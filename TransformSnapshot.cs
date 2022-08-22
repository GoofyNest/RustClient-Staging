public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12124
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public Vector3 pos; // 0x4
	public Quaternion rot; // 0x10

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2540 Offset: 0xF1940 VA: 0x1800F2540
	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	// RVA: 0xF2510 Offset: 0xF1910 VA: 0x1800F2510 Slot: 6
	public void MatchValuesTo(TransformSnapshot entry) { }

	// RVA: 0xF23B0 Offset: 0xF17B0 VA: 0x1800F23B0 Slot: 7
	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	// RVA: 0xF23A0 Offset: 0xF17A0 VA: 0x1800F23A0 Slot: 8
	public TransformSnapshot GetNew() { }

}

