public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 3468
{	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }


	[FreeFunctionAttribute] // RVA: 0xAC560 Offset: 0xAB960 VA: 0x1800AC560
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xAC760 Offset: 0xABB60 VA: 0x1800AC760
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC8A0 Offset: 0xABCA0 VA: 0x1800AC8A0
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC9D0 Offset: 0xABDD0 VA: 0x1800AC9D0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACB50 Offset: 0xABF50 VA: 0x1800ACB50
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACC50 Offset: 0xAC050 VA: 0x1800ACC50
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xACD90 Offset: 0xAC190 VA: 0x1800ACD90
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xACE60 Offset: 0xAC260 VA: 0x1800ACE60
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xAD010 Offset: 0xAC410 VA: 0x1800AD010
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static Quaternion LookRotation(Vector3 forward) { }

	public void .ctor(float x, float y, float z, float w) { }

	public static Quaternion get_identity() { }

	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	private static bool IsEqualUsingDot(float dot) { }

	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	public static float Dot(Quaternion a, Quaternion b) { }

	public void SetLookRotation(Vector3 view, Vector3 up) { }

	public static float Angle(Quaternion a, Quaternion b) { }

	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	public Vector3 get_eulerAngles() { }

	public static Quaternion Euler(float x, float y, float z) { }

	public static Quaternion Euler(Vector3 euler) { }

	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Quaternion other) { }

	public override string ToString() { }

	private static void .cctor() { }

	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

}

public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
{
[Serializable]
public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
	public float4 value; // 0x0
	public static readonly quaternion identity; // 0x0


	public static Quaternion op_Implicit(quaternion q) { }

	public static quaternion op_Implicit(Quaternion q) { }

	public void .ctor(float x, float y, float z, float w) { }

	public void .ctor(float4 value) { }

	public static quaternion AxisAngle(float3 axis, float angle) { }

	public bool Equals(quaternion x) { }

	public override bool Equals(object x) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	private static void .cctor() { }

}

