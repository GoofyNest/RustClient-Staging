public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	// Fields
	[NativeNameAttribute] // RVA: 0xAA230 Offset: 0xA9630 VA: 0x1800AA230
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xAA280 Offset: 0xA9680 VA: 0x1800AA280
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xAA2F0 Offset: 0xA96F0 VA: 0x1800AA2F0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xAA350 Offset: 0xA9750 VA: 0x1800AA350
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xAA420 Offset: 0xA9820 VA: 0x1800AA420
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xAA560 Offset: 0xA9960 VA: 0x1800AA560
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xAA680 Offset: 0xA9A80 VA: 0x1800AA680
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xAA810 Offset: 0xA9C10 VA: 0x1800AA810
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xAA900 Offset: 0xA9D00 VA: 0x1800AA900
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xAAA10 Offset: 0xA9E10 VA: 0x1800AAA10
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xAAAB0 Offset: 0xA9EB0 VA: 0x1800AAAB0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xAABE0 Offset: 0xA9FE0 VA: 0x1800AABE0
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xAAD70 Offset: 0xAA170 VA: 0x1800AAD70
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xAADE0 Offset: 0xAA1E0 VA: 0x1800AADE0
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xAB040 Offset: 0xAA440 VA: 0x1800AB040
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x215EE0 Offset: 0x2152E0 VA: 0x180215EE0
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x215EC0 Offset: 0x2152C0 VA: 0x180215EC0
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x215BB0 Offset: 0x214FB0 VA: 0x180215BB0
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x216960 Offset: 0x215D60 VA: 0x180216960
	public Quaternion get_rotation() { }

	// RVA: 0x2168B0 Offset: 0x215CB0 VA: 0x1802168B0
	public Vector3 get_lossyScale() { }

	// RVA: 0x216680 Offset: 0x215A80 VA: 0x180216680
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB3A0 Offset: 0xAA7A0 VA: 0x1800AB3A0
	// RVA: 0x18F0CD0 Offset: 0x18EF2D0 VA: 0x1818F0CD0
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x216430 Offset: 0x215830 VA: 0x180216430
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB540 Offset: 0xAA940 VA: 0x1800AB540
	// RVA: 0x18F0390 Offset: 0x18EE990 VA: 0x1818F0390
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x216730 Offset: 0x215B30 VA: 0x180216730
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB600 Offset: 0xAAA00 VA: 0x1800AB600
	// RVA: 0x18F1620 Offset: 0x18EFC20 VA: 0x1818F1620
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x216A00 Offset: 0x215E00 VA: 0x180216A00
	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB760 Offset: 0xAAB60 VA: 0x1800AB760
	// RVA: 0x18F0740 Offset: 0x18EED40 VA: 0x1818F0740
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB7F0 Offset: 0xAABF0 VA: 0x1800AB7F0
	// RVA: 0x18F08A0 Offset: 0x18EEEA0 VA: 0x1818F08A0
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB900 Offset: 0xAAD00 VA: 0x1800AB900
	// RVA: 0x18EFC80 Offset: 0x18EE280 VA: 0x1818EFC80
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x18EFB00 Offset: 0x18EE100 VA: 0x1818EFB00
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x2165A0 Offset: 0x2159A0 VA: 0x1802165A0
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x216650 Offset: 0x215A50 VA: 0x180216650
	public float get_Item(int row, int column) { }

	// RVA: 0x216B90 Offset: 0x215F90 VA: 0x180216B90
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x216670 Offset: 0x215A70 VA: 0x180216670
	public float get_Item(int index) { }

	// RVA: 0x216B80 Offset: 0x215F80 VA: 0x180216B80
	public void set_Item(int index, float value) { }

	// RVA: 0x215CE0 Offset: 0x2150E0 VA: 0x180215CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215BD0 Offset: 0x214FD0 VA: 0x180215BD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x215C80 Offset: 0x215080 VA: 0x180215C80 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x18F2300 Offset: 0x18F0900 VA: 0x1818F2300
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x18F2160 Offset: 0x18F0760 VA: 0x1818F2160
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x215CC0 Offset: 0x2150C0 VA: 0x180215CC0
	public Vector4 GetColumn(int index) { }

	// RVA: 0x215F00 Offset: 0x215300 VA: 0x180215F00
	public Vector4 GetRow(int index) { }

	// RVA: 0x216330 Offset: 0x215730 VA: 0x180216330
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x2163B0 Offset: 0x2157B0 VA: 0x1802163B0
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x216150 Offset: 0x215550 VA: 0x180216150
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x216090 Offset: 0x215490 VA: 0x180216090
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x216280 Offset: 0x215680 VA: 0x180216280
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x18F0960 Offset: 0x18EEF60 VA: 0x1818F0960
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x18F1530 Offset: 0x18EFB30 VA: 0x1818F1530
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x18F1C80 Offset: 0x18F0280 VA: 0x1818F1C80
	public static Matrix4x4 get_identity() { }

	// RVA: 0x216590 Offset: 0x215990 VA: 0x180216590 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F16B0 Offset: 0x18EFCB0 VA: 0x1818F16B0
	private static void .cctor() { }

	// RVA: 0x18F0140 Offset: 0x18EE740 VA: 0x1818F0140
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x18F0060 Offset: 0x18EE660 VA: 0x1818F0060
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x18EF5D0 Offset: 0x18EDBD0 VA: 0x1818EF5D0
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x18F0C60 Offset: 0x18EF260 VA: 0x1818F0C60
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x18F0340 Offset: 0x18EE940 VA: 0x1818F0340
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F15D0 Offset: 0x18EFBD0 VA: 0x1818F15D0
	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F06C0 Offset: 0x18EECC0 VA: 0x1818F06C0
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18F0820 Offset: 0x18EEE20 VA: 0x1818F0820
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18EFA80 Offset: 0x18EE080 VA: 0x1818EFA80
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

