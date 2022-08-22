public sealed class GL // TypeDefIndex: 3390
{	// Properties
	public static bool sRGBWrite { get; set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8ABD0 Offset: 0x89FD0 VA: 0x18008ABD0
	// RVA: 0x1818230 Offset: 0x1816830 VA: 0x181818230
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x1818290 Offset: 0x1816890 VA: 0x181818290
	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8ACE0 Offset: 0x8A0E0 VA: 0x18008ACE0
	// RVA: 0x18181D0 Offset: 0x18167D0 VA: 0x1818181D0
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x1818180 Offset: 0x1816780 VA: 0x181818180
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ADB0 Offset: 0x8A1B0 VA: 0x18008ADB0
	// RVA: 0x18180B0 Offset: 0x18166B0 VA: 0x1818180B0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x1818050 Offset: 0x1816650 VA: 0x181818050
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AE20 Offset: 0x8A220 VA: 0x18008AE20
	// RVA: 0x1817D90 Offset: 0x1816390 VA: 0x181817D90
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x1817A60 Offset: 0x1816060 VA: 0x181817A60
	public static void Color(Color c) { }

	// RVA: 0x18182F0 Offset: 0x18168F0 VA: 0x1818182F0
	public static bool get_sRGBWrite() { }

	// RVA: 0x1818320 Offset: 0x1816920 VA: 0x181818320
	public static void set_sRGBWrite(bool value) { }

	// RVA: 0x1817AF0 Offset: 0x18160F0 VA: 0x181817AF0
	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	// RVA: 0x1818010 Offset: 0x1816610 VA: 0x181818010
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	// RVA: 0x1818150 Offset: 0x1816750 VA: 0x181818150
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	// RVA: 0x1818120 Offset: 0x1816720 VA: 0x181818120
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	// RVA: 0x1817EC0 Offset: 0x18164C0 VA: 0x181817EC0
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	// RVA: 0x1817EF0 Offset: 0x18164F0 VA: 0x181817EF0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	// RVA: 0x1817F20 Offset: 0x1816520 VA: 0x181817F20
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B300 Offset: 0x8A700 VA: 0x18008B300
	// RVA: 0x1817F90 Offset: 0x1816590 VA: 0x181817F90
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B400 Offset: 0x8A800 VA: 0x18008B400
	// RVA: 0x1817D20 Offset: 0x1816320 VA: 0x181817D20
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1817C40 Offset: 0x1816240 VA: 0x181817C40
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x1817C40 Offset: 0x1816240 VA: 0x181817C40
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1817C00 Offset: 0x1816200 VA: 0x181817C00
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x1817E10 Offset: 0x1816410 VA: 0x181817E10
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C7E0 Offset: 0x8BBE0 VA: 0x18008C7E0
	// RVA: 0x1817970 Offset: 0x1815F70 VA: 0x181817970
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C9E0 Offset: 0x8BDE0 VA: 0x18008C9E0
	// RVA: 0x1817AC0 Offset: 0x18160C0 VA: 0x181817AC0
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1817B90 Offset: 0x1816190 VA: 0x181817B90
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x1817A00 Offset: 0x1816000 VA: 0x181817A00
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CAF0 Offset: 0x8BEF0 VA: 0x18008CAF0
	// RVA: 0x18179B0 Offset: 0x1815FB0 VA: 0x1818179B0
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x1817FD0 Offset: 0x18165D0 VA: 0x181817FD0
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1817F50 Offset: 0x1816550 VA: 0x181817F50
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x1817CC0 Offset: 0x18162C0 VA: 0x181817CC0
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x1817B20 Offset: 0x1816120 VA: 0x181817B20
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

