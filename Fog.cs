public sealed class Fog // TypeDefIndex: 11787
{	// Fields
	[TooltipAttribute] // RVA: 0x709D0 Offset: 0x6FDD0 VA: 0x1800709D0
	public bool enabled; // 0x10
	[TooltipAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1015890 Offset: 0x1013E90 VA: 0x181015890
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10159C0 Offset: 0x1013FC0 VA: 0x1810159C0
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x1015D50 Offset: 0x1014350 VA: 0x181015D50
	public void .ctor() { }

}

