public class WorldSpline : MonoBehaviour // TypeDefIndex: 11411
{	// Fields
	public int dataIndex; // 0x18
	public Vector3[] points; // 0x20
	public Vector3[] tangents; // 0x28
	[RangeAttribute] // RVA: 0xAC4E0 Offset: 0xAB8E0 VA: 0x1800AC4E0
	public float lutInterval; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool showGizmos; // 0x34
	private static List<Vector3> visualSplineList; // 0x0
	private WorldSplineData privateData; // 0x38

	// Methods

	// RVA: 0x1A89F10 Offset: 0x1A88510 VA: 0x181A89F10
	public WorldSplineData GetData() { }

	// RVA: 0x1A8B580 Offset: 0x1A89B80 VA: 0x181A8B580
	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	// RVA: 0x1A89500 Offset: 0x1A87B00 VA: 0x181A89500
	public void CheckValidity() { }

	// RVA: 0x1A8B3F0 Offset: 0x1A899F0 VA: 0x181A8B3F0 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1A897A0 Offset: 0x1A87DA0 VA: 0x181A897A0
	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	// RVA: 0x1A8AFE0 Offset: 0x1A895E0 VA: 0x181A8AFE0
	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	// RVA: 0x1A8A810 Offset: 0x1A88E10 VA: 0x181A8A810
	public Vector3 GetStartPointWorld() { }

	// RVA: 0x1A8A100 Offset: 0x1A88700 VA: 0x181A8A100
	public Vector3 GetEndPointWorld() { }

	// RVA: 0x1A8A8A0 Offset: 0x1A88EA0 VA: 0x181A8A8A0
	public Vector3 GetStartTangentWorld() { }

	// RVA: 0x1A8A1A0 Offset: 0x1A887A0 VA: 0x181A8A1A0
	public Vector3 GetEndTangentWorld() { }

	// RVA: 0x1A8ABE0 Offset: 0x1A891E0 VA: 0x181A8ABE0
	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	// RVA: 0x1A8AA30 Offset: 0x1A89030 VA: 0x181A8AA30
	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A8A550 Offset: 0x1A88B50 VA: 0x181A8A550
	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	// RVA: 0x1A8A610 Offset: 0x1A88C10 VA: 0x181A8A610
	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A8A440 Offset: 0x1A88A40 VA: 0x181A8A440
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	// RVA: 0x1A8A340 Offset: 0x1A88940 VA: 0x181A8A340
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	// RVA: 0x1A8A6C0 Offset: 0x1A88CC0 VA: 0x181A8A6C0
	public Vector3[] GetPointsWorld() { }

	// RVA: 0x1A8AD90 Offset: 0x1A89390 VA: 0x181A8AD90
	public Vector3[] GetTangentsWorld() { }

	// RVA: 0x1A8B470 Offset: 0x1A89A70 VA: 0x181A8B470
	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	// RVA: 0x1A8B5D0 Offset: 0x1A89BD0 VA: 0x181A8B5D0
	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	// RVA: 0x1A8B850 Offset: 0x1A89E50 VA: 0x181A8B850
	public void .ctor() { }

	// RVA: 0x1A8B7F0 Offset: 0x1A89DF0 VA: 0x181A8B7F0
	private static void .cctor() { }

}

