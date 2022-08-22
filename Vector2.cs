public struct Vector2 : IEquatable<Vector2> // TypeDefIndex: 3470
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x235CF0 Offset: 0x2350F0 VA: 0x180235CF0
	public float get_Item(int index) { }

	// RVA: 0x235DE0 Offset: 0x2351E0 VA: 0x180235DE0
	public void set_Item(int index, float value) { }

	// RVA: 0xF2370 Offset: 0xF1770 VA: 0x1800F2370
	public void .ctor(float x, float y) { }

	// RVA: 0x21826B0 Offset: 0x2180CB0 VA: 0x1821826B0
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x2182870 Offset: 0x2180E70 VA: 0x182182870
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x235B80 Offset: 0x234F80 VA: 0x180235B80
	public void Normalize() { }

	// RVA: 0x235D90 Offset: 0x235190 VA: 0x180235D90
	public Vector2 get_normalized() { }

	// RVA: 0x235B90 Offset: 0x234F90 VA: 0x180235B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x235B40 Offset: 0x234F40 VA: 0x180235B40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235A70 Offset: 0x234E70 VA: 0x180235A70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235B10 Offset: 0x234F10 VA: 0x180235B10 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x2182570 Offset: 0x2180B70 VA: 0x182182570
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x235D80 Offset: 0x235180 VA: 0x180235D80
	public float get_magnitude() { }

	// RVA: 0x235DC0 Offset: 0x2351C0 VA: 0x180235DC0
	public float get_sqrMagnitude() { }

	// RVA: 0x2182350 Offset: 0x2180950 VA: 0x182182350
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x21824E0 Offset: 0x2180AE0 VA: 0x1821824E0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x2182E20 Offset: 0x2181420 VA: 0x182182E20
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x2183060 Offset: 0x2181660 VA: 0x182183060
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x2182870 Offset: 0x2180E70 VA: 0x182182870
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x2182E90 Offset: 0x2181490 VA: 0x182182E90
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x21830A0 Offset: 0x21816A0 VA: 0x1821830A0
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x2183030 Offset: 0x2181630 VA: 0x182183030
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x2183000 Offset: 0x2181600 VA: 0x182183000
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x2182E60 Offset: 0x2181460 VA: 0x182182E60
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x2182ED0 Offset: 0x21814D0 VA: 0x182182ED0
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182F80 Offset: 0x2181580 VA: 0x182182F80
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182F60 Offset: 0x2181560 VA: 0x182182F60
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x2182F20 Offset: 0x2181520 VA: 0x182182F20
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x2182DB0 Offset: 0x21813B0 VA: 0x182182DB0
	public static Vector2 get_zero() { }

	// RVA: 0x2182C40 Offset: 0x2181240 VA: 0x182182C40
	public static Vector2 get_one() { }

	// RVA: 0x2182D40 Offset: 0x2181340 VA: 0x182182D40
	public static Vector2 get_up() { }

	// RVA: 0x2182CB0 Offset: 0x21812B0 VA: 0x182182CB0
	public static Vector2 get_right() { }

	// RVA: 0x2182A10 Offset: 0x2181010 VA: 0x182182A10
	private static void .cctor() { }

}

