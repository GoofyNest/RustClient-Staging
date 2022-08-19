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

	// RVA: 0x198D4D0 Offset: 0x198BAD0 VA: 0x18198D4D0
	public void .ctor(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	// RVA: 0x198DAE0 Offset: 0x198C0E0 VA: 0x18198DAE0
	private float map(float u) { }

	// RVA: 0x198D940 Offset: 0x198BF40 VA: 0x18198D940
	private Vector3 bezierPoint(float t) { }

	// RVA: 0x198DC30 Offset: 0x198C230 VA: 0x18198DC30
	public Vector3 point(float t) { }

}

