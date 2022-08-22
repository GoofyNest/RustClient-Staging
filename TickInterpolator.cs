public class TickInterpolator // TypeDefIndex: 11405
{	// Fields
	private List<TickInterpolator.Segment> points; // 0x10
	private int index; // 0x18
	public float Length; // 0x1C
	public Vector3 CurrentPoint; // 0x20
	public Vector3 StartPoint; // 0x2C
	public Vector3 EndPoint; // 0x38

	// Methods

	// RVA: 0x889DA0 Offset: 0x8883A0 VA: 0x180889DA0
	public void Reset() { }

	// RVA: 0x889DC0 Offset: 0x8883C0 VA: 0x180889DC0
	public void Reset(Vector3 point) { }

	// RVA: 0x889B50 Offset: 0x888150 VA: 0x180889B50
	public void AddPoint(Vector3 point) { }

	// RVA: 0x889CC0 Offset: 0x8882C0 VA: 0x180889CC0
	public bool MoveNext(float distance) { }

	// RVA: 0x889C70 Offset: 0x888270 VA: 0x180889C70
	public bool HasNext() { }

	// RVA: 0x889E40 Offset: 0x888440 VA: 0x180889E40
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x88A010 Offset: 0x888610 VA: 0x18088A010
	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 11406
{	// Fields
	public Vector3 point; // 0x0
	public float length; // 0xC

	// Methods

	// RVA: 0xF96C0 Offset: 0xF8AC0 VA: 0x1800F96C0
	public void .ctor(Vector3 a, Vector3 b) { }

}

