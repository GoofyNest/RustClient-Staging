public class ERCrossingPrefabs : MonoBehaviour // TypeDefIndex: 7179
{	// Fields
	public List<QDOODOQQDQODD> crossingElements; // 0x18
	public List<QDOQDSQOOQDDD> sidewalkControlElements; // 0x20
	public List<ERConnectionSibling> siblings; // 0x28
	public Vector3[] meshVecs; // 0x30
	public Vector3[] fullMeshVecs; // 0x38
	public Vector3[] tmpMeshVecs; // 0x40
	public Vector3[] tmpFullMeshVecs; // 0x48
	public Vector3[] tCrossingTmpFullMeshVecs; // 0x50
	public int[] outerVecInts; // 0x58
	public List<Vector3> surfaceVecs; // 0x60
	public List<int> surfaceVecType; // 0x68
	public List<int> surfaceConnectionInt; // 0x70
	public List<ERBlendVecs> tCrossingBlendData; // 0x78
	public List<Vector3> indentVecs; // 0x80
	public GameObject sourcePrefab; // 0x88
	public int prefabId; // 0x90
	public string guid; // 0x98
	public List<int> prioritySegments; // 0xA0
	public float minNodeDistance; // 0xA8
	public int nodeWithinRange; // 0xAC
	public GameObject sourceObject; // 0xB0
	public bool meshInstance; // 0xB8
	public int selectedConnection; // 0xBC
	public string[] QDOOOQOOQQQQD; // 0xC0
	public bool deformTerrain; // 0xC8
	public bool isRoundabout; // 0xC9
	public bool isERCrossing; // 0xCA
	public bool isYConnector; // 0xCB
	public bool isIConnector; // 0xCC
	public bool isFlexConnector; // 0xCD
	public bool isSnapConnector; // 0xCE
	public bool isExitRoadConnector; // 0xCF
	public Vector3 prefabCenterDummy; // 0xD0
	public float snapRadius; // 0xDC
	public ERRoundabouts roundaboutScript; // 0xE0
	public ERCrossings crossingsScript; // 0xE8
	public ERIConnector iConnectorScript; // 0xF0
	public bool isCustomPrefab; // 0xF8
	public int customPrefabVersion; // 0xFC
	public bool recalculateNormals; // 0x100
	public bool planarUVs; // 0x101
	public float planarTiling; // 0x104
	public int lastVecRoadIndex; // 0x108
	public bool isSceneObject; // 0x10C
	public GameObject surfaceObject; // 0x110
	public Vector3[] surfaceMeshVecs; // 0x118
	public Vector3[] tmpSurfaceMeshVecs; // 0x120
	public Vector3[] tmpSurfaceVecsTCrossings; // 0x128
	public int[] surfaceInts; // 0x130
	public Vector3 leftBottomCorner; // 0x138
	public Vector3 leftTopCorner; // 0x144
	public Vector3 rightBottomCorner; // 0x150
	public Vector3 rightTopCorner; // 0x15C
	public bool tCrossing; // 0x168
	public bool tStraightBending; // 0x169
	public int tCrossingLeftRight; // 0x16C
	public float tMainRoadWidth; // 0x170
	public float tConnectionRoadWidth; // 0x174
	public float bottomLeftSidewalkWidth; // 0x178
	public float bottomLeftSidewalkOuterOffset; // 0x17C
	public float bottomLeftSidewalkCurbDepth; // 0x180
	public float bottomRightSidewalkWidth; // 0x184
	public float bottomRightSidewalkOuterOffset; // 0x188
	public float bottomRightSidewalkCurbDepth; // 0x18C
	public float topLeftSidewalkWidth; // 0x190
	public float topLeftSidewalkOuterOffset; // 0x194
	public float topLeftSidewalkCurbDepth; // 0x198
	public float topRightSidewalkWidth; // 0x19C
	public float topRightSidewalkOuterOffset; // 0x1A0
	public float topRightSidewalkCurbDepth; // 0x1A4
	public ERConnection connObject; // 0x1A8
	public Vector3 testVec; // 0x1B0
	public List<int> surfaceSurroundingInts; // 0x1C0
	public int rotationPriorityElement; // 0x1C8
	public Vector3 cornerPos; // 0x1CC
	public Vector3 mainCorner; // 0x1D8
	public Vector3 connectedCorner; // 0x1E4
	public Vector3 mainVecOuter; // 0x1F0
	public Vector3 connectionVecOuter; // 0x1FC
	public Vector3 indentTopVec; // 0x208
	public Vector3 indentRightVec; // 0x214
	public Vector3 mainIndent; // 0x220
	public Vector3 connectionIndent; // 0x22C
	public int selectedRotationConnection; // 0x238
	public Vector3 bottomVec; // 0x23C
	public Vector3 rightVec; // 0x248
	public Vector3 bottomIndent; // 0x254
	public Vector3 rightIndent; // 0x260
	public float sAngle; // 0x26C
	public ERModularBase baseScript; // 0x270
	public bool QDQDQOOQQDQOQQ; // 0x278
	public Vector3 tp1; // 0x27C
	public Vector3 tp2; // 0x288
	public bool doTerrainDeformation; // 0x294
	public bool includeOuterVertices; // 0x295
	public bool averageNormals; // 0x296
	public float surroundingDistance; // 0x298
	public Mesh surfaceMesh; // 0x2A0
	public List<Vector3> debugVecs1; // 0x2A8
	public List<Vector3> debugVecs2; // 0x2B0
	public bool lightmapAdjusted; // 0x2B8
	public bool isFlexUpdating; // 0x2B9
	public Vector3 oldPosition; // 0x2BC
	public Vector3 oldRotation; // 0x2C8
	public bool lockScale; // 0x2D4
	public float extraIndentMargin; // 0x2D8
	public float indent; // 0x2DC
	public float surrounding; // 0x2E0

	// Methods

	// RVA: 0xB868A0 Offset: 0xB84EA0 VA: 0x180B868A0
	public void OCOODQQDQO() { }

	// RVA: 0xB86F30 Offset: 0xB85530 VA: 0x180B86F30
	public void OOCQCCQDOQ(Vector3 v1, Vector3 v2, int connectionElement, ERModularRoad road) { }

	// RVA: 0xB86970 Offset: 0xB84F70 VA: 0x180B86970
	public void OCQDDQODCC(int el) { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	public void OCDOCCODOC(int elInt, float distance) { }

	// RVA: 0xB849D0 Offset: 0xB82FD0 VA: 0x180B849D0
	public void DeformTCossingConnection(int elInt, float distance, float defaultDistance, List<Vector3> controlPoints, float multiplyFactor, float angle, Vector3 cpCenterPoint, float curveStrength) { }

	// RVA: 0xB87950 Offset: 0xB85F50 VA: 0x180B87950
	public void OOODCOOOCQ(List<int> affectedVecs, List<Vector2> tmpVecs) { }

	// RVA: 0xB88200 Offset: 0xB86800 VA: 0x180B88200
	public void OQOQDDOCDC(bool ignorePriority, ERModularRoad road) { }

	// RVA: 0xB899B0 Offset: 0xB87FB0 VA: 0x180B899B0
	public void OQQODODQCQ() { }

	// RVA: 0xB895F0 Offset: 0xB87BF0 VA: 0x180B895F0
	public void OQQCDODDQQ(bool forceFlag) { }

	// RVA: 0xB846D0 Offset: 0xB82CD0 VA: 0x180B846D0
	public void CheckPlanarUVs() { }

	// RVA: 0xB86E60 Offset: 0xB85460 VA: 0x180B86E60
	public static bool OOCCOODCOO(List<ERModularRoad> affectedObjects, ERModularRoad roadScr) { }

	// RVA: 0xB86390 Offset: 0xB84990 VA: 0x180B86390
	public void OCCDCDDOOQ(bool flag) { }

	// RVA: 0xB878B0 Offset: 0xB85EB0 VA: 0x180B878B0
	public void OODODQQCOD(int el) { }

	// RVA: 0xB85A60 Offset: 0xB84060 VA: 0x180B85A60
	public bool HasConnections() { }

	// RVA: 0xB857A0 Offset: 0xB83DA0 VA: 0x180B857A0
	public bool HasConnectionsFull() { }

	// RVA: 0xB87AD0 Offset: 0xB860D0 VA: 0x180B87AD0
	public void OOQOQQODCD() { }

	// RVA: 0xB86560 Offset: 0xB84B60 VA: 0x180B86560
	public void OCODDQDQCC(int el, int startend) { }

	// RVA: 0xB8A100 Offset: 0xB88700 VA: 0x180B8A100
	public void PopulateSiblingsList() { }

	// RVA: 0xB85B50 Offset: 0xB84150 VA: 0x180B85B50
	public void InitFlexConnector() { }

	// RVA: 0xB84400 Offset: 0xB82A00 VA: 0x180B84400
	public void AttachRoadToFlexConnector(ERModularBase scr, float OCCDOQCODC, Vector3 OCCQOCQOQD) { }

	// RVA: 0xB89A00 Offset: 0xB88000 VA: 0x180B89A00
	public void OQQQQOOCDO(int index) { }

	// RVA: 0xB8A490 Offset: 0xB88A90 VA: 0x180B8A490
	public void SetElementInfo(int index, int sourceIndex) { }

	// RVA: 0xB86B40 Offset: 0xB85140 VA: 0x180B86B40
	public static void ODDQDDQOOD() { }

	// RVA: 0xB880A0 Offset: 0xB866A0 VA: 0x180B880A0
	public static bool OQCDCDOOCD(Vector3 pTarget, Vector3 pSource, Vector3 pCheck) { }

	// RVA: 0xB8A6A0 Offset: 0xB88CA0 VA: 0x180B8A6A0
	public void .ctor() { }

}

