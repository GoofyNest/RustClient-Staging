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

	// RVA: 0x1A8A1D0 Offset: 0x1A887D0 VA: 0x181A8A1D0
	public WorldSplineData GetData() { }

	// RVA: 0x1A8B840 Offset: 0x1A89E40 VA: 0x181A8B840
	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	// RVA: 0x1A897C0 Offset: 0x1A87DC0 VA: 0x181A897C0
	public void CheckValidity() { }

	// RVA: 0x1A8B6B0 Offset: 0x1A89CB0 VA: 0x181A8B6B0 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1A89A60 Offset: 0x1A88060 VA: 0x181A89A60
	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	// RVA: 0x1A8B2A0 Offset: 0x1A898A0 VA: 0x181A8B2A0
	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	// RVA: 0x1A8AAD0 Offset: 0x1A890D0 VA: 0x181A8AAD0
	public Vector3 GetStartPointWorld() { }

	// RVA: 0x1A8A3C0 Offset: 0x1A889C0 VA: 0x181A8A3C0
	public Vector3 GetEndPointWorld() { }

	// RVA: 0x1A8AB60 Offset: 0x1A89160 VA: 0x181A8AB60
	public Vector3 GetStartTangentWorld() { }

	// RVA: 0x1A8A460 Offset: 0x1A88A60 VA: 0x181A8A460
	public Vector3 GetEndTangentWorld() { }

	// RVA: 0x1A8AEA0 Offset: 0x1A894A0 VA: 0x181A8AEA0
	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	// RVA: 0x1A8ACF0 Offset: 0x1A892F0 VA: 0x181A8ACF0
	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A8A810 Offset: 0x1A88E10 VA: 0x181A8A810
	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	// RVA: 0x1A8A8D0 Offset: 0x1A88ED0 VA: 0x181A8A8D0
	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A8A700 Offset: 0x1A88D00 VA: 0x181A8A700
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	// RVA: 0x1A8A600 Offset: 0x1A88C00 VA: 0x181A8A600
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	// RVA: 0x1A8A980 Offset: 0x1A88F80 VA: 0x181A8A980
	public Vector3[] GetPointsWorld() { }

	// RVA: 0x1A8B050 Offset: 0x1A89650 VA: 0x181A8B050
	public Vector3[] GetTangentsWorld() { }

	// RVA: 0x1A8B730 Offset: 0x1A89D30 VA: 0x181A8B730
	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	// RVA: 0x1A8B890 Offset: 0x1A89E90 VA: 0x181A8B890
	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	// RVA: 0x1A8BB10 Offset: 0x1A8A110 VA: 0x181A8BB10
	public void .ctor() { }

	// RVA: 0x1A8BAB0 Offset: 0x1A8A0B0 VA: 0x181A8BAB0
	private static void .cctor() { }

}

