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

	[FreeFunctionAttribute] // RVA: 0xAC2C0 Offset: 0xAB6C0 VA: 0x1800AC2C0
	// RVA: 0x18FE1B0 Offset: 0x18FC7B0 VA: 0x1818FE1B0
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x18FE5A0 Offset: 0x18FCBA0 VA: 0x1818FE5A0
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xAC550 Offset: 0xAB950 VA: 0x1800AC550
	// RVA: 0x18FF020 Offset: 0x18FD620 VA: 0x1818FF020
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC6B0 Offset: 0xABAB0 VA: 0x1800AC6B0
	// RVA: 0x18FEF00 Offset: 0x18FD500 VA: 0x1818FEF00
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC820 Offset: 0xABC20 VA: 0x1800AC820
	// RVA: 0x18FE7D0 Offset: 0x18FCDD0 VA: 0x1818FE7D0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC970 Offset: 0xABD70 VA: 0x1800AC970
	// RVA: 0x18FE6B0 Offset: 0x18FCCB0 VA: 0x1818FE6B0
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xACAA0 Offset: 0xABEA0 VA: 0x1800ACAA0
	// RVA: 0x18FE310 Offset: 0x18FC910 VA: 0x1818FE310
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xACB80 Offset: 0xABF80 VA: 0x1800ACB80
	// RVA: 0x18FE4C0 Offset: 0x18FCAC0 VA: 0x1818FE4C0
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xACC50 Offset: 0xAC050 VA: 0x1800ACC50
	// RVA: 0x18FDB90 Offset: 0x18FC190 VA: 0x1818FDB90
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xACDD0 Offset: 0xAC1D0 VA: 0x1800ACDD0
	// RVA: 0x18FEA30 Offset: 0x18FD030 VA: 0x1818FEA30
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18FE8E0 Offset: 0x18FCEE0 VA: 0x1818FE8E0
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x18FF520 Offset: 0x18FDB20 VA: 0x1818FF520
	public static Quaternion get_identity() { }

	// RVA: 0x18FF940 Offset: 0x18FDF40 VA: 0x1818FF940
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FF750 Offset: 0x18FDD50 VA: 0x1818FF750
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x18FE630 Offset: 0x18FCC30 VA: 0x1818FE630
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x18FF590 Offset: 0x18FDB90 VA: 0x1818FF590
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FF650 Offset: 0x18FDC50 VA: 0x1818FF650
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FDD50 Offset: 0x18FC350 VA: 0x1818FDD50
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x217A40 Offset: 0x216E40 VA: 0x180217A40
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x18FDC30 Offset: 0x18FC230 VA: 0x1818FDC30
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x18FE3A0 Offset: 0x18FC9A0 VA: 0x1818FE3A0
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x217B60 Offset: 0x216F60 VA: 0x180217B60
	public Vector3 get_eulerAngles() { }

	// RVA: 0x18FDE80 Offset: 0x18FC480 VA: 0x1818FDE80
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x18FE010 Offset: 0x18FC610 VA: 0x1818FE010
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x18FEAD0 Offset: 0x18FD0D0 VA: 0x1818FEAD0
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x2179D0 Offset: 0x216DD0 VA: 0x1802179D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2178F0 Offset: 0x216CF0 VA: 0x1802178F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x213060 Offset: 0x212460 VA: 0x180213060 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x217B50 Offset: 0x216F50 VA: 0x180217B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x18FF310 Offset: 0x18FD910 VA: 0x1818FF310
	private static void .cctor() { }

	// RVA: 0x18FE150 Offset: 0x18FC750 VA: 0x1818FE150
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x18FE550 Offset: 0x18FCB50 VA: 0x1818FE550
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x18FEFB0 Offset: 0x18FD5B0 VA: 0x1818FEFB0
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FEE90 Offset: 0x18FD490 VA: 0x1818FEE90
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE760 Offset: 0x18FCD60 VA: 0x1818FE760
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE640 Offset: 0x18FCC40 VA: 0x1818FE640
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18FE2C0 Offset: 0x18FC8C0 VA: 0x1818FE2C0
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x18FE470 Offset: 0x18FCA70 VA: 0x1818FE470
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x18FDB30 Offset: 0x18FC130 VA: 0x1818FDB30
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x18FE880 Offset: 0x18FCE80 VA: 0x1818FE880
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

	// RVA: 0x22B09C0 Offset: 0x22AEFC0 VA: 0x1822B09C0
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x957AB0 Offset: 0x9560B0 VA: 0x180957AB0
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x19E490 Offset: 0x19D890 VA: 0x18019E490
	public void .ctor(float4 value) { }

	// RVA: 0x22B03D0 Offset: 0x22AE9D0 VA: 0x1822B03D0
	public static quaternion AxisAngle(float3 axis, float angle) { }

	// RVA: 0x23A8A0 Offset: 0x239CA0 VA: 0x18023A8A0 Slot: 4
	public bool Equals(quaternion x) { }

	// RVA: 0x23A7F0 Offset: 0x239BF0 VA: 0x18023A7F0 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x23A0D0 Offset: 0x2394D0 VA: 0x18023A0D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A8F0 Offset: 0x239CF0 VA: 0x18023A8F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A8E0 Offset: 0x239CE0 VA: 0x18023A8E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x22B0980 Offset: 0x22AEF80 VA: 0x1822B0980
	private static void .cctor() { }

}

