internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 11787
{	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0,024;


	public void .ctor() { }

	public override DepthTextureMode GetCameraFlags() { }

	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	private float CalculateMaxCoCRadius(int screenHeight) { }

	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	public override void Render(PostProcessRenderContext context) { }

	public override void Release() { }

}

private enum DepthOfFieldRenderer.Pass // TypeDefIndex: 11788
{	public int value__; // 0x0
	public const DepthOfFieldRenderer.Pass CoCCalculation = 0;
	public const DepthOfFieldRenderer.Pass CoCTemporalFilter = 1;
	public const DepthOfFieldRenderer.Pass DownsampleAndPrefilter = 2;
	public const DepthOfFieldRenderer.Pass BokehSmallKernel = 3;
	public const DepthOfFieldRenderer.Pass BokehMediumKernel = 4;
	public const DepthOfFieldRenderer.Pass BokehLargeKernel = 5;
	public const DepthOfFieldRenderer.Pass BokehVeryLargeKernel = 6;
	public const DepthOfFieldRenderer.Pass PostFilter = 7;
	public const DepthOfFieldRenderer.Pass Combine = 8;
	public const DepthOfFieldRenderer.Pass DebugOverlay = 9;

}

