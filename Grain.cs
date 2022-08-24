public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 11792
{	[TooltipAttribute] // RVA: 0x710F0 Offset: 0x704F0 VA: 0x1800710F0
	public BoolParameter colored; // 0x30
	[RangeAttribute] // RVA: 0x711B0 Offset: 0x705B0 VA: 0x1800711B0
	[TooltipAttribute] // RVA: 0x711B0 Offset: 0x705B0 VA: 0x1800711B0
	public FloatParameter intensity; // 0x38
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	[TooltipAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public FloatParameter size; // 0x40
	[RangeAttribute] // RVA: 0x714B0 Offset: 0x708B0 VA: 0x1800714B0
	[DisplayNameAttribute] // RVA: 0x714B0 Offset: 0x708B0 VA: 0x1800714B0
	[TooltipAttribute] // RVA: 0x714B0 Offset: 0x708B0 VA: 0x1800714B0
	public FloatParameter lumContrib; // 0x48


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

