public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D8A0 Offset: 0x7CCA0 VA: 0x18007D8A0
[DefaultMemberAttribute] // RVA: 0x7D8A0 Offset: 0x7CCA0 VA: 0x18007D8A0
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 xyzx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 yzxy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 yzxz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 zxyy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 zxyz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 wwwx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float4 wwww { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	public float3 xyz { get; }

	// Methods

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x23A150 Offset: 0x239550 VA: 0x18023A150
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x22AED50 Offset: 0x22AD350 VA: 0x1822AED50
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x22AEDD0 Offset: 0x22AD3D0 VA: 0x1822AEDD0
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x22AEDB0 Offset: 0x22AD3B0 VA: 0x1822AEDB0
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x22AECF0 Offset: 0x22AD2F0 VA: 0x1822AECF0
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x22AEDF0 Offset: 0x22AD3F0 VA: 0x1822AEDF0
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x22AEE50 Offset: 0x22AD450 VA: 0x1822AEE50
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0x23A1E0 Offset: 0x2395E0 VA: 0x18023A1E0
	public float4 get_xyzx() { }

	// RVA: 0x23A200 Offset: 0x239600 VA: 0x18023A200
	public float4 get_yzxy() { }

	// RVA: 0x23A220 Offset: 0x239620 VA: 0x18023A220
	public float4 get_yzxz() { }

	// RVA: 0x23A240 Offset: 0x239640 VA: 0x18023A240
	public float4 get_zxyy() { }

	// RVA: 0x23A260 Offset: 0x239660 VA: 0x18023A260
	public float4 get_zxyz() { }

	// RVA: 0x23A1A0 Offset: 0x2395A0 VA: 0x18023A1A0
	public float4 get_wwwx() { }

	// RVA: 0x23A190 Offset: 0x239590 VA: 0x18023A190
	public float4 get_wwww() { }

	// RVA: 0x23A1C0 Offset: 0x2395C0 VA: 0x18023A1C0
	public float3 get_xyz() { }

	// RVA: 0x2367F0 Offset: 0x235BF0 VA: 0x1802367F0 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x239FA0 Offset: 0x2393A0 VA: 0x180239FA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23A050 Offset: 0x239450 VA: 0x18023A050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A130 Offset: 0x239530 VA: 0x18023A130 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A140 Offset: 0x239540 VA: 0x18023A140 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

