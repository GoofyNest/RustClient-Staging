internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 11798
{	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x11DCC90 Offset: 0x11DB290 VA: 0x1811DCC90
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11DBA80 Offset: 0x11DA080 VA: 0x1811DBA80
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x11DC130 Offset: 0x11DA730 VA: 0x1811DC130
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x11DBE40 Offset: 0x11DA440 VA: 0x1811DBE40 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x11DC090 Offset: 0x11DA690 VA: 0x1811DC090 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DB700 Offset: 0x11D9D00 VA: 0x1811DB700 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DBDC0 Offset: 0x11DA3C0 VA: 0x1811DBDC0 Slot: 8
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

