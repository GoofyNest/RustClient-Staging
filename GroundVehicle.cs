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
	// RVA: 0xCA72D0 Offset: 0xCA58D0 VA: 0x180CA72D0 Slot: 195
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xCA72F0 Offset: 0xCA58F0 VA: 0x180CA72F0
	private void set_Velocity(Vector3 value) { }

	// RVA: -1 Offset: -1 Slot: 196
	public abstract float get_DriveWheelVelocity();

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool get_LightsAreOn() { }

	// RVA: 0xCA7280 Offset: 0xCA5880 VA: 0x180CA7280
	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	// RVA: 0xCA6F90 Offset: 0xCA5590 VA: 0x180CA6F90 Slot: 28
	public override void InitShared() { }

	// RVA: 0xCA7070 Offset: 0xCA5670 VA: 0x180CA7070 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA6DF0 Offset: 0xCA53F0 VA: 0x180CA6DF0
	public float GetSpeed() { }

	// RVA: -1 Offset: -1 Slot: 197
	public abstract float GetMaxForwardSpeed();

	// RVA: -1 Offset: -1 Slot: 198
	public abstract float GetThrottleInput();

	// RVA: -1 Offset: -1 Slot: 199
	public abstract float GetBrakeInput();

	// RVA: 0xCA6AD0 Offset: 0xCA50D0 VA: 0x180CA6AD0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xCA6DB0 Offset: 0xCA53B0 VA: 0x180CA6DB0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xCA6B50 Offset: 0xCA5150 VA: 0x180CA6B50 Slot: 200
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xCA70D0 Offset: 0xCA56D0 VA: 0x180CA70D0
	private void StartClientTick() { }

	// RVA: 0xCA7160 Offset: 0xCA5760 VA: 0x180CA7160
	private void StopClientTick() { }

	// RVA: -1 Offset: -1 Slot: 201
	protected abstract void OnClientTickStopped();

	// RVA: 0xCA6EE0 Offset: 0xCA54E0 VA: 0x180CA6EE0 Slot: 202
	protected virtual void GroundVehicleClientTick() { }

	// RVA: 0xCA7250 Offset: 0xCA5850 VA: 0x180CA7250
	protected void .ctor() { }

}

