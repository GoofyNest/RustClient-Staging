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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Tag(string value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1088000 Offset: 0x1086600 VA: 0x181088000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10880C0 Offset: 0x10866C0 VA: 0x1810880C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10884A0 Offset: 0x1086AA0 VA: 0x1810884A0
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x1088160 Offset: 0x1086760 VA: 0x181088160
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1088410 Offset: 0x1086A10 VA: 0x181088410
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x1088110 Offset: 0x1086710 VA: 0x181088110 Slot: 3
	public override string ToString() { }

	// RVA: 0x10885A0 Offset: 0x1086BA0 VA: 0x1810885A0
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

	// RVA: 0x10A5E20 Offset: 0x10A4420 VA: 0x1810A5E20
	public static void ResetToPool(Entity instance) { }

	// RVA: 0x10A79E0 Offset: 0x10A5FE0 VA: 0x1810A79E0
	public void ResetToPool() { }

	// RVA: 0x10A5D40 Offset: 0x10A4340 VA: 0x1810A5D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x109C6E0 Offset: 0x109ACE0 VA: 0x18109C6E0
	public void CopyTo(Entity instance) { }

	// RVA: 0x109E530 Offset: 0x109CB30 VA: 0x18109E530
	public Entity Copy() { }

	// RVA: 0x10A5CC0 Offset: 0x10A42C0 VA: 0x1810A5CC0
	public static Entity Deserialize(Stream stream) { }

	// RVA: 0x10A0CA0 Offset: 0x109F2A0 VA: 0x1810A0CA0
	public static Entity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x10A0D20 Offset: 0x109F320 VA: 0x1810A0D20
	public static Entity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x10A5AA0 Offset: 0x10A40A0 VA: 0x1810A5AA0
	public static Entity Deserialize(byte[] buffer) { }

	// RVA: 0x10A5DD0 Offset: 0x10A43D0 VA: 0x1810A5DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x10B5230 Offset: 0x10B3830 VA: 0x1810B5230 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x10B5250 Offset: 0x10B3850 VA: 0x1810B5250 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Entity previous) { }

	// RVA: 0x10A5E00 Offset: 0x10A4400 VA: 0x1810A5E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x10A5BC0 Offset: 0x10A41C0 VA: 0x1810A5BC0
	public static Entity Deserialize(byte[] buffer, Entity instance, bool isDelta = False) { }

	// RVA: 0x10A3480 Offset: 0x10A1A80 VA: 0x1810A3480
	public static Entity Deserialize(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x109E5B0 Offset: 0x109CBB0 VA: 0x18109E5B0
	public static Entity DeserializeLengthDelimited(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x10A0DB0 Offset: 0x109F3B0 VA: 0x1810A0DB0
	public static Entity DeserializeLength(Stream stream, int length, Entity instance, bool isDelta) { }

	// RVA: 0x10A79F0 Offset: 0x10A5FF0 VA: 0x1810A79F0
	public static void SerializeDelta(Stream stream, Entity instance, Entity previous) { }

	// RVA: 0x10AEA80 Offset: 0x10AD080 VA: 0x1810AEA80
	public static void Serialize(Stream stream, Entity instance) { }

	// RVA: 0x10B5220 Offset: 0x10B3820 VA: 0x1810B5220
	public byte[] ToProtoBytes() { }

	// RVA: 0x10B5230 Offset: 0x10B3830 VA: 0x1810B5230
	public void ToProto(Stream stream) { }

	// RVA: 0x10AE970 Offset: 0x10ACF70 VA: 0x1810AE970
	public static byte[] SerializeToBytes(Entity instance) { }

	// RVA: 0x10AE8C0 Offset: 0x10ACEC0 VA: 0x1810AE8C0
	public static void SerializeLengthDelimited(Stream stream, Entity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1D55CB0 Offset: 0x1D542B0 VA: 0x181D55CB0
	public static void ResetToPool(EntitySlots instance) { }

	// RVA: 0x1D55D70 Offset: 0x1D54370 VA: 0x181D55D70
	public void ResetToPool() { }

	// RVA: 0x1D555A0 Offset: 0x1D53BA0 VA: 0x181D555A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB330 Offset: 0x1BF9930 VA: 0x181BFB330
	public void CopyTo(EntitySlots instance) { }

	// RVA: 0x1D53E10 Offset: 0x1D52410 VA: 0x181D53E10
	public EntitySlots Copy() { }

	// RVA: 0x1D54940 Offset: 0x1D52F40 VA: 0x181D54940
	public static EntitySlots Deserialize(Stream stream) { }

	// RVA: 0x1D54200 Offset: 0x1D52800 VA: 0x181D54200
	public static EntitySlots DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D545C0 Offset: 0x1D52BC0 VA: 0x181D545C0
	public static EntitySlots DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D54EA0 Offset: 0x1D534A0 VA: 0x181D54EA0
	public static EntitySlots Deserialize(byte[] buffer) { }

	// RVA: 0x1D556E0 Offset: 0x1D53CE0 VA: 0x181D556E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D56450 Offset: 0x1D54A50 VA: 0x181D56450 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D56470 Offset: 0x1D54A70 VA: 0x181D56470 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntitySlots previous) { }

	// RVA: 0x1D55970 Offset: 0x1D53F70 VA: 0x181D55970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D55230 Offset: 0x1D53830 VA: 0x181D55230
	public static EntitySlots Deserialize(byte[] buffer, EntitySlots instance, bool isDelta = False) { }

	// RVA: 0x1D54C10 Offset: 0x1D53210 VA: 0x181D54C10
	public static EntitySlots Deserialize(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D53EA0 Offset: 0x1D524A0 VA: 0x181D53EA0
	public static EntitySlots DeserializeLengthDelimited(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D54280 Offset: 0x1D52880 VA: 0x181D54280
	public static EntitySlots DeserializeLength(Stream stream, int length, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D55E30 Offset: 0x1D54430 VA: 0x181D55E30
	public static void SerializeDelta(Stream stream, EntitySlots instance, EntitySlots previous) { }

	// RVA: 0x1D562B0 Offset: 0x1D548B0 VA: 0x181D562B0
	public static void Serialize(Stream stream, EntitySlots instance) { }

	// RVA: 0x1D56440 Offset: 0x1D54A40 VA: 0x181D56440
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D56450 Offset: 0x1D54A50 VA: 0x181D56450
	public void ToProto(Stream stream) { }

	// RVA: 0x1D561A0 Offset: 0x1D547A0 VA: 0x181D561A0
	public static byte[] SerializeToBytes(EntitySlots instance) { }

	// RVA: 0x1D560F0 Offset: 0x1D546F0 VA: 0x181D560F0
	public static void SerializeLengthDelimited(Stream stream, EntitySlots instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6481
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Entity> entity; // 0x18

	// Methods

	// RVA: 0x1D53690 Offset: 0x1D51C90 VA: 0x181D53690
	public static void ResetToPool(EntityList instance) { }

	// RVA: 0x1D534E0 Offset: 0x1D51AE0 VA: 0x181D534E0
	public void ResetToPool() { }

	// RVA: 0x1D53260 Offset: 0x1D51860 VA: 0x181D53260 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D525C0 Offset: 0x1D50BC0 VA: 0x181D525C0
	public void CopyTo(EntityList instance) { }

	// RVA: 0x1D526F0 Offset: 0x1D50CF0 VA: 0x181D526F0
	public EntityList Copy() { }

	// RVA: 0x1D530C0 Offset: 0x1D516C0 VA: 0x181D530C0
	public static EntityList Deserialize(Stream stream) { }

	// RVA: 0x1D52AD0 Offset: 0x1D510D0 VA: 0x181D52AD0
	public static EntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D52DA0 Offset: 0x1D513A0 VA: 0x181D52DA0
	public static EntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D53140 Offset: 0x1D51740 VA: 0x181D53140
	public static EntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1D534A0 Offset: 0x1D51AA0 VA: 0x181D534A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D53DD0 Offset: 0x1D523D0 VA: 0x181D53DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D53DF0 Offset: 0x1D523F0 VA: 0x181D53DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityList previous) { }

	// RVA: 0x1D534C0 Offset: 0x1D51AC0 VA: 0x181D534C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D52E30 Offset: 0x1D51430 VA: 0x181D52E30
	public static EntityList Deserialize(byte[] buffer, EntityList instance, bool isDelta = False) { }

	// RVA: 0x1D52F30 Offset: 0x1D51530 VA: 0x181D52F30
	public static EntityList Deserialize(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D52860 Offset: 0x1D50E60 VA: 0x181D52860
	public static EntityList DeserializeLengthDelimited(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D52B50 Offset: 0x1D51150 VA: 0x181D52B50
	public static EntityList DeserializeLength(Stream stream, int length, EntityList instance, bool isDelta) { }

	// RVA: 0x1D53840 Offset: 0x1D51E40 VA: 0x181D53840
	public static void SerializeDelta(Stream stream, EntityList instance, EntityList previous) { }

	// RVA: 0x1D53BE0 Offset: 0x1D521E0 VA: 0x181D53BE0
	public static void Serialize(Stream stream, EntityList instance) { }

	// RVA: 0x1D53DC0 Offset: 0x1D523C0 VA: 0x181D53DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D53DD0 Offset: 0x1D523D0 VA: 0x181D53DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D53AD0 Offset: 0x1D520D0 VA: 0x181D53AD0
	public static byte[] SerializeToBytes(EntityList instance) { }

	// RVA: 0x1D53A20 Offset: 0x1D52020 VA: 0x181D53A20
	public static void SerializeLengthDelimited(Stream stream, EntityList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6504
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> entityIds; // 0x18

	// Methods

	// RVA: 0x1D51F10 Offset: 0x1D50510 VA: 0x181D51F10
	public static void ResetToPool(EntityIdList instance) { }

	// RVA: 0x1D51E30 Offset: 0x1D50430 VA: 0x181D51E30
	public void ResetToPool() { }

	// RVA: 0x1D51CA0 Offset: 0x1D502A0 VA: 0x181D51CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D50FB0 Offset: 0x1D4F5B0 VA: 0x181D50FB0
	public void CopyTo(EntityIdList instance) { }

	// RVA: 0x1D510D0 Offset: 0x1D4F6D0 VA: 0x181D510D0
	public EntityIdList Copy() { }

	// RVA: 0x1D51C20 Offset: 0x1D50220 VA: 0x181D51C20
	public static EntityIdList Deserialize(Stream stream) { }

	// RVA: 0x1D514C0 Offset: 0x1D4FAC0 VA: 0x181D514C0
	public static EntityIdList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D51540 Offset: 0x1D4FB40 VA: 0x181D51540
	public static EntityIdList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D51840 Offset: 0x1D4FE40 VA: 0x181D51840
	public static EntityIdList Deserialize(byte[] buffer) { }

	// RVA: 0x1D51DF0 Offset: 0x1D503F0 VA: 0x181D51DF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D52440 Offset: 0x1D50A40 VA: 0x181D52440 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D52460 Offset: 0x1D50A60 VA: 0x181D52460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityIdList previous) { }

	// RVA: 0x1D51E10 Offset: 0x1D50410 VA: 0x181D51E10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D51B20 Offset: 0x1D50120 VA: 0x181D51B20
	public static EntityIdList Deserialize(byte[] buffer, EntityIdList instance, bool isDelta = False) { }

	// RVA: 0x1D51960 Offset: 0x1D4FF60 VA: 0x181D51960
	public static EntityIdList Deserialize(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51230 Offset: 0x1D4F830 VA: 0x181D51230
	public static EntityIdList DeserializeLengthDelimited(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D515D0 Offset: 0x1D4FBD0 VA: 0x181D515D0
	public static EntityIdList DeserializeLength(Stream stream, int length, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D51FF0 Offset: 0x1D505F0 VA: 0x181D51FF0
	public static void SerializeDelta(Stream stream, EntityIdList instance, EntityIdList previous) { }

	// RVA: 0x1D522F0 Offset: 0x1D508F0 VA: 0x181D522F0
	public static void Serialize(Stream stream, EntityIdList instance) { }

	// RVA: 0x1D52430 Offset: 0x1D50A30 VA: 0x181D52430
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D52440 Offset: 0x1D50A40 VA: 0x181D52440
	public void ToProto(Stream stream) { }

	// RVA: 0x1D521E0 Offset: 0x1D507E0 VA: 0x181D521E0
	public static byte[] SerializeToBytes(EntityIdList instance) { }

	// RVA: 0x1D52130 Offset: 0x1D50730 VA: 0x181D52130
	public static void SerializeLengthDelimited(Stream stream, EntityIdList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public static class Entity // TypeDefIndex: 6628
{	// Fields
	private static Dictionary<Transform, IEntity> _dict; // 0x3736

	// Methods

	// RVA: 0x1BA2D50 Offset: 0x1BA1350 VA: 0x181BA2D50
	public static void Register(Transform t, IEntity entity) { }

	// RVA: 0x1BA2CC0 Offset: 0x1BA12C0 VA: 0x181BA2CC0
	public static IEntity Get(Transform t) { }

	// RVA: 0x1BA2F90 Offset: 0x1BA1590 VA: 0x181BA2F90
	public static void Unregister(Transform t) { }

	// RVA: 0x1BA2DE0 Offset: 0x1BA13E0 VA: 0x181BA2DE0
	public static void Register(GameObject obj, IEntity entity) { }

	// RVA: 0x1BA2BD0 Offset: 0x1BA11D0 VA: 0x181BA2BD0
	public static IEntity Get(GameObject obj) { }

	// RVA: 0x1BA2EC0 Offset: 0x1BA14C0 VA: 0x181BA2EC0
	public static void Unregister(GameObject obj) { }

	// RVA: 0x1BA3010 Offset: 0x1BA1610 VA: 0x181BA3010
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

	// RVA: 0x8C3E20 Offset: 0x8C2420 VA: 0x1808C3E20
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x8C3FD0 Offset: 0x8C25D0 VA: 0x1808C3FD0
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
	|-RVA: 0x15E6D70 Offset: 0x15E5370 VA: 0x1815E6D70
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	// RVA: -1 Offset: -1
	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6BF0 Offset: 0x15E51F0 VA: 0x1815E6BF0
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override BaseEntity GetBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1356160 Offset: 0x1354760 VA: 0x181356160
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
	|-RVA: 0x15E6D50 Offset: 0x15E5350 VA: 0x1815E6D50
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

	// RVA: 0x8C4010 Offset: 0x8C2610 VA: 0x1808C4010
	private void Update() { }

	// RVA: 0x8C41C0 Offset: 0x8C27C0 VA: 0x1808C41C0
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

	// RVA: 0x8C4430 Offset: 0x8C2A30 VA: 0x1808C4430
	private int get_ParamHash() { }

	// RVA: 0x8C4230 Offset: 0x8C2830 VA: 0x1808C4230 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C43E0 Offset: 0x8C29E0 VA: 0x1808C43E0
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

	// RVA: 0x8C4460 Offset: 0x8C2A60 VA: 0x1808C4460
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

	// RVA: 0x8C46F0 Offset: 0x8C2CF0 VA: 0x1808C46F0
	protected void OnDisable() { }

	// RVA: 0x8C4670 Offset: 0x8C2C70 VA: 0x1808C4670
	public void DoUpdate(BaseEntity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected virtual void OnStateToggled(bool state) { }

	// RVA: 0x8C4700 Offset: 0x8C2D00 VA: 0x1808C4700 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C47F0 Offset: 0x8C2DF0 VA: 0x1808C47F0 Slot: 11
	public void OnSendNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4880 Offset: 0x8C2E80 VA: 0x1808C4880 Slot: 12
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x8C4950 Offset: 0x8C2F50 VA: 0x1808C4950
	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 9495
{	// Fields
	public bool UseEntityParent; // 0x40

	// Methods

	// RVA: 0x8C44A0 Offset: 0x8C2AA0 VA: 0x1808C44A0 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8C4660 Offset: 0x8C2C60 VA: 0x1808C4660
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

	// RVA: 0x8C5010 Offset: 0x8C3610 VA: 0x1808C5010
	private void OnEnable() { }

	// RVA: 0x8C4E20 Offset: 0x8C3420 VA: 0x1808C4E20
	private void DoInitialize(BaseEntity entity) { }

	// RVA: 0x8C50B0 Offset: 0x8C36B0 VA: 0x1808C50B0 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8C4F30 Offset: 0x8C3530 VA: 0x1808C4F30
	public void DoOpen() { }

	// RVA: 0x8C4D40 Offset: 0x8C3340 VA: 0x1808C4D40
	public void DoClose() { }

	[IteratorStateMachineAttribute] // RVA: 0x757A0 Offset: 0x74BA0 VA: 0x1800757A0
	// RVA: 0x8C5460 Offset: 0x8C3A60 VA: 0x1808C5460
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	// RVA: 0x8C54F0 Offset: 0x8C3AF0 VA: 0x1808C54F0
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

	// RVA: 0x8D7010 Offset: 0x8D5610 VA: 0x1808D7010
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

	// RVA: 0x8D9060 Offset: 0x8D7660 VA: 0x1808D9060 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D97C0 Offset: 0x8D7DC0 VA: 0x1808D97C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 9500
{	// Fields
	public float secondsTillDestroy; // 0x20

	// Methods

	// RVA: 0x8C60C0 Offset: 0x8C46C0 VA: 0x1808C60C0
	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 9533
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly bool editorGiveFreeFuel; // 0x11
	private readonly uint fuelStorageID; // 0x14
	public EntityRef<StorageContainer> fuelStorageInstance; // 0x18

	// Methods

	// RVA: 0x8C4B80 Offset: 0x8C3180 VA: 0x1808C4B80
	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	// RVA: 0x8C4A50 Offset: 0x8C3050 VA: 0x1808C4A50
	public bool IsInFuelInteractionRange(BasePlayer player) { }

	// RVA: 0x8C49F0 Offset: 0x8C2FF0 VA: 0x1808C49F0
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

	// RVA: 0x8C5E00 Offset: 0x8C4400 VA: 0x1808C5E00
	public string get_name() { }

	// RVA: 0x8C5D20 Offset: 0x8C4320 VA: 0x1808C5D20
	public void Setup(BaseEntity owner, Socket_Base socket) { }

	// RVA: 0x8C5BB0 Offset: 0x8C41B0 VA: 0x1808C5BB0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x8C5B50 Offset: 0x8C4150 VA: 0x1808C5B50
	public bool Contains(EntityLink entity) { }

	// RVA: 0x8C57C0 Offset: 0x8C3DC0 VA: 0x1808C57C0
	public void Add(EntityLink entity) { }

	// RVA: 0x8C5CC0 Offset: 0x8C42C0 VA: 0x1808C5CC0
	public void Remove(EntityLink entity) { }

	// RVA: 0x8C5A60 Offset: 0x8C4060 VA: 0x1808C5A60
	public void Clear() { }

	// RVA: 0x8C5BF0 Offset: 0x8C41F0 VA: 0x1808C5BF0
	public bool IsEmpty() { }

	// RVA: 0x8C5C70 Offset: 0x8C4270 VA: 0x1808C5C70
	public bool IsOccupied() { }

	// RVA: 0x8C5C50 Offset: 0x8C4250 VA: 0x1808C5C50
	public bool IsMale() { }

	// RVA: 0x8C5C30 Offset: 0x8C4230 VA: 0x1808C5C30
	public bool IsFemale() { }

	// RVA: 0x8C5820 Offset: 0x8C3E20 VA: 0x1808C5820
	public bool CanConnect(EntityLink link) { }

	// RVA: 0x8C5D80 Offset: 0x8C4380 VA: 0x1808C5D80
	public void .ctor() { }

}

public static class EntityLinkEx // TypeDefIndex: 9535
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C56F0 Offset: 0x8C3CF0 VA: 0x1808C56F0
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C5660 Offset: 0x8C3C60 VA: 0x1808C5660
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C5530 Offset: 0x8C3B30 VA: 0x1808C5530
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
	|-RVA: 0x1F4EA0 Offset: 0x1F42A0 VA: 0x1801F4EA0
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4EE0 Offset: 0x1F42E0 VA: 0x1801F4EE0
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	// RVA: -1 Offset: -1
	public bool IsValid(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4DB0 Offset: 0x1F41B0 VA: 0x1801F4DB0
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
	|-RVA: 0x1F4E10 Offset: 0x1F4210 VA: 0x1801F4E10
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
	|-RVA: 0x1F4DA0 Offset: 0x1F41A0 VA: 0x1801F4DA0
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
	|-RVA: 0x1F4E20 Offset: 0x1F4220 VA: 0x1801F4E20
	|-EntityRef<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4EF0 Offset: 0x1F42F0 VA: 0x1801F4EF0
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	// RVA: -1 Offset: -1
	public void set_uid(uint value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F00 Offset: 0x1F4300 VA: 0x1801F4F00
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

	// RVA: 0x8C4BE0 Offset: 0x8C31E0 VA: 0x1808C4BE0
	private void OnWillRenderObject() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 11912
{	// Methods

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6DE8E0 Offset: 0x6DCEE0 VA: 0x1806DE8E0
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6DCD40 Offset: 0x6DB340 VA: 0x1806DCD40
	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DEBF0 Offset: 0x6DD1F0 VA: 0x1806DEBF0
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF020 Offset: 0x6DD620 VA: 0x1806DF020
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DEE10 Offset: 0x6DD410 VA: 0x1806DEE10
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF230 Offset: 0x6DD830 VA: 0x1806DF230
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF930 Offset: 0x6DDF30 VA: 0x1806DF930
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF440 Offset: 0x6DDA40 VA: 0x1806DF440
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6DF6C0 Offset: 0x6DDCC0 VA: 0x1806DF6C0
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99190 Offset: 0x98590 VA: 0x180099190
	// RVA: 0x6DDFA0 Offset: 0x6DC5A0 VA: 0x1806DDFA0
	public static void clspawn(string name) { }

	[ClientVar] // RVA: 0x993D0 Offset: 0x987D0 VA: 0x1800993D0
	// RVA: 0x6DE1D0 Offset: 0x6DC7D0 VA: 0x1806DE1D0
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x996C0 Offset: 0x98AC0 VA: 0x1800996C0
	// RVA: 0x6DE420 Offset: 0x6DCA20 VA: 0x1806DE420
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99880 Offset: 0x98C80 VA: 0x180099880
	// RVA: 0x6DE7C0 Offset: 0x6DCDC0 VA: 0x1806DE7C0
	public static void clspawnitem(string name) { }

	[ClientVar] // RVA: 0x99C00 Offset: 0x99000 VA: 0x180099C00
	// RVA: 0x6DD9A0 Offset: 0x6DBFA0 VA: 0x1806DD9A0
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DD600 Offset: 0x6DBC00 VA: 0x1806DD600
	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] // RVA: 0x99DF0 Offset: 0x991F0 VA: 0x180099DF0
	// RVA: 0x6DC9F0 Offset: 0x6DAFF0 VA: 0x1806DC9F0
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DDF40 Offset: 0x6DC540 VA: 0x1806DDF40
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

	// RVA: 0x6E8480 Offset: 0x6E6A80 VA: 0x1806E8480
	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 11915
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E85D0 Offset: 0x6E6BD0 VA: 0x1806E85D0
	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 11916
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E85F0 Offset: 0x6E6BF0 VA: 0x1806E85F0
	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 11917
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8610 Offset: 0x6E6C10 VA: 0x1806E8610
	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 11918
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8630 Offset: 0x6E6C30 VA: 0x1806E8630
	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 11919
{	// Fields
	public BasePlayer player; // 0x10
	public uint filter; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8690 Offset: 0x6E6C90 VA: 0x1806E8690
	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 11920
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E85D0 Offset: 0x6E6BD0 VA: 0x1806E85D0
	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

