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

	// RVA: 0x1A89040 Offset: 0x1A87640 VA: 0x181A89040
	public void .ctor(WorldSpline worldSpline) { }

	// RVA: 0x1A88F10 Offset: 0x1A87510 VA: 0x181A88F10
	public bool IsSameAs(WorldSpline worldSpline) { }

	// RVA: 0x1A88E80 Offset: 0x1A87480 VA: 0x181A88E80
	public bool IsDifferentTo(WorldSpline worldSpline) { }

	// RVA: 0x1A88DD0 Offset: 0x1A873D0 VA: 0x181A88DD0
	public Vector3 GetStartPoint() { }

	// RVA: 0x1A88690 Offset: 0x1A86C90 VA: 0x181A88690
	public Vector3 GetEndPoint() { }

	// RVA: 0x1A88E10 Offset: 0x1A87410 VA: 0x181A88E10
	public Vector3 GetStartTangent() { }

	// RVA: 0x1A886F0 Offset: 0x1A86CF0 VA: 0x181A886F0
	public Vector3 GetEndTangent() { }

	// RVA: 0x1A88D90 Offset: 0x1A87390 VA: 0x181A88D90
	public Vector3 GetPointCubicHermite(float distance) { }

	// RVA: 0x1A88E50 Offset: 0x1A87450 VA: 0x181A88E50
	public Vector3 GetTangentCubicHermite(float distance) { }

	// RVA: 0x1A88750 Offset: 0x1A86D50 VA: 0x181A88750
	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	// RVA: 0x1A88FA0 Offset: 0x1A875A0 VA: 0x181A88FA0
	public void SetDefaultTangents(WorldSpline worldSpline) { }

	// RVA: 0x1A882D0 Offset: 0x1A868D0 VA: 0x181A882D0
	public bool DetectSplineProblems(WorldSpline worldSpline) { }

	// RVA: 0x1A87FC0 Offset: 0x1A865C0 VA: 0x181A87FC0
	private void CreateLookupTable(WorldSpline worldSpline) { }

	// RVA: 0x1A87DD0 Offset: 0x1A863D0 VA: 0x181A87DD0
	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11413
{	// Fields
	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10

	// Methods

	// RVA: 0x1A87D60 Offset: 0x1A86360 VA: 0x181A87D60
	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 11414
{	// Fields
	public float distance; // 0x0
	public Vector3 pos; // 0x4

	// Methods

	// RVA: 0x22A500 Offset: 0x229900 VA: 0x18022A500
	public void .ctor(float distance, Vector3 pos) { }

}

