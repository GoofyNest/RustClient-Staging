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

	// RVA: 0x6F4400 Offset: 0x6F2A00 VA: 0x1806F4400
	public void Awake() { }

	// RVA: 0x6F5300 Offset: 0x6F3900 VA: 0x1806F5300
	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	// RVA: 0x6F4CA0 Offset: 0x6F32A0 VA: 0x1806F4CA0
	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	// RVA: 0x6F5440 Offset: 0x6F3A40 VA: 0x1806F5440
	public float GetIdealAltitude() { }

	// RVA: 0x6F4460 Offset: 0x6F2A60 VA: 0x1806F4460
	public void FixedUpdate() { }

	// RVA: 0x6F5480 Offset: 0x6F3A80 VA: 0x1806F5480
	public void OnDrawGizmos() { }

	// RVA: 0x6F5870 Offset: 0x6F3E70 VA: 0x1806F5870
	public void .ctor() { }

	// RVA: 0x6F5830 Offset: 0x6F3E30 VA: 0x1806F5830
	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 8855
{	// Fields
	public float throttle; // 0x0
	public float roll; // 0x4
	public float yaw; // 0x8
	public float pitch; // 0xC

}

