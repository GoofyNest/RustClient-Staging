internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 11798
{	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x11DC9D0 Offset: 0x11DAFD0 VA: 0x1811DC9D0
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11DB7C0 Offset: 0x11D9DC0 VA: 0x1811DB7C0
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x11DBE70 Offset: 0x11DA470 VA: 0x1811DBE70
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x11DBB80 Offset: 0x11DA180 VA: 0x1811DBB80 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x11DBDD0 Offset: 0x11DA3D0 VA: 0x1811DBDD0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DB440 Offset: 0x11D9A40 VA: 0x1811DB440 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11DBB00 Offset: 0x11DA100 VA: 0x1811DBB00 Slot: 8
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
