public struct Vector3i : IEquatable<Vector3i> // TypeDefIndex: 4823
{	// Fields
	public static readonly Vector3i zero; // 0x0
	public static readonly Vector3i one; // 0xC
	public static readonly Vector3i forward; // 0x18
	public static readonly Vector3i back; // 0x24
	public static readonly Vector3i up; // 0x30
	public static readonly Vector3i down; // 0x3C
	public static readonly Vector3i right; // 0x48
	public static readonly Vector3i left; // 0x54
	public int x; // 0x0
	public int y; // 0x4
	public int z; // 0x8

	// Methods

	// RVA: 0x20BA90 Offset: 0x20AE90 VA: 0x18020BA90
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x2272AD0 Offset: 0x22710D0 VA: 0x182272AD0
	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	// RVA: 0x22729B0 Offset: 0x2270FB0 VA: 0x1822729B0
	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	// RVA: 0x2272BA0 Offset: 0x22711A0 VA: 0x182272BA0
	public static Vector3i op_UnaryPlus(Vector3i v) { }

	// RVA: 0x2272B60 Offset: 0x2271160 VA: 0x182272B60
	public static Vector3i op_UnaryNegation(Vector3i v) { }

	// RVA: 0x2272790 Offset: 0x2270D90 VA: 0x182272790
	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	// RVA: 0x2272B10 Offset: 0x2271110 VA: 0x182272B10
	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	// RVA: 0x2272A90 Offset: 0x2271090 VA: 0x182272A90
	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	// RVA: 0x2272850 Offset: 0x2270E50 VA: 0x182272850
	public static Vector3i op_Division(Vector3i v, int divisor) { }

	// RVA: 0x2272A30 Offset: 0x2271030 VA: 0x182272A30
	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	// RVA: 0x22727F0 Offset: 0x2270DF0 VA: 0x1822727F0
	public static Vector3 op_Division(Vector3i v, float divisor) { }

	// RVA: 0x22729F0 Offset: 0x2270FF0 VA: 0x1822729F0
	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	// RVA: 0x2272910 Offset: 0x2270F10 VA: 0x182272910
	public static Vector3 op_Implicit(Vector3i other) { }

	// RVA: 0x22728D0 Offset: 0x2270ED0 VA: 0x1822728D0
	public static Vector3i op_Explicit(Vector3 other) { }

	// RVA: 0x2272890 Offset: 0x2270E90 VA: 0x182272890
	public static bool op_Equality(Vector3i a, Vector3i b) { }

	// RVA: 0x2272970 Offset: 0x2270F70 VA: 0x182272970
	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	// RVA: 0x238AC0 Offset: 0x237EC0 VA: 0x180238AC0 Slot: 4
	public bool Equals(Vector3i o) { }

	// RVA: 0x238B00 Offset: 0x237F00 VA: 0x180238B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238A10 Offset: 0x237E10 VA: 0x180238A10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238B50 Offset: 0x237F50 VA: 0x180238B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2272640 Offset: 0x2270C40 VA: 0x182272640
	private static void .cctor() { }

}

