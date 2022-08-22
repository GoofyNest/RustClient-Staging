public enum EntityHandling // TypeDefIndex: 1838
{	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;

}

public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 5765
{	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsWeak() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	internal void set_IsWeak(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Tag(string value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1088A70 Offset: 0x1087070 VA: 0x181088A70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1088B30 Offset: 0x1087130 VA: 0x181088B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1088F10 Offset: 0x1087510 VA: 0x181088F10
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x1088BD0 Offset: 0x10871D0 VA: 0x181088BD0
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1088E80 Offset: 0x1087480 VA: 0x181088E80
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x1088B80 Offset: 0x1087180 VA: 0x181088B80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1089010 Offset: 0x1087610 VA: 0x181089010
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

	// RVA: 0x10A6890 Offset: 0x10A4E90 VA: 0x1810A6890
	public static void ResetToPool(Entity instance) { }

	// RVA: 0x10A8450 Offset: 0x10A6A50 VA: 0x1810A8450
	public void ResetToPool() { }

	// RVA: 0x10A67B0 Offset: 0x10A4DB0 VA: 0x1810A67B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x109D150 Offset: 0x109B750 VA: 0x18109D150
	public void CopyTo(Entity instance) { }

	// RVA: 0x109EFA0 Offset: 0x109D5A0 VA: 0x18109EFA0
	public Entity Copy() { }

	// RVA: 0x10A6730 Offset: 0x10A4D30 VA: 0x1810A6730
	public static Entity Deserialize(Stream stream) { }

	// RVA: 0x10A1710 Offset: 0x109FD10 VA: 0x1810A1710
	public static Entity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x10A1790 Offset: 0x109FD90 VA: 0x1810A1790
	public static Entity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x10A6510 Offset: 0x10A4B10 VA: 0x1810A6510
	public static Entity Deserialize(byte[] buffer) { }

	// RVA: 0x10A6840 Offset: 0x10A4E40 VA: 0x1810A6840
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x10B5CA0 Offset: 0x10B42A0 VA: 0x1810B5CA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x10B5CC0 Offset: 0x10B42C0 VA: 0x1810B5CC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Entity previous) { }

	// RVA: 0x10A6870 Offset: 0x10A4E70 VA: 0x1810A6870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x10A6630 Offset: 0x10A4C30 VA: 0x1810A6630
	public static Entity Deserialize(byte[] buffer, Entity instance, bool isDelta = False) { }

	// RVA: 0x10A3EF0 Offset: 0x10A24F0 VA: 0x1810A3EF0
	public static Entity Deserialize(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x109F020 Offset: 0x109D620 VA: 0x18109F020
	public static Entity DeserializeLengthDelimited(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x10A1820 Offset: 0x109FE20 VA: 0x1810A1820
	public static Entity DeserializeLength(Stream stream, int length, Entity instance, bool isDelta) { }

	// RVA: 0x10A8460 Offset: 0x10A6A60 VA: 0x1810A8460
	public static void SerializeDelta(Stream stream, Entity instance, Entity previous) { }

	// RVA: 0x10AF4F0 Offset: 0x10ADAF0 VA: 0x1810AF4F0
	public static void Serialize(Stream stream, Entity instance) { }

	// RVA: 0x10B5C90 Offset: 0x10B4290 VA: 0x1810B5C90
	public byte[] ToProtoBytes() { }

	// RVA: 0x10B5CA0 Offset: 0x10B42A0 VA: 0x1810B5CA0
	public void ToProto(Stream stream) { }

	// RVA: 0x10AF3E0 Offset: 0x10AD9E0 VA: 0x1810AF3E0
	public static byte[] SerializeToBytes(Entity instance) { }

	// RVA: 0x10AF330 Offset: 0x10AD930 VA: 0x1810AF330
	public static void SerializeLengthDelimited(Stream stream, Entity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1D564A0 Offset: 0x1D54AA0 VA: 0x181D564A0
	public static void ResetToPool(EntitySlots instance) { }

	// RVA: 0x1D56560 Offset: 0x1D54B60 VA: 0x181D56560
	public void ResetToPool() { }

	// RVA: 0x1D55D90 Offset: 0x1D54390 VA: 0x181D55D90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFBB20 Offset: 0x1BFA120 VA: 0x181BFBB20
	public void CopyTo(EntitySlots instance) { }

	// RVA: 0x1D54600 Offset: 0x1D52C00 VA: 0x181D54600
	public EntitySlots Copy() { }

	// RVA: 0x1D55130 Offset: 0x1D53730 VA: 0x181D55130
	public static EntitySlots Deserialize(Stream stream) { }

	// RVA: 0x1D549F0 Offset: 0x1D52FF0 VA: 0x181D549F0
	public static EntitySlots DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D54DB0 Offset: 0x1D533B0 VA: 0x181D54DB0
	public static EntitySlots DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D55690 Offset: 0x1D53C90 VA: 0x181D55690
	public static EntitySlots Deserialize(byte[] buffer) { }

	// RVA: 0x1D55ED0 Offset: 0x1D544D0 VA: 0x181D55ED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D56C40 Offset: 0x1D55240 VA: 0x181D56C40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D56C60 Offset: 0x1D55260 VA: 0x181D56C60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntitySlots previous) { }

	// RVA: 0x1D56160 Offset: 0x1D54760 VA: 0x181D56160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D55A20 Offset: 0x1D54020 VA: 0x181D55A20
	public static EntitySlots Deserialize(byte[] buffer, EntitySlots instance, bool isDelta = False) { }

	// RVA: 0x1D55400 Offset: 0x1D53A00 VA: 0x181D55400
	public static EntitySlots Deserialize(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D54690 Offset: 0x1D52C90 VA: 0x181D54690
	public static EntitySlots DeserializeLengthDelimited(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D54A70 Offset: 0x1D53070 VA: 0x181D54A70
	public static EntitySlots DeserializeLength(Stream stream, int length, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D56620 Offset: 0x1D54C20 VA: 0x181D56620
	public static void SerializeDelta(Stream stream, EntitySlots instance, EntitySlots previous) { }

	// RVA: 0x1D56AA0 Offset: 0x1D550A0 VA: 0x181D56AA0
	public static void Serialize(Stream stream, EntitySlots instance) { }

	// RVA: 0x1D56C30 Offset: 0x1D55230 VA: 0x181D56C30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D56C40 Offset: 0x1D55240 VA: 0x181D56C40
	public void ToProto(Stream stream) { }

	// RVA: 0x1D56990 Offset: 0x1D54F90 VA: 0x181D56990
	public static byte[] SerializeToBytes(EntitySlots instance) { }

	// RVA: 0x1D568E0 Offset: 0x1D54EE0 VA: 0x181D568E0
	public static void SerializeLengthDelimited(Stream stream, EntitySlots instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6481
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Entity> entity; // 0x18

	// Methods

	// RVA: 0x1D53E80 Offset: 0x1D52480 VA: 0x181D53E80
	public static void ResetToPool(EntityList instance) { }

	// RVA: 0x1D53CD0 Offset: 0x1D522D0 VA: 0x181D53CD0
	public void ResetToPool() { }

	// RVA: 0x1D53A50 Offset: 0x1D52050 VA: 0x181D53A50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D52DB0 Offset: 0x1D513B0 VA: 0x181D52DB0
	public void CopyTo(EntityList instance) { }

	// RVA: 0x1D52EE0 Offset: 0x1D514E0 VA: 0x181D52EE0
	public EntityList Copy() { }

	// RVA: 0x1D538B0 Offset: 0x1D51EB0 VA: 0x181D538B0
	public static EntityList Deserialize(Stream stream) { }

	// RVA: 0x1D532C0 Offset: 0x1D518C0 VA: 0x181D532C0
	public static EntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D53590 Offset: 0x1D51B90 VA: 0x181D53590
	public static EntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D53930 Offset: 0x1D51F30 VA: 0x181D53930
	public static EntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1D53C90 Offset: 0x1D52290 VA: 0x181D53C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D545C0 Offset: 0x1D52BC0 VA: 0x181D545C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D545E0 Offset: 0x1D52BE0 VA: 0x181D545E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityList previous) { }

	// RVA: 0x1D53CB0 Offset: 0x1D522B0 VA: 0x181D53CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D53620 Offset: 0x1D51C20 VA: 0x181D53620
	public static EntityList Deserialize(byte[] buffer, EntityList instance, bool isDelta = False) { }

	// RVA: 0x1D53720 Offset: 0x1D51D20 VA: 0x181D53720
	public static EntityList Deserialize(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D53050 Offset: 0x1D51650 VA: 0x181D53050
	public static EntityList DeserializeLengthDelimited(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D53340 Offset: 0x1D51940 VA: 0x181D53340
	public static EntityList DeserializeLength(Stream stream, int length, EntityList instance, bool isDelta) { }

	// RVA: 0x1D54030 Offset: 0x1D52630 VA: 0x181D54030
	public static void SerializeDelta(Stream stream, EntityList instance, EntityList previous) { }

	// RVA: 0x1D543D0 Offset: 0x1D529D0 VA: 0x181D543D0
	public static void Serialize(Stream stream, EntityList instance) { }

	// RVA: 0x1D545B0 Offset: 0x1D52BB0 VA: 0x181D545B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D545C0 Offset: 0x1D52BC0 VA: 0x181D545C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D542C0 Offset: 0x1D528C0 VA: 0x181D542C0
	public static byte[] SerializeToBytes(EntityList instance) { }

	// RVA: 0x1D54210 Offset: 0x1D52810 VA: 0x181D54210
	public static void SerializeLengthDelimited(Stream stream, EntityList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6504
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> entityIds; // 0x18

	// Methods

	// RVA: 0x1D52700 Offset: 0x1D50D00 VA: 0x181D52700
	public static void ResetToPool(EntityIdList instance) { }

	// RVA: 0x1D52620 Offset: 0x1D50C20 VA: 0x181D52620
	public void ResetToPool() { }

	// RVA: 0x1D52490 Offset: 0x1D50A90 VA: 0x181D52490 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D517A0 Offset: 0x1D4FDA0 VA: 0x181D517A0
	public void CopyTo(EntityIdList instance) { }

	// RVA: 0x1D518C0 Offset: 0x1D4FEC0 VA: 0x181D518C0
	public EntityIdList Copy() { }

	// RVA: 0x1D52410 Offset: 0x1D50A10 VA: 0x181D52410
	public static EntityIdList Deserialize(Stream stream) { }

	// RVA: 0x1D51CB0 Offset: 0x1D502B0 VA: 0x181D51CB0
	public static EntityIdList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D51D30 Offset: 0x1D50330 VA: 0x181D51D30
	public static EntityIdList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D52030 Offset: 0x1D50630 VA: 0x181D52030
	public static EntityIdList Deserialize(byte[] buffer) { }

	// RVA: 0x1D525E0 Offset: 0x1D50BE0 VA: 0x181D525E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D52C30 Offset: 0x1D51230 VA: 0x181D52C30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D52C50 Offset: 0x1D51250 VA: 0x181D52C50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityIdList previous) { }

	// RVA: 0x1D52600 Offset: 0x1D50C00 VA: 0x181D52600 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D52310 Offset: 0x1D50910 VA: 0x181D52310
	public static EntityIdList Deserialize(byte[] buffer, EntityIdList instance, bool isDelta = False) { }

	// RVA: 0x1D52150 Offset: 0x1D50750 VA: 0x181D52150
	public static EntityIdList Deserialize(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51A20 Offset: 0x1D50020 VA: 0x181D51A20
	public static EntityIdList DeserializeLengthDelimited(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51DC0 Offset: 0x1D503C0 VA: 0x181D51DC0
	public static EntityIdList DeserializeLength(Stream stream, int length, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D527E0 Offset: 0x1D50DE0 VA: 0x181D527E0
	public static void SerializeDelta(Stream stream, EntityIdList instance, EntityIdList previous) { }

	// RVA: 0x1D52AE0 Offset: 0x1D510E0 VA: 0x181D52AE0
	public static void Serialize(Stream stream, EntityIdList instance) { }

	// RVA: 0x1D52C20 Offset: 0x1D51220 VA: 0x181D52C20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D52C30 Offset: 0x1D51230 VA: 0x181D52C30
	public void ToProto(Stream stream) { }

	// RVA: 0x1D529D0 Offset: 0x1D50FD0 VA: 0x181D529D0
	public static byte[] SerializeToBytes(EntityIdList instance) { }

	// RVA: 0x1D52920 Offset: 0x1D50F20 VA: 0x181D52920
	public static void SerializeLengthDelimited(Stream stream, EntityIdList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public static class Entity // TypeDefIndex: 6628
{	// Fields
	private static Dictionary<Transform, IEntity> _dict; // 0x34E0

	// Methods

	// RVA: 0x1BA3540 Offset: 0x1BA1B40 VA: 0x181BA3540
	public static void Register(Transform t, IEntity entity) { }

	// RVA: 0x1BA34B0 Offset: 0x1BA1AB0 VA: 0x181BA34B0
	public static IEntity Get(Transform t) { }

	// RVA: 0x1BA3780 Offset: 0x1BA1D80 VA: 0x181BA3780
	public static void Unregister(Transform t) { }

	// RVA: 0x1BA35D0 Offset: 0x1BA1BD0 VA: 0x181BA35D0
	public static void Register(GameObject obj, IEntity entity) { }

	// RVA: 0x1BA33C0 Offset: 0x1BA19C0 VA: 0x181BA33C0
	public static IEntity Get(GameObject obj) { }

	// RVA: 0x1BA36B0 Offset: 0x1BA1CB0 VA: 0x181BA36B0
	public static void Unregister(GameObject obj) { }

	// RVA: 0x1BA3800 Offset: 0x1BA1E00 VA: 0x181BA3800
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

	// RVA: 0x8C4330 Offset: 0x8C2930 VA: 0x1808C4330
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x8C44E0 Offset: 0x8C2AE0 VA: 0x1808C44E0
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
	|-RVA: 0x1893AB0 Offset: 0x18920B0 VA: 0x181893AB0
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	// RVA: -1 Offset: -1
	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1893930 Offset: 0x1891F30 VA: 0x181893930
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override BaseEntity GetBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355260 Offset: 0x1353860 VA: 0x181355260
	|-EntityComponent<BaseEntity>.GetBaseEntity
	|-EntityComponent<BasePlayer>.GetBaseEntity
	|-EntityComponent<object>.GetBaseEntity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1893A90 Offset: 0x1892090 VA: 0x181893A90
	|-EntityComponent<BaseEntity>..ctor
	|-EntityComponent<BasePlayer>..ctor
	|-EntityComponent<object>..ctor
	*/

}

public class EntityComponentBase : BaseMonoBehaviour // TypeDefIndex: 9489
{	// Properties
	public virtual bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	protected virtual BaseEntity GetBaseEntity() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

public class EntityDebug : EntityComponent<BaseEntity> // TypeDefIndex: 9490
{	// Fields
	internal Stopwatch stopwatch; // 0x20

	// Methods

	// RVA: 0x8C4520 Offset: 0x8C2B20 VA: 0x1808C4520
	private void Update() { }

	// RVA: 0x8C46D0 Offset: 0x8C2CD0 VA: 0x1808C46D0
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

	// RVA: 0x8C4940 Offset: 0x8C2F40 VA: 0x1808C4940
	private int get_ParamHash() { }

	// RVA: 0x8C4740 Offset: 0x8C2D40 VA: 0x1808C4740 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C48F0 Offset: 0x8C2EF0 VA: 0x1808C48F0
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

	// RVA: 0x8C4970 Offset: 0x8C2F70 VA: 0x1808C4970
	public void .ctor() { }

}

public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess // TypeDefIndex: 9494
{	// Fields
	public bool runClientside; // 0x20
	public bool runServerside; // 0x21
	public BaseEntity.Flags flag; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UnityEvent onFlagEnabled; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UnityEvent onFlagDisabled; // 0x30
	internal bool hasRunOnce; // 0x38
	internal bool lastHasFlag; // 0x39

	// Methods

	// RVA: 0x8C4C00 Offset: 0x8C3200 VA: 0x1808C4C00
	protected void OnDisable() { }

	// RVA: 0x8C4B80 Offset: 0x8C3180 VA: 0x1808C4B80
	public void DoUpdate(BaseEntity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected virtual void OnStateToggled(bool state) { }

	// RVA: 0x8C4C10 Offset: 0x8C3210 VA: 0x1808C4C10 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4D00 Offset: 0x8C3300 VA: 0x1808C4D00 Slot: 11
	public void OnSendNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4D90 Offset: 0x8C3390 VA: 0x1808C4D90 Slot: 12
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x8C4E60 Offset: 0x8C3460 VA: 0x1808C4E60
	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 9495
{	// Fields
	public bool UseEntityParent; // 0x40

	// Methods

	// RVA: 0x8C49B0 Offset: 0x8C2FB0 VA: 0x1808C49B0 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C4B70 Offset: 0x8C3170 VA: 0x1808C4B70
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

	// RVA: 0x8C5520 Offset: 0x8C3B20 VA: 0x1808C5520
	private void OnEnable() { }

	// RVA: 0x8C5330 Offset: 0x8C3930 VA: 0x1808C5330
	private void DoInitialize(BaseEntity entity) { }

	// RVA: 0x8C55C0 Offset: 0x8C3BC0 VA: 0x1808C55C0 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C5440 Offset: 0x8C3A40 VA: 0x1808C5440
	public void DoOpen() { }

	// RVA: 0x8C5250 Offset: 0x8C3850 VA: 0x1808C5250
	public void DoClose() { }

	[IteratorStateMachineAttribute] // RVA: 0x757A0 Offset: 0x74BA0 VA: 0x1800757A0
	// RVA: 0x8C5970 Offset: 0x8C3F70 VA: 0x1808C5970
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	// RVA: 0x8C5A00 Offset: 0x8C4000 VA: 0x1808C5A00
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

	// RVA: 0x8D7520 Offset: 0x8D5B20 VA: 0x1808D7520
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8D9570 Offset: 0x8D7B70 VA: 0x1808D9570 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9CD0 Offset: 0x8D82D0 VA: 0x1808D9CD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 9500
{	// Fields
	public float secondsTillDestroy; // 0x20

	// Methods

	// RVA: 0x8C65D0 Offset: 0x8C4BD0 VA: 0x1808C65D0
	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 9533
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly bool editorGiveFreeFuel; // 0x11
	private readonly uint fuelStorageID; // 0x14
	public EntityRef<StorageContainer> fuelStorageInstance; // 0x18

	// Methods

	// RVA: 0x8C5090 Offset: 0x8C3690 VA: 0x1808C5090
	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	// RVA: 0x8C4F60 Offset: 0x8C3560 VA: 0x1808C4F60
	public bool IsInFuelInteractionRange(BasePlayer player) { }

	// RVA: 0x8C4F00 Offset: 0x8C3500 VA: 0x1808C4F00
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

	// RVA: 0x8C6310 Offset: 0x8C4910 VA: 0x1808C6310
	public string get_name() { }

	// RVA: 0x8C6230 Offset: 0x8C4830 VA: 0x1808C6230
	public void Setup(BaseEntity owner, Socket_Base socket) { }

	// RVA: 0x8C60C0 Offset: 0x8C46C0 VA: 0x1808C60C0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x8C6060 Offset: 0x8C4660 VA: 0x1808C6060
	public bool Contains(EntityLink entity) { }

	// RVA: 0x8C5CD0 Offset: 0x8C42D0 VA: 0x1808C5CD0
	public void Add(EntityLink entity) { }

	// RVA: 0x8C61D0 Offset: 0x8C47D0 VA: 0x1808C61D0
	public void Remove(EntityLink entity) { }

	// RVA: 0x8C5F70 Offset: 0x8C4570 VA: 0x1808C5F70
	public void Clear() { }

	// RVA: 0x8C6100 Offset: 0x8C4700 VA: 0x1808C6100
	public bool IsEmpty() { }

	// RVA: 0x8C6180 Offset: 0x8C4780 VA: 0x1808C6180
	public bool IsOccupied() { }

	// RVA: 0x8C6160 Offset: 0x8C4760 VA: 0x1808C6160
	public bool IsMale() { }

	// RVA: 0x8C6140 Offset: 0x8C4740 VA: 0x1808C6140
	public bool IsFemale() { }

	// RVA: 0x8C5D30 Offset: 0x8C4330 VA: 0x1808C5D30
	public bool CanConnect(EntityLink link) { }

	// RVA: 0x8C6290 Offset: 0x8C4890 VA: 0x1808C6290
	public void .ctor() { }

}

public static class EntityLinkEx // TypeDefIndex: 9535
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C5C00 Offset: 0x8C4200 VA: 0x1808C5C00
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C5B70 Offset: 0x8C4170 VA: 0x1808C5B70
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C5A40 Offset: 0x8C4040 VA: 0x1808C5A40
	public static void AddLinks(List<EntityLink> links, BaseEntity entity, Socket_Base[] sockets) { }

}

public struct EntityRef // TypeDefIndex: 9536
{	// Fields
	internal BaseEntity ent_cached; // 0x0
	internal uint id_cached; // 0x8

	// Properties
	public uint uid { get; set; }

	// Methods

	// RVA: 0xF9E20 Offset: 0xF9220 VA: 0x1800F9E20
	public bool IsSet() { }

	// RVA: 0xF9E30 Offset: 0xF9230 VA: 0x1800F9E30
	public bool IsValid(bool serverside) { }

	// RVA: 0xF9E50 Offset: 0xF9250 VA: 0x1800F9E50
	public void Set(BaseEntity ent) { }

	// RVA: 0xF9E10 Offset: 0xF9210 VA: 0x1800F9E10
	public BaseEntity Get(bool serverside) { }

	// RVA: 0xF9EA0 Offset: 0xF92A0 VA: 0x1800F9EA0
	public uint get_uid() { }

	// RVA: 0xF9EE0 Offset: 0xF92E0 VA: 0x1800F9EE0
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
	|-RVA: 0x213D90 Offset: 0x213190 VA: 0x180213D90
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213DD0 Offset: 0x2131D0 VA: 0x180213DD0
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	// RVA: -1 Offset: -1
	public bool IsValid(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213CA0 Offset: 0x2130A0 VA: 0x180213CA0
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
	|-RVA: 0x213D00 Offset: 0x213100 VA: 0x180213D00
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
	|-RVA: 0x213C90 Offset: 0x213090 VA: 0x180213C90
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
	|-RVA: 0x213D10 Offset: 0x213110 VA: 0x180213D10
	|-EntityRef<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213DE0 Offset: 0x2131E0 VA: 0x180213DE0
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	// RVA: -1 Offset: -1
	public void set_uid(uint value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213DF0 Offset: 0x2131F0 VA: 0x180213DF0
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

	// RVA: 0x8C50F0 Offset: 0x8C36F0 VA: 0x1808C50F0
	private void OnWillRenderObject() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 11912
{	// Methods

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6DE870 Offset: 0x6DCE70 VA: 0x1806DE870
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6DCCD0 Offset: 0x6DB2D0 VA: 0x1806DCCD0
	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DEB80 Offset: 0x6DD180 VA: 0x1806DEB80
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DEFB0 Offset: 0x6DD5B0 VA: 0x1806DEFB0
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DEDA0 Offset: 0x6DD3A0 VA: 0x1806DEDA0
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF1C0 Offset: 0x6DD7C0 VA: 0x1806DF1C0
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF8C0 Offset: 0x6DDEC0 VA: 0x1806DF8C0
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF3D0 Offset: 0x6DD9D0 VA: 0x1806DF3D0
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF650 Offset: 0x6DDC50 VA: 0x1806DF650
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99190 Offset: 0x98590 VA: 0x180099190
	// RVA: 0x6DDF30 Offset: 0x6DC530 VA: 0x1806DDF30
	public static void clspawn(string name) { }

	[ClientVar] // RVA: 0x993D0 Offset: 0x987D0 VA: 0x1800993D0
	// RVA: 0x6DE160 Offset: 0x6DC760 VA: 0x1806DE160
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x996C0 Offset: 0x98AC0 VA: 0x1800996C0
	// RVA: 0x6DE3B0 Offset: 0x6DC9B0 VA: 0x1806DE3B0
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99880 Offset: 0x98C80 VA: 0x180099880
	// RVA: 0x6DE750 Offset: 0x6DCD50 VA: 0x1806DE750
	public static void clspawnitem(string name) { }

	[ClientVar] // RVA: 0x99C00 Offset: 0x99000 VA: 0x180099C00
	// RVA: 0x6DD930 Offset: 0x6DBF30 VA: 0x1806DD930
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DD590 Offset: 0x6DBB90 VA: 0x1806DD590
	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] // RVA: 0x99DF0 Offset: 0x991F0 VA: 0x180099DF0
	// RVA: 0x6DC980 Offset: 0x6DAF80 VA: 0x1806DC980
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DDED0 Offset: 0x6DC4D0 VA: 0x1806DDED0
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

	// RVA: 0xF4050 Offset: 0xF3450 VA: 0x1800F4050
	public void .ctor(BaseNetworkable src) { }

}

private sealed class Entity.<>c__DisplayClass3_0 // TypeDefIndex: 11914
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8410 Offset: 0x6E6A10 VA: 0x1806E8410
	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 11915
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8560 Offset: 0x6E6B60 VA: 0x1806E8560
	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 11916
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8580 Offset: 0x6E6B80 VA: 0x1806E8580
	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 11917
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E85A0 Offset: 0x6E6BA0 VA: 0x1806E85A0
	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 11918
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E85C0 Offset: 0x6E6BC0 VA: 0x1806E85C0
	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 11919
{	// Fields
	public BasePlayer player; // 0x10
	public uint filter; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8620 Offset: 0x6E6C20 VA: 0x1806E8620
	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 11920
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8560 Offset: 0x6E6B60 VA: 0x1806E8560
	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

