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

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_IsInitialized() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public Material get_ReflectionMaterial() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public Material get_UnderwaterMaterial() { }

	// RVA: 0xC205C0 Offset: 0xC1EBC0 VA: 0x180C205C0
	public MaterialPropertyBlock get_UnderwaterBlock() { }

	// RVA: 0xC1F7D0 Offset: 0xC1DDD0 VA: 0x180C1F7D0
	public void Initialize(WaterSystem water, WaterRuntime runtime, int maxVertexCount) { }

	// RVA: 0xC1D570 Offset: 0xC1BB70 VA: 0x180C1D570
	public void Destroy() { }

	// RVA: 0xC1D230 Offset: 0xC1B830 VA: 0x180C1D230
	private void CheckScreenSize() { }

	// RVA: 0xC1C580 Offset: 0xC1AB80 VA: 0x180C1C580
	private void CheckCommandBuffer() { }

	// RVA: 0xC1D2E0 Offset: 0xC1B8E0 VA: 0x180C1D2E0
	private void CleanupCommandBuffer() { }

	// RVA: 0xC1CB30 Offset: 0xC1B130 VA: 0x180C1CB30
	public bool CheckLostData() { }

	// RVA: 0xC1C950 Offset: 0xC1AF50 VA: 0x180C1C950
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format, bool linear, FilterMode filter = 0) { }

	// RVA: 0xC201E0 Offset: 0xC1E7E0 VA: 0x180C201E0
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0xC1D0C0 Offset: 0xC1B6C0 VA: 0x180C1D0C0
	private void CheckRenderTextures() { }

	// RVA: 0xC1D4D0 Offset: 0xC1BAD0 VA: 0x180C1D4D0
	private void CleanupRenderTextures() { }

	// RVA: 0xC1CC70 Offset: 0xC1B270 VA: 0x180C1CC70
	private void CheckOverlayMesh() { }

	// RVA: 0xC1D410 Offset: 0xC1BA10 VA: 0x180C1D410
	private void CleanupOverlayMesh() { }

	// RVA: 0xC1F9D0 Offset: 0xC1DFD0 VA: 0x180C1F9D0
	private bool IsVisibleToCamera() { }

	// RVA: 0xC1E6A0 Offset: 0xC1CCA0 VA: 0x180C1E6A0
	private void FillCommandBuffer_SetGlobals(CommandBuffer cb) { }

	// RVA: 0xC1E010 Offset: 0xC1C610 VA: 0x180C1E010
	private void FillCommandBuffer_Mask(CommandBuffer cb) { }

	// RVA: 0xC1D8F0 Offset: 0xC1BEF0 VA: 0x180C1D8F0
	private void FillCommandBuffer_Depth(CommandBuffer cb) { }

	// RVA: 0xC1E590 Offset: 0xC1CB90 VA: 0x180C1E590
	private void FillCommandBuffer_PreFog(CommandBuffer cb) { }

	// RVA: 0xC1E340 Offset: 0xC1C940 VA: 0x180C1E340
	private void FillCommandBuffer_PostFog(CommandBuffer cb) { }

	// RVA: 0xC1C4F0 Offset: 0xC1AAF0 VA: 0x180C1C4F0
	private void CheckAndClearUnderwaterBlock() { }

	// RVA: 0xC1D560 Offset: 0xC1BB60 VA: 0x180C1D560
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC202A0 Offset: 0xC1E8A0 VA: 0x180C202A0
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC20480 Offset: 0xC1EA80 VA: 0x180C20480
	public void UpdateUnderwaterMaterial(Material reference) { }

	// RVA: 0xC1F320 Offset: 0xC1D920 VA: 0x180C1F320
	public static List<WaterCullingVolume> FindAndSortVisibleCullingVolumes(Camera camera, List<WaterCullingVolume> list) { }

	// RVA: 0xC1FF50 Offset: 0xC1E550 VA: 0x180C1FF50
	public void PrepareRender(int visibilityMask) { }

	// RVA: 0xC1FA80 Offset: 0xC1E080 VA: 0x180C1FA80
	private bool IssueRender(bool debug, bool depthOnly) { }

	// RVA: 0xC1FA70 Offset: 0xC1E070 VA: 0x180C1FA70
	public bool IssueRender(bool debug) { }

	// RVA: 0xC202B0 Offset: 0xC1E8B0 VA: 0x180C202B0
	public void ShowDebug() { }

	// RVA: 0xC20520 Offset: 0xC1EB20 VA: 0x180C20520
	public void .ctor() { }

	// RVA: 0xC204A0 Offset: 0xC1EAA0 VA: 0x180C204A0
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

	// RVA: 0xC10A70 Offset: 0xC0F070 VA: 0x180C10A70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC10A30 Offset: 0xC0F030 VA: 0x180C10A30
	internal int <FindAndSortVisibleCullingVolumes>b__62_0(WaterCullingVolume x, WaterCullingVolume y) { }

}

