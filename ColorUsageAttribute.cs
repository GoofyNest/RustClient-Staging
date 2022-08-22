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

	// RVA: 0x18113B0 Offset: 0x180F9B0 VA: 0x1818113B0
	public void .ctor(bool showAlpha) { }

	// RVA: 0x1811350 Offset: 0x180F950 VA: 0x181811350
	public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] // RVA: 0xB3460 Offset: 0xB2860 VA: 0x1800B3460
	// RVA: 0x1811400 Offset: 0x180FA00 VA: 0x181811400
	public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

