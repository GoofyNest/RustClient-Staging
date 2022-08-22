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

	// RVA: 0x22722B0 Offset: 0x22708B0 VA: 0x1822722B0
	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	// RVA: 0x2272190 Offset: 0x2270790 VA: 0x182272190
	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	// RVA: 0x2272380 Offset: 0x2270980 VA: 0x182272380
	public static Vector3i op_UnaryPlus(Vector3i v) { }

	// RVA: 0x2272340 Offset: 0x2270940 VA: 0x182272340
	public static Vector3i op_UnaryNegation(Vector3i v) { }

	// RVA: 0x2271F70 Offset: 0x2270570 VA: 0x182271F70
	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	// RVA: 0x22722F0 Offset: 0x22708F0 VA: 0x1822722F0
	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	// RVA: 0x2272270 Offset: 0x2270870 VA: 0x182272270
	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	// RVA: 0x2272030 Offset: 0x2270630 VA: 0x182272030
	public static Vector3i op_Division(Vector3i v, int divisor) { }

	// RVA: 0x2272210 Offset: 0x2270810 VA: 0x182272210
	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	// RVA: 0x2271FD0 Offset: 0x22705D0 VA: 0x182271FD0
	public static Vector3 op_Division(Vector3i v, float divisor) { }

	// RVA: 0x22721D0 Offset: 0x22707D0 VA: 0x1822721D0
	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	// RVA: 0x22720F0 Offset: 0x22706F0 VA: 0x1822720F0
	public static Vector3 op_Implicit(Vector3i other) { }

	// RVA: 0x22720B0 Offset: 0x22706B0 VA: 0x1822720B0
	public static Vector3i op_Explicit(Vector3 other) { }

	// RVA: 0x2272070 Offset: 0x2270670 VA: 0x182272070
	public static bool op_Equality(Vector3i a, Vector3i b) { }

	// RVA: 0x2272150 Offset: 0x2270750 VA: 0x182272150
	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	// RVA: 0x238AC0 Offset: 0x237EC0 VA: 0x180238AC0 Slot: 4
	public bool Equals(Vector3i o) { }

	// RVA: 0x238B00 Offset: 0x237F00 VA: 0x180238B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238A10 Offset: 0x237E10 VA: 0x180238A10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238B50 Offset: 0x237F50 VA: 0x180238B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2271E20 Offset: 0x2270420 VA: 0x182271E20
	private static void .cctor() { }

}

