public class Preset // TypeDefIndex: 11562
{	// Fields
	public bool DiagDetection; // 0x10
	public bool CornerDetection; // 0x11
	[RangeAttribute] // RVA: 0xC6610 Offset: 0xC5A10 VA: 0x1800C6610
	public float Threshold; // 0x14
	[MinAttribute] // RVA: 0xC64E0 Offset: 0xC58E0 VA: 0x1800C64E0
	public float DepthThreshold; // 0x18
	[RangeAttribute] // RVA: 0xC6730 Offset: 0xC5B30 VA: 0x1800C6730
	public int MaxSearchSteps; // 0x1C
	[RangeAttribute] // RVA: 0xC6A40 Offset: 0xC5E40 VA: 0x1800C6A40
	public int MaxSearchStepsDiag; // 0x20
	[RangeAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public int CornerRounding; // 0x24
	[MinAttribute] // RVA: 0xC6B50 Offset: 0xC5F50 VA: 0x1800C6B50
	public float LocalContrastAdaptationFactor; // 0x28

	// Methods

	// RVA: 0x5A4F30 Offset: 0x5A3530 VA: 0x1805A4F30
	public void .ctor() { }

}

