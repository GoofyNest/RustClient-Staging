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

	// RVA: 0x9F6230 Offset: 0x9F4830 VA: 0x1809F6230 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9F2F30 Offset: 0x9F1530 VA: 0x1809F2F30
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F4390 Offset: 0x9F2990 VA: 0x1809F4390
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9F31E0 Offset: 0x9F17E0 VA: 0x1809F31E0
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F5270 Offset: 0x9F3870 VA: 0x1809F5270
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9F2550 Offset: 0x9F0B50 VA: 0x1809F2550
	private void CheckInternalLogLut() { }

	// RVA: 0x9F2720 Offset: 0x9F0D20 VA: 0x1809F2720
	private void CheckInternalStripLut() { }

	// RVA: 0x9F28E0 Offset: 0x9F0EE0 VA: 0x1809F28E0
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x9F2E50 Offset: 0x9F1450 VA: 0x1809F2E50
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x9F2DE0 Offset: 0x9F13E0 VA: 0x1809F2DE0
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x9F28B0 Offset: 0x9F0EB0 VA: 0x1809F28B0
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x9F2E80 Offset: 0x9F1480 VA: 0x1809F2E80 Slot: 7
	public override void Release() { }

	// RVA: 0x9F63A0 Offset: 0x9F49A0 VA: 0x1809F63A0
	public void .ctor() { }

}

private enum ColorGradingRenderer.Pass // TypeDefIndex: 11779
{	// Fields
	public int value__; // 0x0
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

