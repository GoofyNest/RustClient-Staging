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

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_IsInitialized() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public Material get_ReflectionMaterial() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Material get_UnderwaterMaterial() { }

	// RVA: 0xC1FE30 Offset: 0xC1E430 VA: 0x180C1FE30
	public MaterialPropertyBlock get_UnderwaterBlock() { }

	// RVA: 0xC1F040 Offset: 0xC1D640 VA: 0x180C1F040
	public void Initialize(WaterSystem water, WaterRuntime runtime, int maxVertexCount) { }

	// RVA: 0xC1CDE0 Offset: 0xC1B3E0 VA: 0x180C1CDE0
	public void Destroy() { }

	// RVA: 0xC1CAA0 Offset: 0xC1B0A0 VA: 0x180C1CAA0
	private void CheckScreenSize() { }

	// RVA: 0xC1BDF0 Offset: 0xC1A3F0 VA: 0x180C1BDF0
	private void CheckCommandBuffer() { }

	// RVA: 0xC1CB50 Offset: 0xC1B150 VA: 0x180C1CB50
	private void CleanupCommandBuffer() { }

	// RVA: 0xC1C3A0 Offset: 0xC1A9A0 VA: 0x180C1C3A0
	public bool CheckLostData() { }

	// RVA: 0xC1C1C0 Offset: 0xC1A7C0 VA: 0x180C1C1C0
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format, bool linear, FilterMode filter = 0) { }

	// RVA: 0xC1FA50 Offset: 0xC1E050 VA: 0x180C1FA50
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0xC1C930 Offset: 0xC1AF30 VA: 0x180C1C930
	private void CheckRenderTextures() { }

	// RVA: 0xC1CD40 Offset: 0xC1B340 VA: 0x180C1CD40
	private void CleanupRenderTextures() { }

	// RVA: 0xC1C4E0 Offset: 0xC1AAE0 VA: 0x180C1C4E0
	private void CheckOverlayMesh() { }

	// RVA: 0xC1CC80 Offset: 0xC1B280 VA: 0x180C1CC80
	private void CleanupOverlayMesh() { }

	// RVA: 0xC1F240 Offset: 0xC1D840 VA: 0x180C1F240
	private bool IsVisibleToCamera() { }

	// RVA: 0xC1DF10 Offset: 0xC1C510 VA: 0x180C1DF10
	private void FillCommandBuffer_SetGlobals(CommandBuffer cb) { }

	// RVA: 0xC1D880 Offset: 0xC1BE80 VA: 0x180C1D880
	private void FillCommandBuffer_Mask(CommandBuffer cb) { }

	// RVA: 0xC1D160 Offset: 0xC1B760 VA: 0x180C1D160
	private void FillCommandBuffer_Depth(CommandBuffer cb) { }

	// RVA: 0xC1DE00 Offset: 0xC1C400 VA: 0x180C1DE00
	private void FillCommandBuffer_PreFog(CommandBuffer cb) { }

	// RVA: 0xC1DBB0 Offset: 0xC1C1B0 VA: 0x180C1DBB0
	private void FillCommandBuffer_PostFog(CommandBuffer cb) { }

	// RVA: 0xC1BD60 Offset: 0xC1A360 VA: 0x180C1BD60
	private void CheckAndClearUnderwaterBlock() { }

	// RVA: 0xC1CDD0 Offset: 0xC1B3D0 VA: 0x180C1CDD0
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC1FB10 Offset: 0xC1E110 VA: 0x180C1FB10
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC1FCF0 Offset: 0xC1E2F0 VA: 0x180C1FCF0
	public void UpdateUnderwaterMaterial(Material reference) { }

	// RVA: 0xC1EB90 Offset: 0xC1D190 VA: 0x180C1EB90
	public static List<WaterCullingVolume> FindAndSortVisibleCullingVolumes(Camera camera, List<WaterCullingVolume> list) { }

	// RVA: 0xC1F7C0 Offset: 0xC1DDC0 VA: 0x180C1F7C0
	public void PrepareRender(int visibilityMask) { }

	// RVA: 0xC1F2F0 Offset: 0xC1D8F0 VA: 0x180C1F2F0
	private bool IssueRender(bool debug, bool depthOnly) { }

	// RVA: 0xC1F2E0 Offset: 0xC1D8E0 VA: 0x180C1F2E0
	public bool IssueRender(bool debug) { }

	// RVA: 0xC1FB20 Offset: 0xC1E120 VA: 0x180C1FB20
	public void ShowDebug() { }

	// RVA: 0xC1FD90 Offset: 0xC1E390 VA: 0x180C1FD90
	public void .ctor() { }

	// RVA: 0xC1FD10 Offset: 0xC1E310 VA: 0x180C1FD10
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

	// RVA: 0xC102E0 Offset: 0xC0E8E0 VA: 0x180C102E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC102A0 Offset: 0xC0E8A0 VA: 0x180C102A0
	internal int <FindAndSortVisibleCullingVolumes>b__62_0(WaterCullingVolume x, WaterCullingVolume y) { }

}

