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

	// RVA: 0x20BE60 Offset: 0x20B260 VA: 0x18020BE60
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x2271FF0 Offset: 0x22705F0 VA: 0x182271FF0
	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	// RVA: 0x2271ED0 Offset: 0x22704D0 VA: 0x182271ED0
	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	// RVA: 0x22720C0 Offset: 0x22706C0 VA: 0x1822720C0
	public static Vector3i op_UnaryPlus(Vector3i v) { }

	// RVA: 0x2272080 Offset: 0x2270680 VA: 0x182272080
	public static Vector3i op_UnaryNegation(Vector3i v) { }

	// RVA: 0x2271CB0 Offset: 0x22702B0 VA: 0x182271CB0
	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	// RVA: 0x2272030 Offset: 0x2270630 VA: 0x182272030
	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	// RVA: 0x2271FB0 Offset: 0x22705B0 VA: 0x182271FB0
	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	// RVA: 0x2271D70 Offset: 0x2270370 VA: 0x182271D70
	public static Vector3i op_Division(Vector3i v, int divisor) { }

	// RVA: 0x2271F50 Offset: 0x2270550 VA: 0x182271F50
	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	// RVA: 0x2271D10 Offset: 0x2270310 VA: 0x182271D10
	public static Vector3 op_Division(Vector3i v, float divisor) { }

	// RVA: 0x2271F10 Offset: 0x2270510 VA: 0x182271F10
	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	// RVA: 0x2271E30 Offset: 0x2270430 VA: 0x182271E30
	public static Vector3 op_Implicit(Vector3i other) { }

	// RVA: 0x2271DF0 Offset: 0x22703F0 VA: 0x182271DF0
	public static Vector3i op_Explicit(Vector3 other) { }

	// RVA: 0x2271DB0 Offset: 0x22703B0 VA: 0x182271DB0
	public static bool op_Equality(Vector3i a, Vector3i b) { }

	// RVA: 0x2271E90 Offset: 0x2270490 VA: 0x182271E90
	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	// RVA: 0x238AC0 Offset: 0x237EC0 VA: 0x180238AC0 Slot: 4
	public bool Equals(Vector3i o) { }

	// RVA: 0x238B00 Offset: 0x237F00 VA: 0x180238B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238A10 Offset: 0x237E10 VA: 0x180238A10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238B50 Offset: 0x237F50 VA: 0x180238B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2271B60 Offset: 0x2270160 VA: 0x182271B60
	private static void .cctor() { }

}

