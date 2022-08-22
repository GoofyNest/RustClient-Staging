public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 10273
{	// Fields
	[HeaderAttribute] // RVA: 0xC3AA0 Offset: 0xC2EA0 VA: 0x1800C3AA0
	public BoolParameter applySharpen; // 0x30
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public FloatParameter strength; // 0x38
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public FloatParameter clamp; // 0x40
	[HeaderAttribute] // RVA: 0xC5040 Offset: 0xC4440 VA: 0x1800C5040
	public BoolParameter applyVignette; // 0x48
	[RangeAttribute] // RVA: 0xC5190 Offset: 0xC4590 VA: 0x1800C5190
	public FloatParameter sharpness; // 0x50
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public FloatParameter darkness; // 0x58

	// Methods

	// RVA: 0x594FF0 Offset: 0x5935F0 VA: 0x180594FF0
	public void .ctor() { }

}

