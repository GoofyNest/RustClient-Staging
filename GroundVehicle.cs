public abstract class GroundVehicle : BaseVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 9711
{	[HeaderAttribute] // RVA: 0x85E70 Offset: 0x85270 VA: 0x180085E70
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

	public Vector3 Velocity { get; set; }
	public abstract float DriveWheelVelocity { get; }
	public bool LightsAreOn { get; }
	public VehicleEngineController.EngineState<GroundVehicle> CurEngineState { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Velocity(Vector3 value) { }

	public abstract float get_DriveWheelVelocity();

	public bool get_LightsAreOn() { }

	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	public override void InitShared() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public float GetSpeed() { }

	public abstract float GetMaxForwardSpeed();

	public abstract float GetThrottleInput();

	public abstract float GetBrakeInput();

	protected override bool CanPushNow(BasePlayer pusher) { }

	protected override void ClientInit(Entity info) { }

	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void StartClientTick() { }

	private void StopClientTick() { }

	protected abstract void OnClientTickStopped();

	protected virtual void GroundVehicleClientTick() { }

	protected void .ctor() { }

}

