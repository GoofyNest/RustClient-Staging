public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12124
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Time>k__BackingField; // 0x0
	public Vector3 pos; // 0x4
	public Quaternion rot; // 0x10

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF25C0 Offset: 0xF19C0 VA: 0x1800F25C0
	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	// RVA: 0xF2590 Offset: 0xF1990 VA: 0x1800F2590 Slot: 6
	public void MatchValuesTo(TransformSnapshot entry) { }

	// RVA: 0xF2430 Offset: 0xF1830 VA: 0x1800F2430 Slot: 7
	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	// RVA: 0xF2420 Offset: 0xF1820 VA: 0x1800F2420 Slot: 8
	public TransformSnapshot GetNew() { }

}

