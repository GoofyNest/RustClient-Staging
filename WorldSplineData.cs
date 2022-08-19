public class WorldSplineData // TypeDefIndex: 11412
{	// Fields
	public Vector3[] inputPoints; // 0x10
	public Vector3[] inputTangents; // 0x18
	public float inputLUTInterval; // 0x20
	public List<WorldSplineData.LUTEntry> LUTValues; // 0x28
	public float Length; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int maxPointsIndex; // 0x34

	// Methods

	// RVA: 0x1A9F080 Offset: 0x1A9D680 VA: 0x181A9F080
	public void .ctor(WorldSpline worldSpline) { }

	// RVA: 0x1A9EF50 Offset: 0x1A9D550 VA: 0x181A9EF50
	public bool IsSameAs(WorldSpline worldSpline) { }

	// RVA: 0x1A9EEC0 Offset: 0x1A9D4C0 VA: 0x181A9EEC0
	public bool IsDifferentTo(WorldSpline worldSpline) { }

	// RVA: 0x1A9EC20 Offset: 0x1A9D220 VA: 0x181A9EC20
	public Vector3 GetStartPoint() { }

	// RVA: 0x1A9E4E0 Offset: 0x1A9CAE0 VA: 0x181A9E4E0
	public Vector3 GetEndPoint() { }

	// RVA: 0x1A9EC60 Offset: 0x1A9D260 VA: 0x181A9EC60
	public Vector3 GetStartTangent() { }

	// RVA: 0x1A9E540 Offset: 0x1A9CB40 VA: 0x181A9E540
	public Vector3 GetEndTangent() { }

	// RVA: 0x1A9ECD0 Offset: 0x1A9D2D0 VA: 0x181A9ECD0 Slot: 4
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x1A9EBE0 Offset: 0x1A9D1E0 VA: 0x181A9EBE0
	public Vector3 GetPointCubicHermite(float distance) { }

	// RVA: 0x1A9ECA0 Offset: 0x1A9D2A0 VA: 0x181A9ECA0
	public Vector3 GetTangentCubicHermite(float distance) { }

	// RVA: 0x1A9E5A0 Offset: 0x1A9CBA0 VA: 0x181A9E5A0
	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	// RVA: 0x1A9EFE0 Offset: 0x1A9D5E0 VA: 0x181A9EFE0
	public void SetDefaultTangents(WorldSpline worldSpline) { }

	// RVA: 0x1A9E1D0 Offset: 0x1A9C7D0 VA: 0x181A9E1D0
	private void CreateLookupTable(WorldSpline worldSpline) { }

	// RVA: 0x1A9DFE0 Offset: 0x1A9C5E0 VA: 0x181A9DFE0
	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11413
{	// Fields
	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10

	// Methods

	// RVA: 0x1A9DF70 Offset: 0x1A9C570 VA: 0x181A9DF70
	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 11414
{	// Fields
	public float distance; // 0x0
	public Vector3 pos; // 0x4

	// Methods

	// RVA: 0x22A580 Offset: 0x229980 VA: 0x18022A580
	public void .ctor(float distance, Vector3 pos) { }

}

