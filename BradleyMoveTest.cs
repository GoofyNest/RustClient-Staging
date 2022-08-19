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

	// RVA: 0x520D80 Offset: 0x51F380 VA: 0x180520D80
	public void Awake() { }

	// RVA: 0x520D80 Offset: 0x51F380 VA: 0x180520D80
	public void Initialize() { }

	// RVA: 0x521580 Offset: 0x51FB80 VA: 0x180521580
	public void SetDestination(Vector3 dest) { }

	// RVA: 0x520E10 Offset: 0x51F410 VA: 0x180520E10
	public void FixedUpdate() { }

	// RVA: 0x520CA0 Offset: 0x51F2A0 VA: 0x180520CA0
	public void ApplyBrakes(float amount) { }

	// RVA: 0x5214E0 Offset: 0x51FAE0 VA: 0x1805214E0
	public float GetMotorTorque(bool rightSide) { }

	// RVA: 0x521590 Offset: 0x51FB90 VA: 0x180521590
	public void SetMotorTorque(float newThrottle, bool rightSide, float torqueAmount) { }

	// RVA: 0x520C10 Offset: 0x51F210 VA: 0x180520C10
	public void ApplyBrakeTorque(float amount, bool rightSide) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void AdjustFriction() { }

	// RVA: 0x521680 Offset: 0x51FC80 VA: 0x180521680
	public void .ctor() { }

}

