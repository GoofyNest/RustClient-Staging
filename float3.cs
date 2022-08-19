public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D4F0 Offset: 0x7C8F0 VA: 0x18007D4F0
[DefaultMemberAttribute] // RVA: 0x7D4F0 Offset: 0x7C8F0 VA: 0x18007D4F0
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float3 yzx { get; }

	// Methods

	// RVA: 0xFB580 Offset: 0xFA980 VA: 0x1800FB580
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x22ADDD0 Offset: 0x22AC3D0 VA: 0x1822ADDD0
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x22ADE70 Offset: 0x22AC470 VA: 0x1822ADE70
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x22ADE20 Offset: 0x22AC420 VA: 0x1822ADE20
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x22ADD40 Offset: 0x22AC340 VA: 0x1822ADD40
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x22ADEB0 Offset: 0x22AC4B0 VA: 0x1822ADEB0
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x22ADD90 Offset: 0x22AC390 VA: 0x1822ADD90
	public static float3 op_Division(float3 lhs, float rhs) { }

	// RVA: 0x22ADF00 Offset: 0x22AC500 VA: 0x1822ADF00
	public static float3 op_UnaryNegation(float3 val) { }

	// RVA: 0x23A000 Offset: 0x239400 VA: 0x18023A000
	public float3 get_yzx() { }

	// RVA: 0x236210 Offset: 0x235610 VA: 0x180236210 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x239D20 Offset: 0x239120 VA: 0x180239D20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239DE0 Offset: 0x2391E0 VA: 0x180239DE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239E90 Offset: 0x239290 VA: 0x180239E90 Slot: 3
	public override string ToString() { }

	// RVA: 0x239F40 Offset: 0x239340 VA: 0x180239F40 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1EF9980 Offset: 0x1EF7F80 VA: 0x181EF9980
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x1EF9950 Offset: 0x1EF7F50 VA: 0x181EF9950
	public static float3 op_Implicit(Vector3 v) { }

}

