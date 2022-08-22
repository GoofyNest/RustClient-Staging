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
	// RVA: 0x2184260 Offset: 0x2182860 VA: 0x182184260
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xABEA0 Offset: 0xAB2A0 VA: 0x1800ABEA0
	// RVA: 0x2183AE0 Offset: 0x21820E0 VA: 0x182183AE0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2183B30 Offset: 0x2182130 VA: 0x182183B30
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x2183F40 Offset: 0x2182540 VA: 0x182183F40
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x21831A0 Offset: 0x21817A0 VA: 0x1821831A0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183120 Offset: 0x2181720 VA: 0x182183120
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2183550 Offset: 0x2181B50 VA: 0x182183550
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2184310 Offset: 0x2182910 VA: 0x182184310
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2184440 Offset: 0x2182A40 VA: 0x182184440
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

	// RVA: 0x2183FF0 Offset: 0x21825F0 VA: 0x182183FF0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2182DF0 Offset: 0x21813F0 VA: 0x182182DF0
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2361F0 Offset: 0x2355F0 VA: 0x1802361F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360D0 Offset: 0x2354D0 VA: 0x1802360D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236190 Offset: 0x235590 VA: 0x180236190 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x2183DC0 Offset: 0x21823C0 VA: 0x182183DC0
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x21838E0 Offset: 0x2181EE0 VA: 0x1821838E0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x236250 Offset: 0x235650 VA: 0x180236250
	public void Normalize() { }

	// RVA: 0x2365B0 Offset: 0x2359B0 VA: 0x1802365B0
	public Vector3 get_normalized() { }

	// RVA: 0x2182F70 Offset: 0x2181570 VA: 0x182182F70
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183BB0 Offset: 0x21821B0 VA: 0x182183BB0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2182C40 Offset: 0x2181240 VA: 0x182182C40
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2184050 Offset: 0x2182650 VA: 0x182184050
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x2182E90 Offset: 0x2181490 VA: 0x182182E90
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x21832A0 Offset: 0x21818A0 VA: 0x1821832A0
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x236510 Offset: 0x235910 VA: 0x180236510
	public float get_magnitude() { }

	// RVA: 0x2184850 Offset: 0x2182E50 VA: 0x182184850
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x236650 Offset: 0x235A50 VA: 0x180236650
	public float get_sqrMagnitude() { }

	// RVA: 0x2183450 Offset: 0x2181A50 VA: 0x182183450
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2183350 Offset: 0x2181950 VA: 0x182183350
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185270 Offset: 0x2183870 VA: 0x182185270
	public static Vector3 get_zero() { }

	// RVA: 0x2185040 Offset: 0x2183640 VA: 0x182185040
	public static Vector3 get_one() { }

	// RVA: 0x2184E00 Offset: 0x2183400 VA: 0x182184E00
	public static Vector3 get_forward() { }

	// RVA: 0x2184D00 Offset: 0x2183300 VA: 0x182184D00
	public static Vector3 get_back() { }

	// RVA: 0x21851F0 Offset: 0x21837F0 VA: 0x1821851F0
	public static Vector3 get_up() { }

	// RVA: 0x2184D80 Offset: 0x2183380 VA: 0x182184D80
	public static Vector3 get_down() { }

	// RVA: 0x2184E80 Offset: 0x2183480 VA: 0x182184E80
	public static Vector3 get_left() { }

	// RVA: 0x2185140 Offset: 0x2183740 VA: 0x182185140
	public static Vector3 get_right() { }

	// RVA: 0x21850C0 Offset: 0x21836C0 VA: 0x1821850C0
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x21852F0 Offset: 0x21838F0 VA: 0x1821852F0
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2185550 Offset: 0x2183B50 VA: 0x182185550
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x21855A0 Offset: 0x2183BA0 VA: 0x1821855A0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x21854C0 Offset: 0x2183AC0 VA: 0x1821854C0
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2185500 Offset: 0x2183B00 VA: 0x182185500
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x2185340 Offset: 0x2183940 VA: 0x182185340
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x2185390 Offset: 0x2183990 VA: 0x182185390
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2185400 Offset: 0x2183A00 VA: 0x182185400
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x236440 Offset: 0x235840 VA: 0x180236440 Slot: 3
	public override string ToString() { }

	// RVA: 0x2184A60 Offset: 0x2183060 VA: 0x182184A60
	private static void .cctor() { }

	// RVA: 0x21841F0 Offset: 0x21827F0 VA: 0x1821841F0
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2183ED0 Offset: 0x21824D0 VA: 0x182183ED0
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

