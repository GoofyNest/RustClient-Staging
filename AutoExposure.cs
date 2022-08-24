public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 11769
{	[MinMaxAttribute] // RVA: 0xE9D60 Offset: 0xE9160 VA: 0x1800E9D60
	[DisplayNameAttribute] // RVA: 0xE9D60 Offset: 0xE9160 VA: 0x1800E9D60
	[TooltipAttribute] // RVA: 0xE9D60 Offset: 0xE9160 VA: 0x1800E9D60
	public Vector2Parameter filtering; // 0x30
	[RangeAttribute] // RVA: 0xE9FE0 Offset: 0xE93E0 VA: 0x1800E9FE0
	[DisplayNameAttribute] // RVA: 0xE9FE0 Offset: 0xE93E0 VA: 0x1800E9FE0
	[TooltipAttribute] // RVA: 0xE9FE0 Offset: 0xE93E0 VA: 0x1800E9FE0
	public FloatParameter minLuminance; // 0x38
	[RangeAttribute] // RVA: 0xEA1C0 Offset: 0xE95C0 VA: 0x1800EA1C0
	[DisplayNameAttribute] // RVA: 0xEA1C0 Offset: 0xE95C0 VA: 0x1800EA1C0
	[TooltipAttribute] // RVA: 0xEA1C0 Offset: 0xE95C0 VA: 0x1800EA1C0
	public FloatParameter maxLuminance; // 0x40
	[MinAttribute] // RVA: 0xEA240 Offset: 0xE9640 VA: 0x1800EA240
	[DisplayNameAttribute] // RVA: 0xEA240 Offset: 0xE9640 VA: 0x1800EA240
	[TooltipAttribute] // RVA: 0xEA240 Offset: 0xE9640 VA: 0x1800EA240
	public FloatParameter keyValue; // 0x48
	[DisplayNameAttribute] // RVA: 0xEA460 Offset: 0xE9860 VA: 0x1800EA460
	[TooltipAttribute] // RVA: 0xEA460 Offset: 0xE9860 VA: 0x1800EA460
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[MinAttribute] // RVA: 0xEA570 Offset: 0xE9970 VA: 0x1800EA570
	[TooltipAttribute] // RVA: 0xEA570 Offset: 0xE9970 VA: 0x1800EA570
	public FloatParameter speedUp; // 0x58
	[MinAttribute] // RVA: 0xEA7D0 Offset: 0xE9BD0 VA: 0x1800EA7D0
	[TooltipAttribute] // RVA: 0xEA7D0 Offset: 0xE9BD0 VA: 0x1800EA7D0
	public FloatParameter speedDown; // 0x60


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

