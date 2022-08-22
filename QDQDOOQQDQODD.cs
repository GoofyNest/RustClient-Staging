public class QDQDOOQQDQODD // TypeDefIndex: 7194
{	// Fields
	public string roadTypeName; // 0x10
	public double id; // 0x18
	public double timestamp; // 0x20
	public float roadWidth; // 0x28
	public float faceDistance; // 0x2C
	public float angleTreshold; // 0x30
	public float uvTiling; // 0x34
	public int uv4Type; // 0x38
	public ERRoadWayType type; // 0x3C
	public float detailDistance; // 0x40
	public bool planarUVs; // 0x44
	public float outerIndent; // 0x48
	public bool roadShapeDataActive; // 0x4C
	public ERRoadShape roadShapeData; // 0x50
	public float minSpeed; // 0xB0
	public float maxSpeed; // 0xB4
	public float speedLimit; // 0xB8
	public List<Vector2> roadShape; // 0xC0
	public List<Vector2> roadShapeExt; // 0xC8
	public List<Vector2> roadShapeExt2; // 0xD0
	public List<bool> doConnectionTri; // 0xD8
	public List<bool> doConnectionTriExt; // 0xE0
	public List<float> roadShapeUVs; // 0xE8
	public List<float> roadShapeExtUVs; // 0xF0
	public List<float> roadShapeExtUVs2; // 0xF8
	public List<float> roadShapeUVs2; // 0x100
	public bool preserveUVs; // 0x108
	public List<bool> hardEdge; // 0x110
	public string roadShapeVecsString; // 0x118
	public double defaultSidewalk; // 0x120
	public bool sidewalks; // 0x128
	public float sidewalkHeight; // 0x12C
	public float sidewalkWidth; // 0x130
	public Material roadMaterial; // 0x138
	public Material[] roadMaterials; // 0x140
	public PhysicMaterial roadPhysicsMaterial; // 0x148
	public PhysicMaterial[] roadPhysicsMaterials; // 0x150
	public Material connectionMaterial; // 0x158
	public bool isSideObject; // 0x160
	public bool isCustomRoad; // 0x161
	public int subSegments; // 0x164
	public List<ERSORoad> soData; // 0x168
	public List<ERSORoadExt> soDataExt; // 0x170
	public List<ERSORoadLog> soDataLog; // 0x178
	public int layer; // 0x180
	public bool isStatic; // 0x184
	public string tag; // 0x188
	public bool splatMapActive; // 0x190
	public int splatIndex; // 0x194
	public int expandLevel; // 0x198
	public int smoothLevel; // 0x19C
	public float splatOpacity; // 0x1A0
	public bool followTerrainContours; // 0x1A4
	public float terrainContoursOffset; // 0x1A8
	public bool terrainDeformation; // 0x1AC
	public float defaultIndent; // 0x1B0
	public float defaultSurrounding; // 0x1B4
	public bool castShadow; // 0x1B8
	public bool randomnessFlag; // 0x1B9
	public float randomYPosition; // 0x1BC
	public float randomMinYPosition; // 0x1C0
	public float randomMaxYPosition; // 0x1C4
	public float minRandomYPositionDistance; // 0x1C8
	public float maxRandomYPositionDistance; // 0x1CC
	public float randomMinRotation; // 0x1D0
	public float randomMaxRotation; // 0x1D4
	public float minRandomRotationDistance; // 0x1D8
	public float maxRandomRotationDistance; // 0x1DC
	public bool vegetationStudioMaskLineActive; // 0x1E0
	public float vegetationStudioGrassPerimeter; // 0x1E4
	public float vegetationStudioPlantPerimeter; // 0x1E8
	public float vegetationStudioTreePerimeter; // 0x1EC
	public float vegetationStudioObjectPerimeter; // 0x1F0
	public float vegetationStudioLargeObjectPerimeter; // 0x1F4
	public bool vegetationStudioBiomeMaskActive; // 0x1F8
	public float vegetationStudioBiomeMaskDistance; // 0x1FC
	public float vegetationStudioBiomeMaskBlendDistance; // 0x200
	public float vegetationStudioBiomeMaskNoiseScale; // 0x204
	public List<ERDecal> decalPresets; // 0x208
	public List<ERDecalClass> decalClassPresets; // 0x210
	public double defaultRamp; // 0x218
	public int extrusionType; // 0x220
	public float extrusionDistance; // 0x224
	public float fixedDistance; // 0x228
	public float connectionAngle; // 0x22C
	public float connectionRadius; // 0x230
	public int isRoadShape; // 0x234
	public int controlType; // 0x238

	// Methods

	// RVA: 0xB623F0 Offset: 0xB609F0 VA: 0x180B623F0
	public void RoadTypeUpgrade() { }

	// RVA: 0xB5DEF0 Offset: 0xB5C4F0 VA: 0x180B5DEF0
	public int GetTagIndex(string[] tags) { }

	// RVA: 0xB5DF70 Offset: 0xB5C570 VA: 0x180B5DF70
	public static int GetTagIndex(string[] tags, string tag) { }

	// RVA: 0xB62110 Offset: 0xB60710 VA: 0x180B62110
	public void OQQOCCODOD() { }

	// RVA: 0xB62C00 Offset: 0xB61200 VA: 0x180B62C00
	public void .ctor(int count) { }

	// RVA: 0xB627B0 Offset: 0xB60DB0 VA: 0x180B627B0
	public void UpdateTimestamp() { }

	// RVA: 0xB5F910 Offset: 0xB5DF10 VA: 0x180B5F910
	public static bool ODQDDOCDDC(ERModularBase scr) { }

	// RVA: 0xB622B0 Offset: 0xB608B0 VA: 0x180B622B0
	public static string[] RoadNames(List<QDQDOOQQDQODD> roadTypes) { }

	// RVA: 0xB5E8B0 Offset: 0xB5CEB0 VA: 0x180B5E8B0
	public static string[] Nodes(ERRoadShape data) { }

	// RVA: 0xB5E780 Offset: 0xB5CD80 VA: 0x180B5E780
	public static string[] LaneNodes(ERRoadShape data) { }

	// RVA: 0xB5E5F0 Offset: 0xB5CBF0 VA: 0x180B5E5F0
	public static GUIContent[] LaneNodesContents(ERRoadShape data) { }

	// RVA: 0xB60040 Offset: 0xB5E640 VA: 0x180B60040
	public void ODQQQODOQD() { }

	// RVA: 0xB62610 Offset: 0xB60C10 VA: 0x180B62610
	public static int SetRoadType(List<QDQDOOQQDQODD> roadTypes, double roadType) { }

	// RVA: 0xB62AF0 Offset: 0xB610F0 VA: 0x180B62AF0
	public void UpdateUVs() { }

	// RVA: 0xB5DE30 Offset: 0xB5C430 VA: 0x180B5DE30
	public static QDQDOOQQDQODD GetRoadTypeElByID(List<QDQDOOQQDQODD> roadTypes, double id) { }

	// RVA: 0xB5F560 Offset: 0xB5DB60 VA: 0x180B5F560
	public static int ODDQDCOODD(List<QDQDOOQQDQODD> roadTypes, double id, ref string[] ramps, ref QDQDOOQQDQODD[] rampTypes) { }

	// RVA: 0xB5DD60 Offset: 0xB5C360 VA: 0x180B5DD60
	public static int GetRoadTypeByID(List<QDQDOOQQDQODD> roadTypes, double id) { }

	// RVA: 0xB62060 Offset: 0xB60660 VA: 0x180B62060
	public static bool OOQDCODDCO(List<QDQDOOQQDQODD> roadTypes, double id, ref QDQDOOQQDQODD motorwayLink) { }

	// RVA: 0xB5F7B0 Offset: 0xB5DDB0 VA: 0x180B5F7B0
	public static string[] ODODCOQODO(List<QDQDOOQQDQODD> roadTypes) { }

	// RVA: 0xB5DFF0 Offset: 0xB5C5F0 VA: 0x180B5DFF0
	public static bool GetTerrainDeformationByID(List<QDQDOOQQDQODD> roadTypes, double id, ref int element) { }

	// RVA: 0xB62A00 Offset: 0xB61000 VA: 0x180B62A00
	public static void UpdateUVTiling(List<QDQDOOQQDQODD> roadTypes, double id, float tiling) { }

	// RVA: 0xB626C0 Offset: 0xB60CC0 VA: 0x180B626C0
	public static void UpdateResolution(List<QDQDOOQQDQODD> roadTypes, double id, ref float resolution, ref float threshold) { }

	// RVA: 0xB5E9E0 Offset: 0xB5CFE0 VA: 0x180B5E9E0
	public void OCDOCDQQQO(QDQDOOQQDQODD sourcePreset, List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, bool copyShapeData) { }

	// RVA: 0xB60280 Offset: 0xB5E880 VA: 0x180B60280
	public static void OOOCDCQQCO(QDQDOOQQDQODD sourcePreset, ERModularRoad road, bool update, int customShapeHandling, bool checkRoadWidth) { }

	// RVA: 0xB5CEF0 Offset: 0xB5B4F0 VA: 0x180B5CEF0
	public static void AssignSideObjects(ERModularBase scr, int roadTypeInt, ERModularRoad OCCQOOOQQO) { }

	// RVA: 0xB5E0C0 Offset: 0xB5C6C0 VA: 0x180B5E0C0
	public static void HasActiveSideObjects(List<ERSORoadExt> sos1, List<ERSORoadExt> sos2, ref bool flag1, ref bool flag2) { }

	// RVA: 0xB61EE0 Offset: 0xB604E0 VA: 0x180B61EE0
	public int OOOOCQCDDC(int index, ERLaneDirection direction) { }

	// RVA: 0xB5F540 Offset: 0xB5DB40 VA: 0x180B5F540
	public static bool ODCDDDQCQQ(QDQDOOQQDQODD rt1, QDQDOOQQDQODD rt2) { }

}

