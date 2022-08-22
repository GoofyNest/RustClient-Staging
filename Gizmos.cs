public sealed class Gizmos // TypeDefIndex: 3380
{	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BF90 Offset: 0x182A590 VA: 0x18182BF90
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C3A0 Offset: 0x182A9A0 VA: 0x18182C3A0
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C260 Offset: 0x182A860 VA: 0x18182C260
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C300 Offset: 0x182A900 VA: 0x18182C300
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BCB0 Offset: 0x182A2B0 VA: 0x18182BCB0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182C0C0 Offset: 0x182A6C0 VA: 0x18182C0C0
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BE60 Offset: 0x182A460 VA: 0x18182BE60
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x182BED0 Offset: 0x182A4D0 VA: 0x18182BED0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x182C430 Offset: 0x182AA30 VA: 0x18182C430
	public static Color get_color() { }

	// RVA: 0x182C540 Offset: 0x182AB40 VA: 0x18182C540
	public static void set_color(Color value) { }

	// RVA: 0x182C4B0 Offset: 0x182AAB0 VA: 0x18182C4B0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x182C5C0 Offset: 0x182ABC0 VA: 0x18182C5C0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x182BD70 Offset: 0x182A370 VA: 0x18182BD70
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x182C130 Offset: 0x182A730 VA: 0x18182C130
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x182C040 Offset: 0x182A640 VA: 0x18182C040
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x182BF40 Offset: 0x182A540 VA: 0x18182BF40
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x182C350 Offset: 0x182A950 VA: 0x18182C350
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182C210 Offset: 0x182A810 VA: 0x18182C210
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x182C2B0 Offset: 0x182A8B0 VA: 0x18182C2B0
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182BC60 Offset: 0x182A260 VA: 0x18182BC60
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x182BFE0 Offset: 0x182A5E0 VA: 0x18182BFE0
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x182BDF0 Offset: 0x182A3F0 VA: 0x18182BDF0
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x182C3F0 Offset: 0x182A9F0 VA: 0x18182C3F0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x182C500 Offset: 0x182AB00 VA: 0x18182C500
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x182C470 Offset: 0x182AA70 VA: 0x18182C470
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x182C580 Offset: 0x182AB80 VA: 0x18182C580
	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x182BD00 Offset: 0x182A300 VA: 0x18182BD00
	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

