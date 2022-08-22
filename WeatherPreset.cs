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

	// RVA: 0x8F34B0 Offset: 0x8F1AB0 VA: 0x1808F34B0
	public void Apply(TOD_Sky sky) { }

	// RVA: 0x8F3690 Offset: 0x8F1C90 VA: 0x1808F3690
	public void Copy(TOD_Sky sky) { }

	// RVA: 0x8F5160 Offset: 0x8F3760 VA: 0x1808F5160
	public void Reset() { }

	// RVA: 0x8F5330 Offset: 0x8F3930 VA: 0x1808F5330
	public void Set(WeatherPreset other) { }

	// RVA: 0x8F5530 Offset: 0x8F3B30 VA: 0x1808F5530 Slot: 3
	public override string ToString() { }

	// RVA: 0x8F3870 Offset: 0x8F1E70 VA: 0x1808F3870
	public void Fade(WeatherPreset a, WeatherPreset b, float t) { }

	// RVA: 0x8F4EB0 Offset: 0x8F34B0 VA: 0x1808F4EB0
	public void Override(WeatherPreset other) { }

	// RVA: 0x8F4260 Offset: 0x8F2860 VA: 0x1808F4260
	public void Max(WeatherPreset other) { }

	// RVA: 0x8F4B90 Offset: 0x8F3190 VA: 0x1808F4B90
	public void Min(WeatherPreset other) { }

	// RVA: 0x8F41E0 Offset: 0x8F27E0 VA: 0x1808F41E0
	private void Fade(ref float x, float a, float b, float t) { }

	// RVA: 0x8F4EA0 Offset: 0x8F34A0 VA: 0x1808F4EA0
	private void Override(ref float x, float other) { }

	// RVA: 0x8F4A90 Offset: 0x8F3090 VA: 0x1808F4A90
	private void Max(ref float x, float other) { }

	// RVA: 0x8F4B10 Offset: 0x8F3110 VA: 0x1808F4B10
	private void Min(ref float x, float other) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

