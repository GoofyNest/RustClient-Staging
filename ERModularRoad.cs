public class ERModularRoad : MonoBehaviour // TypeDefIndex: 7178
{	// Fields
	public ERModularBase baseScript; // 0x18
	public string roadName; // 0x20
	public bool locked; // 0x28
	public double roadType; // 0x30
	public QDQDOOQQDQODD rt; // 0x38
	public int defaultControlType; // 0x40
	public bool isCustomRoadSet; // 0x44
	public bool isCustomRoad; // 0x45
	public List<ERMarker> markers; // 0x48
	public List<ERMarker> tmpMarkers; // 0x50
	public List<ERMarkerExt> markersExt; // 0x58
	public List<ERMarkerExt> tmpMarkersExt; // 0x60
	public List<float> tValues; // 0x68
	public float roadWidth; // 0x70
	public float faceDistance; // 0x74
	public float angleTreshold; // 0x78
	public bool resolutionFlag; // 0x7C
	public bool angleThresholdFlag; // 0x7D
	public bool closedTrack; // 0x7E
	public float minNodeDistance; // 0x80
	public int nodeWithinRange; // 0x84
	public float uvTiling; // 0x88
	public bool planarUVs; // 0x8C
	public bool flipNormals; // 0x8D
	public int defaultLeftSidewalk; // 0x90
	public int defaultRightSidewalk; // 0x94
	public bool leftSidewalkActive; // 0x98
	public bool rightSidewalkActive; // 0x99
	public List<ERSideWalkInstance> leftSidewalks; // 0xA0
	public List<ERSideWalkInstance> rightSidewalks; // 0xA8
	public List<OQQCCQCDQQ> exitRoads; // 0xB0
	public int selectedExit; // 0xB8
	public bool randomnessFlag; // 0xBC
	public bool randomnessMarkerFlag; // 0xBD
	public float randomYPosition; // 0xC0
	public float randomMinYPosition; // 0xC4
	public float randomMaxYPosition; // 0xC8
	public float minRandomYPositionDistance; // 0xCC
	public float maxRandomYPositionDistance; // 0xD0
	public float randomMinRotation; // 0xD4
	public float randomMaxRotation; // 0xD8
	public float minRandomRotationDistance; // 0xDC
	public float maxRandomRotationDistance; // 0xE0
	public bool vegetationStudioMaskLineActive; // 0xE4
	public float vegetationStudioGrassPerimeter; // 0xE8
	public float vegetationStudioPlantPerimeter; // 0xEC
	public float vegetationStudioTreePerimeter; // 0xF0
	public float vegetationStudioObjectPerimeter; // 0xF4
	public float vegetationStudioLargeObjectPerimeter; // 0xF8
	public bool vegetationStudioBiomeMaskActive; // 0xFC
	public float vegetationStudioBiomeMaskDistance; // 0x100
	public float vegetationStudioBiomeMaskBlendDistance; // 0x104
	public float vegetationStudioBiomeMaskNoiseScale; // 0x108
	public int vertsStats; // 0x10C
	public int trisStats; // 0x110
	public float indent; // 0x114
	public float surrounding; // 0x118
	public bool followTerrainContours; // 0x11C
	public float terrainContoursOffset; // 0x120
	public List<Vector2> roadShape; // 0x128
	public List<int> roadShapeIntsStart; // 0x130
	public List<int> roadShapeIntsEnd; // 0x138
	public List<int> roadShapeIntsStartFull; // 0x140
	public List<int> roadShapeIntsEndFull; // 0x148
	public string roadShapeString; // 0x150
	public string roadShapeReversedString; // 0x158
	public int roadShapeMatchCount; // 0x160
	public int geoReversed; // 0x164
	public int roadShapeCols; // 0x168
	public bool flipRoadUVs; // 0x16C
	public int subSegments; // 0x170
	public List<float> nodeDistance; // 0x178
	public List<float> roadShapeUVs; // 0x180
	public List<float> roadShapeUVs2; // 0x188
	public List<bool> doConnectionTri; // 0x190
	public List<float> randomRotations; // 0x198
	public List<bool> hardEdge; // 0x1A0
	public List<int> roadShapeMaterialInts; // 0x1A8
	public int subMeshCount; // 0x1B0
	public List<int> roadShapeMaterialIntCounts; // 0x1B8
	public List<Vector3> controlPoints; // 0x1C0
	public List<Vector3> splinePoints; // 0x1C8
	public List<float> distances; // 0x1D0
	public List<int> markerInts; // 0x1D8
	public List<Vector3> insertSplinePoints; // 0x1E0
	public List<Vector3> soSplinePoints; // 0x1E8
	public List<Vector3> soSplinePointsLeft; // 0x1F0
	public List<Vector3> soSplinePointsRight; // 0x1F8
	public List<Vector3> soSplinePointsLeftClamped; // 0x200
	public List<Vector3> soSplinePointsRightClamped; // 0x208
	public List<float> OQCOCCQCCD; // 0x210
	public List<float> OQQOODQCCC; // 0x218
	public List<float> bendAngles; // 0x220
	public List<Vector3> meshVecs; // 0x228
	public List<Vector2> meshUVs; // 0x230
	public List<Vector2> meshUVs2; // 0x238
	public List<List<int>> tris; // 0x240
	public List<Vector3> surfaceMeshVecs; // 0x248
	public List<Vector3> leftIndentVecs; // 0x250
	public List<Vector3> rightIndentVecs; // 0x258
	public List<Vector3> middleIndentVecs; // 0x260
	public List<Vector3> leftSurroundingVecs; // 0x268
	public List<Vector3> rightSurroundingVecs; // 0x270
	public List<Vector3> leftIndentVecsSV; // 0x278
	public List<Vector3> rightIndentVecsSV; // 0x280
	public List<bool> bridgeElement; // 0x288
	public List<Vector3> vecsBelowTerrain; // 0x290
	public List<Vector3> treeVecs; // 0x298
	public List<Vector3> detailVecs; // 0x2A0
	public List<int> vegetationTris; // 0x2A8
	public List<bool> doLeftSurrounding; // 0x2B0
	public List<bool> doRightSurrounding; // 0x2B8
	public float totalDistance; // 0x2C0
	public List<int> nodeSplinePoint; // 0x2C8
	public string totalDistanceString; // 0x2D0
	public ERCrossingPrefabs startPrefabScript; // 0x2D8
	public ERCrossingPrefabs endPrefabScript; // 0x2E0
	public int startConnectionSegment; // 0x2E8
	public bool startConnectionFlag; // 0x2EC
	public int endConnectionSegment; // 0x2F0
	public bool endConnectionFlag; // 0x2F4
	public bool startSegmentIntAdjusted; // 0x2F5
	public bool endSegmentIntAdjusted; // 0x2F6
	public bool tCrossingConnected; // 0x2F7
	public Material roadMaterial; // 0x2F8
	public Material[] roadMaterials; // 0x300
	public PhysicMaterial roadPhysicsMaterial; // 0x308
	public PhysicMaterial[] roadPhysicsMaterials; // 0x310
	public Vector3 startDir; // 0x318
	public Vector3 endDir; // 0x324
	public float startAngle; // 0x330
	public float endAngle; // 0x334
	private int ᙃ; // 0x338
	private int ᙄ; // 0x33C
	public int startbendLeftRight; // 0x340
	public int endbendLeftRight; // 0x344
	public float connectionAdjustDistanceStart; // 0x348
	public float connectionAdjustDistanceEnd; // 0x34C
	public Vector3 pivotp; // 0x350
	public Vector3 p1; // 0x35C
	public Vector3 p2; // 0x368
	public Vector3 p3; // 0x374
	public Vector3 p4; // 0x380
	public Vector3 p5; // 0x38C
	public Vector3 p6; // 0x398
	public Vector3 p7; // 0x3A4
	public Vector3 cp1; // 0x3B0
	public Vector3 cp2; // 0x3BC
	public Vector3 cp3; // 0x3C8
	public Vector3 cp4; // 0x3D4
	public Vector3 cp5; // 0x3E0
	public Vector3 cp6; // 0x3EC
	public Vector3 cp7; // 0x3F8
	public Vector3 cp8; // 0x404
	public Vector3 cp9; // 0x410
	public Vector3 cpcenter; // 0x41C
	public Vector3 p1Circle; // 0x428
	public Vector3 p2Circle; // 0x434
	public float cpradius; // 0x440
	public float cpangle; // 0x444
	public Vector3 dp1; // 0x448
	public Vector3 dp2; // 0x454
	public Vector3 dp3; // 0x460
	public Vector3 dp4; // 0x46C
	public List<Vector3> segPoints; // 0x478
	public List<Vector3> testPoints; // 0x480
	public List<Vector3> testPoints2; // 0x488
	public Vector3 OQOQODDQCC; // 0x490
	public Vector3 ODQCDQCCOD; // 0x49C
	public Vector3 endLeft; // 0x4A8
	public Vector3 endRight; // 0x4B4
	public Mesh testmesh; // 0x4C0
	public GameObject surfaceMesh; // 0x4C8
	public Vector3 sv1; // 0x4D0
	public Vector3 sv2; // 0x4DC
	public Vector3 prefabIndentLeft; // 0x4E8
	public Vector3 prefabIndentRight; // 0x4F4
	public Vector3 roadIndent1; // 0x500
	public static int ODQQCDOQOD; // 0x0
	public static int OCOQCCDDQC; // 0x4
	public static int ODCDCCQCQC; // 0x8
	public static int OQDCDCOCQC; // 0xC
	public static int OQQQOQOQOQ; // 0x10
	public static int OQOQDOCQCD; // 0x14
	public Vector3 tmpPerpCP; // 0x50C
	public Vector3 tmpCP; // 0x518
	private int ᙅ; // 0x524
	private int 4AAAA; // 0x528
	public float splinePos; // 0x52C
	public float camHeight; // 0x530
	public Vector3[] flyOverPoints; // 0x538
	public Vector3 splinePosV3; // 0x540
	public List<float> markerDistances; // 0x550
	public string osmRoadType; // 0x558
	public List<ERSORoad> soData; // 0x560
	public List<ERSORoadExt> soDataExt; // 0x568
	public string[] sideObjectNames; // 0x570
	public int selectedSO; // 0x578
	public bool rebuildSos; // 0x57C
	public bool sosCleared; // 0x57D
	public bool isSideObject; // 0x57E
	public int startOffsetActiveMarker; // 0x580
	public int endOffsetActiveMarker; // 0x584
	public float leftToCenterPerc; // 0x588
	public ERRoad road; // 0x590
	public bool splatMapActive; // 0x598
	public int splatIndex; // 0x59C
	public int expandLevel; // 0x5A0
	public int smoothLevel; // 0x5A4
	public float splatOpacity; // 0x5A8
	public int layer; // 0x5AC
	public bool isStatic; // 0x5B0
	public string tag; // 0x5B8
	public int tagInt; // 0x5C0
	public bool castShadow; // 0x5C4
	public bool fadeInFlag; // 0x5C5
	public float fadeInDistance; // 0x5C8
	public bool fadeOutFlag; // 0x5CC
	public float fadeOutDistance; // 0x5D0
	public bool doSurroundingSurfaces; // 0x5D4
	public bool terrainDeformation; // 0x5D5
	public bool snapToTerrain; // 0x5D6
	public List<ERSOSection> soSectionList1; // 0x5D8
	public List<ERSOSection> soSectionList2; // 0x5E0
	public List<ERSOSection> soSectionList3; // 0x5E8
	public List<ERSOSection> soSectionList4; // 0x5F0
	public List<ERSOSection> soSectionList5; // 0x5F8
	public List<ERSOSection> soSectionList6; // 0x600
	public List<ERSOSection> soSectionList7; // 0x608
	public List<ERSOSection> soSectionList8; // 0x610
	public bool snapVertices; // 0x618
	public float snapOffset; // 0x61C
	public bool hasMeshCollider; // 0x620
	public bool isUpdated; // 0x621
	public bool QDDDQODQQDQDQQD; // 0x622
	public int uv4Type; // 0x624
	public float detailDistance; // 0x628
	public bool startDecalCollapsed; // 0x62C
	public ERDecal startDecal; // 0x630
	public ERDecal endDecal; // 0x638
	public GameObject startDecalPrefab; // 0x640
	public GameObject startDecalPrefabSource; // 0x648
	public bool endDecalCollapsed; // 0x650
	public GameObject endDecalPrefab; // 0x658
	public GameObject endDecalPrefabSource; // 0x660
	public int startDecalID; // 0x668
	public int endDecalID; // 0x66C
	public Vector3 lastForward; // 0x670
	public bool roadUpdate; // 0x67C
	public Bounds bounds; // 0x680
	public List<Vector3> debugVecs; // 0x698
	public List<float> debugFloats; // 0x6A0
	public Vector3 exitExtrudeEnd; // 0x6A8
	public Vector3 exitFixedEnd; // 0x6B4
	public Vector3 exitSplitEnd; // 0x6C0
	public Texture2D splatTextureMask; // 0x6D0
	public bool lockUVs; // 0x6D8
	public List<ERLaneData> laneData; // 0x6E0
	public bool oneWayRoad; // 0x6E8
	public ERLaneDirection oneWayDirection; // 0x6EC

	// Methods

	// RVA: 0x489DD0 Offset: 0x4883D0 VA: 0x180489DD0
	public bool ODDQCOCDQQ(ERCrossingPrefabs prefabScript) { }

	// RVA: 0x48A610 Offset: 0x488C10 VA: 0x18048A610
	public void ODQCQCDCDQ(List<ERDecal> decalPresets) { }

	// RVA: 0x48CA60 Offset: 0x48B060 VA: 0x18048CA60
	public void OOQOCCOOOD() { }

	// RVA: 0x470080 Offset: 0x46E680 VA: 0x180470080
	public float GetRoadWidth() { }

	// RVA: 0x498400 Offset: 0x496A00 VA: 0x180498400
	public void OQQOCOQDCQ(Vector3 pos) { }

	// RVA: 0x472C60 Offset: 0x471260 VA: 0x180472C60
	public int OCDQCCCDCC(Vector3 pos) { }

	// RVA: 0x46EC70 Offset: 0x46D270 VA: 0x18046EC70
	public void GetInsertPointExt(Vector3 pos, ref int n1, int marker) { }

	// RVA: 0x4731D0 Offset: 0x4717D0 VA: 0x1804731D0
	public void OCOOCCODDD(Vector3 pos, ref int n1) { }

	// RVA: 0x48C460 Offset: 0x48AA60 VA: 0x18048C460
	public void OOODDDDQQO(Vector3 pos, ref int n1, int selectedMarker, bool sameRoad) { }

	// RVA: 0x48CF20 Offset: 0x48B520 VA: 0x18048CF20
	public int OQCCQDDOQD(Vector3 pos) { }

	// RVA: 0x48B920 Offset: 0x489F20 VA: 0x18048B920
	public int OOCDODCOOD(Vector3 pos, int selectedMarker) { }

	// RVA: 0x470D90 Offset: 0x46F390 VA: 0x180470D90
	public int HandleAddMarkerAtStart(Vector3 pos, int selectedMarker) { }

	// RVA: 0x489DB0 Offset: 0x4883B0 VA: 0x180489DB0
	public void ODDDCDQCCO(ERCrossingPrefabs ODCQDOOOCC, int targetElement, bool reverse, bool uvReverse, bool UpdateResolutionFlag) { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	public void OOOCDCQQCO(bool ignorePrefabAlignment, int selectedMarker) { }

	// RVA: 0x498580 Offset: 0x496B80 VA: 0x180498580
	public void PrintRoadShape(List<Vector2> lst) { }

	// RVA: 0x473BF0 Offset: 0x4721F0 VA: 0x180473BF0
	public void OCQOQCDCQC(bool ignorePrefabAlignment, bool forceAutoRotate) { }

	// RVA: 0x472DB0 Offset: 0x4713B0 VA: 0x180472DB0
	private void OCODCOOQOC(ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs2, int cols, ref int addedRows, ref List<bool> isPlanar, ref List<Color> colors, ref float uv, ref float uv4) { }

	// RVA: 0x4724C0 Offset: 0x470AC0 VA: 0x1804724C0
	public void OCDCOOQOQD(Mesh m) { }

	// RVA: 0x497EC0 Offset: 0x4964C0 VA: 0x180497EC0
	public void OQOOOOOOCQ(ERDecal decal, ref GameObject decalPrefab, string name) { }

	// RVA: 0x489DA0 Offset: 0x4883A0 VA: 0x180489DA0
	public float ODCDOQOOOO(ERDecal decal, float roadWidth) { }

	// RVA: 0x48BD40 Offset: 0x48A340 VA: 0x18048BD40
	public void OOOCOODQCO(string type) { }

	// RVA: 0x497190 Offset: 0x495790 VA: 0x180497190
	public void OQOCCDCCDD(GameObject decal, int index) { }

	// RVA: 0x472750 Offset: 0x470D50 VA: 0x180472750
	public float OCDDDDQDQQ(int startEnd) { }

	// RVA: 0x46E1C0 Offset: 0x46C7C0 VA: 0x18046E1C0
	public Vector3[] AdjustNormals(Vector3[] normals) { }

	// RVA: 0x46E370 Offset: 0x46C970 VA: 0x18046E370
	public void AdjustPrefabNormals(List<int> roadInts, List<int> prefabInts, Vector3[] normals, GameObject prefab, Vector3[] verts) { }

	// RVA: 0x48D500 Offset: 0x48BB00 VA: 0x18048D500
	public bool OQCDCDOOCD(Vector3 pTarget, Vector3 pSource, Vector3 pCheck) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OODCOQOQOD(ref List<Vector3> surfaceVecs, ERCrossingPrefabs prefabScript, ref bool startSurfacesSafe, float distance, float minIndent) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ODOCCQDCQO(ref List<Vector3> surfaceVecs, ERCrossingPrefabs prefabScript, int el, ref bool surfacesSafe, float distance, float minIndent) { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public bool OQCODQODCO(Vector3 ODCQDOOOCCIndent, Vector3 otherPrefabIndent, Vector3 v) { }

	// RVA: 0x487430 Offset: 0x485A30 VA: 0x180487430
	public void OCQOQQCDOD(List<Vector3> surfaceVecs, List<Vector2> uvs, int h, List<bool> doBridge, Vector3 firstDir, Vector3 lastDir, float indent, float surrounding, List<bool> tunnelSegments) { }

	// RVA: 0x470E70 Offset: 0x46F470 VA: 0x180470E70
	public void InterpolateSurfaces(ref List<Vector3> surfaceVecs, ref List<Vector2> uvs, ref List<int> tris, Vector3 dir, int vecCount, int startEnd, float indent, float surrounding) { }

	// RVA: 0x48B0B0 Offset: 0x4896B0 VA: 0x18048B0B0
	public void OOCCDCDCQD() { }

	// RVA: 0x48D670 Offset: 0x48BC70 VA: 0x18048D670
	public List<Vector3> OQDDOOOOQD(List<ERMarkerExt> markersExt, float faceDist, bool ignorePrefabAlignment, ref List<float> tValues, ref List<float> markerDistances, bool forceAutoRotate, ref List<float> rotationArray, ref List<float> bendAngles) { }

	// RVA: 0x4733E0 Offset: 0x4719E0 VA: 0x1804733E0
	public void OCQOOCCQDD(List<ERMarkerExt> tmpMarkers, int j, Vector3[] tr, Vector3 circleDir, float totalDist, ref Vector3 startCP, int startMarker, List<Vector3> p) { }

	// RVA: 0x496700 Offset: 0x494D00 VA: 0x180496700
	public void OQDOQOCDDQ(List<ERMarkerExt> tmpMarkersExt, int j, Vector3[] tr, ref Vector3 endCP, int startMarker) { }

	// RVA: 0x48B5D0 Offset: 0x489BD0 VA: 0x18048B5D0
	public void OOCCQCCDQC(ref Vector3 endCP, Vector3 curV3, Vector3 nextV3, Vector3 nextNextV3) { }

	// RVA: 0x495990 Offset: 0x493F90 VA: 0x180495990
	public List<float> OQDOOOQODD(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, ref List<float> OQQOODQCCC, List<float> randomRotations) { }

	// RVA: 0x498890 Offset: 0x496E90 VA: 0x180498890
	public void RoadSmoothness(float curDist, ERMarkerExt marker, float totalDistance, ref float randomYDistanceStart, ref float randomYDistanceEnd, ref float randomYDistanceMiddle, ref Vector3 randomYDistanceV3, ref Vector3 v, ref float currentRandomYDistance, ref float randomRotationStart, ref float randomRotationEnd, ref float randomRotationMiddle, ref Vector3 randomRotationV3, ref float currentRandomRotation, ref List<float> rotationArray) { }

	// RVA: 0x46ECA0 Offset: 0x46D2A0 VA: 0x18046ECA0
	public List<List<Vector2>> GetRoadShapeValues(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, List<Vector2> roadShape) { }

	// RVA: 0x470100 Offset: 0x46E700 VA: 0x180470100
	public List<float> GetSurfaceValues(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, ref List<float> leftIndents, ref List<float> rightIndents, ref List<float> leftSurrounding, ref List<float> rightSurrounding, float minRequiredIndent) { }

	// RVA: 0x472210 Offset: 0x470810 VA: 0x180472210
	public bool OCCQQDDDQC(SideObject obj, bool flag) { }

	// RVA: 0x48A2C0 Offset: 0x4888C0 VA: 0x18048A2C0
	public bool ODQCOQQDCD(SideObject obj, int marker, bool flag) { }

	// RVA: 0x46E7A0 Offset: 0x46CDA0 VA: 0x18046E7A0
	public bool ERSetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	// RVA: 0x489EE0 Offset: 0x4884E0 VA: 0x180489EE0
	public bool ODQCOQQDCD(SideObject obj, int[] markers, bool flag) { }

	// RVA: 0x498090 Offset: 0x496690 VA: 0x180498090
	public List<Vector3> OQOQDCODCD(bool flag) { }

	// RVA: 0x498390 Offset: 0x496990 VA: 0x180498390
	public void OQOQDQCDCQ() { }

	// RVA: 0x48AC90 Offset: 0x489290 VA: 0x18048AC90
	public List<float> ODQQOQQDOO(Vector3[] tr) { }

	// RVA: 0x48C760 Offset: 0x48AD60 VA: 0x18048C760
	public Vector3 OOOOQCODCQ(float offset) { }

	// RVA: 0x48BA10 Offset: 0x48A010 VA: 0x18048BA10
	public static Vector3 OODODQQQCD(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t, float tension) { }

	// RVA: 0x471EF0 Offset: 0x4704F0 VA: 0x180471EF0
	public Vector3 OCCDDOCCDQ(int startend, ERCrossingPrefabs prefab) { }

	// RVA: 0x496F80 Offset: 0x495580 VA: 0x180496F80
	public void OQDQOOQODD(bool lineMask, bool biomeMask) { }

	// RVA: 0x498E30 Offset: 0x497430 VA: 0x180498E30
	public void SetMarkerShape(List<Vector2> conVecs, Vector3 scale, ERCrossingPrefabs prefab, int connectionIndex) { }

	// RVA: 0x48AB00 Offset: 0x489100 VA: 0x18048AB00
	public void ODQOCQCCDC(ERIndentAlignment value, int marker, ERRoadSide type) { }

	// RVA: 0x46E5E0 Offset: 0x46CBE0 VA: 0x18046E5E0
	public ERIndentAlignment ERGetIndentAlignment(int marker, ERRoadSide type) { }

	// RVA: 0x46EA00 Offset: 0x46D000 VA: 0x18046EA00
	public void FlipRoadUVs(bool update) { }

	// RVA: 0x470020 Offset: 0x46E620 VA: 0x180470020
	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	// RVA: 0x499030 Offset: 0x497630 VA: 0x180499030
	public void .ctor() { }

}

