public sealed class TerrainData : Object // TypeDefIndex: 4093
{	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
	private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";
	private const string k_HeightmapPrefix = "GetHeightmap().";
	private const string k_DetailDatabasePrefix = "GetDetailDatabase().";
	private const string k_TreeDatabasePrefix = "GetTreeDatabase().";
	private const string k_SplatDatabasePrefix = "GetSplatDatabase().";
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MaximumDetailsPerRes; // 0x10
	internal static readonly int k_MinimumAlphamapResolution; // 0x14
	internal static readonly int k_MaximumAlphamapResolution; // 0x18
	internal static readonly int k_MinimumBaseMapResolution; // 0x1C
	internal static readonly int k_MaximumBaseMapResolution; // 0x20

	public int heightmapResolution { get; set; }
	private int internalHeightmapResolution { get; set; }
	public Vector3 heightmapScale { get; }
	public Vector3 size { get; set; }
	public int detailResolution { get; }
	public DetailPrototype[] detailPrototypes { get; }
	public TreeInstance[] treeInstances { get; set; }
	public int alphamapLayers { get; }
	public int alphamapResolution { get; set; }
	private int Internal_alphamapResolution { get; set; }
	public int alphamapWidth { get; }
	public int alphamapHeight { get; }
	public int baseMapResolution { set; }
	private int Internal_baseMapResolution { set; }
	public TerrainLayer[] terrainLayers { get; }
	internal Terrain[] users { get; }


	[StaticAccessorAttribute] // RVA: 0x7B490 Offset: 0x7A890 VA: 0x18007B490
	[ThreadSafeAttribute] // RVA: 0x7B490 Offset: 0x7A890 VA: 0x18007B490
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B5C0 Offset: 0x7A9C0 VA: 0x18007B5C0
	private static void Internal_Create(TerrainData terrainData) { }

	public int get_heightmapResolution() { }

	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B860 Offset: 0x7AC60 VA: 0x18007B860
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B8F0 Offset: 0x7ACF0 VA: 0x18007B8F0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BB10 Offset: 0x7AF10 VA: 0x18007BB10
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BC00 Offset: 0x7B000 VA: 0x18007BC00
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BD60 Offset: 0x7B160 VA: 0x18007BD60
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BE60 Offset: 0x7B260 VA: 0x18007BE60
	public float GetHeight(int x, int y) { }

	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7C020 Offset: 0x7B420 VA: 0x18007C020
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C0C0 Offset: 0x7B4C0 VA: 0x18007C0C0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C1C0 Offset: 0x7B5C0 VA: 0x18007C1C0
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C250 Offset: 0x7B650 VA: 0x18007C250
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C400 Offset: 0x7B800 VA: 0x18007C400
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4C0 Offset: 0x7B8C0 VA: 0x18007C4C0
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	public TreeInstance[] get_treeInstances() { }

	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C680 Offset: 0x7BA80 VA: 0x18007C680
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C760 Offset: 0x7BB60 VA: 0x18007C760
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C9C0 Offset: 0x7BDC0 VA: 0x18007C9C0
	public int get_alphamapLayers() { }

	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7CA80 Offset: 0x7BE80 VA: 0x18007CA80
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	public int get_alphamapResolution() { }

	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CE00 Offset: 0x7C200 VA: 0x18007CE00
	[NativeNameAttribute] // RVA: 0x7CE00 Offset: 0x7C200 VA: 0x18007CE00
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CEF0 Offset: 0x7C2F0 VA: 0x18007CEF0
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7D000 Offset: 0x7C400 VA: 0x18007D000
	private void set_Internal_alphamapResolution(int value) { }

	public int get_alphamapWidth() { }

	public int get_alphamapHeight() { }

	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7D070 Offset: 0x7C470 VA: 0x18007D070
	private void set_Internal_baseMapResolution(int value) { }

	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D100 Offset: 0x7C500 VA: 0x18007D100
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	public TerrainLayer[] get_terrainLayers() { }

	internal Terrain[] get_users() { }

	private static void .cctor() { }

	private void get_heightmapScale_Injected(out Vector3 ret) { }

	private void get_size_Injected(out Vector3 ret) { }

	private void set_size_Injected(ref Vector3 value) { }

	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

}

private enum TerrainData.BoundaryValueType // TypeDefIndex: 4094
{	public int value__; // 0x0
	public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
	public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
	public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
	public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
	public const TerrainData.BoundaryValueType MaxDetailsPerRes = 4;
	public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
	public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
	public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
	public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;

}

