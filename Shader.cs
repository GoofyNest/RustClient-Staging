public sealed class Shader : Object // TypeDefIndex: 3405
{	// Properties
	[NativePropertyAttribute] // RVA: 0x936F0 Offset: 0x92AF0 VA: 0x1800936F0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	// RVA: 0x19B52E0 Offset: 0x19B38E0 VA: 0x1819B52E0
	public static Shader Find(string name) { }

	// RVA: 0x19B5FD0 Offset: 0x19B45D0 VA: 0x1819B5FD0
	public static int get_globalMaximumLOD() { }

	// RVA: 0x19B6080 Offset: 0x19B4680 VA: 0x1819B6080
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	// RVA: 0x19B6000 Offset: 0x19B4600 VA: 0x1819B6000
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91410 Offset: 0x90810 VA: 0x180091410
	// RVA: 0x19B51D0 Offset: 0x19B37D0 VA: 0x1819B51D0
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91480 Offset: 0x90880 VA: 0x180091480
	// RVA: 0x19B5190 Offset: 0x19B3790 VA: 0x1819B5190
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91580 Offset: 0x90980 VA: 0x180091580
	// RVA: 0x19B56B0 Offset: 0x19B3CB0 VA: 0x1819B56B0
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x916C0 Offset: 0x90AC0 VA: 0x1800916C0
	// RVA: 0x19B5F30 Offset: 0x19B4530 VA: 0x1819B5F30
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x917E0 Offset: 0x90BE0 VA: 0x1800917E0
	// RVA: 0x19B5620 Offset: 0x19B3C20 VA: 0x1819B5620
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91910 Offset: 0x90D10 VA: 0x180091910
	// RVA: 0x19B56F0 Offset: 0x19B3CF0 VA: 0x1819B56F0
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x919F0 Offset: 0x90DF0 VA: 0x1800919F0
	// RVA: 0x19B6040 Offset: 0x19B4640 VA: 0x1819B6040
	public int get_passCount() { }

	// RVA: 0x19B5210 Offset: 0x19B3810 VA: 0x1819B5210
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91B70 Offset: 0x90F70 VA: 0x180091B70
	// RVA: 0x19B5660 Offset: 0x19B3C60 VA: 0x1819B5660
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92F30 Offset: 0x92330 VA: 0x180092F30
	// RVA: 0x19B5820 Offset: 0x19B3E20 VA: 0x1819B5820
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93050 Offset: 0x92450 VA: 0x180093050
	// RVA: 0x19B5E30 Offset: 0x19B4430 VA: 0x1819B5E30
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	// RVA: 0x19B5990 Offset: 0x19B3F90 VA: 0x1819B5990
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	// RVA: 0x19B5AC0 Offset: 0x19B40C0 VA: 0x1819B5AC0
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93240 Offset: 0x92640 VA: 0x180093240
	// RVA: 0x19B5320 Offset: 0x19B3920 VA: 0x1819B5320
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x933D0 Offset: 0x927D0 VA: 0x1800933D0
	// RVA: 0x19B5B70 Offset: 0x19B4170 VA: 0x1819B5B70
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x19B5CD0 Offset: 0x19B42D0 VA: 0x1819B5CD0
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x19B5870 Offset: 0x19B3E70 VA: 0x1819B5870
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19B5820 Offset: 0x19B3E20 VA: 0x1819B5820
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x19B58E0 Offset: 0x19B3EE0 VA: 0x1819B58E0
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x19B5E70 Offset: 0x19B4470 VA: 0x1819B5E70
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19B5EF0 Offset: 0x19B44F0 VA: 0x1819B5EF0
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x19B5790 Offset: 0x19B3D90 VA: 0x1819B5790
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19B5730 Offset: 0x19B3D30 VA: 0x1819B5730
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x19B59D0 Offset: 0x19B3FD0 VA: 0x1819B59D0
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19B5A60 Offset: 0x19B4060 VA: 0x1819B5A60
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x19B5B00 Offset: 0x19B4100 VA: 0x1819B5B00
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x19B5AC0 Offset: 0x19B40C0 VA: 0x1819B5AC0
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x19B5BC0 Offset: 0x19B41C0 VA: 0x1819B5BC0
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x19B5360 Offset: 0x19B3960 VA: 0x1819B5360
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x19B5F70 Offset: 0x19B4570 VA: 0x1819B5F70
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x93450 Offset: 0x92850 VA: 0x180093450
	// RVA: 0x19B5400 Offset: 0x19B3A00 VA: 0x1819B5400
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x935F0 Offset: 0x929F0 VA: 0x1800935F0
	// RVA: 0x19B5510 Offset: 0x19B3B10 VA: 0x1819B5510
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	// RVA: 0x19B50F0 Offset: 0x19B36F0 VA: 0x1819B50F0
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x19B53C0 Offset: 0x19B39C0 VA: 0x1819B53C0
	public int GetPropertyCount() { }

	// RVA: 0x19B5440 Offset: 0x19B3A40 VA: 0x1819B5440
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x19B5550 Offset: 0x19B3B50 VA: 0x1819B5550
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x19B5DF0 Offset: 0x19B43F0 VA: 0x1819B5DF0
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x19B5950 Offset: 0x19B3F50 VA: 0x1819B5950
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

