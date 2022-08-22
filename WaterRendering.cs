public class WaterRendering // TypeDefIndex: 10619
{	// Fields
	private WaterSystem water; // 0x10
	private WaterSimulation simulation; // 0x18
	private Camera camera; // 0x20
	private PostOpaqueDepth postOpaqueDepth; // 0x28
	private int width; // 0x30
	private int height; // 0x34
	private bool initialized; // 0x38
	private WaterRadialMesh radialMesh; // 0x40
	private WaterRendering.RenderState state; // 0x48
	private const int MaxCullingVolumes = 4;
	private const float MaxCullingVolumeDistanceToCamera = 500;
	private const float MaxCullingVolumeSqrDistanceToCamera = 250000;
	private static Vector4[] cullingVolumeArray; // 0x0
	private static Plane[] frustumPlanes; // 0x8
	private Material reflectionMat; // 0x70
	private Material underwaterMat; // 0x78
	private Material multiCopyMat; // 0x80
	private RenderTexture surfaceTex; // 0x88
	private RenderTexture preFogBackgroundTex; // 0x90
	private RenderTexture ssrReflectionTex; // 0x98
	private Mesh overlayMesh; // 0xA0
	private float underwaterScatterCoefficientOverride; // 0xA8
	private MaterialPropertyBlock underwaterBlock; // 0xB0
	private CommandBufferManager commandBufferManager; // 0xB8
	private CommandBufferDesc setGlobalsCBDesc; // 0xC0
	private CommandBufferDesc waterMaskCBDesc; // 0xC8
	private CommandBufferDesc waterDepthCBDesc; // 0xD0
	private CommandBufferDesc preFogCBDesc; // 0xD8
	private CommandBufferDesc postFogCBDesc; // 0xE0
	private RenderTargetIdentifier[] targets; // 0xE8
	private bool initializedMaterials; // 0xF0

	// Properties
	public bool IsInitialized { get; }
	public Material ReflectionMaterial { get; }
	public Material UnderwaterMaterial { get; }
	public MaterialPropertyBlock UnderwaterBlock { get; }

	// Methods

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_IsInitialized() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public Material get_ReflectionMaterial() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Material get_UnderwaterMaterial() { }

	// RVA: 0xC200F0 Offset: 0xC1E6F0 VA: 0x180C200F0
	public MaterialPropertyBlock get_UnderwaterBlock() { }

	// RVA: 0xC1F300 Offset: 0xC1D900 VA: 0x180C1F300
	public void Initialize(WaterSystem water, WaterRuntime runtime, int maxVertexCount) { }

	// RVA: 0xC1D0A0 Offset: 0xC1B6A0 VA: 0x180C1D0A0
	public void Destroy() { }

	// RVA: 0xC1CD60 Offset: 0xC1B360 VA: 0x180C1CD60
	private void CheckScreenSize() { }

	// RVA: 0xC1C0B0 Offset: 0xC1A6B0 VA: 0x180C1C0B0
	private void CheckCommandBuffer() { }

	// RVA: 0xC1CE10 Offset: 0xC1B410 VA: 0x180C1CE10
	private void CleanupCommandBuffer() { }

	// RVA: 0xC1C660 Offset: 0xC1AC60 VA: 0x180C1C660
	public bool CheckLostData() { }

	// RVA: 0xC1C480 Offset: 0xC1AA80 VA: 0x180C1C480
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format, bool linear, FilterMode filter = 0) { }

	// RVA: 0xC1FD10 Offset: 0xC1E310 VA: 0x180C1FD10
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0xC1CBF0 Offset: 0xC1B1F0 VA: 0x180C1CBF0
	private void CheckRenderTextures() { }

	// RVA: 0xC1D000 Offset: 0xC1B600 VA: 0x180C1D000
	private void CleanupRenderTextures() { }

	// RVA: 0xC1C7A0 Offset: 0xC1ADA0 VA: 0x180C1C7A0
	private void CheckOverlayMesh() { }

	// RVA: 0xC1CF40 Offset: 0xC1B540 VA: 0x180C1CF40
	private void CleanupOverlayMesh() { }

	// RVA: 0xC1F500 Offset: 0xC1DB00 VA: 0x180C1F500
	private bool IsVisibleToCamera() { }

	// RVA: 0xC1E1D0 Offset: 0xC1C7D0 VA: 0x180C1E1D0
	private void FillCommandBuffer_SetGlobals(CommandBuffer cb) { }

	// RVA: 0xC1DB40 Offset: 0xC1C140 VA: 0x180C1DB40
	private void FillCommandBuffer_Mask(CommandBuffer cb) { }

	// RVA: 0xC1D420 Offset: 0xC1BA20 VA: 0x180C1D420
	private void FillCommandBuffer_Depth(CommandBuffer cb) { }

	// RVA: 0xC1E0C0 Offset: 0xC1C6C0 VA: 0x180C1E0C0
	private void FillCommandBuffer_PreFog(CommandBuffer cb) { }

	// RVA: 0xC1DE70 Offset: 0xC1C470 VA: 0x180C1DE70
	private void FillCommandBuffer_PostFog(CommandBuffer cb) { }

	// RVA: 0xC1C020 Offset: 0xC1A620 VA: 0x180C1C020
	private void CheckAndClearUnderwaterBlock() { }

	// RVA: 0xC1D090 Offset: 0xC1B690 VA: 0x180C1D090
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC1FDD0 Offset: 0xC1E3D0 VA: 0x180C1FDD0
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC1FFB0 Offset: 0xC1E5B0 VA: 0x180C1FFB0
	public void UpdateUnderwaterMaterial(Material reference) { }

	// RVA: 0xC1EE50 Offset: 0xC1D450 VA: 0x180C1EE50
	public static List<WaterCullingVolume> FindAndSortVisibleCullingVolumes(Camera camera, List<WaterCullingVolume> list) { }

	// RVA: 0xC1FA80 Offset: 0xC1E080 VA: 0x180C1FA80
	public void PrepareRender(int visibilityMask) { }

	// RVA: 0xC1F5B0 Offset: 0xC1DBB0 VA: 0x180C1F5B0
	private bool IssueRender(bool debug, bool depthOnly) { }

	// RVA: 0xC1F5A0 Offset: 0xC1DBA0 VA: 0x180C1F5A0
	public bool IssueRender(bool debug) { }

	// RVA: 0xC1FDE0 Offset: 0xC1E3E0 VA: 0x180C1FDE0
	public void ShowDebug() { }

	// RVA: 0xC20050 Offset: 0xC1E650 VA: 0x180C20050
	public void .ctor() { }

	// RVA: 0xC1FFD0 Offset: 0xC1E5D0 VA: 0x180C1FFD0
	private static void .cctor() { }

}

private struct WaterRendering.RenderState // TypeDefIndex: 10620
{	// Fields
	public Camera camera; // 0x0
	public int layer; // 0x8
	public bool simulation; // 0xC
	public bool displacement; // 0xD
	public int reflections; // 0x10
	public bool caustics; // 0x14
	public int visibilityMask; // 0x18
	public List<WaterCullingVolume> cullingVolumes; // 0x20

}

private sealed class WaterRendering.<>c // TypeDefIndex: 10621
{	// Fields
	public static readonly WaterRendering.<>c <>9; // 0x0
	public static Comparison<WaterCullingVolume> <>9__62_0; // 0x8

	// Methods

	// RVA: 0xC105A0 Offset: 0xC0EBA0 VA: 0x180C105A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC10560 Offset: 0xC0EB60 VA: 0x180C10560
	internal int <FindAndSortVisibleCullingVolumes>b__62_0(WaterCullingVolume x, WaterCullingVolume y) { }

}

