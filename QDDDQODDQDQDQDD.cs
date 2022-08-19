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

	// RVA: 0xD22730 Offset: 0xD20D30 VA: 0x180D22730
	public static List<QDQDOOQQDQODD> OQQCDQOQCD(List<QDQDOOQQDQODD> roadTypes, bool all) { }

	// RVA: 0xD217D0 Offset: 0xD1FDD0 VA: 0x180D217D0
	public static void OQODQQQCOC(ERCrossings scr) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ODODCOOQDO() { }

	// RVA: 0xD0B5D0 Offset: 0xD09BD0 VA: 0x180D0B5D0
	public static bool OCODDQQOCQ(List<ERConnectionSibling> siblings, int thisSibling, int OtherSibling, int startLane) { }

	// RVA: 0xD1D4F0 Offset: 0xD1BAF0 VA: 0x180D1D4F0
	public static void OQCDQDQOOO(bool hasLaneControlData) { }

	// RVA: 0xD0B4F0 Offset: 0xD09AF0 VA: 0x180D0B4F0
	public static ERLaneConnector OCODCDQQOQ(ERCrossings scr, int startConnectionIndex, int startLaneIndex, int endConnectionIndex, int endLaneIndex, bool stop) { }

	// RVA: 0xD22940 Offset: 0xD20F40 VA: 0x180D22940
	public static void OQQDCODOQD(ERCrossingPrefabs scr, ref ERLaneConnector conn, int startConnectionIndex) { }

	// RVA: 0xD257C0 Offset: 0xD23DC0 VA: 0x180D257C0
	public static bool OQQQQQODQD(Vector3 left, Vector3 rightStart, Vector3 rightEnd, ref float angle1, float prevAngle1, float angle2, bool flag) { }

	// RVA: 0xD1B500 Offset: 0xD19B00 VA: 0x180D1B500
	public static Vector3 OODQQDCDCD(float distance, float angle) { }

	// RVA: 0xD20FD0 Offset: 0xD1F5D0 VA: 0x180D20FD0
	public static void OQDOCDCQCD(Vector3 cp, float roadWidth, ref Vector3 lStart, ref Vector3 lEnd, ref Vector3 rStart, ref Vector3 rEnd, float largestRadius) { }

	// RVA: 0xD071D0 Offset: 0xD057D0 VA: 0x180D071D0
	public static void GetOCOCQCDDCD(Vector3 cp, float radius, int cornerSegments, Vector3 leftPoint, Vector3 rightPoint, ref List<Vector3> leftpoints, ref List<Vector3> rightpoints, bool flag) { }

	// RVA: 0xD14250 Offset: 0xD12850 VA: 0x180D14250
	private static void OOCCQCDQQC(List<Vector3> rightPoints1, List<Vector3> leftPoints1, List<Vector3> leftPoints2, List<Vector3> rightPoints2, ref List<Vector3> outerpoints, ref List<Vector3> innerpoints, float dist) { }

	// RVA: 0xD1BDE0 Offset: 0xD1A3E0 VA: 0x180D1BDE0
	private void OOOQOQODDD(ref float uvRatio, ref List<Vector3> priorityLeftPoints, ref List<Vector3> priorityRightPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> leftRoundingPoints, ref List<Vector3> leftRoundingPointsOther, ref List<Vector3> rightRoundingPointsOther) { }

	// RVA: 0xD16FB0 Offset: 0xD155B0 VA: 0x180D16FB0
	private static bool OOCOCOCDQD(float radius, int cornerSegments, Vector3 startPoint, Vector3 endPoint, ref List<Vector3> points, ref List<Vector3> priorityPoints, float curvature, bool swapflag, bool priorityIsSingleSection, Vector3 prioritySectionDir, int leftright, bool leftRightCheck, ref int mainIndex, ref bool insertFlag) { }

	// RVA: 0xD07F00 Offset: 0xD06500 VA: 0x180D07F00
	private static void MatchLeftRights(ref List<Vector3> leftRoundingPoints, Vector3 lStart, ref List<Vector3> rightRoundingPoints, Vector3 rStart) { }

	// RVA: 0xD14CF0 Offset: 0xD132F0 VA: 0x180D14CF0
	public static void OOCDCOQDDO(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1, ref List<Vector3> priorityPointsMain, ERConnectionSibling prioritySibling, bool isSecondary) { }

	// RVA: 0xD16E70 Offset: 0xD15470 VA: 0x180D16E70
	public static bool OOCOCCQDCQ(Vector3 v, List<Vector3> points, int firstIndex, int lastIndex) { }

	// RVA: 0xD1AB70 Offset: 0xD19170 VA: 0x180D1AB70
	public static void OODQCOCOQD(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1) { }

	// RVA: 0xD25230 Offset: 0xD23830 VA: 0x180D25230
	public static void OQQDQCQCDQ(List<Vector3> roundingPoints, ref List<Vector3> pointsIndents, float indent, Vector3 lp, Vector3 rp, bool leftSide) { }

	// RVA: 0xD1D0C0 Offset: 0xD1B6C0 VA: 0x180D1D0C0
	public static void OOQQOOOQOO(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents, Vector3 cp) { }

	// RVA: 0xD136D0 Offset: 0xD11CD0 VA: 0x180D136D0
	public static void OOCCDOCDDC(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents) { }

	// RVA: 0xD07C00 Offset: 0xD06200 VA: 0x180D07C00
	public static void MatchInnerOCOCQCDDCD(ref List<Vector3> innerArray, List<Vector3> startVecs, List<Vector3> endVecs) { }

	// RVA: 0xD0EAE0 Offset: 0xD0D0E0 VA: 0x180D0EAE0
	public static void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	// RVA: 0xD05790 Offset: 0xD03D90 VA: 0x180D05790
	public static void ERODOCDOOCCC(List<List<Vector3>> roadVecs, List<float> shapeUVs, ref List<List<Vector2>> uvs, List<Vector3> priorityPointsMain, ref List<Vector2> priorityPointsMainUVs, Vector2 cp, float uvRatio, ERConnectionSibling sibling, bool primarySection) { }

	// RVA: 0xD0E3E0 Offset: 0xD0C9E0 VA: 0x180D0E3E0
	public static void OCQODCQDOD(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	// RVA: 0xD0BBC0 Offset: 0xD0A1C0 VA: 0x180D0BBC0
	public static void OCOQCCQCCC(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> rightRoundingPointsUV) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOCDCQQQCD(ref List<Vector3> leftRoundingPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> centerPoints, ref Vector3 cpLeft, ref Vector3 cpRight, List<Vector3> priorityRoad, float cornerRadius, float cornerSegments, Vector3 lStart, Vector3 lEnd, Vector3 rStart, Vector3 rEnd, float leftIndent, float leftIndentUVX, float rightIndent, float rightIndentUVX) { }

	// RVA: 0xD1B650 Offset: 0xD19C50 VA: 0x180D1B650
	public static void OOOQCOOQDD(List<Vector3> outerPoints, Vector3 pos, ref float uvX, float indentUVX, float indentdist, int leftright) { }

	// RVA: 0xD0AE70 Offset: 0xD09470 VA: 0x180D0AE70
	public static void OCOCCCCDOO(ref List<Vector3> indentPoints, List<Vector3> outerPoints, List<Vector3> priorityConnectionPoints, int leftright) { }

	// RVA: 0xD21490 Offset: 0xD1FA90 VA: 0x180D21490
	public static void OQDQCQCDQQ(ref List<Vector3> centerPoints, List<Vector3> priorityConnectionPoints) { }

	// RVA: 0xD0FB30 Offset: 0xD0E130 VA: 0x180D0FB30
	public static void ODDDOCDCQO(List<ERConnectionSibling> priorityRoads, List<ERConnectionSibling> primaryRoads) { }

	// RVA: 0xD21E70 Offset: 0xD20470 VA: 0x180D21E70
	public static void OQOQDQDOOO(Transform tr, ERConnectionSibling sibling, int index) { }

	// RVA: 0xD116C0 Offset: 0xD0FCC0 VA: 0x180D116C0
	public static void ODODQCDCOD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD0EB90 Offset: 0xD0D190 VA: 0x180D0EB90
	public static void ODDCQODOCD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD20750 Offset: 0xD1ED50 VA: 0x180D20750
	private static void OQCDQQOCOC(int curLeft, int endLeft, int curRight, int endRight, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD1BA20 Offset: 0xD1A020 VA: 0x180D1BA20
	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD08C10 Offset: 0xD07210 VA: 0x180D08C10
	public static void OCDOQDDCQC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD13A80 Offset: 0xD12080 VA: 0x180D13A80
	public static void OOCCQCDDDQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD20AB0 Offset: 0xD1F0B0 VA: 0x180D20AB0
	public static void OQCQQDDDCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD08A40 Offset: 0xD07040 VA: 0x180D08A40
	public static void OCDCQDDDCC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD06C60 Offset: 0xD05260 VA: 0x180D06C60
	public static void ForkPriorityOCODCOCODQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV, List<Vector3> mainPoints, List<Vector2> mainPointsUV) { }

	// RVA: 0xD0C130 Offset: 0xD0A730 VA: 0x180D0C130
	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD083F0 Offset: 0xD069F0 VA: 0x180D083F0
	private static void MergeMeshDataExt(ref List<List<int>> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs, Material mat, ref List<Material> mats) { }

	// RVA: 0xD0DF40 Offset: 0xD0C540 VA: 0x180D0DF40
	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD25AC0 Offset: 0xD240C0 VA: 0x180D25AC0
	public static List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	// RVA: 0xD0C470 Offset: 0xD0AA70 VA: 0x180D0C470
	public static void OCQDDOQCOQ(QDOODOQQDQODD connection, ERConnectionSibling sibling, int index, int total) { }

	// RVA: 0xD18F40 Offset: 0xD17540 VA: 0x180D18F40
	public static void OOCQCOOOOO(List<ERConnectionSibling> siblings, int index) { }

	// RVA: 0xD259A0 Offset: 0xD23FA0 VA: 0x180D259A0
	public static bool OQQQQQQQCD(QDQDOOQQDQODD roadType) { }

	// RVA: 0xD1CC00 Offset: 0xD1B200 VA: 0x180D1CC00
	public static Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0xD05680 Offset: 0xD03C80 VA: 0x180D05680
	public static void Clear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void OOODDOCOOO() { }

	// RVA: 0xD1C560 Offset: 0xD1AB60 VA: 0x180D1C560
	public static void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	// RVA: 0xD216F0 Offset: 0xD1FCF0 VA: 0x180D216F0
	public static void OQOCODDDDC(int connection, QDQDOOQQDQODD roadType) { }

	// RVA: 0xD16D10 Offset: 0xD15310 VA: 0x180D16D10
	public static float OOCDQCOCQO(Vector3 v1, Vector3 v2, Vector3 n) { }

	// RVA: 0xD22220 Offset: 0xD20820 VA: 0x180D22220
	public static Vector3 OQOQODOOCD(Vector3 dirPos1, Vector3 dirPos2, Vector3 currentPos, List<Vector3> vecs, int startend) { }

	// RVA: 0xD131B0 Offset: 0xD117B0 VA: 0x180D131B0
	public static Vector3 ODQQOCDCOC(Vector3 currentPos, List<Vector3> vecs, ref int index, int startend) { }

	// RVA: 0xD25690 Offset: 0xD23C90 VA: 0x180D25690
	public static bool OQQOCCCOCD(Vector3 p1, Vector3 p2, Vector3 v) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xD26200 Offset: 0xD24800 VA: 0x180D26200
	private static void .cctor() { }

}

