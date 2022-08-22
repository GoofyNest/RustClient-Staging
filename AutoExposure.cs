public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 11765
{	// Fields
	[MinMaxAttribute] // RVA: 0xEA080 Offset: 0xE9480 VA: 0x1800EA080
	[DisplayNameAttribute] // RVA: 0xEA080 Offset: 0xE9480 VA: 0x1800EA080
	[TooltipAttribute] // RVA: 0xEA080 Offset: 0xE9480 VA: 0x1800EA080
	public Vector2Parameter filtering; // 0x30
	[RangeAttribute] // RVA: 0xEA2B0 Offset: 0xE96B0 VA: 0x1800EA2B0
	[DisplayNameAttribute] // RVA: 0xEA2B0 Offset: 0xE96B0 VA: 0x1800EA2B0
	[TooltipAttribute] // RVA: 0xEA2B0 Offset: 0xE96B0 VA: 0x1800EA2B0
	public FloatParameter minLuminance; // 0x38
	[RangeAttribute] // RVA: 0xEA4C0 Offset: 0xE98C0 VA: 0x1800EA4C0
	[DisplayNameAttribute] // RVA: 0xEA4C0 Offset: 0xE98C0 VA: 0x1800EA4C0
	[TooltipAttribute] // RVA: 0xEA4C0 Offset: 0xE98C0 VA: 0x1800EA4C0
	public FloatParameter maxLuminance; // 0x40
	[MinAttribute] // RVA: 0xEA710 Offset: 0xE9B10 VA: 0x1800EA710
	[DisplayNameAttribute] // RVA: 0xEA710 Offset: 0xE9B10 VA: 0x1800EA710
	[TooltipAttribute] // RVA: 0xEA710 Offset: 0xE9B10 VA: 0x1800EA710
	public FloatParameter keyValue; // 0x48
	[DisplayNameAttribute] // RVA: 0xEA860 Offset: 0xE9C60 VA: 0x1800EA860
	[TooltipAttribute] // RVA: 0xEA860 Offset: 0xE9C60 VA: 0x1800EA860
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[MinAttribute] // RVA: 0xEA9E0 Offset: 0xE9DE0 VA: 0x1800EA9E0
	[TooltipAttribute] // RVA: 0xEA9E0 Offset: 0xE9DE0 VA: 0x1800EA9E0
	public FloatParameter speedUp; // 0x58
	[MinAttribute] // RVA: 0xEAB10 Offset: 0xE9F10 VA: 0x1800EAB10
	[TooltipAttribute] // RVA: 0xEAB10 Offset: 0xE9F10 VA: 0x1800EAB10
	public FloatParameter speedDown; // 0x60

	// Methods

	// RVA: 0x9EDE30 Offset: 0x9EC430 VA: 0x1809EDE30 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9EDFA0 Offset: 0x9EC5A0 VA: 0x1809EDFA0
	public void .ctor() { }

}

