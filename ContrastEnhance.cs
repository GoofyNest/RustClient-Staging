internal class ContrastEnhance : PostEffectsBase // TypeDefIndex: 8174
{	// Fields
	public float intensity; // 0x28
	public float threshold; // 0x2C
	private Material separableBlurMaterial; // 0x30
	private Material contrastCompositeMaterial; // 0x38
	public float blurSpread; // 0x40
	public Shader separableBlurShader; // 0x48
	public Shader contrastCompositeShader; // 0x50

	// Methods

	// RVA: 0x21D9190 Offset: 0x21D7790 VA: 0x1821D9190 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D9270 Offset: 0x21D7870 VA: 0x1821D9270
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9620 Offset: 0x21D7C20 VA: 0x1821D9620
	public void .ctor() { }

}

