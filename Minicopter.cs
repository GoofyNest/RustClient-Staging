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

	// RVA: 0x1F49380 Offset: 0x1F47980 VA: 0x181F49380
	public static void ResetToPool(Minicopter instance) { }

	// RVA: 0x1F492D0 Offset: 0x1F478D0 VA: 0x181F492D0
	public void ResetToPool() { }

	// RVA: 0x1F48F20 Offset: 0x1F47520 VA: 0x181F48F20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E22480 Offset: 0x1E20A80 VA: 0x181E22480
	public void CopyTo(Minicopter instance) { }

	// RVA: 0x1F47BD0 Offset: 0x1F461D0 VA: 0x181F47BD0
	public Minicopter Copy() { }

	// RVA: 0x1F483A0 Offset: 0x1F469A0 VA: 0x181F483A0
	public static Minicopter Deserialize(Stream stream) { }

	// RVA: 0x1F47F80 Offset: 0x1F46580 VA: 0x181F47F80
	public static Minicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F48000 Offset: 0x1F46600 VA: 0x181F48000
	public static Minicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F488A0 Offset: 0x1F46EA0 VA: 0x181F488A0
	public static Minicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1F49050 Offset: 0x1F47650 VA: 0x181F49050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F49A00 Offset: 0x1F48000 VA: 0x181F49A00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F49A20 Offset: 0x1F48020 VA: 0x181F49A20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Minicopter previous) { }

	// RVA: 0x1F492B0 Offset: 0x1F478B0 VA: 0x181F492B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F48BF0 Offset: 0x1F471F0 VA: 0x181F48BF0
	public static Minicopter Deserialize(byte[] buffer, Minicopter instance, bool isDelta = False) { }

	// RVA: 0x1F48640 Offset: 0x1F46C40 VA: 0x181F48640
	public static Minicopter Deserialize(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F47C50 Offset: 0x1F46250 VA: 0x181F47C50
	public static Minicopter DeserializeLengthDelimited(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F48090 Offset: 0x1F46690 VA: 0x181F48090
	public static Minicopter DeserializeLength(Stream stream, int length, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F49430 Offset: 0x1F47A30 VA: 0x181F49430
	public static void SerializeDelta(Stream stream, Minicopter instance, Minicopter previous) { }

	// RVA: 0x1F49880 Offset: 0x1F47E80 VA: 0x181F49880
	public static void Serialize(Stream stream, Minicopter instance) { }

	// RVA: 0x1F499F0 Offset: 0x1F47FF0 VA: 0x181F499F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F49A00 Offset: 0x1F48000 VA: 0x181F49A00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F49770 Offset: 0x1F47D70 VA: 0x181F49770
	public static byte[] SerializeToBytes(Minicopter instance) { }

	// RVA: 0x1F496C0 Offset: 0x1F47CC0 VA: 0x181F496C0
	public static void SerializeLengthDelimited(Stream stream, Minicopter instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x765DE0 Offset: 0x7643E0 VA: 0x180765DE0
	public float GetFuelFraction() { }

	[BaseEntity.Menu] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Description] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.Icon] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	[BaseEntity.Menu.ShowIf] // RVA: 0xAC630 Offset: 0xABA30 VA: 0x1800AC630
	// RVA: 0x766480 Offset: 0x764A80 VA: 0x180766480
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x766330 Offset: 0x764930 VA: 0x180766330
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7677B0 Offset: 0x765DB0 VA: 0x1807677B0
	public bool get_IsStartingUp() { }

	// RVA: 0x7676A0 Offset: 0x765CA0 VA: 0x1807676A0
	public VehicleEngineController.EngineState<MiniCopter> get_CurEngineState() { }

	// RVA: 0x766100 Offset: 0x764700 VA: 0x180766100 Slot: 28
	public override void InitShared() { }

	// RVA: 0x767260 Offset: 0x765860 VA: 0x180767260
	public void Update() { }

	// RVA: 0x7666B0 Offset: 0x764CB0 VA: 0x1807666B0 Slot: 197
	public virtual void UpdateAnimator() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 198
	protected virtual float GetMainRotorScale() { }

	// RVA: 0x766CC0 Offset: 0x7652C0 VA: 0x180766CC0
	public void UpdateRotor(float delta) { }

	// RVA: 0x7661D0 Offset: 0x7647D0 VA: 0x1807661D0
	public void LateUpdate() { }

	// RVA: 0x766A80 Offset: 0x765080 VA: 0x180766A80 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x766680 Offset: 0x764C80 VA: 0x180766680
	public float RemapValue(float toUse, float maxRemap) { }

	// RVA: 0x766210 Offset: 0x764810 VA: 0x180766210 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x765BE0 Offset: 0x7641E0 VA: 0x180765BE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x766690 Offset: 0x764C90 VA: 0x180766690
	public void TryUpdateLayerIndicies() { }

	// RVA: 0x766A20 Offset: 0x765020 VA: 0x180766A20 Slot: 199
	public virtual void UpdateLayerIndicies() { }

	// RVA: 0x7664C0 Offset: 0x764AC0 VA: 0x1807664C0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x765B80 Offset: 0x764180 VA: 0x180765B80 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x765DF0 Offset: 0x7643F0 VA: 0x180765DF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7676F0 Offset: 0x765CF0 VA: 0x1807676F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x766590 Offset: 0x764B90 VA: 0x180766590 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x767640 Offset: 0x765C40 VA: 0x180767640
	public void .ctor() { }

	// RVA: 0x767560 Offset: 0x765B60 VA: 0x180767560
	private static void .cctor() { }

}

