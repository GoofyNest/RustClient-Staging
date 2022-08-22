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

	// RVA: 0x1A94610 Offset: 0x1A92C10 VA: 0x181A94610
	private void Start() { }

	// RVA: 0x1A95370 Offset: 0x1A93970 VA: 0x181A95370
	private void Update() { }

	// RVA: 0x1A94320 Offset: 0x1A92920 VA: 0x181A94320
	private void InputPlayer() { }

	// RVA: 0x1A93F80 Offset: 0x1A92580 VA: 0x181A93F80
	private void DoSteering() { }

	// RVA: 0x1A93DE0 Offset: 0x1A923E0 VA: 0x181A93DE0
	private void ApplyForceAtWheels() { }

	// RVA: 0x1A94660 Offset: 0x1A92C60 VA: 0x181A94660
	private void UpdateTireAnimation() { }

	// RVA: 0x1A93FD0 Offset: 0x1A925D0 VA: 0x181A93FD0
	private float GetShockHeightDelta(WheelCollider wheel) { }

	// RVA: 0x1A953E0 Offset: 0x1A939E0 VA: 0x181A953E0
	public void .ctor() { }

}

