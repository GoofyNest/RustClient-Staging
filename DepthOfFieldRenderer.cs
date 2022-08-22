internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 11783
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0,024;

	// Methods

	// RVA: 0x9FD170 Offset: 0x9FB770 VA: 0x1809FD170
	public void .ctor() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9FD0D0 Offset: 0x9FB6D0 VA: 0x1809FD0D0
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x9FBD10 Offset: 0x9FA310 VA: 0x1809FBD10
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x9FBDC0 Offset: 0x9FA3C0 VA: 0x1809FBDC0
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x9FC350 Offset: 0x9FA950 VA: 0x1809FC350 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9FC200 Offset: 0x9FA800 VA: 0x1809FC200 Slot: 7
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

