internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 11778
{	// Fields
	private Texture2D m_GradingCurves; // 0x20
	private readonly Color[] m_Pixels; // 0x28
	private RenderTexture m_InternalLdrLut; // 0x30
	private RenderTexture m_InternalLogLut; // 0x38
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; // 0x40

	// Methods

	// RVA: 0x9F5F70 Offset: 0x9F4570 VA: 0x1809F5F70 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9F2C70 Offset: 0x9F1270 VA: 0x1809F2C70
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F40D0 Offset: 0x9F26D0 VA: 0x1809F40D0
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F2F20 Offset: 0x9F1520 VA: 0x1809F2F20
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F4FB0 Offset: 0x9F35B0 VA: 0x1809F4FB0
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F2290 Offset: 0x9F0890 VA: 0x1809F2290
	private void CheckInternalLogLut() { }

	// RVA: 0x9F2460 Offset: 0x9F0A60 VA: 0x1809F2460
	private void CheckInternalStripLut() { }

	// RVA: 0x9F2620 Offset: 0x9F0C20 VA: 0x1809F2620
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x9F2B90 Offset: 0x9F1190 VA: 0x1809F2B90
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x9F2B20 Offset: 0x9F1120 VA: 0x1809F2B20
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x9F25F0 Offset: 0x9F0BF0 VA: 0x1809F25F0
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x9F2BC0 Offset: 0x9F11C0 VA: 0x1809F2BC0 Slot: 7
	public override void Release() { }

	// RVA: 0x9F60E0 Offset: 0x9F46E0 VA: 0x1809F60E0
	public void .ctor() { }

}

private enum ColorGradingRenderer.Pass // TypeDefIndex: 11779
{	// Fields
	public int value__; // 0x0
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

