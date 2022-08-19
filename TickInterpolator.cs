public class TickInterpolator // TypeDefIndex: 11405
{	// Fields
	private List<TickInterpolator.Segment> points; // 0x10
	private int index; // 0x18
	public float Length; // 0x1C
	public Vector3 CurrentPoint; // 0x20
	public Vector3 StartPoint; // 0x2C
	public Vector3 EndPoint; // 0x38

	// Methods

	// RVA: 0x889C90 Offset: 0x888290 VA: 0x180889C90
	public void Reset() { }

	// RVA: 0x889CB0 Offset: 0x8882B0 VA: 0x180889CB0
	public void Reset(Vector3 point) { }

	// RVA: 0x889A40 Offset: 0x888040 VA: 0x180889A40
	public void AddPoint(Vector3 point) { }

	// RVA: 0x889BB0 Offset: 0x8881B0 VA: 0x180889BB0
	public bool MoveNext(float distance) { }

	// RVA: 0x889B60 Offset: 0x888160 VA: 0x180889B60
	public bool HasNext() { }

	// RVA: 0x889D30 Offset: 0x888330 VA: 0x180889D30
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x889F00 Offset: 0x888500 VA: 0x180889F00
	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 11406
{	// Fields
	public Vector3 point; // 0x0
	public float length; // 0xC

	// Methods

	// RVA: 0xF9740 Offset: 0xF8B40 VA: 0x1800F9740
	public void .ctor(Vector3 a, Vector3 b) { }

}

