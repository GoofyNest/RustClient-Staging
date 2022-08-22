public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
{
// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x7F740 Offset: 0x7EB40 VA: 0x18007F740
[DebuggerTypeProxyAttribute] // RVA: 0x7F740 Offset: 0x7EB40 VA: 0x18007F740
[Serializable]
public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x23A740 Offset: 0x239B40 VA: 0x18023A740
	public void .ctor(int v) { }

	// RVA: 0x23A750 Offset: 0x239B50 VA: 0x18023A750
	public void .ctor(float2 v) { }

	// RVA: 0x22AE810 Offset: 0x22ACE10 VA: 0x1822AE810
	public static int2 op_Implicit(int v) { }

	// RVA: 0x2271B60 Offset: 0x2270160 VA: 0x182271B60
	public static int2 op_Explicit(float2 v) { }

	// RVA: 0x22AE7F0 Offset: 0x22ACDF0 VA: 0x1822AE7F0
	public static int2 op_Addition(int2 lhs, int rhs) { }

	// RVA: 0x22AE820 Offset: 0x22ACE20 VA: 0x1822AE820
	public static int2 op_Subtraction(int2 lhs, int rhs) { }

	// RVA: 0xF94A0 Offset: 0xF88A0 VA: 0x1800F94A0 Slot: 4
	public bool Equals(int2 rhs) { }

	// RVA: 0x23A570 Offset: 0x239970 VA: 0x18023A570 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23A600 Offset: 0x239A00 VA: 0x18023A600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A6C0 Offset: 0x239AC0 VA: 0x18023A6C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A630 Offset: 0x239A30 VA: 0x18023A630 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

