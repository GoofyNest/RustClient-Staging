internal class CreaseShading : PostEffectsBase // TypeDefIndex: 8176
{	// Fields
	public float intensity; // 0x28
	public int softness; // 0x2C
	public float spread; // 0x30
	public Shader blurShader; // 0x38
	private Material blurMaterial; // 0x40
	public Shader depthFetchShader; // 0x48
	private Material depthFetchMaterial; // 0x50
	public Shader creaseApplyShader; // 0x58
	private Material creaseApplyMaterial; // 0x60

	// Methods

	// RVA: 0x21DABB0 Offset: 0x21D91B0 VA: 0x1821DABB0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DAC60 Offset: 0x21D9260 VA: 0x1821DAC60
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DB060 Offset: 0x21D9660 VA: 0x1821DB060
	public void .ctor() { }

}

