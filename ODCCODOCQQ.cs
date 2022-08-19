public class ODCCODOCQQ : MonoBehaviour // TypeDefIndex: 7205
{	// Fields
	public static GameObject rtg; // 0x0
	public static GameObject swgLeft; // 0x8
	public static GameObject swgRight; // 0x10
	public static Vector3 camdir; // 0x18
	public static List<List<Vector3>> vecs; // 0x28

	// Methods

	// RVA: 0x423140 Offset: 0x421740 VA: 0x180423140
	public static void OODDQCQQDQ(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0x41E0A0 Offset: 0x41C6A0 VA: 0x18041E0A0
	public static void CleanMeshData(Mesh m, List<List<int>> mtris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs2, ref List<Vector3> normals, ref List<Vector4> tangents, ref List<Color> colors, ref List<List<int>> tris) { }

	// RVA: 0x41F430 Offset: 0x41DA30 VA: 0x18041F430
	public static void OCDCQCOQQO(Mesh mesh) { }

	// RVA: 0x421980 Offset: 0x41FF80 VA: 0x180421980
	public static void OOCQQCOQQC(Mesh mesh) { }

	// RVA: 0x41E800 Offset: 0x41CE00 VA: 0x18041E800
	public static void GenerateWaypoints(ERModularRoad scr, float distance) { }

	// RVA: 0x423790 Offset: 0x421D90 VA: 0x180423790
	public static void OOQDCQODOD(List<SelectedObject> selectedObjects, int alignType) { }

	// RVA: 0x421950 Offset: 0x41FF50 VA: 0x180421950
	public static void OOCDQDQDCQ(GameObject go, SideObject so, List<Vector3> vecs, List<Vector2> uvs, List<Vector2> uvs1, List<Color> color, List<Vector4> tangents, List<int> triangles, List<Vector3> normals, List<int> normalArray1, List<int> normalArray2) { }

	// RVA: 0x41EE50 Offset: 0x41D450 VA: 0x18041EE50
	public static void GetRoadShape(float width, int subSegments, ref List<Vector2> roadShape, ref List<float> uvs, ref List<float> uvs1, float dir) { }

	// RVA: 0x41F030 Offset: 0x41D630 VA: 0x18041F030
	public static void GetRoadShape(float oldWidth, QDQDOOQQDQODD roadType, float dir) { }

	// RVA: 0x426BE0 Offset: 0x4251E0 VA: 0x180426BE0
	public static void UpdateRoadType(ERModularBase scr, int index) { }

	// RVA: 0x425A50 Offset: 0x424050 VA: 0x180425A50
	public static bool UpdateRoadTypeByRoad(ERModularBase scr, ERModularRoad road, int index, QDQDOOQQDQODD type) { }

	// RVA: 0x420250 Offset: 0x41E850 VA: 0x180420250
	public static int OCDQQQDDQO(List<Vector2> roadShape) { }

	// RVA: 0x41FF30 Offset: 0x41E530 VA: 0x18041FF30
	public static void OCDQCDQQDD(ref List<ERMarkerExt> tmpMarkersExt) { }

	// RVA: 0x420380 Offset: 0x41E980 VA: 0x180420380
	public static void ODOCDOQDDQ(QDQDOOQQDQODD roadType) { }

	// RVA: 0x4256D0 Offset: 0x423CD0 VA: 0x1804256D0
	public static void RebuildMainRoadShape(QDQDOOQQDQODD roadType) { }

	// RVA: 0x424F50 Offset: 0x423550 VA: 0x180424F50
	public static void OQDCDQDCQC(QDQDOOQQDQODD roadType, ref List<Vector2> roadShape, ref List<float> roadShapeUVs, ref List<bool> doConnectionTri, ref List<bool> hardEdge, ref int currentMostLeftInt, ref int currentMostRightInt, ref int sectionRoadShapeCols, int leftright, int lineIndexTarget, bool transition, List<Vector2> origRoadShape) { }

	// RVA: 0x421A80 Offset: 0x420080 VA: 0x180421A80
	public static List<int> OODCQDDQDC(List<Vector2> _rs1, List<bool> _hd1, int cols1, List<Vector2> _rs2, List<bool> _hd2, int cols2, ref List<int> tris, bool flipNormals, int vecCount, int i1, int i2, int last1, int last2) { }

	// RVA: 0x4235A0 Offset: 0x421BA0 VA: 0x1804235A0
	public static void OOQCCCDODD(QDQDOOQQDQODD roadType, ref List<Vector2> roadShapeVecs, ref List<float> roadShapeUVs, ref List<bool> hardEdge, ref int rightOuterIndex) { }

	// RVA: 0x426C70 Offset: 0x425270 VA: 0x180426C70
	public static void VisualizeRoadType(ERModularBase baseScript, GameObject prefab, QDQDOOQQDQODD rt, Vector3 pos, Vector3 dir) { }

	// RVA: 0x420590 Offset: 0x41EB90 VA: 0x180420590
	public static void ODODDQCQQC(QDQDOOQQDQODD rt) { }

	// RVA: 0x422350 Offset: 0x420950 VA: 0x180422350
	public static void OODDDCCOQO(List<Vector3> cvecs, float OOCODCCCOQ, float OQQDDDQDOQ, float OCCOCCCODQ, List<float> breakpoints, float OQQOOQOOQQ, Vector3 startDir, Vector3 endDir, ref List<Vector3> vecs, float length, Vector3 firstRounding, float uvRatio) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void RoadShapeChangeTriangulation(List<Vector3> shape1, List<Vector3> shape2, int startIndex1, int endIndex1, int startIndex2, int endIndex2, ref List<int> tris) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x427360 Offset: 0x425960 VA: 0x180427360
	private static void .cctor() { }

}

