public class PathInterpolator // TypeDefIndex: 11398
{	// Fields
	public Vector3[] Points; // 0x10
	public Vector3[] Tangents; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <MinIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <MaxIndex>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <StepSize>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_MinIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20 Slot: 4
	public virtual float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x862A90 Offset: 0x861090 VA: 0x180862A90
	private void set_Length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x862A80 Offset: 0x861080 VA: 0x180862A80 Slot: 5
	public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x862AA0 Offset: 0x8610A0 VA: 0x180862AA0
	private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_Circular() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	private void set_Circular(bool value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public int get_DefaultMinIndex() { }

	// RVA: 0x8629A0 Offset: 0x860FA0 VA: 0x1808629A0
	public int get_DefaultMaxIndex() { }

	// RVA: 0x862A30 Offset: 0x861030 VA: 0x180862A30
	public float get_StartOffset() { }

	// RVA: 0x8629C0 Offset: 0x860FC0 VA: 0x1808629C0
	public float get_EndOffset() { }

	// RVA: 0x862670 Offset: 0x860C70 VA: 0x180862670
	public void .ctor(Vector3[] points) { }

	// RVA: 0x8627F0 Offset: 0x860DF0 VA: 0x1808627F0
	public void .ctor(Vector3[] points, Vector3[] tangents) { }

	// RVA: 0x861B60 Offset: 0x860160 VA: 0x180861B60
	public void RecalculateTangents() { }

	// RVA: 0x8619A0 Offset: 0x85FFA0 VA: 0x1808619A0
	public void RecalculateLength() { }

	// RVA: 0x861E10 Offset: 0x860410 VA: 0x180861E10
	public void Resample(float distance) { }

	// RVA: 0x8624F0 Offset: 0x860AF0 VA: 0x1808624F0
	public void Smoothen(int iterations, Func<int, float> filter) { }

	// RVA: 0x8623D0 Offset: 0x8609D0 VA: 0x1808623D0
	public void Smoothen(int iterations, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x861F80 Offset: 0x860580 VA: 0x180861F80
	private void SmoothenIndex(int i, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x861540 Offset: 0x85FB40 VA: 0x180861540
	public Vector3 GetStartPoint() { }

	// RVA: 0x860C90 Offset: 0x85F290 VA: 0x180860C90
	public Vector3 GetEndPoint() { }

	// RVA: 0x8615A0 Offset: 0x85FBA0 VA: 0x1808615A0
	public Vector3 GetStartTangent() { }

	// RVA: 0x860CF0 Offset: 0x85F2F0 VA: 0x180860CF0
	public Vector3 GetEndTangent() { }

	// RVA: 0x8612E0 Offset: 0x85F8E0 VA: 0x1808612E0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x861650 Offset: 0x85FC50 VA: 0x180861650 Slot: 6
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x860DA0 Offset: 0x85F3A0 VA: 0x180860DA0 Slot: 7
	public virtual Vector3 GetPointCubicHermite(float distance) { }

}

