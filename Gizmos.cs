public sealed class Gizmos // TypeDefIndex: 3380
{	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BD10 Offset: 0x182A310 VA: 0x18182BD10
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182C120 Offset: 0x182A720 VA: 0x18182C120
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BFE0 Offset: 0x182A5E0 VA: 0x18182BFE0
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182C080 Offset: 0x182A680 VA: 0x18182C080
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BA30 Offset: 0x182A030 VA: 0x18182BA30
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BE40 Offset: 0x182A440 VA: 0x18182BE40
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BBE0 Offset: 0x182A1E0 VA: 0x18182BBE0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x182BC50 Offset: 0x182A250 VA: 0x18182BC50
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x182C1B0 Offset: 0x182A7B0 VA: 0x18182C1B0
	public static Color get_color() { }

	// RVA: 0x182C2C0 Offset: 0x182A8C0 VA: 0x18182C2C0
	public static void set_color(Color value) { }

	// RVA: 0x182C230 Offset: 0x182A830 VA: 0x18182C230
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x182C340 Offset: 0x182A940 VA: 0x18182C340
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x182BAF0 Offset: 0x182A0F0 VA: 0x18182BAF0
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x182BEB0 Offset: 0x182A4B0 VA: 0x18182BEB0
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x182BDC0 Offset: 0x182A3C0 VA: 0x18182BDC0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x182BCC0 Offset: 0x182A2C0 VA: 0x18182BCC0
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x182C0D0 Offset: 0x182A6D0 VA: 0x18182C0D0
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182BF90 Offset: 0x182A590 VA: 0x18182BF90
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182C030 Offset: 0x182A630 VA: 0x18182C030
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182B9E0 Offset: 0x1829FE0 VA: 0x18182B9E0
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182BD60 Offset: 0x182A360 VA: 0x18182BD60
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x182BB70 Offset: 0x182A170 VA: 0x18182BB70
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x182C170 Offset: 0x182A770 VA: 0x18182C170
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x182C280 Offset: 0x182A880 VA: 0x18182C280
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x182C1F0 Offset: 0x182A7F0 VA: 0x18182C1F0
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x182C300 Offset: 0x182A900 VA: 0x18182C300
	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x182BA80 Offset: 0x182A080 VA: 0x18182BA80
	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

