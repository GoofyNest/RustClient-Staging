public class RainEffect : WeatherEffect // TypeDefIndex: 10071
{	// Fields
	public int FadeStartDistance; // 0x48
	public int FadeEndDistance; // 0x4C
	public int FadeFalloff; // 0x50
	public bool Stormy; // 0x54

	// Methods

	// RVA: 0x6A6080 Offset: 0x6A4680 VA: 0x1806A6080 Slot: 6
	protected override float GetCurrentIntensity() { }

	// RVA: 0x5B1170 Offset: 0x5AF770 VA: 0x1805B1170 Slot: 7
	protected override float GetUpdateInterval(float intensity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void UpdatePosition(float intensity) { }

	// RVA: 0x5B11B0 Offset: 0x5AF7B0 VA: 0x1805B11B0
	public void .ctor() { }

}

