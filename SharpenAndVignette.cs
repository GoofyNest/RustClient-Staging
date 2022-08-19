public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 10273
{	// Fields
	[HeaderAttribute] // RVA: 0xC3A10 Offset: 0xC2E10 VA: 0x1800C3A10
	public BoolParameter applySharpen; // 0x30
	[RangeAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	public FloatParameter strength; // 0x38
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public FloatParameter clamp; // 0x40
	[HeaderAttribute] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	public BoolParameter applyVignette; // 0x48
	[RangeAttribute] // RVA: 0xC5020 Offset: 0xC4420 VA: 0x1800C5020
	public FloatParameter sharpness; // 0x50
	[RangeAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public FloatParameter darkness; // 0x58

	// Methods

	// RVA: 0x595060 Offset: 0x593660 VA: 0x180595060
	public void .ctor() { }

}

