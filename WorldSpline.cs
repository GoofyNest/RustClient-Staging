public class WorldSpline : MonoBehaviour // TypeDefIndex: 11411
{	// Fields
	public int dataIndex; // 0x18
	public Vector3[] points; // 0x20
	public Vector3[] tangents; // 0x28
	[RangeAttribute] // RVA: 0xAC440 Offset: 0xAB840 VA: 0x1800AC440
	public float lutInterval; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool showGizmos; // 0x34
	private static List<Vector3> visualSplineList; // 0x0
	private WorldSplineData privateData; // 0x38

	// Methods

	// RVA: 0x1A9FF50 Offset: 0x1A9E550 VA: 0x181A9FF50
	public WorldSplineData GetData() { }

	// RVA: 0x1AA1910 Offset: 0x1A9FF10 VA: 0x181AA1910
	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	// RVA: 0x1A9F540 Offset: 0x1A9DB40 VA: 0x181A9F540
	public void CheckValidity() { }

	// RVA: 0x1AA1780 Offset: 0x1A9FD80 VA: 0x181AA1780 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1A9F7E0 Offset: 0x1A9DDE0 VA: 0x181A9F7E0
	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	// RVA: 0x1AA1370 Offset: 0x1A9F970 VA: 0x181AA1370
	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	// RVA: 0x1AA0850 Offset: 0x1A9EE50 VA: 0x181AA0850
	public Vector3 GetStartPointWorld() { }

	// RVA: 0x1AA0140 Offset: 0x1A9E740 VA: 0x181AA0140
	public Vector3 GetEndPointWorld() { }

	// RVA: 0x1AA08E0 Offset: 0x1A9EEE0 VA: 0x181AA08E0
	public Vector3 GetStartTangentWorld() { }

	// RVA: 0x1AA01E0 Offset: 0x1A9E7E0 VA: 0x181AA01E0
	public Vector3 GetEndTangentWorld() { }

	// RVA: 0x1AA0F70 Offset: 0x1A9F570 VA: 0x181AA0F70
	public Vector3 GetTangentWorld(float distance) { }

	// RVA: 0x1AA0DD0 Offset: 0x1A9F3D0 VA: 0x181AA0DD0
	public Vector3 GetTangentWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1AA0C20 Offset: 0x1A9F220 VA: 0x181AA0C20
	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	// RVA: 0x1AA0A70 Offset: 0x1A9F070 VA: 0x181AA0A70
	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1AA0590 Offset: 0x1A9EB90 VA: 0x181AA0590
	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	// RVA: 0x1AA0650 Offset: 0x1A9EC50 VA: 0x181AA0650
	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1AA0480 Offset: 0x1A9EA80 VA: 0x181AA0480
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	// RVA: 0x1AA0380 Offset: 0x1A9E980 VA: 0x181AA0380
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	// RVA: 0x1AA0700 Offset: 0x1A9ED00 VA: 0x181AA0700
	public Vector3[] GetPointsWorld() { }

	// RVA: 0x1AA1120 Offset: 0x1A9F720 VA: 0x181AA1120
	public Vector3[] GetTangentsWorld() { }

	// RVA: 0x1AA1800 Offset: 0x1A9FE00 VA: 0x181AA1800
	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	// RVA: 0x1AA1960 Offset: 0x1A9FF60 VA: 0x181AA1960
	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	// RVA: 0x1AA1BE0 Offset: 0x1AA01E0 VA: 0x181AA1BE0
	public void .ctor() { }

	// RVA: 0x1AA1B80 Offset: 0x1AA0180 VA: 0x181AA1B80
	private static void .cctor() { }

}

