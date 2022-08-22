public class WorldSplineData // TypeDefIndex: 11412
{	// Fields
	public Vector3[] inputPoints; // 0x10
	public Vector3[] inputTangents; // 0x18
	public float inputLUTInterval; // 0x20
	public List<WorldSplineData.LUTEntry> LUTValues; // 0x28
	public float Length; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int maxPointsIndex; // 0x34

	// Methods

	// RVA: 0x1A75B10 Offset: 0x1A74110 VA: 0x181A75B10
	public void .ctor(WorldSpline worldSpline) { }

	// RVA: 0x1A759E0 Offset: 0x1A73FE0 VA: 0x181A759E0
	public bool IsSameAs(WorldSpline worldSpline) { }

	// RVA: 0x1A75950 Offset: 0x1A73F50 VA: 0x181A75950
	public bool IsDifferentTo(WorldSpline worldSpline) { }

	// RVA: 0x1A758A0 Offset: 0x1A73EA0 VA: 0x181A758A0
	public Vector3 GetStartPoint() { }

	// RVA: 0x1A75160 Offset: 0x1A73760 VA: 0x181A75160
	public Vector3 GetEndPoint() { }

	// RVA: 0x1A758E0 Offset: 0x1A73EE0 VA: 0x181A758E0
	public Vector3 GetStartTangent() { }

	// RVA: 0x1A751C0 Offset: 0x1A737C0 VA: 0x181A751C0
	public Vector3 GetEndTangent() { }

	// RVA: 0x1A75860 Offset: 0x1A73E60 VA: 0x181A75860
	public Vector3 GetPointCubicHermite(float distance) { }

	// RVA: 0x1A75920 Offset: 0x1A73F20 VA: 0x181A75920
	public Vector3 GetTangentCubicHermite(float distance) { }

	// RVA: 0x1A75220 Offset: 0x1A73820 VA: 0x181A75220
	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	// RVA: 0x1A75A70 Offset: 0x1A74070 VA: 0x181A75A70
	public void SetDefaultTangents(WorldSpline worldSpline) { }

	// RVA: 0x1A74DA0 Offset: 0x1A733A0 VA: 0x181A74DA0
	public bool DetectSplineProblems(WorldSpline worldSpline) { }

	// RVA: 0x1A74A90 Offset: 0x1A73090 VA: 0x181A74A90
	private void CreateLookupTable(WorldSpline worldSpline) { }

	// RVA: 0x1A748A0 Offset: 0x1A72EA0 VA: 0x181A748A0
	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11413
{	// Fields
	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10

	// Methods

	// RVA: 0x1A74830 Offset: 0x1A72E30 VA: 0x181A74830
	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 11414
{	// Fields
	public float distance; // 0x0
	public Vector3 pos; // 0x4

	// Methods

	// RVA: 0x2294E0 Offset: 0x2288E0 VA: 0x1802294E0
	public void .ctor(float distance, Vector3 pos) { }

}

