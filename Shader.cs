public sealed class Shader : Object // TypeDefIndex: 3405
{	// Properties
	[NativePropertyAttribute] // RVA: 0x93670 Offset: 0x92A70 VA: 0x180093670
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x912C0 Offset: 0x906C0 VA: 0x1800912C0
	// RVA: 0x19B5320 Offset: 0x19B3920 VA: 0x1819B5320
	public static Shader Find(string name) { }

	// RVA: 0x19B6010 Offset: 0x19B4610 VA: 0x1819B6010
	public static int get_globalMaximumLOD() { }

	// RVA: 0x19B60C0 Offset: 0x19B46C0 VA: 0x1819B60C0
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x91360 Offset: 0x90760 VA: 0x180091360
	// RVA: 0x19B6040 Offset: 0x19B4640 VA: 0x1819B6040
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x913D0 Offset: 0x907D0 VA: 0x1800913D0
	// RVA: 0x19B5210 Offset: 0x19B3810 VA: 0x1819B5210
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	// RVA: 0x19B51D0 Offset: 0x19B37D0 VA: 0x1819B51D0
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91540 Offset: 0x90940 VA: 0x180091540
	// RVA: 0x19B56F0 Offset: 0x19B3CF0 VA: 0x1819B56F0
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91680 Offset: 0x90A80 VA: 0x180091680
	// RVA: 0x19B5F70 Offset: 0x19B4570 VA: 0x1819B5F70
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x917A0 Offset: 0x90BA0 VA: 0x1800917A0
	// RVA: 0x19B5660 Offset: 0x19B3C60 VA: 0x1819B5660
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x918D0 Offset: 0x90CD0 VA: 0x1800918D0
	// RVA: 0x19B5730 Offset: 0x19B3D30 VA: 0x1819B5730
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x919B0 Offset: 0x90DB0 VA: 0x1800919B0
	// RVA: 0x19B6080 Offset: 0x19B4680 VA: 0x1819B6080
	public int get_passCount() { }

	// RVA: 0x19B5250 Offset: 0x19B3850 VA: 0x1819B5250
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91B20 Offset: 0x90F20 VA: 0x180091B20
	// RVA: 0x19B56A0 Offset: 0x19B3CA0 VA: 0x1819B56A0
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92EB0 Offset: 0x922B0 VA: 0x180092EB0
	// RVA: 0x19B5860 Offset: 0x19B3E60 VA: 0x1819B5860
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x92FA0 Offset: 0x923A0 VA: 0x180092FA0
	// RVA: 0x19B5E70 Offset: 0x19B4470 VA: 0x1819B5E70
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93030 Offset: 0x92430 VA: 0x180093030
	// RVA: 0x19B59D0 Offset: 0x19B3FD0 VA: 0x1819B59D0
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93090 Offset: 0x92490 VA: 0x180093090
	// RVA: 0x19B5B00 Offset: 0x19B4100 VA: 0x1819B5B00
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93190 Offset: 0x92590 VA: 0x180093190
	// RVA: 0x19B5360 Offset: 0x19B3960 VA: 0x1819B5360
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x93320 Offset: 0x92720 VA: 0x180093320
	// RVA: 0x19B5BB0 Offset: 0x19B41B0 VA: 0x1819B5BB0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x19B5D10 Offset: 0x19B4310 VA: 0x1819B5D10
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x19B58B0 Offset: 0x19B3EB0 VA: 0x1819B58B0
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19B5860 Offset: 0x19B3E60 VA: 0x1819B5860
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x19B5920 Offset: 0x19B3F20 VA: 0x1819B5920
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x19B5EB0 Offset: 0x19B44B0 VA: 0x1819B5EB0
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19B5F30 Offset: 0x19B4530 VA: 0x1819B5F30
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x19B57D0 Offset: 0x19B3DD0 VA: 0x1819B57D0
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19B5770 Offset: 0x19B3D70 VA: 0x1819B5770
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x19B5A10 Offset: 0x19B4010 VA: 0x1819B5A10
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19B5AA0 Offset: 0x19B40A0 VA: 0x1819B5AA0
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x19B5B40 Offset: 0x19B4140 VA: 0x1819B5B40
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x19B5B00 Offset: 0x19B4100 VA: 0x1819B5B00
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x19B5C00 Offset: 0x19B4200 VA: 0x1819B5C00
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x19B53A0 Offset: 0x19B39A0 VA: 0x1819B53A0
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x19B5FB0 Offset: 0x19B45B0 VA: 0x1819B5FB0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x93400 Offset: 0x92800 VA: 0x180093400
	// RVA: 0x19B5440 Offset: 0x19B3A40 VA: 0x1819B5440
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x93540 Offset: 0x92940 VA: 0x180093540
	// RVA: 0x19B5550 Offset: 0x19B3B50 VA: 0x1819B5550
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	// RVA: 0x19B5130 Offset: 0x19B3730 VA: 0x1819B5130
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x19B5400 Offset: 0x19B3A00 VA: 0x1819B5400
	public int GetPropertyCount() { }

	// RVA: 0x19B5480 Offset: 0x19B3A80 VA: 0x1819B5480
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x19B5590 Offset: 0x19B3B90 VA: 0x1819B5590
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x19B5E30 Offset: 0x19B4430 VA: 0x1819B5E30
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x19B5990 Offset: 0x19B3F90 VA: 0x1819B5990
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

