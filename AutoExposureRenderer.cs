internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 11766
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x9EDCD0 Offset: 0x9EC2D0 VA: 0x1809EDCD0
	public void .ctor() { }

	// RVA: 0x9ED050 Offset: 0x9EB650 VA: 0x1809ED050
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x9ED3C0 Offset: 0x9EB9C0 VA: 0x1809ED3C0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9ED2D0 Offset: 0x9EB8D0 VA: 0x1809ED2D0 Slot: 7
	public override void Release() { }

}

