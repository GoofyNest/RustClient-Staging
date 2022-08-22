public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 3484
{	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[ObsoleteAttribute] // RVA: 0xB30E0 Offset: 0xB24E0 VA: 0x1800B30E0
	public readonly float minBrightness; // 0x14
	[ObsoleteAttribute] // RVA: 0xB30E0 Offset: 0xB24E0 VA: 0x1800B30E0
	public readonly float maxBrightness; // 0x18
	[ObsoleteAttribute] // RVA: 0xB30E0 Offset: 0xB24E0 VA: 0x1800B30E0
	public readonly float minExposureValue; // 0x1C
	[ObsoleteAttribute] // RVA: 0xB30E0 Offset: 0xB24E0 VA: 0x1800B30E0
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x1823F70 Offset: 0x1822570 VA: 0x181823F70
	public void .ctor(bool showAlpha) { }

	// RVA: 0x1823F10 Offset: 0x1822510 VA: 0x181823F10
	public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] // RVA: 0xB3460 Offset: 0xB2860 VA: 0x1800B3460
	// RVA: 0x1823FC0 Offset: 0x18225C0 VA: 0x181823FC0
	public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

