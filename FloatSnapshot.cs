public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12129
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Time>k__BackingField; // 0x0
	public float value; // 0x4

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_Time(float value) { }

	public void .ctor(float time, float value) { }

	public void MatchValuesTo(FloatSnapshot entry) { }

	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	public FloatSnapshot GetNew() { }

}

