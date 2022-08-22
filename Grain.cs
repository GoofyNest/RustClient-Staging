public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 11788
{	// Fields
	[TooltipAttribute] // RVA: 0x70E30 Offset: 0x70230 VA: 0x180070E30
	public BoolParameter colored; // 0x30
	[RangeAttribute] // RVA: 0x70F40 Offset: 0x70340 VA: 0x180070F40
	[TooltipAttribute] // RVA: 0x70F40 Offset: 0x70340 VA: 0x180070F40
	public FloatParameter intensity; // 0x38
	[RangeAttribute] // RVA: 0x710D0 Offset: 0x704D0 VA: 0x1800710D0
	[TooltipAttribute] // RVA: 0x710D0 Offset: 0x704D0 VA: 0x1800710D0
	public FloatParameter size; // 0x40
	[RangeAttribute] // RVA: 0x71290 Offset: 0x70690 VA: 0x180071290
	[DisplayNameAttribute] // RVA: 0x71290 Offset: 0x70690 VA: 0x180071290
	[TooltipAttribute] // RVA: 0x71290 Offset: 0x70690 VA: 0x180071290
	public FloatParameter lumContrib; // 0x48

	// Methods

	// RVA: 0x9F19D0 Offset: 0x9EFFD0 VA: 0x1809F19D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10166E0 Offset: 0x1014CE0 VA: 0x1810166E0
	public void .ctor() { }

}

