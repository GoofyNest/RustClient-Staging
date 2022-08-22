public class MagnetCrane : GroundVehicle, IGenericLerpTarget<MagnetCrane.MagnetCraneSnapshot>, ILerpInfo // TypeDefIndex: 8406
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x408
	private GenericLerp<MagnetCrane.MagnetCraneSnapshot> animInterp; // 0x460
	private float leftTreadInput; // 0x468
	private float rightTreadInput; // 0x46C
	[HeaderAttribute] // RVA: 0xEA980 Offset: 0xE9D80 VA: 0x1800EA980
	public Animator animator; // 0x470
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform COM; // 0x478
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float arm1Speed; // 0x480
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float arm2Speed; // 0x484
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float turnYawSpeed; // 0x488
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseMagnet Magnet; // 0x490
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MagnetCraneAudio mcAudio; // 0x498
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Rigidbody myRigidbody; // 0x4A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform[] collisionTestingPoints; // 0x4A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxDistanceFromOrigin; // 0x4B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef selfDamageEffect; // 0x4B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef explosionEffect; // 0x4C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform explosionPoint; // 0x4C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CapsuleCollider driverCollision; // 0x4D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftHandTarget; // 0x4D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightHandTarget; // 0x4E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftFootTarget; // 0x4E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightFootTarget; // 0x4F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float idleFuelPerSec; // 0x4F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxFuelPerSec; // 0x4FC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject[] OnTriggers; // 0x500
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtEx magnetDamage; // 0x508
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int engineKW; // 0x510
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CarWheel[] wheels; // 0x518
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CarSettings carSettings; // 0x520
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem exhaustInner; // 0x528
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem exhaustOuter; // 0x530
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x55A320 Offset: 0x558920 VA: 0x18055A320 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x55B490 Offset: 0x559A90 VA: 0x18055B490 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x55ADE0 Offset: 0x5593E0 VA: 0x18055ADE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x559570 Offset: 0x557B70 VA: 0x180559570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x55B130 Offset: 0x559730 VA: 0x18055B130 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x55AED0 Offset: 0x5594D0 VA: 0x18055AED0 Slot: 203
	public void SetFrom(MagnetCrane.MagnetCraneSnapshot snapshot) { }

	// RVA: 0x55A200 Offset: 0x558800 VA: 0x18055A200 Slot: 204
	public MagnetCrane.MagnetCraneSnapshot GetCurrentState() { }

	// RVA: 0x5595D0 Offset: 0x557BD0 VA: 0x1805595D0 Slot: 205
	public void DebugInterpolationState(Interpolator.Segment<MagnetCrane.MagnetCraneSnapshot> segment, List<MagnetCrane.MagnetCraneSnapshot> entries) { }

	// RVA: 0x55A690 Offset: 0x558C90 VA: 0x18055A690 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x55ADA0 Offset: 0x5593A0 VA: 0x18055ADA0 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x55AFE0 Offset: 0x5595E0 VA: 0x18055AFE0
	private void UpdateExhaust() { }

	// RVA: 0x55AA50 Offset: 0x559050 VA: 0x18055AA50
	private void InitAnimInterpolator() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x55AD60 Offset: 0x559360 VA: 0x18055AD60
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x55ACB0 Offset: 0x5592B0 VA: 0x18055ACB0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x55B480 Offset: 0x559A80 VA: 0x18055B480 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x55A630 Offset: 0x558C30 VA: 0x18055A630 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x55A1A0 Offset: 0x5587A0 VA: 0x18055A1A0 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x55AAE0 Offset: 0x5590E0 VA: 0x18055AAE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x55A310 Offset: 0x558910 VA: 0x18055A310 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x559500 Offset: 0x557B00 VA: 0x180559500 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x55B450 Offset: 0x559A50 VA: 0x18055B450
	public void .ctor() { }

	// RVA: 0x55B340 Offset: 0x559940 VA: 0x18055B340
	private static void .cctor() { }

}

public struct MagnetCrane.MagnetCraneSnapshot : ISnapshot<MagnetCrane.MagnetCraneSnapshot> // TypeDefIndex: 8407
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public float yaw; // 0x4
	public float arm1; // 0x8
	public float arm2; // 0xC

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float time, float yaw, float arm1, float arm2) { }

	// RVA: 0xF2AA0 Offset: 0xF1EA0 VA: 0x1800F2AA0 Slot: 6
	public void MatchValuesTo(MagnetCrane.MagnetCraneSnapshot entry) { }

	// RVA: 0xF2960 Offset: 0xF1D60 VA: 0x1800F2960 Slot: 7
	public void Lerp(MagnetCrane.MagnetCraneSnapshot prev, MagnetCrane.MagnetCraneSnapshot next, float delta) { }

	// RVA: 0xF2950 Offset: 0xF1D50 VA: 0x1800F2950 Slot: 8
	public MagnetCrane.MagnetCraneSnapshot GetNew() { }

}

