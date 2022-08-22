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


	[StaticAccessorAttribute] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[ThreadSafeAttribute] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	private static void Internal_Create(TerrainData terrainData) { }

	public int get_heightmapResolution() { }

	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B810 Offset: 0x7AC10 VA: 0x18007B810
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B890 Offset: 0x7AC90 VA: 0x18007B890
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BAA0 Offset: 0x7AEA0 VA: 0x18007BAA0
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BB20 Offset: 0x7AF20 VA: 0x18007BB20
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BC80 Offset: 0x7B080 VA: 0x18007BC80
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BD80 Offset: 0x7B180 VA: 0x18007BD80
	public float GetHeight(int x, int y) { }

	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BED0 Offset: 0x7B2D0 VA: 0x18007BED0
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BF40 Offset: 0x7B340 VA: 0x18007BF40
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C110 Offset: 0x7B510 VA: 0x18007C110
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C1C0 Offset: 0x7B5C0 VA: 0x18007C1C0
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C3F0 Offset: 0x7B7F0 VA: 0x18007C3F0
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4B0 Offset: 0x7B8B0 VA: 0x18007C4B0
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	public TreeInstance[] get_treeInstances() { }

	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C6D0 Offset: 0x7BAD0 VA: 0x18007C6D0
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C910 Offset: 0x7BD10 VA: 0x18007C910
	public int get_alphamapLayers() { }

	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C9A0 Offset: 0x7BDA0 VA: 0x18007C9A0
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	public int get_alphamapResolution() { }

	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[NativeNameAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CE10 Offset: 0x7C210 VA: 0x18007CE10
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CF20 Offset: 0x7C320 VA: 0x18007CF20
	private void set_Internal_alphamapResolution(int value) { }

	public int get_alphamapWidth() { }

	public int get_alphamapHeight() { }

	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	private void set_Internal_baseMapResolution(int value) { }

	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D020 Offset: 0x7C420 VA: 0x18007D020
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D170 Offset: 0x7C570 VA: 0x18007D170
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

