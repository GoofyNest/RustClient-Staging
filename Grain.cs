public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 11792
{	[TooltipAttribute] // RVA: 0x708A0 Offset: 0x6FCA0 VA: 0x1800708A0
	public BoolParameter colored; // 0x30
	[RangeAttribute] // RVA: 0x70990 Offset: 0x6FD90 VA: 0x180070990
	[TooltipAttribute] // RVA: 0x70990 Offset: 0x6FD90 VA: 0x180070990
	public FloatParameter intensity; // 0x38
	[RangeAttribute] // RVA: 0x70B70 Offset: 0x6FF70 VA: 0x180070B70
	[TooltipAttribute] // RVA: 0x70B70 Offset: 0x6FF70 VA: 0x180070B70
	public FloatParameter size; // 0x40
	[RangeAttribute] // RVA: 0x70D60 Offset: 0x70160 VA: 0x180070D60
	[DisplayNameAttribute] // RVA: 0x70D60 Offset: 0x70160 VA: 0x180070D60
	[TooltipAttribute] // RVA: 0x70D60 Offset: 0x70160 VA: 0x180070D60
	public FloatParameter lumContrib; // 0x48


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

