public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 11790
{	// Fields
	[RangeAttribute] // RVA: 0x71810 Offset: 0x70C10 VA: 0x180071810
	[TooltipAttribute] // RVA: 0x71810 Offset: 0x70C10 VA: 0x180071810
	public FloatParameter intensity; // 0x30
	[RangeAttribute] // RVA: 0x719B0 Offset: 0x70DB0 VA: 0x1800719B0
	[DisplayNameAttribute] // RVA: 0x719B0 Offset: 0x70DB0 VA: 0x1800719B0
	[TooltipAttribute] // RVA: 0x719B0 Offset: 0x70DB0 VA: 0x1800719B0
	public FloatParameter intensityX; // 0x38
	[RangeAttribute] // RVA: 0x71B70 Offset: 0x70F70 VA: 0x180071B70
	[DisplayNameAttribute] // RVA: 0x71B70 Offset: 0x70F70 VA: 0x180071B70
	[TooltipAttribute] // RVA: 0x71B70 Offset: 0x70F70 VA: 0x180071B70
	public FloatParameter intensityY; // 0x40
	[SpaceAttribute] // RVA: 0x71E40 Offset: 0x71240 VA: 0x180071E40
	[RangeAttribute] // RVA: 0x71E40 Offset: 0x71240 VA: 0x180071E40
	[TooltipAttribute] // RVA: 0x71E40 Offset: 0x71240 VA: 0x180071E40
	public FloatParameter centerX; // 0x48
	[RangeAttribute] // RVA: 0x720F0 Offset: 0x714F0 VA: 0x1800720F0
	[TooltipAttribute] // RVA: 0x720F0 Offset: 0x714F0 VA: 0x1800720F0
	public FloatParameter centerY; // 0x50
	[SpaceAttribute] // RVA: 0x72300 Offset: 0x71700 VA: 0x180072300
	[RangeAttribute] // RVA: 0x72300 Offset: 0x71700 VA: 0x180072300
	[TooltipAttribute] // RVA: 0x72300 Offset: 0x71700 VA: 0x180072300
	public FloatParameter scale; // 0x58

	// Methods

	// RVA: 0x1017FA0 Offset: 0x10165A0 VA: 0x181017FA0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10180A0 Offset: 0x10166A0 VA: 0x1810180A0
	public void .ctor() { }

}

