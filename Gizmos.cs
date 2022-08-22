public sealed class Gizmos // TypeDefIndex: 3380
{	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BCD0 Offset: 0x182A2D0 VA: 0x18182BCD0
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C0E0 Offset: 0x182A6E0 VA: 0x18182C0E0
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BFA0 Offset: 0x182A5A0 VA: 0x18182BFA0
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C040 Offset: 0x182A640 VA: 0x18182C040
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182B9F0 Offset: 0x1829FF0 VA: 0x18182B9F0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BE00 Offset: 0x182A400 VA: 0x18182BE00
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BBA0 Offset: 0x182A1A0 VA: 0x18182BBA0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BC10 Offset: 0x182A210 VA: 0x18182BC10
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x182C170 Offset: 0x182A770 VA: 0x18182C170
	public static Color get_color() { }

	// RVA: 0x182C280 Offset: 0x182A880 VA: 0x18182C280
	public static void set_color(Color value) { }

	// RVA: 0x182C1F0 Offset: 0x182A7F0 VA: 0x18182C1F0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x182C300 Offset: 0x182A900 VA: 0x18182C300
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x182BAB0 Offset: 0x182A0B0 VA: 0x18182BAB0
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x182BE70 Offset: 0x182A470 VA: 0x18182BE70
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x182BD80 Offset: 0x182A380 VA: 0x18182BD80
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x182BC80 Offset: 0x182A280 VA: 0x18182BC80
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x182C090 Offset: 0x182A690 VA: 0x18182C090
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182BF50 Offset: 0x182A550 VA: 0x18182BF50
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182BFF0 Offset: 0x182A5F0 VA: 0x18182BFF0
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182B9A0 Offset: 0x1829FA0 VA: 0x18182B9A0
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182BD20 Offset: 0x182A320 VA: 0x18182BD20
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x182BB30 Offset: 0x182A130 VA: 0x18182BB30
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x182C130 Offset: 0x182A730 VA: 0x18182C130
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x182C240 Offset: 0x182A840 VA: 0x18182C240
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x182C1B0 Offset: 0x182A7B0 VA: 0x18182C1B0
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x182C2C0 Offset: 0x182A8C0 VA: 0x18182C2C0
	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x182BA40 Offset: 0x182A040 VA: 0x18182BA40
	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

