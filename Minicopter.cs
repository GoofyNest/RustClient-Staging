public class Minicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6347
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint fuelStorageID; // 0x14
	public float fuelFraction; // 0x18
	public float pitch; // 0x1C
	public float roll; // 0x20
	public float yaw; // 0x24

	// Methods

	// RVA: 0x1F48B60 Offset: 0x1F47160 VA: 0x181F48B60
	public static void ResetToPool(Minicopter instance) { }

	// RVA: 0x1F48AB0 Offset: 0x1F470B0 VA: 0x181F48AB0
	public void ResetToPool() { }

	// RVA: 0x1F48700 Offset: 0x1F46D00 VA: 0x181F48700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21C60 Offset: 0x1E20260 VA: 0x181E21C60
	public void CopyTo(Minicopter instance) { }

	// RVA: 0x1F473B0 Offset: 0x1F459B0 VA: 0x181F473B0
	public Minicopter Copy() { }

	// RVA: 0x1F47B80 Offset: 0x1F46180 VA: 0x181F47B80
	public static Minicopter Deserialize(Stream stream) { }

	// RVA: 0x1F47760 Offset: 0x1F45D60 VA: 0x181F47760
	public static Minicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F477E0 Offset: 0x1F45DE0 VA: 0x181F477E0
	public static Minicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F48080 Offset: 0x1F46680 VA: 0x181F48080
	public static Minicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1F48830 Offset: 0x1F46E30 VA: 0x181F48830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F491E0 Offset: 0x1F477E0 VA: 0x181F491E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F49200 Offset: 0x1F47800 VA: 0x181F49200 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Minicopter previous) { }

	// RVA: 0x1F48A90 Offset: 0x1F47090 VA: 0x181F48A90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F483D0 Offset: 0x1F469D0 VA: 0x181F483D0
	public static Minicopter Deserialize(byte[] buffer, Minicopter instance, bool isDelta = False) { }

	// RVA: 0x1F47E20 Offset: 0x1F46420 VA: 0x181F47E20
	public static Minicopter Deserialize(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F47430 Offset: 0x1F45A30 VA: 0x181F47430
	public static Minicopter DeserializeLengthDelimited(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F47870 Offset: 0x1F45E70 VA: 0x181F47870
	public static Minicopter DeserializeLength(Stream stream, int length, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F48C10 Offset: 0x1F47210 VA: 0x181F48C10
	public static void SerializeDelta(Stream stream, Minicopter instance, Minicopter previous) { }

	// RVA: 0x1F49060 Offset: 0x1F47660 VA: 0x181F49060
	public static void Serialize(Stream stream, Minicopter instance) { }

	// RVA: 0x1F491D0 Offset: 0x1F477D0 VA: 0x181F491D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F491E0 Offset: 0x1F477E0 VA: 0x181F491E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F48F50 Offset: 0x1F47550 VA: 0x181F48F50
	public static byte[] SerializeToBytes(Minicopter instance) { }

	// RVA: 0x1F48EA0 Offset: 0x1F474A0 VA: 0x181F48EA0
	public static void SerializeLengthDelimited(Stream stream, Minicopter instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class MiniCopter : BaseHelicopterVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 8292
{	// Fields
	[HeaderAttribute] // RVA: 0x78540 Offset: 0x77940 VA: 0x180078540
	public GameObjectRef fuelStoragePrefab; // 0x4D0
	public float fuelPerSec; // 0x4D8
	public float fuelGaugeMax; // 0x4DC
	private float cachedFuelFraction; // 0x4E0
	public Transform waterSample; // 0x4E8
	public WheelCollider leftWheel; // 0x4F0
	public WheelCollider rightWheel; // 0x4F8
	public WheelCollider frontWheel; // 0x500
	public Transform leftWheelTrans; // 0x508
	public Transform rightWheelTrans; // 0x510
	public Transform frontWheelTrans; // 0x518
	public float cachedrotation_left; // 0x520
	public float cachedrotation_right; // 0x524
	public float cachedrotation_front; // 0x528
	[HeaderAttribute] // RVA: 0x7F560 Offset: 0x7E960 VA: 0x18007F560
	public Transform joystickPositionLeft; // 0x530
	public Transform joystickPositionRight; // 0x538
	public Transform leftFootPosition; // 0x540
	public Transform rightFootPosition; // 0x548
	public AnimationCurve bladeEngineCurve; // 0x550
	public Animator animator; // 0x558
	public float maxRotorSpeed; // 0x560
	public float timeUntilMaxRotorSpeed; // 0x564
	public float rotorBlurThreshold; // 0x568
	public Transform mainRotorBlur; // 0x570
	public Transform mainRotorBlades; // 0x578
	public Transform rearRotorBlades; // 0x580
	public Transform rearRotorBlur; // 0x588
	public float motorForceConstant; // 0x590
	public float brakeForceConstant; // 0x594
	public GameObject preventBuildingObject; // 0x598
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x0
	[ServerVar] // RVA: 0xAC3A0 Offset: 0xAB7A0 VA: 0x1800AC3A0
	public static float outsidedecayminutes; // 0x4
	[ServerVar] // RVA: 0xAC500 Offset: 0xAB900 VA: 0x1800AC500
	public static float insidedecayminutes; // 0x8
	private VehicleEngineController<MiniCopter> engineController; // 0x5A0
	private float leftWheelVelocity; // 0x5A8
	private float rightWheelVelocity; // 0x5AC
	private float rotorSpeed; // 0x5B0
	private float mainRotorBlurRotation; // 0x5B4
	private float mainRotorRotation; // 0x5B8
	private float rearRotorBlurRotation; // 0x5BC
	private float rearRotorRotation; // 0x5C0
	private float cachedPitch; // 0x5C4
	private float cachedYaw; // 0x5C8
	private float cachedRoll; // 0x5CC
	protected static int fuelAnimationIndex; // 0xC
	protected static int pitchAnimationIndex; // 0x10
	protected static int rollAnimationIndex; // 0x14
	protected static int yawAnimationIndex; // 0x18
	protected int fuelShakeIndex; // 0x5D0
	private Option __menuOption_Menu_FuelStorage; // 0x5D8

	// Properties
	public bool IsStartingUp { get; }
	public VehicleEngineController.EngineState<MiniCopter> CurEngineState { get; }
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x765E90 Offset: 0x764490 VA: 0x180765E90
	public float GetFuelFraction() { }

	[BaseEntity.Menu] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Description] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Icon] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.ShowIf] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	// RVA: 0x766530 Offset: 0x764B30 VA: 0x180766530
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7663E0 Offset: 0x7649E0 VA: 0x1807663E0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x767860 Offset: 0x765E60 VA: 0x180767860
	public bool get_IsStartingUp() { }

	// RVA: 0x767750 Offset: 0x765D50 VA: 0x180767750
	public VehicleEngineController.EngineState<MiniCopter> get_CurEngineState() { }

	// RVA: 0x7661B0 Offset: 0x7647B0 VA: 0x1807661B0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x767310 Offset: 0x765910 VA: 0x180767310
	public void Update() { }

	// RVA: 0x766760 Offset: 0x764D60 VA: 0x180766760 Slot: 197
	public virtual void UpdateAnimator() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 198
	protected virtual float GetMainRotorScale() { }

	// RVA: 0x766D70 Offset: 0x765370 VA: 0x180766D70
	public void UpdateRotor(float delta) { }

	// RVA: 0x766280 Offset: 0x764880 VA: 0x180766280
	public void LateUpdate() { }

	// RVA: 0x766B30 Offset: 0x765130 VA: 0x180766B30 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x766730 Offset: 0x764D30 VA: 0x180766730
	public float RemapValue(float toUse, float maxRemap) { }

	// RVA: 0x7662C0 Offset: 0x7648C0 VA: 0x1807662C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x765C90 Offset: 0x764290 VA: 0x180765C90 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x766740 Offset: 0x764D40 VA: 0x180766740
	public void TryUpdateLayerIndicies() { }

	// RVA: 0x766AD0 Offset: 0x7650D0 VA: 0x180766AD0 Slot: 199
	public virtual void UpdateLayerIndicies() { }

	// RVA: 0x766570 Offset: 0x764B70 VA: 0x180766570 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x765C30 Offset: 0x764230 VA: 0x180765C30 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x765EA0 Offset: 0x7644A0 VA: 0x180765EA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7677A0 Offset: 0x765DA0 VA: 0x1807677A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x766640 Offset: 0x764C40 VA: 0x180766640 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7676F0 Offset: 0x765CF0 VA: 0x1807676F0
	public void .ctor() { }

	// RVA: 0x767610 Offset: 0x765C10 VA: 0x180767610
	private static void .cctor() { }

}

