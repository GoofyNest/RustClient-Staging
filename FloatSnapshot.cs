public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12129
{
	[CompilerGeneratedAttribute] 
	private float <Time>k__BackingField; 
	public float value; 

	public float Time { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Time() { }

	[CompilerGeneratedAttribute] 
	public void set_Time(float value) { }

	public void .ctor(float time, float value) { }

	public void MatchValuesTo(FloatSnapshot entry) { }

	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	public FloatSnapshot GetNew() { }

}

