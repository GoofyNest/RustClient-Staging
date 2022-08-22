public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12125
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public float value; // 0x4

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2370 Offset: 0xF1770 VA: 0x1800F2370
	public void .ctor(float time, float value) { }

	// RVA: 0xF2350 Offset: 0xF1750 VA: 0x1800F2350 Slot: 6
	public void MatchValuesTo(FloatSnapshot entry) { }

	// RVA: 0xF22D0 Offset: 0xF16D0 VA: 0x1800F22D0 Slot: 7
	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	// RVA: 0xF22B0 Offset: 0xF16B0 VA: 0x1800F22B0 Slot: 8
	public FloatSnapshot GetNew() { }

}

