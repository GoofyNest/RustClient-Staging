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

	// RVA: 0x849FE0 Offset: 0x8485E0 VA: 0x180849FE0
	private Camera get_targetCamera() { }

	// RVA: 0x849F30 Offset: 0x848530 VA: 0x180849F30
	private int get_TargetWidth() { }

	// RVA: 0x849E80 Offset: 0x848480 VA: 0x180849E80
	private int get_TargetHeight() { }

	// RVA: 0x849640 Offset: 0x847C40 VA: 0x180849640
	public static void Register(DeferredExtensionMesh mesh) { }

	// RVA: 0x849B80 Offset: 0x848180 VA: 0x180849B80
	public static void Unregister(DeferredExtensionMesh mesh) { }

	// RVA: 0x849510 Offset: 0x847B10 VA: 0x180849510
	private void OnEnable() { }

	// RVA: 0x849380 Offset: 0x847980 VA: 0x180849380
	private void OnDisable() { }

	// RVA: 0x848060 Offset: 0x846660 VA: 0x180848060
	private void CheckCommandBuffers() { }

	// RVA: 0x848600 Offset: 0x846C00 VA: 0x180848600
	private void CleanupCommandBuffers() { }

	// RVA: 0x8487E0 Offset: 0x846DE0 VA: 0x1808487E0
	private void CreateMaterials() { }

	// RVA: 0x8486D0 Offset: 0x846CD0 VA: 0x1808486D0
	private void CleanupMaterials() { }

	// RVA: 0x847F70 Offset: 0x846570 VA: 0x180847F70
	private void BindSystemTextures() { }

	// RVA: -1 Offset: -1
	private void SafeCleanupTexture<T>(ref T tex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572BB0 Offset: 0x15711B0 VA: 0x181572BB0
	|-DeferredExtension.SafeCleanupTexture<object>
	|-DeferredExtension.SafeCleanupTexture<RenderTexture>
	*/

	// RVA: 0x848780 Offset: 0x846D80 VA: 0x180848780
	private void CleanupSystemTextures() { }

	// RVA: 0x848370 Offset: 0x846970 VA: 0x180848370
	private void CheckSystemTextures() { }

	// RVA: 0x847EF0 Offset: 0x8464F0 VA: 0x180847EF0
	public static void BecameVisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x847E70 Offset: 0x846470 VA: 0x180847E70
	public static void BecameInvisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x848880 Offset: 0x846E80 VA: 0x180848880
	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb) { }

	// RVA: 0x848B40 Offset: 0x847140 VA: 0x180848B40
	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb) { }

	// RVA: 0x848250 Offset: 0x846850 VA: 0x180848250
	private void CheckConsoleVars() { }

	// RVA: 0x8482F0 Offset: 0x8468F0 VA: 0x1808482F0
	private void CheckShaderKeywords() { }

	// RVA: 0x8496C0 Offset: 0x847CC0 VA: 0x1808496C0
	private void SetShaderGlobals() { }

	// RVA: 0x849C00 Offset: 0x848200 VA: 0x180849C00
	private void Update() { }

	// RVA: 0x849630 Offset: 0x847C30 VA: 0x180849630
	private void OnPreRender() { }

	// RVA: 0x849310 Offset: 0x847910 VA: 0x180849310
	public static float LightIntensityScale(float intensity) { }

	// RVA: 0x849DB0 Offset: 0x8483B0 VA: 0x180849DB0
	public void .ctor() { }

	// RVA: 0x849D10 Offset: 0x848310 VA: 0x180849D10
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

