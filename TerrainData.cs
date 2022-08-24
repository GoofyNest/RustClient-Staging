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


	[StaticAccessorAttribute] // RVA: 0x7B4C0 Offset: 0x7A8C0 VA: 0x18007B4C0
	[ThreadSafeAttribute] // RVA: 0x7B4C0 Offset: 0x7A8C0 VA: 0x18007B4C0
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B5C0 Offset: 0x7A9C0 VA: 0x18007B5C0
	private static void Internal_Create(TerrainData terrainData) { }

	public int get_heightmapResolution() { }

	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B800 Offset: 0x7AC00 VA: 0x18007B800
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B830 Offset: 0x7AC30 VA: 0x18007B830
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BA00 Offset: 0x7AE00 VA: 0x18007BA00
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BAB0 Offset: 0x7AEB0 VA: 0x18007BAB0
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BC10 Offset: 0x7B010 VA: 0x18007BC10
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BD60 Offset: 0x7B160 VA: 0x18007BD60
	public float GetHeight(int x, int y) { }

	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BF30 Offset: 0x7B330 VA: 0x18007BF30
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BFF0 Offset: 0x7B3F0 VA: 0x18007BFF0
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C0E0 Offset: 0x7B4E0 VA: 0x18007C0E0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C1E0 Offset: 0x7B5E0 VA: 0x18007C1E0
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C270 Offset: 0x7B670 VA: 0x18007C270
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C420 Offset: 0x7B820 VA: 0x18007C420
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4E0 Offset: 0x7B8E0 VA: 0x18007C4E0
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	public TreeInstance[] get_treeInstances() { }

	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C620 Offset: 0x7BA20 VA: 0x18007C620
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C6B0 Offset: 0x7BAB0 VA: 0x18007C6B0
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C8C0 Offset: 0x7BCC0 VA: 0x18007C8C0
	public int get_alphamapLayers() { }

	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C950 Offset: 0x7BD50 VA: 0x18007C950
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	public int get_alphamapResolution() { }

	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CCD0 Offset: 0x7C0D0 VA: 0x18007CCD0
	[NativeNameAttribute] // RVA: 0x7CCD0 Offset: 0x7C0D0 VA: 0x18007CCD0
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CDC0 Offset: 0x7C1C0 VA: 0x18007CDC0
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CED0 Offset: 0x7C2D0 VA: 0x18007CED0
	private void set_Internal_alphamapResolution(int value) { }

	public int get_alphamapWidth() { }

	public int get_alphamapHeight() { }

	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CF40 Offset: 0x7C340 VA: 0x18007CF40
	private void set_Internal_baseMapResolution(int value) { }

	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CFD0 Offset: 0x7C3D0 VA: 0x18007CFD0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D120 Offset: 0x7C520 VA: 0x18007D120
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

