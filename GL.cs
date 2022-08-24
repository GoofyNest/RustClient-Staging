public sealed class GL // TypeDefIndex: 3390
{	public static bool sRGBWrite { get; set; }


	[NativeNameAttribute] // RVA: 0x8ACE0 Offset: 0x8A0E0 VA: 0x18008ACE0
	public static void Vertex3(float x, float y, float z) { }

	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8AD90 Offset: 0x8A190 VA: 0x18008AD90
	public static void TexCoord3(float x, float y, float z) { }

	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE30 Offset: 0x8A230 VA: 0x18008AE30
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void Color(Color c) { }

	public static bool get_sRGBWrite() { }

	public static void set_sRGBWrite(bool value) { }

	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AF80 Offset: 0x8A380 VA: 0x18008AF80
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AFF0 Offset: 0x8A3F0 VA: 0x18008AFF0
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B060 Offset: 0x8A460 VA: 0x18008B060
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B190 Offset: 0x8A590 VA: 0x18008B190
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B200 Offset: 0x8A600 VA: 0x18008B200
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B320 Offset: 0x8A720 VA: 0x18008B320
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B420 Offset: 0x8A820 VA: 0x18008B420
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C7B0 Offset: 0x8BBB0 VA: 0x18008C7B0
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C9B0 Offset: 0x8BDB0 VA: 0x18008C9B0
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CAC0 Offset: 0x8BEC0 VA: 0x18008CAC0
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

