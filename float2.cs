public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 7101
{	// Fields
	public float x; // 0x0
	public float y; // 0x4

	// Methods

	// RVA: 0xF23F0 Offset: 0xF17F0 VA: 0x1800F23F0
	public void .ctor(float x, float y) { }

	// RVA: 0x239CF0 Offset: 0x2390F0 VA: 0x180239CF0
	public void .ctor(int2 v) { }

	// RVA: 0x239D10 Offset: 0x239110 VA: 0x180239D10
	public void .ctor(half2 v) { }

	// RVA: 0x22ADC60 Offset: 0x22AC260 VA: 0x1822ADC60
	public static float2 op_Implicit(int2 v) { }

	// RVA: 0x970C40 Offset: 0x96F240 VA: 0x180970C40
	public static float2 op_Implicit(half2 v) { }

	// RVA: 0x2182740 Offset: 0x2180D40 VA: 0x182182740
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x235B90 Offset: 0x234F90 VA: 0x180235B90 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x239AF0 Offset: 0x238EF0 VA: 0x180239AF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239B80 Offset: 0x238F80 VA: 0x180239B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239C60 Offset: 0x239060 VA: 0x180239C60 Slot: 3
	public override string ToString() { }

	// RVA: 0x239BD0 Offset: 0x238FD0 VA: 0x180239BD0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

