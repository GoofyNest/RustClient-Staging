public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	[NativeNameAttribute] // RVA: 0xAA3D0 Offset: 0xA97D0 VA: 0x1800AA3D0
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xAA450 Offset: 0xA9850 VA: 0x1800AA450
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xAA4B0 Offset: 0xA98B0 VA: 0x1800AA4B0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xAA520 Offset: 0xA9920 VA: 0x1800AA520
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xAA5A0 Offset: 0xA99A0 VA: 0x1800AA5A0
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xAA630 Offset: 0xA9A30 VA: 0x1800AA630
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xAA690 Offset: 0xA9A90 VA: 0x1800AA690
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xAA8A0 Offset: 0xA9CA0 VA: 0x1800AA8A0
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xAA940 Offset: 0xA9D40 VA: 0x1800AA940
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xAAA00 Offset: 0xA9E00 VA: 0x1800AAA00
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xAAB00 Offset: 0xA9F00 VA: 0x1800AAB00
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xAABF0 Offset: 0xA9FF0 VA: 0x1800AABF0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xAAD10 Offset: 0xAA110 VA: 0x1800AAD10
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xAAEA0 Offset: 0xAA2A0 VA: 0x1800AAEA0
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xAB170 Offset: 0xAA570 VA: 0x1800AB170
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }


	[ThreadSafeAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	private FrustumPlanes DecomposeProjection() { }

	public Quaternion get_rotation() { }

	public Vector3 get_lossyScale() { }

	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB550 Offset: 0xAA950 VA: 0x1800AB550
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB6F0 Offset: 0xAAAF0 VA: 0x1800AB6F0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB780 Offset: 0xAAB80 VA: 0x1800AB780
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB960 Offset: 0xAAD60 VA: 0x1800AB960
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB9A0 Offset: 0xAADA0 VA: 0x1800AB9A0
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xABAB0 Offset: 0xAAEB0 VA: 0x1800ABAB0
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	public float get_Item(int row, int column) { }

	public void set_Item(int row, int column, float value) { }

	public float get_Item(int index) { }

	public void set_Item(int index, float value) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Matrix4x4 other) { }

	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	public Vector4 GetColumn(int index) { }

	public Vector4 GetRow(int index) { }

	public void SetColumn(int index, Vector4 column) { }

	public void SetRow(int index, Vector4 row) { }

	public Vector3 MultiplyPoint(Vector3 point) { }

	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	public Vector3 MultiplyVector(Vector3 vector) { }

	public static Matrix4x4 Scale(Vector3 vector) { }

	public static Matrix4x4 Translate(Vector3 vector) { }

	public static Matrix4x4 get_identity() { }

	public override string ToString() { }

	private static void .cctor() { }

	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

