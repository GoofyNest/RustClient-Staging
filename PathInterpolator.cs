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
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_MinIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x862B30 Offset: 0x861130 VA: 0x180862B30 Slot: 4
	public virtual float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x862BA0 Offset: 0x8611A0 VA: 0x180862BA0
	private void set_Length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x862B90 Offset: 0x861190 VA: 0x180862B90 Slot: 5
	public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x862BB0 Offset: 0x8611B0 VA: 0x180862BB0
	private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_Circular() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	private void set_Circular(bool value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public int get_DefaultMinIndex() { }

	// RVA: 0x862AB0 Offset: 0x8610B0 VA: 0x180862AB0
	public int get_DefaultMaxIndex() { }

	// RVA: 0x862B40 Offset: 0x861140 VA: 0x180862B40
	public float get_StartOffset() { }

	// RVA: 0x862AD0 Offset: 0x8610D0 VA: 0x180862AD0
	public float get_EndOffset() { }

	// RVA: 0x862780 Offset: 0x860D80 VA: 0x180862780
	public void .ctor(Vector3[] points) { }

	// RVA: 0x862900 Offset: 0x860F00 VA: 0x180862900
	public void .ctor(Vector3[] points, Vector3[] tangents) { }

	// RVA: 0x861C70 Offset: 0x860270 VA: 0x180861C70
	public void RecalculateTangents() { }

	// RVA: 0x861AB0 Offset: 0x8600B0 VA: 0x180861AB0
	public void RecalculateLength() { }

	// RVA: 0x861F20 Offset: 0x860520 VA: 0x180861F20
	public void Resample(float distance) { }

	// RVA: 0x862600 Offset: 0x860C00 VA: 0x180862600
	public void Smoothen(int iterations, Func<int, float> filter) { }

	// RVA: 0x8624E0 Offset: 0x860AE0 VA: 0x1808624E0
	public void Smoothen(int iterations, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x862090 Offset: 0x860690 VA: 0x180862090
	private void SmoothenIndex(int i, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x861650 Offset: 0x85FC50 VA: 0x180861650
	public Vector3 GetStartPoint() { }

	// RVA: 0x860DA0 Offset: 0x85F3A0 VA: 0x180860DA0
	public Vector3 GetEndPoint() { }

	// RVA: 0x8616B0 Offset: 0x85FCB0 VA: 0x1808616B0
	public Vector3 GetStartTangent() { }

	// RVA: 0x860E00 Offset: 0x85F400 VA: 0x180860E00
	public Vector3 GetEndTangent() { }

	// RVA: 0x8613F0 Offset: 0x85F9F0 VA: 0x1808613F0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x861760 Offset: 0x85FD60 VA: 0x180861760 Slot: 6
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x860EB0 Offset: 0x85F4B0 VA: 0x180860EB0 Slot: 7
	public virtual Vector3 GetPointCubicHermite(float distance) { }

}

