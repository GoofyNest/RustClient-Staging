public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D5C0 Offset: 0x7C9C0 VA: 0x18007D5C0
[DefaultMemberAttribute] // RVA: 0x7D5C0 Offset: 0x7C9C0 VA: 0x18007D5C0
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float3 yzx { get; }

	// Methods

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x22AE6F0 Offset: 0x22ACCF0 VA: 0x1822AE6F0
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x22AE790 Offset: 0x22ACD90 VA: 0x1822AE790
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x22AE740 Offset: 0x22ACD40 VA: 0x1822AE740
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x22AE660 Offset: 0x22ACC60 VA: 0x1822AE660
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x22AE7D0 Offset: 0x22ACDD0 VA: 0x1822AE7D0
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x22AE6B0 Offset: 0x22ACCB0 VA: 0x1822AE6B0
	public static float3 op_Division(float3 lhs, float rhs) { }

	// RVA: 0x22AE820 Offset: 0x22ACE20 VA: 0x1822AE820
	public static float3 op_UnaryNegation(float3 val) { }

	// RVA: 0x239F80 Offset: 0x239380 VA: 0x180239F80
	public float3 get_yzx() { }

	// RVA: 0x236190 Offset: 0x235590 VA: 0x180236190 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x239CA0 Offset: 0x2390A0 VA: 0x180239CA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239D60 Offset: 0x239160 VA: 0x180239D60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239E10 Offset: 0x239210 VA: 0x180239E10 Slot: 3
	public override string ToString() { }

	// RVA: 0x239EC0 Offset: 0x2392C0 VA: 0x180239EC0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1EFA2A0 Offset: 0x1EF88A0 VA: 0x181EFA2A0
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x1EFA270 Offset: 0x1EF8870 VA: 0x181EFA270
	public static float3 op_Implicit(Vector3 v) { }

}

