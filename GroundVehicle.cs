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
	// RVA: 0xCA7A30 Offset: 0xCA6030 VA: 0x180CA7A30 Slot: 195
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA7A50 Offset: 0xCA6050 VA: 0x180CA7A50
	private void set_Velocity(Vector3 value) { }

	// RVA: -1 Offset: -1 Slot: 196
	public abstract float get_DriveWheelVelocity();

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool get_LightsAreOn() { }

	// RVA: 0xCA79E0 Offset: 0xCA5FE0 VA: 0x180CA79E0
	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	// RVA: 0xCA76F0 Offset: 0xCA5CF0 VA: 0x180CA76F0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xCA77D0 Offset: 0xCA5DD0 VA: 0x180CA77D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA7550 Offset: 0xCA5B50 VA: 0x180CA7550
	public float GetSpeed() { }

	// RVA: -1 Offset: -1 Slot: 197
	public abstract float GetMaxForwardSpeed();

	// RVA: -1 Offset: -1 Slot: 198
	public abstract float GetThrottleInput();

	// RVA: -1 Offset: -1 Slot: 199
	public abstract float GetBrakeInput();

	// RVA: 0xCA7230 Offset: 0xCA5830 VA: 0x180CA7230 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xCA7510 Offset: 0xCA5B10 VA: 0x180CA7510 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xCA72B0 Offset: 0xCA58B0 VA: 0x180CA72B0 Slot: 200
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA7830 Offset: 0xCA5E30 VA: 0x180CA7830
	private void StartClientTick() { }

	// RVA: 0xCA78C0 Offset: 0xCA5EC0 VA: 0x180CA78C0
	private void StopClientTick() { }

	// RVA: -1 Offset: -1 Slot: 201
	protected abstract void OnClientTickStopped();

	// RVA: 0xCA7640 Offset: 0xCA5C40 VA: 0x180CA7640 Slot: 202
	protected virtual void GroundVehicleClientTick() { }

	// RVA: 0xCA79B0 Offset: 0xCA5FB0 VA: 0x180CA79B0
	protected void .ctor() { }

}

