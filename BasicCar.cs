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

	// RVA: 0x50CC50 Offset: 0x50B250 VA: 0x18050CC50 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x50C380 Offset: 0x50A980 VA: 0x18050C380 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion viewRot) { }

	// RVA: 0x50C2A0 Offset: 0x50A8A0 VA: 0x18050C2A0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x50CC60 Offset: 0x50B260 VA: 0x18050CC60 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x50C030 Offset: 0x50A630 VA: 0x18050C030 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x50D650 Offset: 0x50BC50 VA: 0x18050D650
	public void Update() { }

	// RVA: 0x50C450 Offset: 0x50AA50 VA: 0x18050C450
	private float GetShockHeightDelta(WheelCollider wheel, int i) { }

	// RVA: 0x50C240 Offset: 0x50A840 VA: 0x18050C240
	private float ClientSteering() { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool IsBreaking() { }

	// RVA: 0x50D0A0 Offset: 0x50B6A0 VA: 0x18050D0A0
	private void UpdateTireAnimation() { }

	// RVA: 0x50CAB0 Offset: 0x50B0B0 VA: 0x18050CAB0
	public void InitializeClientsideEffects() { }

	// RVA: 0x50CCD0 Offset: 0x50B2D0 VA: 0x18050CCD0
	public void ShutdownClientsideEffects() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsEngineOn() { }

	// RVA: 0x50CDA0 Offset: 0x50B3A0 VA: 0x18050CDA0
	public void UpdateSounds() { }

	// RVA: 0x50D6B0 Offset: 0x50BCB0 VA: 0x18050D6B0
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

	// RVA: 0x529390 Offset: 0x527990 VA: 0x180529390
	public void .ctor() { }

}

