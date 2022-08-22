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

	// RVA: 0xD22E90 Offset: 0xD21490 VA: 0x180D22E90
	public static List<QDQDOOQQDQODD> OQQCDQOQCD(List<QDQDOOQQDQODD> roadTypes, bool all) { }

	// RVA: 0xD21F30 Offset: 0xD20530 VA: 0x180D21F30
	public static void OQODQQQCOC(ERCrossings scr) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ODODCOOQDO() { }

	// RVA: 0xD0BD30 Offset: 0xD0A330 VA: 0x180D0BD30
	public static bool OCODDQQOCQ(List<ERConnectionSibling> siblings, int thisSibling, int OtherSibling, int startLane) { }

	// RVA: 0xD1DC50 Offset: 0xD1C250 VA: 0x180D1DC50
	public static void OQCDQDQOOO(bool hasLaneControlData) { }

	// RVA: 0xD0BC50 Offset: 0xD0A250 VA: 0x180D0BC50
	public static ERLaneConnector OCODCDQQOQ(ERCrossings scr, int startConnectionIndex, int startLaneIndex, int endConnectionIndex, int endLaneIndex, bool stop) { }

	// RVA: 0xD230A0 Offset: 0xD216A0 VA: 0x180D230A0
	public static void OQQDCODOQD(ERCrossingPrefabs scr, ref ERLaneConnector conn, int startConnectionIndex) { }

	// RVA: 0xD25F20 Offset: 0xD24520 VA: 0x180D25F20
	public static bool OQQQQQODQD(Vector3 left, Vector3 rightStart, Vector3 rightEnd, ref float angle1, float prevAngle1, float angle2, bool flag) { }

	// RVA: 0xD1BC60 Offset: 0xD1A260 VA: 0x180D1BC60
	public static Vector3 OODQQDCDCD(float distance, float angle) { }

	// RVA: 0xD21730 Offset: 0xD1FD30 VA: 0x180D21730
	public static void OQDOCDCQCD(Vector3 cp, float roadWidth, ref Vector3 lStart, ref Vector3 lEnd, ref Vector3 rStart, ref Vector3 rEnd, float largestRadius) { }

	// RVA: 0xD07930 Offset: 0xD05F30 VA: 0x180D07930
	public static void GetOCOCQCDDCD(Vector3 cp, float radius, int cornerSegments, Vector3 leftPoint, Vector3 rightPoint, ref List<Vector3> leftpoints, ref List<Vector3> rightpoints, bool flag) { }

	// RVA: 0xD149B0 Offset: 0xD12FB0 VA: 0x180D149B0
	private static void OOCCQCDQQC(List<Vector3> rightPoints1, List<Vector3> leftPoints1, List<Vector3> leftPoints2, List<Vector3> rightPoints2, ref List<Vector3> outerpoints, ref List<Vector3> innerpoints, float dist) { }

	// RVA: 0xD1C540 Offset: 0xD1AB40 VA: 0x180D1C540
	private void OOOQOQODDD(ref float uvRatio, ref List<Vector3> priorityLeftPoints, ref List<Vector3> priorityRightPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> leftRoundingPoints, ref List<Vector3> leftRoundingPointsOther, ref List<Vector3> rightRoundingPointsOther) { }

	// RVA: 0xD17710 Offset: 0xD15D10 VA: 0x180D17710
	private static bool OOCOCOCDQD(float radius, int cornerSegments, Vector3 startPoint, Vector3 endPoint, ref List<Vector3> points, ref List<Vector3> priorityPoints, float curvature, bool swapflag, bool priorityIsSingleSection, Vector3 prioritySectionDir, int leftright, bool leftRightCheck, ref int mainIndex, ref bool insertFlag) { }

	// RVA: 0xD08660 Offset: 0xD06C60 VA: 0x180D08660
	private static void MatchLeftRights(ref List<Vector3> leftRoundingPoints, Vector3 lStart, ref List<Vector3> rightRoundingPoints, Vector3 rStart) { }

	// RVA: 0xD15450 Offset: 0xD13A50 VA: 0x180D15450
	public static void OOCDCOQDDO(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1, ref List<Vector3> priorityPointsMain, ERConnectionSibling prioritySibling, bool isSecondary) { }

	// RVA: 0xD175D0 Offset: 0xD15BD0 VA: 0x180D175D0
	public static bool OOCOCCQDCQ(Vector3 v, List<Vector3> points, int firstIndex, int lastIndex) { }

	// RVA: 0xD1B2D0 Offset: 0xD198D0 VA: 0x180D1B2D0
	public static void OODQCOCOQD(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1) { }

	// RVA: 0xD25990 Offset: 0xD23F90 VA: 0x180D25990
	public static void OQQDQCQCDQ(List<Vector3> roundingPoints, ref List<Vector3> pointsIndents, float indent, Vector3 lp, Vector3 rp, bool leftSide) { }

	// RVA: 0xD1D820 Offset: 0xD1BE20 VA: 0x180D1D820
	public static void OOQQOOOQOO(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents, Vector3 cp) { }

	// RVA: 0xD13E30 Offset: 0xD12430 VA: 0x180D13E30
	public static void OOCCDOCDDC(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents) { }

	// RVA: 0xD08360 Offset: 0xD06960 VA: 0x180D08360
	public static void MatchInnerOCOCQCDDCD(ref List<Vector3> innerArray, List<Vector3> startVecs, List<Vector3> endVecs) { }

	// RVA: 0xD0F240 Offset: 0xD0D840 VA: 0x180D0F240
	public static void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	// RVA: 0xD05EF0 Offset: 0xD044F0 VA: 0x180D05EF0
	public static void ERODOCDOOCCC(List<List<Vector3>> roadVecs, List<float> shapeUVs, ref List<List<Vector2>> uvs, List<Vector3> priorityPointsMain, ref List<Vector2> priorityPointsMainUVs, Vector2 cp, float uvRatio, ERConnectionSibling sibling, bool primarySection) { }

	// RVA: 0xD0EB40 Offset: 0xD0D140 VA: 0x180D0EB40
	public static void OCQODCQDOD(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	// RVA: 0xD0C320 Offset: 0xD0A920 VA: 0x180D0C320
	public static void OCOQCCQCCC(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> rightRoundingPointsUV) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOCDCQQQCD(ref List<Vector3> leftRoundingPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> centerPoints, ref Vector3 cpLeft, ref Vector3 cpRight, List<Vector3> priorityRoad, float cornerRadius, float cornerSegments, Vector3 lStart, Vector3 lEnd, Vector3 rStart, Vector3 rEnd, float leftIndent, float leftIndentUVX, float rightIndent, float rightIndentUVX) { }

	// RVA: 0xD1BDB0 Offset: 0xD1A3B0 VA: 0x180D1BDB0
	public static void OOOQCOOQDD(List<Vector3> outerPoints, Vector3 pos, ref float uvX, float indentUVX, float indentdist, int leftright) { }

	// RVA: 0xD0B5D0 Offset: 0xD09BD0 VA: 0x180D0B5D0
	public static void OCOCCCCDOO(ref List<Vector3> indentPoints, List<Vector3> outerPoints, List<Vector3> priorityConnectionPoints, int leftright) { }

	// RVA: 0xD21BF0 Offset: 0xD201F0 VA: 0x180D21BF0
	public static void OQDQCQCDQQ(ref List<Vector3> centerPoints, List<Vector3> priorityConnectionPoints) { }

	// RVA: 0xD10290 Offset: 0xD0E890 VA: 0x180D10290
	public static void ODDDOCDCQO(List<ERConnectionSibling> priorityRoads, List<ERConnectionSibling> primaryRoads) { }

	// RVA: 0xD225D0 Offset: 0xD20BD0 VA: 0x180D225D0
	public static void OQOQDQDOOO(Transform tr, ERConnectionSibling sibling, int index) { }

	// RVA: 0xD11E20 Offset: 0xD10420 VA: 0x180D11E20
	public static void ODODQCDCOD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD0F2F0 Offset: 0xD0D8F0 VA: 0x180D0F2F0
	public static void ODDCQODOCD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD20EB0 Offset: 0xD1F4B0 VA: 0x180D20EB0
	private static void OQCDQQOCOC(int curLeft, int endLeft, int curRight, int endRight, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD1C180 Offset: 0xD1A780 VA: 0x180D1C180
	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD09370 Offset: 0xD07970 VA: 0x180D09370
	public static void OCDOQDDCQC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD141E0 Offset: 0xD127E0 VA: 0x180D141E0
	public static void OOCCQCDDDQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD21210 Offset: 0xD1F810 VA: 0x180D21210
	public static void OQCQQDDDCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD091A0 Offset: 0xD077A0 VA: 0x180D091A0
	public static void OCDCQDDDCC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD073C0 Offset: 0xD059C0 VA: 0x180D073C0
	public static void ForkPriorityOCODCOCODQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV, List<Vector3> mainPoints, List<Vector2> mainPointsUV) { }

	// RVA: 0xD0C890 Offset: 0xD0AE90 VA: 0x180D0C890
	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD08B50 Offset: 0xD07150 VA: 0x180D08B50
	private static void MergeMeshDataExt(ref List<List<int>> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs, Material mat, ref List<Material> mats) { }

	// RVA: 0xD0E6A0 Offset: 0xD0CCA0 VA: 0x180D0E6A0
	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD26220 Offset: 0xD24820 VA: 0x180D26220
	public static List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	// RVA: 0xD0CBD0 Offset: 0xD0B1D0 VA: 0x180D0CBD0
	public static void OCQDDOQCOQ(QDOODOQQDQODD connection, ERConnectionSibling sibling, int index, int total) { }

	// RVA: 0xD196A0 Offset: 0xD17CA0 VA: 0x180D196A0
	public static void OOCQCOOOOO(List<ERConnectionSibling> siblings, int index) { }

	// RVA: 0xD26100 Offset: 0xD24700 VA: 0x180D26100
	public static bool OQQQQQQQCD(QDQDOOQQDQODD roadType) { }

	// RVA: 0xD1D360 Offset: 0xD1B960 VA: 0x180D1D360
	public static Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0xD05DE0 Offset: 0xD043E0 VA: 0x180D05DE0
	public static void Clear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOODDOCOOO() { }

	// RVA: 0xD1CCC0 Offset: 0xD1B2C0 VA: 0x180D1CCC0
	public static void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	// RVA: 0xD21E50 Offset: 0xD20450 VA: 0x180D21E50
	public static void OQOCODDDDC(int connection, QDQDOOQQDQODD roadType) { }

	// RVA: 0xD17470 Offset: 0xD15A70 VA: 0x180D17470
	public static float OOCDQCOCQO(Vector3 v1, Vector3 v2, Vector3 n) { }

	// RVA: 0xD22980 Offset: 0xD20F80 VA: 0x180D22980
	public static Vector3 OQOQODOOCD(Vector3 dirPos1, Vector3 dirPos2, Vector3 currentPos, List<Vector3> vecs, int startend) { }

	// RVA: 0xD13910 Offset: 0xD11F10 VA: 0x180D13910
	public static Vector3 ODQQOCDCOC(Vector3 currentPos, List<Vector3> vecs, ref int index, int startend) { }

	// RVA: 0xD25DF0 Offset: 0xD243F0 VA: 0x180D25DF0
	public static bool OQQOCCCOCD(Vector3 p1, Vector3 p2, Vector3 v) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xD26960 Offset: 0xD24F60 VA: 0x180D26960
	private static void .cctor() { }

}

