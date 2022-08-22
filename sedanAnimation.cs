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

	// RVA: 0x1A94350 Offset: 0x1A92950 VA: 0x181A94350
	private void Start() { }

	// RVA: 0x1A950B0 Offset: 0x1A936B0 VA: 0x181A950B0
	private void Update() { }

	// RVA: 0x1A94060 Offset: 0x1A92660 VA: 0x181A94060
	private void InputPlayer() { }

	// RVA: 0x1A93CC0 Offset: 0x1A922C0 VA: 0x181A93CC0
	private void DoSteering() { }

	// RVA: 0x1A93B20 Offset: 0x1A92120 VA: 0x181A93B20
	private void ApplyForceAtWheels() { }

	// RVA: 0x1A943A0 Offset: 0x1A929A0 VA: 0x181A943A0
	private void UpdateTireAnimation() { }

	// RVA: 0x1A93D10 Offset: 0x1A92310 VA: 0x181A93D10
	private float GetShockHeightDelta(WheelCollider wheel) { }

	// RVA: 0x1A95120 Offset: 0x1A93720 VA: 0x181A95120
	public void .ctor() { }

}

