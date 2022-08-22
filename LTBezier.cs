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

	// RVA: 0x198D750 Offset: 0x198BD50 VA: 0x18198D750
	public void .ctor(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	// RVA: 0x198DD60 Offset: 0x198C360 VA: 0x18198DD60
	private float map(float u) { }

	// RVA: 0x198DBC0 Offset: 0x198C1C0 VA: 0x18198DBC0
	private Vector3 bezierPoint(float t) { }

	// RVA: 0x198DEB0 Offset: 0x198C4B0 VA: 0x18198DEB0
	public Vector3 point(float t) { }

}

