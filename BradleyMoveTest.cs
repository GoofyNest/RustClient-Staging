public class BradleyMoveTest : MonoBehaviour // TypeDefIndex: 8860
{	// Fields
	public WheelCollider[] leftWheels; // 0x18
	public WheelCollider[] rightWheels; // 0x20
	public float moveForceMax; // 0x28
	public float brakeForce; // 0x2C
	public float throttle; // 0x30
	public float turnForce; // 0x34
	public float sideStiffnessMax; // 0x38
	public float sideStiffnessMin; // 0x3C
	public Transform centerOfMass; // 0x40
	public float turning; // 0x48
	public bool brake; // 0x4C
	public Rigidbody myRigidBody; // 0x50
	public Vector3 destination; // 0x58
	public float stoppingDist; // 0x64
	public GameObject followTest; // 0x68

	// Methods

	// RVA: 0x520D10 Offset: 0x51F310 VA: 0x180520D10
	public void Awake() { }

	// RVA: 0x520D10 Offset: 0x51F310 VA: 0x180520D10
	public void Initialize() { }

	// RVA: 0x521510 Offset: 0x51FB10 VA: 0x180521510
	public void SetDestination(Vector3 dest) { }

	// RVA: 0x520DA0 Offset: 0x51F3A0 VA: 0x180520DA0
	public void FixedUpdate() { }

	// RVA: 0x520C30 Offset: 0x51F230 VA: 0x180520C30
	public void ApplyBrakes(float amount) { }

	// RVA: 0x521470 Offset: 0x51FA70 VA: 0x180521470
	public float GetMotorTorque(bool rightSide) { }

	// RVA: 0x521520 Offset: 0x51FB20 VA: 0x180521520
	public void SetMotorTorque(float newThrottle, bool rightSide, float torqueAmount) { }

	// RVA: 0x520BA0 Offset: 0x51F1A0 VA: 0x180520BA0
	public void ApplyBrakeTorque(float amount, bool rightSide) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void AdjustFriction() { }

	// RVA: 0x521610 Offset: 0x51FC10 VA: 0x180521610
	public void .ctor() { }

}

