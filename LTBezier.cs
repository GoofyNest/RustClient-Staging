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

	// RVA: 0x198D490 Offset: 0x198BA90 VA: 0x18198D490
	public void .ctor(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	// RVA: 0x198DAA0 Offset: 0x198C0A0 VA: 0x18198DAA0
	private float map(float u) { }

	// RVA: 0x198D900 Offset: 0x198BF00 VA: 0x18198D900
	private Vector3 bezierPoint(float t) { }

	// RVA: 0x198DBF0 Offset: 0x198C1F0 VA: 0x18198DBF0
	public Vector3 point(float t) { }

}

