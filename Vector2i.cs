public struct Vector2i : IEquatable<Vector2i> // TypeDefIndex: 4821
{	// Fields
	public static readonly Vector2i zero; // 0x0
	public static readonly Vector2i one; // 0x8
	public static readonly Vector2i left; // 0x10
	public static readonly Vector2i right; // 0x18
	public static readonly Vector2i forward; // 0x20
	public static readonly Vector2i back; // 0x28
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
	public void .ctor(int x, int y) { }

	// RVA: 0x2271BF0 Offset: 0x22701F0 VA: 0x182271BF0
	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	// RVA: 0x2271AC0 Offset: 0x22700C0 VA: 0x182271AC0
	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	// RVA: 0x2271C30 Offset: 0x2270230 VA: 0x182271C30
	public static Vector2i op_UnaryPlus(Vector2i v) { }

	// RVA: 0x2271C10 Offset: 0x2270210 VA: 0x182271C10
	public static Vector2i op_UnaryNegation(Vector2i v) { }

	// RVA: 0x8752C0 Offset: 0x8738C0 VA: 0x1808752C0
	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	// RVA: 0x875360 Offset: 0x873960 VA: 0x180875360
	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	// RVA: 0x2271B60 Offset: 0x2270160 VA: 0x182271B60
	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	// RVA: 0x2271980 Offset: 0x226FF80 VA: 0x182271980
	public static Vector2i op_Division(Vector2i v, int divisor) { }

	// RVA: 0x2271B10 Offset: 0x2270110 VA: 0x182271B10
	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	// RVA: 0x2271A10 Offset: 0x2270010 VA: 0x182271A10
	public static Vector2 op_Division(Vector2i v, float divisor) { }

	// RVA: 0x2271AE0 Offset: 0x22700E0 VA: 0x182271AE0
	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	// RVA: 0x2271A80 Offset: 0x2270080 VA: 0x182271A80
	public static Vector2 op_Implicit(Vector2i other) { }

	// RVA: 0x2271A60 Offset: 0x2270060 VA: 0x182271A60
	public static Vector2i op_Explicit(Vector2 other) { }

	// RVA: 0x875300 Offset: 0x873900 VA: 0x180875300
	public static bool op_Equality(Vector2i a, Vector2i b) { }

	// RVA: 0x875320 Offset: 0x873920 VA: 0x180875320
	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	// RVA: 0xF9520 Offset: 0xF8920 VA: 0x1800F9520 Slot: 4
	public bool Equals(Vector2i o) { }

	// RVA: 0xF9540 Offset: 0xF8940 VA: 0x1800F9540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238770 Offset: 0x237B70 VA: 0x180238770 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238800 Offset: 0x237C00 VA: 0x180238800 Slot: 3
	public override string ToString() { }

	// RVA: 0x2271890 Offset: 0x226FE90 VA: 0x182271890
	private static void .cctor() { }

}

