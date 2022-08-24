internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 11802
{	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30


	public void .ctor(AmbientOcclusion settings) { }

	public DepthTextureMode GetCameraFlags() { }

	private void DoLazyInitialization(PostProcessRenderContext context) { }

	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	public void Release() { }

}

private enum ScalableAO.Pass // TypeDefIndex: 11803
{	public int value__; // 0x0
	public const ScalableAO.Pass OcclusionEstimationForward = 0;
	public const ScalableAO.Pass OcclusionEstimationDeferred = 1;
	public const ScalableAO.Pass HorizontalBlurForward = 2;
	public const ScalableAO.Pass HorizontalBlurDeferred = 3;
	public const ScalableAO.Pass VerticalBlur = 4;
	public const ScalableAO.Pass CompositionForward = 5;
	public const ScalableAO.Pass CompositionDeferred = 6;
	public const ScalableAO.Pass DebugOverlay = 7;

}

