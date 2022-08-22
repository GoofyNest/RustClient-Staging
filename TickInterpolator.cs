public class TickInterpolator // TypeDefIndex: 11405
{	// Fields
	private List<TickInterpolator.Segment> points; // 0x10
	private int index; // 0x18
	public float Length; // 0x1C
	public Vector3 CurrentPoint; // 0x20
	public Vector3 StartPoint; // 0x2C
	public Vector3 EndPoint; // 0x38

	// Methods

	// RVA: 0x86D0E0 Offset: 0x86B6E0 VA: 0x18086D0E0
	public void Reset() { }

	// RVA: 0x86D100 Offset: 0x86B700 VA: 0x18086D100
	public void Reset(Vector3 point) { }

	// RVA: 0x86CE90 Offset: 0x86B490 VA: 0x18086CE90
	public void AddPoint(Vector3 point) { }

	// RVA: 0x86D000 Offset: 0x86B600 VA: 0x18086D000
	public bool MoveNext(float distance) { }

	// RVA: 0x86CFB0 Offset: 0x86B5B0 VA: 0x18086CFB0
	public bool HasNext() { }

	// RVA: 0x86D180 Offset: 0x86B780 VA: 0x18086D180
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x86D350 Offset: 0x86B950 VA: 0x18086D350
	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 11406
{	// Fields
	public Vector3 point; // 0x0
	public float length; // 0xC

	// Methods

	// RVA: 0xF9370 Offset: 0xF8770 VA: 0x1800F9370
	public void .ctor(Vector3 a, Vector3 b) { }

}

