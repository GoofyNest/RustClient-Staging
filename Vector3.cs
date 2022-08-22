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
	// RVA: 0x2184A80 Offset: 0x2183080 VA: 0x182184A80
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xABEA0 Offset: 0xAB2A0 VA: 0x1800ABEA0
	// RVA: 0x2184300 Offset: 0x2182900 VA: 0x182184300
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2184350 Offset: 0x2182950 VA: 0x182184350
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x2184760 Offset: 0x2182D60 VA: 0x182184760
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x21839C0 Offset: 0x2181FC0 VA: 0x1821839C0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183940 Offset: 0x2181F40 VA: 0x182183940
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183D70 Offset: 0x2182370 VA: 0x182183D70
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2184B30 Offset: 0x2183130 VA: 0x182184B30
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2184C60 Offset: 0x2183260 VA: 0x182184C60
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

	// RVA: 0x2184810 Offset: 0x2182E10 VA: 0x182184810
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2183610 Offset: 0x2181C10 VA: 0x182183610
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2361F0 Offset: 0x2355F0 VA: 0x1802361F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360D0 Offset: 0x2354D0 VA: 0x1802360D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236190 Offset: 0x235590 VA: 0x180236190 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x21845E0 Offset: 0x2182BE0 VA: 0x1821845E0
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x2184100 Offset: 0x2182700 VA: 0x182184100
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x236250 Offset: 0x235650 VA: 0x180236250
	public void Normalize() { }

	// RVA: 0x2365B0 Offset: 0x2359B0 VA: 0x1802365B0
	public Vector3 get_normalized() { }

	// RVA: 0x2183790 Offset: 0x2181D90 VA: 0x182183790
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x21843D0 Offset: 0x21829D0 VA: 0x1821843D0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2183460 Offset: 0x2181A60 VA: 0x182183460
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2184870 Offset: 0x2182E70 VA: 0x182184870
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x21836B0 Offset: 0x2181CB0 VA: 0x1821836B0
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x2183AC0 Offset: 0x21820C0 VA: 0x182183AC0
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x236510 Offset: 0x235910 VA: 0x180236510
	public float get_magnitude() { }

	// RVA: 0x2185070 Offset: 0x2183670 VA: 0x182185070
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x236650 Offset: 0x235A50 VA: 0x180236650
	public float get_sqrMagnitude() { }

	// RVA: 0x2183C70 Offset: 0x2182270 VA: 0x182183C70
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183B70 Offset: 0x2182170 VA: 0x182183B70
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185A90 Offset: 0x2184090 VA: 0x182185A90
	public static Vector3 get_zero() { }

	// RVA: 0x2185860 Offset: 0x2183E60 VA: 0x182185860
	public static Vector3 get_one() { }

	// RVA: 0x2185620 Offset: 0x2183C20 VA: 0x182185620
	public static Vector3 get_forward() { }

	// RVA: 0x2185520 Offset: 0x2183B20 VA: 0x182185520
	public static Vector3 get_back() { }

	// RVA: 0x2185A10 Offset: 0x2184010 VA: 0x182185A10
	public static Vector3 get_up() { }

	// RVA: 0x21855A0 Offset: 0x2183BA0 VA: 0x1821855A0
	public static Vector3 get_down() { }

	// RVA: 0x21856A0 Offset: 0x2183CA0 VA: 0x1821856A0
	public static Vector3 get_left() { }

	// RVA: 0x2185960 Offset: 0x2183F60 VA: 0x182185960
	public static Vector3 get_right() { }

	// RVA: 0x21858E0 Offset: 0x2183EE0 VA: 0x1821858E0
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x2185B10 Offset: 0x2184110 VA: 0x182185B10
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2185D70 Offset: 0x2184370 VA: 0x182185D70
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x2185DC0 Offset: 0x21843C0 VA: 0x182185DC0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x2185CE0 Offset: 0x21842E0 VA: 0x182185CE0
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2185D20 Offset: 0x2184320 VA: 0x182185D20
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x2185B60 Offset: 0x2184160 VA: 0x182185B60
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x2185BB0 Offset: 0x21841B0 VA: 0x182185BB0
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185C20 Offset: 0x2184220 VA: 0x182185C20
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x236440 Offset: 0x235840 VA: 0x180236440 Slot: 3
	public override string ToString() { }

	// RVA: 0x2185280 Offset: 0x2183880 VA: 0x182185280
	private static void .cctor() { }

	// RVA: 0x2184A10 Offset: 0x2183010 VA: 0x182184A10
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x21846F0 Offset: 0x2182CF0 VA: 0x1821846F0
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

