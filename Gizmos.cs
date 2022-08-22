public sealed class Gizmos // TypeDefIndex: 3380
{	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x18193D0 Offset: 0x18179D0 VA: 0x1818193D0
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x18197E0 Offset: 0x1817DE0 VA: 0x1818197E0
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x18196A0 Offset: 0x1817CA0 VA: 0x1818196A0
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x1819740 Offset: 0x1817D40 VA: 0x181819740
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x18190F0 Offset: 0x18176F0 VA: 0x1818190F0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x1819500 Offset: 0x1817B00 VA: 0x181819500
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x18192A0 Offset: 0x18178A0 VA: 0x1818192A0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x1819310 Offset: 0x1817910 VA: 0x181819310
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x1819870 Offset: 0x1817E70 VA: 0x181819870
	public static Color get_color() { }

	// RVA: 0x1819980 Offset: 0x1817F80 VA: 0x181819980
	public static void set_color(Color value) { }

	// RVA: 0x18198F0 Offset: 0x1817EF0 VA: 0x1818198F0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1819A00 Offset: 0x1818000 VA: 0x181819A00
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x18191B0 Offset: 0x18177B0 VA: 0x1818191B0
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x1819570 Offset: 0x1817B70 VA: 0x181819570
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x1819480 Offset: 0x1817A80 VA: 0x181819480
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x1819380 Offset: 0x1817980 VA: 0x181819380
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x1819790 Offset: 0x1817D90 VA: 0x181819790
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x1819650 Offset: 0x1817C50 VA: 0x181819650
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x18196F0 Offset: 0x1817CF0 VA: 0x1818196F0
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x18190A0 Offset: 0x18176A0 VA: 0x1818190A0
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x1819420 Offset: 0x1817A20 VA: 0x181819420
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x1819230 Offset: 0x1817830 VA: 0x181819230
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x1819830 Offset: 0x1817E30 VA: 0x181819830
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1819940 Offset: 0x1817F40 VA: 0x181819940
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x18198B0 Offset: 0x1817EB0 VA: 0x1818198B0
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x18199C0 Offset: 0x1817FC0 VA: 0x1818199C0
	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1819140 Offset: 0x1817740 VA: 0x181819140
	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

