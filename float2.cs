public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 7101
{	// Fields
	public float x; // 0x0
	public float y; // 0x4

	// Methods

	// RVA: 0xF2370 Offset: 0xF1770 VA: 0x1800F2370
	public void .ctor(float x, float y) { }

	// RVA: 0x239C70 Offset: 0x239070 VA: 0x180239C70
	public void .ctor(int2 v) { }

	// RVA: 0x239C90 Offset: 0x239090 VA: 0x180239C90
	public void .ctor(half2 v) { }

	// RVA: 0x22ADD60 Offset: 0x22AC360 VA: 0x1822ADD60
	public static float2 op_Implicit(int2 v) { }

	// RVA: 0x970D50 Offset: 0x96F350 VA: 0x180970D50
	public static float2 op_Implicit(half2 v) { }

	// RVA: 0x2182840 Offset: 0x2180E40 VA: 0x182182840
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x235B10 Offset: 0x234F10 VA: 0x180235B10 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x239A70 Offset: 0x238E70 VA: 0x180239A70 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239B00 Offset: 0x238F00 VA: 0x180239B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239BE0 Offset: 0x238FE0 VA: 0x180239BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x239B50 Offset: 0x238F50 VA: 0x180239B50 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

