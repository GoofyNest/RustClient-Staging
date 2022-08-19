public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 11790
{	// Fields
	[RangeAttribute] // RVA: 0x716E0 Offset: 0x70AE0 VA: 0x1800716E0
	[TooltipAttribute] // RVA: 0x716E0 Offset: 0x70AE0 VA: 0x1800716E0
	public FloatParameter intensity; // 0x30
	[RangeAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	[DisplayNameAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	[TooltipAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	public FloatParameter intensityX; // 0x38
	[RangeAttribute] // RVA: 0x71A40 Offset: 0x70E40 VA: 0x180071A40
	[DisplayNameAttribute] // RVA: 0x71A40 Offset: 0x70E40 VA: 0x180071A40
	[TooltipAttribute] // RVA: 0x71A40 Offset: 0x70E40 VA: 0x180071A40
	public FloatParameter intensityY; // 0x40
	[SpaceAttribute] // RVA: 0x71C90 Offset: 0x71090 VA: 0x180071C90
	[RangeAttribute] // RVA: 0x71C90 Offset: 0x71090 VA: 0x180071C90
	[TooltipAttribute] // RVA: 0x71C90 Offset: 0x71090 VA: 0x180071C90
	public FloatParameter centerX; // 0x48
	[RangeAttribute] // RVA: 0x71F20 Offset: 0x71320 VA: 0x180071F20
	[TooltipAttribute] // RVA: 0x71F20 Offset: 0x71320 VA: 0x180071F20
	public FloatParameter centerY; // 0x50
	[SpaceAttribute] // RVA: 0x72170 Offset: 0x71570 VA: 0x180072170
	[RangeAttribute] // RVA: 0x72170 Offset: 0x71570 VA: 0x180072170
	[TooltipAttribute] // RVA: 0x72170 Offset: 0x71570 VA: 0x180072170
	public FloatParameter scale; // 0x58

	// Methods

	// RVA: 0x1017FA0 Offset: 0x10165A0 VA: 0x181017FA0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10180A0 Offset: 0x10166A0 VA: 0x1810180A0
	public void .ctor() { }

}

