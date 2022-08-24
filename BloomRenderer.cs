internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom> // TypeDefIndex: 11772
{	private BloomRenderer.Level[] m_Pyramid; // 0x20
	private const int k_MaxPyramidSize = 16;


	public override void Init() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum BloomRenderer.Pass // TypeDefIndex: 11773
{	public int value__; // 0x0
	public const BloomRenderer.Pass Prefilter13 = 0;
	public const BloomRenderer.Pass Prefilter4 = 1;
	public const BloomRenderer.Pass Downsample13 = 2;
	public const BloomRenderer.Pass Downsample4 = 3;
	public const BloomRenderer.Pass UpsampleTent = 4;
	public const BloomRenderer.Pass UpsampleBox = 5;
	public const BloomRenderer.Pass DebugOverlayThreshold = 6;
	public const BloomRenderer.Pass DebugOverlayTent = 7;
	public const BloomRenderer.Pass DebugOverlayBox = 8;

}

private struct BloomRenderer.Level // TypeDefIndex: 11774
{	internal int down; // 0x0
	internal int up; // 0x4

}

