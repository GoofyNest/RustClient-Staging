public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 11815
{	// Fields
	[TooltipAttribute] // RVA: 0x77A90 Offset: 0x76E90 VA: 0x180077A90
	public VignetteModeParameter mode; // 0x30
	[TooltipAttribute] // RVA: 0x77B60 Offset: 0x76F60 VA: 0x180077B60
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x77C40 Offset: 0x77040 VA: 0x180077C40
	public Vector2Parameter center; // 0x40
	[RangeAttribute] // RVA: 0x77DB0 Offset: 0x771B0 VA: 0x180077DB0
	[TooltipAttribute] // RVA: 0x77DB0 Offset: 0x771B0 VA: 0x180077DB0
	public FloatParameter intensity; // 0x48
	[RangeAttribute] // RVA: 0x77F40 Offset: 0x77340 VA: 0x180077F40
	[TooltipAttribute] // RVA: 0x77F40 Offset: 0x77340 VA: 0x180077F40
	public FloatParameter smoothness; // 0x50
	[RangeAttribute] // RVA: 0x78140 Offset: 0x77540 VA: 0x180078140
	[TooltipAttribute] // RVA: 0x78140 Offset: 0x77540 VA: 0x180078140
	public FloatParameter roundness; // 0x58
	[TooltipAttribute] // RVA: 0x782D0 Offset: 0x776D0 VA: 0x1800782D0
	public BoolParameter rounded; // 0x60
	[TooltipAttribute] // RVA: 0x78480 Offset: 0x77880 VA: 0x180078480
	public TextureParameter mask; // 0x68
	[RangeAttribute] // RVA: 0x78600 Offset: 0x77A00 VA: 0x180078600
	[TooltipAttribute] // RVA: 0x78600 Offset: 0x77A00 VA: 0x180078600
	public FloatParameter opacity; // 0x70

	// Methods

	// RVA: 0x11EB500 Offset: 0x11E9B00 VA: 0x1811EB500 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x11EB5D0 Offset: 0x11E9BD0 VA: 0x1811EB5D0
	public void .ctor() { }

}

