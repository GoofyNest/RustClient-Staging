public sealed class Fog // TypeDefIndex: 11787
{	// Fields
	[TooltipAttribute] // RVA: 0x709D0 Offset: 0x6FDD0 VA: 0x1800709D0
	public bool enabled; // 0x10
	[TooltipAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1015B50 Offset: 0x1014150 VA: 0x181015B50
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1015C80 Offset: 0x1014280 VA: 0x181015C80
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x1016010 Offset: 0x1014610 VA: 0x181016010
	public void .ctor() { }

}

