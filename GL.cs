public sealed class GL // TypeDefIndex: 3390
{	public static bool sRGBWrite { get; set; }


	[NativeNameAttribute] // RVA: 0x8AD20 Offset: 0x8A120 VA: 0x18008AD20
	public static void Vertex3(float x, float y, float z) { }

	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8ADD0 Offset: 0x8A1D0 VA: 0x18008ADD0
	public static void TexCoord3(float x, float y, float z) { }

	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE70 Offset: 0x8A270 VA: 0x18008AE70
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AF40 Offset: 0x8A340 VA: 0x18008AF40
	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void Color(Color c) { }

	public static bool get_sRGBWrite() { }

	public static void set_sRGBWrite(bool value) { }

	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AFE0 Offset: 0x8A3E0 VA: 0x18008AFE0
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8B080 Offset: 0x8A480 VA: 0x18008B080
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B2C0 Offset: 0x8A6C0 VA: 0x18008B2C0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B330 Offset: 0x8A730 VA: 0x18008B330
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B450 Offset: 0x8A850 VA: 0x18008B450
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B550 Offset: 0x8A950 VA: 0x18008B550
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C8E0 Offset: 0x8BCE0 VA: 0x18008C8E0
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8CAE0 Offset: 0x8BEE0 VA: 0x18008CAE0
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CC40 Offset: 0x8C040 VA: 0x18008CC40
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

