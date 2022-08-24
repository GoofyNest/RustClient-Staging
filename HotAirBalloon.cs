public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6344
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float inflationAmount; // 0x14
	public Vector3 velocity; // 0x18


	public static void ResetToPool(HotAirBalloon instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(HotAirBalloon instance) { }

	public HotAirBalloon Copy() { }

	public static HotAirBalloon Deserialize(Stream stream) { }

	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	public static HotAirBalloon Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	public void .ctor() { }

}

public class HotAirBalloon : BaseCombatEntity // TypeDefIndex: 8398
{	private Option __menuOption_Menu_BurnOff; // 0x240
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
	[HeaderAttribute] // RVA: 0x785A0 Offset: 0x779A0 VA: 0x1800785A0
	public GameObjectRef fuelStoragePrefab; // 0x3A8
	public float fuelPerSec; // 0x3B0
	[HeaderAttribute] // RVA: 0x78720 Offset: 0x77B20 VA: 0x180078720
	public GameObjectRef storageUnitPrefab; // 0x3B8
	public EntityRef<StorageContainer> storageUnitInstance; // 0x3C0
	[HeaderAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	public DamageRenderer damageRenderer; // 0x3D0
	public Transform engineHeight; // 0x3D8
	public GameObject[] killTriggers; // 0x3E0
	private EntityFuelSystem fuelSystem; // 0x3E8
	[ServerVar] // RVA: 0x71FC0 Offset: 0x713C0 VA: 0x180071FC0
	public static float population; // 0x0
	[ServerVar] // RVA: 0xE7950 Offset: 0xE6D50 VA: 0x1800E7950
	public static float outsidedecayminutes; // 0x4
	public float windForce; // 0x3F0
	public Vector3 currentWindVec; // 0x3F4
	public Bounds collapsedBounds; // 0x400
	public Bounds raisedBounds; // 0x418
	public GameObject[] balloonColliders; // 0x430
	private float currentClientInflationLevel; // 0x438
	private Vector3 windSockVec; // 0x43C

	public override bool HasMenuOptions { get; }
	public bool IsFullyInflated { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool get_IsFullyInflated() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool WaterLogged() { }

	[BaseEntity.Menu] // RVA: 0xE79C0 Offset: 0xE6DC0 VA: 0x1800E79C0
	[BaseEntity.Menu.Description] // RVA: 0xE79C0 Offset: 0xE6DC0 VA: 0x1800E79C0
	[BaseEntity.Menu.Icon] // RVA: 0xE79C0 Offset: 0xE6DC0 VA: 0x1800E79C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE79C0 Offset: 0xE6DC0 VA: 0x1800E79C0
	public void Menu_BurnOn(BasePlayer player) { }

	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7B10 Offset: 0xE6F10 VA: 0x1800E7B10
	[BaseEntity.Menu.Description] // RVA: 0xE7B10 Offset: 0xE6F10 VA: 0x1800E7B10
	[BaseEntity.Menu.Icon] // RVA: 0xE7B10 Offset: 0xE6F10 VA: 0x1800E7B10
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7B10 Offset: 0xE6F10 VA: 0x1800E7B10
	public void Menu_BurnOff(BasePlayer player) { }

	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7C60 Offset: 0xE7060 VA: 0x1800E7C60
	[BaseEntity.Menu.Description] // RVA: 0xE7C60 Offset: 0xE7060 VA: 0x1800E7C60
	[BaseEntity.Menu.Icon] // RVA: 0xE7C60 Offset: 0xE7060 VA: 0x1800E7C60
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7C60 Offset: 0xE7060 VA: 0x1800E7C60
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	public void UpdateBalloonMesh(float inf) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public Vector3 GetWindAtPos(Vector3 pos) { }

	public void .ctor() { }

	private static void .cctor() { }

}

