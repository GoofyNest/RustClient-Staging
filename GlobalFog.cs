internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	// Fields
	[TooltipAttribute] // RVA: 0x9AB20 Offset: 0x99F20 VA: 0x18009AB20
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x9AD40 Offset: 0x9A140 VA: 0x18009AD40
	public bool useRadialDistance; // 0x29
	[TooltipAttribute] // RVA: 0x9ADA0 Offset: 0x9A1A0 VA: 0x18009ADA0
	public bool heightFog; // 0x2A
	[TooltipAttribute] // RVA: 0x9AEA0 Offset: 0x9A2A0 VA: 0x18009AEA0
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x9AFA0 Offset: 0x9A3A0 VA: 0x18009AFA0
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40

	// Methods

	// RVA: 0x21DFEA0 Offset: 0x21DE4A0 VA: 0x1821DFEA0 Slot: 4
	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21E0050 Offset: 0x21DE650 VA: 0x1821E0050
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DFF00 Offset: 0x21DE500 VA: 0x1821DFF00
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	// RVA: 0x21E0D20 Offset: 0x21DF320 VA: 0x1821E0D20
	public void .ctor() { }

}

