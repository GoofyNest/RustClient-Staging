public sealed class GL // TypeDefIndex: 3390
{	// Properties
	public static bool sRGBWrite { get; set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8ABD0 Offset: 0x89FD0 VA: 0x18008ABD0
	// RVA: 0x182ADF0 Offset: 0x18293F0 VA: 0x18182ADF0
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x182AE50 Offset: 0x1829450 VA: 0x18182AE50
	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8ACE0 Offset: 0x8A0E0 VA: 0x18008ACE0
	// RVA: 0x182AD90 Offset: 0x1829390 VA: 0x18182AD90
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x182AD40 Offset: 0x1829340 VA: 0x18182AD40
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ADB0 Offset: 0x8A1B0 VA: 0x18008ADB0
	// RVA: 0x182AC70 Offset: 0x1829270 VA: 0x18182AC70
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x182AC10 Offset: 0x1829210 VA: 0x18182AC10
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE20 Offset: 0x8A220 VA: 0x18008AE20
	// RVA: 0x182A950 Offset: 0x1828F50 VA: 0x18182A950
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x182A620 Offset: 0x1828C20 VA: 0x18182A620
	public static void Color(Color c) { }

	// RVA: 0x182AEB0 Offset: 0x18294B0 VA: 0x18182AEB0
	public static bool get_sRGBWrite() { }

	// RVA: 0x182AEE0 Offset: 0x18294E0 VA: 0x18182AEE0
	public static void set_sRGBWrite(bool value) { }

	// RVA: 0x182A6B0 Offset: 0x1828CB0 VA: 0x18182A6B0
	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	// RVA: 0x182ABD0 Offset: 0x18291D0 VA: 0x18182ABD0
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	// RVA: 0x182AD10 Offset: 0x1829310 VA: 0x18182AD10
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	// RVA: 0x182ACE0 Offset: 0x18292E0 VA: 0x18182ACE0
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	// RVA: 0x182AA80 Offset: 0x1829080 VA: 0x18182AA80
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	// RVA: 0x182AAB0 Offset: 0x18290B0 VA: 0x18182AAB0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	// RVA: 0x182AAE0 Offset: 0x18290E0 VA: 0x18182AAE0
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B300 Offset: 0x8A700 VA: 0x18008B300
	// RVA: 0x182AB50 Offset: 0x1829150 VA: 0x18182AB50
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B400 Offset: 0x8A800 VA: 0x18008B400
	// RVA: 0x182A8E0 Offset: 0x1828EE0 VA: 0x18182A8E0
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A800 Offset: 0x1828E00 VA: 0x18182A800
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x182A800 Offset: 0x1828E00 VA: 0x18182A800
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A7C0 Offset: 0x1828DC0 VA: 0x18182A7C0
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x182A9D0 Offset: 0x1828FD0 VA: 0x18182A9D0
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C7E0 Offset: 0x8BBE0 VA: 0x18008C7E0
	// RVA: 0x182A530 Offset: 0x1828B30 VA: 0x18182A530
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C9E0 Offset: 0x8BDE0 VA: 0x18008C9E0
	// RVA: 0x182A680 Offset: 0x1828C80 VA: 0x18182A680
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182A750 Offset: 0x1828D50 VA: 0x18182A750
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x182A5C0 Offset: 0x1828BC0 VA: 0x18182A5C0
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CAF0 Offset: 0x8BEF0 VA: 0x18008CAF0
	// RVA: 0x182A570 Offset: 0x1828B70 VA: 0x18182A570
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x182AB90 Offset: 0x1829190 VA: 0x18182AB90
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x182AB10 Offset: 0x1829110 VA: 0x18182AB10
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x182A880 Offset: 0x1828E80 VA: 0x18182A880
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x182A6E0 Offset: 0x1828CE0 VA: 0x18182A6E0
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

