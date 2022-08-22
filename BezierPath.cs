public class BezierPath // TypeDefIndex: 11736
{	// Fields
	public int SegmentsPerCurve; // 0x10
	public float MINIMUM_SQR_DISTANCE; // 0x14
	public float DIVISION_THRESHOLD; // 0x18
	private List<Vector2> controlPoints; // 0x20
	private int curveCount; // 0x28

	// Methods

	// RVA: 0x11D4760 Offset: 0x11D2D60 VA: 0x1811D4760
	public void .ctor() { }

	// RVA: 0x11D4640 Offset: 0x11D2C40 VA: 0x1811D4640
	public void SetControlPoints(List<Vector2> newControlPoints) { }

	// RVA: 0x11D46D0 Offset: 0x11D2CD0 VA: 0x1811D46D0
	public void SetControlPoints(Vector2[] newControlPoints) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public List<Vector2> GetControlPoints() { }

	// RVA: 0x11D3E50 Offset: 0x11D2450 VA: 0x1811D3E50
	public void Interpolate(List<Vector2> segmentPoints, float scale) { }

	// RVA: 0x11D4250 Offset: 0x11D2850 VA: 0x1811D4250
	public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale) { }

	// RVA: 0x11D31E0 Offset: 0x11D17E0 VA: 0x1811D31E0
	public Vector2 CalculateBezierPoint(int curveIndex, float t) { }

	// RVA: 0x11D38B0 Offset: 0x11D1EB0 VA: 0x1811D38B0
	public List<Vector2> GetDrawingPoints0() { }

	// RVA: 0x11D39B0 Offset: 0x11D1FB0 VA: 0x1811D39B0
	public List<Vector2> GetDrawingPoints1() { }

	// RVA: 0x11D3CA0 Offset: 0x11D22A0 VA: 0x1811D3CA0
	public List<Vector2> GetDrawingPoints2() { }

	// RVA: 0x11D34E0 Offset: 0x11D1AE0 VA: 0x1811D34E0
	private List<Vector2> FindDrawingPoints(int curveIndex) { }

	// RVA: 0x11D35F0 Offset: 0x11D1BF0 VA: 0x1811D35F0
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex) { }

	// RVA: 0x11D3360 Offset: 0x11D1960 VA: 0x1811D3360
	private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

}

