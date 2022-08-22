public class ERMesh // TypeDefIndex: 7247
{	// Fields
	public List<int> vecsInt; // 0x10
	public List<Vector3> vecs; // 0x18
	public List<Vector2> uv; // 0x20
	public List<Vector2> uv2; // 0x28
	public List<Color> colors; // 0x30
	public List<Vector3> normals; // 0x38
	public List<Vector4> tangents; // 0x40
	public List<int> triangles; // 0x48
	public List<int> triangles2; // 0x50
	public List<int> startVecsInt; // 0x58
	public List<Vector3> startVecs; // 0x60
	public List<Vector2> startUv; // 0x68
	public List<Vector2> startUv2; // 0x70
	public List<Color> startColors; // 0x78
	public List<Vector3> startNormals; // 0x80
	public List<Vector4> startTangents; // 0x88
	public List<int> startTriangles; // 0x90
	public List<int> startTriangles2; // 0x98
	public List<int> endVecsInt; // 0xA0
	public List<Vector3> endVecs; // 0xA8
	public List<Vector2> endUv; // 0xB0
	public List<Vector2> endUv2; // 0xB8
	public List<Color> endColors; // 0xC0
	public List<Vector3> endNormals; // 0xC8
	public List<Vector4> endTangents; // 0xD0
	public List<int> endTriangles; // 0xD8
	public List<int> endTriangles2; // 0xE0
	public List<int> suVecsInt; // 0xE8
	public List<Vector3> suVecs; // 0xF0
	public List<Vector2> suUv; // 0xF8
	public List<Vector2> suUv2; // 0x100
	public List<Color> suColors; // 0x108
	public List<Vector3> suNormals; // 0x110
	public List<Vector4> suTangents; // 0x118
	public List<int> suTriangles; // 0x120
	public List<int> suTriangles2; // 0x128
	public List<int> sdVecsInt; // 0x130
	public List<Vector3> sdVecs; // 0x138
	public List<Vector2> sdUv; // 0x140
	public List<Vector2> sdUv2; // 0x148
	public List<Color> sdColors; // 0x150
	public List<Vector3> sdNormals; // 0x158
	public List<Vector4> sdTangents; // 0x160
	public List<int> sdTriangles; // 0x168
	public List<int> sdTriangles2; // 0x170
	public List<Material> materials; // 0x178
	public List<Vector3> sVecs; // 0x180
	public List<Vector2> sUv; // 0x188
	public List<Vector2> sUv2; // 0x190
	public List<Color> sColors; // 0x198
	public List<Vector3> sNormals; // 0x1A0
	public List<Vector4> sTangents; // 0x1A8
	public List<int> sTriangles; // 0x1B0
	public List<Vector3> sTerrainNormals; // 0x1B8
	public List<List<Vector3>> sVecsGroups; // 0x1C0
	public List<List<Vector2>> sUvGroups; // 0x1C8
	public List<List<Vector2>> sUv2Groups; // 0x1D0
	public List<List<Color>> sColorsGroups; // 0x1D8
	public List<List<Vector3>> sNormalsGroups; // 0x1E0
	public List<List<Vector4>> sTangentsGroups; // 0x1E8
	public List<List<int>> sTrianglesGroups; // 0x1F0
	public List<List<Vector3>> sTerrainNormalsGroups; // 0x1F8
	public List<Vector3> sStartVecs; // 0x200
	public List<Vector2> sStartUv; // 0x208
	public List<Vector2> sStartUv2; // 0x210
	public List<Color> sStartColors; // 0x218
	public List<Vector3> sStartNormals; // 0x220
	public List<Vector4> sStartTangents; // 0x228
	public List<int> sStartTriangles; // 0x230
	public List<Vector3> sEndVecs; // 0x238
	public List<Vector2> sEndUv; // 0x240
	public List<Vector2> sEndUv2; // 0x248
	public List<Color> sEndColors; // 0x250
	public List<Vector3> sEndNormals; // 0x258
	public List<Vector4> sEndTangents; // 0x260
	public List<int> sEndTriangles; // 0x268
	public List<Vector3> sSuVecs; // 0x270
	public List<Vector2> sSuUv; // 0x278
	public List<Vector2> sSuUv2; // 0x280
	public List<Color> sSuColors; // 0x288
	public List<Vector3> sSuNormals; // 0x290
	public List<Vector4> sSuTangents; // 0x298
	public List<int> sSuTriangles; // 0x2A0
	public List<Vector3> sSdVecs; // 0x2A8
	public List<Vector2> sSdUv; // 0x2B0
	public List<Vector2> sSdUv2; // 0x2B8
	public List<Color> sSdColors; // 0x2C0
	public List<Vector3> sSdNormals; // 0x2C8
	public List<Vector4> sSdTangents; // 0x2D0
	public List<int> sSdTriangles; // 0x2D8
	public int startEndVecCount; // 0x2E0
	public int middleStartVecCount; // 0x2E4
	public int middleEndVecCount; // 0x2E8
	public int endStartVecCount; // 0x2EC
	public List<Vector3> middleEndVecs; // 0x2F0
	public List<int> startEndInts; // 0x2F8
	public List<int> middleStartInts; // 0x300
	public List<int> middleEndInts; // 0x308
	public List<int> middleStartStartInts; // 0x310
	public List<int> middleEndEndInts; // 0x318
	public List<int> endStartInts; // 0x320
	public List<int> startEndIntsNC; // 0x328
	public List<int> middleStartStartIntsNC; // 0x330
	public List<int> middleStartIntsNC; // 0x338
	public List<int> middleEndIntsNC; // 0x340
	public List<int> middleEndEndIntsNC; // 0x348
	public List<int> endStartIntsNC; // 0x350
	public int OQOQODDQCCInt; // 0x358
	public int ODQCDQCCODInt; // 0x35C
	public int middleLeftInt; // 0x360
	public int middleRightInt; // 0x364
	public int endLeftInt; // 0x368
	public int endRightInt; // 0x36C
	public List<int> normalArray1; // 0x370
	public List<int> normalArray2; // 0x378
	public List<List<int>> normalArray1Group; // 0x380
	public List<List<int>> normalArray2Group; // 0x388
	public int vecCount; // 0x390
	public List<float> zValues; // 0x398
	public List<ZIndexArray> zValueVecIndexes; // 0x3A0
	public List<float> zValuesStart; // 0x3A8
	public List<ZIndexArray> zValueVecIndexesStart; // 0x3B0
	public List<float> zValuesEnd; // 0x3B8
	public List<ZIndexArray> zValueVecIndexesEnd; // 0x3C0
	public List<float> zValuesStepUp; // 0x3C8
	public List<ZIndexArray> zValueVecIndexesStepUp; // 0x3D0
	public List<float> zValuesStepDown; // 0x3D8
	public List<ZIndexArray> zValueVecIndexesStepDown; // 0x3E0
	public float minZ; // 0x3E8
	public float minMiddleZ; // 0x3EC
	public float maxZ; // 0x3F0
	public float maxMiddleZ; // 0x3F4
	public float totalZDistance; // 0x3F8
	public float offset1; // 0x3FC
	public float offset2; // 0x400
	public List<int> vertexBatches; // 0x408
	public List<int> triangleBatches; // 0x410
	public int lodIndex; // 0x418
	public bool castShadows; // 0x41C
	public string name; // 0x420
	public bool terrainMesh; // 0x428

	// Methods

	// RVA: 0x9C1180 Offset: 0x9BF780 VA: 0x1809C1180
	public void OCQQQCQQDD() { }

	// RVA: 0x9C5570 Offset: 0x9C3B70 VA: 0x1809C5570
	public void .ctor(GameObject m_go, SideObject soScript, float minZ, Transform sourceTransform, Vector3 scale, Mesh m, Material mat, float startMin = 0, bool rotate180 = False) { }

	// RVA: 0x9BF180 Offset: 0x9BD780 VA: 0x1809BF180
	private void OCDCDCQQDQ(GameObject m_go, SideObject soScript, float minZ, Transform sourceTransform, Vector3 scale, Mesh m, Material mat, float startMin, bool namingConvention) { }

	// RVA: 0x9BFD00 Offset: 0x9BE300 VA: 0x1809BFD00
	private void OCDCQCQQOC(List<Vector3> vecs, ref List<ZIndexArray> zValueVecIndexes, ref List<float> zValues) { }

	// RVA: 0x9BDE60 Offset: 0x9BC460 VA: 0x1809BDE60
	public void GetMiddleSementInfo(List<Vector3> vecs, ref float minMiddleZ, ref float maxMiddleZ, ref List<int> middleStartInts, ref List<int> middleEndInts) { }

	// RVA: 0x9BDD50 Offset: 0x9BC350 VA: 0x1809BDD50
	public void GetMiddleEdges(List<Vector3> vecs, float z, ref List<int> edgeInts) { }

	// RVA: 0x9C3100 Offset: 0x9C1700 VA: 0x1809C3100
	public bool OOCDOCOCQO(Vector3 v, int index, List<float> zV, ref List<ZIndexArray> zVIndexes) { }

	// RVA: 0x9C0AD0 Offset: 0x9BF0D0 VA: 0x1809C0AD0
	public void OCDQOQOCCD(int index, Vector3 v, ref List<int> vecsInts, ref List<Vector3> vecs, ref List<Vector2> uv, ref List<Vector2> uv2, ref List<Vector3> normals, ref List<Color> colors, ref List<Vector4> tangents, Vector2 sourceUv, Vector2 sourceUv2, Vector3 sourceNormal, Color sourceColor, Vector4 sourceTangent, ref int tri) { }

	// RVA: 0x9C16B0 Offset: 0x9BFCB0 VA: 0x1809C16B0
	public void ODDDDDQDOQ(int index, ref List<int> vecsInts) { }

	// RVA: 0x9BE110 Offset: 0x9BC710 VA: 0x1809BE110
	public void InEdgePairArray(int index1, int index2, ref List<CRedge> vecsInts) { }

	// RVA: 0x9C3F20 Offset: 0x9C2520 VA: 0x1809C3F20
	public void OQCDQOQOCQ(float adjustZ) { }

	// RVA: 0x9BFEE0 Offset: 0x9BE4E0 VA: 0x1809BFEE0
	public void OCDDCDODQQ(ref List<List<int>> groups, List<int> triInts, List<int> edgeInts) { }

	// RVA: 0x9C3D20 Offset: 0x9C2320 VA: 0x1809C3D20
	public void OOQOCOQOOO(List<CRedge> edges, ref int curInt) { }

	// RVA: 0x9BF0B0 Offset: 0x9BD6B0 VA: 0x1809BF0B0
	public bool OCCCOQOCQO(List<CRedge> edges, int index, int curInt) { }

	// RVA: 0x9C1770 Offset: 0x9BFD70 VA: 0x1809C1770
	public bool ODDDDDQDOQ(int index, List<int> edgeInts) { }

	// RVA: 0x9C0990 Offset: 0x9BEF90 VA: 0x1809C0990
	public bool OCDOQODCCQ(List<CRedge> edges, int index1, int index2) { }

	// RVA: 0x9BE2F0 Offset: 0x9BC8F0 VA: 0x1809BE2F0
	public void MatchEdgePairs(List<CRedge> startEdgePairs, List<CRedge> endEdgePairs, ref List<int> startInts, ref List<int> endInts, ref List<int> startIntsNC, ref List<int> endIntsNC, List<Vector3> startVecs, List<Vector3> endVecs, List<Vector3> startNormals, List<Vector3> normals, ref int OQOQODDQCCInt, ref int ODQCDQCCODInt) { }

	// RVA: 0x9C46A0 Offset: 0x9C2CA0 VA: 0x1809C46A0
	public void OQOCDDCQDD(List<List<int>> startGroups, List<List<int>> endGroups, ref List<int> startInts, ref List<int> endInts, List<Vector3> startVecs, List<Vector3> endVecs) { }

	// RVA: 0x9C1800 Offset: 0x9BFE00 VA: 0x1809C1800
	public void ODDDOCDCQO(ERModularRoad roadScr, GameObject go, SideObject so, ERModularBase scr, bool mirrored, int sectionListIndex, List<int> sectionIndexes, int autoSectionStart) { }

	// RVA: 0x9C4160 Offset: 0x9C2760 VA: 0x1809C4160
	public static bool OQCQCDQDOO(ERModularRoad rd, int listIndex, int listItemIndex, SideObject so, bool mirrored) { }

	// RVA: 0x9C31F0 Offset: 0x9C17F0 VA: 0x1809C31F0
	private void OODCCOCQOC(GameObject go, SideObject so, ERModularBase scr, List<Vector3> sVecs, List<Vector2> sUv, List<Vector2> sUv2, List<Color> sColors, List<Vector3> sNormals, List<Vector4> sTangents, List<int> sTriangles, List<int> normalArray1, List<int> normalArray2, List<Material> materials, List<Vector3> sTerrainNormals) { }

	// RVA: 0x9C0CE0 Offset: 0x9BF2E0 VA: 0x1809C0CE0
	private void OCOCOQQOOO(ref int vecCount, ref List<int> intList, List<Vector3> vecsList, float zValue) { }

	// RVA: 0x9C0E70 Offset: 0x9BF470 VA: 0x1809C0E70
	private void OCODQQOCDD(ref List<int> targetIntList, List<int> sourceIntList, List<Vector3> targetVecs, List<Vector3> sourceVecs) { }

	// RVA: 0x9BD8D0 Offset: 0x9BBED0 VA: 0x1809BD8D0
	public void Clear() { }

}

