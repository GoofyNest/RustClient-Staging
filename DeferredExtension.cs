public class DeferredExtension : MonoBehaviour // TypeDefIndex: 10657
{	// Fields
	public ExtendGBufferParams extendGBuffer; // 0x18
	public SubsurfaceScatteringParams subsurfaceScattering; // 0x1C
	public Texture2D blueNoise; // 0x30
	public float depthScale; // 0x38
	public bool debug; // 0x3C
	public bool forceToCameraResolution; // 0x3D
	private Camera _targetCamera; // 0x40
	private CommandBufferManager commandBufferManager; // 0x48
	private CommandBufferDesc extendGBufferCBDesc; // 0x50
	private CommandBufferDesc postSubsurfaceCBDesc; // 0x58
	private Material postSubsurfaceMat; // 0x60
	private int frameIndexMod8; // 0x68
	private PostProcessLayer post; // 0x70
	private int gbufferWidth; // 0x78
	private int gbufferHeight; // 0x7C
	private RenderTexture gbufferTexture4; // 0x80
	private RenderTexture gbufferTexture5; // 0x88
	private RenderTargetIdentifier[] targets; // 0x90
	private static HashSet<DeferredExtensionMesh> registeredMeshes; // 0x0
	private static HashSet<DeferredExtensionMesh> visibleMeshes; // 0x8

	// Properties
	private Camera targetCamera { get; }
	private int TargetWidth { get; }
	private int TargetHeight { get; }

	// Methods

	// RVA: 0x84A530 Offset: 0x848B30 VA: 0x18084A530
	private Camera get_targetCamera() { }

	// RVA: 0x84A480 Offset: 0x848A80 VA: 0x18084A480
	private int get_TargetWidth() { }

	// RVA: 0x84A3D0 Offset: 0x8489D0 VA: 0x18084A3D0
	private int get_TargetHeight() { }

	// RVA: 0x849B90 Offset: 0x848190 VA: 0x180849B90
	public static void Register(DeferredExtensionMesh mesh) { }

	// RVA: 0x84A0D0 Offset: 0x8486D0 VA: 0x18084A0D0
	public static void Unregister(DeferredExtensionMesh mesh) { }

	// RVA: 0x849A60 Offset: 0x848060 VA: 0x180849A60
	private void OnEnable() { }

	// RVA: 0x8498D0 Offset: 0x847ED0 VA: 0x1808498D0
	private void OnDisable() { }

	// RVA: 0x8485B0 Offset: 0x846BB0 VA: 0x1808485B0
	private void CheckCommandBuffers() { }

	// RVA: 0x848B50 Offset: 0x847150 VA: 0x180848B50
	private void CleanupCommandBuffers() { }

	// RVA: 0x848D30 Offset: 0x847330 VA: 0x180848D30
	private void CreateMaterials() { }

	// RVA: 0x848C20 Offset: 0x847220 VA: 0x180848C20
	private void CleanupMaterials() { }

	// RVA: 0x8484C0 Offset: 0x846AC0 VA: 0x1808484C0
	private void BindSystemTextures() { }

	// RVA: -1 Offset: -1
	private void SafeCleanupTexture<T>(ref T tex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571C80 Offset: 0x1570280 VA: 0x181571C80
	|-DeferredExtension.SafeCleanupTexture<object>
	|-DeferredExtension.SafeCleanupTexture<RenderTexture>
	*/

	// RVA: 0x848CD0 Offset: 0x8472D0 VA: 0x180848CD0
	private void CleanupSystemTextures() { }

	// RVA: 0x8488C0 Offset: 0x846EC0 VA: 0x1808488C0
	private void CheckSystemTextures() { }

	// RVA: 0x848440 Offset: 0x846A40 VA: 0x180848440
	public static void BecameVisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x8483C0 Offset: 0x8469C0 VA: 0x1808483C0
	public static void BecameInvisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x848DD0 Offset: 0x8473D0 VA: 0x180848DD0
	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb) { }

	// RVA: 0x849090 Offset: 0x847690 VA: 0x180849090
	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb) { }

	// RVA: 0x8487A0 Offset: 0x846DA0 VA: 0x1808487A0
	private void CheckConsoleVars() { }

	// RVA: 0x848840 Offset: 0x846E40 VA: 0x180848840
	private void CheckShaderKeywords() { }

	// RVA: 0x849C10 Offset: 0x848210 VA: 0x180849C10
	private void SetShaderGlobals() { }

	// RVA: 0x84A150 Offset: 0x848750 VA: 0x18084A150
	private void Update() { }

	// RVA: 0x849B80 Offset: 0x848180 VA: 0x180849B80
	private void OnPreRender() { }

	// RVA: 0x849860 Offset: 0x847E60 VA: 0x180849860
	public static float LightIntensityScale(float intensity) { }

	// RVA: 0x84A300 Offset: 0x848900 VA: 0x18084A300
	public void .ctor() { }

	// RVA: 0x84A260 Offset: 0x848860 VA: 0x18084A260
	private static void .cctor() { }

}

private enum DeferredExtension.SubsurfacePass // TypeDefIndex: 10658
{	// Fields
	public int value__; // 0x0
	public const DeferredExtension.SubsurfacePass SetupFullRes = 0;
	public const DeferredExtension.SubsurfacePass SetupHalfRes = 1;
	public const DeferredExtension.SubsurfacePass Direction0 = 2;
	public const DeferredExtension.SubsurfacePass Direction1 = 3;
	public const DeferredExtension.SubsurfacePass RecombineFullRes = 4;
	public const DeferredExtension.SubsurfacePass RecombineHalfRes = 5;
	public const DeferredExtension.SubsurfacePass RecombinePassthrough = 6;

}

