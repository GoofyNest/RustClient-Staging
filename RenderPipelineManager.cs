public static class RenderPipelineManager // TypeDefIndex: 3851
{	// Fields
	private static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static int s_CameraCapacity; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x28

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF3E0 Offset: 0x19AD9E0 VA: 0x1819AF3E0
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF640 Offset: 0x19ADC40 VA: 0x1819AF640
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF2E0 Offset: 0x19AD8E0 VA: 0x1819AF2E0
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF540 Offset: 0x19ADB40 VA: 0x1819AF540
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF1E0 Offset: 0x19AD7E0 VA: 0x1819AF1E0
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AF440 Offset: 0x19ADA40 VA: 0x1819AF440
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AE650 Offset: 0x19ACC50 VA: 0x1819AE650
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x19AED30 Offset: 0x19AD330 VA: 0x1819AED30
	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AE990 Offset: 0x19ACF90 VA: 0x1819AE990
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	// RVA: 0x19AEEE0 Offset: 0x19AD4E0 VA: 0x1819AEEE0
	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x19AF170 Offset: 0x19AD770 VA: 0x1819AF170
	private static void .cctor() { }

}

