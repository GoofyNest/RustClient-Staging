public abstract class GroundVehicle : BaseVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 9711
{	// Fields
	[HeaderAttribute] // RVA: 0x85E70 Offset: 0x85270 VA: 0x180085E70
	[SerializeField] // RVA: 0x85E70 Offset: 0x85270 VA: 0x180085E70
	protected GroundVehicleAudio gvAudio; // 0x3B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef fuelStoragePrefab; // 0x3C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform waterloggedPoint; // 0x3C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef collisionEffect; // 0x3D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineStartupTime; // 0x3D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float minCollisionDamageForce; // 0x3DC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxCollisionDamageForce; // 0x3E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float collisionDamageMultiplier; // 0x3E4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Velocity>k__BackingField; // 0x3E8
	protected VehicleEngineController<GroundVehicle> engineController; // 0x3F8
	private bool runningClientTick; // 0x400

	// Properties
	public Vector3 Velocity { get; set; }
	public abstract float DriveWheelVelocity { get; }
	public bool LightsAreOn { get; }
	public VehicleEngineController.EngineState<GroundVehicle> CurEngineState { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA7590 Offset: 0xCA5B90 VA: 0x180CA7590 Slot: 195
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA75B0 Offset: 0xCA5BB0 VA: 0x180CA75B0
	private void set_Velocity(Vector3 value) { }

	// RVA: -1 Offset: -1 Slot: 196
	public abstract float get_DriveWheelVelocity();

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool get_LightsAreOn() { }

	// RVA: 0xCA7540 Offset: 0xCA5B40 VA: 0x180CA7540
	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	// RVA: 0xCA7250 Offset: 0xCA5850 VA: 0x180CA7250 Slot: 28
	public override void InitShared() { }

	// RVA: 0xCA7330 Offset: 0xCA5930 VA: 0x180CA7330 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA70B0 Offset: 0xCA56B0 VA: 0x180CA70B0
	public float GetSpeed() { }

	// RVA: -1 Offset: -1 Slot: 197
	public abstract float GetMaxForwardSpeed();

	// RVA: -1 Offset: -1 Slot: 198
	public abstract float GetThrottleInput();

	// RVA: -1 Offset: -1 Slot: 199
	public abstract float GetBrakeInput();

	// RVA: 0xCA6D90 Offset: 0xCA5390 VA: 0x180CA6D90 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xCA7070 Offset: 0xCA5670 VA: 0x180CA7070 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xCA6E10 Offset: 0xCA5410 VA: 0x180CA6E10 Slot: 200
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA7390 Offset: 0xCA5990 VA: 0x180CA7390
	private void StartClientTick() { }

	// RVA: 0xCA7420 Offset: 0xCA5A20 VA: 0x180CA7420
	private void StopClientTick() { }

	// RVA: -1 Offset: -1 Slot: 201
	protected abstract void OnClientTickStopped();

	// RVA: 0xCA71A0 Offset: 0xCA57A0 VA: 0x180CA71A0 Slot: 202
	protected virtual void GroundVehicleClientTick() { }

	// RVA: 0xCA7510 Offset: 0xCA5B10 VA: 0x180CA7510
	protected void .ctor() { }

}

