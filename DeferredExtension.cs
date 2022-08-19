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

	// RVA: 0x849ED0 Offset: 0x8484D0 VA: 0x180849ED0
	private Camera get_targetCamera() { }

	// RVA: 0x849E20 Offset: 0x848420 VA: 0x180849E20
	private int get_TargetWidth() { }

	// RVA: 0x849D70 Offset: 0x848370 VA: 0x180849D70
	private int get_TargetHeight() { }

	// RVA: 0x849530 Offset: 0x847B30 VA: 0x180849530
	public static void Register(DeferredExtensionMesh mesh) { }

	// RVA: 0x849A70 Offset: 0x848070 VA: 0x180849A70
	public static void Unregister(DeferredExtensionMesh mesh) { }

	// RVA: 0x849400 Offset: 0x847A00 VA: 0x180849400
	private void OnEnable() { }

	// RVA: 0x849270 Offset: 0x847870 VA: 0x180849270
	private void OnDisable() { }

	// RVA: 0x847F50 Offset: 0x846550 VA: 0x180847F50
	private void CheckCommandBuffers() { }

	// RVA: 0x8484F0 Offset: 0x846AF0 VA: 0x1808484F0
	private void CleanupCommandBuffers() { }

	// RVA: 0x8486D0 Offset: 0x846CD0 VA: 0x1808486D0
	private void CreateMaterials() { }

	// RVA: 0x8485C0 Offset: 0x846BC0 VA: 0x1808485C0
	private void CleanupMaterials() { }

	// RVA: 0x847E60 Offset: 0x846460 VA: 0x180847E60
	private void BindSystemTextures() { }

	// RVA: -1 Offset: -1
	private void SafeCleanupTexture<T>(ref T tex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15728F0 Offset: 0x1570EF0 VA: 0x1815728F0
	|-DeferredExtension.SafeCleanupTexture<object>
	|-DeferredExtension.SafeCleanupTexture<RenderTexture>
	*/

	// RVA: 0x848670 Offset: 0x846C70 VA: 0x180848670
	private void CleanupSystemTextures() { }

	// RVA: 0x848260 Offset: 0x846860 VA: 0x180848260
	private void CheckSystemTextures() { }

	// RVA: 0x847DE0 Offset: 0x8463E0 VA: 0x180847DE0
	public static void BecameVisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x847D60 Offset: 0x846360 VA: 0x180847D60
	public static void BecameInvisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x848770 Offset: 0x846D70 VA: 0x180848770
	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb) { }

	// RVA: 0x848A30 Offset: 0x847030 VA: 0x180848A30
	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb) { }

	// RVA: 0x848140 Offset: 0x846740 VA: 0x180848140
	private void CheckConsoleVars() { }

	// RVA: 0x8481E0 Offset: 0x8467E0 VA: 0x1808481E0
	private void CheckShaderKeywords() { }

	// RVA: 0x8495B0 Offset: 0x847BB0 VA: 0x1808495B0
	private void SetShaderGlobals() { }

	// RVA: 0x849AF0 Offset: 0x8480F0 VA: 0x180849AF0
	private void Update() { }

	// RVA: 0x849520 Offset: 0x847B20 VA: 0x180849520
	private void OnPreRender() { }

	// RVA: 0x849200 Offset: 0x847800 VA: 0x180849200
	public static float LightIntensityScale(float intensity) { }

	// RVA: 0x849CA0 Offset: 0x8482A0 VA: 0x180849CA0
	public void .ctor() { }

	// RVA: 0x849C00 Offset: 0x848200 VA: 0x180849C00
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

