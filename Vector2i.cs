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

	// RVA: 0x2272510 Offset: 0x2270B10 VA: 0x182272510
	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	// RVA: 0x22723E0 Offset: 0x22709E0 VA: 0x1822723E0
	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	// RVA: 0x2272550 Offset: 0x2270B50 VA: 0x182272550
	public static Vector2i op_UnaryPlus(Vector2i v) { }

	// RVA: 0x2272530 Offset: 0x2270B30 VA: 0x182272530
	public static Vector2i op_UnaryNegation(Vector2i v) { }

	// RVA: 0x890AF0 Offset: 0x88F0F0 VA: 0x180890AF0
	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	// RVA: 0x890B90 Offset: 0x88F190 VA: 0x180890B90
	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	// RVA: 0x2272480 Offset: 0x2270A80 VA: 0x182272480
	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	// RVA: 0x22722A0 Offset: 0x22708A0 VA: 0x1822722A0
	public static Vector2i op_Division(Vector2i v, int divisor) { }

	// RVA: 0x2272430 Offset: 0x2270A30 VA: 0x182272430
	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	// RVA: 0x2272330 Offset: 0x2270930 VA: 0x182272330
	public static Vector2 op_Division(Vector2i v, float divisor) { }

	// RVA: 0x2272400 Offset: 0x2270A00 VA: 0x182272400
	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	// RVA: 0x22723A0 Offset: 0x22709A0 VA: 0x1822723A0
	public static Vector2 op_Implicit(Vector2i other) { }

	// RVA: 0x2272380 Offset: 0x2270980 VA: 0x182272380
	public static Vector2i op_Explicit(Vector2 other) { }

	// RVA: 0x890B30 Offset: 0x88F130 VA: 0x180890B30
	public static bool op_Equality(Vector2i a, Vector2i b) { }

	// RVA: 0x890B50 Offset: 0x88F150 VA: 0x180890B50
	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	// RVA: 0xF9CF0 Offset: 0xF90F0 VA: 0x1800F9CF0 Slot: 4
	public bool Equals(Vector2i o) { }

	// RVA: 0xF9D10 Offset: 0xF9110 VA: 0x1800F9D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2386F0 Offset: 0x237AF0 VA: 0x1802386F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238780 Offset: 0x237B80 VA: 0x180238780 Slot: 3
	public override string ToString() { }

	// RVA: 0x22721B0 Offset: 0x22707B0 VA: 0x1822721B0
	private static void .cctor() { }

}

