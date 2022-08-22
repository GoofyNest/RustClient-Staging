public class BasicCar : BaseVehicle // TypeDefIndex: 9699
{	// Fields
	public BasicCar.VehicleWheel[] wheels; // 0x3B8
	public float brakePedal; // 0x3C0
	public float gasPedal; // 0x3C4
	public float steering; // 0x3C8
	public Transform centerOfMass; // 0x3D0
	public Transform steeringWheel; // 0x3D8
	public float motorForceConstant; // 0x3E0
	public float brakeForceConstant; // 0x3E4
	public float GasLerpTime; // 0x3E8
	public float SteeringLerpTime; // 0x3EC
	public Transform driverEye; // 0x3F0
	public GameObjectRef chairRef; // 0x3F8
	public Transform chairAnchorTest; // 0x400
	public SoundPlayer idleLoopPlayer; // 0x408
	public Transform engineOffset; // 0x410
	public SoundDefinition engineSoundDef; // 0x418
	private SedanWheelSmoke wheelSmoke; // 0x420
	private float shockRestingPosY; // 0x428
	private float shockDistance; // 0x42C
	private float traceDistanceNeutralPoint; // 0x430
	private int cachedMask; // 0x434
	private const float wheelSpinConstant = 120;
	private AverageVelocity averageVelocity; // 0x438
	private Sound engineSoundLoop; // 0x440
	private SoundModulation.Modulator engineSoundVolume; // 0x448
	private SoundModulation.Modulator engineSoundPitch; // 0x450

	// Methods

	// RVA: 0x50CBE0 Offset: 0x50B1E0 VA: 0x18050CBE0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x50C310 Offset: 0x50A910 VA: 0x18050C310 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion viewRot) { }

	// RVA: 0x50C230 Offset: 0x50A830 VA: 0x18050C230 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x50CBF0 Offset: 0x50B1F0 VA: 0x18050CBF0 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x50BFC0 Offset: 0x50A5C0 VA: 0x18050BFC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x50D5E0 Offset: 0x50BBE0 VA: 0x18050D5E0
	public void Update() { }

	// RVA: 0x50C3E0 Offset: 0x50A9E0 VA: 0x18050C3E0
	private float GetShockHeightDelta(WheelCollider wheel, int i) { }

	// RVA: 0x50C1D0 Offset: 0x50A7D0 VA: 0x18050C1D0
	private float ClientSteering() { }

	// RVA: 0x50CBD0 Offset: 0x50B1D0 VA: 0x18050CBD0
	public bool IsBreaking() { }

	// RVA: 0x50D030 Offset: 0x50B630 VA: 0x18050D030
	private void UpdateTireAnimation() { }

	// RVA: 0x50CA40 Offset: 0x50B040 VA: 0x18050CA40
	public void InitializeClientsideEffects() { }

	// RVA: 0x50CC60 Offset: 0x50B260 VA: 0x18050CC60
	public void ShutdownClientsideEffects() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsEngineOn() { }

	// RVA: 0x50CD30 Offset: 0x50B330 VA: 0x18050CD30
	public void UpdateSounds() { }

	// RVA: 0x50D640 Offset: 0x50BC40 VA: 0x18050D640
	public void .ctor() { }

}

public class BasicCar.VehicleWheel // TypeDefIndex: 9700
{	// Fields
	public Transform shock; // 0x10
	public WheelCollider wheelCollider; // 0x18
	public Transform wheel; // 0x20
	public Transform axle; // 0x28
	public bool steerWheel; // 0x30
	public bool brakeWheel; // 0x31
	public bool powerWheel; // 0x32

	// Methods

	// RVA: 0x529320 Offset: 0x527920 VA: 0x180529320
	public void .ctor() { }

}

