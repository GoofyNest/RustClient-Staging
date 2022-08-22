internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 11798
{	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x11DD330 Offset: 0x11DB930 VA: 0x1811DD330
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11DC120 Offset: 0x11DA720 VA: 0x1811DC120
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x11DC7D0 Offset: 0x11DADD0 VA: 0x1811DC7D0
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x11DC4E0 Offset: 0x11DAAE0 VA: 0x1811DC4E0 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x11DC730 Offset: 0x11DAD30 VA: 0x1811DC730 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DBDA0 Offset: 0x11DA3A0 VA: 0x1811DBDA0 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DC460 Offset: 0x11DAA60 VA: 0x1811DC460 Slot: 8
	public void Release() { }

}

private enum ScalableAO.Pass // TypeDefIndex: 11799
{	// Fields
	public int value__; // 0x0
	public const ScalableAO.Pass OcclusionEstimationForward = 0;
	public const ScalableAO.Pass OcclusionEstimationDeferred = 1;
	public const ScalableAO.Pass HorizontalBlurForward = 2;
	public const ScalableAO.Pass HorizontalBlurDeferred = 3;
	public const ScalableAO.Pass VerticalBlur = 4;
	public const ScalableAO.Pass CompositionForward = 5;
	public const ScalableAO.Pass CompositionDeferred = 6;
	public const ScalableAO.Pass DebugOverlay = 7;

}

