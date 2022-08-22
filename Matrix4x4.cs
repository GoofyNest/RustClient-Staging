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
	// RVA: 0x215E60 Offset: 0x215260 VA: 0x180215E60
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x215E40 Offset: 0x215240 VA: 0x180215E40
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x215B30 Offset: 0x214F30 VA: 0x180215B30
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x2168E0 Offset: 0x215CE0 VA: 0x1802168E0
	public Quaternion get_rotation() { }

	// RVA: 0x216830 Offset: 0x215C30 VA: 0x180216830
	public Vector3 get_lossyScale() { }

	// RVA: 0x216600 Offset: 0x215A00 VA: 0x180216600
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	// RVA: 0x18F0F50 Offset: 0x18EF550 VA: 0x1818F0F50
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x2163B0 Offset: 0x2157B0 VA: 0x1802163B0
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB5E0 Offset: 0xAA9E0 VA: 0x1800AB5E0
	// RVA: 0x18F0610 Offset: 0x18EEC10 VA: 0x1818F0610
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x2166B0 Offset: 0x215AB0 VA: 0x1802166B0
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB6A0 Offset: 0xAAAA0 VA: 0x1800AB6A0
	// RVA: 0x18F18A0 Offset: 0x18EFEA0 VA: 0x1818F18A0
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x216980 Offset: 0x215D80 VA: 0x180216980
	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB850 Offset: 0xAAC50 VA: 0x1800AB850
	// RVA: 0x18F09C0 Offset: 0x18EEFC0 VA: 0x1818F09C0
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB890 Offset: 0xAAC90 VA: 0x1800AB890
	// RVA: 0x18F0B20 Offset: 0x18EF120 VA: 0x1818F0B20
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB9A0 Offset: 0xAADA0 VA: 0x1800AB9A0
	// RVA: 0x18EFF00 Offset: 0x18EE500 VA: 0x1818EFF00
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x18EFD80 Offset: 0x18EE380 VA: 0x1818EFD80
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x216520 Offset: 0x215920 VA: 0x180216520
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x2165D0 Offset: 0x2159D0 VA: 0x1802165D0
	public float get_Item(int row, int column) { }

	// RVA: 0x216B10 Offset: 0x215F10 VA: 0x180216B10
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x2165F0 Offset: 0x2159F0 VA: 0x1802165F0
	public float get_Item(int index) { }

	// RVA: 0x216B00 Offset: 0x215F00 VA: 0x180216B00
	public void set_Item(int index, float value) { }

	// RVA: 0x215C60 Offset: 0x215060 VA: 0x180215C60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215B50 Offset: 0x214F50 VA: 0x180215B50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x215C00 Offset: 0x215000 VA: 0x180215C00 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x18F2580 Offset: 0x18F0B80 VA: 0x1818F2580
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x18F23E0 Offset: 0x18F09E0 VA: 0x1818F23E0
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x215C40 Offset: 0x215040 VA: 0x180215C40
	public Vector4 GetColumn(int index) { }

	// RVA: 0x215E80 Offset: 0x215280 VA: 0x180215E80
	public Vector4 GetRow(int index) { }

	// RVA: 0x2162B0 Offset: 0x2156B0 VA: 0x1802162B0
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x216330 Offset: 0x215730 VA: 0x180216330
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x2160D0 Offset: 0x2154D0 VA: 0x1802160D0
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x216010 Offset: 0x215410 VA: 0x180216010
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x216200 Offset: 0x215600 VA: 0x180216200
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x18F0BE0 Offset: 0x18EF1E0 VA: 0x1818F0BE0
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x18F17B0 Offset: 0x18EFDB0 VA: 0x1818F17B0
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x18F1F00 Offset: 0x18F0500 VA: 0x1818F1F00
	public static Matrix4x4 get_identity() { }

	// RVA: 0x216510 Offset: 0x215910 VA: 0x180216510 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F1930 Offset: 0x18EFF30 VA: 0x1818F1930
	private static void .cctor() { }

	// RVA: 0x18F03C0 Offset: 0x18EE9C0 VA: 0x1818F03C0
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x18F02E0 Offset: 0x18EE8E0 VA: 0x1818F02E0
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x18EF850 Offset: 0x18EDE50 VA: 0x1818EF850
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x18F0EE0 Offset: 0x18EF4E0 VA: 0x1818F0EE0
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x18F05C0 Offset: 0x18EEBC0 VA: 0x1818F05C0
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F1850 Offset: 0x18EFE50 VA: 0x1818F1850
	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18F0940 Offset: 0x18EEF40 VA: 0x1818F0940
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18F0AA0 Offset: 0x18EF0A0 VA: 0x1818F0AA0
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18EFD00 Offset: 0x18EE300 VA: 0x1818EFD00
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

