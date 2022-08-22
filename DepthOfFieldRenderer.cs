internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 11783
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0,024;

	// Methods

	// RVA: 0x9FD660 Offset: 0x9FBC60 VA: 0x1809FD660
	public void .ctor() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9FD5C0 Offset: 0x9FBBC0 VA: 0x1809FD5C0
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x9FC200 Offset: 0x9FA800 VA: 0x1809FC200
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x9FC2B0 Offset: 0x9FA8B0 VA: 0x1809FC2B0
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x9FC840 Offset: 0x9FAE40 VA: 0x1809FC840 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9FC6F0 Offset: 0x9FACF0 VA: 0x1809FC6F0 Slot: 7
	public override void Release() { }

}

private enum DepthOfFieldRenderer.Pass // TypeDefIndex: 11784
{	// Fields
	public int value__; // 0x0
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

