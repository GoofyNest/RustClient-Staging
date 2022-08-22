public struct Vector3 : IEquatable<Vector3> // TypeDefIndex: 3467
{	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }
	public static Vector3 positiveInfinity { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xABE00 Offset: 0xAB200 VA: 0x1800ABE00
	// RVA: 0x2183FA0 Offset: 0x21825A0 VA: 0x182183FA0
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xABEA0 Offset: 0xAB2A0 VA: 0x1800ABEA0
	// RVA: 0x2183820 Offset: 0x2181E20 VA: 0x182183820
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2183870 Offset: 0x2181E70 VA: 0x182183870
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x2183C80 Offset: 0x2182280 VA: 0x182183C80
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x2182EE0 Offset: 0x21814E0 VA: 0x182182EE0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2182E60 Offset: 0x2181460 VA: 0x182182E60
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183290 Offset: 0x2181890 VA: 0x182183290
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2184050 Offset: 0x2182650 VA: 0x182184050
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2184180 Offset: 0x2182780 VA: 0x182184180
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x236470 Offset: 0x235870 VA: 0x180236470
	public float get_Item(int index) { }

	// RVA: 0x236680 Offset: 0x235A80 VA: 0x180236680
	public void set_Item(int index, float value) { }

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x236450 Offset: 0x235850 VA: 0x180236450
	public void .ctor(float x, float y) { }

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x2183D30 Offset: 0x2182330 VA: 0x182183D30
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2182B30 Offset: 0x2181130 VA: 0x182182B30
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2361F0 Offset: 0x2355F0 VA: 0x1802361F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360D0 Offset: 0x2354D0 VA: 0x1802360D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236190 Offset: 0x235590 VA: 0x180236190 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x2183B00 Offset: 0x2182100 VA: 0x182183B00
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x2183620 Offset: 0x2181C20 VA: 0x182183620
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x236250 Offset: 0x235650 VA: 0x180236250
	public void Normalize() { }

	// RVA: 0x2365B0 Offset: 0x2359B0 VA: 0x1802365B0
	public Vector3 get_normalized() { }

	// RVA: 0x2182CB0 Offset: 0x21812B0 VA: 0x182182CB0
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x21838F0 Offset: 0x2181EF0 VA: 0x1821838F0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2182980 Offset: 0x2180F80 VA: 0x182182980
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2183D90 Offset: 0x2182390 VA: 0x182183D90
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x2182BD0 Offset: 0x21811D0 VA: 0x182182BD0
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x2182FE0 Offset: 0x21815E0 VA: 0x182182FE0
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x236510 Offset: 0x235910 VA: 0x180236510
	public float get_magnitude() { }

	// RVA: 0x2184590 Offset: 0x2182B90 VA: 0x182184590
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x236650 Offset: 0x235A50 VA: 0x180236650
	public float get_sqrMagnitude() { }

	// RVA: 0x2183190 Offset: 0x2181790 VA: 0x182183190
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183090 Offset: 0x2181690 VA: 0x182183090
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2184FB0 Offset: 0x21835B0 VA: 0x182184FB0
	public static Vector3 get_zero() { }

	// RVA: 0x2184D80 Offset: 0x2183380 VA: 0x182184D80
	public static Vector3 get_one() { }

	// RVA: 0x2184B40 Offset: 0x2183140 VA: 0x182184B40
	public static Vector3 get_forward() { }

	// RVA: 0x2184A40 Offset: 0x2183040 VA: 0x182184A40
	public static Vector3 get_back() { }

	// RVA: 0x2184F30 Offset: 0x2183530 VA: 0x182184F30
	public static Vector3 get_up() { }

	// RVA: 0x2184AC0 Offset: 0x21830C0 VA: 0x182184AC0
	public static Vector3 get_down() { }

	// RVA: 0x2184BC0 Offset: 0x21831C0 VA: 0x182184BC0
	public static Vector3 get_left() { }

	// RVA: 0x2184E80 Offset: 0x2183480 VA: 0x182184E80
	public static Vector3 get_right() { }

	// RVA: 0x2184E00 Offset: 0x2183400 VA: 0x182184E00
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x2185030 Offset: 0x2183630 VA: 0x182185030
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2185290 Offset: 0x2183890 VA: 0x182185290
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x21852E0 Offset: 0x21838E0 VA: 0x1821852E0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x2185200 Offset: 0x2183800 VA: 0x182185200
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2185240 Offset: 0x2183840 VA: 0x182185240
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x2185080 Offset: 0x2183680 VA: 0x182185080
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x21850D0 Offset: 0x21836D0 VA: 0x1821850D0
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185140 Offset: 0x2183740 VA: 0x182185140
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x236440 Offset: 0x235840 VA: 0x180236440 Slot: 3
	public override string ToString() { }

	// RVA: 0x21847A0 Offset: 0x2182DA0 VA: 0x1821847A0
	private static void .cctor() { }

	// RVA: 0x2183F30 Offset: 0x2182530 VA: 0x182183F30
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2183C10 Offset: 0x2182210 VA: 0x182183C10
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

