public sealed class Shader : Object // TypeDefIndex: 3405
{	// Properties
	[NativePropertyAttribute] // RVA: 0x936F0 Offset: 0x92AF0 VA: 0x1800936F0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	// RVA: 0x19B55A0 Offset: 0x19B3BA0 VA: 0x1819B55A0
	public static Shader Find(string name) { }

	// RVA: 0x19B6290 Offset: 0x19B4890 VA: 0x1819B6290
	public static int get_globalMaximumLOD() { }

	// RVA: 0x19B6340 Offset: 0x19B4940 VA: 0x1819B6340
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	// RVA: 0x19B62C0 Offset: 0x19B48C0 VA: 0x1819B62C0
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91410 Offset: 0x90810 VA: 0x180091410
	// RVA: 0x19B5490 Offset: 0x19B3A90 VA: 0x1819B5490
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91480 Offset: 0x90880 VA: 0x180091480
	// RVA: 0x19B5450 Offset: 0x19B3A50 VA: 0x1819B5450
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91580 Offset: 0x90980 VA: 0x180091580
	// RVA: 0x19B5970 Offset: 0x19B3F70 VA: 0x1819B5970
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x916C0 Offset: 0x90AC0 VA: 0x1800916C0
	// RVA: 0x19B61F0 Offset: 0x19B47F0 VA: 0x1819B61F0
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x917E0 Offset: 0x90BE0 VA: 0x1800917E0
	// RVA: 0x19B58E0 Offset: 0x19B3EE0 VA: 0x1819B58E0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91910 Offset: 0x90D10 VA: 0x180091910
	// RVA: 0x19B59B0 Offset: 0x19B3FB0 VA: 0x1819B59B0
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x919F0 Offset: 0x90DF0 VA: 0x1800919F0
	// RVA: 0x19B6300 Offset: 0x19B4900 VA: 0x1819B6300
	public int get_passCount() { }

	// RVA: 0x19B54D0 Offset: 0x19B3AD0 VA: 0x1819B54D0
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91B70 Offset: 0x90F70 VA: 0x180091B70
	// RVA: 0x19B5920 Offset: 0x19B3F20 VA: 0x1819B5920
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92F30 Offset: 0x92330 VA: 0x180092F30
	// RVA: 0x19B5AE0 Offset: 0x19B40E0 VA: 0x1819B5AE0
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93050 Offset: 0x92450 VA: 0x180093050
	// RVA: 0x19B60F0 Offset: 0x19B46F0 VA: 0x1819B60F0
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	// RVA: 0x19B5C50 Offset: 0x19B4250 VA: 0x1819B5C50
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	// RVA: 0x19B5D80 Offset: 0x19B4380 VA: 0x1819B5D80
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93240 Offset: 0x92640 VA: 0x180093240
	// RVA: 0x19B55E0 Offset: 0x19B3BE0 VA: 0x1819B55E0
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x933D0 Offset: 0x927D0 VA: 0x1800933D0
	// RVA: 0x19B5E30 Offset: 0x19B4430 VA: 0x1819B5E30
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x19B5F90 Offset: 0x19B4590 VA: 0x1819B5F90
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x19B5B30 Offset: 0x19B4130 VA: 0x1819B5B30
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19B5AE0 Offset: 0x19B40E0 VA: 0x1819B5AE0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x19B5BA0 Offset: 0x19B41A0 VA: 0x1819B5BA0
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x19B6130 Offset: 0x19B4730 VA: 0x1819B6130
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19B61B0 Offset: 0x19B47B0 VA: 0x1819B61B0
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x19B5A50 Offset: 0x19B4050 VA: 0x1819B5A50
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19B59F0 Offset: 0x19B3FF0 VA: 0x1819B59F0
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x19B5C90 Offset: 0x19B4290 VA: 0x1819B5C90
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19B5D20 Offset: 0x19B4320 VA: 0x1819B5D20
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x19B5DC0 Offset: 0x19B43C0 VA: 0x1819B5DC0
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x19B5D80 Offset: 0x19B4380 VA: 0x1819B5D80
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x19B5E80 Offset: 0x19B4480 VA: 0x1819B5E80
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x19B5620 Offset: 0x19B3C20 VA: 0x1819B5620
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x19B6230 Offset: 0x19B4830 VA: 0x1819B6230
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x93450 Offset: 0x92850 VA: 0x180093450
	// RVA: 0x19B56C0 Offset: 0x19B3CC0 VA: 0x1819B56C0
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x935F0 Offset: 0x929F0 VA: 0x1800935F0
	// RVA: 0x19B57D0 Offset: 0x19B3DD0 VA: 0x1819B57D0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	// RVA: 0x19B53B0 Offset: 0x19B39B0 VA: 0x1819B53B0
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x19B5680 Offset: 0x19B3C80 VA: 0x1819B5680
	public int GetPropertyCount() { }

	// RVA: 0x19B5700 Offset: 0x19B3D00 VA: 0x1819B5700
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x19B5810 Offset: 0x19B3E10 VA: 0x1819B5810
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x19B60B0 Offset: 0x19B46B0 VA: 0x1819B60B0
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x19B5C10 Offset: 0x19B4210 VA: 0x1819B5C10
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

