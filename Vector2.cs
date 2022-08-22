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

	// RVA: 0x2181BD0 Offset: 0x21801D0 VA: 0x182181BD0
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x2181D90 Offset: 0x2180390 VA: 0x182181D90
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

	// RVA: 0x2181A90 Offset: 0x2180090 VA: 0x182181A90
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x235D80 Offset: 0x235180 VA: 0x180235D80
	public float get_magnitude() { }

	// RVA: 0x235DC0 Offset: 0x2351C0 VA: 0x180235DC0
	public float get_sqrMagnitude() { }

	// RVA: 0x2181870 Offset: 0x217FE70 VA: 0x182181870
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x2181A00 Offset: 0x2180000 VA: 0x182181A00
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x2182340 Offset: 0x2180940 VA: 0x182182340
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x2182580 Offset: 0x2180B80 VA: 0x182182580
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x2181D90 Offset: 0x2180390 VA: 0x182181D90
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x21823B0 Offset: 0x21809B0 VA: 0x1821823B0
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x21825C0 Offset: 0x2180BC0 VA: 0x1821825C0
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x2182550 Offset: 0x2180B50 VA: 0x182182550
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x2182520 Offset: 0x2180B20 VA: 0x182182520
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x2182380 Offset: 0x2180980 VA: 0x182182380
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x21823F0 Offset: 0x21809F0 VA: 0x1821823F0
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x21824A0 Offset: 0x2180AA0 VA: 0x1821824A0
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2182480 Offset: 0x2180A80 VA: 0x182182480
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x2182440 Offset: 0x2180A40 VA: 0x182182440
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x21822D0 Offset: 0x21808D0 VA: 0x1821822D0
	public static Vector2 get_zero() { }

	// RVA: 0x2182160 Offset: 0x2180760 VA: 0x182182160
	public static Vector2 get_one() { }

	// RVA: 0x2182260 Offset: 0x2180860 VA: 0x182182260
	public static Vector2 get_up() { }

	// RVA: 0x21821D0 Offset: 0x21807D0 VA: 0x1821821D0
	public static Vector2 get_right() { }

	// RVA: 0x2181F30 Offset: 0x2180530 VA: 0x182181F30
	private static void .cctor() { }

}

