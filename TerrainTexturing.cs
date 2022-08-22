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

	// RVA: 0x862150 Offset: 0x860750 VA: 0x180862150
	private void InitializeBasePyramid() { }

	// RVA: 0x862700 Offset: 0x860D00 VA: 0x180862700
	private void ReleaseBasePyramid() { }

	// RVA: 0x862B40 Offset: 0x861140 VA: 0x180862B40
	private void UpdateBasePyramid() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public RenderTexture get_DiffuseBasePyramidTexture() { }

	// RVA: 0x860CF0 Offset: 0x85F2F0 VA: 0x180860CF0
	private RenderTexture CreateBasePyramidRT(string name, int size, bool linear) { }

	// RVA: 0x862000 Offset: 0x860600 VA: 0x180862000
	private void InitializeBasePyramidTexture() { }

	// RVA: 0x862700 Offset: 0x860D00 VA: 0x180862700
	private void ReleaseBasePyramidTexture() { }

	// RVA: 0x860090 Offset: 0x85E690 VA: 0x180860090
	private void CacheBasePyramidTexture() { }

	// RVA: 0x862970 Offset: 0x860F70 VA: 0x180862970
	private void UpdateBasePyramidShaderConstants() { }

	// RVA: 0x8629B0 Offset: 0x860FB0 VA: 0x1808629B0
	private void UpdateBasePyramidTexture() { }

	// RVA: 0x860BD0 Offset: 0x85F1D0 VA: 0x180860BD0
	private bool CheckLostBasePyramidTexture() { }

	// RVA: 0x8622D0 Offset: 0x8608D0 VA: 0x1808622D0
	private void InitializeCoarseHeightSlope() { }

	// RVA: 0x862730 Offset: 0x860D30 VA: 0x180862730
	private void ReleaseCoarseHeightSlope() { }

	// RVA: 0x862B50 Offset: 0x861150 VA: 0x180862B50
	private void UpdateCoarseHeightSlope() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public RenderTexture get_CoarseHeightSlopeTexture() { }

	// RVA: 0x862160 Offset: 0x860760 VA: 0x180862160
	private void InitializeCoarseHeightSlopeTexture() { }

	// RVA: 0x862730 Offset: 0x860D30 VA: 0x180862730
	private void ReleaseCoarseHeightSlopeTexture() { }

	// RVA: 0x8602A0 Offset: 0x85E8A0 VA: 0x1808602A0
	private void CacheCoarseHeightSlopeTexture() { }

	// RVA: 0x862B50 Offset: 0x861150 VA: 0x180862B50
	private void UpdateCoarseHeightSlopeTexture() { }

	// RVA: 0x860C60 Offset: 0x85F260 VA: 0x180860C60
	private bool CheckLostCoarseHeightSlopeTexture() { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	public int get_ShoreMapSize() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Vector3[] get_ShoreMap() { }

	// RVA: 0x8622E0 Offset: 0x8608E0 VA: 0x1808622E0
	private void InitializeShoreVector() { }

	// RVA: 0x861210 Offset: 0x85F810 VA: 0x180861210
	private void GenerateShoreVector() { }

	// RVA: 0x862780 Offset: 0x860D80 VA: 0x180862780
	private void ReleaseShoreVector() { }

	// RVA: 0x8612F0 Offset: 0x85F8F0 VA: 0x1808612F0
	private void GenerateShoreVector(out float[] distances, out Vector3[] vectors) { }

	// RVA: 0x8618E0 Offset: 0x85FEE0 VA: 0x1808618E0
	public float GetCoarseDistanceToShore(Vector3 pos) { }

	// RVA: 0x861A30 Offset: 0x860030 VA: 0x180861A30
	public float GetCoarseDistanceToShore(Vector2 uv) { }

	// RVA: 0x861B80 Offset: 0x860180 VA: 0x180861B80
	public Vector3 GetCoarseVectorToShore(Vector3 pos) { }

	// RVA: 0x861D00 Offset: 0x860300 VA: 0x180861D00
	public Vector3 GetCoarseVectorToShore(Vector2 uv) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public Texture2D get_ShoreVectorTexture() { }

	// RVA: 0x861040 Offset: 0x85F640 VA: 0x180861040
	private void GenerateShoreVectorTexture(int size) { }

	// RVA: 0x862740 Offset: 0x860D40 VA: 0x180862740
	private void ReleaseShoreVectorTexture() { }

	// RVA: 0x864D20 Offset: 0x863320 VA: 0x180864D20
	public static TerrainTexturing get_Instance() { }

	// RVA: 0x860AD0 Offset: 0x85F0D0 VA: 0x180860AD0
	private void CheckInstance() { }

	// RVA: 0x860080 Offset: 0x85E680 VA: 0x180860080
	private void Awake() { }

	// RVA: 0x8628B0 Offset: 0x860EB0 VA: 0x1808628B0 Slot: 4
	public override void Setup() { }

	// RVA: 0x862570 Offset: 0x860B70 VA: 0x180862570 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x8628C0 Offset: 0x860EC0 VA: 0x1808628C0
	private void Shutdown() { }

	// RVA: 0x860080 Offset: 0x85E680 VA: 0x180860080
	private void OnEnable() { }

	// RVA: 0x862500 Offset: 0x860B00 VA: 0x180862500
	private void OnDisable() { }

	// RVA: 0x863F20 Offset: 0x862520 VA: 0x180863F20
	private void Update() { }

	// RVA: 0x860E20 Offset: 0x85F420 VA: 0x180860E20
	private Material CreateMaterial(string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T mat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4310 Offset: 0x5D2910 VA: 0x1805D4310
	|-TerrainTexturing.SafeDestroy<object>
	|-TerrainTexturing.SafeDestroy<Material>
	|-TerrainTexturing.SafeDestroy<Texture2D>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D43B0 Offset: 0x5D29B0 VA: 0x1805D43B0
	|-TerrainTexturing.SafeDispose<object>
	*/

	// RVA: 0x8627F0 Offset: 0x860DF0 VA: 0x1808627F0
	private void SafeDestroyRT(ref RenderTexture rtex) { }

	// RVA: 0x860EA0 Offset: 0x85F4A0 VA: 0x180860EA0
	private Texture2D CreateTex(string name, int width, int height, TextureFormat format, bool mips, bool linear) { }

	// RVA: 0x860F90 Offset: 0x85F590 VA: 0x180860F90
	private void DestroyTex(ref Texture2D tex) { }

	// RVA: 0x8640F0 Offset: 0x8626F0 VA: 0x1808640F0
	private void WarmupStrings() { }

	// RVA: 0x862D20 Offset: 0x861320 VA: 0x180862D20
	private void UpdateTerrainShaderConstants() { }

	// RVA: 0x862C60 Offset: 0x861260 VA: 0x180862C60
	private void UpdateFoliageDisplaceShaderConstants() { }

	// RVA: 0x862CA0 Offset: 0x8612A0 VA: 0x180862CA0
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0x863BB0 Offset: 0x8621B0 VA: 0x180863BB0
	private void UpdateTerrainToGlobal() { }

	// RVA: 0x862960 Offset: 0x860F60 VA: 0x180862960
	public void TriggerUpdateGlobalParams() { }

	// RVA: 0x862950 Offset: 0x860F50 VA: 0x180862950
	public void TriggerBasePyramidUpdate() { }

	// RVA: 0x864D00 Offset: 0x863300 VA: 0x180864D00
	public void .ctor() { }

	// RVA: 0x8649F0 Offset: 0x862FF0 VA: 0x1808649F0
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

	// RVA: 0x8729C0 Offset: 0x870FC0 VA: 0x1808729C0
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

	// RVA: 0x872DF0 Offset: 0x8713F0 VA: 0x180872DF0
	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

