public class TrainCar : BaseVehicle, IGenericLerpTarget<TrainCar.TrainCarSnapshot>, ILerpInfo, ITrainCollidable, IPrefabPreProcess // TypeDefIndex: 8467
{	private Option __menuOption_Menu_Uncouple; // 0x3B8
	private GenericLerp<TrainCar.TrainCarSnapshot> animInterp; // 0x410
	protected bool runningClientTick; // 0x418
	private Vector3 bogieRotation; // 0x41C
	private Vector3 prevWheelRotation; // 0x428
	[HeaderAttribute] // RVA: 0x90F90 Offset: 0x90390 VA: 0x180090F90
	[SerializeField] // RVA: 0x90F90 Offset: 0x90390 VA: 0x180090F90
	private float corpseSeconds; // 0x434
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerTrainCollisions frontCollisionTrigger; // 0x438
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerTrainCollisions rearCollisionTrigger; // 0x440
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float collisionDamageDivide; // 0x448
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float derailCollisionForce; // 0x44C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerHurtNotChild hurtTriggerFront; // 0x450
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerHurtNotChild hurtTriggerRear; // 0x458
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float hurtTriggerMinSpeed; // 0x460
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform centreOfMassTransform; // 0x468
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform frontBogiePivot; // 0x470
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool frontBogieCanRotate; // 0x478
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rearBogiePivot; // 0x480
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool rearBogieCanRotate; // 0x488
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform[] wheelVisuals; // 0x490
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float wheelRadius; // 0x498
	[FormerlySerializedAsAttribute] // RVA: 0x91B30 Offset: 0x90F30 VA: 0x180091B30
	[SerializeField] // RVA: 0x91B30 Offset: 0x90F30 VA: 0x180091B30
	private GameObjectRef fxDestroyed; // 0x4A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected TriggerParent platformParentTrigger; // 0x4A8
	public GameObjectRef collisionEffect; // 0x4B0
	public Transform frontCoupling; // 0x4B8
	public Transform frontCouplingPivot; // 0x4C0
	public Transform rearCoupling; // 0x4C8
	public Transform rearCouplingPivot; // 0x4D0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition coupleSound; // 0x4D8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition uncoupleSound; // 0x4E0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainCarAudio trainCarAudio; // 0x4E8
	[FormerlySerializedAsAttribute] // RVA: 0x93280 Offset: 0x92680 VA: 0x180093280
	[SerializeField] // RVA: 0x93280 Offset: 0x92680 VA: 0x180093280
	private ParticleSystem frontCouplingChangedFx; // 0x4F0
	[FormerlySerializedAsAttribute] // RVA: 0x93410 Offset: 0x92810 VA: 0x180093410
	[SerializeField] // RVA: 0x93410 Offset: 0x92810 VA: 0x180093410
	private ParticleSystem rearCouplingChangedFx; // 0x4F8
	[FormerlySerializedAsAttribute] // RVA: 0x93540 Offset: 0x92940 VA: 0x180093540
	[SerializeField] // RVA: 0x93540 Offset: 0x92940 VA: 0x180093540
	private ParticleSystem newCouplingFX; // 0x500
	[SerializeField] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	[ReadOnlyAttribute] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	private Vector3 frontBogieLocalOffset; // 0x508
	[SerializeField] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	[ReadOnlyAttribute] // RVA: 0x93600 Offset: 0x92A00 VA: 0x180093600
	private Vector3 rearBogieLocalOffset; // 0x514
	[ServerVar] // RVA: 0x71FC0 Offset: 0x713C0 VA: 0x180071FC0
	public static float population; // 0x0
	[ServerVar] // RVA: 0x93830 Offset: 0x92C30 VA: 0x180093830
	public static int wagons_per_engine; // 0x4
	[ServerVar] // RVA: 0x93A20 Offset: 0x92E20 VA: 0x180093A20
	public static float decayminutes; // 0x8
	[ReadOnlyAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public float DistFrontWheelToFrontCoupling; // 0x520
	[ReadOnlyAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public float DistFrontWheelToBackCoupling; // 0x524
	public TrainCouplingController coupling; // 0x528
	public TrainTrackSpline.TrackSelection localTrackSelection; // 0x530
	public const BaseEntity.Flags Flag_LinedUpToUnload = 1024;

	public override bool HasMenuOptions { get; }
	public TriggerTrainCollisions FrontCollisionTrigger { get; }
	public TriggerTrainCollisions RearCollisionTrigger { get; }
	public virtual TrainCar.TrainCarType CarType { get; }
	public bool LinedUpToUnload { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void StartClientTick() { }

	protected virtual void StopClientTick() { }

	protected virtual void TrainClientTick() { }

	protected virtual bool UpdateBraking(float forwardSpeed) { }

	private void InitAnimInterpolator() { }

	private void AddSnapshot(float time, float frontBogieYRot, float rearBogieYRot) { }

	private void UpdateWheelVisuals(Vector3 localVelocity, float frontBogieYRot, float rearBogieYRot) { }

	public void SetFrom(TrainCar.TrainCarSnapshot snapshot) { }

	public TrainCar.TrainCarSnapshot GetCurrentState() { }

	public void DebugInterpolationState(Interpolator.Segment<TrainCar.TrainCarSnapshot> segment, List<TrainCar.TrainCarSnapshot> entries) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetTrackSelection(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void BaseTrainUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	[BaseEntity.Menu.Description] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	[BaseEntity.Menu.Icon] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	[BaseEntity.Menu.ShowIf] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	public void Menu_Uncouple(BasePlayer player) { }

	public virtual bool Menu_Uncouple_ShowIf(BasePlayer player) { }

	public TriggerTrainCollisions get_FrontCollisionTrigger() { }

	public TriggerTrainCollisions get_RearCollisionTrigger() { }

	public virtual TrainCar.TrainCarType get_CarType() { }

	public bool get_LinedUpToUnload() { }

	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override float InheritedVelocityScale() { }

	protected virtual void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void <UpdateWheelVisuals>g__SetBogieRotation|18_0(Transform pivot, float yAngle, bool canRotate) { }

}

public struct TrainCar.TrainCarSnapshot : ISnapshot<TrainCar.TrainCarSnapshot> // TypeDefIndex: 8468
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Time>k__BackingField; // 0x0
	public float frontBogieY; // 0x4
	public float rearBogieY; // 0x8

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_Time(float value) { }

	public void .ctor(float time, float frontBogieY, float rearBogieY) { }

	public void MatchValuesTo(TrainCar.TrainCarSnapshot entry) { }

	public void Lerp(TrainCar.TrainCarSnapshot prev, TrainCar.TrainCarSnapshot next, float delta) { }

	public TrainCar.TrainCarSnapshot GetNew() { }

}

public enum TrainCar.TrainCarType // TypeDefIndex: 8469
{	public int value__; // 0x0
	public const TrainCar.TrainCarType Wagon = 0;
	public const TrainCar.TrainCarType Engine = 1;
	public const TrainCar.TrainCarType Other = 2;

}

