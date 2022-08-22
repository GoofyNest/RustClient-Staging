public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6344
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float inflationAmount; // 0x14
	public Vector3 velocity; // 0x18

	// Methods

	// RVA: 0x1BFE800 Offset: 0x1BFCE00 VA: 0x181BFE800
	public static void ResetToPool(HotAirBalloon instance) { }

	// RVA: 0x1BFE890 Offset: 0x1BFCE90 VA: 0x181BFE890
	public void ResetToPool() { }

	// RVA: 0x1BFE6B0 Offset: 0x1BFCCB0 VA: 0x181BFE6B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFDC30 Offset: 0x1BFC230 VA: 0x181BFDC30
	public void CopyTo(HotAirBalloon instance) { }

	// RVA: 0x1BFDC60 Offset: 0x1BFC260 VA: 0x181BFDC60
	public HotAirBalloon Copy() { }

	// RVA: 0x1BFE280 Offset: 0x1BFC880 VA: 0x181BFE280
	public static HotAirBalloon Deserialize(Stream stream) { }

	// RVA: 0x1BFDCE0 Offset: 0x1BFC2E0 VA: 0x181BFDCE0
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFDFC0 Offset: 0x1BFC5C0 VA: 0x181BFDFC0
	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFE300 Offset: 0x1BFC900 VA: 0x181BFE300
	public static HotAirBalloon Deserialize(byte[] buffer) { }

	// RVA: 0x1BFE7C0 Offset: 0x1BFCDC0 VA: 0x181BFE7C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFEF40 Offset: 0x1BFD540 VA: 0x181BFEF40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFEF60 Offset: 0x1BFD560 VA: 0x181BFEF60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	// RVA: 0x1BFE7E0 Offset: 0x1BFCDE0 VA: 0x181BFE7E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFE420 Offset: 0x1BFCA20 VA: 0x181BFE420
	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	// RVA: 0x1BFE520 Offset: 0x1BFCB20 VA: 0x181BFE520
	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFDD60 Offset: 0x1BFC360 VA: 0x181BFDD60
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFE050 Offset: 0x1BFC650 VA: 0x181BFE050
	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BFE920 Offset: 0x1BFCF20 VA: 0x181BFE920
	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	// RVA: 0x1BFED90 Offset: 0x1BFD390 VA: 0x181BFED90
	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1BFEF30 Offset: 0x1BFD530 VA: 0x181BFEF30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFEF40 Offset: 0x1BFD540 VA: 0x181BFEF40
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFEC80 Offset: 0x1BFD280 VA: 0x181BFEC80
	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	// RVA: 0x1BFEBD0 Offset: 0x1BFD1D0 VA: 0x181BFEBD0
	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x7436F0 Offset: 0x741CF0 VA: 0x1807436F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x744E30 Offset: 0x743430 VA: 0x180744E30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7444D0 Offset: 0x742AD0 VA: 0x1807444D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x745000 Offset: 0x743600 VA: 0x180745000
	public bool get_IsFullyInflated() { }

	// RVA: 0x743FE0 Offset: 0x7425E0 VA: 0x180743FE0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x744090 Offset: 0x742690 VA: 0x180744090 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x744CC0 Offset: 0x7432C0 VA: 0x180744CC0
	public bool WaterLogged() { }

	[BaseEntity.Menu] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.Description] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.Icon] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE78A0 Offset: 0xE6CA0 VA: 0x1800E78A0
	// RVA: 0x744390 Offset: 0x742990 VA: 0x180744390
	public void Menu_BurnOn(BasePlayer player) { }

	// RVA: 0x744260 Offset: 0x742860 VA: 0x180744260
	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.Description] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.Icon] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE79F0 Offset: 0xE6DF0 VA: 0x1800E79F0
	// RVA: 0x744210 Offset: 0x742810 VA: 0x180744210
	public void Menu_BurnOff(BasePlayer player) { }

	// RVA: 0x744150 Offset: 0x742750 VA: 0x180744150
	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.Description] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.Icon] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7B70 Offset: 0xE6F70 VA: 0x1800E7B70
	// RVA: 0x744490 Offset: 0x742A90 VA: 0x180744490
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7443E0 Offset: 0x7429E0 VA: 0x1807443E0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7435D0 Offset: 0x741BD0 VA: 0x1807435D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x744810 Offset: 0x742E10 VA: 0x180744810
	public void Update() { }

	// RVA: 0x7445C0 Offset: 0x742BC0 VA: 0x1807445C0
	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	// RVA: 0x744610 Offset: 0x742C10 VA: 0x180744610
	public void UpdateBalloonMesh(float inf) { }

	// RVA: 0x743600 Offset: 0x741C00 VA: 0x180743600 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x743EA0 Offset: 0x7424A0 VA: 0x180743EA0
	public Vector3 GetWindAtPos(Vector3 pos) { }

	// RVA: 0x744D70 Offset: 0x743370 VA: 0x180744D70
	public void .ctor() { }

	// RVA: 0x744D20 Offset: 0x743320 VA: 0x180744D20
	private static void .cctor() { }

}

