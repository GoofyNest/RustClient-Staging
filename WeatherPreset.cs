public class WeatherPreset : ScriptableObject // TypeDefIndex: 10078
{	// Fields
	public WeatherPresetType Type; // 0x18
	public float Wind; // 0x1C
	public float Rain; // 0x20
	public float Thunder; // 0x24
	public float Rainbow; // 0x28
	public TOD_AtmosphereParameters Atmosphere; // 0x30
	public TOD_CloudParameters Clouds; // 0x38

	// Methods

	// RVA: 0x8F2E90 Offset: 0x8F1490 VA: 0x1808F2E90
	public void Apply(TOD_Sky sky) { }

	// RVA: 0x8F3070 Offset: 0x8F1670 VA: 0x1808F3070
	public void Copy(TOD_Sky sky) { }

	// RVA: 0x8F4B40 Offset: 0x8F3140 VA: 0x1808F4B40
	public void Reset() { }

	// RVA: 0x8F4D10 Offset: 0x8F3310 VA: 0x1808F4D10
	public void Set(WeatherPreset other) { }

	// RVA: 0x8F4F10 Offset: 0x8F3510 VA: 0x1808F4F10 Slot: 3
	public override string ToString() { }

	// RVA: 0x8F3250 Offset: 0x8F1850 VA: 0x1808F3250
	public void Fade(WeatherPreset a, WeatherPreset b, float t) { }

	// RVA: 0x8F4890 Offset: 0x8F2E90 VA: 0x1808F4890
	public void Override(WeatherPreset other) { }

	// RVA: 0x8F3C40 Offset: 0x8F2240 VA: 0x1808F3C40
	public void Max(WeatherPreset other) { }

	// RVA: 0x8F4570 Offset: 0x8F2B70 VA: 0x1808F4570
	public void Min(WeatherPreset other) { }

	// RVA: 0x8F3BC0 Offset: 0x8F21C0 VA: 0x1808F3BC0
	private void Fade(ref float x, float a, float b, float t) { }

	// RVA: 0x8F4880 Offset: 0x8F2E80 VA: 0x1808F4880
	private void Override(ref float x, float other) { }

	// RVA: 0x8F4470 Offset: 0x8F2A70 VA: 0x1808F4470
	private void Max(ref float x, float other) { }

	// RVA: 0x8F44F0 Offset: 0x8F2AF0 VA: 0x1808F44F0
	private void Min(ref float x, float other) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

