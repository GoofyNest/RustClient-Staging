public class TerrainTexturing : TerrainExtension // TypeDefIndex: 10432
{	// Fields
	private const int MaxBasePyramidSize = 4096;
	private TextureCacheState pyramidCacheState; // 0x30
	private RenderTexture diffuseBasePyramidTexture; // 0x38
	private const int CoarseHeightDownscale = 1;
	private const int CoarseSlopeBlurPasses = 4;
	private const float CoarseSlopeBlurRadius = 1;
	private TextureCacheState coarseHeightSlopeCacheState; // 0x40
	private RenderTexture coarseHeightSlopeTexture; // 0x48
	private const int ShoreVectorDownscale = 3;
	private const int ShoreVectorBlurPasses = 0;
	private float terrainSize; // 0x50
	private int shoreMapSize; // 0x54
	private float[] shoreDistances; // 0x58
	private Vector3[] shoreVectors; // 0x60
	private Texture2D shoreVectorTexture; // 0x68
	public bool debugFoliageDisplacement; // 0x70
	private bool initialized; // 0x71
	private static TerrainTexturing instance; // 0x0
	private bool prevDebugFoliageDisplacement; // 0x72
	private int prevQuality; // 0x74
	private bool triggerUpdateGlobalParams; // 0x78
	private int[,] PID_Layer; // 0x80
	private static int PID_NaN; // 0x8
	private static int PID_Terrain_Control0; // 0xC
	private static int PID_Terrain_Control1; // 0x10
	private static int PID_Terrain_TextureArray0; // 0x14
	private static int PID_Terrain_TextureArray1; // 0x18
	private static int PID_Terrain_HeightSlope; // 0x1C
	private static int PID_Terrain_ShoreVector; // 0x20
	private static int PID_Terrain_Position; // 0x24
	private static int PID_Terrain_Size; // 0x28
	private static int PID_Terrain_RcpSize; // 0x2C
	private static int PID_Terrain_TexelSize; // 0x30
	private static int PID_Terrain_TexelSize0; // 0x34
	private static int PID_Terrain_TexelSize1; // 0x38
	private static int PID_TerrainParallax; // 0x3C
	private static int PID_TerrainPotatoDetailTexture; // 0x40
	private static int PID_TerrainPotatoDetailWorldUVScale; // 0x44
	private static int PID_PotatoDetailTexture; // 0x48
	private static int PID_PotatoDetailWorldUVScale; // 0x4C
	private static int PID_UVMIXMult; // 0x50
	private static int PID_UVMIXStart; // 0x54
	private static int PID_UVMIXDist; // 0x58
	private static int PID_LayerFallback_Albedo; // 0x5C
	private static int PID_LayerFallback_Metallic; // 0x60
	private static int PID_LayerFallback_Smoothness; // 0x64

	// Properties
	public RenderTexture DiffuseBasePyramidTexture { get; }
	public RenderTexture CoarseHeightSlopeTexture { get; }
	public int ShoreMapSize { get; }
	public Vector3[] ShoreMap { get; }
	public Texture2D ShoreVectorTexture { get; }
	public static TerrainTexturing Instance { get; }

	// Methods

	// RVA: 0x87ED00 Offset: 0x87D300 VA: 0x18087ED00
	private void InitializeBasePyramid() { }

	// RVA: 0x87F2B0 Offset: 0x87D8B0 VA: 0x18087F2B0
	private void ReleaseBasePyramid() { }

	// RVA: 0x87F6F0 Offset: 0x87DCF0 VA: 0x18087F6F0
	private void UpdateBasePyramid() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public RenderTexture get_DiffuseBasePyramidTexture() { }

	// RVA: 0x87D8A0 Offset: 0x87BEA0 VA: 0x18087D8A0
	private RenderTexture CreateBasePyramidRT(string name, int size, bool linear) { }

	// RVA: 0x87EBB0 Offset: 0x87D1B0 VA: 0x18087EBB0
	private void InitializeBasePyramidTexture() { }

	// RVA: 0x87F2B0 Offset: 0x87D8B0 VA: 0x18087F2B0
	private void ReleaseBasePyramidTexture() { }

	// RVA: 0x87CC40 Offset: 0x87B240 VA: 0x18087CC40
	private void CacheBasePyramidTexture() { }

	// RVA: 0x87F520 Offset: 0x87DB20 VA: 0x18087F520
	private void UpdateBasePyramidShaderConstants() { }

	// RVA: 0x87F560 Offset: 0x87DB60 VA: 0x18087F560
	private void UpdateBasePyramidTexture() { }

	// RVA: 0x87D780 Offset: 0x87BD80 VA: 0x18087D780
	private bool CheckLostBasePyramidTexture() { }

	// RVA: 0x87EE80 Offset: 0x87D480 VA: 0x18087EE80
	private void InitializeCoarseHeightSlope() { }

	// RVA: 0x87F2E0 Offset: 0x87D8E0 VA: 0x18087F2E0
	private void ReleaseCoarseHeightSlope() { }

	// RVA: 0x87F700 Offset: 0x87DD00 VA: 0x18087F700
	private void UpdateCoarseHeightSlope() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public RenderTexture get_CoarseHeightSlopeTexture() { }

	// RVA: 0x87ED10 Offset: 0x87D310 VA: 0x18087ED10
	private void InitializeCoarseHeightSlopeTexture() { }

	// RVA: 0x87F2E0 Offset: 0x87D8E0 VA: 0x18087F2E0
	private void ReleaseCoarseHeightSlopeTexture() { }

	// RVA: 0x87CE50 Offset: 0x87B450 VA: 0x18087CE50
	private void CacheCoarseHeightSlopeTexture() { }

	// RVA: 0x87F700 Offset: 0x87DD00 VA: 0x18087F700
	private void UpdateCoarseHeightSlopeTexture() { }

	// RVA: 0x87D810 Offset: 0x87BE10 VA: 0x18087D810
	private bool CheckLostCoarseHeightSlopeTexture() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public int get_ShoreMapSize() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Vector3[] get_ShoreMap() { }

	// RVA: 0x87EE90 Offset: 0x87D490 VA: 0x18087EE90
	private void InitializeShoreVector() { }

	// RVA: 0x87DDC0 Offset: 0x87C3C0 VA: 0x18087DDC0
	private void GenerateShoreVector() { }

	// RVA: 0x87F330 Offset: 0x87D930 VA: 0x18087F330
	private void ReleaseShoreVector() { }

	// RVA: 0x87DEA0 Offset: 0x87C4A0 VA: 0x18087DEA0
	private void GenerateShoreVector(out float[] distances, out Vector3[] vectors) { }

	// RVA: 0x87E490 Offset: 0x87CA90 VA: 0x18087E490
	public float GetCoarseDistanceToShore(Vector3 pos) { }

	// RVA: 0x87E5E0 Offset: 0x87CBE0 VA: 0x18087E5E0
	public float GetCoarseDistanceToShore(Vector2 uv) { }

	// RVA: 0x87E730 Offset: 0x87CD30 VA: 0x18087E730
	public Vector3 GetCoarseVectorToShore(Vector3 pos) { }

	// RVA: 0x87E8B0 Offset: 0x87CEB0 VA: 0x18087E8B0
	public Vector3 GetCoarseVectorToShore(Vector2 uv) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public Texture2D get_ShoreVectorTexture() { }

	// RVA: 0x87DBF0 Offset: 0x87C1F0 VA: 0x18087DBF0
	private void GenerateShoreVectorTexture(int size) { }

	// RVA: 0x87F2F0 Offset: 0x87D8F0 VA: 0x18087F2F0
	private void ReleaseShoreVectorTexture() { }

	// RVA: 0x8818D0 Offset: 0x87FED0 VA: 0x1808818D0
	public static TerrainTexturing get_Instance() { }

	// RVA: 0x87D680 Offset: 0x87BC80 VA: 0x18087D680
	private void CheckInstance() { }

	// RVA: 0x87CC30 Offset: 0x87B230 VA: 0x18087CC30
	private void Awake() { }

	// RVA: 0x87F460 Offset: 0x87DA60 VA: 0x18087F460 Slot: 4
	public override void Setup() { }

	// RVA: 0x87F120 Offset: 0x87D720 VA: 0x18087F120 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x87F470 Offset: 0x87DA70 VA: 0x18087F470
	private void Shutdown() { }

	// RVA: 0x87CC30 Offset: 0x87B230 VA: 0x18087CC30
	private void OnEnable() { }

	// RVA: 0x87F0B0 Offset: 0x87D6B0 VA: 0x18087F0B0
	private void OnDisable() { }

	// RVA: 0x880AD0 Offset: 0x87F0D0 VA: 0x180880AD0
	private void Update() { }

	// RVA: 0x87D9D0 Offset: 0x87BFD0 VA: 0x18087D9D0
	private Material CreateMaterial(string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T mat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4380 Offset: 0x5D2980 VA: 0x1805D4380
	|-TerrainTexturing.SafeDestroy<object>
	|-TerrainTexturing.SafeDestroy<Material>
	|-TerrainTexturing.SafeDestroy<Texture2D>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4420 Offset: 0x5D2A20 VA: 0x1805D4420
	|-TerrainTexturing.SafeDispose<object>
	*/

	// RVA: 0x87F3A0 Offset: 0x87D9A0 VA: 0x18087F3A0
	private void SafeDestroyRT(ref RenderTexture rtex) { }

	// RVA: 0x87DA50 Offset: 0x87C050 VA: 0x18087DA50
	private Texture2D CreateTex(string name, int width, int height, TextureFormat format, bool mips, bool linear) { }

	// RVA: 0x87DB40 Offset: 0x87C140 VA: 0x18087DB40
	private void DestroyTex(ref Texture2D tex) { }

	// RVA: 0x880CA0 Offset: 0x87F2A0 VA: 0x180880CA0
	private void WarmupStrings() { }

	// RVA: 0x87F8D0 Offset: 0x87DED0 VA: 0x18087F8D0
	private void UpdateTerrainShaderConstants() { }

	// RVA: 0x87F810 Offset: 0x87DE10 VA: 0x18087F810
	private void UpdateFoliageDisplaceShaderConstants() { }

	// RVA: 0x87F850 Offset: 0x87DE50 VA: 0x18087F850
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0x880760 Offset: 0x87ED60 VA: 0x180880760
	private void UpdateTerrainToGlobal() { }

	// RVA: 0x87F510 Offset: 0x87DB10 VA: 0x18087F510
	public void TriggerUpdateGlobalParams() { }

	// RVA: 0x87F500 Offset: 0x87DB00 VA: 0x18087F500
	public void TriggerBasePyramidUpdate() { }

	// RVA: 0x8818B0 Offset: 0x87FEB0 VA: 0x1808818B0
	public void .ctor() { }

	// RVA: 0x8815A0 Offset: 0x87FBA0 VA: 0x1808815A0
	private static void .cctor() { }

}

private enum TerrainTexturing.LayerPropID // TypeDefIndex: 10433
{	// Fields
	public int value__; // 0x0
	public const TerrainTexturing.LayerPropID UVMIX = 0;
	public const TerrainTexturing.LayerPropID AridColor = 1;
	public const TerrainTexturing.LayerPropID TemperateColor = 2;
	public const TerrainTexturing.LayerPropID TundraColor = 3;
	public const TerrainTexturing.LayerPropID ArcticColor = 4;
	public const TerrainTexturing.LayerPropID AridOverlayColor = 5;
	public const TerrainTexturing.LayerPropID TemperateOverlayColor = 6;
	public const TerrainTexturing.LayerPropID TundraOverlayColor = 7;
	public const TerrainTexturing.LayerPropID ArcticOverlayColor = 8;
	public const TerrainTexturing.LayerPropID AridOverlayParam = 9;
	public const TerrainTexturing.LayerPropID TemperateOverlayParam = 10;
	public const TerrainTexturing.LayerPropID TundraOverlayParam = 11;
	public const TerrainTexturing.LayerPropID ArcticOverlayParam = 12;
	public const TerrainTexturing.LayerPropID Metallic = 13;
	public const TerrainTexturing.LayerPropID Factor = 14;
	public const TerrainTexturing.LayerPropID Falloff = 15;
	public const TerrainTexturing.LayerPropID COUNT = 16;

}

private sealed class TerrainTexturing.<>c__DisplayClass27_0 // TypeDefIndex: 10434
{	// Fields
	public int block; // 0x10
	public int dstsize; // 0x14
	public int srcsize; // 0x18
	public float hscale_s; // 0x1C
	public float ny; // 0x20
	public float hscale; // 0x24
	public float hoffset; // 0x28
	public Color[] pixels; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_1 // TypeDefIndex: 10435
{	// Fields
	public Color32[] heightColors; // 0x10
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F570 Offset: 0x88DB70 VA: 0x18088F570
	internal void <CacheCoarseHeightSlopeTexture>b__0(int dz) { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_2 // TypeDefIndex: 10436
{	// Fields
	public short[] heights; // 0x10
	public int heightres; // 0x18
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals2; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F9A0 Offset: 0x88DFA0 VA: 0x18088F9A0
	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

