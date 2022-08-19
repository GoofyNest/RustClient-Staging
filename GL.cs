public sealed class GL // TypeDefIndex: 3390
{	// Properties
	public static bool sRGBWrite { get; set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8AB60 Offset: 0x89F60 VA: 0x18008AB60
	// RVA: 0x182AB70 Offset: 0x1829170 VA: 0x18182AB70
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x182ABD0 Offset: 0x18291D0 VA: 0x18182ABD0
	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	// RVA: 0x182AB10 Offset: 0x1829110 VA: 0x18182AB10
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x182AAC0 Offset: 0x18290C0 VA: 0x18182AAC0
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AD40 Offset: 0x8A140 VA: 0x18008AD40
	// RVA: 0x182A9F0 Offset: 0x1828FF0 VA: 0x18182A9F0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x182A990 Offset: 0x1828F90 VA: 0x18182A990
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ADE0 Offset: 0x8A1E0 VA: 0x18008ADE0
	// RVA: 0x182A6D0 Offset: 0x1828CD0 VA: 0x18182A6D0
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x182A3A0 Offset: 0x18289A0 VA: 0x18182A3A0
	public static void Color(Color c) { }

	// RVA: 0x182AC30 Offset: 0x1829230 VA: 0x18182AC30
	public static bool get_sRGBWrite() { }

	// RVA: 0x182AC60 Offset: 0x1829260 VA: 0x18182AC60
	public static void set_sRGBWrite(bool value) { }

	// RVA: 0x182A430 Offset: 0x1828A30 VA: 0x18182A430
	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	// RVA: 0x182A950 Offset: 0x1828F50 VA: 0x18182A950
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AF40 Offset: 0x8A340 VA: 0x18008AF40
	// RVA: 0x182AA90 Offset: 0x1829090 VA: 0x18182AA90
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	// RVA: 0x182AA60 Offset: 0x1829060 VA: 0x18182AA60
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	// RVA: 0x182A800 Offset: 0x1828E00 VA: 0x18182A800
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	// RVA: 0x182A830 Offset: 0x1828E30 VA: 0x18182A830
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B170 Offset: 0x8A570 VA: 0x18008B170
	// RVA: 0x182A860 Offset: 0x1828E60 VA: 0x18182A860
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B220 Offset: 0x8A620 VA: 0x18008B220
	// RVA: 0x182A8D0 Offset: 0x1828ED0 VA: 0x18182A8D0
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B390 Offset: 0x8A790 VA: 0x18008B390
	// RVA: 0x182A660 Offset: 0x1828C60 VA: 0x18182A660
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x182A580 Offset: 0x1828B80 VA: 0x18182A580
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x182A580 Offset: 0x1828B80 VA: 0x18182A580
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x182A540 Offset: 0x1828B40 VA: 0x18182A540
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x182A750 Offset: 0x1828D50 VA: 0x18182A750
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C740 Offset: 0x8BB40 VA: 0x18008C740
	// RVA: 0x182A2B0 Offset: 0x18288B0 VA: 0x18182A2B0
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C940 Offset: 0x8BD40 VA: 0x18008C940
	// RVA: 0x182A400 Offset: 0x1828A00 VA: 0x18182A400
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x182A4D0 Offset: 0x1828AD0 VA: 0x18182A4D0
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x182A340 Offset: 0x1828940 VA: 0x18182A340
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8CA80 Offset: 0x8BE80 VA: 0x18008CA80
	// RVA: 0x182A2F0 Offset: 0x18288F0 VA: 0x18182A2F0
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x182A910 Offset: 0x1828F10 VA: 0x18182A910
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x182A890 Offset: 0x1828E90 VA: 0x18182A890
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x182A600 Offset: 0x1828C00 VA: 0x18182A600
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x182A460 Offset: 0x1828A60 VA: 0x18182A460
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

