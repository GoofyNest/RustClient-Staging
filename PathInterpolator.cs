public class PathInterpolator // TypeDefIndex: 11398
{	// Fields
	public Vector3[] Points; // 0x10
	public Vector3[] Tangents; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <MinIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <MaxIndex>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <StepSize>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Circular>k__BackingField; // 0x30
	protected bool initialized; // 0x31

	// Properties
	public int MinIndex { get; set; }
	public int MaxIndex { get; set; }
	public virtual float Length { get; set; }
	public virtual float StepSize { get; set; }
	public bool Circular { get; set; }
	public int DefaultMinIndex { get; }
	public int DefaultMaxIndex { get; }
	public float StartOffset { get; }
	public float EndOffset { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_MinIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x87E290 Offset: 0x87C890 VA: 0x18087E290 Slot: 4
	public virtual float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x87E300 Offset: 0x87C900 VA: 0x18087E300
	private void set_Length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x87E2F0 Offset: 0x87C8F0 VA: 0x18087E2F0 Slot: 5
	public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x87E310 Offset: 0x87C910 VA: 0x18087E310
	private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_Circular() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	private void set_Circular(bool value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public int get_DefaultMinIndex() { }

	// RVA: 0x87E210 Offset: 0x87C810 VA: 0x18087E210
	public int get_DefaultMaxIndex() { }

	// RVA: 0x87E2A0 Offset: 0x87C8A0 VA: 0x18087E2A0
	public float get_StartOffset() { }

	// RVA: 0x87E230 Offset: 0x87C830 VA: 0x18087E230
	public float get_EndOffset() { }

	// RVA: 0x87DEE0 Offset: 0x87C4E0 VA: 0x18087DEE0
	public void .ctor(Vector3[] points) { }

	// RVA: 0x87E060 Offset: 0x87C660 VA: 0x18087E060
	public void .ctor(Vector3[] points, Vector3[] tangents) { }

	// RVA: 0x87D3D0 Offset: 0x87B9D0 VA: 0x18087D3D0
	public void RecalculateTangents() { }

	// RVA: 0x87D210 Offset: 0x87B810 VA: 0x18087D210
	public void RecalculateLength() { }

	// RVA: 0x87D680 Offset: 0x87BC80 VA: 0x18087D680
	public void Resample(float distance) { }

	// RVA: 0x87DD60 Offset: 0x87C360 VA: 0x18087DD60
	public void Smoothen(int iterations, Func<int, float> filter) { }

	// RVA: 0x87DC40 Offset: 0x87C240 VA: 0x18087DC40
	public void Smoothen(int iterations, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x87D7F0 Offset: 0x87BDF0 VA: 0x18087D7F0
	private void SmoothenIndex(int i, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x87CDB0 Offset: 0x87B3B0 VA: 0x18087CDB0
	public Vector3 GetStartPoint() { }

	// RVA: 0x87C500 Offset: 0x87AB00 VA: 0x18087C500
	public Vector3 GetEndPoint() { }

	// RVA: 0x87CE10 Offset: 0x87B410 VA: 0x18087CE10
	public Vector3 GetStartTangent() { }

	// RVA: 0x87C560 Offset: 0x87AB60 VA: 0x18087C560
	public Vector3 GetEndTangent() { }

	// RVA: 0x87CB50 Offset: 0x87B150 VA: 0x18087CB50
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x87CEC0 Offset: 0x87B4C0 VA: 0x18087CEC0 Slot: 6
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x87C610 Offset: 0x87AC10 VA: 0x18087C610 Slot: 7
	public virtual Vector3 GetPointCubicHermite(float distance) { }

}

