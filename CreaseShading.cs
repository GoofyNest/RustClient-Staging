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

	// RVA: 0x21DA390 Offset: 0x21D8990 VA: 0x1821DA390 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DA440 Offset: 0x21D8A40 VA: 0x1821DA440
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DA840 Offset: 0x21D8E40 VA: 0x1821DA840
	public void .ctor() { }

}

