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

	// RVA: 0x22AF030 Offset: 0x22AD630 VA: 0x1822AF030
	public static int2 op_Implicit(int v) { }

	// RVA: 0x2272380 Offset: 0x2270980 VA: 0x182272380
	public static int2 op_Explicit(float2 v) { }

	// RVA: 0x22AF010 Offset: 0x22AD610 VA: 0x1822AF010
	public static int2 op_Addition(int2 lhs, int rhs) { }

	// RVA: 0x22AF040 Offset: 0x22AD640 VA: 0x1822AF040
	public static int2 op_Subtraction(int2 lhs, int rhs) { }

	// RVA: 0xF9CF0 Offset: 0xF90F0 VA: 0x1800F9CF0 Slot: 4
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

