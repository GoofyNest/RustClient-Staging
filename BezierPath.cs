public class BezierPath // TypeDefIndex: 11736
{	// Fields
	public int SegmentsPerCurve; // 0x10
	public float MINIMUM_SQR_DISTANCE; // 0x14
	public float DIVISION_THRESHOLD; // 0x18
	private List<Vector2> controlPoints; // 0x20
	private int curveCount; // 0x28

	// Methods

	// RVA: 0x11D44A0 Offset: 0x11D2AA0 VA: 0x1811D44A0
	public void .ctor() { }

	// RVA: 0x11D4380 Offset: 0x11D2980 VA: 0x1811D4380
	public void SetControlPoints(List<Vector2> newControlPoints) { }

	// RVA: 0x11D4410 Offset: 0x11D2A10 VA: 0x1811D4410
	public void SetControlPoints(Vector2[] newControlPoints) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public List<Vector2> GetControlPoints() { }

	// RVA: 0x11D3B90 Offset: 0x11D2190 VA: 0x1811D3B90
	public void Interpolate(List<Vector2> segmentPoints, float scale) { }

	// RVA: 0x11D3F90 Offset: 0x11D2590 VA: 0x1811D3F90
	public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale) { }

	// RVA: 0x11D2F20 Offset: 0x11D1520 VA: 0x1811D2F20
	public Vector2 CalculateBezierPoint(int curveIndex, float t) { }

	// RVA: 0x11D35F0 Offset: 0x11D1BF0 VA: 0x1811D35F0
	public List<Vector2> GetDrawingPoints0() { }

	// RVA: 0x11D36F0 Offset: 0x11D1CF0 VA: 0x1811D36F0
	public List<Vector2> GetDrawingPoints1() { }

	// RVA: 0x11D39E0 Offset: 0x11D1FE0 VA: 0x1811D39E0
	public List<Vector2> GetDrawingPoints2() { }

	// RVA: 0x11D3220 Offset: 0x11D1820 VA: 0x1811D3220
	private List<Vector2> FindDrawingPoints(int curveIndex) { }

	// RVA: 0x11D3330 Offset: 0x11D1930 VA: 0x1811D3330
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex) { }

	// RVA: 0x11D30A0 Offset: 0x11D16A0 VA: 0x1811D30A0
	private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

}

