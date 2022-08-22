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

	// RVA: 0x1823CB0 Offset: 0x18222B0 VA: 0x181823CB0
	public void .ctor(bool showAlpha) { }

	// RVA: 0x1823C50 Offset: 0x1822250 VA: 0x181823C50
	public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] // RVA: 0xB3460 Offset: 0xB2860 VA: 0x1800B3460
	// RVA: 0x1823D00 Offset: 0x1822300 VA: 0x181823D00
	public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

