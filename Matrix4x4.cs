public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	[NativeNameAttribute] // RVA: 0xAA2F0 Offset: 0xA96F0 VA: 0x1800AA2F0
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

	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }


	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	private FrustumPlanes DecomposeProjection() { }

	public Quaternion get_rotation() { }

	public Vector3 get_lossyScale() { }

	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB5E0 Offset: 0xAA9E0 VA: 0x1800AB5E0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB6A0 Offset: 0xAAAA0 VA: 0x1800AB6A0
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB850 Offset: 0xAAC50 VA: 0x1800AB850
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB890 Offset: 0xAAC90 VA: 0x1800AB890
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB9A0 Offset: 0xAADA0 VA: 0x1800AB9A0
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

