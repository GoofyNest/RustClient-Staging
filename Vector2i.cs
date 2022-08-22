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

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x2271A30 Offset: 0x2270030 VA: 0x182271A30
	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	// RVA: 0x2271900 Offset: 0x226FF00 VA: 0x182271900
	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	// RVA: 0x2271A70 Offset: 0x2270070 VA: 0x182271A70
	public static Vector2i op_UnaryPlus(Vector2i v) { }

	// RVA: 0x2271A50 Offset: 0x2270050 VA: 0x182271A50
	public static Vector2i op_UnaryNegation(Vector2i v) { }

	// RVA: 0x8752C0 Offset: 0x8738C0 VA: 0x1808752C0
	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	// RVA: 0x875360 Offset: 0x873960 VA: 0x180875360
	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	// RVA: 0x22719A0 Offset: 0x226FFA0 VA: 0x1822719A0
	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	// RVA: 0x22717C0 Offset: 0x226FDC0 VA: 0x1822717C0
	public static Vector2i op_Division(Vector2i v, int divisor) { }

	// RVA: 0x2271950 Offset: 0x226FF50 VA: 0x182271950
	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	// RVA: 0x2271850 Offset: 0x226FE50 VA: 0x182271850
	public static Vector2 op_Division(Vector2i v, float divisor) { }

	// RVA: 0x2271920 Offset: 0x226FF20 VA: 0x182271920
	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	// RVA: 0x22718C0 Offset: 0x226FEC0 VA: 0x1822718C0
	public static Vector2 op_Implicit(Vector2i other) { }

	// RVA: 0x22718A0 Offset: 0x226FEA0 VA: 0x1822718A0
	public static Vector2i op_Explicit(Vector2 other) { }

	// RVA: 0x875300 Offset: 0x873900 VA: 0x180875300
	public static bool op_Equality(Vector2i a, Vector2i b) { }

	// RVA: 0x875320 Offset: 0x873920 VA: 0x180875320
	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	// RVA: 0xF94A0 Offset: 0xF88A0 VA: 0x1800F94A0 Slot: 4
	public bool Equals(Vector2i o) { }

	// RVA: 0xF94C0 Offset: 0xF88C0 VA: 0x1800F94C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2386F0 Offset: 0x237AF0 VA: 0x1802386F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238780 Offset: 0x237B80 VA: 0x180238780 Slot: 3
	public override string ToString() { }

	// RVA: 0x22716D0 Offset: 0x226FCD0 VA: 0x1822716D0
	private static void .cctor() { }

}

