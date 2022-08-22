public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	// Fields
	[NativeNameAttribute] // RVA: 0xAA2F0 Offset: 0xA96F0 VA: 0x1800AA2F0
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xAA340 Offset: 0xA9740 VA: 0x1800AA340
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xAA3A0 Offset: 0xA97A0 VA: 0x1800AA3A0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xAA410 Offset: 0xA9810 VA: 0x1800AA410
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xAA4C0 Offset: 0xA98C0 VA: 0x1800AA4C0
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xAA590 Offset: 0xA9990 VA: 0x1800AA590
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xAA600 Offset: 0xA9A00 VA: 0x1800AA600
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xAA810 Offset: 0xA9C10 VA: 0x1800AA810
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xAA8B0 Offset: 0xA9CB0 VA: 0x1800AA8B0
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xAA970 Offset: 0xA9D70 VA: 0x1800AA970
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xAAA60 Offset: 0xA9E60 VA: 0x1800AAA60
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xAAB50 Offset: 0xA9F50 VA: 0x1800AAB50
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xAAC40 Offset: 0xAA040 VA: 0x1800AAC40
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xAADD0 Offset: 0xAA1D0 VA: 0x1800AADD0
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xAAF00 Offset: 0xAA300 VA: 0x1800AAF00
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
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

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x216530 Offset: 0x215930 VA: 0x180216530
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x216510 Offset: 0x215910 VA: 0x180216510
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x216200 Offset: 0x215600 VA: 0x180216200
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x216FB0 Offset: 0x2163B0 VA: 0x180216FB0
	public Quaternion get_rotation() { }

	// RVA: 0x216F00 Offset: 0x216300 VA: 0x180216F00
	public Vector3 get_lossyScale() { }

	// RVA: 0x216CD0 Offset: 0x2160D0 VA: 0x180216CD0
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	// RVA: 0x18F0670 Offset: 0x18EEC70 VA: 0x1818F0670
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x216A80 Offset: 0x215E80 VA: 0x180216A80
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB5E0 Offset: 0xAA9E0 VA: 0x1800AB5E0
	// RVA: 0x18EFD30 Offset: 0x18EE330 VA: 0x1818EFD30
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x216D80 Offset: 0x216180 VA: 0x180216D80
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB6A0 Offset: 0xAAAA0 VA: 0x1800AB6A0
	// RVA: 0x18F0FC0 Offset: 0x18EF5C0 VA: 0x1818F0FC0
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x217050 Offset: 0x216450 VA: 0x180217050
	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB850 Offset: 0xAAC50 VA: 0x1800AB850
	// RVA: 0x18F00E0 Offset: 0x18EE6E0 VA: 0x1818F00E0
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB890 Offset: 0xAAC90 VA: 0x1800AB890
	// RVA: 0x18F0240 Offset: 0x18EE840 VA: 0x1818F0240
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB9A0 Offset: 0xAADA0 VA: 0x1800AB9A0
	// RVA: 0x18EF620 Offset: 0x18EDC20 VA: 0x1818EF620
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x18EF4A0 Offset: 0x18EDAA0 VA: 0x1818EF4A0
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x216BF0 Offset: 0x215FF0 VA: 0x180216BF0
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x216CA0 Offset: 0x2160A0 VA: 0x180216CA0
	public float get_Item(int row, int column) { }

	// RVA: 0x2171E0 Offset: 0x2165E0 VA: 0x1802171E0
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x216CC0 Offset: 0x2160C0 VA: 0x180216CC0
	public float get_Item(int index) { }

	// RVA: 0x2171D0 Offset: 0x2165D0 VA: 0x1802171D0
	public void set_Item(int index, float value) { }

	// RVA: 0x216330 Offset: 0x215730 VA: 0x180216330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x216220 Offset: 0x215620 VA: 0x180216220 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2162D0 Offset: 0x2156D0 VA: 0x1802162D0 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x18F1CA0 Offset: 0x18F02A0 VA: 0x1818F1CA0
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x18F1B00 Offset: 0x18F0100 VA: 0x1818F1B00
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x216310 Offset: 0x215710 VA: 0x180216310
	public Vector4 GetColumn(int index) { }

	// RVA: 0x216550 Offset: 0x215950 VA: 0x180216550
	public Vector4 GetRow(int index) { }

	// RVA: 0x216980 Offset: 0x215D80 VA: 0x180216980
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x216A00 Offset: 0x215E00 VA: 0x180216A00
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x2167A0 Offset: 0x215BA0 VA: 0x1802167A0
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x2166E0 Offset: 0x215AE0 VA: 0x1802166E0
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x2168D0 Offset: 0x215CD0 VA: 0x1802168D0
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x18F0300 Offset: 0x18EE900 VA: 0x1818F0300
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x18F0ED0 Offset: 0x18EF4D0 VA: 0x1818F0ED0
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x18F1620 Offset: 0x18EFC20 VA: 0x1818F1620
	public static Matrix4x4 get_identity() { }

	// RVA: 0x216BE0 Offset: 0x215FE0 VA: 0x180216BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F1050 Offset: 0x18EF650 VA: 0x1818F1050
	private static void .cctor() { }

	// RVA: 0x18EFAE0 Offset: 0x18EE0E0 VA: 0x1818EFAE0
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x18EFA00 Offset: 0x18EE000 VA: 0x1818EFA00
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x18EEF70 Offset: 0x18ED570 VA: 0x1818EEF70
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x18F0600 Offset: 0x18EEC00 VA: 0x1818F0600
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x18EFCE0 Offset: 0x18EE2E0 VA: 0x1818EFCE0
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F0F70 Offset: 0x18EF570 VA: 0x1818F0F70
	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F0060 Offset: 0x18EE660 VA: 0x1818F0060
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18F01C0 Offset: 0x18EE7C0 VA: 0x1818F01C0
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18EF420 Offset: 0x18EDA20 VA: 0x1818EF420
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

