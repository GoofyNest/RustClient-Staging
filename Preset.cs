public class Preset // TypeDefIndex: 11566
{	public bool DiagDetection; // 0x10
	public bool CornerDetection; // 0x11
	[RangeAttribute] // RVA: 0xC6910 Offset: 0xC5D10 VA: 0x1800C6910
	public float Threshold; // 0x14
	[MinAttribute] // RVA: 0xC6790 Offset: 0xC5B90 VA: 0x1800C6790
	public float DepthThreshold; // 0x18
	[RangeAttribute] // RVA: 0xC6C30 Offset: 0xC6030 VA: 0x1800C6C30
	public int MaxSearchSteps; // 0x1C
	[RangeAttribute] // RVA: 0xC6CE0 Offset: 0xC60E0 VA: 0x1800C6CE0
	public int MaxSearchStepsDiag; // 0x20
	[RangeAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public int CornerRounding; // 0x24
	[MinAttribute] // RVA: 0xC6E10 Offset: 0xC6210 VA: 0x1800C6E10
	public float LocalContrastAdaptationFactor; // 0x28


	public void .ctor() { }

}

