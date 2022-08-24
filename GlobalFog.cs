internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	[TooltipAttribute] // RVA: 0x9AC10 Offset: 0x9A010 VA: 0x18009AC10
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x9AE40 Offset: 0x9A240 VA: 0x18009AE40
	public bool useRadialDistance; // 0x29
	[TooltipAttribute] // RVA: 0x9AE70 Offset: 0x9A270 VA: 0x18009AE70
	public bool heightFog; // 0x2A
	[TooltipAttribute] // RVA: 0x9AFA0 Offset: 0x9A3A0 VA: 0x18009AFA0
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x9B050 Offset: 0x9A450 VA: 0x18009B050
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x9B140 Offset: 0x9A540 VA: 0x18009B140
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40


	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	public void .ctor() { }

}

