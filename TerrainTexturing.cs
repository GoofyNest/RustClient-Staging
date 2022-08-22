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

	// RVA: 0x87EE10 Offset: 0x87D410 VA: 0x18087EE10
	private void InitializeBasePyramid() { }

	// RVA: 0x87F3C0 Offset: 0x87D9C0 VA: 0x18087F3C0
	private void ReleaseBasePyramid() { }

	// RVA: 0x87F800 Offset: 0x87DE00 VA: 0x18087F800
	private void UpdateBasePyramid() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public RenderTexture get_DiffuseBasePyramidTexture() { }

	// RVA: 0x87D9B0 Offset: 0x87BFB0 VA: 0x18087D9B0
	private RenderTexture CreateBasePyramidRT(string name, int size, bool linear) { }

	// RVA: 0x87ECC0 Offset: 0x87D2C0 VA: 0x18087ECC0
	private void InitializeBasePyramidTexture() { }

	// RVA: 0x87F3C0 Offset: 0x87D9C0 VA: 0x18087F3C0
	private void ReleaseBasePyramidTexture() { }

	// RVA: 0x87CD50 Offset: 0x87B350 VA: 0x18087CD50
	private void CacheBasePyramidTexture() { }

	// RVA: 0x87F630 Offset: 0x87DC30 VA: 0x18087F630
	private void UpdateBasePyramidShaderConstants() { }

	// RVA: 0x87F670 Offset: 0x87DC70 VA: 0x18087F670
	private void UpdateBasePyramidTexture() { }

	// RVA: 0x87D890 Offset: 0x87BE90 VA: 0x18087D890
	private bool CheckLostBasePyramidTexture() { }

	// RVA: 0x87EF90 Offset: 0x87D590 VA: 0x18087EF90
	private void InitializeCoarseHeightSlope() { }

	// RVA: 0x87F3F0 Offset: 0x87D9F0 VA: 0x18087F3F0
	private void ReleaseCoarseHeightSlope() { }

	// RVA: 0x87F810 Offset: 0x87DE10 VA: 0x18087F810
	private void UpdateCoarseHeightSlope() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public RenderTexture get_CoarseHeightSlopeTexture() { }

	// RVA: 0x87EE20 Offset: 0x87D420 VA: 0x18087EE20
	private void InitializeCoarseHeightSlopeTexture() { }

	// RVA: 0x87F3F0 Offset: 0x87D9F0 VA: 0x18087F3F0
	private void ReleaseCoarseHeightSlopeTexture() { }

	// RVA: 0x87CF60 Offset: 0x87B560 VA: 0x18087CF60
	private void CacheCoarseHeightSlopeTexture() { }

	// RVA: 0x87F810 Offset: 0x87DE10 VA: 0x18087F810
	private void UpdateCoarseHeightSlopeTexture() { }

	// RVA: 0x87D920 Offset: 0x87BF20 VA: 0x18087D920
	private bool CheckLostCoarseHeightSlopeTexture() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public int get_ShoreMapSize() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Vector3[] get_ShoreMap() { }

	// RVA: 0x87EFA0 Offset: 0x87D5A0 VA: 0x18087EFA0
	private void InitializeShoreVector() { }

	// RVA: 0x87DED0 Offset: 0x87C4D0 VA: 0x18087DED0
	private void GenerateShoreVector() { }

	// RVA: 0x87F440 Offset: 0x87DA40 VA: 0x18087F440
	private void ReleaseShoreVector() { }

	// RVA: 0x87DFB0 Offset: 0x87C5B0 VA: 0x18087DFB0
	private void GenerateShoreVector(out float[] distances, out Vector3[] vectors) { }

	// RVA: 0x87E5A0 Offset: 0x87CBA0 VA: 0x18087E5A0
	public float GetCoarseDistanceToShore(Vector3 pos) { }

	// RVA: 0x87E6F0 Offset: 0x87CCF0 VA: 0x18087E6F0
	public float GetCoarseDistanceToShore(Vector2 uv) { }

	// RVA: 0x87E840 Offset: 0x87CE40 VA: 0x18087E840
	public Vector3 GetCoarseVectorToShore(Vector3 pos) { }

	// RVA: 0x87E9C0 Offset: 0x87CFC0 VA: 0x18087E9C0
	public Vector3 GetCoarseVectorToShore(Vector2 uv) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public Texture2D get_ShoreVectorTexture() { }

	// RVA: 0x87DD00 Offset: 0x87C300 VA: 0x18087DD00
	private void GenerateShoreVectorTexture(int size) { }

	// RVA: 0x87F400 Offset: 0x87DA00 VA: 0x18087F400
	private void ReleaseShoreVectorTexture() { }

	// RVA: 0x8819E0 Offset: 0x87FFE0 VA: 0x1808819E0
	public static TerrainTexturing get_Instance() { }

	// RVA: 0x87D790 Offset: 0x87BD90 VA: 0x18087D790
	private void CheckInstance() { }

	// RVA: 0x87CD40 Offset: 0x87B340 VA: 0x18087CD40
	private void Awake() { }

	// RVA: 0x87F570 Offset: 0x87DB70 VA: 0x18087F570 Slot: 4
	public override void Setup() { }

	// RVA: 0x87F230 Offset: 0x87D830 VA: 0x18087F230 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x87F580 Offset: 0x87DB80 VA: 0x18087F580
	private void Shutdown() { }

	// RVA: 0x87CD40 Offset: 0x87B340 VA: 0x18087CD40
	private void OnEnable() { }

	// RVA: 0x87F1C0 Offset: 0x87D7C0 VA: 0x18087F1C0
	private void OnDisable() { }

	// RVA: 0x880BE0 Offset: 0x87F1E0 VA: 0x180880BE0
	private void Update() { }

	// RVA: 0x87DAE0 Offset: 0x87C0E0 VA: 0x18087DAE0
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

	// RVA: 0x87F4B0 Offset: 0x87DAB0 VA: 0x18087F4B0
	private void SafeDestroyRT(ref RenderTexture rtex) { }

	// RVA: 0x87DB60 Offset: 0x87C160 VA: 0x18087DB60
	private Texture2D CreateTex(string name, int width, int height, TextureFormat format, bool mips, bool linear) { }

	// RVA: 0x87DC50 Offset: 0x87C250 VA: 0x18087DC50
	private void DestroyTex(ref Texture2D tex) { }

	// RVA: 0x880DB0 Offset: 0x87F3B0 VA: 0x180880DB0
	private void WarmupStrings() { }

	// RVA: 0x87F9E0 Offset: 0x87DFE0 VA: 0x18087F9E0
	private void UpdateTerrainShaderConstants() { }

	// RVA: 0x87F920 Offset: 0x87DF20 VA: 0x18087F920
	private void UpdateFoliageDisplaceShaderConstants() { }

	// RVA: 0x87F960 Offset: 0x87DF60 VA: 0x18087F960
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0x880870 Offset: 0x87EE70 VA: 0x180880870
	private void UpdateTerrainToGlobal() { }

	// RVA: 0x87F620 Offset: 0x87DC20 VA: 0x18087F620
	public void TriggerUpdateGlobalParams() { }

	// RVA: 0x87F610 Offset: 0x87DC10 VA: 0x18087F610
	public void TriggerBasePyramidUpdate() { }

	// RVA: 0x8819C0 Offset: 0x87FFC0 VA: 0x1808819C0
	public void .ctor() { }

	// RVA: 0x8816B0 Offset: 0x87FCB0 VA: 0x1808816B0
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

	// RVA: 0x88F680 Offset: 0x88DC80 VA: 0x18088F680
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

	// RVA: 0x88FAB0 Offset: 0x88E0B0 VA: 0x18088FAB0
	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

