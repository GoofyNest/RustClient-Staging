public sealed class GL // TypeDefIndex: 3390
{	// Properties
	public static bool sRGBWrite { get; set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8ABD0 Offset: 0x89FD0 VA: 0x18008ABD0
	// RVA: 0x182AB30 Offset: 0x1829130 VA: 0x18182AB30
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x182AB90 Offset: 0x1829190 VA: 0x18182AB90
	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8ACE0 Offset: 0x8A0E0 VA: 0x18008ACE0
	// RVA: 0x182AAD0 Offset: 0x18290D0 VA: 0x18182AAD0
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x182AA80 Offset: 0x1829080 VA: 0x18182AA80
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ADB0 Offset: 0x8A1B0 VA: 0x18008ADB0
	// RVA: 0x182A9B0 Offset: 0x1828FB0 VA: 0x18182A9B0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x182A950 Offset: 0x1828F50 VA: 0x18182A950
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE20 Offset: 0x8A220 VA: 0x18008AE20
	// RVA: 0x182A690 Offset: 0x1828C90 VA: 0x18182A690
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x182A360 Offset: 0x1828960 VA: 0x18182A360
	public static void Color(Color c) { }

	// RVA: 0x182ABF0 Offset: 0x18291F0 VA: 0x18182ABF0
	public static bool get_sRGBWrite() { }

	// RVA: 0x182AC20 Offset: 0x1829220 VA: 0x18182AC20
	public static void set_sRGBWrite(bool value) { }

	// RVA: 0x182A3F0 Offset: 0x18289F0 VA: 0x18182A3F0
	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	// RVA: 0x182A910 Offset: 0x1828F10 VA: 0x18182A910
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	// RVA: 0x182AA50 Offset: 0x1829050 VA: 0x18182AA50
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	// RVA: 0x182AA20 Offset: 0x1829020 VA: 0x18182AA20
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	// RVA: 0x182A7C0 Offset: 0x1828DC0 VA: 0x18182A7C0
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	// RVA: 0x182A7F0 Offset: 0x1828DF0 VA: 0x18182A7F0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	// RVA: 0x182A820 Offset: 0x1828E20 VA: 0x18182A820
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B300 Offset: 0x8A700 VA: 0x18008B300
	// RVA: 0x182A890 Offset: 0x1828E90 VA: 0x18182A890
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B400 Offset: 0x8A800 VA: 0x18008B400
	// RVA: 0x182A620 Offset: 0x1828C20 VA: 0x18182A620
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A540 Offset: 0x1828B40 VA: 0x18182A540
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x182A540 Offset: 0x1828B40 VA: 0x18182A540
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A500 Offset: 0x1828B00 VA: 0x18182A500
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x182A710 Offset: 0x1828D10 VA: 0x18182A710
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C7E0 Offset: 0x8BBE0 VA: 0x18008C7E0
	// RVA: 0x182A270 Offset: 0x1828870 VA: 0x18182A270
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C9E0 Offset: 0x8BDE0 VA: 0x18008C9E0
	// RVA: 0x182A3C0 Offset: 0x18289C0 VA: 0x18182A3C0
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A490 Offset: 0x1828A90 VA: 0x18182A490
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x182A300 Offset: 0x1828900 VA: 0x18182A300
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CAF0 Offset: 0x8BEF0 VA: 0x18008CAF0
	// RVA: 0x182A2B0 Offset: 0x18288B0 VA: 0x18182A2B0
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x182A8D0 Offset: 0x1828ED0 VA: 0x18182A8D0
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x182A850 Offset: 0x1828E50 VA: 0x18182A850
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x182A5C0 Offset: 0x1828BC0 VA: 0x18182A5C0
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x182A420 Offset: 0x1828A20 VA: 0x18182A420
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

