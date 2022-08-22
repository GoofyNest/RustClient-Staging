public class sedanAnimation : MonoBehaviour // TypeDefIndex: 8298
{	// Fields
	public Transform[] frontAxles; // 0x18
	public Transform FL_shock; // 0x20
	public Transform FL_wheel; // 0x28
	public Transform FR_shock; // 0x30
	public Transform FR_wheel; // 0x38
	public Transform RL_shock; // 0x40
	public Transform RL_wheel; // 0x48
	public Transform RR_shock; // 0x50
	public Transform RR_wheel; // 0x58
	public WheelCollider FL_wheelCollider; // 0x60
	public WheelCollider FR_wheelCollider; // 0x68
	public WheelCollider RL_wheelCollider; // 0x70
	public WheelCollider RR_wheelCollider; // 0x78
	public Transform steeringWheel; // 0x80
	public float motorForceConstant; // 0x88
	public float brakeForceConstant; // 0x8C
	public float brakePedal; // 0x90
	public float gasPedal; // 0x94
	public float steering; // 0x98
	private Rigidbody myRigidbody; // 0xA0
	public float GasLerpTime; // 0xA8
	public float SteeringLerpTime; // 0xAC
	private float wheelSpinConstant; // 0xB0
	private float shockRestingPosY; // 0xB4
	private float shockDistance; // 0xB8
	private float traceDistanceNeutralPoint; // 0xBC

	// Methods

	// RVA: 0x1A80E20 Offset: 0x1A7F420 VA: 0x181A80E20
	private void Start() { }

	// RVA: 0x1A81B80 Offset: 0x1A80180 VA: 0x181A81B80
	private void Update() { }

	// RVA: 0x1A80B30 Offset: 0x1A7F130 VA: 0x181A80B30
	private void InputPlayer() { }

	// RVA: 0x1A80790 Offset: 0x1A7ED90 VA: 0x181A80790
	private void DoSteering() { }

	// RVA: 0x1A805F0 Offset: 0x1A7EBF0 VA: 0x181A805F0
	private void ApplyForceAtWheels() { }

	// RVA: 0x1A80E70 Offset: 0x1A7F470 VA: 0x181A80E70
	private void UpdateTireAnimation() { }

	// RVA: 0x1A807E0 Offset: 0x1A7EDE0 VA: 0x181A807E0
	private float GetShockHeightDelta(WheelCollider wheel) { }

	// RVA: 0x1A81BF0 Offset: 0x1A801F0 VA: 0x181A81BF0
	public void .ctor() { }

}

