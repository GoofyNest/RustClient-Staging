public class ERCrossings : MonoBehaviour // TypeDefIndex: 7169
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ERConnectionData cdata; // 0x18
	public List<List<Vector3>> startConnectionV3; // 0x20
	public List<List<Vector3>> endConnectionV3; // 0x28
	public List<List<Vector3>> leftConnectionV3; // 0x30
	public List<List<Vector3>> rightConnectionV3; // 0x38
	public List<List<Vector2>> startConnectionUV; // 0x40
	public List<List<Vector2>> endConnectionUV; // 0x48
	public List<List<Vector2>> leftConnectionUV; // 0x50
	public List<List<Vector2>> rightConnectionUV; // 0x58
	public List<List<int>> startConnectionTris; // 0x60
	public List<List<int>> endConnectionTris; // 0x68
	public List<List<int>> leftConnectionTris; // 0x70
	public List<List<int>> rightConnectionTris; // 0x78
	public List<List<Vector3>> leftSidewalkStartV3; // 0x80
	public List<List<Vector3>> rightSidewalkStartV3; // 0x88
	public List<List<Vector3>> leftSidewalkEndV3; // 0x90
	public List<List<Vector3>> rightSidewalkEndV3; // 0x98
	public List<List<Vector2>> leftSidewalkStartUV; // 0xA0
	public List<List<Vector2>> rightSidewalkStartUV; // 0xA8
	public List<List<Vector2>> leftSidewalkEndUV; // 0xB0
	public List<List<Vector2>> rightSidewalkEndUV; // 0xB8
	public List<List<Vector3>> leftSidewalkLeftV3; // 0xC0
	public List<List<Vector3>> leftSidewalkRightV3; // 0xC8
	public List<List<Vector3>> rightSidewalkLeftV3; // 0xD0
	public List<List<Vector3>> rightSidewalkRightV3; // 0xD8
	public List<List<Vector2>> leftSidewalkLeftUV; // 0xE0
	public List<List<Vector2>> leftSidewalkRightUV; // 0xE8
	public List<List<Vector2>> rightSidewalkLeftUV; // 0xF0
	public List<List<Vector2>> rightSidewalkRightUV; // 0xF8
	public List<List<int>> leftSidewalkStartTris; // 0x100
	public List<List<int>> rightSidewalkStartTris; // 0x108
	public List<List<int>> leftSidewalkEndTris; // 0x110
	public List<List<int>> rightSidewalkEndTris; // 0x118
	public List<List<int>> leftSidewalkLeftTris; // 0x120
	public List<List<int>> leftSidewalkRightTris; // 0x128
	public List<List<int>> rightSidewalkLeftTris; // 0x130
	public List<List<int>> rightSidewalkRightTris; // 0x138
	public List<float> uvArrayFront; // 0x140
	public List<float> uvArrayBack; // 0x148
	public List<float> uvArrayLeft; // 0x150
	public List<float> uvArrayRight; // 0x158
	public List<int> OCCODQDOQO; // 0x160
	public List<int> OOQODQDOQC; // 0x168
	public List<int> OQCCQOCQDQ; // 0x170
	public List<int> OQDQOQOCQD; // 0x178
	public List<int> ODQDCCQOQD; // 0x180
	public List<int> ODOQODQODO; // 0x188
	public List<int> OOOQCQDOCD; // 0x190
	public List<int> OQCDOOCDCD; // 0x198
	public List<int> OCCODQDOQOStart; // 0x1A0
	public List<int> OOQODQDOQCStart; // 0x1A8
	public List<int> OQCCQOCQDQStart; // 0x1B0
	public List<int> OQDQOQOCQDStart; // 0x1B8
	public List<int> ODQDCCQOQDStart; // 0x1C0
	public List<int> ODOQODQODOStart; // 0x1C8
	public List<int> OOOQCQDOCDStart; // 0x1D0
	public List<int> OQCDOOCDCDStart; // 0x1D8
	public List<int> frontLeftRoadInts; // 0x1E0
	public List<int> frontRightRoadInts; // 0x1E8
	public List<int> backLeftRoadInts; // 0x1F0
	public List<int> backRightRoadInts; // 0x1F8
	public List<int> leftLeftRoadInts; // 0x200
	public List<int> leftRightRoadInts; // 0x208
	public List<int> rightLeftRoadInts; // 0x210
	public List<int> rightRightRoadInts; // 0x218
	public List<ERSideWalk> sidewalkCorners; // 0x220
	public List<float> sidewalkWidths; // 0x228
	public List<float> curbHeights; // 0x230
	public List<float> curbDepths; // 0x238
	public List<bool> beveledCurbs; // 0x240
	public List<float> beveledHeights; // 0x248
	public List<float> beveledDepths; // 0x250
	public List<bool> outerCurbs; // 0x258
	public List<bool> lockUVs; // 0x260
	public List<Material> materials; // 0x268
	public int leftStartSidewalkCornerInt; // 0x270
	public int rightStartSidewalkCornerInt; // 0x274
	public int leftEndSidewalkCornerInt; // 0x278
	public int rightEndSidewalkCornerInt; // 0x27C
	public int leftLeftSidewalkCornerInt; // 0x280
	public int rightLeftSidewalkCornerInt; // 0x284
	public int leftRightSidewalkCornerInt; // 0x288
	public int rightRightSidewalkCornerInt; // 0x28C
	public Vector3[] sidewalkControlPoints; // 0x290
	public bool[] sidewalkControlStatus; // 0x298
	public bool copySettingsFlag; // 0x2A0
	public bool generalSettingsFlag; // 0x2A1
	public bool connectionSettingsFlag; // 0x2A2
	public bool cornerSettingsFlag; // 0x2A3
	public bool sidewalkSettingsFlag; // 0x2A4
	public string[] QDOOOQOOQQQQD; // 0x2A8
	public int selectedConnection; // 0x2B0
	public float startAngle; // 0x2B4
	public bool roundedCorners; // 0x2B8
	public float roundingRadius; // 0x2BC
	public int roundingSegments; // 0x2C0
	public float innerSegmentDistance; // 0x2C4
	public bool tCrossing; // 0x2C8
	public bool tStraightBending; // 0x2C9
	public bool oldTCrossing; // 0x2CA
	public int tCrossingLeftRight; // 0x2CC
	public int oldtCrossingLeftRight; // 0x2D0
	public int geometryType; // 0x2D4
	public float resolution; // 0x2D8
	public bool includeSidewalks; // 0x2DC
	public bool defaultSidewalkEnabledStatus; // 0x2DD
	public bool planarUVs; // 0x2DE
	public float planarTiling; // 0x2E0
	public bool isSceneObject; // 0x2E4
	public int connectionHandling; // 0x2E8
	public List<QDQDOOQQDQODD> roadTypesDynamic; // 0x2F0
	public int frontRoadTypeInt; // 0x2F8
	public double frontRoadTypeID; // 0x300
	public float frontRoadWidth; // 0x308
	public Material frontMaterial; // 0x310
	public Material frontRoadMaterial; // 0x318
	public float frontRoadUVTiling; // 0x320
	public int backRoadTypeInt; // 0x324
	public double backRoadTypeID; // 0x328
	public float backRoadWidth; // 0x330
	public Material backMaterial; // 0x338
	public Material backRoadMaterial; // 0x340
	public float backRoadUVTiling; // 0x348
	public int leftRoadTypeInt; // 0x34C
	public double leftRoadTypeID; // 0x350
	public float leftRoadWidth; // 0x358
	public Material leftMaterial; // 0x360
	public Material leftRoadMaterial; // 0x368
	public float leftRoadUVTiling; // 0x370
	public int rightRoadTypeInt; // 0x374
	public double rightRoadTypeID; // 0x378
	public float rightRoadWidth; // 0x380
	public Material rightMaterial; // 0x388
	public Material rightRoadMaterial; // 0x390
	public float rightRoadUVTiling; // 0x398
	public int selectedRoadType; // 0x39C
	public bool uniformCornersFlag; // 0x3A0
	public int selectedCorner; // 0x3A4
	public int selectedCornerPreset; // 0x3A8
	public string cornerPresetName; // 0x3B0
	public int selectedSidewalkPreset; // 0x3B8
	public string sidewalkPresetName; // 0x3C0
	public int OCOQDODDQQCorner; // 0x3C8
	public Vector3 leftBottom; // 0x3CC
	public Vector3 rightBottom; // 0x3D8
	public Vector3 leftTop; // 0x3E4
	public Vector3 rightTop; // 0x3F0
	public Vector3 frontCenter; // 0x3FC
	public Vector3 backCenter; // 0x408
	public Vector3 leftCenter; // 0x414
	public Vector3 rightCenter; // 0x420
	public int prefabId; // 0x42C
	public ERCrossingPrefabs prefabScript; // 0x430
	public QDOODOQQDQODD connectionElement; // 0x438
	public int crossingOuterElement; // 0x440
	public string crossingName; // 0x448
	public bool guiChanged; // 0x450
	public bool includeSidewalkChangeFlag; // 0x451
	public List<Vector3> debugVecs; // 0x458
	public List<NormalPairs> normalPairs; // 0x460
	public float maxConnectionWidth; // 0x468
	public int crossingStructure; // 0x46C
	public ERModularBase baseScript; // 0x470
	public List<ERConnectionSibling> siblings1; // 0x478
	public List<ERConnectionSibling> prioritySiblings; // 0x480
	public Vector3 crossPointCenter; // 0x488
	public List<Vector3> edges; // 0x498
	public ERConnectionSibling primaryPriorityConnection; // 0x4A0
	public ERConnectionSibling secondPriorityConnection; // 0x4A8
	public bool adjustMainRadiusFlag; // 0x4B0
	public bool disableAdjustMainRadiusFlag; // 0x4B1
	public bool showScaleSliderAtPrimary; // 0x4B2
	public bool showScaleSliderAtSecondary; // 0x4B3
	public ERRoadWayType priorityWayType; // 0x4B4
	public float leftIntOffset; // 0x4B8
	public float rightIntOffset; // 0x4BC
	public bool isUpdating; // 0x4C0
	public int serializeTest; // 0x4C4
	public int updateQueue; // 0x4C8

	// Methods

	// RVA: 0xB95460 Offset: 0xB93A60 VA: 0x180B95460
	public void Refresh() { }

	// RVA: 0xB945C0 Offset: 0xB92BC0 VA: 0x180B945C0
	public void ODOCCDCQOC() { }

	// RVA: 0xB95470 Offset: 0xB93A70 VA: 0x180B95470
	public Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2, bool update) { }

	// RVA: 0xB980B0 Offset: 0xB966B0 VA: 0x180B980B0
	public void UpdateAllConnectionAngles() { }

	// RVA: 0xB95460 Offset: 0xB93A60 VA: 0x180B95460
	public void OOOCDCQQCO() { }

	// RVA: 0xB986B0 Offset: 0xB96CB0 VA: 0x180B986B0
	public bool UpdateToRoadType(QDQDOOQQDQODD sourcePreset, ref List<ERModularRoad> updatedRoads) { }

	// RVA: 0xB97DA0 Offset: 0xB963A0 VA: 0x180B97DA0
	public bool RoadIsUpdated(ERModularRoad rd, ref List<ERModularRoad> updatedRoads) { }

	// RVA: 0xB97F40 Offset: 0xB96540 VA: 0x180B97F40
	public int SetRoadTypeInt(double id) { }

	// RVA: 0xB8BB40 Offset: 0xB8A140 VA: 0x180B8BB40
	public void OCQCQODOQC(ERCrossings source, bool refreshFlag) { }

	// RVA: 0xB95E50 Offset: 0xB94450 VA: 0x180B95E50
	public void OQCQCOOCDD() { }

	// RVA: 0xB8D730 Offset: 0xB8BD30 VA: 0x180B8D730
	public void OCQDQODOQD(bool sidewalkSceneHandleFlag, bool rebuildRoads) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OQCQDQDCOD() { }

	// RVA: 0xB91250 Offset: 0xB8F850 VA: 0x180B91250
	public void ODDDOCDCQO(bool rebuildRoads) { }

	// RVA: 0xB96540 Offset: 0xB94B40 VA: 0x180B96540
	public void OQCQQCQDCQ(int el, List<List<int>> trIntArray, List<float> uvArray, List<List<int>> leftSidewalkIntArray, List<List<int>> rightSidewalkIntArray, int startend) { }

	// RVA: 0xB94950 Offset: 0xB92F50 VA: 0x180B94950
	public void ODQCODQDDQ(int el, Material roadMaterial, int leftCorner, int rightCorner, int leftVecCount, int rightVecCount) { }

	// RVA: 0xB8B390 Offset: 0xB89990 VA: 0x180B8B390
	public void OCDDOCDDOQ(List<Vector3> meshVecs, List<int> connectionVecInts, ref List<Vector2> roadShapeVecs, List<List<Vector3>> vecArrays, List<List<Vector3>> leftSidewalkArray, List<List<Vector3>> rightSidewalkArray, int connectionElement, int startend) { }

	// RVA: 0xB94740 Offset: 0xB92D40 VA: 0x180B94740
	public static void ODOODQDCCQ(List<Vector3> sourceVecs, ref List<Vector2> roadShapeVecs, Vector3 centerPoint, Vector3 startPoint, float halfWayDistance) { }

	// RVA: 0xB8A680 Offset: 0xB88C80 VA: 0x180B8A680
	public static string GetRoadShapeVecString(List<Vector2> vecs, List<Vector2> lvecs, List<Vector2> rvecs, ref int matchCount) { }

	// RVA: 0xB8EB20 Offset: 0xB8D120 VA: 0x180B8EB20
	public void ODCCCQCQOO() { }

	// RVA: 0xB903B0 Offset: 0xB8E9B0 VA: 0x180B903B0
	public void ODCDCDDOCC(List<SidewalkPresetClass> sidewalkPresets, int el) { }

	// RVA: 0xB8AAB0 Offset: 0xB890B0 VA: 0x180B8AAB0
	public void OCCODQDOCO() { }

	// RVA: 0xB971C0 Offset: 0xB957C0 VA: 0x180B971C0
	public void OQDOQDQQQQ(int el) { }

	// RVA: 0xB95010 Offset: 0xB93610 VA: 0x180B95010
	public void OODOQQQQCO() { }

	// RVA: 0xB95BF0 Offset: 0xB941F0 VA: 0x180B95BF0
	public void OQCOOQQOOD() { }

	// RVA: 0xB96CD0 Offset: 0xB952D0 VA: 0x180B96CD0
	public bool OQDOOCDOCD(ERModularRoad road, float angle) { }

	// RVA: 0xB995F0 Offset: 0xB97BF0 VA: 0x180B995F0
	public void .ctor() { }

}

private sealed class ERCrossings.ᙃ // TypeDefIndex: 7170
{	// Fields
	public static readonly ERCrossings.ᙃ <>9; // 0x0
	public static Comparison<ERConnectionSibling> <>9__203_0; // 0x8

	// Methods

	// RVA: 0x9CF720 Offset: 0x9CDD20 VA: 0x1809CF720
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9CF6F0 Offset: 0x9CDCF0 VA: 0x1809CF6F0
	internal int <OQDOOCDOCD>b__203_0(ERConnectionSibling x, ERConnectionSibling y) { }

}

