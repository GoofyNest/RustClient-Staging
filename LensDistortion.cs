public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 11794
{	[RangeAttribute] // RVA: 0x71A50 Offset: 0x70E50 VA: 0x180071A50
	[TooltipAttribute] // RVA: 0x71A50 Offset: 0x70E50 VA: 0x180071A50
	public FloatParameter intensity; // 0x30
	[RangeAttribute] // RVA: 0x71C10 Offset: 0x71010 VA: 0x180071C10
	[DisplayNameAttribute] // RVA: 0x71C10 Offset: 0x71010 VA: 0x180071C10
	[TooltipAttribute] // RVA: 0x71C10 Offset: 0x71010 VA: 0x180071C10
	public FloatParameter intensityX; // 0x38
	[RangeAttribute] // RVA: 0x71E60 Offset: 0x71260 VA: 0x180071E60
	[DisplayNameAttribute] // RVA: 0x71E60 Offset: 0x71260 VA: 0x180071E60
	[TooltipAttribute] // RVA: 0x71E60 Offset: 0x71260 VA: 0x180071E60
	public FloatParameter intensityY; // 0x40
	[SpaceAttribute] // RVA: 0x72150 Offset: 0x71550 VA: 0x180072150
	[RangeAttribute] // RVA: 0x72150 Offset: 0x71550 VA: 0x180072150
	[TooltipAttribute] // RVA: 0x72150 Offset: 0x71550 VA: 0x180072150
	public FloatParameter centerX; // 0x48
	[RangeAttribute] // RVA: 0x723F0 Offset: 0x717F0 VA: 0x1800723F0
	[TooltipAttribute] // RVA: 0x723F0 Offset: 0x717F0 VA: 0x1800723F0
	public FloatParameter centerY; // 0x50
	[SpaceAttribute] // RVA: 0x725F0 Offset: 0x719F0 VA: 0x1800725F0
	[RangeAttribute] // RVA: 0x725F0 Offset: 0x719F0 VA: 0x1800725F0
	[TooltipAttribute] // RVA: 0x725F0 Offset: 0x719F0 VA: 0x1800725F0
	public FloatParameter scale; // 0x58


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

