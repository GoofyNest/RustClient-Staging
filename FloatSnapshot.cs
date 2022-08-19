public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12125
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Time>k__BackingField; // 0x0
	public float value; // 0x4

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF23F0 Offset: 0xF17F0 VA: 0x1800F23F0
	public void .ctor(float time, float value) { }

	// RVA: 0xF23D0 Offset: 0xF17D0 VA: 0x1800F23D0 Slot: 6
	public void MatchValuesTo(FloatSnapshot entry) { }

	// RVA: 0xF2350 Offset: 0xF1750 VA: 0x1800F2350 Slot: 7
	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	// RVA: 0xF2330 Offset: 0xF1730 VA: 0x1800F2330 Slot: 8
	public FloatSnapshot GetNew() { }

}

