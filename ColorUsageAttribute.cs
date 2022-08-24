public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 3484
{	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[ObsoleteAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	public readonly float minBrightness; // 0x14
	[ObsoleteAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	public readonly float maxBrightness; // 0x18
	[ObsoleteAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	public readonly float minExposureValue; // 0x1C
	[ObsoleteAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	public readonly float maxExposureValue; // 0x20


	public void .ctor(bool showAlpha) { }

	public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] // RVA: 0xB3540 Offset: 0xB2940 VA: 0x1800B3540
	public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

