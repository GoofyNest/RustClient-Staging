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

	// RVA: 0x2271CF0 Offset: 0x22702F0 VA: 0x182271CF0
	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	// RVA: 0x2271BC0 Offset: 0x22701C0 VA: 0x182271BC0
	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	// RVA: 0x2271D30 Offset: 0x2270330 VA: 0x182271D30
	public static Vector2i op_UnaryPlus(Vector2i v) { }

	// RVA: 0x2271D10 Offset: 0x2270310 VA: 0x182271D10
	public static Vector2i op_UnaryNegation(Vector2i v) { }

	// RVA: 0x8753D0 Offset: 0x8739D0 VA: 0x1808753D0
	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	// RVA: 0x875470 Offset: 0x873A70 VA: 0x180875470
	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	// RVA: 0x2271C60 Offset: 0x2270260 VA: 0x182271C60
	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	// RVA: 0x2271A80 Offset: 0x2270080 VA: 0x182271A80
	public static Vector2i op_Division(Vector2i v, int divisor) { }

	// RVA: 0x2271C10 Offset: 0x2270210 VA: 0x182271C10
	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	// RVA: 0x2271B10 Offset: 0x2270110 VA: 0x182271B10
	public static Vector2 op_Division(Vector2i v, float divisor) { }

	// RVA: 0x2271BE0 Offset: 0x22701E0 VA: 0x182271BE0
	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	// RVA: 0x2271B80 Offset: 0x2270180 VA: 0x182271B80
	public static Vector2 op_Implicit(Vector2i other) { }

	// RVA: 0x2271B60 Offset: 0x2270160 VA: 0x182271B60
	public static Vector2i op_Explicit(Vector2 other) { }

	// RVA: 0x875410 Offset: 0x873A10 VA: 0x180875410
	public static bool op_Equality(Vector2i a, Vector2i b) { }

	// RVA: 0x875430 Offset: 0x873A30 VA: 0x180875430
	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	// RVA: 0xF94A0 Offset: 0xF88A0 VA: 0x1800F94A0 Slot: 4
	public bool Equals(Vector2i o) { }

	// RVA: 0xF94C0 Offset: 0xF88C0 VA: 0x1800F94C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2386F0 Offset: 0x237AF0 VA: 0x1802386F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238780 Offset: 0x237B80 VA: 0x180238780 Slot: 3
	public override string ToString() { }

	// RVA: 0x2271990 Offset: 0x226FF90 VA: 0x182271990
	private static void .cctor() { }

}

