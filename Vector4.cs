public struct Vector4 : IEquatable<Vector4> // TypeDefIndex: 3473
{	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x236870 Offset: 0x235C70 VA: 0x180236870
	public float get_Item(int index) { }

	// RVA: 0x236A50 Offset: 0x235E50 VA: 0x180236A50
	public void set_Item(int index, float value) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x236850 Offset: 0x235C50 VA: 0x180236850
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x21857A0 Offset: 0x2183DA0 VA: 0x1821857A0
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x217950 Offset: 0x216D50 VA: 0x180217950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x236730 Offset: 0x235B30 VA: 0x180236730 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2367F0 Offset: 0x235BF0 VA: 0x1802367F0 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x2185990 Offset: 0x2183F90 VA: 0x182185990
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x236920 Offset: 0x235D20 VA: 0x180236920
	public Vector4 get_normalized() { }

	// RVA: 0x18FDFD0 Offset: 0x18FC5D0 VA: 0x1818FDFD0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x21858C0 Offset: 0x2183EC0 VA: 0x1821858C0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x2369B0 Offset: 0x235DB0 VA: 0x1802369B0
	public float get_sqrMagnitude() { }

	// RVA: 0x21860F0 Offset: 0x21846F0 VA: 0x1821860F0
	public static Vector4 get_zero() { }

	// RVA: 0x2185FE0 Offset: 0x21845E0 VA: 0x182185FE0
	public static Vector4 get_one() { }

	// RVA: 0x1824D20 Offset: 0x1823320 VA: 0x181824D20
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x18250D0 Offset: 0x18236D0 VA: 0x1818250D0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1825040 Offset: 0x1823640 VA: 0x181825040
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x1824D70 Offset: 0x1823370 VA: 0x181824D70
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x2186160 Offset: 0x2184760 VA: 0x182186160
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x21862A0 Offset: 0x21848A0 VA: 0x1821862A0
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2186200 Offset: 0x2184800 VA: 0x182186200
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x2186270 Offset: 0x2184870 VA: 0x182186270
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x21861C0 Offset: 0x21847C0 VA: 0x1821861C0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2186250 Offset: 0x2184850 VA: 0x182186250
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x236840 Offset: 0x235C40 VA: 0x180236840 Slot: 3
	public override string ToString() { }

	// RVA: 0x2185DF0 Offset: 0x21843F0 VA: 0x182185DF0
	private static void .cctor() { }

}

