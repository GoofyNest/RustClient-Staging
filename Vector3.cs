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

	[FreeFunctionAttribute] // RVA: 0xABD90 Offset: 0xAB190 VA: 0x1800ABD90
	// RVA: 0x2184160 Offset: 0x2182760 VA: 0x182184160
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xABE40 Offset: 0xAB240 VA: 0x1800ABE40
	// RVA: 0x21839E0 Offset: 0x2181FE0 VA: 0x1821839E0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2183A30 Offset: 0x2182030 VA: 0x182183A30
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x2183E40 Offset: 0x2182440 VA: 0x182183E40
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x21830A0 Offset: 0x21816A0 VA: 0x1821830A0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183020 Offset: 0x2181620 VA: 0x182183020
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183450 Offset: 0x2181A50 VA: 0x182183450
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2184210 Offset: 0x2182810 VA: 0x182184210
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2184340 Offset: 0x2182940 VA: 0x182184340
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x2364F0 Offset: 0x2358F0 VA: 0x1802364F0
	public float get_Item(int index) { }

	// RVA: 0x236700 Offset: 0x235B00 VA: 0x180236700
	public void set_Item(int index, float value) { }

	// RVA: 0xFB580 Offset: 0xFA980 VA: 0x1800FB580
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2364D0 Offset: 0x2358D0 VA: 0x1802364D0
	public void .ctor(float x, float y) { }

	// RVA: 0xFB580 Offset: 0xFA980 VA: 0x1800FB580
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x2183EF0 Offset: 0x21824F0 VA: 0x182183EF0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2182CF0 Offset: 0x21812F0 VA: 0x182182CF0
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x236270 Offset: 0x235670 VA: 0x180236270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x236150 Offset: 0x235550 VA: 0x180236150 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236210 Offset: 0x235610 VA: 0x180236210 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x2183CC0 Offset: 0x21822C0 VA: 0x182183CC0
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x21837E0 Offset: 0x2181DE0 VA: 0x1821837E0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x2362D0 Offset: 0x2356D0 VA: 0x1802362D0
	public void Normalize() { }

	// RVA: 0x236630 Offset: 0x235A30 VA: 0x180236630
	public Vector3 get_normalized() { }

	// RVA: 0x2182E70 Offset: 0x2181470 VA: 0x182182E70
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183AB0 Offset: 0x21820B0 VA: 0x182183AB0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2182B40 Offset: 0x2181140 VA: 0x182182B40
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2183F50 Offset: 0x2182550 VA: 0x182183F50
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x2182D90 Offset: 0x2181390 VA: 0x182182D90
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x21831A0 Offset: 0x21817A0 VA: 0x1821831A0
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x236590 Offset: 0x235990 VA: 0x180236590
	public float get_magnitude() { }

	// RVA: 0x2184750 Offset: 0x2182D50 VA: 0x182184750
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x2366D0 Offset: 0x235AD0 VA: 0x1802366D0
	public float get_sqrMagnitude() { }

	// RVA: 0x2183350 Offset: 0x2181950 VA: 0x182183350
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183250 Offset: 0x2181850 VA: 0x182183250
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185170 Offset: 0x2183770 VA: 0x182185170
	public static Vector3 get_zero() { }

	// RVA: 0x2184F40 Offset: 0x2183540 VA: 0x182184F40
	public static Vector3 get_one() { }

	// RVA: 0x2184D00 Offset: 0x2183300 VA: 0x182184D00
	public static Vector3 get_forward() { }

	// RVA: 0x2184C00 Offset: 0x2183200 VA: 0x182184C00
	public static Vector3 get_back() { }

	// RVA: 0x21850F0 Offset: 0x21836F0 VA: 0x1821850F0
	public static Vector3 get_up() { }

	// RVA: 0x2184C80 Offset: 0x2183280 VA: 0x182184C80
	public static Vector3 get_down() { }

	// RVA: 0x2184D80 Offset: 0x2183380 VA: 0x182184D80
	public static Vector3 get_left() { }

	// RVA: 0x2185040 Offset: 0x2183640 VA: 0x182185040
	public static Vector3 get_right() { }

	// RVA: 0x2184FC0 Offset: 0x21835C0 VA: 0x182184FC0
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x21851F0 Offset: 0x21837F0 VA: 0x1821851F0
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2185450 Offset: 0x2183A50 VA: 0x182185450
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x21854A0 Offset: 0x2183AA0 VA: 0x1821854A0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x21853C0 Offset: 0x21839C0 VA: 0x1821853C0
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2185400 Offset: 0x2183A00 VA: 0x182185400
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x2185240 Offset: 0x2183840 VA: 0x182185240
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x2185290 Offset: 0x2183890 VA: 0x182185290
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185300 Offset: 0x2183900 VA: 0x182185300
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2364C0 Offset: 0x2358C0 VA: 0x1802364C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2184960 Offset: 0x2182F60 VA: 0x182184960
	private static void .cctor() { }

	// RVA: 0x21840F0 Offset: 0x21826F0 VA: 0x1821840F0
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2183DD0 Offset: 0x21823D0 VA: 0x182183DD0
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

