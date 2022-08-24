public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 10273
{	[HeaderAttribute] // RVA: 0xC3B70 Offset: 0xC2F70 VA: 0x1800C3B70
	public BoolParameter applySharpen; // 0x30
	[RangeAttribute] // RVA: 0x75B10 Offset: 0x74F10 VA: 0x180075B10
	public FloatParameter strength; // 0x38
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public FloatParameter clamp; // 0x40
	[HeaderAttribute] // RVA: 0xC5120 Offset: 0xC4520 VA: 0x1800C5120
	public BoolParameter applyVignette; // 0x48
	[RangeAttribute] // RVA: 0xC5280 Offset: 0xC4680 VA: 0x1800C5280
	public FloatParameter sharpness; // 0x50
	[RangeAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public FloatParameter darkness; // 0x58


	public void .ctor() { }

}

