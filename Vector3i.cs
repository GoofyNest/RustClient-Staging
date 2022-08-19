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

	// RVA: 0x20BEE0 Offset: 0x20B2E0 VA: 0x18020BEE0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x22721B0 Offset: 0x22707B0 VA: 0x1822721B0
	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	// RVA: 0x2272090 Offset: 0x2270690 VA: 0x182272090
	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	// RVA: 0x2272280 Offset: 0x2270880 VA: 0x182272280
	public static Vector3i op_UnaryPlus(Vector3i v) { }

	// RVA: 0x2272240 Offset: 0x2270840 VA: 0x182272240
	public static Vector3i op_UnaryNegation(Vector3i v) { }

	// RVA: 0x2271E70 Offset: 0x2270470 VA: 0x182271E70
	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	// RVA: 0x22721F0 Offset: 0x22707F0 VA: 0x1822721F0
	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	// RVA: 0x2272170 Offset: 0x2270770 VA: 0x182272170
	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	// RVA: 0x2271F30 Offset: 0x2270530 VA: 0x182271F30
	public static Vector3i op_Division(Vector3i v, int divisor) { }

	// RVA: 0x2272110 Offset: 0x2270710 VA: 0x182272110
	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	// RVA: 0x2271ED0 Offset: 0x22704D0 VA: 0x182271ED0
	public static Vector3 op_Division(Vector3i v, float divisor) { }

	// RVA: 0x22720D0 Offset: 0x22706D0 VA: 0x1822720D0
	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	// RVA: 0x2271FF0 Offset: 0x22705F0 VA: 0x182271FF0
	public static Vector3 op_Implicit(Vector3i other) { }

	// RVA: 0x2271FB0 Offset: 0x22705B0 VA: 0x182271FB0
	public static Vector3i op_Explicit(Vector3 other) { }

	// RVA: 0x2271F70 Offset: 0x2270570 VA: 0x182271F70
	public static bool op_Equality(Vector3i a, Vector3i b) { }

	// RVA: 0x2272050 Offset: 0x2270650 VA: 0x182272050
	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	// RVA: 0x238B40 Offset: 0x237F40 VA: 0x180238B40 Slot: 4
	public bool Equals(Vector3i o) { }

	// RVA: 0x238B80 Offset: 0x237F80 VA: 0x180238B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238A90 Offset: 0x237E90 VA: 0x180238A90 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238BD0 Offset: 0x237FD0 VA: 0x180238BD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2271D20 Offset: 0x2270320 VA: 0x182271D20
	private static void .cctor() { }

}

