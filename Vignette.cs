public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 11815
{	// Fields
	[TooltipAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	public VignetteModeParameter mode; // 0x30
	[TooltipAttribute] // RVA: 0x779F0 Offset: 0x76DF0 VA: 0x1800779F0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x77B30 Offset: 0x76F30 VA: 0x180077B30
	public Vector2Parameter center; // 0x40
	[RangeAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	[TooltipAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	public FloatParameter intensity; // 0x48
	[RangeAttribute] // RVA: 0x77E40 Offset: 0x77240 VA: 0x180077E40
	[TooltipAttribute] // RVA: 0x77E40 Offset: 0x77240 VA: 0x180077E40
	public FloatParameter smoothness; // 0x50
	[RangeAttribute] // RVA: 0x78040 Offset: 0x77440 VA: 0x180078040
	[TooltipAttribute] // RVA: 0x78040 Offset: 0x77440 VA: 0x180078040
	public FloatParameter roundness; // 0x58
	[TooltipAttribute] // RVA: 0x78190 Offset: 0x77590 VA: 0x180078190
	public BoolParameter rounded; // 0x60
	[TooltipAttribute] // RVA: 0x78340 Offset: 0x77740 VA: 0x180078340
	public TextureParameter mask; // 0x68
	[RangeAttribute] // RVA: 0x78470 Offset: 0x77870 VA: 0x180078470
	[TooltipAttribute] // RVA: 0x78470 Offset: 0x77870 VA: 0x180078470
	public FloatParameter opacity; // 0x70

	// Methods

	// RVA: 0x11EB240 Offset: 0x11E9840 VA: 0x1811EB240 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x11EB310 Offset: 0x11E9910 VA: 0x1811EB310
	public void .ctor() { }

}

