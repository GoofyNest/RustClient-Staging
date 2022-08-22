public class QDDDQODDQDQDQDD : MonoBehaviour // TypeDefIndex: 7261
{	// Fields
	public static Vector3 testPoint; // 0x0
	public static ERCrossings cScr; // 0x10
	public static List<Vector3> ll1; // 0x18
	public static List<Vector3> ll2; // 0x20
	public static List<Vector3> ll3; // 0x28
	public static List<Vector3> ll4; // 0x30
	public static int crossingStructure; // 0x38
	public static List<QDQDOOQQDQODD> roadTypesDynamic; // 0x40
	public static ERModularBase baseScript; // 0x48
	public static List<ERConnectionSibling> siblings; // 0x50
	public static Vector3 crossPointCenter; // 0x58
	public static ERCrossingPrefabs prefabScript; // 0x68
	public static ERConnectionSibling primaryPriorityConnection; // 0x70
	public static ERConnectionSibling secondPriorityConnection; // 0x78
	private static float ᙃ; // 0x80
	private static float ᙄ; // 0x84
	public static List<Vector3> debugEdges; // 0x88
	public static List<Vector3> debugvecs; // 0x90

	// Methods

	// RVA: 0xD229F0 Offset: 0xD20FF0 VA: 0x180D229F0
	public static List<QDQDOOQQDQODD> OQQCDQOQCD(List<QDQDOOQQDQODD> roadTypes, bool all) { }

	// RVA: 0xD21A90 Offset: 0xD20090 VA: 0x180D21A90
	public static void OQODQQQCOC(ERCrossings scr) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ODODCOOQDO() { }

	// RVA: 0xD0B890 Offset: 0xD09E90 VA: 0x180D0B890
	public static bool OCODDQQOCQ(List<ERConnectionSibling> siblings, int thisSibling, int OtherSibling, int startLane) { }

	// RVA: 0xD1D7B0 Offset: 0xD1BDB0 VA: 0x180D1D7B0
	public static void OQCDQDQOOO(bool hasLaneControlData) { }

	// RVA: 0xD0B7B0 Offset: 0xD09DB0 VA: 0x180D0B7B0
	public static ERLaneConnector OCODCDQQOQ(ERCrossings scr, int startConnectionIndex, int startLaneIndex, int endConnectionIndex, int endLaneIndex, bool stop) { }

	// RVA: 0xD22C00 Offset: 0xD21200 VA: 0x180D22C00
	public static void OQQDCODOQD(ERCrossingPrefabs scr, ref ERLaneConnector conn, int startConnectionIndex) { }

	// RVA: 0xD25A80 Offset: 0xD24080 VA: 0x180D25A80
	public static bool OQQQQQODQD(Vector3 left, Vector3 rightStart, Vector3 rightEnd, ref float angle1, float prevAngle1, float angle2, bool flag) { }

	// RVA: 0xD1B7C0 Offset: 0xD19DC0 VA: 0x180D1B7C0
	public static Vector3 OODQQDCDCD(float distance, float angle) { }

	// RVA: 0xD21290 Offset: 0xD1F890 VA: 0x180D21290
	public static void OQDOCDCQCD(Vector3 cp, float roadWidth, ref Vector3 lStart, ref Vector3 lEnd, ref Vector3 rStart, ref Vector3 rEnd, float largestRadius) { }

	// RVA: 0xD07490 Offset: 0xD05A90 VA: 0x180D07490
	public static void GetOCOCQCDDCD(Vector3 cp, float radius, int cornerSegments, Vector3 leftPoint, Vector3 rightPoint, ref List<Vector3> leftpoints, ref List<Vector3> rightpoints, bool flag) { }

	// RVA: 0xD14510 Offset: 0xD12B10 VA: 0x180D14510
	private static void OOCCQCDQQC(List<Vector3> rightPoints1, List<Vector3> leftPoints1, List<Vector3> leftPoints2, List<Vector3> rightPoints2, ref List<Vector3> outerpoints, ref List<Vector3> innerpoints, float dist) { }

	// RVA: 0xD1C0A0 Offset: 0xD1A6A0 VA: 0x180D1C0A0
	private void OOOQOQODDD(ref float uvRatio, ref List<Vector3> priorityLeftPoints, ref List<Vector3> priorityRightPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> leftRoundingPoints, ref List<Vector3> leftRoundingPointsOther, ref List<Vector3> rightRoundingPointsOther) { }

	// RVA: 0xD17270 Offset: 0xD15870 VA: 0x180D17270
	private static bool OOCOCOCDQD(float radius, int cornerSegments, Vector3 startPoint, Vector3 endPoint, ref List<Vector3> points, ref List<Vector3> priorityPoints, float curvature, bool swapflag, bool priorityIsSingleSection, Vector3 prioritySectionDir, int leftright, bool leftRightCheck, ref int mainIndex, ref bool insertFlag) { }

	// RVA: 0xD081C0 Offset: 0xD067C0 VA: 0x180D081C0
	private static void MatchLeftRights(ref List<Vector3> leftRoundingPoints, Vector3 lStart, ref List<Vector3> rightRoundingPoints, Vector3 rStart) { }

	// RVA: 0xD14FB0 Offset: 0xD135B0 VA: 0x180D14FB0
	public static void OOCDCOQDDO(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1, ref List<Vector3> priorityPointsMain, ERConnectionSibling prioritySibling, bool isSecondary) { }

	// RVA: 0xD17130 Offset: 0xD15730 VA: 0x180D17130
	public static bool OOCOCCQDCQ(Vector3 v, List<Vector3> points, int firstIndex, int lastIndex) { }

	// RVA: 0xD1AE30 Offset: 0xD19430 VA: 0x180D1AE30
	public static void OODQCOCOQD(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1) { }

	// RVA: 0xD254F0 Offset: 0xD23AF0 VA: 0x180D254F0
	public static void OQQDQCQCDQ(List<Vector3> roundingPoints, ref List<Vector3> pointsIndents, float indent, Vector3 lp, Vector3 rp, bool leftSide) { }

	// RVA: 0xD1D380 Offset: 0xD1B980 VA: 0x180D1D380
	public static void OOQQOOOQOO(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents, Vector3 cp) { }

	// RVA: 0xD13990 Offset: 0xD11F90 VA: 0x180D13990
	public static void OOCCDOCDDC(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents) { }

	// RVA: 0xD07EC0 Offset: 0xD064C0 VA: 0x180D07EC0
	public static void MatchInnerOCOCQCDDCD(ref List<Vector3> innerArray, List<Vector3> startVecs, List<Vector3> endVecs) { }

	// RVA: 0xD0EDA0 Offset: 0xD0D3A0 VA: 0x180D0EDA0
	public static void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	// RVA: 0xD05A50 Offset: 0xD04050 VA: 0x180D05A50
	public static void ERODOCDOOCCC(List<List<Vector3>> roadVecs, List<float> shapeUVs, ref List<List<Vector2>> uvs, List<Vector3> priorityPointsMain, ref List<Vector2> priorityPointsMainUVs, Vector2 cp, float uvRatio, ERConnectionSibling sibling, bool primarySection) { }

	// RVA: 0xD0E6A0 Offset: 0xD0CCA0 VA: 0x180D0E6A0
	public static void OCQODCQDOD(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	// RVA: 0xD0BE80 Offset: 0xD0A480 VA: 0x180D0BE80
	public static void OCOQCCQCCC(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> rightRoundingPointsUV) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOCDCQQQCD(ref List<Vector3> leftRoundingPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> centerPoints, ref Vector3 cpLeft, ref Vector3 cpRight, List<Vector3> priorityRoad, float cornerRadius, float cornerSegments, Vector3 lStart, Vector3 lEnd, Vector3 rStart, Vector3 rEnd, float leftIndent, float leftIndentUVX, float rightIndent, float rightIndentUVX) { }

	// RVA: 0xD1B910 Offset: 0xD19F10 VA: 0x180D1B910
	public static void OOOQCOOQDD(List<Vector3> outerPoints, Vector3 pos, ref float uvX, float indentUVX, float indentdist, int leftright) { }

	// RVA: 0xD0B130 Offset: 0xD09730 VA: 0x180D0B130
	public static void OCOCCCCDOO(ref List<Vector3> indentPoints, List<Vector3> outerPoints, List<Vector3> priorityConnectionPoints, int leftright) { }

	// RVA: 0xD21750 Offset: 0xD1FD50 VA: 0x180D21750
	public static void OQDQCQCDQQ(ref List<Vector3> centerPoints, List<Vector3> priorityConnectionPoints) { }

	// RVA: 0xD0FDF0 Offset: 0xD0E3F0 VA: 0x180D0FDF0
	public static void ODDDOCDCQO(List<ERConnectionSibling> priorityRoads, List<ERConnectionSibling> primaryRoads) { }

	// RVA: 0xD22130 Offset: 0xD20730 VA: 0x180D22130
	public static void OQOQDQDOOO(Transform tr, ERConnectionSibling sibling, int index) { }

	// RVA: 0xD11980 Offset: 0xD0FF80 VA: 0x180D11980
	public static void ODODQCDCOD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD0EE50 Offset: 0xD0D450 VA: 0x180D0EE50
	public static void ODDCQODOCD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD20A10 Offset: 0xD1F010 VA: 0x180D20A10
	private static void OQCDQQOCOC(int curLeft, int endLeft, int curRight, int endRight, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD1BCE0 Offset: 0xD1A2E0 VA: 0x180D1BCE0
	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD08ED0 Offset: 0xD074D0 VA: 0x180D08ED0
	public static void OCDOQDDCQC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD13D40 Offset: 0xD12340 VA: 0x180D13D40
	public static void OOCCQCDDDQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD20D70 Offset: 0xD1F370 VA: 0x180D20D70
	public static void OQCQQDDDCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD08D00 Offset: 0xD07300 VA: 0x180D08D00
	public static void OCDCQDDDCC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD06F20 Offset: 0xD05520 VA: 0x180D06F20
	public static void ForkPriorityOCODCOCODQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV, List<Vector3> mainPoints, List<Vector2> mainPointsUV) { }

	// RVA: 0xD0C3F0 Offset: 0xD0A9F0 VA: 0x180D0C3F0
	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD086B0 Offset: 0xD06CB0 VA: 0x180D086B0
	private static void MergeMeshDataExt(ref List<List<int>> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs, Material mat, ref List<Material> mats) { }

	// RVA: 0xD0E200 Offset: 0xD0C800 VA: 0x180D0E200
	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD25D80 Offset: 0xD24380 VA: 0x180D25D80
	public static List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	// RVA: 0xD0C730 Offset: 0xD0AD30 VA: 0x180D0C730
	public static void OCQDDOQCOQ(QDOODOQQDQODD connection, ERConnectionSibling sibling, int index, int total) { }

	// RVA: 0xD19200 Offset: 0xD17800 VA: 0x180D19200
	public static void OOCQCOOOOO(List<ERConnectionSibling> siblings, int index) { }

	// RVA: 0xD25C60 Offset: 0xD24260 VA: 0x180D25C60
	public static bool OQQQQQQQCD(QDQDOOQQDQODD roadType) { }

	// RVA: 0xD1CEC0 Offset: 0xD1B4C0 VA: 0x180D1CEC0
	public static Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0xD05940 Offset: 0xD03F40 VA: 0x180D05940
	public static void Clear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOODDOCOOO() { }

	// RVA: 0xD1C820 Offset: 0xD1AE20 VA: 0x180D1C820
	public static void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	// RVA: 0xD219B0 Offset: 0xD1FFB0 VA: 0x180D219B0
	public static void OQOCODDDDC(int connection, QDQDOOQQDQODD roadType) { }

	// RVA: 0xD16FD0 Offset: 0xD155D0 VA: 0x180D16FD0
	public static float OOCDQCOCQO(Vector3 v1, Vector3 v2, Vector3 n) { }

	// RVA: 0xD224E0 Offset: 0xD20AE0 VA: 0x180D224E0
	public static Vector3 OQOQODOOCD(Vector3 dirPos1, Vector3 dirPos2, Vector3 currentPos, List<Vector3> vecs, int startend) { }

	// RVA: 0xD13470 Offset: 0xD11A70 VA: 0x180D13470
	public static Vector3 ODQQOCDCOC(Vector3 currentPos, List<Vector3> vecs, ref int index, int startend) { }

	// RVA: 0xD25950 Offset: 0xD23F50 VA: 0x180D25950
	public static bool OQQOCCCOCD(Vector3 p1, Vector3 p2, Vector3 v) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xD264C0 Offset: 0xD24AC0 VA: 0x180D264C0
	private static void .cctor() { }

}

