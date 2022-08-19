public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 11788
{	// Fields
	[TooltipAttribute] // RVA: 0x70D00 Offset: 0x70100 VA: 0x180070D00
	public BoolParameter colored; // 0x30
	[RangeAttribute] // RVA: 0x70DF0 Offset: 0x701F0 VA: 0x180070DF0
	[TooltipAttribute] // RVA: 0x70DF0 Offset: 0x701F0 VA: 0x180070DF0
	public FloatParameter intensity; // 0x38
	[RangeAttribute] // RVA: 0x70FD0 Offset: 0x703D0 VA: 0x180070FD0
	[TooltipAttribute] // RVA: 0x70FD0 Offset: 0x703D0 VA: 0x180070FD0
	public FloatParameter size; // 0x40
	[RangeAttribute] // RVA: 0x71140 Offset: 0x70540 VA: 0x180071140
	[DisplayNameAttribute] // RVA: 0x71140 Offset: 0x70540 VA: 0x180071140
	[TooltipAttribute] // RVA: 0x71140 Offset: 0x70540 VA: 0x180071140
	public FloatParameter lumContrib; // 0x48

	// Methods

	// RVA: 0x9F19D0 Offset: 0x9EFFD0 VA: 0x1809F19D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10166E0 Offset: 0x1014CE0 VA: 0x1810166E0
	public void .ctor() { }

}

