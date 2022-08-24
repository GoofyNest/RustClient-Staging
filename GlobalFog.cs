internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	[TooltipAttribute] // RVA: 0x9AC50 Offset: 0x9A050 VA: 0x18009AC50
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x9AE30 Offset: 0x9A230 VA: 0x18009AE30
	public bool useRadialDistance; // 0x29
	[TooltipAttribute] // RVA: 0x9AE60 Offset: 0x9A260 VA: 0x18009AE60
	public bool heightFog; // 0x2A
	[TooltipAttribute] // RVA: 0x9AFA0 Offset: 0x9A3A0 VA: 0x18009AFA0
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x9B000 Offset: 0x9A400 VA: 0x18009B000
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x9B0A0 Offset: 0x9A4A0 VA: 0x18009B0A0
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40


	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	public void .ctor() { }

}

