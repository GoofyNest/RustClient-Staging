public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 11819
{	[TooltipAttribute] // RVA: 0x77580 Offset: 0x76980 VA: 0x180077580
	public VignetteModeParameter mode; // 0x30
	[TooltipAttribute] // RVA: 0x776B0 Offset: 0x76AB0 VA: 0x1800776B0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x77840 Offset: 0x76C40 VA: 0x180077840
	public Vector2Parameter center; // 0x40
	[RangeAttribute] // RVA: 0x77950 Offset: 0x76D50 VA: 0x180077950
	[TooltipAttribute] // RVA: 0x77950 Offset: 0x76D50 VA: 0x180077950
	public FloatParameter intensity; // 0x48
	[RangeAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	[TooltipAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	public FloatParameter smoothness; // 0x50
	[RangeAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	[TooltipAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	public FloatParameter roundness; // 0x58
	[TooltipAttribute] // RVA: 0x77DD0 Offset: 0x771D0 VA: 0x180077DD0
	public BoolParameter rounded; // 0x60
	[TooltipAttribute] // RVA: 0x77F30 Offset: 0x77330 VA: 0x180077F30
	public TextureParameter mask; // 0x68
	[RangeAttribute] // RVA: 0x78030 Offset: 0x77430 VA: 0x180078030
	[TooltipAttribute] // RVA: 0x78030 Offset: 0x77430 VA: 0x180078030
	public FloatParameter opacity; // 0x70


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

