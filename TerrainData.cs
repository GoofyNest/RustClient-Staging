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
	// RVA: 0x22BF1B0 Offset: 0x22BD7B0 VA: 0x1822BF1B0
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x22BFED0 Offset: 0x22BE4D0 VA: 0x1822BFED0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	// RVA: 0x22BF4C0 Offset: 0x22BDAC0 VA: 0x1822BF4C0
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x22C0070 Offset: 0x22BE670 VA: 0x1822C0070
	public int get_heightmapResolution() { }

	// RVA: 0x22C0A70 Offset: 0x22BF070 VA: 0x1822C0A70
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B810 Offset: 0x7AC10 VA: 0x18007B810
	// RVA: 0x22C0070 Offset: 0x22BE670 VA: 0x1822C0070
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B890 Offset: 0x7AC90 VA: 0x18007B890
	// RVA: 0x22C0BE0 Offset: 0x22BF1E0 VA: 0x1822C0BE0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BAA0 Offset: 0x7AEA0 VA: 0x18007BAA0
	// RVA: 0x22C0100 Offset: 0x22BE700 VA: 0x1822C0100
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BB20 Offset: 0x7AF20 VA: 0x18007BB20
	// RVA: 0x22C01A0 Offset: 0x22BE7A0 VA: 0x1822C01A0
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BC80 Offset: 0x7B080 VA: 0x18007BC80
	// RVA: 0x22C0C70 Offset: 0x22BF270 VA: 0x1822C0C70
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BD80 Offset: 0x7B180 VA: 0x18007BD80
	// RVA: 0x22BF250 Offset: 0x22BD850 VA: 0x1822BF250
	public float GetHeight(int x, int y) { }

	// RVA: 0x22BF2A0 Offset: 0x22BD8A0 VA: 0x1822BF2A0
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BED0 Offset: 0x7B2D0 VA: 0x18007BED0
	// RVA: 0x22BF560 Offset: 0x22BDB60 VA: 0x1822BF560
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x22BF970 Offset: 0x22BDF70 VA: 0x1822BF970
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BF40 Offset: 0x7B340 VA: 0x18007BF40
	// RVA: 0x22BF6C0 Offset: 0x22BDCC0 VA: 0x1822BF6C0
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	// RVA: 0x22BF450 Offset: 0x22BDA50 VA: 0x1822BF450
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C110 Offset: 0x7B510 VA: 0x18007C110
	// RVA: 0x22C0030 Offset: 0x22BE630 VA: 0x1822C0030
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C1C0 Offset: 0x7B5C0 VA: 0x18007C1C0
	// RVA: 0x22BFFF0 Offset: 0x22BE5F0 VA: 0x1822BFFF0
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C3F0 Offset: 0x7B7F0 VA: 0x18007C3F0
	// RVA: 0x22BF1F0 Offset: 0x22BD7F0 VA: 0x1822BF1F0
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x22BF8B0 Offset: 0x22BDEB0 VA: 0x1822BF8B0
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4B0 Offset: 0x7B8B0 VA: 0x18007C4B0
	// RVA: 0x22BF660 Offset: 0x22BDC60 VA: 0x1822BF660
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x22BF5C0 Offset: 0x22BDBC0 VA: 0x1822BF5C0
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x22C0CC0 Offset: 0x22BF2C0 VA: 0x1822C0CC0
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x22BF5C0 Offset: 0x22BDBC0 VA: 0x1822BF5C0
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C6D0 Offset: 0x7BAD0 VA: 0x18007C6D0
	// RVA: 0x22BFC60 Offset: 0x22BE260 VA: 0x1822BFC60
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C910 Offset: 0x7BD10 VA: 0x18007C910
	// RVA: 0x22BFFB0 Offset: 0x22BE5B0 VA: 0x1822BFFB0
	public int get_alphamapLayers() { }

	// RVA: 0x22BF0E0 Offset: 0x22BD6E0 VA: 0x1822BF0E0
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C9A0 Offset: 0x7BDA0 VA: 0x18007C9A0
	// RVA: 0x22BF500 Offset: 0x22BDB00 VA: 0x1822BF500
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x22BFF70 Offset: 0x22BE570 VA: 0x1822BFF70
	public int get_alphamapResolution() { }

	// RVA: 0x22C02F0 Offset: 0x22BE8F0 VA: 0x1822C02F0
	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[NativeNameAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	// RVA: 0x22BF0A0 Offset: 0x22BD6A0 VA: 0x1822BF0A0
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CE10 Offset: 0x7C210 VA: 0x18007CE10
	// RVA: 0x22BFF70 Offset: 0x22BE570 VA: 0x1822BFF70
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CF20 Offset: 0x7C320 VA: 0x18007CF20
	// RVA: 0x22C0270 Offset: 0x22BE870 VA: 0x1822C0270
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x22BFF70 Offset: 0x22BE570 VA: 0x1822BFF70
	public int get_alphamapWidth() { }

	// RVA: 0x22BFF70 Offset: 0x22BE570 VA: 0x1822BFF70
	public int get_alphamapHeight() { }

	// RVA: 0x22C06B0 Offset: 0x22BECB0 VA: 0x1822C06B0
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	// RVA: 0x22C02B0 Offset: 0x22BE8B0 VA: 0x1822C02B0
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x22BF720 Offset: 0x22BDD20 VA: 0x1822BF720
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D020 Offset: 0x7C420 VA: 0x18007D020
	// RVA: 0x22BF600 Offset: 0x22BDC00 VA: 0x1822BF600
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D170 Offset: 0x7C570 VA: 0x18007D170
	// RVA: 0x22C01F0 Offset: 0x22BE7F0 VA: 0x1822C01F0
	public TerrainLayer[] get_terrainLayers() { }

	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	internal Terrain[] get_users() { }

	// RVA: 0x22BFCC0 Offset: 0x22BE2C0 VA: 0x1822BFCC0
	private static void .cctor() { }

	// RVA: 0x22C00B0 Offset: 0x22BE6B0 VA: 0x1822C00B0
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x22C0150 Offset: 0x22BE750 VA: 0x1822C0150
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x22C0C20 Offset: 0x22BF220 VA: 0x1822C0C20
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x22BF3E0 Offset: 0x22BD9E0 VA: 0x1822BF3E0
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

