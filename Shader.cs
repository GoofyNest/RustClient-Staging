public sealed class Shader : Object // TypeDefIndex: 3405
{	[NativePropertyAttribute] // RVA: 0x936B0 Offset: 0x92AB0 VA: 0x1800936B0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }


	[FreeFunctionAttribute] // RVA: 0x91490 Offset: 0x90890 VA: 0x180091490
	public static Shader Find(string name) { }

	public static int get_globalMaximumLOD() { }

	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x91530 Offset: 0x90930 VA: 0x180091530
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x915A0 Offset: 0x909A0 VA: 0x1800915A0
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91610 Offset: 0x90A10 VA: 0x180091610
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91780 Offset: 0x90B80 VA: 0x180091780
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91860 Offset: 0x90C60 VA: 0x180091860
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91940 Offset: 0x90D40 VA: 0x180091940
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91A60 Offset: 0x90E60 VA: 0x180091A60
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91B00 Offset: 0x90F00 VA: 0x180091B00
	public int get_passCount() { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91BF0 Offset: 0x90FF0 VA: 0x180091BF0
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92F50 Offset: 0x92350 VA: 0x180092F50
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93070 Offset: 0x92470 VA: 0x180093070
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x930D0 Offset: 0x924D0 VA: 0x1800930D0
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93130 Offset: 0x92530 VA: 0x180093130
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93260 Offset: 0x92660 VA: 0x180093260
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x933F0 Offset: 0x927F0 VA: 0x1800933F0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	public static float GetGlobalFloat(string name) { }

	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x93470 Offset: 0x92870 VA: 0x180093470
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x935E0 Offset: 0x929E0 VA: 0x1800935E0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public int GetPropertyCount() { }

	public string GetPropertyName(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

