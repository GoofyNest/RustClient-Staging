public sealed class TerrainData : Object // TypeDefIndex: 4093
{	// Fields
	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
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

	// Properties
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

	// Methods

	[StaticAccessorAttribute] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[ThreadSafeAttribute] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	// RVA: 0x22BF470 Offset: 0x22BDA70 VA: 0x1822BF470
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x22C0190 Offset: 0x22BE790 VA: 0x1822C0190
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	// RVA: 0x22BF780 Offset: 0x22BDD80 VA: 0x1822BF780
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x22C0330 Offset: 0x22BE930 VA: 0x1822C0330
	public int get_heightmapResolution() { }

	// RVA: 0x22C0D30 Offset: 0x22BF330 VA: 0x1822C0D30
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B810 Offset: 0x7AC10 VA: 0x18007B810
	// RVA: 0x22C0330 Offset: 0x22BE930 VA: 0x1822C0330
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B890 Offset: 0x7AC90 VA: 0x18007B890
	// RVA: 0x22C0EA0 Offset: 0x22BF4A0 VA: 0x1822C0EA0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BAA0 Offset: 0x7AEA0 VA: 0x18007BAA0
	// RVA: 0x22C03C0 Offset: 0x22BE9C0 VA: 0x1822C03C0
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BB20 Offset: 0x7AF20 VA: 0x18007BB20
	// RVA: 0x22C0460 Offset: 0x22BEA60 VA: 0x1822C0460
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BC80 Offset: 0x7B080 VA: 0x18007BC80
	// RVA: 0x22C0F30 Offset: 0x22BF530 VA: 0x1822C0F30
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BD80 Offset: 0x7B180 VA: 0x18007BD80
	// RVA: 0x22BF510 Offset: 0x22BDB10 VA: 0x1822BF510
	public float GetHeight(int x, int y) { }

	// RVA: 0x22BF560 Offset: 0x22BDB60 VA: 0x1822BF560
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BED0 Offset: 0x7B2D0 VA: 0x18007BED0
	// RVA: 0x22BF820 Offset: 0x22BDE20 VA: 0x1822BF820
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x22BFC30 Offset: 0x22BE230 VA: 0x1822BFC30
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BF40 Offset: 0x7B340 VA: 0x18007BF40
	// RVA: 0x22BF980 Offset: 0x22BDF80 VA: 0x1822BF980
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	// RVA: 0x22BF710 Offset: 0x22BDD10 VA: 0x1822BF710
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C110 Offset: 0x7B510 VA: 0x18007C110
	// RVA: 0x22C02F0 Offset: 0x22BE8F0 VA: 0x1822C02F0
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C1C0 Offset: 0x7B5C0 VA: 0x18007C1C0
	// RVA: 0x22C02B0 Offset: 0x22BE8B0 VA: 0x1822C02B0
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C3F0 Offset: 0x7B7F0 VA: 0x18007C3F0
	// RVA: 0x22BF4B0 Offset: 0x22BDAB0 VA: 0x1822BF4B0
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x22BFB70 Offset: 0x22BE170 VA: 0x1822BFB70
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4B0 Offset: 0x7B8B0 VA: 0x18007C4B0
	// RVA: 0x22BF920 Offset: 0x22BDF20 VA: 0x1822BF920
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x22BF880 Offset: 0x22BDE80 VA: 0x1822BF880
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x22C0F80 Offset: 0x22BF580 VA: 0x1822C0F80
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x22BF880 Offset: 0x22BDE80 VA: 0x1822BF880
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C6D0 Offset: 0x7BAD0 VA: 0x18007C6D0
	// RVA: 0x22BFF20 Offset: 0x22BE520 VA: 0x1822BFF20
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C910 Offset: 0x7BD10 VA: 0x18007C910
	// RVA: 0x22C0270 Offset: 0x22BE870 VA: 0x1822C0270
	public int get_alphamapLayers() { }

	// RVA: 0x22BF3A0 Offset: 0x22BD9A0 VA: 0x1822BF3A0
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C9A0 Offset: 0x7BDA0 VA: 0x18007C9A0
	// RVA: 0x22BF7C0 Offset: 0x22BDDC0 VA: 0x1822BF7C0
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	public int get_alphamapResolution() { }

	// RVA: 0x22C05B0 Offset: 0x22BEBB0 VA: 0x1822C05B0
	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[NativeNameAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	// RVA: 0x22BF360 Offset: 0x22BD960 VA: 0x1822BF360
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CE10 Offset: 0x7C210 VA: 0x18007CE10
	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CF20 Offset: 0x7C320 VA: 0x18007CF20
	// RVA: 0x22C0530 Offset: 0x22BEB30 VA: 0x1822C0530
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	public int get_alphamapWidth() { }

	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	public int get_alphamapHeight() { }

	// RVA: 0x22C0970 Offset: 0x22BEF70 VA: 0x1822C0970
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	// RVA: 0x22C0570 Offset: 0x22BEB70 VA: 0x1822C0570
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x22BF9E0 Offset: 0x22BDFE0 VA: 0x1822BF9E0
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D020 Offset: 0x7C420 VA: 0x18007D020
	// RVA: 0x22BF8C0 Offset: 0x22BDEC0 VA: 0x1822BF8C0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D170 Offset: 0x7C570 VA: 0x18007D170
	// RVA: 0x22C04B0 Offset: 0x22BEAB0 VA: 0x1822C04B0
	public TerrainLayer[] get_terrainLayers() { }

	// RVA: 0x22C04F0 Offset: 0x22BEAF0 VA: 0x1822C04F0
	internal Terrain[] get_users() { }

	// RVA: 0x22BFF80 Offset: 0x22BE580 VA: 0x1822BFF80
	private static void .cctor() { }

	// RVA: 0x22C0370 Offset: 0x22BE970 VA: 0x1822C0370
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x22C0410 Offset: 0x22BEA10 VA: 0x1822C0410
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x22C0EE0 Offset: 0x22BF4E0 VA: 0x1822C0EE0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x22BF6A0 Offset: 0x22BDCA0 VA: 0x1822BF6A0
	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

}

private enum TerrainData.BoundaryValueType // TypeDefIndex: 4094
{	// Fields
	public int value__; // 0x0
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

