﻿using System.IO;

namespace Sakuno.KanColle.Amatsukaze
{
    public static class ProductInfo
    {
        public const string AppName = "いんてりじぇんと連装砲くん";
        public const string ProductName = "Intelligent Naval Gun";

        public const string AssemblyVersionString = "0.1.16";

        public static string Version => AssemblyVersionString;
        public static string ReleaseCodeName => "Braindrive";
        public static string ReleaseDate => "2018.5.19";
        public static string ReleaseType => "Alpha";

        public const string UserAgent = "ING/" + AssemblyVersionString;

        public static string RootDirectory { get; } = Path.GetDirectoryName(typeof(ProductInfo).Assembly.Location);
    }
}
