﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Sakuno.ING.Composition;
using Sakuno.Net;

namespace Sakuno.ING.Timing.NTP
{
    [Export(typeof(ITimingService), LazyCreate = false)]
    public class NTPService : ITimingService
    {
        private const int NDPPort = 123;
        private const int JapanTimeZoneOffset = 9;
        private static readonly TimeSpan _jstOffset = TimeSpan.FromHours(JapanTimeZoneOffset);

        public bool IsSycned { get; private set; }

        private DateTimeOffset _baseTime;
        private TimeSpan _initialTimestamp;
        private readonly Stopwatch _stopwatch = Stopwatch.StartNew();

        public DateTimeOffset Now => IsSycned ?
            _baseTime + _stopwatch.Elapsed - _initialTimestamp : DateTimeOffset.Now;

        private System.Threading.Timer _timer;

        public NTPService()
        {
            SyncDateTime();
        }

        private void TimerElapsed(object state)
        {
            Elapsed?.Invoke(Now);
        }

        public event Action<DateTimeOffset> Elapsed;

        private async void SyncDateTime()
        {
            var hostnames = new[]
            {
                "jp.pool.ntp.org",
                "pool.ntp.org",
                "us.pool.ntp.org",
                "cn.pool.ntp.org",
                "jp.ntp.org.cn",
                "us.ntp.org.cn",
                "cn.ntp.org.cn",
            };

            foreach (var hostname in hostnames)
            {
                var task = SynchronizeAsync(hostname);

                if (await Task.WhenAny(task, Task.Delay(3000)) == task)
                {
                    _timer = new System.Threading.Timer(TimerElapsed, null, 1000, System.Threading.Timeout.Infinite);

                    IsSycned = true;
                    Console.WriteLine("Date & time synchronized.");
                    return;
                }
            }
        }

        private async Task SynchronizeAsync(string hostname)
        {
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                var addresses = await Dns.GetHostAddressesAsync(hostname);
                var ipEndPoint = new IPEndPoint(addresses[0], NDPPort);

                var context = new SocketAsyncOperationContext() { RemoteEndPoint = ipEndPoint };

                var buffer = new byte[48];
                buffer[0] = 0x1B;

                context.SetBuffer(buffer);

                await socket.SendToAsync(context);
                await socket.ReceiveFromAsync(context);

                var integer = (ulong)buffer[40] << 24 | (ulong)buffer[41] << 16 | (ulong)buffer[42] << 8 | buffer[43];
                var fraction = (ulong)buffer[44] << 24 | (ulong)buffer[45] << 16 | (ulong)buffer[46] << 8 | buffer[47];
                var milliseconds = (long)(integer * 1000 + (fraction >> 20));

                const long TicksOf20thCentury = 599266080000000000;
                const long TicksPerMillisecond = 10000;

                var baseTimestamp = TicksOf20thCentury + milliseconds * TicksPerMillisecond;
                _baseTime = new DateTimeOffset(baseTimestamp, TimeSpan.Zero).ToOffset(_jstOffset);
                _initialTimestamp = _stopwatch.Elapsed;
            }
        }
    }
}
