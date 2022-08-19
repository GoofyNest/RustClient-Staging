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

	// RVA: 0x235D70 Offset: 0x235170 VA: 0x180235D70
	public float get_Item(int index) { }

	// RVA: 0x235E60 Offset: 0x235260 VA: 0x180235E60
	public void set_Item(int index, float value) { }

	// RVA: 0xF23F0 Offset: 0xF17F0 VA: 0x1800F23F0
	public void .ctor(float x, float y) { }

	// RVA: 0x2181D90 Offset: 0x2180390 VA: 0x182181D90
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x2181F50 Offset: 0x2180550 VA: 0x182181F50
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x235C00 Offset: 0x235000 VA: 0x180235C00
	public void Normalize() { }

	// RVA: 0x235E10 Offset: 0x235210 VA: 0x180235E10
	public Vector2 get_normalized() { }

	// RVA: 0x235C10 Offset: 0x235010 VA: 0x180235C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x235BC0 Offset: 0x234FC0 VA: 0x180235BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235AF0 Offset: 0x234EF0 VA: 0x180235AF0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235B90 Offset: 0x234F90 VA: 0x180235B90 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x2181C50 Offset: 0x2180250 VA: 0x182181C50
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x235E00 Offset: 0x235200 VA: 0x180235E00
	public float get_magnitude() { }

	// RVA: 0x235E40 Offset: 0x235240 VA: 0x180235E40
	public float get_sqrMagnitude() { }

	// RVA: 0x2181A30 Offset: 0x2180030 VA: 0x182181A30
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x2181BC0 Offset: 0x21801C0 VA: 0x182181BC0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x2182500 Offset: 0x2180B00 VA: 0x182182500
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x2182740 Offset: 0x2180D40 VA: 0x182182740
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x2181F50 Offset: 0x2180550 VA: 0x182181F50
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x2182570 Offset: 0x2180B70 VA: 0x182182570
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x2182780 Offset: 0x2180D80 VA: 0x182182780
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x2182710 Offset: 0x2180D10 VA: 0x182182710
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x21826E0 Offset: 0x2180CE0 VA: 0x1821826E0
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x2182540 Offset: 0x2180B40 VA: 0x182182540
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x21825B0 Offset: 0x2180BB0 VA: 0x1821825B0
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182660 Offset: 0x2180C60 VA: 0x182182660
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182640 Offset: 0x2180C40 VA: 0x182182640
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x2182600 Offset: 0x2180C00 VA: 0x182182600
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x2182490 Offset: 0x2180A90 VA: 0x182182490
	public static Vector2 get_zero() { }

	// RVA: 0x2182320 Offset: 0x2180920 VA: 0x182182320
	public static Vector2 get_one() { }

	// RVA: 0x2182420 Offset: 0x2180A20 VA: 0x182182420
	public static Vector2 get_up() { }

	// RVA: 0x2182390 Offset: 0x2180990 VA: 0x182182390
	public static Vector2 get_right() { }

	// RVA: 0x21820F0 Offset: 0x21806F0 VA: 0x1821820F0
	private static void .cctor() { }

}

