public enum EntityHandling // TypeDefIndex: 1838
{	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;

}

public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 5765
{	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsWeak() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	internal void set_IsWeak(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Tag(string value) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1087D40 Offset: 0x1086340 VA: 0x181087D40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1087E00 Offset: 0x1086400 VA: 0x181087E00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10881E0 Offset: 0x10867E0 VA: 0x1810881E0
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x1087EA0 Offset: 0x10864A0 VA: 0x181087EA0
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1088150 Offset: 0x1086750 VA: 0x181088150
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x1087E50 Offset: 0x1086450 VA: 0x181087E50 Slot: 3
	public override string ToString() { }

	// RVA: 0x10882E0 Offset: 0x10868E0 VA: 0x1810882E0
	private static void .cctor() { }

}

public class Entity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6291
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public BaseNetworkable baseNetworkable; // 0x18
	public BaseEntity baseEntity; // 0x20
	public BasePlayer basePlayer; // 0x28
	public WorldItem worldItem; // 0x30
	public BaseResource resource; // 0x38
	public BuildingBlock buildingBlock; // 0x40
	public Environment environment; // 0x48
	public Corpse corpse; // 0x50
	public ParentInfo parent; // 0x58
	public KeyLock keyLock; // 0x60
	public CodeLock codeLock; // 0x68
	public EntitySlots entitySlots; // 0x70
	public BuildingPrivilege buildingPrivilege; // 0x78
	public StorageBox storageBox; // 0x80
	public HeldEntity heldEntity; // 0x88
	public BaseProjectile baseProjectile; // 0x90
	public BaseNPC baseNPC; // 0x98
	public Loot loot; // 0xA0
	public GenericSpawner genericSpawner; // 0xA8
	public SleepingBag sleepingBag; // 0xB0
	public LootableCorpse lootableCorpse; // 0xB8
	public Sign sign; // 0xC0
	public BaseCombat baseCombat; // 0xC8
	public MapEntity mapEntity; // 0xD0
	public ResearchTable researchTable; // 0xD8
	public DudExplosive dudExplosive; // 0xE0
	public MiningQuarry miningQuarry; // 0xE8
	public BaseVehicle baseVehicle; // 0xF0
	public Helicopter helicopter; // 0xF8
	public Landmine landmine; // 0x100
	public AutoTurret autoturret; // 0x108
	public SphereEntity sphereEntity; // 0x110
	public StabilityEntity stabilityEntity; // 0x118
	public OwnerInfo ownerInfo; // 0x120
	public DecayEntity decayEntity; // 0x128
	public Spawnable spawnable; // 0x130
	public ServerGib servergib; // 0x138
	public VendingMachine vendingMachine; // 0x140
	public SpinnerWheel spinnerWheel; // 0x148
	public Lift lift; // 0x150
	public BradleyAPC bradley; // 0x158
	public WaterWell waterwell; // 0x160
	public Motorboat motorBoat; // 0x168
	public IOEntity ioEntity; // 0x170
	public PuzzleReset puzzleReset; // 0x178
	public RelationshipManager relationshipManager; // 0x180
	public HotAirBalloon hotAirBalloon; // 0x188
	public SAMSite samSite; // 0x190
	public EggHunt eggHunt; // 0x198
	public ArcadeMachine arcadeMachine; // 0x1A0
	public Minicopter miniCopter; // 0x1A8
	public Horse horse; // 0x1B0
	public SmartAlarm smartAlarm; // 0x1B8
	public LightString lightString; // 0x1C0
	public LightDeployer lightDeployer; // 0x1C8
	public RCEntity rcEntity; // 0x1D0
	public ComputerStation computerStation; // 0x1D8
	public GrowableEntity growableEntity; // 0x1E0
	public Composter composter; // 0x1E8
	public ModularVehicle modularVehicle; // 0x1F0
	public ModularCar modularCar; // 0x1F8
	public SimpleUID simpleUID; // 0x200
	public VehicleLift vehicleLift; // 0x208
	public EngineStorage engineStorage; // 0x210
	public VehicleVendor vehicleVendor; // 0x218
	public WaterPool WaterPool; // 0x220
	public Photo photo; // 0x228
	public PhotoFrame photoFrame; // 0x230
	public VehicleModule vehicleModule; // 0x238
	public MixingTable mixingTable; // 0x240
	public ShopKeeper shopKeeper; // 0x248
	public Elevator elevator; // 0x250
	public SkullTrophy skullTrophy; // 0x258
	public Cassette cassette; // 0x260
	public Telephone telephone; // 0x268
	public BoomBox boomBox; // 0x270
	public NeonSign neonSign; // 0x278
	public SubEntityList subEntityList; // 0x280
	public MarketTerminal marketTerminal; // 0x288
	public DeliveryDrone deliveryDrone; // 0x290
	public ReclaimTerminal reclaimTerminal; // 0x298
	public SlotMachine slotMachine; // 0x2A0
	public TrainEngine trainEngine; // 0x2A8
	public CardTable cardTable; // 0x2B0
	public Crane crane; // 0x2B8
	public ConnectedSpeaker connectedSpeaker; // 0x2C0
	public AudioEntity audioEntity; // 0x2C8
	public MicrophoneStand microphoneStand; // 0x2D0
	public Submarine submarine; // 0x2D8
	public SleepingBagCamper sleepingBagCamper; // 0x2E0
	public CamperModule camperModule; // 0x2E8
	public PaintableSign paintableSign; // 0x2F0
	public Whitelist whitelist; // 0x2F8
	public FrankensteinTable FrankensteinTable; // 0x300
	public MLRS mlrs; // 0x308
	public ReclaimManager reclaimManager; // 0x310
	public GameMode gameMode; // 0x318
	public Snowmobile snowmobile; // 0x320
	public bool createdThisFrame; // 0x328
	public PatternFirework patternFirework; // 0x330
	public CargoPlane cargoPlane; // 0x338
	public PaintedItem paintedItem; // 0x340
	public Spray spray; // 0x348
	public BaseTrain baseTrain; // 0x350
	public Zipline zipline; // 0x358
	public ZiplineMountable ziplineMountable; // 0x360
	public ZiplineArrivalPoint ZiplineArrival; // 0x368
	public SprayLine sprayLine; // 0x370
	public CoalingTower coalingTower; // 0x378
	public SimpleFloat simpleFloat; // 0x380

	// Methods

	// RVA: 0x10A5B60 Offset: 0x10A4160 VA: 0x1810A5B60
	public static void ResetToPool(Entity instance) { }

	// RVA: 0x10A7720 Offset: 0x10A5D20 VA: 0x1810A7720
	public void ResetToPool() { }

	// RVA: 0x10A5A80 Offset: 0x10A4080 VA: 0x1810A5A80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x109C420 Offset: 0x109AA20 VA: 0x18109C420
	public void CopyTo(Entity instance) { }

	// RVA: 0x109E270 Offset: 0x109C870 VA: 0x18109E270
	public Entity Copy() { }

	// RVA: 0x10A5A00 Offset: 0x10A4000 VA: 0x1810A5A00
	public static Entity Deserialize(Stream stream) { }

	// RVA: 0x10A09E0 Offset: 0x109EFE0 VA: 0x1810A09E0
	public static Entity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x10A0A60 Offset: 0x109F060 VA: 0x1810A0A60
	public static Entity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x10A57E0 Offset: 0x10A3DE0 VA: 0x1810A57E0
	public static Entity Deserialize(byte[] buffer) { }

	// RVA: 0x10A5B10 Offset: 0x10A4110 VA: 0x1810A5B10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x10B4F70 Offset: 0x10B3570 VA: 0x1810B4F70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x10B4F90 Offset: 0x10B3590 VA: 0x1810B4F90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Entity previous) { }

	// RVA: 0x10A5B40 Offset: 0x10A4140 VA: 0x1810A5B40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x10A5900 Offset: 0x10A3F00 VA: 0x1810A5900
	public static Entity Deserialize(byte[] buffer, Entity instance, bool isDelta = False) { }

	// RVA: 0x10A31C0 Offset: 0x10A17C0 VA: 0x1810A31C0
	public static Entity Deserialize(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x109E2F0 Offset: 0x109C8F0 VA: 0x18109E2F0
	public static Entity DeserializeLengthDelimited(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x10A0AF0 Offset: 0x109F0F0 VA: 0x1810A0AF0
	public static Entity DeserializeLength(Stream stream, int length, Entity instance, bool isDelta) { }

	// RVA: 0x10A7730 Offset: 0x10A5D30 VA: 0x1810A7730
	public static void SerializeDelta(Stream stream, Entity instance, Entity previous) { }

	// RVA: 0x10AE7C0 Offset: 0x10ACDC0 VA: 0x1810AE7C0
	public static void Serialize(Stream stream, Entity instance) { }

	// RVA: 0x10B4F60 Offset: 0x10B3560 VA: 0x1810B4F60
	public byte[] ToProtoBytes() { }

	// RVA: 0x10B4F70 Offset: 0x10B3570 VA: 0x1810B4F70
	public void ToProto(Stream stream) { }

	// RVA: 0x10AE6B0 Offset: 0x10ACCB0 VA: 0x1810AE6B0
	public static byte[] SerializeToBytes(Entity instance) { }

	// RVA: 0x10AE600 Offset: 0x10ACC00 VA: 0x1810AE600
	public static void SerializeLengthDelimited(Stream stream, Entity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class EntitySlots : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6296
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint slotLock; // 0x14
	public uint slotFireMod; // 0x18
	public uint slotUpperModification; // 0x1C
	public uint centerDecoration; // 0x20
	public uint lowerCenterDecoration; // 0x24
	public uint storageMonitor; // 0x28

	// Methods

	// RVA: 0x1D55BB0 Offset: 0x1D541B0 VA: 0x181D55BB0
	public static void ResetToPool(EntitySlots instance) { }

	// RVA: 0x1D55C70 Offset: 0x1D54270 VA: 0x181D55C70
	public void ResetToPool() { }

	// RVA: 0x1D554A0 Offset: 0x1D53AA0 VA: 0x181D554A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB230 Offset: 0x1BF9830 VA: 0x181BFB230
	public void CopyTo(EntitySlots instance) { }

	// RVA: 0x1D53D10 Offset: 0x1D52310 VA: 0x181D53D10
	public EntitySlots Copy() { }

	// RVA: 0x1D54840 Offset: 0x1D52E40 VA: 0x181D54840
	public static EntitySlots Deserialize(Stream stream) { }

	// RVA: 0x1D54100 Offset: 0x1D52700 VA: 0x181D54100
	public static EntitySlots DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D544C0 Offset: 0x1D52AC0 VA: 0x181D544C0
	public static EntitySlots DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D54DA0 Offset: 0x1D533A0 VA: 0x181D54DA0
	public static EntitySlots Deserialize(byte[] buffer) { }

	// RVA: 0x1D555E0 Offset: 0x1D53BE0 VA: 0x181D555E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D56350 Offset: 0x1D54950 VA: 0x181D56350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D56370 Offset: 0x1D54970 VA: 0x181D56370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntitySlots previous) { }

	// RVA: 0x1D55870 Offset: 0x1D53E70 VA: 0x181D55870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D55130 Offset: 0x1D53730 VA: 0x181D55130
	public static EntitySlots Deserialize(byte[] buffer, EntitySlots instance, bool isDelta = False) { }

	// RVA: 0x1D54B10 Offset: 0x1D53110 VA: 0x181D54B10
	public static EntitySlots Deserialize(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D53DA0 Offset: 0x1D523A0 VA: 0x181D53DA0
	public static EntitySlots DeserializeLengthDelimited(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D54180 Offset: 0x1D52780 VA: 0x181D54180
	public static EntitySlots DeserializeLength(Stream stream, int length, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D55D30 Offset: 0x1D54330 VA: 0x181D55D30
	public static void SerializeDelta(Stream stream, EntitySlots instance, EntitySlots previous) { }

	// RVA: 0x1D561B0 Offset: 0x1D547B0 VA: 0x181D561B0
	public static void Serialize(Stream stream, EntitySlots instance) { }

	// RVA: 0x1D56340 Offset: 0x1D54940 VA: 0x181D56340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D56350 Offset: 0x1D54950 VA: 0x181D56350
	public void ToProto(Stream stream) { }

	// RVA: 0x1D560A0 Offset: 0x1D546A0 VA: 0x181D560A0
	public static byte[] SerializeToBytes(EntitySlots instance) { }

	// RVA: 0x1D55FF0 Offset: 0x1D545F0 VA: 0x181D55FF0
	public static void SerializeLengthDelimited(Stream stream, EntitySlots instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6481
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Entity> entity; // 0x18

	// Methods

	// RVA: 0x1D53590 Offset: 0x1D51B90 VA: 0x181D53590
	public static void ResetToPool(EntityList instance) { }

	// RVA: 0x1D533E0 Offset: 0x1D519E0 VA: 0x181D533E0
	public void ResetToPool() { }

	// RVA: 0x1D53160 Offset: 0x1D51760 VA: 0x181D53160 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D524C0 Offset: 0x1D50AC0 VA: 0x181D524C0
	public void CopyTo(EntityList instance) { }

	// RVA: 0x1D525F0 Offset: 0x1D50BF0 VA: 0x181D525F0
	public EntityList Copy() { }

	// RVA: 0x1D52FC0 Offset: 0x1D515C0 VA: 0x181D52FC0
	public static EntityList Deserialize(Stream stream) { }

	// RVA: 0x1D529D0 Offset: 0x1D50FD0 VA: 0x181D529D0
	public static EntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D52CA0 Offset: 0x1D512A0 VA: 0x181D52CA0
	public static EntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D53040 Offset: 0x1D51640 VA: 0x181D53040
	public static EntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1D533A0 Offset: 0x1D519A0 VA: 0x181D533A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D53CD0 Offset: 0x1D522D0 VA: 0x181D53CD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D53CF0 Offset: 0x1D522F0 VA: 0x181D53CF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityList previous) { }

	// RVA: 0x1D533C0 Offset: 0x1D519C0 VA: 0x181D533C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D52D30 Offset: 0x1D51330 VA: 0x181D52D30
	public static EntityList Deserialize(byte[] buffer, EntityList instance, bool isDelta = False) { }

	// RVA: 0x1D52E30 Offset: 0x1D51430 VA: 0x181D52E30
	public static EntityList Deserialize(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D52760 Offset: 0x1D50D60 VA: 0x181D52760
	public static EntityList DeserializeLengthDelimited(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D52A50 Offset: 0x1D51050 VA: 0x181D52A50
	public static EntityList DeserializeLength(Stream stream, int length, EntityList instance, bool isDelta) { }

	// RVA: 0x1D53740 Offset: 0x1D51D40 VA: 0x181D53740
	public static void SerializeDelta(Stream stream, EntityList instance, EntityList previous) { }

	// RVA: 0x1D53AE0 Offset: 0x1D520E0 VA: 0x181D53AE0
	public static void Serialize(Stream stream, EntityList instance) { }

	// RVA: 0x1D53CC0 Offset: 0x1D522C0 VA: 0x181D53CC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D53CD0 Offset: 0x1D522D0 VA: 0x181D53CD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D539D0 Offset: 0x1D51FD0 VA: 0x181D539D0
	public static byte[] SerializeToBytes(EntityList instance) { }

	// RVA: 0x1D53920 Offset: 0x1D51F20 VA: 0x181D53920
	public static void SerializeLengthDelimited(Stream stream, EntityList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6504
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> entityIds; // 0x18

	// Methods

	// RVA: 0x1D51E10 Offset: 0x1D50410 VA: 0x181D51E10
	public static void ResetToPool(EntityIdList instance) { }

	// RVA: 0x1D51D30 Offset: 0x1D50330 VA: 0x181D51D30
	public void ResetToPool() { }

	// RVA: 0x1D51BA0 Offset: 0x1D501A0 VA: 0x181D51BA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D50EB0 Offset: 0x1D4F4B0 VA: 0x181D50EB0
	public void CopyTo(EntityIdList instance) { }

	// RVA: 0x1D50FD0 Offset: 0x1D4F5D0 VA: 0x181D50FD0
	public EntityIdList Copy() { }

	// RVA: 0x1D51B20 Offset: 0x1D50120 VA: 0x181D51B20
	public static EntityIdList Deserialize(Stream stream) { }

	// RVA: 0x1D513C0 Offset: 0x1D4F9C0 VA: 0x181D513C0
	public static EntityIdList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D51440 Offset: 0x1D4FA40 VA: 0x181D51440
	public static EntityIdList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D51740 Offset: 0x1D4FD40 VA: 0x181D51740
	public static EntityIdList Deserialize(byte[] buffer) { }

	// RVA: 0x1D51CF0 Offset: 0x1D502F0 VA: 0x181D51CF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D52340 Offset: 0x1D50940 VA: 0x181D52340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D52360 Offset: 0x1D50960 VA: 0x181D52360 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityIdList previous) { }

	// RVA: 0x1D51D10 Offset: 0x1D50310 VA: 0x181D51D10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D51A20 Offset: 0x1D50020 VA: 0x181D51A20
	public static EntityIdList Deserialize(byte[] buffer, EntityIdList instance, bool isDelta = False) { }

	// RVA: 0x1D51860 Offset: 0x1D4FE60 VA: 0x181D51860
	public static EntityIdList Deserialize(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51130 Offset: 0x1D4F730 VA: 0x181D51130
	public static EntityIdList DeserializeLengthDelimited(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D514D0 Offset: 0x1D4FAD0 VA: 0x181D514D0
	public static EntityIdList DeserializeLength(Stream stream, int length, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51EF0 Offset: 0x1D504F0 VA: 0x181D51EF0
	public static void SerializeDelta(Stream stream, EntityIdList instance, EntityIdList previous) { }

	// RVA: 0x1D521F0 Offset: 0x1D507F0 VA: 0x181D521F0
	public static void Serialize(Stream stream, EntityIdList instance) { }

	// RVA: 0x1D52330 Offset: 0x1D50930 VA: 0x181D52330
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D52340 Offset: 0x1D50940 VA: 0x181D52340
	public void ToProto(Stream stream) { }

	// RVA: 0x1D520E0 Offset: 0x1D506E0 VA: 0x181D520E0
	public static byte[] SerializeToBytes(EntityIdList instance) { }

	// RVA: 0x1D52030 Offset: 0x1D50630 VA: 0x181D52030
	public static void SerializeLengthDelimited(Stream stream, EntityIdList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public static class Entity // TypeDefIndex: 6628
{	// Fields
	private static Dictionary<Transform, IEntity> _dict; // 0x3736

	// Methods

	// RVA: 0x1BA2C50 Offset: 0x1BA1250 VA: 0x181BA2C50
	public static void Register(Transform t, IEntity entity) { }

	// RVA: 0x1BA2BC0 Offset: 0x1BA11C0 VA: 0x181BA2BC0
	public static IEntity Get(Transform t) { }

	// RVA: 0x1BA2E90 Offset: 0x1BA1490 VA: 0x181BA2E90
	public static void Unregister(Transform t) { }

	// RVA: 0x1BA2CE0 Offset: 0x1BA12E0 VA: 0x181BA2CE0
	public static void Register(GameObject obj, IEntity entity) { }

	// RVA: 0x1BA2AD0 Offset: 0x1BA10D0 VA: 0x181BA2AD0
	public static IEntity Get(GameObject obj) { }

	// RVA: 0x1BA2DC0 Offset: 0x1BA13C0 VA: 0x181BA2DC0
	public static void Unregister(GameObject obj) { }

	// RVA: 0x1BA2F10 Offset: 0x1BA1510 VA: 0x181BA2F10
	private static void .cctor() { }

}

public enum EntityType // TypeDefIndex: 9426
{	// Fields
	public int value__; // 0x0
	public const EntityType Player = 1;
	public const EntityType NPC = 2;
	public const EntityType WorldItem = 4;
	public const EntityType Corpse = 8;
	public const EntityType TimedExplosive = 16;
	public const EntityType Chair = 32;
	public const EntityType BasePlayerNPC = 64;

}

public class EntityCollisionMessage : EntityComponent<BaseEntity> // TypeDefIndex: 9487
{	// Methods

	// RVA: 0x8C3D10 Offset: 0x8C2310 VA: 0x1808C3D10
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x8C3EC0 Offset: 0x8C24C0 VA: 0x1808C3EC0
	public void .ctor() { }

}

public class EntityComponent<T> : EntityComponentBase // TypeDefIndex: 9488
{	// Fields
	private T _baseEntity; // 0x0

	// Properties
	protected T baseEntity { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected T get_baseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6AB0 Offset: 0x15E50B0 VA: 0x1815E6AB0
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	// RVA: -1 Offset: -1
	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6930 Offset: 0x15E4F30 VA: 0x1815E6930
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override BaseEntity GetBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355EA0 Offset: 0x13544A0 VA: 0x181355EA0
	|-EntityComponent<BaseAnimalNPC>.GetBaseEntity
	|-EntityComponent<BaseEntity>.GetBaseEntity
	|-EntityComponent<BaseFishNPC>.GetBaseEntity
	|-EntityComponent<BasePet>.GetBaseEntity
	|-EntityComponent<BasePlayer>.GetBaseEntity
	|-EntityComponent<CH47HelicopterAIController>.GetBaseEntity
	|-EntityComponent<HumanNPC>.GetBaseEntity
	|-EntityComponent<ScarecrowNPC>.GetBaseEntity
	|-EntityComponent<object>.GetBaseEntity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6A90 Offset: 0x15E5090 VA: 0x1815E6A90
	|-EntityComponent<BaseEntity>..ctor
	|-EntityComponent<BasePlayer>..ctor
	|-EntityComponent<object>..ctor
	*/

}

public class EntityComponentBase : BaseMonoBehaviour // TypeDefIndex: 9489
{	// Properties
	public virtual bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	protected virtual BaseEntity GetBaseEntity() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class EntityDebug : EntityComponent<BaseEntity> // TypeDefIndex: 9490
{	// Fields
	internal Stopwatch stopwatch; // 0x20

	// Methods

	// RVA: 0x8C3F00 Offset: 0x8C2500 VA: 0x1808C3F00
	private void Update() { }

	// RVA: 0x8C40B0 Offset: 0x8C26B0 VA: 0x1808C40B0
	public void .ctor() { }

}

public class EntityFlag_Animator : EntityFlag_Toggle // TypeDefIndex: 9491
{	// Fields
	public Animator TargetAnimator; // 0x40
	public string ParamName; // 0x48
	public EntityFlag_Animator.AnimatorMode AnimationMode; // 0x50
	public float FloatOnState; // 0x54
	public float FloatOffState; // 0x58
	public int IntegerOnState; // 0x5C
	public int IntegerOffState; // 0x60
	private int cachedHash; // 0x64
	private bool cachedState; // 0x68

	// Properties
	private int ParamHash { get; }

	// Methods

	// RVA: 0x8C4320 Offset: 0x8C2920 VA: 0x1808C4320
	private int get_ParamHash() { }

	// RVA: 0x8C4120 Offset: 0x8C2720 VA: 0x1808C4120 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C42D0 Offset: 0x8C28D0 VA: 0x1808C42D0
	public void .ctor() { }

}

public enum EntityFlag_Animator.AnimatorMode // TypeDefIndex: 9492
{	// Fields
	public int value__; // 0x0
	public const EntityFlag_Animator.AnimatorMode Bool = 0;
	public const EntityFlag_Animator.AnimatorMode Float = 1;
	public const EntityFlag_Animator.AnimatorMode Trigger = 2;
	public const EntityFlag_Animator.AnimatorMode Integer = 3;

}

public class EntityFlag_TOD : EntityComponent<BaseEntity> // TypeDefIndex: 9493
{	// Fields
	public BaseEntity.Flags desiredFlag; // 0x20
	public bool onAtNight; // 0x24

	// Methods

	// RVA: 0x8C4350 Offset: 0x8C2950 VA: 0x1808C4350
	public void .ctor() { }

}

public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess // TypeDefIndex: 9494
{	// Fields
	public bool runClientside; // 0x20
	public bool runServerside; // 0x21
	public BaseEntity.Flags flag; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private UnityEvent onFlagEnabled; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private UnityEvent onFlagDisabled; // 0x30
	internal bool hasRunOnce; // 0x38
	internal bool lastHasFlag; // 0x39

	// Methods

	// RVA: 0x8C45E0 Offset: 0x8C2BE0 VA: 0x1808C45E0
	protected void OnDisable() { }

	// RVA: 0x8C4560 Offset: 0x8C2B60 VA: 0x1808C4560
	public void DoUpdate(BaseEntity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected virtual void OnStateToggled(bool state) { }

	// RVA: 0x8C45F0 Offset: 0x8C2BF0 VA: 0x1808C45F0 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C46E0 Offset: 0x8C2CE0 VA: 0x1808C46E0 Slot: 11
	public void OnSendNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4770 Offset: 0x8C2D70 VA: 0x1808C4770 Slot: 12
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x8C4840 Offset: 0x8C2E40 VA: 0x1808C4840
	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 9495
{	// Fields
	public bool UseEntityParent; // 0x40

	// Methods

	// RVA: 0x8C4390 Offset: 0x8C2990 VA: 0x1808C4390 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C4550 Offset: 0x8C2B50 VA: 0x1808C4550
	public void .ctor() { }

}

public class EntityItem_RotateWhenOn : EntityComponent<BaseEntity>, IOnPostNetworkUpdate // TypeDefIndex: 9497
{	// Fields
	public EntityItem_RotateWhenOn.State on; // 0x20
	public EntityItem_RotateWhenOn.State off; // 0x28
	internal bool currentlyOn; // 0x30
	internal bool stateInitialized; // 0x31
	public BaseEntity.Flags targetFlag; // 0x34
	private Sound movementLoop; // 0x38

	// Methods

	// RVA: 0x8C4F00 Offset: 0x8C3500 VA: 0x1808C4F00
	private void OnEnable() { }

	// RVA: 0x8C4D10 Offset: 0x8C3310 VA: 0x1808C4D10
	private void DoInitialize(BaseEntity entity) { }

	// RVA: 0x8C4FA0 Offset: 0x8C35A0 VA: 0x1808C4FA0 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4E20 Offset: 0x8C3420 VA: 0x1808C4E20
	public void DoOpen() { }

	// RVA: 0x8C4C30 Offset: 0x8C3230 VA: 0x1808C4C30
	public void DoClose() { }

	[IteratorStateMachineAttribute] // RVA: 0x756A0 Offset: 0x74AA0 VA: 0x1800756A0
	// RVA: 0x8C5350 Offset: 0x8C3950 VA: 0x1808C5350
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	// RVA: 0x8C53E0 Offset: 0x8C39E0 VA: 0x1808C53E0
	public void .ctor() { }

}

public class EntityItem_RotateWhenOn.State // TypeDefIndex: 9498
{	// Fields
	public Vector3 rotation; // 0x10
	public float initialDelay; // 0x1C
	public float timeToTake; // 0x20
	public AnimationCurve animationCurve; // 0x28
	public string effectOnStart; // 0x30
	public string effectOnFinish; // 0x38
	public SoundDefinition movementLoop; // 0x40
	public float movementLoopFadeOutTime; // 0x48
	public SoundDefinition startSound; // 0x50
	public SoundDefinition stopSound; // 0x58

	// Methods

	// RVA: 0x8D6F00 Offset: 0x8D5500 VA: 0x1808D6F00
	public void .ctor() { }

}

private sealed class EntityItem_RotateWhenOn.<RotateTo>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9499
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityItem_RotateWhenOn <>4__this; // 0x20
	public EntityItem_RotateWhenOn.State state; // 0x28
	private Quaternion <start>5__2; // 0x30
	private Quaternion <target>5__3; // 0x40
	private bool <effectsStarted>5__4; // 0x50
	private float <TimeTaken>5__5; // 0x54

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8D8F50 Offset: 0x8D7550 VA: 0x1808D8F50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8D96B0 Offset: 0x8D7CB0 VA: 0x1808D96B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 9500
{	// Fields
	public float secondsTillDestroy; // 0x20

	// Methods

	// RVA: 0x8C5FB0 Offset: 0x8C45B0 VA: 0x1808C5FB0
	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 9533
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly bool editorGiveFreeFuel; // 0x11
	private readonly uint fuelStorageID; // 0x14
	public EntityRef<StorageContainer> fuelStorageInstance; // 0x18

	// Methods

	// RVA: 0x8C4A70 Offset: 0x8C3070 VA: 0x1808C4A70
	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	// RVA: 0x8C4940 Offset: 0x8C2F40 VA: 0x1808C4940
	public bool IsInFuelInteractionRange(BasePlayer player) { }

	// RVA: 0x8C48E0 Offset: 0x8C2EE0 VA: 0x1808C48E0
	private StorageContainer GetFuelContainer() { }

}

public class EntityLink : Pool.IPooled // TypeDefIndex: 9534
{	// Fields
	public BaseEntity owner; // 0x10
	public Socket_Base socket; // 0x18
	public List<EntityLink> connections; // 0x20
	public int capacity; // 0x28

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x8C5CF0 Offset: 0x8C42F0 VA: 0x1808C5CF0
	public string get_name() { }

	// RVA: 0x8C5C10 Offset: 0x8C4210 VA: 0x1808C5C10
	public void Setup(BaseEntity owner, Socket_Base socket) { }

	// RVA: 0x8C5AA0 Offset: 0x8C40A0 VA: 0x1808C5AA0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x8C5A40 Offset: 0x8C4040 VA: 0x1808C5A40
	public bool Contains(EntityLink entity) { }

	// RVA: 0x8C56B0 Offset: 0x8C3CB0 VA: 0x1808C56B0
	public void Add(EntityLink entity) { }

	// RVA: 0x8C5BB0 Offset: 0x8C41B0 VA: 0x1808C5BB0
	public void Remove(EntityLink entity) { }

	// RVA: 0x8C5950 Offset: 0x8C3F50 VA: 0x1808C5950
	public void Clear() { }

	// RVA: 0x8C5AE0 Offset: 0x8C40E0 VA: 0x1808C5AE0
	public bool IsEmpty() { }

	// RVA: 0x8C5B60 Offset: 0x8C4160 VA: 0x1808C5B60
	public bool IsOccupied() { }

	// RVA: 0x8C5B40 Offset: 0x8C4140 VA: 0x1808C5B40
	public bool IsMale() { }

	// RVA: 0x8C5B20 Offset: 0x8C4120 VA: 0x1808C5B20
	public bool IsFemale() { }

	// RVA: 0x8C5710 Offset: 0x8C3D10 VA: 0x1808C5710
	public bool CanConnect(EntityLink link) { }

	// RVA: 0x8C5C70 Offset: 0x8C4270 VA: 0x1808C5C70
	public void .ctor() { }

}

public static class EntityLinkEx // TypeDefIndex: 9535
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C55E0 Offset: 0x8C3BE0 VA: 0x1808C55E0
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C5550 Offset: 0x8C3B50 VA: 0x1808C5550
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C5420 Offset: 0x8C3A20 VA: 0x1808C5420
	public static void AddLinks(List<EntityLink> links, BaseEntity entity, Socket_Base[] sockets) { }

}

public struct EntityRef // TypeDefIndex: 9536
{	// Fields
	internal BaseEntity ent_cached; // 0x0
	internal uint id_cached; // 0x8

	// Properties
	public uint uid { get; set; }

	// Methods

	// RVA: 0xF9EA0 Offset: 0xF92A0 VA: 0x1800F9EA0
	public bool IsSet() { }

	// RVA: 0xF9EB0 Offset: 0xF92B0 VA: 0x1800F9EB0
	public bool IsValid(bool serverside) { }

	// RVA: 0xF9ED0 Offset: 0xF92D0 VA: 0x1800F9ED0
	public void Set(BaseEntity ent) { }

	// RVA: 0xF9E90 Offset: 0xF9290 VA: 0x1800F9E90
	public BaseEntity Get(bool serverside) { }

	// RVA: 0xF9F20 Offset: 0xF9320 VA: 0x1800F9F20
	public uint get_uid() { }

	// RVA: 0xF9F60 Offset: 0xF9360 VA: 0x1800F9F60
	public void set_uid(uint value) { }

}

public struct EntityRef<T> // TypeDefIndex: 9537
{	// Fields
	private EntityRef entityRef; // 0x0

	// Properties
	public bool IsSet { get; }
	public uint uid { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(uint uid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F20 Offset: 0x1F4320 VA: 0x1801F4F20
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F60 Offset: 0x1F4360 VA: 0x1801F4F60
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	// RVA: -1 Offset: -1
	public bool IsValid(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4E30 Offset: 0x1F4230 VA: 0x1801F4E30
	|-EntityRef<BaseEntity>.IsValid
	|-EntityRef<FishingBobber>.IsValid
	|-EntityRef<StorageContainer>.IsValid
	|-EntityRef<object>.IsValid
	|-EntityRef<TrainCar>.IsValid
	|-EntityRef<TrainCarUnloadable>.IsValid
	*/

	// RVA: -1 Offset: -1
	public void Set(T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4E90 Offset: 0x1F4290 VA: 0x1801F4E90
	|-EntityRef<BaseEntity>.Set
	|-EntityRef<BasePlayer>.Set
	|-EntityRef<FishingBobber>.Set
	|-EntityRef<IOEntity>.Set
	|-EntityRef<PaintedItemStorageEntity>.Set
	|-EntityRef<object>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4E20 Offset: 0x1F4220 VA: 0x1801F4E20
	|-EntityRef<BaseEntity>.Get
	|-EntityRef<BasePlayer>.Get
	|-EntityRef<BaseVehicleSeat>.Get
	|-EntityRef<FishingBobber>.Get
	|-EntityRef<IOEntity>.Get
	|-EntityRef<LootContainer>.Get
	|-EntityRef<OreHopper>.Get
	|-EntityRef<PaintedItemStorageEntity>.Get
	|-EntityRef<PercentFullStorageContainer>.Get
	|-EntityRef<StorageContainer>.Get
	|-EntityRef<object>.Get
	|-EntityRef<TrainCar>.Get
	|-EntityRef<TrainCarUnloadable>.Get
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(bool serverside, out T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4EA0 Offset: 0x1F42A0 VA: 0x1801F4EA0
	|-EntityRef<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F70 Offset: 0x1F4370 VA: 0x1801F4F70
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	// RVA: -1 Offset: -1
	public void set_uid(uint value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F80 Offset: 0x1F4380 VA: 0x1801F4F80
	|-EntityRef<BaseEntity>.set_uid
	|-EntityRef<BaseOven>.set_uid
	|-EntityRef<BasePlayer>.set_uid
	|-EntityRef<BaseVehicleSeat>.set_uid
	|-EntityRef<FishingBobber>.set_uid
	|-EntityRef<IOEntity>.set_uid
	|-EntityRef<Locker>.set_uid
	|-EntityRef<OreHopper>.set_uid
	|-EntityRef<PercentFullStorageContainer>.set_uid
	|-EntityRef<StorageContainer>.set_uid
	|-EntityRef<object>.set_uid
	|-EntityRef<TrainCar>.set_uid
	|-EntityRef<TrainCarUnloadable>.set_uid
	*/

}

public class EntityHUDRender : MonoBehaviour // TypeDefIndex: 10922
{	// Fields
	internal BaseEntity cachedEntity; // 0x18

	// Methods

	// RVA: 0x8C4AD0 Offset: 0x8C30D0 VA: 0x1808C4AD0
	private void OnWillRenderObject() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 11912
{	// Methods

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x6DE7D0 Offset: 0x6DCDD0 VA: 0x1806DE7D0
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6DCC30 Offset: 0x6DB230 VA: 0x1806DCC30
	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DEAE0 Offset: 0x6DD0E0 VA: 0x1806DEAE0
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DEF10 Offset: 0x6DD510 VA: 0x1806DEF10
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DED00 Offset: 0x6DD300 VA: 0x1806DED00
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DF120 Offset: 0x6DD720 VA: 0x1806DF120
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DF820 Offset: 0x6DDE20 VA: 0x1806DF820
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DF330 Offset: 0x6DD930 VA: 0x1806DF330
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6DF5B0 Offset: 0x6DDBB0 VA: 0x1806DF5B0
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99050 Offset: 0x98450 VA: 0x180099050
	// RVA: 0x6DDE90 Offset: 0x6DC490 VA: 0x1806DDE90
	public static void clspawn(string name) { }

	[ClientVar] // RVA: 0x992B0 Offset: 0x986B0 VA: 0x1800992B0
	// RVA: 0x6DE0C0 Offset: 0x6DC6C0 VA: 0x1806DE0C0
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99470 Offset: 0x98870 VA: 0x180099470
	// RVA: 0x6DE310 Offset: 0x6DC910 VA: 0x1806DE310
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x996E0 Offset: 0x98AE0 VA: 0x1800996E0
	// RVA: 0x6DE6B0 Offset: 0x6DCCB0 VA: 0x1806DE6B0
	public static void clspawnitem(string name) { }

	[ClientVar] // RVA: 0x99A70 Offset: 0x98E70 VA: 0x180099A70
	// RVA: 0x6DD890 Offset: 0x6DBE90 VA: 0x1806DD890
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DD4F0 Offset: 0x6DBAF0 VA: 0x1806DD4F0
	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] // RVA: 0x99C30 Offset: 0x99030 VA: 0x180099C30
	// RVA: 0x6DC8E0 Offset: 0x6DAEE0 VA: 0x1806DC8E0
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DDE30 Offset: 0x6DC430 VA: 0x1806DDE30
	public void .ctor() { }

}

private struct Entity.EntityInfo // TypeDefIndex: 11913
{	// Fields
	public BaseNetworkable entity; // 0x0
	public uint entityID; // 0x8
	public uint groupID; // 0xC
	public uint parentID; // 0x10
	public string status; // 0x18

	// Methods

	// RVA: 0xF40D0 Offset: 0xF34D0 VA: 0x1800F40D0
	public void .ctor(BaseNetworkable src) { }

}

private sealed class Entity.<>c__DisplayClass3_0 // TypeDefIndex: 11914
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8370 Offset: 0x6E6970 VA: 0x1806E8370
	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 11915
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E84C0 Offset: 0x6E6AC0 VA: 0x1806E84C0
	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 11916
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E84E0 Offset: 0x6E6AE0 VA: 0x1806E84E0
	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 11917
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8500 Offset: 0x6E6B00 VA: 0x1806E8500
	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 11918
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8520 Offset: 0x6E6B20 VA: 0x1806E8520
	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 11919
{	// Fields
	public BasePlayer player; // 0x10
	public uint filter; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8580 Offset: 0x6E6B80 VA: 0x1806E8580
	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 11920
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E84C0 Offset: 0x6E6AC0 VA: 0x1806E84C0
	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

