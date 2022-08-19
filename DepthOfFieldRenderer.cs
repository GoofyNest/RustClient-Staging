internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 11783
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0,024;

	// Methods

	// RVA: 0x9FCEB0 Offset: 0x9FB4B0 VA: 0x1809FCEB0
	public void .ctor() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9FCE10 Offset: 0x9FB410 VA: 0x1809FCE10
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x9FBA50 Offset: 0x9FA050 VA: 0x1809FBA50
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x9FBB00 Offset: 0x9FA100 VA: 0x1809FBB00
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x9FC090 Offset: 0x9FA690 VA: 0x1809FC090 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9FBF40 Offset: 0x9FA540 VA: 0x1809FBF40 Slot: 7
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

