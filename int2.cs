public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
{
// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x7F670 Offset: 0x7EA70 VA: 0x18007F670
[DebuggerTypeProxyAttribute] // RVA: 0x7F670 Offset: 0x7EA70 VA: 0x18007F670
[Serializable]
public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
	public void .ctor(int x, int y) { }

	// RVA: 0x23A7C0 Offset: 0x239BC0 VA: 0x18023A7C0
	public void .ctor(int v) { }

	// RVA: 0x23A7D0 Offset: 0x239BD0 VA: 0x18023A7D0
	public void .ctor(float2 v) { }

	// RVA: 0x22AE710 Offset: 0x22ACD10 VA: 0x1822AE710
	public static int2 op_Implicit(int v) { }

	// RVA: 0x2271A60 Offset: 0x2270060 VA: 0x182271A60
	public static int2 op_Explicit(float2 v) { }

	// RVA: 0x22AE6F0 Offset: 0x22ACCF0 VA: 0x1822AE6F0
	public static int2 op_Addition(int2 lhs, int rhs) { }

	// RVA: 0x22AE720 Offset: 0x22ACD20 VA: 0x1822AE720
	public static int2 op_Subtraction(int2 lhs, int rhs) { }

	// RVA: 0xF9520 Offset: 0xF8920 VA: 0x1800F9520 Slot: 4
	public bool Equals(int2 rhs) { }

	// RVA: 0x23A5F0 Offset: 0x2399F0 VA: 0x18023A5F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23A680 Offset: 0x239A80 VA: 0x18023A680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A740 Offset: 0x239B40 VA: 0x18023A740 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A6B0 Offset: 0x239AB0 VA: 0x18023A6B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

