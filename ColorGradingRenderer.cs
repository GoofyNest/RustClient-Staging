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

	// RVA: 0x9F6720 Offset: 0x9F4D20 VA: 0x1809F6720 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9F3420 Offset: 0x9F1A20 VA: 0x1809F3420
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F4880 Offset: 0x9F2E80 VA: 0x1809F4880
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F36D0 Offset: 0x9F1CD0 VA: 0x1809F36D0
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F5760 Offset: 0x9F3D60 VA: 0x1809F5760
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F2A40 Offset: 0x9F1040 VA: 0x1809F2A40
	private void CheckInternalLogLut() { }

	// RVA: 0x9F2C10 Offset: 0x9F1210 VA: 0x1809F2C10
	private void CheckInternalStripLut() { }

	// RVA: 0x9F2DD0 Offset: 0x9F13D0 VA: 0x1809F2DD0
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x9F3340 Offset: 0x9F1940 VA: 0x1809F3340
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x9F32D0 Offset: 0x9F18D0 VA: 0x1809F32D0
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x9F2DA0 Offset: 0x9F13A0 VA: 0x1809F2DA0
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x9F3370 Offset: 0x9F1970 VA: 0x1809F3370 Slot: 7
	public override void Release() { }

	// RVA: 0x9F6890 Offset: 0x9F4E90 VA: 0x1809F6890
	public void .ctor() { }

}

private enum ColorGradingRenderer.Pass // TypeDefIndex: 11779
{	// Fields
	public int value__; // 0x0
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

