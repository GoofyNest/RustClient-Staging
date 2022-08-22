public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12125
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public float value; // 0x4

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Time(float value) { }

	public void .ctor(float time, float value) { }

	public void MatchValuesTo(FloatSnapshot entry) { }

	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	public FloatSnapshot GetNew() { }

}

