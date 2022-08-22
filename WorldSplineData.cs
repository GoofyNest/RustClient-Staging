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

	// RVA: 0x1A89300 Offset: 0x1A87900 VA: 0x181A89300
	public void .ctor(WorldSpline worldSpline) { }

	// RVA: 0x1A891D0 Offset: 0x1A877D0 VA: 0x181A891D0
	public bool IsSameAs(WorldSpline worldSpline) { }

	// RVA: 0x1A89140 Offset: 0x1A87740 VA: 0x181A89140
	public bool IsDifferentTo(WorldSpline worldSpline) { }

	// RVA: 0x1A89090 Offset: 0x1A87690 VA: 0x181A89090
	public Vector3 GetStartPoint() { }

	// RVA: 0x1A88950 Offset: 0x1A86F50 VA: 0x181A88950
	public Vector3 GetEndPoint() { }

	// RVA: 0x1A890D0 Offset: 0x1A876D0 VA: 0x181A890D0
	public Vector3 GetStartTangent() { }

	// RVA: 0x1A889B0 Offset: 0x1A86FB0 VA: 0x181A889B0
	public Vector3 GetEndTangent() { }

	// RVA: 0x1A89050 Offset: 0x1A87650 VA: 0x181A89050
	public Vector3 GetPointCubicHermite(float distance) { }

	// RVA: 0x1A89110 Offset: 0x1A87710 VA: 0x181A89110
	public Vector3 GetTangentCubicHermite(float distance) { }

	// RVA: 0x1A88A10 Offset: 0x1A87010 VA: 0x181A88A10
	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	// RVA: 0x1A89260 Offset: 0x1A87860 VA: 0x181A89260
	public void SetDefaultTangents(WorldSpline worldSpline) { }

	// RVA: 0x1A88590 Offset: 0x1A86B90 VA: 0x181A88590
	public bool DetectSplineProblems(WorldSpline worldSpline) { }

	// RVA: 0x1A88280 Offset: 0x1A86880 VA: 0x181A88280
	private void CreateLookupTable(WorldSpline worldSpline) { }

	// RVA: 0x1A88090 Offset: 0x1A86690 VA: 0x181A88090
	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11413
{	// Fields
	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10

	// Methods

	// RVA: 0x1A88020 Offset: 0x1A86620 VA: 0x181A88020
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

