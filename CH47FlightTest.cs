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

	// RVA: 0x6F4460 Offset: 0x6F2A60 VA: 0x1806F4460
	public void Awake() { }

	// RVA: 0x6F5360 Offset: 0x6F3960 VA: 0x1806F5360
	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	// RVA: 0x6F4D00 Offset: 0x6F3300 VA: 0x1806F4D00
	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	// RVA: 0x6F54A0 Offset: 0x6F3AA0 VA: 0x1806F54A0
	public float GetIdealAltitude() { }

	// RVA: 0x6F44C0 Offset: 0x6F2AC0 VA: 0x1806F44C0
	public void FixedUpdate() { }

	// RVA: 0x6F54E0 Offset: 0x6F3AE0 VA: 0x1806F54E0
	public void OnDrawGizmos() { }

	// RVA: 0x6F58D0 Offset: 0x6F3ED0 VA: 0x1806F58D0
	public void .ctor() { }

	// RVA: 0x6F5890 Offset: 0x6F3E90 VA: 0x1806F5890
	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 8855
{	// Fields
	public float throttle; // 0x0
	public float roll; // 0x4
	public float yaw; // 0x8
	public float pitch; // 0xC

}

