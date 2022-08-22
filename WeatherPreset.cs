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

	// RVA: 0x8F2FA0 Offset: 0x8F15A0 VA: 0x1808F2FA0
	public void Apply(TOD_Sky sky) { }

	// RVA: 0x8F3180 Offset: 0x8F1780 VA: 0x1808F3180
	public void Copy(TOD_Sky sky) { }

	// RVA: 0x8F4C50 Offset: 0x8F3250 VA: 0x1808F4C50
	public void Reset() { }

	// RVA: 0x8F4E20 Offset: 0x8F3420 VA: 0x1808F4E20
	public void Set(WeatherPreset other) { }

	// RVA: 0x8F5020 Offset: 0x8F3620 VA: 0x1808F5020 Slot: 3
	public override string ToString() { }

	// RVA: 0x8F3360 Offset: 0x8F1960 VA: 0x1808F3360
	public void Fade(WeatherPreset a, WeatherPreset b, float t) { }

	// RVA: 0x8F49A0 Offset: 0x8F2FA0 VA: 0x1808F49A0
	public void Override(WeatherPreset other) { }

	// RVA: 0x8F3D50 Offset: 0x8F2350 VA: 0x1808F3D50
	public void Max(WeatherPreset other) { }

	// RVA: 0x8F4680 Offset: 0x8F2C80 VA: 0x1808F4680
	public void Min(WeatherPreset other) { }

	// RVA: 0x8F3CD0 Offset: 0x8F22D0 VA: 0x1808F3CD0
	private void Fade(ref float x, float a, float b, float t) { }

	// RVA: 0x8F4990 Offset: 0x8F2F90 VA: 0x1808F4990
	private void Override(ref float x, float other) { }

	// RVA: 0x8F4580 Offset: 0x8F2B80 VA: 0x1808F4580
	private void Max(ref float x, float other) { }

	// RVA: 0x8F4600 Offset: 0x8F2C00 VA: 0x1808F4600
	private void Min(ref float x, float other) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

