public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12124
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Time>k__BackingField; // 0x0
	public Vector3 pos; // 0x4
	public Quaternion rot; // 0x10

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Time(float value) { }

	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	public void MatchValuesTo(TransformSnapshot entry) { }

	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	public TransformSnapshot GetNew() { }

}

