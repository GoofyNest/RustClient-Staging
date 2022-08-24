public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 11794
{	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	[TooltipAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public FloatParameter intensity; // 0x30
	[RangeAttribute] // RVA: 0x71480 Offset: 0x70880 VA: 0x180071480
	[DisplayNameAttribute] // RVA: 0x71480 Offset: 0x70880 VA: 0x180071480
	[TooltipAttribute] // RVA: 0x71480 Offset: 0x70880 VA: 0x180071480
	public FloatParameter intensityX; // 0x38
	[RangeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[DisplayNameAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TooltipAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public FloatParameter intensityY; // 0x40
	[SpaceAttribute] // RVA: 0x71900 Offset: 0x70D00 VA: 0x180071900
	[RangeAttribute] // RVA: 0x71900 Offset: 0x70D00 VA: 0x180071900
	[TooltipAttribute] // RVA: 0x71900 Offset: 0x70D00 VA: 0x180071900
	public FloatParameter centerX; // 0x48
	[RangeAttribute] // RVA: 0x71B10 Offset: 0x70F10 VA: 0x180071B10
	[TooltipAttribute] // RVA: 0x71B10 Offset: 0x70F10 VA: 0x180071B10
	public FloatParameter centerY; // 0x50
	[SpaceAttribute] // RVA: 0x71CA0 Offset: 0x710A0 VA: 0x180071CA0
	[RangeAttribute] // RVA: 0x71CA0 Offset: 0x710A0 VA: 0x180071CA0
	[TooltipAttribute] // RVA: 0x71CA0 Offset: 0x710A0 VA: 0x180071CA0
	public FloatParameter scale; // 0x58


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

