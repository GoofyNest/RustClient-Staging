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

	// RVA: 0x21D9090 Offset: 0x21D7690 VA: 0x1821D9090 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D9170 Offset: 0x21D7770 VA: 0x1821D9170
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9520 Offset: 0x21D7B20 VA: 0x1821D9520
	public void .ctor() { }

}

