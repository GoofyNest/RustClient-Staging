public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 10273
{	[HeaderAttribute] // RVA: 0xC23A0 Offset: 0xC17A0 VA: 0x1800C23A0
	public BoolParameter applySharpen; // 0x30
	[RangeAttribute] // RVA: 0x75B60 Offset: 0x74F60 VA: 0x180075B60
	public FloatParameter strength; // 0x38
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public FloatParameter clamp; // 0x40
	[HeaderAttribute] // RVA: 0xC38A0 Offset: 0xC2CA0 VA: 0x1800C38A0
	public BoolParameter applyVignette; // 0x48
	[RangeAttribute] // RVA: 0xC39B0 Offset: 0xC2DB0 VA: 0x1800C39B0
	public FloatParameter sharpness; // 0x50
	[RangeAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	public FloatParameter darkness; // 0x58


	public void .ctor() { }

}

