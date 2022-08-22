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

	// RVA: 0x1A769E0 Offset: 0x1A74FE0 VA: 0x181A769E0
	public WorldSplineData GetData() { }

	// RVA: 0x1A78050 Offset: 0x1A76650 VA: 0x181A78050
	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	// RVA: 0x1A75FD0 Offset: 0x1A745D0 VA: 0x181A75FD0
	public void CheckValidity() { }

	// RVA: 0x1A77EC0 Offset: 0x1A764C0 VA: 0x181A77EC0 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1A76270 Offset: 0x1A74870 VA: 0x181A76270
	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	// RVA: 0x1A77AB0 Offset: 0x1A760B0 VA: 0x181A77AB0
	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	// RVA: 0x1A772E0 Offset: 0x1A758E0 VA: 0x181A772E0
	public Vector3 GetStartPointWorld() { }

	// RVA: 0x1A76BD0 Offset: 0x1A751D0 VA: 0x181A76BD0
	public Vector3 GetEndPointWorld() { }

	// RVA: 0x1A77370 Offset: 0x1A75970 VA: 0x181A77370
	public Vector3 GetStartTangentWorld() { }

	// RVA: 0x1A76C70 Offset: 0x1A75270 VA: 0x181A76C70
	public Vector3 GetEndTangentWorld() { }

	// RVA: 0x1A776B0 Offset: 0x1A75CB0 VA: 0x181A776B0
	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	// RVA: 0x1A77500 Offset: 0x1A75B00 VA: 0x181A77500
	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A77020 Offset: 0x1A75620 VA: 0x181A77020
	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	// RVA: 0x1A770E0 Offset: 0x1A756E0 VA: 0x181A770E0
	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A76F10 Offset: 0x1A75510 VA: 0x181A76F10
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	// RVA: 0x1A76E10 Offset: 0x1A75410 VA: 0x181A76E10
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	// RVA: 0x1A77190 Offset: 0x1A75790 VA: 0x181A77190
	public Vector3[] GetPointsWorld() { }

	// RVA: 0x1A77860 Offset: 0x1A75E60 VA: 0x181A77860
	public Vector3[] GetTangentsWorld() { }

	// RVA: 0x1A77F40 Offset: 0x1A76540 VA: 0x181A77F40
	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	// RVA: 0x1A780A0 Offset: 0x1A766A0 VA: 0x181A780A0
	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	// RVA: 0x1A78320 Offset: 0x1A76920 VA: 0x181A78320
	public void .ctor() { }

	// RVA: 0x1A782C0 Offset: 0x1A768C0 VA: 0x181A782C0
	private static void .cctor() { }

}

