public sealed class Fog // TypeDefIndex: 11787
{	// Fields
	[TooltipAttribute] // RVA: 0x709D0 Offset: 0x6FDD0 VA: 0x1800709D0
	public bool enabled; // 0x10
	[TooltipAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x10165F0 Offset: 0x1014BF0 VA: 0x1810165F0
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1016720 Offset: 0x1014D20 VA: 0x181016720
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x1016AB0 Offset: 0x10150B0 VA: 0x181016AB0
	public void .ctor() { }

}

