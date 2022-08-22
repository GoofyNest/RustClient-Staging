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

	// RVA: 0x21D99B0 Offset: 0x21D7FB0 VA: 0x1821D99B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D9A90 Offset: 0x21D8090 VA: 0x1821D9A90
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9E40 Offset: 0x21D8440 VA: 0x1821D9E40
	public void .ctor() { }

}

