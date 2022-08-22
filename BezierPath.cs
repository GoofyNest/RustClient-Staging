public class BezierPath // TypeDefIndex: 11736
{	// Fields
	public int SegmentsPerCurve; // 0x10
	public float MINIMUM_SQR_DISTANCE; // 0x14
	public float DIVISION_THRESHOLD; // 0x18
	private List<Vector2> controlPoints; // 0x20
	private int curveCount; // 0x28

	// Methods

	// RVA: 0x11D4E00 Offset: 0x11D3400 VA: 0x1811D4E00
	public void .ctor() { }

	// RVA: 0x11D4CE0 Offset: 0x11D32E0 VA: 0x1811D4CE0
	public void SetControlPoints(List<Vector2> newControlPoints) { }

	// RVA: 0x11D4D70 Offset: 0x11D3370 VA: 0x1811D4D70
	public void SetControlPoints(Vector2[] newControlPoints) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public List<Vector2> GetControlPoints() { }

	// RVA: 0x11D44F0 Offset: 0x11D2AF0 VA: 0x1811D44F0
	public void Interpolate(List<Vector2> segmentPoints, float scale) { }

	// RVA: 0x11D48F0 Offset: 0x11D2EF0 VA: 0x1811D48F0
	public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale) { }

	// RVA: 0x11D3880 Offset: 0x11D1E80 VA: 0x1811D3880
	public Vector2 CalculateBezierPoint(int curveIndex, float t) { }

	// RVA: 0x11D3F50 Offset: 0x11D2550 VA: 0x1811D3F50
	public List<Vector2> GetDrawingPoints0() { }

	// RVA: 0x11D4050 Offset: 0x11D2650 VA: 0x1811D4050
	public List<Vector2> GetDrawingPoints1() { }

	// RVA: 0x11D4340 Offset: 0x11D2940 VA: 0x1811D4340
	public List<Vector2> GetDrawingPoints2() { }

	// RVA: 0x11D3B80 Offset: 0x11D2180 VA: 0x1811D3B80
	private List<Vector2> FindDrawingPoints(int curveIndex) { }

	// RVA: 0x11D3C90 Offset: 0x11D2290 VA: 0x1811D3C90
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex) { }

	// RVA: 0x11D3A00 Offset: 0x11D2000 VA: 0x1811D3A00
	private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

}

