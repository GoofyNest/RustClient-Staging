public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 3468
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xAC360 Offset: 0xAB760 VA: 0x1800AC360
	// RVA: 0x18FDB50 Offset: 0x18FC150 VA: 0x1818FDB50
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x18FDF40 Offset: 0x18FC540 VA: 0x1818FDF40
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xAC5F0 Offset: 0xAB9F0 VA: 0x1800AC5F0
	// RVA: 0x18FE9C0 Offset: 0x18FCFC0 VA: 0x1818FE9C0
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC750 Offset: 0xABB50 VA: 0x1800AC750
	// RVA: 0x18FE8A0 Offset: 0x18FCEA0 VA: 0x1818FE8A0
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC8C0 Offset: 0xABCC0 VA: 0x1800AC8C0
	// RVA: 0x18FE170 Offset: 0x18FC770 VA: 0x1818FE170
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACA70 Offset: 0xABE70 VA: 0x1800ACA70
	// RVA: 0x18FE050 Offset: 0x18FC650 VA: 0x1818FE050
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACB40 Offset: 0xABF40 VA: 0x1800ACB40
	// RVA: 0x18FDCB0 Offset: 0x18FC2B0 VA: 0x1818FDCB0
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xACC50 Offset: 0xAC050 VA: 0x1800ACC50
	// RVA: 0x18FDE60 Offset: 0x18FC460 VA: 0x1818FDE60
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xACCF0 Offset: 0xAC0F0 VA: 0x1800ACCF0
	// RVA: 0x18FD530 Offset: 0x18FBB30 VA: 0x1818FD530
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	// RVA: 0x18FE3D0 Offset: 0x18FC9D0 VA: 0x1818FE3D0
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FE280 Offset: 0x18FC880 VA: 0x1818FE280
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x18FEEC0 Offset: 0x18FD4C0 VA: 0x1818FEEC0
	public static Quaternion get_identity() { }

	// RVA: 0x18FF2E0 Offset: 0x18FD8E0 VA: 0x1818FF2E0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FF0F0 Offset: 0x18FD6F0 VA: 0x1818FF0F0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x18FDFD0 Offset: 0x18FC5D0 VA: 0x1818FDFD0
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x18FEF30 Offset: 0x18FD530 VA: 0x1818FEF30
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FEFF0 Offset: 0x18FD5F0 VA: 0x1818FEFF0
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FD6F0 Offset: 0x18FBCF0 VA: 0x1818FD6F0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x218090 Offset: 0x217490 VA: 0x180218090
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x18FD5D0 Offset: 0x18FBBD0 VA: 0x1818FD5D0
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x18FDD40 Offset: 0x18FC340 VA: 0x1818FDD40
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x2181B0 Offset: 0x2175B0 VA: 0x1802181B0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x18FD820 Offset: 0x18FBE20 VA: 0x1818FD820
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x18FD9B0 Offset: 0x18FBFB0 VA: 0x1818FD9B0
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x18FE470 Offset: 0x18FCA70 VA: 0x1818FE470
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x218020 Offset: 0x217420 VA: 0x180218020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217F40 Offset: 0x217340 VA: 0x180217F40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212410 Offset: 0x211810 VA: 0x180212410 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x2181A0 Offset: 0x2175A0 VA: 0x1802181A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18FECB0 Offset: 0x18FD2B0 VA: 0x1818FECB0
	private static void .cctor() { }

	// RVA: 0x18FDAF0 Offset: 0x18FC0F0 VA: 0x1818FDAF0
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x18FDEF0 Offset: 0x18FC4F0 VA: 0x1818FDEF0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x18FE950 Offset: 0x18FCF50 VA: 0x1818FE950
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE830 Offset: 0x18FCE30 VA: 0x1818FE830
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE100 Offset: 0x18FC700 VA: 0x1818FE100
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FDFE0 Offset: 0x18FC5E0 VA: 0x1818FDFE0
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FDC60 Offset: 0x18FC260 VA: 0x1818FDC60
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x18FDE10 Offset: 0x18FC410 VA: 0x1818FDE10
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x18FD4D0 Offset: 0x18FBAD0 VA: 0x1818FD4D0
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x18FE220 Offset: 0x18FC820 VA: 0x1818FE220
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

}

public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
{
// Namespace: Unity.Mathematics
[Serializable]
public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
	// Fields
	public float4 value; // 0x0
	public static readonly quaternion identity; // 0x0

	// Methods

	// RVA: 0x22B12E0 Offset: 0x22AF8E0 VA: 0x1822B12E0
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x9580C0 Offset: 0x9566C0 VA: 0x1809580C0
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x19E100 Offset: 0x19D500 VA: 0x18019E100
	public void .ctor(float4 value) { }

	// RVA: 0x22B0CF0 Offset: 0x22AF2F0 VA: 0x1822B0CF0
	public static quaternion AxisAngle(float3 axis, float angle) { }

	// RVA: 0x23A820 Offset: 0x239C20 VA: 0x18023A820 Slot: 4
	public bool Equals(quaternion x) { }

	// RVA: 0x23A770 Offset: 0x239B70 VA: 0x18023A770 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x23A050 Offset: 0x239450 VA: 0x18023A050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A870 Offset: 0x239C70 VA: 0x18023A870 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A860 Offset: 0x239C60 VA: 0x18023A860 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x22B12A0 Offset: 0x22AF8A0 VA: 0x1822B12A0
	private static void .cctor() { }

}

