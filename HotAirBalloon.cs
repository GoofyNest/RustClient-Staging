public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6344
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float inflationAmount; // 0x14
	public Vector3 velocity; // 0x18

	// Methods

	// RVA: 0x1BFDF10 Offset: 0x1BFC510 VA: 0x181BFDF10
	public static void ResetToPool(HotAirBalloon instance) { }

	// RVA: 0x1BFDFA0 Offset: 0x1BFC5A0 VA: 0x181BFDFA0
	public void ResetToPool() { }

	// RVA: 0x1BFDDC0 Offset: 0x1BFC3C0 VA: 0x181BFDDC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD340 Offset: 0x1BFB940 VA: 0x181BFD340
	public void CopyTo(HotAirBalloon instance) { }

	// RVA: 0x1BFD370 Offset: 0x1BFB970 VA: 0x181BFD370
	public HotAirBalloon Copy() { }

	// RVA: 0x1BFD990 Offset: 0x1BFBF90 VA: 0x181BFD990
	public static HotAirBalloon Deserialize(Stream stream) { }

	// RVA: 0x1BFD3F0 Offset: 0x1BFB9F0 VA: 0x181BFD3F0
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFD6D0 Offset: 0x1BFBCD0 VA: 0x181BFD6D0
	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFDA10 Offset: 0x1BFC010 VA: 0x181BFDA10
	public static HotAirBalloon Deserialize(byte[] buffer) { }

	// RVA: 0x1BFDED0 Offset: 0x1BFC4D0 VA: 0x181BFDED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFE650 Offset: 0x1BFCC50 VA: 0x181BFE650 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFE670 Offset: 0x1BFCC70 VA: 0x181BFE670 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	// RVA: 0x1BFDEF0 Offset: 0x1BFC4F0 VA: 0x181BFDEF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFDB30 Offset: 0x1BFC130 VA: 0x181BFDB30
	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	// RVA: 0x1BFDC30 Offset: 0x1BFC230 VA: 0x181BFDC30
	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFD470 Offset: 0x1BFBA70 VA: 0x181BFD470
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFD760 Offset: 0x1BFBD60 VA: 0x181BFD760
	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFE030 Offset: 0x1BFC630 VA: 0x181BFE030
	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	// RVA: 0x1BFE4A0 Offset: 0x1BFCAA0 VA: 0x181BFE4A0
	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1BFE640 Offset: 0x1BFCC40 VA: 0x181BFE640
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFE650 Offset: 0x1BFCC50 VA: 0x181BFE650
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFE390 Offset: 0x1BFC990 VA: 0x181BFE390
	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	// RVA: 0x1BFE2E0 Offset: 0x1BFC8E0 VA: 0x181BFE2E0
	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[HeaderAttribute] // RVA: 0x78440 Offset: 0x77840 VA: 0x180078440
	public GameObjectRef fuelStoragePrefab; // 0x3A8
	public float fuelPerSec; // 0x3B0
	[HeaderAttribute] // RVA: 0x78560 Offset: 0x77960 VA: 0x180078560
	public GameObjectRef storageUnitPrefab; // 0x3B8
	public EntityRef<StorageContainer> storageUnitInstance; // 0x3C0
	[HeaderAttribute] // RVA: 0xCB670 Offset: 0xCAA70 VA: 0x1800CB670
	public DamageRenderer damageRenderer; // 0x3D0
	public Transform engineHeight; // 0x3D8
	public GameObject[] killTriggers; // 0x3E0
	private EntityFuelSystem fuelSystem; // 0x3E8
	[ServerVar] // RVA: 0x71E60 Offset: 0x71260 VA: 0x180071E60
	public static float population; // 0x0
	[ServerVar] // RVA: 0xE7760 Offset: 0xE6B60 VA: 0x1800E7760
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

	// RVA: 0x743690 Offset: 0x741C90 VA: 0x180743690 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x744DD0 Offset: 0x7433D0 VA: 0x180744DD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x744470 Offset: 0x742A70 VA: 0x180744470 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x744FA0 Offset: 0x7435A0 VA: 0x180744FA0
	public bool get_IsFullyInflated() { }

	// RVA: 0x743F80 Offset: 0x742580 VA: 0x180743F80 Slot: 28
	public override void InitShared() { }

	// RVA: 0x744030 Offset: 0x742630 VA: 0x180744030 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x744C60 Offset: 0x743260 VA: 0x180744C60
	public bool WaterLogged() { }

	[BaseEntity.Menu] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	[BaseEntity.Menu.Description] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	[BaseEntity.Menu.Icon] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	// RVA: 0x744330 Offset: 0x742930 VA: 0x180744330
	public void Menu_BurnOn(BasePlayer player) { }

	// RVA: 0x744200 Offset: 0x742800 VA: 0x180744200
	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7950 Offset: 0xE6D50 VA: 0x1800E7950
	[BaseEntity.Menu.Description] // RVA: 0xE7950 Offset: 0xE6D50 VA: 0x1800E7950
	[BaseEntity.Menu.Icon] // RVA: 0xE7950 Offset: 0xE6D50 VA: 0x1800E7950
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7950 Offset: 0xE6D50 VA: 0x1800E7950
	// RVA: 0x7441B0 Offset: 0x7427B0 VA: 0x1807441B0
	public void Menu_BurnOff(BasePlayer player) { }

	// RVA: 0x7440F0 Offset: 0x7426F0 VA: 0x1807440F0
	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7AF0 Offset: 0xE6EF0 VA: 0x1800E7AF0
	[BaseEntity.Menu.Description] // RVA: 0xE7AF0 Offset: 0xE6EF0 VA: 0x1800E7AF0
	[BaseEntity.Menu.Icon] // RVA: 0xE7AF0 Offset: 0xE6EF0 VA: 0x1800E7AF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7AF0 Offset: 0xE6EF0 VA: 0x1800E7AF0
	// RVA: 0x744430 Offset: 0x742A30 VA: 0x180744430
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x744380 Offset: 0x742980 VA: 0x180744380
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x743570 Offset: 0x741B70 VA: 0x180743570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7447B0 Offset: 0x742DB0 VA: 0x1807447B0
	public void Update() { }

	// RVA: 0x744560 Offset: 0x742B60 VA: 0x180744560
	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	// RVA: 0x7445B0 Offset: 0x742BB0 VA: 0x1807445B0
	public void UpdateBalloonMesh(float inf) { }

	// RVA: 0x7435A0 Offset: 0x741BA0 VA: 0x1807435A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x743E40 Offset: 0x742440 VA: 0x180743E40
	public Vector3 GetWindAtPos(Vector3 pos) { }

	// RVA: 0x744D10 Offset: 0x743310 VA: 0x180744D10
	public void .ctor() { }

	// RVA: 0x744CC0 Offset: 0x7432C0 VA: 0x180744CC0
	private static void .cctor() { }

}

