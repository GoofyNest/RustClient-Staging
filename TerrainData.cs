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
	// RVA: 0x22BFC90 Offset: 0x22BE290 VA: 0x1822BFC90
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x22C09B0 Offset: 0x22BEFB0 VA: 0x1822C09B0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	// RVA: 0x22BFFA0 Offset: 0x22BE5A0 VA: 0x1822BFFA0
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x22C0B50 Offset: 0x22BF150 VA: 0x1822C0B50
	public int get_heightmapResolution() { }

	// RVA: 0x22C1550 Offset: 0x22BFB50 VA: 0x1822C1550
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B810 Offset: 0x7AC10 VA: 0x18007B810
	// RVA: 0x22C0B50 Offset: 0x22BF150 VA: 0x1822C0B50
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B890 Offset: 0x7AC90 VA: 0x18007B890
	// RVA: 0x22C16C0 Offset: 0x22BFCC0 VA: 0x1822C16C0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7BAA0 Offset: 0x7AEA0 VA: 0x18007BAA0
	// RVA: 0x22C0BE0 Offset: 0x22BF1E0 VA: 0x1822C0BE0
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BB20 Offset: 0x7AF20 VA: 0x18007BB20
	// RVA: 0x22C0C80 Offset: 0x22BF280 VA: 0x1822C0C80
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BC80 Offset: 0x7B080 VA: 0x18007BC80
	// RVA: 0x22C1750 Offset: 0x22BFD50 VA: 0x1822C1750
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BD80 Offset: 0x7B180 VA: 0x18007BD80
	// RVA: 0x22BFD30 Offset: 0x22BE330 VA: 0x1822BFD30
	public float GetHeight(int x, int y) { }

	// RVA: 0x22BFD80 Offset: 0x22BE380 VA: 0x1822BFD80
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BED0 Offset: 0x7B2D0 VA: 0x18007BED0
	// RVA: 0x22C0040 Offset: 0x22BE640 VA: 0x1822C0040
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x22C0450 Offset: 0x22BEA50 VA: 0x1822C0450
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BF40 Offset: 0x7B340 VA: 0x18007BF40
	// RVA: 0x22C01A0 Offset: 0x22BE7A0 VA: 0x1822C01A0
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	// RVA: 0x22BFF30 Offset: 0x22BE530 VA: 0x1822BFF30
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C110 Offset: 0x7B510 VA: 0x18007C110
	// RVA: 0x22C0B10 Offset: 0x22BF110 VA: 0x1822C0B10
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C1C0 Offset: 0x7B5C0 VA: 0x18007C1C0
	// RVA: 0x22C0AD0 Offset: 0x22BF0D0 VA: 0x1822C0AD0
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C3F0 Offset: 0x7B7F0 VA: 0x18007C3F0
	// RVA: 0x22BFCD0 Offset: 0x22BE2D0 VA: 0x1822BFCD0
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x22C0390 Offset: 0x22BE990 VA: 0x1822C0390
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C4B0 Offset: 0x7B8B0 VA: 0x18007C4B0
	// RVA: 0x22C0140 Offset: 0x22BE740 VA: 0x1822C0140
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x22C00A0 Offset: 0x22BE6A0 VA: 0x1822C00A0
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x22C17A0 Offset: 0x22BFDA0 VA: 0x1822C17A0
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x22C00A0 Offset: 0x22BE6A0 VA: 0x1822C00A0
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C6D0 Offset: 0x7BAD0 VA: 0x18007C6D0
	// RVA: 0x22C0740 Offset: 0x22BED40 VA: 0x1822C0740
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C910 Offset: 0x7BD10 VA: 0x18007C910
	// RVA: 0x22C0A90 Offset: 0x22BF090 VA: 0x1822C0A90
	public int get_alphamapLayers() { }

	// RVA: 0x22BFBC0 Offset: 0x22BE1C0 VA: 0x1822BFBC0
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C9A0 Offset: 0x7BDA0 VA: 0x18007C9A0
	// RVA: 0x22BFFE0 Offset: 0x22BE5E0 VA: 0x1822BFFE0
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x22C0A50 Offset: 0x22BF050 VA: 0x1822C0A50
	public int get_alphamapResolution() { }

	// RVA: 0x22C0DD0 Offset: 0x22BF3D0 VA: 0x1822C0DD0
	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[NativeNameAttribute] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	// RVA: 0x22BFB80 Offset: 0x22BE180 VA: 0x1822BFB80
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CE10 Offset: 0x7C210 VA: 0x18007CE10
	// RVA: 0x22C0A50 Offset: 0x22BF050 VA: 0x1822C0A50
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CF20 Offset: 0x7C320 VA: 0x18007CF20
	// RVA: 0x22C0D50 Offset: 0x22BF350 VA: 0x1822C0D50
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x22C0A50 Offset: 0x22BF050 VA: 0x1822C0A50
	public int get_alphamapWidth() { }

	// RVA: 0x22C0A50 Offset: 0x22BF050 VA: 0x1822C0A50
	public int get_alphamapHeight() { }

	// RVA: 0x22C1190 Offset: 0x22BF790 VA: 0x1822C1190
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	// RVA: 0x22C0D90 Offset: 0x22BF390 VA: 0x1822C0D90
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x22C0200 Offset: 0x22BE800 VA: 0x1822C0200
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D020 Offset: 0x7C420 VA: 0x18007D020
	// RVA: 0x22C00E0 Offset: 0x22BE6E0 VA: 0x1822C00E0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D170 Offset: 0x7C570 VA: 0x18007D170
	// RVA: 0x22C0CD0 Offset: 0x22BF2D0 VA: 0x1822C0CD0
	public TerrainLayer[] get_terrainLayers() { }

	// RVA: 0x22C0D10 Offset: 0x22BF310 VA: 0x1822C0D10
	internal Terrain[] get_users() { }

	// RVA: 0x22C07A0 Offset: 0x22BEDA0 VA: 0x1822C07A0
	private static void .cctor() { }

	// RVA: 0x22C0B90 Offset: 0x22BF190 VA: 0x1822C0B90
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x22C0C30 Offset: 0x22BF230 VA: 0x1822C0C30
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x22C1700 Offset: 0x22BFD00 VA: 0x1822C1700
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x22BFEC0 Offset: 0x22BE4C0 VA: 0x1822BFEC0
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

