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

	// RVA: 0x2181E90 Offset: 0x2180490 VA: 0x182181E90
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x2182050 Offset: 0x2180650 VA: 0x182182050
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

	// RVA: 0x2181D50 Offset: 0x2180350 VA: 0x182181D50
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x235D80 Offset: 0x235180 VA: 0x180235D80
	public float get_magnitude() { }

	// RVA: 0x235DC0 Offset: 0x2351C0 VA: 0x180235DC0
	public float get_sqrMagnitude() { }

	// RVA: 0x2181B30 Offset: 0x2180130 VA: 0x182181B30
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x2181CC0 Offset: 0x21802C0 VA: 0x182181CC0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x2182600 Offset: 0x2180C00 VA: 0x182182600
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x2182840 Offset: 0x2180E40 VA: 0x182182840
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x2182050 Offset: 0x2180650 VA: 0x182182050
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x2182670 Offset: 0x2180C70 VA: 0x182182670
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x2182880 Offset: 0x2180E80 VA: 0x182182880
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x2182810 Offset: 0x2180E10 VA: 0x182182810
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x21827E0 Offset: 0x2180DE0 VA: 0x1821827E0
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x2182640 Offset: 0x2180C40 VA: 0x182182640
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x21826B0 Offset: 0x2180CB0 VA: 0x1821826B0
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182760 Offset: 0x2180D60 VA: 0x182182760
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182740 Offset: 0x2180D40 VA: 0x182182740
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x2182700 Offset: 0x2180D00 VA: 0x182182700
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x2182590 Offset: 0x2180B90 VA: 0x182182590
	public static Vector2 get_zero() { }

	// RVA: 0x2182420 Offset: 0x2180A20 VA: 0x182182420
	public static Vector2 get_one() { }

	// RVA: 0x2182520 Offset: 0x2180B20 VA: 0x182182520
	public static Vector2 get_up() { }

	// RVA: 0x2182490 Offset: 0x2180A90 VA: 0x182182490
	public static Vector2 get_right() { }

	// RVA: 0x21821F0 Offset: 0x21807F0 VA: 0x1821821F0
	private static void .cctor() { }

}

