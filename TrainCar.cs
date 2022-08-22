public class TrainCar : BaseVehicle, IGenericLerpTarget<TrainCar.TrainCarSnapshot>, ILerpInfo, ITrainCollidable, IPrefabPreProcess // TypeDefIndex: 8467
{	// Fields
	private Option __menuOption_Menu_Uncouple; // 0x3B8
	private GenericLerp<TrainCar.TrainCarSnapshot> animInterp; // 0x410
	protected bool runningClientTick; // 0x418
	private Vector3 bogieRotation; // 0x41C
	private Vector3 prevWheelRotation; // 0x428
	[HeaderAttribute] // RVA: 0x90EA0 Offset: 0x902A0 VA: 0x180090EA0
	[SerializeField] // RVA: 0x90EA0 Offset: 0x902A0 VA: 0x180090EA0
	private float corpseSeconds; // 0x434
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerTrainCollisions frontCollisionTrigger; // 0x438
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerTrainCollisions rearCollisionTrigger; // 0x440
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float collisionDamageDivide; // 0x448
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float derailCollisionForce; // 0x44C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerFront; // 0x450
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerRear; // 0x458
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float hurtTriggerMinSpeed; // 0x460
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform centreOfMassTransform; // 0x468
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform frontBogiePivot; // 0x470
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool frontBogieCanRotate; // 0x478
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rearBogiePivot; // 0x480
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool rearBogieCanRotate; // 0x488
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform[] wheelVisuals; // 0x490
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float wheelRadius; // 0x498
	[FormerlySerializedAsAttribute] // RVA: 0x91A70 Offset: 0x90E70 VA: 0x180091A70
	[SerializeField] // RVA: 0x91A70 Offset: 0x90E70 VA: 0x180091A70
	private GameObjectRef fxDestroyed; // 0x4A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TriggerParent platformParentTrigger; // 0x4A8
	public GameObjectRef collisionEffect; // 0x4B0
	public Transform frontCoupling; // 0x4B8
	public Transform frontCouplingPivot; // 0x4C0
	public Transform rearCoupling; // 0x4C8
	public Transform rearCouplingPivot; // 0x4D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition coupleSound; // 0x4D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition uncoupleSound; // 0x4E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainCarAudio trainCarAudio; // 0x4E8
	[FormerlySerializedAsAttribute] // RVA: 0x93170 Offset: 0x92570 VA: 0x180093170
	[SerializeField] // RVA: 0x93170 Offset: 0x92570 VA: 0x180093170
	private ParticleSystem frontCouplingChangedFx; // 0x4F0
	[FormerlySerializedAsAttribute] // RVA: 0x932D0 Offset: 0x926D0 VA: 0x1800932D0
	[SerializeField] // RVA: 0x932D0 Offset: 0x926D0 VA: 0x1800932D0
	private ParticleSystem rearCouplingChangedFx; // 0x4F8
	[FormerlySerializedAsAttribute] // RVA: 0x93400 Offset: 0x92800 VA: 0x180093400
	[SerializeField] // RVA: 0x93400 Offset: 0x92800 VA: 0x180093400
	private ParticleSystem newCouplingFX; // 0x500
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private Vector3 frontBogieLocalOffset; // 0x508
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private Vector3 rearBogieLocalOffset; // 0x514
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x0
	[ServerVar] // RVA: 0x93720 Offset: 0x92B20 VA: 0x180093720
	public static int wagons_per_engine; // 0x4
	[ServerVar] // RVA: 0x938E0 Offset: 0x92CE0 VA: 0x1800938E0
	public static float decayminutes; // 0x8
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public float DistFrontWheelToFrontCoupling; // 0x520
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public float DistFrontWheelToBackCoupling; // 0x524
	public TrainCouplingController coupling; // 0x528
	public TrainTrackSpline.TrackSelection localTrackSelection; // 0x530
	public const BaseEntity.Flags Flag_LinedUpToUnload = 1024;

	// Properties
	public override bool HasMenuOptions { get; }
	public TriggerTrainCollisions FrontCollisionTrigger { get; }
	public TriggerTrainCollisions RearCollisionTrigger { get; }
	public virtual TrainCar.TrainCarType CarType { get; }
	public bool LinedUpToUnload { get; }

	// Methods

	// RVA: 0xA0F160 Offset: 0xA0D760 VA: 0x180A0F160 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA10DC0 Offset: 0xA0F3C0 VA: 0x180A10DC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA0FB10 Offset: 0xA0E110 VA: 0x180A0FB10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0F0A0 Offset: 0xA0D6A0 VA: 0x180A0F0A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA0EB30 Offset: 0xA0D130 VA: 0x180A0EB30 Slot: 199
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA10730 Offset: 0xA0ED30 VA: 0x180A10730
	private void StartClientTick() { }

	// RVA: 0xA10840 Offset: 0xA0EE40 VA: 0x180A10840 Slot: 200
	protected virtual void StopClientTick() { }

	// RVA: 0xA108E0 Offset: 0xA0EEE0 VA: 0x180A108E0 Slot: 201
	protected virtual void TrainClientTick() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 202
	protected virtual bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0xA0F470 Offset: 0xA0DA70 VA: 0x180A0F470
	private void InitAnimInterpolator() { }

	// RVA: 0xA0E8E0 Offset: 0xA0CEE0 VA: 0x180A0E8E0
	private void AddSnapshot(float time, float frontBogieYRot, float rearBogieYRot) { }

	// RVA: 0xA10A40 Offset: 0xA0F040 VA: 0x180A10A40
	private void UpdateWheelVisuals(Vector3 localVelocity, float frontBogieYRot, float rearBogieYRot) { }

	// RVA: 0xA10660 Offset: 0xA0EC60 VA: 0x180A10660 Slot: 194
	public void SetFrom(TrainCar.TrainCarSnapshot snapshot) { }

	// RVA: 0xA0F0E0 Offset: 0xA0D6E0 VA: 0x180A0F0E0 Slot: 195
	public TrainCar.TrainCarSnapshot GetCurrentState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 196
	public void DebugInterpolationState(Interpolator.Segment<TrainCar.TrainCarSnapshot> segment, List<TrainCar.TrainCarSnapshot> entries) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA106D0 Offset: 0xA0ECD0 VA: 0x180A106D0
	private void SetTrackSelection(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0EA80 Offset: 0xA0D080 VA: 0x180A0EA80
	private void BaseTrainUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x93B10 Offset: 0x92F10 VA: 0x180093B10
	[BaseEntity.Menu.Description] // RVA: 0x93B10 Offset: 0x92F10 VA: 0x180093B10
	[BaseEntity.Menu.Icon] // RVA: 0x93B10 Offset: 0x92F10 VA: 0x180093B10
	[BaseEntity.Menu.ShowIf] // RVA: 0x93B10 Offset: 0x92F10 VA: 0x180093B10
	// RVA: 0xA0F980 Offset: 0xA0DF80 VA: 0x180A0F980
	public void Menu_Uncouple(BasePlayer player) { }

	// RVA: 0xA0F7F0 Offset: 0xA0DDF0 VA: 0x180A0F7F0 Slot: 203
	public virtual bool Menu_Uncouple_ShowIf(BasePlayer player) { }

	// RVA: 0xA10DB0 Offset: 0xA0F3B0 VA: 0x180A10DB0
	public TriggerTrainCollisions get_FrontCollisionTrigger() { }

	// RVA: 0xA10E90 Offset: 0xA0F490 VA: 0x180A10E90
	public TriggerTrainCollisions get_RearCollisionTrigger() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 204
	public virtual TrainCar.TrainCarType get_CarType() { }

	// RVA: 0x738290 Offset: 0x736890 VA: 0x180738290
	public bool get_LinedUpToUnload() { }

	// RVA: 0xA102F0 Offset: 0xA0E8F0 VA: 0x180A102F0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA0F500 Offset: 0xA0DB00 VA: 0x180A0F500 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA0F670 Offset: 0xA0DC70 VA: 0x180A0F670 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA0FAB0 Offset: 0xA0E0B0 VA: 0x180A0FAB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 197
	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	// RVA: 0x714290 Offset: 0x712890 VA: 0x180714290 Slot: 99
	public override float InheritedVelocityScale() { }

	// RVA: 0xA10720 Offset: 0xA0ED20 VA: 0x180A10720 Slot: 205
	protected virtual void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0xA10CD0 Offset: 0xA0F2D0 VA: 0x180A10CD0
	public void .ctor() { }

	// RVA: 0xA10C70 Offset: 0xA0F270 VA: 0x180A10C70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA10980 Offset: 0xA0EF80 VA: 0x180A10980
	private void <UpdateWheelVisuals>g__SetBogieRotation|18_0(Transform pivot, float yAngle, bool canRotate) { }

}

public struct TrainCar.TrainCarSnapshot : ISnapshot<TrainCar.TrainCarSnapshot> // TypeDefIndex: 8468
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public float frontBogieY; // 0x4
	public float rearBogieY; // 0x8

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float time, float frontBogieY, float rearBogieY) { }

	// RVA: 0xFB4D0 Offset: 0xFA8D0 VA: 0x1800FB4D0 Slot: 6
	public void MatchValuesTo(TrainCar.TrainCarSnapshot entry) { }

	// RVA: 0xFB3F0 Offset: 0xFA7F0 VA: 0x1800FB3F0 Slot: 7
	public void Lerp(TrainCar.TrainCarSnapshot prev, TrainCar.TrainCarSnapshot next, float delta) { }

	// RVA: 0xFB3E0 Offset: 0xFA7E0 VA: 0x1800FB3E0 Slot: 8
	public TrainCar.TrainCarSnapshot GetNew() { }

}

public enum TrainCar.TrainCarType // TypeDefIndex: 8469
{	// Fields
	public int value__; // 0x0
	public const TrainCar.TrainCarType Wagon = 0;
	public const TrainCar.TrainCarType Engine = 1;
	public const TrainCar.TrainCarType Other = 2;

}

