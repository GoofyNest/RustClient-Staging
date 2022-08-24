public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 11819
{	[TooltipAttribute] // RVA: 0x77C80 Offset: 0x77080 VA: 0x180077C80
	public VignetteModeParameter mode; // 0x30
	[TooltipAttribute] // RVA: 0x77DB0 Offset: 0x771B0 VA: 0x180077DB0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x77EC0 Offset: 0x772C0 VA: 0x180077EC0
	public Vector2Parameter center; // 0x40
	[RangeAttribute] // RVA: 0x78040 Offset: 0x77440 VA: 0x180078040
	[TooltipAttribute] // RVA: 0x78040 Offset: 0x77440 VA: 0x180078040
	public FloatParameter intensity; // 0x48
	[RangeAttribute] // RVA: 0x78230 Offset: 0x77630 VA: 0x180078230
	[TooltipAttribute] // RVA: 0x78230 Offset: 0x77630 VA: 0x180078230
	public FloatParameter smoothness; // 0x50
	[RangeAttribute] // RVA: 0x783E0 Offset: 0x777E0 VA: 0x1800783E0
	[TooltipAttribute] // RVA: 0x783E0 Offset: 0x777E0 VA: 0x1800783E0
	public FloatParameter roundness; // 0x58
	[TooltipAttribute] // RVA: 0x785D0 Offset: 0x779D0 VA: 0x1800785D0
	public BoolParameter rounded; // 0x60
	[TooltipAttribute] // RVA: 0x78780 Offset: 0x77B80 VA: 0x180078780
	public TextureParameter mask; // 0x68
	[RangeAttribute] // RVA: 0x788C0 Offset: 0x77CC0 VA: 0x1800788C0
	[TooltipAttribute] // RVA: 0x788C0 Offset: 0x77CC0 VA: 0x1800788C0
	public FloatParameter opacity; // 0x70


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

