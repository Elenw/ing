//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Sakuno.ING.Game.Models.MasterData;

namespace Sakuno.ING.Game.Models
{
    public partial class Equipment : Calculated<EquipmentId, IRawEquipment>
    {
        public Equipment(EquipmentId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public Equipment(IRawEquipment raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private EquipmentInfo _info;
        public EquipmentInfo Info
        {
            get => _info;
            internal set => Set(ref _info, value);
        }

        private bool _isLocked;
        public bool IsLocked
        {
            get => _isLocked;
            internal set => Set(ref _isLocked, value);
        }

        private int _improvementLevel;
        public int ImprovementLevel
        {
            get => _improvementLevel;
            internal set => Set(ref _improvementLevel, value);
        }

        private int _airProficiency;
        public int AirProficiency
        {
            get => _airProficiency;
            internal set => Set(ref _airProficiency, value);
        }

        private bool _isAvailable;
        public bool IsAvailable
        {
            get => _isAvailable;
            internal set => Set(ref _isAvailable, value);
        }

        public event Action<Equipment, IRawEquipment, DateTimeOffset> Updating;
        public override void Update(IRawEquipment raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawEquipment raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            IsLocked = raw.IsLocked;
            ImprovementLevel = raw.ImprovementLevel;
            AirProficiency = raw.AirProficiency;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawEquipment raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class BuildingDock : Calculated<BuildingDockId, IRawBuildingDock>
    {
        public BuildingDock(BuildingDockId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public BuildingDock(IRawBuildingDock raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private DateTimeOffset _completionTime;
        public DateTimeOffset CompletionTime
        {
            get => _completionTime;
            internal set => Set(ref _completionTime, value);
        }

        private BuildingDockState _state;
        public BuildingDockState State
        {
            get => _state;
            internal set => Set(ref _state, value);
        }

        private Materials _consumption;
        public Materials Consumption
        {
            get => _consumption;
            internal set => Set(ref _consumption, value);
        }

        private ShipInfo _builtShip;
        public ShipInfo BuiltShip
        {
            get => _builtShip;
            internal set => Set(ref _builtShip, value);
        }

        private bool _isLSC;
        public bool IsLSC
        {
            get => _isLSC;
            internal set => Set(ref _isLSC, value);
        }

        private TimeSpan _timeRemaining;
        public TimeSpan TimeRemaining
        {
            get => _timeRemaining;
            internal set => Set(ref _timeRemaining, value);
        }

        public event Action<BuildingDock, IRawBuildingDock, DateTimeOffset> Updating;
        public override void Update(IRawBuildingDock raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawBuildingDock raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            CompletionTime = raw.CompletionTime;
            State = raw.State;
            Consumption = raw.Consumption;
            IsLSC = raw.IsLSC;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawBuildingDock raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class RepairingDock : Calculated<RepairingDockId, IRawRepairingDock>
    {
        public RepairingDock(RepairingDockId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public RepairingDock(IRawRepairingDock raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private RepairingDockState _state;
        public RepairingDockState State
        {
            get => _state;
            internal set => Set(ref _state, value);
        }

        private DateTimeOffset _completionTime;
        public DateTimeOffset CompletionTime
        {
            get => _completionTime;
            internal set => Set(ref _completionTime, value);
        }

        private Materials _consumption;
        public Materials Consumption
        {
            get => _consumption;
            internal set => Set(ref _consumption, value);
        }

        private TimeSpan _timeRemaining;
        public TimeSpan TimeRemaining
        {
            get => _timeRemaining;
            internal set => Set(ref _timeRemaining, value);
        }

        public event Action<RepairingDock, IRawRepairingDock, DateTimeOffset> Updating;
        public override void Update(IRawRepairingDock raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawRepairingDock raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            State = raw.State;
            CompletionTime = raw.CompletionTime;
            Consumption = raw.Consumption;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawRepairingDock raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class UseItemCount : Calculated<UseItemId, IRawUseItemCount>
    {
        public UseItemCount(UseItemId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public UseItemCount(IRawUseItemCount raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private UseItemInfo _item;
        public UseItemInfo Item
        {
            get => _item;
            internal set => Set(ref _item, value);
        }

        private int _count;
        public int Count
        {
            get => _count;
            internal set => Set(ref _count, value);
        }

        public event Action<UseItemCount, IRawUseItemCount, DateTimeOffset> Updating;
        public override void Update(IRawUseItemCount raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawUseItemCount raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            Count = raw.Count;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawUseItemCount raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class Admiral : Calculated<int, IRawAdmiral>
    {
        public Admiral(int id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public Admiral(IRawAdmiral raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private string _name;
        public string Name
        {
            get => _name;
            internal set => Set(ref _name, value);
        }

        private Leveling _leveling;
        public Leveling Leveling
        {
            get => _leveling;
            internal set => Set(ref _leveling, value);
        }

        private AdmiralRank _rank;
        public AdmiralRank Rank
        {
            get => _rank;
            internal set => Set(ref _rank, value);
        }

        private string _comment;
        public string Comment
        {
            get => _comment;
            internal set => Set(ref _comment, value);
        }

        private int _maxShipCount;
        public int MaxShipCount
        {
            get => _maxShipCount;
            internal set => Set(ref _maxShipCount, value);
        }

        private int _maxEquipmentCount;
        public int MaxEquipmentCount
        {
            get => _maxEquipmentCount;
            internal set => Set(ref _maxEquipmentCount, value);
        }

        private BattleStat _battleStat;
        public BattleStat BattleStat
        {
            get => _battleStat;
            internal set => Set(ref _battleStat, value);
        }

        private BattleStat _practiceStat;
        public BattleStat PracticeStat
        {
            get => _practiceStat;
            internal set => Set(ref _practiceStat, value);
        }

        private ExpeditionStat _expeditionStat;
        public ExpeditionStat ExpeditionStat
        {
            get => _expeditionStat;
            internal set => Set(ref _expeditionStat, value);
        }

        private bool _canLSC;
        public bool CanLSC
        {
            get => _canLSC;
            internal set => Set(ref _canLSC, value);
        }

        private int _maxMaterial;
        public int MaxMaterial
        {
            get => _maxMaterial;
            internal set => Set(ref _maxMaterial, value);
        }

        public event Action<Admiral, IRawAdmiral, DateTimeOffset> Updating;
        public override void Update(IRawAdmiral raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawAdmiral raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            Name = raw.Name;
            Leveling = raw.Leveling;
            Rank = raw.Rank;
            Comment = raw.Comment;
            MaxShipCount = raw.MaxShipCount;
            MaxEquipmentCount = raw.MaxEquipmentCount;
            BattleStat = raw.BattleStat;
            PracticeStat = raw.PracticeStat;
            ExpeditionStat = raw.ExpeditionStat;
            CanLSC = raw.CanLSC;
            MaxMaterial = raw.MaxMaterial;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawAdmiral raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class Ship : Calculated<ShipId, IRawShip>
    {
        public Ship(ShipId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public Ship(IRawShip raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private ShipInfo _info;
        public ShipInfo Info
        {
            get => _info;
            internal set => Set(ref _info, value);
        }

        private Leveling _leveling;
        public Leveling Leveling
        {
            get => _leveling;
            internal set => Set(ref _leveling, value);
        }

        private ClampedValue _hP;
        public ClampedValue HP
        {
            get => _hP;
            internal set => Set(ref _hP, value);
        }

        private ShipSpeed _speed;
        public ShipSpeed Speed
        {
            get => _speed;
            internal set => Set(ref _speed, value);
        }

        private FireRange _fireRange;
        public FireRange FireRange
        {
            get => _fireRange;
            internal set => Set(ref _fireRange, value);
        }

        private int _slotCount;
        public int SlotCount
        {
            get => _slotCount;
            internal set => Set(ref _slotCount, value);
        }

        private Slot _extraSlot;
        public Slot ExtraSlot
        {
            get => _extraSlot;
            internal set => Set(ref _extraSlot, value);
        }

        private ClampedValue _fuel;
        public ClampedValue Fuel
        {
            get => _fuel;
            internal set => Set(ref _fuel, value);
        }

        private ClampedValue _bullet;
        public ClampedValue Bullet
        {
            get => _bullet;
            internal set => Set(ref _bullet, value);
        }

        private TimeSpan _repairingTime;
        public TimeSpan RepairingTime
        {
            get => _repairingTime;
            internal set => Set(ref _repairingTime, value);
        }

        private Materials _repairingCost;
        public Materials RepairingCost
        {
            get => _repairingCost;
            internal set => Set(ref _repairingCost, value);
        }

        private int _morale;
        public int Morale
        {
            get => _morale;
            internal set => Set(ref _morale, value);
        }

        private ShipMordenizationStatus _firepower;
        public ShipMordenizationStatus Firepower
        {
            get => _firepower;
            internal set => Set(ref _firepower, value);
        }

        private ShipMordenizationStatus _torpedo;
        public ShipMordenizationStatus Torpedo
        {
            get => _torpedo;
            internal set => Set(ref _torpedo, value);
        }

        private ShipMordenizationStatus _antiAir;
        public ShipMordenizationStatus AntiAir
        {
            get => _antiAir;
            internal set => Set(ref _antiAir, value);
        }

        private ShipMordenizationStatus _armor;
        public ShipMordenizationStatus Armor
        {
            get => _armor;
            internal set => Set(ref _armor, value);
        }

        private ShipMordenizationStatus _evasion;
        public ShipMordenizationStatus Evasion
        {
            get => _evasion;
            internal set => Set(ref _evasion, value);
        }

        private ShipMordenizationStatus _antiSubmarine;
        public ShipMordenizationStatus AntiSubmarine
        {
            get => _antiSubmarine;
            internal set => Set(ref _antiSubmarine, value);
        }

        private ShipMordenizationStatus _lightOfSight;
        public ShipMordenizationStatus LightOfSight
        {
            get => _lightOfSight;
            internal set => Set(ref _lightOfSight, value);
        }

        private ShipMordenizationStatus _luck;
        public ShipMordenizationStatus Luck
        {
            get => _luck;
            internal set => Set(ref _luck, value);
        }

        private bool _isLocked;
        public bool IsLocked
        {
            get => _isLocked;
            internal set => Set(ref _isLocked, value);
        }

        private int? _shipLockingTag;
        public int? ShipLockingTag
        {
            get => _shipLockingTag;
            internal set => Set(ref _shipLockingTag, value);
        }

        private bool _isRepairing;
        public bool IsRepairing
        {
            get => _isRepairing;
            internal set => Set(ref _isRepairing, value);
        }

        public event Action<Ship, IRawShip, DateTimeOffset> Updating;
        public override void Update(IRawShip raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawShip raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            Leveling = raw.Leveling;
            HP = raw.HP;
            Speed = raw.Speed;
            FireRange = raw.FireRange;
            RepairingTime = raw.RepairingTime;
            RepairingCost = raw.RepairingCost;
            Morale = raw.Morale;
            IsLocked = raw.IsLocked;
            ShipLockingTag = raw.ShipLockingTag;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawShip raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class Fleet : Calculated<FleetId, IRawFleet>
    {
        public Fleet(FleetId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public Fleet(IRawFleet raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private string _name;
        public string Name
        {
            get => _name;
            internal set => Set(ref _name, value);
        }

        private FleetExpeditionState _expeditionState;
        public FleetExpeditionState ExpeditionState
        {
            get => _expeditionState;
            internal set => Set(ref _expeditionState, value);
        }

        private ExpeditionInfo _expedition;
        public ExpeditionInfo Expedition
        {
            get => _expedition;
            internal set => Set(ref _expedition, value);
        }

        private DateTimeOffset _expeditionCompletionTime;
        public DateTimeOffset ExpeditionCompletionTime
        {
            get => _expeditionCompletionTime;
            internal set => Set(ref _expeditionCompletionTime, value);
        }

        private TimeSpan _expeditionTimeRemaining;
        public TimeSpan ExpeditionTimeRemaining
        {
            get => _expeditionTimeRemaining;
            internal set => Set(ref _expeditionTimeRemaining, value);
        }

        public event Action<Fleet, IRawFleet, DateTimeOffset> Updating;
        public override void Update(IRawFleet raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawFleet raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            Name = raw.Name;
            ExpeditionState = raw.ExpeditionState;
            ExpeditionCompletionTime = raw.ExpeditionCompletionTime;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawFleet raw, DateTimeOffset timeStamp);
        partial void CreateDummy();

        private readonly BindableSnapshotCollection<Ship> ships = new BindableSnapshotCollection<Ship>();
        public IReadOnlyList<Ship> Ships => ships;
    }
    public partial class Quest : Calculated<QuestId, IRawQuest>
    {
        public Quest(QuestId id, QuestManager owner) : base(id)
        {
            this.owner = owner;
            Name.Translation = owner.Localization?.GetLocalized("QuestName", id.ToString());
            Description.Translation = owner.Localization?.GetLocalized("QuestDesc", id.ToString());
            CreateDummy();
        }

        public Quest(IRawQuest raw, QuestManager owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly QuestManager owner;

        public TextTranslationGroup Name { get; } = new TextTranslationGroup();

        public TextTranslationGroup Description { get; } = new TextTranslationGroup();

        private QuestCategoty _category;
        public QuestCategoty Category
        {
            get => _category;
            internal set => Set(ref _category, value);
        }

        private QuestPeriod _period;
        public QuestPeriod Period
        {
            get => _period;
            internal set => Set(ref _period, value);
        }

        private QuestState _state;
        public QuestState State
        {
            get => _state;
            internal set => Set(ref _state, value);
        }

        private QuestProgress _progress;
        public QuestProgress Progress
        {
            get => _progress;
            internal set => Set(ref _progress, value);
        }

        private Materials _rewards;
        public Materials Rewards
        {
            get => _rewards;
            internal set => Set(ref _rewards, value);
        }

        public event Action<Quest, IRawQuest, DateTimeOffset> Updating;
        public override void Update(IRawQuest raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawQuest raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            if (raw.Name != Name.Origin)
            {
                Name.Origin = raw.Name;
                NotifyPropertyChanged(nameof(Name));
            }

            if (raw.Description != Description.Origin)
            {
                Description.Origin = raw.Description;
                NotifyPropertyChanged(nameof(Description));
            }

            Category = raw.Category;
            Period = raw.Period;
            State = raw.State;
            Progress = raw.Progress;
            Rewards = raw.Rewards;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawQuest raw, DateTimeOffset timeStamp);
        partial void CreateDummy();

        public override string ToString() => $"Quest {Id}: {Name.Origin}";
    }
    public partial class Map : Calculated<MapId, IRawMap>
    {
        public Map(MapId id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public Map(IRawMap raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private MapInfo _info;
        public MapInfo Info
        {
            get => _info;
            internal set => Set(ref _info, value);
        }

        private bool _isCleared;
        public bool IsCleared
        {
            get => _isCleared;
            internal set => Set(ref _isCleared, value);
        }

        private EventMapRank? _rank;
        public EventMapRank? Rank
        {
            get => _rank;
            internal set => Set(ref _rank, value);
        }

        private int? _gaugeIndex;
        public int? GaugeIndex
        {
            get => _gaugeIndex;
            internal set => Set(ref _gaugeIndex, value);
        }

        private EventMapGaugeType? _gaugeType;
        public EventMapGaugeType? GaugeType
        {
            get => _gaugeType;
            internal set => Set(ref _gaugeType, value);
        }

        private int _availableAirForceGroups;
        public int AvailableAirForceGroups
        {
            get => _availableAirForceGroups;
            internal set => Set(ref _availableAirForceGroups, value);
        }

        private ClampedValue _gauge;
        public ClampedValue Gauge
        {
            get => _gauge;
            internal set => Set(ref _gauge, value);
        }

        public event Action<Map, IRawMap, DateTimeOffset> Updating;
        public override void Update(IRawMap raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawMap raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            IsCleared = raw.IsCleared;
            Rank = raw.Rank;
            GaugeIndex = raw.GaugeIndex;
            GaugeType = raw.GaugeType;
            AvailableAirForceGroups = raw.AvailableAirForceGroups;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawMap raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
    public partial class AirForceSquadron : Calculated<int, IRawAirForceSquadron>
    {
        public AirForceSquadron(int id, NavalBase owner) : base(id)
        {
            this.owner = owner;
            CreateDummy();
        }

        public AirForceSquadron(IRawAirForceSquadron raw, NavalBase owner, DateTimeOffset timeStamp) : this(raw.Id, owner) => UpdateProps(raw, timeStamp);

        private readonly NavalBase owner;

        private Equipment _equipment;
        public Equipment Equipment
        {
            get => _equipment;
            internal set => Set(ref _equipment, value);
        }

        private ClampedValue _aircraftCount;
        public ClampedValue AircraftCount
        {
            get => _aircraftCount;
            internal set => Set(ref _aircraftCount, value);
        }

        private SquadronMorale _morale;
        public SquadronMorale Morale
        {
            get => _morale;
            internal set => Set(ref _morale, value);
        }

        public event Action<AirForceSquadron, IRawAirForceSquadron, DateTimeOffset> Updating;
        public override void Update(IRawAirForceSquadron raw, DateTimeOffset timeStamp)
        {
            Updating?.Invoke(this, raw, timeStamp);
            UpdateProps(raw, timeStamp);
        }

        private void UpdateProps(IRawAirForceSquadron raw, DateTimeOffset timeStamp)
        {
            UpdationTime = timeStamp;

            AircraftCount = raw.AircraftCount;
            Morale = raw.Morale;

            UpdateCore(raw, timeStamp);
        }

        partial void UpdateCore(IRawAirForceSquadron raw, DateTimeOffset timeStamp);
        partial void CreateDummy();
    }
}
