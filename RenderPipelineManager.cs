public static class RenderPipelineManager // TypeDefIndex: 3851
{	private static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static int s_CameraCapacity; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x28

	public static RenderPipeline currentPipeline { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void CleanupRenderPipeline() { }

	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	private static void .cctor() { }

}

