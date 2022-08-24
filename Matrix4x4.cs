public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	[NativeNameAttribute] // RVA: 0xAA360 Offset: 0xA9760 VA: 0x1800AA360
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xAA420 Offset: 0xA9820 VA: 0x1800AA420
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xAA4C0 Offset: 0xA98C0 VA: 0x1800AA4C0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xAA580 Offset: 0xA9980 VA: 0x1800AA580
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xAA690 Offset: 0xA9A90 VA: 0x1800AA690
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xAA7A0 Offset: 0xA9BA0 VA: 0x1800AA7A0
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xAA810 Offset: 0xA9C10 VA: 0x1800AA810
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xAAA20 Offset: 0xA9E20 VA: 0x1800AAA20
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xAAA90 Offset: 0xA9E90 VA: 0x1800AAA90
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xAAB50 Offset: 0xA9F50 VA: 0x1800AAB50
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xAAC20 Offset: 0xAA020 VA: 0x1800AAC20
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xAACF0 Offset: 0xAA0F0 VA: 0x1800AACF0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xAAD90 Offset: 0xAA190 VA: 0x1800AAD90
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xAAEE0 Offset: 0xAA2E0 VA: 0x1800AAEE0
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xAB160 Offset: 0xAA560 VA: 0x1800AB160
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


	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	private FrustumPlanes DecomposeProjection() { }

	public Quaternion get_rotation() { }

	public Vector3 get_lossyScale() { }

	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB490 Offset: 0xAA890 VA: 0x1800AB490
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB670 Offset: 0xAAA70 VA: 0x1800AB670
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB760 Offset: 0xAAB60 VA: 0x1800AB760
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB950 Offset: 0xAAD50 VA: 0x1800AB950
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB990 Offset: 0xAAD90 VA: 0x1800AB990
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xABAE0 Offset: 0xAAEE0 VA: 0x1800ABAE0
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

