internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 11766
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x9EE1C0 Offset: 0x9EC7C0 VA: 0x1809EE1C0
	public void .ctor() { }

	// RVA: 0x9ED540 Offset: 0x9EBB40 VA: 0x1809ED540
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x9ED8B0 Offset: 0x9EBEB0 VA: 0x1809ED8B0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9ED7C0 Offset: 0x9EBDC0 VA: 0x1809ED7C0 Slot: 7
	public override void Release() { }

}

