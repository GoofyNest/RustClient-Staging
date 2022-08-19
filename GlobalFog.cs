internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	// Fields
	[TooltipAttribute] // RVA: 0x9AA90 Offset: 0x99E90 VA: 0x18009AA90
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x9AC00 Offset: 0x9A000 VA: 0x18009AC00
	public bool useRadialDistance; // 0x29
	[TooltipAttribute] // RVA: 0x9AD10 Offset: 0x9A110 VA: 0x18009AD10
	public bool heightFog; // 0x2A
	[TooltipAttribute] // RVA: 0x9AE10 Offset: 0x9A210 VA: 0x18009AE10
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x9AE40 Offset: 0x9A240 VA: 0x18009AE40
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x9AEE0 Offset: 0x9A2E0 VA: 0x18009AEE0
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40

	// Methods

	// RVA: 0x21DFDA0 Offset: 0x21DE3A0 VA: 0x1821DFDA0 Slot: 4
	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21DFF50 Offset: 0x21DE550 VA: 0x1821DFF50
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DFE00 Offset: 0x21DE400 VA: 0x1821DFE00
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	// RVA: 0x21E0C20 Offset: 0x21DF220 VA: 0x1821E0C20
	public void .ctor() { }

}

