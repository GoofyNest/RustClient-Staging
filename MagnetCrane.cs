public class MagnetCrane : GroundVehicle, IGenericLerpTarget<MagnetCrane.MagnetCraneSnapshot>, ILerpInfo // TypeDefIndex: 8406
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x408
	private GenericLerp<MagnetCrane.MagnetCraneSnapshot> animInterp; // 0x460
	private float leftTreadInput; // 0x468
	private float rightTreadInput; // 0x46C
	[HeaderAttribute] // RVA: 0xEA8C0 Offset: 0xE9CC0 VA: 0x1800EA8C0
	public Animator animator; // 0x470
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform COM; // 0x478
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float arm1Speed; // 0x480
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float arm2Speed; // 0x484
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float turnYawSpeed; // 0x488
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseMagnet Magnet; // 0x490
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MagnetCraneAudio mcAudio; // 0x498
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Rigidbody myRigidbody; // 0x4A0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform[] collisionTestingPoints; // 0x4A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxDistanceFromOrigin; // 0x4B0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef selfDamageEffect; // 0x4B8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef explosionEffect; // 0x4C0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform explosionPoint; // 0x4C8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CapsuleCollider driverCollision; // 0x4D0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform leftHandTarget; // 0x4D8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rightHandTarget; // 0x4E0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform leftFootTarget; // 0x4E8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rightFootTarget; // 0x4F0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float idleFuelPerSec; // 0x4F8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxFuelPerSec; // 0x4FC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject[] OnTriggers; // 0x500
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TriggerHurtEx magnetDamage; // 0x508
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int engineKW; // 0x510
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CarWheel[] wheels; // 0x518
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CarSettings carSettings; // 0x520
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem exhaustInner; // 0x528
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem exhaustOuter; // 0x530
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EmissionToggle lightToggle; // 0x538
	public static readonly Translate.Phrase ReturnMessage; // 0x0
	private const BaseEntity.Flags Flag_ArmMovement = 32768;
	private const BaseEntity.Flags Flag_BaseMovementInput = 262144;
	private static int leftTreadParam; // 0x8
	private static int rightTreadParam; // 0xC
	private static int yawParam; // 0x10
	private static int arm1Param; // 0x14
	private static int arm2Param; // 0x18

	// Properties
	public override bool HasMenuOptions { get; }
	public override float DriveWheelVelocity { get; }

	// Methods

	// RVA: 0x55A390 Offset: 0x558990 VA: 0x18055A390 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x55B500 Offset: 0x559B00 VA: 0x18055B500 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x55AE50 Offset: 0x559450 VA: 0x18055AE50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5595E0 Offset: 0x557BE0 VA: 0x1805595E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x55B1A0 Offset: 0x5597A0 VA: 0x18055B1A0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x55AF40 Offset: 0x559540 VA: 0x18055AF40 Slot: 203
	public void SetFrom(MagnetCrane.MagnetCraneSnapshot snapshot) { }

	// RVA: 0x55A270 Offset: 0x558870 VA: 0x18055A270 Slot: 204
	public MagnetCrane.MagnetCraneSnapshot GetCurrentState() { }

	// RVA: 0x559640 Offset: 0x557C40 VA: 0x180559640 Slot: 205
	public void DebugInterpolationState(Interpolator.Segment<MagnetCrane.MagnetCraneSnapshot> segment, List<MagnetCrane.MagnetCraneSnapshot> entries) { }

	// RVA: 0x55A700 Offset: 0x558D00 VA: 0x18055A700 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x55AE10 Offset: 0x559410 VA: 0x18055AE10 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x55B050 Offset: 0x559650 VA: 0x18055B050
	private void UpdateExhaust() { }

	// RVA: 0x55AAC0 Offset: 0x5590C0 VA: 0x18055AAC0
	private void InitAnimInterpolator() { }

	[BaseEntity.Menu] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.Description] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.Icon] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	// RVA: 0x55ADD0 Offset: 0x5593D0 VA: 0x18055ADD0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x55AD20 Offset: 0x559320 VA: 0x18055AD20
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x55B4F0 Offset: 0x559AF0 VA: 0x18055B4F0 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x55A6A0 Offset: 0x558CA0 VA: 0x18055A6A0 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x55A210 Offset: 0x558810 VA: 0x18055A210 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x55AB50 Offset: 0x559150 VA: 0x18055AB50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x55A380 Offset: 0x558980 VA: 0x18055A380 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x559570 Offset: 0x557B70 VA: 0x180559570 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x55B4C0 Offset: 0x559AC0 VA: 0x18055B4C0
	public void .ctor() { }

	// RVA: 0x55B3B0 Offset: 0x5599B0 VA: 0x18055B3B0
	private static void .cctor() { }

}

public struct MagnetCrane.MagnetCraneSnapshot : ISnapshot<MagnetCrane.MagnetCraneSnapshot> // TypeDefIndex: 8407
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Time>k__BackingField; // 0x0
	public float yaw; // 0x4
	public float arm1; // 0x8
	public float arm2; // 0xC

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float time, float yaw, float arm1, float arm2) { }

	// RVA: 0xF2B20 Offset: 0xF1F20 VA: 0x1800F2B20 Slot: 6
	public void MatchValuesTo(MagnetCrane.MagnetCraneSnapshot entry) { }

	// RVA: 0xF29E0 Offset: 0xF1DE0 VA: 0x1800F29E0 Slot: 7
	public void Lerp(MagnetCrane.MagnetCraneSnapshot prev, MagnetCrane.MagnetCraneSnapshot next, float delta) { }

	// RVA: 0xF29D0 Offset: 0xF1DD0 VA: 0x1800F29D0 Slot: 8
	public MagnetCrane.MagnetCraneSnapshot GetNew() { }

}

