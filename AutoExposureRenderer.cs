internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 11766
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x9EDA10 Offset: 0x9EC010 VA: 0x1809EDA10
	public void .ctor() { }

	// RVA: 0x9ECD90 Offset: 0x9EB390 VA: 0x1809ECD90
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x9ED100 Offset: 0x9EB700 VA: 0x1809ED100 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9ED010 Offset: 0x9EB610 VA: 0x1809ED010 Slot: 7
	public override void Release() { }

}

