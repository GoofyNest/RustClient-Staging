public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12128
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Time>k__BackingField; // 0x0
	public Vector3 pos; // 0x4
	public Quaternion rot; // 0x10

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_Time(float value) { }

	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	public void MatchValuesTo(TransformSnapshot entry) { }

	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	public TransformSnapshot GetNew() { }

}

