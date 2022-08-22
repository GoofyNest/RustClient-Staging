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

	// RVA: 0x1F488A0 Offset: 0x1F46EA0 VA: 0x181F488A0
	public static void ResetToPool(Minicopter instance) { }

	// RVA: 0x1F487F0 Offset: 0x1F46DF0 VA: 0x181F487F0
	public void ResetToPool() { }

	// RVA: 0x1F48440 Offset: 0x1F46A40 VA: 0x181F48440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E219A0 Offset: 0x1E1FFA0 VA: 0x181E219A0
	public void CopyTo(Minicopter instance) { }

	// RVA: 0x1F470F0 Offset: 0x1F456F0 VA: 0x181F470F0
	public Minicopter Copy() { }

	// RVA: 0x1F478C0 Offset: 0x1F45EC0 VA: 0x181F478C0
	public static Minicopter Deserialize(Stream stream) { }

	// RVA: 0x1F474A0 Offset: 0x1F45AA0 VA: 0x181F474A0
	public static Minicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F47520 Offset: 0x1F45B20 VA: 0x181F47520
	public static Minicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F47DC0 Offset: 0x1F463C0 VA: 0x181F47DC0
	public static Minicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1F48570 Offset: 0x1F46B70 VA: 0x181F48570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F48F20 Offset: 0x1F47520 VA: 0x181F48F20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F48F40 Offset: 0x1F47540 VA: 0x181F48F40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Minicopter previous) { }

	// RVA: 0x1F487D0 Offset: 0x1F46DD0 VA: 0x181F487D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F48110 Offset: 0x1F46710 VA: 0x181F48110
	public static Minicopter Deserialize(byte[] buffer, Minicopter instance, bool isDelta = False) { }

	// RVA: 0x1F47B60 Offset: 0x1F46160 VA: 0x181F47B60
	public static Minicopter Deserialize(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F47170 Offset: 0x1F45770 VA: 0x181F47170
	public static Minicopter DeserializeLengthDelimited(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F475B0 Offset: 0x1F45BB0 VA: 0x181F475B0
	public static Minicopter DeserializeLength(Stream stream, int length, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F48950 Offset: 0x1F46F50 VA: 0x181F48950
	public static void SerializeDelta(Stream stream, Minicopter instance, Minicopter previous) { }

	// RVA: 0x1F48DA0 Offset: 0x1F473A0 VA: 0x181F48DA0
	public static void Serialize(Stream stream, Minicopter instance) { }

	// RVA: 0x1F48F10 Offset: 0x1F47510 VA: 0x181F48F10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F48F20 Offset: 0x1F47520 VA: 0x181F48F20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F48C90 Offset: 0x1F47290 VA: 0x181F48C90
	public static byte[] SerializeToBytes(Minicopter instance) { }

	// RVA: 0x1F48BE0 Offset: 0x1F471E0 VA: 0x181F48BE0
	public static void SerializeLengthDelimited(Stream stream, Minicopter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x765D80 Offset: 0x764380 VA: 0x180765D80
	public float GetFuelFraction() { }

	[BaseEntity.Menu] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Description] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Icon] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.ShowIf] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	// RVA: 0x766420 Offset: 0x764A20 VA: 0x180766420
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7662D0 Offset: 0x7648D0 VA: 0x1807662D0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x767750 Offset: 0x765D50 VA: 0x180767750
	public bool get_IsStartingUp() { }

	// RVA: 0x767640 Offset: 0x765C40 VA: 0x180767640
	public VehicleEngineController.EngineState<MiniCopter> get_CurEngineState() { }

	// RVA: 0x7660A0 Offset: 0x7646A0 VA: 0x1807660A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x767200 Offset: 0x765800 VA: 0x180767200
	public void Update() { }

	// RVA: 0x766650 Offset: 0x764C50 VA: 0x180766650 Slot: 197
	public virtual void UpdateAnimator() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 198
	protected virtual float GetMainRotorScale() { }

	// RVA: 0x766C60 Offset: 0x765260 VA: 0x180766C60
	public void UpdateRotor(float delta) { }

	// RVA: 0x766170 Offset: 0x764770 VA: 0x180766170
	public void LateUpdate() { }

	// RVA: 0x766A20 Offset: 0x765020 VA: 0x180766A20 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x766620 Offset: 0x764C20 VA: 0x180766620
	public float RemapValue(float toUse, float maxRemap) { }

	// RVA: 0x7661B0 Offset: 0x7647B0 VA: 0x1807661B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x765B80 Offset: 0x764180 VA: 0x180765B80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x766630 Offset: 0x764C30 VA: 0x180766630
	public void TryUpdateLayerIndicies() { }

	// RVA: 0x7669C0 Offset: 0x764FC0 VA: 0x1807669C0 Slot: 199
	public virtual void UpdateLayerIndicies() { }

	// RVA: 0x766460 Offset: 0x764A60 VA: 0x180766460 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x765B20 Offset: 0x764120 VA: 0x180765B20 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x765D90 Offset: 0x764390 VA: 0x180765D90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x767690 Offset: 0x765C90 VA: 0x180767690 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x766530 Offset: 0x764B30 VA: 0x180766530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7675E0 Offset: 0x765BE0 VA: 0x1807675E0
	public void .ctor() { }

	// RVA: 0x767500 Offset: 0x765B00 VA: 0x180767500
	private static void .cctor() { }

}

