public class LTBezier // TypeDefIndex: 5582
{	// Fields
	public float length; // 0x10
	private Vector3 a; // 0x14
	private Vector3 aa; // 0x20
	private Vector3 bb; // 0x2C
	private Vector3 cc; // 0x38
	private float len; // 0x44
	private float[] arcLengths; // 0x48

	// Methods

	// RVA: 0x197AB50 Offset: 0x1979150 VA: 0x18197AB50
	public void .ctor(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	// RVA: 0x197B160 Offset: 0x1979760 VA: 0x18197B160
	private float map(float u) { }

	// RVA: 0x197AFC0 Offset: 0x19795C0 VA: 0x18197AFC0
	private Vector3 bezierPoint(float t) { }

	// RVA: 0x197B2B0 Offset: 0x19798B0 VA: 0x18197B2B0
	public Vector3 point(float t) { }

}

