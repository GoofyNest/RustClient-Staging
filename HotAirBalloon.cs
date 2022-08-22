public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6344
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float inflationAmount; // 0x14
	public Vector3 velocity; // 0x18

	// Methods

	// RVA: 0x1BFE010 Offset: 0x1BFC610 VA: 0x181BFE010
	public static void ResetToPool(HotAirBalloon instance) { }

	// RVA: 0x1BFE0A0 Offset: 0x1BFC6A0 VA: 0x181BFE0A0
	public void ResetToPool() { }

	// RVA: 0x1BFDEC0 Offset: 0x1BFC4C0 VA: 0x181BFDEC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD440 Offset: 0x1BFBA40 VA: 0x181BFD440
	public void CopyTo(HotAirBalloon instance) { }

	// RVA: 0x1BFD470 Offset: 0x1BFBA70 VA: 0x181BFD470
	public HotAirBalloon Copy() { }

	// RVA: 0x1BFDA90 Offset: 0x1BFC090 VA: 0x181BFDA90
	public static HotAirBalloon Deserialize(Stream stream) { }

	// RVA: 0x1BFD4F0 Offset: 0x1BFBAF0 VA: 0x181BFD4F0
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFD7D0 Offset: 0x1BFBDD0 VA: 0x181BFD7D0
	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFDB10 Offset: 0x1BFC110 VA: 0x181BFDB10
	public static HotAirBalloon Deserialize(byte[] buffer) { }

	// RVA: 0x1BFDFD0 Offset: 0x1BFC5D0 VA: 0x181BFDFD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFE750 Offset: 0x1BFCD50 VA: 0x181BFE750 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFE770 Offset: 0x1BFCD70 VA: 0x181BFE770 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	// RVA: 0x1BFDFF0 Offset: 0x1BFC5F0 VA: 0x181BFDFF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFDC30 Offset: 0x1BFC230 VA: 0x181BFDC30
	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	// RVA: 0x1BFDD30 Offset: 0x1BFC330 VA: 0x181BFDD30
	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFD570 Offset: 0x1BFBB70 VA: 0x181BFD570
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFD860 Offset: 0x1BFBE60 VA: 0x181BFD860
	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFE130 Offset: 0x1BFC730 VA: 0x181BFE130
	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	// RVA: 0x1BFE5A0 Offset: 0x1BFCBA0 VA: 0x181BFE5A0
	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1BFE740 Offset: 0x1BFCD40 VA: 0x181BFE740
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFE750 Offset: 0x1BFCD50 VA: 0x181BFE750
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFE490 Offset: 0x1BFCA90 VA: 0x181BFE490
	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	// RVA: 0x1BFE3E0 Offset: 0x1BFC9E0 VA: 0x181BFE3E0
	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class HotAirBalloon : BaseCombatEntity // TypeDefIndex: 8398
{	// Fields
	private Option __menuOption_Menu_BurnOff; // 0x240
	private Option __menuOption_Menu_BurnOn; // 0x298
	private Option __menuOption_Menu_FuelStorage; // 0x2F0
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_HalfInflated = 128;
	protected const BaseEntity.Flags Flag_FullInflated = 256;
	public Transform centerOfMass; // 0x348
	public Rigidbody myRigidbody; // 0x350
	public Transform buoyancyPoint; // 0x358
	public float liftAmount; // 0x360
	public Transform windSock; // 0x368
	public Transform[] windFlags; // 0x370
	public GameObject staticBalloonDeflated; // 0x378
	public GameObject staticBalloon; // 0x380
	public GameObject animatedBalloon; // 0x388
	public Animator balloonAnimator; // 0x390
	public Transform groundSample; // 0x398
	public float inflationLevel; // 0x3A0
	[HeaderAttribute] // RVA: 0x78540 Offset: 0x77940 VA: 0x180078540
	public GameObjectRef fuelStoragePrefab; // 0x3A8
	public float fuelPerSec; // 0x3B0
	[HeaderAttribute] // RVA: 0x786B0 Offset: 0x77AB0 VA: 0x1800786B0
	public GameObjectRef storageUnitPrefab; // 0x3B8
	public EntityRef<StorageContainer> storageUnitInstance; // 0x3C0
	[HeaderAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	public DamageRenderer damageRenderer; // 0x3D0
	public Transform engineHeight; // 0x3D8
	public GameObject[] killTriggers; // 0x3E0
	private EntityFuelSystem fuelSystem; // 0x3E8
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x0
	[ServerVar] // RVA: 0xE7830 Offset: 0xE6C30 VA: 0x1800E7830
	public static float outsidedecayminutes; // 0x4
	public float windForce; // 0x3F0
	public Vector3 currentWindVec; // 0x3F4
	public Bounds collapsedBounds; // 0x400
	public Bounds raisedBounds; // 0x418
	public GameObject[] balloonColliders; // 0x430
	private float currentClientInflationLevel; // 0x438
	private Vector3 windSockVec; // 0x43C

	// Properties
	public override bool HasMenuOptions { get; }
	public bool IsFullyInflated { get; }

	// Methods

	// RVA: 0x7437A0 Offset: 0x741DA0 VA: 0x1807437A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x744EE0 Offset: 0x7434E0 VA: 0x180744EE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x744580 Offset: 0x742B80 VA: 0x180744580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7450B0 Offset: 0x7436B0 VA: 0x1807450B0
	public bool get_IsFullyInflated() { }

	// RVA: 0x744090 Offset: 0x742690 VA: 0x180744090 Slot: 28
	public override void InitShared() { }

	// RVA: 0x744140 Offset: 0x742740 VA: 0x180744140 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x744D70 Offset: 0x743370 VA: 0x180744D70
	public bool WaterLogged() { }

	[BaseEntity.Menu] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.Description] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.Icon] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	// RVA: 0x744440 Offset: 0x742A40 VA: 0x180744440
	public void Menu_BurnOn(BasePlayer player) { }

	// RVA: 0x744310 Offset: 0x742910 VA: 0x180744310
	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.Description] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.Icon] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	// RVA: 0x7442C0 Offset: 0x7428C0 VA: 0x1807442C0
	public void Menu_BurnOff(BasePlayer player) { }

	// RVA: 0x744200 Offset: 0x742800 VA: 0x180744200
	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.Description] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.Icon] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	// RVA: 0x744540 Offset: 0x742B40 VA: 0x180744540
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x744490 Offset: 0x742A90 VA: 0x180744490
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x743680 Offset: 0x741C80 VA: 0x180743680 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7448C0 Offset: 0x742EC0 VA: 0x1807448C0
	public void Update() { }

	// RVA: 0x744670 Offset: 0x742C70 VA: 0x180744670
	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	// RVA: 0x7446C0 Offset: 0x742CC0 VA: 0x1807446C0
	public void UpdateBalloonMesh(float inf) { }

	// RVA: 0x7436B0 Offset: 0x741CB0 VA: 0x1807436B0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x743F50 Offset: 0x742550 VA: 0x180743F50
	public Vector3 GetWindAtPos(Vector3 pos) { }

	// RVA: 0x744E20 Offset: 0x743420 VA: 0x180744E20
	public void .ctor() { }

	// RVA: 0x744DD0 Offset: 0x7433D0 VA: 0x180744DD0
	private static void .cctor() { }

}

