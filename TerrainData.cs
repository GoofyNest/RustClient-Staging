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

	[StaticAccessorAttribute] // RVA: 0x7B290 Offset: 0x7A690 VA: 0x18007B290
	[ThreadSafeAttribute] // RVA: 0x7B290 Offset: 0x7A690 VA: 0x18007B290
	// RVA: 0x22BF370 Offset: 0x22BD970 VA: 0x1822BF370
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x22C0090 Offset: 0x22BE690 VA: 0x1822C0090
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B440 Offset: 0x7A840 VA: 0x18007B440
	// RVA: 0x22BF680 Offset: 0x22BDC80 VA: 0x1822BF680
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	public int get_heightmapResolution() { }

	// RVA: 0x22C0C30 Offset: 0x22BF230 VA: 0x1822C0C30
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B730 Offset: 0x7AB30 VA: 0x18007B730
	// RVA: 0x22C0230 Offset: 0x22BE830 VA: 0x1822C0230
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B800 Offset: 0x7AC00 VA: 0x18007B800
	// RVA: 0x22C0DA0 Offset: 0x22BF3A0 VA: 0x1822C0DA0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	// RVA: 0x22C02C0 Offset: 0x22BE8C0 VA: 0x1822C02C0
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7BA50 Offset: 0x7AE50 VA: 0x18007BA50
	// RVA: 0x22C0360 Offset: 0x22BE960 VA: 0x1822C0360
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BB60 Offset: 0x7AF60 VA: 0x18007BB60
	// RVA: 0x22C0E30 Offset: 0x22BF430 VA: 0x1822C0E30
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	// RVA: 0x22BF410 Offset: 0x22BDA10 VA: 0x1822BF410
	public float GetHeight(int x, int y) { }

	// RVA: 0x22BF460 Offset: 0x22BDA60 VA: 0x1822BF460
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BDD0 Offset: 0x7B1D0 VA: 0x18007BDD0
	// RVA: 0x22BF720 Offset: 0x22BDD20 VA: 0x1822BF720
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x22BFB30 Offset: 0x22BE130 VA: 0x1822BFB30
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BE40 Offset: 0x7B240 VA: 0x18007BE40
	// RVA: 0x22BF880 Offset: 0x22BDE80 VA: 0x1822BF880
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7BF10 Offset: 0x7B310 VA: 0x18007BF10
	// RVA: 0x22BF610 Offset: 0x22BDC10 VA: 0x1822BF610
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	// RVA: 0x22C01F0 Offset: 0x22BE7F0 VA: 0x1822C01F0
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C0F0 Offset: 0x7B4F0 VA: 0x18007C0F0
	// RVA: 0x22C01B0 Offset: 0x22BE7B0 VA: 0x1822C01B0
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C320 Offset: 0x7B720 VA: 0x18007C320
	// RVA: 0x22BF3B0 Offset: 0x22BD9B0 VA: 0x1822BF3B0
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x22BFA70 Offset: 0x22BE070 VA: 0x1822BFA70
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C3E0 Offset: 0x7B7E0 VA: 0x18007C3E0
	// RVA: 0x22BF820 Offset: 0x22BDE20 VA: 0x1822BF820
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x22BF780 Offset: 0x22BDD80 VA: 0x1822BF780
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x22C0E80 Offset: 0x22BF480 VA: 0x1822C0E80
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C570 Offset: 0x7B970 VA: 0x18007C570
	// RVA: 0x22BF780 Offset: 0x22BDD80 VA: 0x1822BF780
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C600 Offset: 0x7BA00 VA: 0x18007C600
	// RVA: 0x22BFE20 Offset: 0x22BE420 VA: 0x1822BFE20
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C800 Offset: 0x7BC00 VA: 0x18007C800
	// RVA: 0x22C0170 Offset: 0x22BE770 VA: 0x1822C0170
	public int get_alphamapLayers() { }

	// RVA: 0x22BF2A0 Offset: 0x22BD8A0 VA: 0x1822BF2A0
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C920 Offset: 0x7BD20 VA: 0x18007C920
	// RVA: 0x22BF6C0 Offset: 0x22BDCC0 VA: 0x1822BF6C0
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x22C0130 Offset: 0x22BE730 VA: 0x1822C0130
	public int get_alphamapResolution() { }

	// RVA: 0x22C04B0 Offset: 0x22BEAB0 VA: 0x1822C04B0
	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CCA0 Offset: 0x7C0A0 VA: 0x18007CCA0
	[NativeNameAttribute] // RVA: 0x7CCA0 Offset: 0x7C0A0 VA: 0x18007CCA0
	// RVA: 0x22BF260 Offset: 0x22BD860 VA: 0x1822BF260
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	// RVA: 0x22C0130 Offset: 0x22BE730 VA: 0x1822C0130
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CE50 Offset: 0x7C250 VA: 0x18007CE50
	// RVA: 0x22C0430 Offset: 0x22BEA30 VA: 0x1822C0430
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x22C0130 Offset: 0x22BE730 VA: 0x1822C0130
	public int get_alphamapWidth() { }

	// RVA: 0x22C0130 Offset: 0x22BE730 VA: 0x1822C0130
	public int get_alphamapHeight() { }

	// RVA: 0x22C0870 Offset: 0x22BEE70 VA: 0x1822C0870
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CEC0 Offset: 0x7C2C0 VA: 0x18007CEC0
	// RVA: 0x22C0470 Offset: 0x22BEA70 VA: 0x1822C0470
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x22BF8E0 Offset: 0x22BDEE0 VA: 0x1822BF8E0
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CF50 Offset: 0x7C350 VA: 0x18007CF50
	// RVA: 0x22BF7C0 Offset: 0x22BDDC0 VA: 0x1822BF7C0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7D0A0 Offset: 0x7C4A0 VA: 0x18007D0A0
	// RVA: 0x22C03B0 Offset: 0x22BE9B0 VA: 0x1822C03B0
	public TerrainLayer[] get_terrainLayers() { }

	// RVA: 0x22C03F0 Offset: 0x22BE9F0 VA: 0x1822C03F0
	internal Terrain[] get_users() { }

	// RVA: 0x22BFE80 Offset: 0x22BE480 VA: 0x1822BFE80
	private static void .cctor() { }

	// RVA: 0x22C0270 Offset: 0x22BE870 VA: 0x1822C0270
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x22C0310 Offset: 0x22BE910 VA: 0x1822C0310
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x22C0DE0 Offset: 0x22BF3E0 VA: 0x1822C0DE0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x22BF5A0 Offset: 0x22BDBA0 VA: 0x1822BF5A0
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

