public class CH47FlightTest : MonoBehaviour // TypeDefIndex: 8854
{	// Fields
	public Rigidbody rigidBody; // 0x18
	public float engineThrustMax; // 0x20
	public Vector3 torqueScale; // 0x24
	public Transform com; // 0x30
	public Transform[] GroundPoints; // 0x38
	public Transform[] GroundEffects; // 0x40
	public float currentThrottle; // 0x48
	public float avgThrust; // 0x4C
	public float liftDotMax; // 0x50
	public Transform AIMoveTarget; // 0x58
	private static float altitudeTolerance; // 0x0

	// Methods

	// RVA: 0x6F4510 Offset: 0x6F2B10 VA: 0x1806F4510
	public void Awake() { }

	// RVA: 0x6F5410 Offset: 0x6F3A10 VA: 0x1806F5410
	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	// RVA: 0x6F4DB0 Offset: 0x6F33B0 VA: 0x1806F4DB0
	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	// RVA: 0x6F5550 Offset: 0x6F3B50 VA: 0x1806F5550
	public float GetIdealAltitude() { }

	// RVA: 0x6F4570 Offset: 0x6F2B70 VA: 0x1806F4570
	public void FixedUpdate() { }

	// RVA: 0x6F5590 Offset: 0x6F3B90 VA: 0x1806F5590
	public void OnDrawGizmos() { }

	// RVA: 0x6F5980 Offset: 0x6F3F80 VA: 0x1806F5980
	public void .ctor() { }

	// RVA: 0x6F5940 Offset: 0x6F3F40 VA: 0x1806F5940
	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 8855
{	// Fields
	public float throttle; // 0x0
	public float roll; // 0x4
	public float yaw; // 0x8
	public float pitch; // 0xC

}

