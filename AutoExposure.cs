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
	[RangeAttribute] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	[DisplayNameAttribute] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	[TooltipAttribute] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	public FloatParameter maxLuminance; // 0x40
	[MinAttribute] // RVA: 0xEA5F0 Offset: 0xE99F0 VA: 0x1800EA5F0
	[DisplayNameAttribute] // RVA: 0xEA5F0 Offset: 0xE99F0 VA: 0x1800EA5F0
	[TooltipAttribute] // RVA: 0xEA5F0 Offset: 0xE99F0 VA: 0x1800EA5F0
	public FloatParameter keyValue; // 0x48
	[DisplayNameAttribute] // RVA: 0xEA760 Offset: 0xE9B60 VA: 0x1800EA760
	[TooltipAttribute] // RVA: 0xEA760 Offset: 0xE9B60 VA: 0x1800EA760
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[MinAttribute] // RVA: 0xEA960 Offset: 0xE9D60 VA: 0x1800EA960
	[TooltipAttribute] // RVA: 0xEA960 Offset: 0xE9D60 VA: 0x1800EA960
	public FloatParameter speedUp; // 0x58
	[MinAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	[TooltipAttribute] // RVA: 0xEAA30 Offset: 0xE9E30 VA: 0x1800EAA30
	public FloatParameter speedDown; // 0x60

	// Methods

	// RVA: 0x9EDB70 Offset: 0x9EC170 VA: 0x1809EDB70 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9EDCE0 Offset: 0x9EC2E0 VA: 0x1809EDCE0
	public void .ctor() { }

}

