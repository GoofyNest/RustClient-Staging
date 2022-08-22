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
	// RVA: 0x199CAA0 Offset: 0x199B0A0 VA: 0x18199CAA0
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199CD00 Offset: 0x199B300 VA: 0x18199CD00
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199C9A0 Offset: 0x199AFA0 VA: 0x18199C9A0
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199CC00 Offset: 0x199B200 VA: 0x18199CC00
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199C8A0 Offset: 0x199AEA0 VA: 0x18199C8A0
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199CB00 Offset: 0x199B100 VA: 0x18199CB00
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199BD10 Offset: 0x199A310 VA: 0x18199BD10
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x199C3F0 Offset: 0x199A9F0 VA: 0x18199C3F0
	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199C050 Offset: 0x199A650 VA: 0x18199C050
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	// RVA: 0x199C5A0 Offset: 0x199ABA0 VA: 0x18199C5A0
	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x199C830 Offset: 0x199AE30 VA: 0x18199C830
	private static void .cctor() { }

}

