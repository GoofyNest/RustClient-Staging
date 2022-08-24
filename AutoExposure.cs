public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 11769
{	[MinMaxAttribute] // RVA: 0xEA3A0 Offset: 0xE97A0 VA: 0x1800EA3A0
	[DisplayNameAttribute] // RVA: 0xEA3A0 Offset: 0xE97A0 VA: 0x1800EA3A0
	[TooltipAttribute] // RVA: 0xEA3A0 Offset: 0xE97A0 VA: 0x1800EA3A0
	public Vector2Parameter filtering; // 0x30
	[RangeAttribute] // RVA: 0xEA4D0 Offset: 0xE98D0 VA: 0x1800EA4D0
	[DisplayNameAttribute] // RVA: 0xEA4D0 Offset: 0xE98D0 VA: 0x1800EA4D0
	[TooltipAttribute] // RVA: 0xEA4D0 Offset: 0xE98D0 VA: 0x1800EA4D0
	public FloatParameter minLuminance; // 0x38
	[RangeAttribute] // RVA: 0xEA790 Offset: 0xE9B90 VA: 0x1800EA790
	[DisplayNameAttribute] // RVA: 0xEA790 Offset: 0xE9B90 VA: 0x1800EA790
	[TooltipAttribute] // RVA: 0xEA790 Offset: 0xE9B90 VA: 0x1800EA790
	public FloatParameter maxLuminance; // 0x40
	[MinAttribute] // RVA: 0xEA910 Offset: 0xE9D10 VA: 0x1800EA910
	[DisplayNameAttribute] // RVA: 0xEA910 Offset: 0xE9D10 VA: 0x1800EA910
	[TooltipAttribute] // RVA: 0xEA910 Offset: 0xE9D10 VA: 0x1800EA910
	public FloatParameter keyValue; // 0x48
	[DisplayNameAttribute] // RVA: 0xEAAA0 Offset: 0xE9EA0 VA: 0x1800EAAA0
	[TooltipAttribute] // RVA: 0xEAAA0 Offset: 0xE9EA0 VA: 0x1800EAAA0
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[MinAttribute] // RVA: 0xEAC50 Offset: 0xEA050 VA: 0x1800EAC50
	[TooltipAttribute] // RVA: 0xEAC50 Offset: 0xEA050 VA: 0x1800EAC50
	public FloatParameter speedUp; // 0x58
	[MinAttribute] // RVA: 0xEAE80 Offset: 0xEA280 VA: 0x1800EAE80
	[TooltipAttribute] // RVA: 0xEAE80 Offset: 0xEA280 VA: 0x1800EAE80
	public FloatParameter speedDown; // 0x60


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

