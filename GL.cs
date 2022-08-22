public sealed class GL // TypeDefIndex: 3390
{	public static bool sRGBWrite { get; set; }


	[NativeNameAttribute] // RVA: 0x8ABD0 Offset: 0x89FD0 VA: 0x18008ABD0
	public static void Vertex3(float x, float y, float z) { }

	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8ACE0 Offset: 0x8A0E0 VA: 0x18008ACE0
	public static void TexCoord3(float x, float y, float z) { }

	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ADB0 Offset: 0x8A1B0 VA: 0x18008ADB0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE20 Offset: 0x8A220 VA: 0x18008AE20
	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void Color(Color c) { }

	public static bool get_sRGBWrite() { }

	public static void set_sRGBWrite(bool value) { }

	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B300 Offset: 0x8A700 VA: 0x18008B300
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B400 Offset: 0x8A800 VA: 0x18008B400
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C7E0 Offset: 0x8BBE0 VA: 0x18008C7E0
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C9E0 Offset: 0x8BDE0 VA: 0x18008C9E0
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CAF0 Offset: 0x8BEF0 VA: 0x18008CAF0
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

