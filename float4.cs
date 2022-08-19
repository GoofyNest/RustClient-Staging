public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D790 Offset: 0x7CB90 VA: 0x18007D790
[DefaultMemberAttribute] // RVA: 0x7D790 Offset: 0x7CB90 VA: 0x18007D790
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 xyzx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 yzxy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 yzxz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 zxyy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 zxyz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 wwwx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float4 wwww { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	public float3 xyz { get; }

	// Methods

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x23A1D0 Offset: 0x2395D0 VA: 0x18023A1D0
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x22AE430 Offset: 0x22ACA30 VA: 0x1822AE430
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x22AE4B0 Offset: 0x22ACAB0 VA: 0x1822AE4B0
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x22AE490 Offset: 0x22ACA90 VA: 0x1822AE490
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x22AE3D0 Offset: 0x22AC9D0 VA: 0x1822AE3D0
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x22AE4D0 Offset: 0x22ACAD0 VA: 0x1822AE4D0
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x22AE530 Offset: 0x22ACB30 VA: 0x1822AE530
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0x23A260 Offset: 0x239660 VA: 0x18023A260
	public float4 get_xyzx() { }

	// RVA: 0x23A280 Offset: 0x239680 VA: 0x18023A280
	public float4 get_yzxy() { }

	// RVA: 0x23A2A0 Offset: 0x2396A0 VA: 0x18023A2A0
	public float4 get_yzxz() { }

	// RVA: 0x23A2C0 Offset: 0x2396C0 VA: 0x18023A2C0
	public float4 get_zxyy() { }

	// RVA: 0x23A2E0 Offset: 0x2396E0 VA: 0x18023A2E0
	public float4 get_zxyz() { }

	// RVA: 0x23A220 Offset: 0x239620 VA: 0x18023A220
	public float4 get_wwwx() { }

	// RVA: 0x23A210 Offset: 0x239610 VA: 0x18023A210
	public float4 get_wwww() { }

	// RVA: 0x23A240 Offset: 0x239640 VA: 0x18023A240
	public float3 get_xyz() { }

	// RVA: 0x236870 Offset: 0x235C70 VA: 0x180236870 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x23A020 Offset: 0x239420 VA: 0x18023A020 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23A0D0 Offset: 0x2394D0 VA: 0x18023A0D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A1B0 Offset: 0x2395B0 VA: 0x18023A1B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A1C0 Offset: 0x2395C0 VA: 0x18023A1C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

