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

	// RVA: 0x21D8ED0 Offset: 0x21D74D0 VA: 0x1821D8ED0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D8FB0 Offset: 0x21D75B0 VA: 0x1821D8FB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9360 Offset: 0x21D7960 VA: 0x1821D9360
	public void .ctor() { }

}

