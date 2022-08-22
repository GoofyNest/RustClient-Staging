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
	// RVA: 0x18FE430 Offset: 0x18FCA30 VA: 0x1818FE430
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x18FE820 Offset: 0x18FCE20 VA: 0x1818FE820
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xAC5F0 Offset: 0xAB9F0 VA: 0x1800AC5F0
	// RVA: 0x18FF2A0 Offset: 0x18FD8A0 VA: 0x1818FF2A0
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC750 Offset: 0xABB50 VA: 0x1800AC750
	// RVA: 0x18FF180 Offset: 0x18FD780 VA: 0x1818FF180
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC8C0 Offset: 0xABCC0 VA: 0x1800AC8C0
	// RVA: 0x18FEA50 Offset: 0x18FD050 VA: 0x1818FEA50
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACA70 Offset: 0xABE70 VA: 0x1800ACA70
	// RVA: 0x18FE930 Offset: 0x18FCF30 VA: 0x1818FE930
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACB40 Offset: 0xABF40 VA: 0x1800ACB40
	// RVA: 0x18FE590 Offset: 0x18FCB90 VA: 0x1818FE590
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xACC50 Offset: 0xAC050 VA: 0x1800ACC50
	// RVA: 0x18FE740 Offset: 0x18FCD40 VA: 0x1818FE740
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xACCF0 Offset: 0xAC0F0 VA: 0x1800ACCF0
	// RVA: 0x18FDE10 Offset: 0x18FC410 VA: 0x1818FDE10
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xACE40 Offset: 0xAC240 VA: 0x1800ACE40
	// RVA: 0x18FECB0 Offset: 0x18FD2B0 VA: 0x1818FECB0
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FEB60 Offset: 0x18FD160 VA: 0x1818FEB60
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x18FF7A0 Offset: 0x18FDDA0 VA: 0x1818FF7A0
	public static Quaternion get_identity() { }

	// RVA: 0x18FFBC0 Offset: 0x18FE1C0 VA: 0x1818FFBC0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FF9D0 Offset: 0x18FDFD0 VA: 0x1818FF9D0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x18FE8B0 Offset: 0x18FCEB0 VA: 0x1818FE8B0
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x18FF810 Offset: 0x18FDE10 VA: 0x1818FF810
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FF8D0 Offset: 0x18FDED0 VA: 0x1818FF8D0
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FDFD0 Offset: 0x18FC5D0 VA: 0x1818FDFD0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x2179C0 Offset: 0x216DC0 VA: 0x1802179C0
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x18FDEB0 Offset: 0x18FC4B0 VA: 0x1818FDEB0
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x18FE620 Offset: 0x18FCC20 VA: 0x1818FE620
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x217AE0 Offset: 0x216EE0 VA: 0x180217AE0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x18FE100 Offset: 0x18FC700 VA: 0x1818FE100
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x18FE290 Offset: 0x18FC890 VA: 0x1818FE290
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x18FED50 Offset: 0x18FD350 VA: 0x1818FED50
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x217950 Offset: 0x216D50 VA: 0x180217950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217870 Offset: 0x216C70 VA: 0x180217870 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212FE0 Offset: 0x2123E0 VA: 0x180212FE0 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x217AD0 Offset: 0x216ED0 VA: 0x180217AD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18FF590 Offset: 0x18FDB90 VA: 0x1818FF590
	private static void .cctor() { }

	// RVA: 0x18FE3D0 Offset: 0x18FC9D0 VA: 0x1818FE3D0
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x18FE7D0 Offset: 0x18FCDD0 VA: 0x1818FE7D0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x18FF230 Offset: 0x18FD830 VA: 0x1818FF230
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FF110 Offset: 0x18FD710 VA: 0x1818FF110
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE9E0 Offset: 0x18FCFE0 VA: 0x1818FE9E0
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE8C0 Offset: 0x18FCEC0 VA: 0x1818FE8C0
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE540 Offset: 0x18FCB40 VA: 0x1818FE540
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x18FE6F0 Offset: 0x18FCCF0 VA: 0x1818FE6F0
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x18FDDB0 Offset: 0x18FC3B0 VA: 0x1818FDDB0
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x18FEB00 Offset: 0x18FD100 VA: 0x1818FEB00
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

	// RVA: 0x22B0AC0 Offset: 0x22AF0C0 VA: 0x1822B0AC0
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x957BC0 Offset: 0x9561C0 VA: 0x180957BC0
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x19E410 Offset: 0x19D810 VA: 0x18019E410
	public void .ctor(float4 value) { }

	// RVA: 0x22B04D0 Offset: 0x22AEAD0 VA: 0x1822B04D0
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

	// RVA: 0x22B0A80 Offset: 0x22AF080 VA: 0x1822B0A80
	private static void .cctor() { }

}

