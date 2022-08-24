public sealed class Shader : Object // TypeDefIndex: 3405
{	[NativePropertyAttribute] // RVA: 0x93800 Offset: 0x92C00 VA: 0x180093800
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }


	[FreeFunctionAttribute] // RVA: 0x91410 Offset: 0x90810 VA: 0x180091410
	public static Shader Find(string name) { }

	public static int get_globalMaximumLOD() { }

	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x914A0 Offset: 0x908A0 VA: 0x1800914A0
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91510 Offset: 0x90910 VA: 0x180091510
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91580 Offset: 0x90980 VA: 0x180091580
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91680 Offset: 0x90A80 VA: 0x180091680
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91770 Offset: 0x90B70 VA: 0x180091770
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91890 Offset: 0x90C90 VA: 0x180091890
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91A10 Offset: 0x90E10 VA: 0x180091A10
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91AF0 Offset: 0x90EF0 VA: 0x180091AF0
	public int get_passCount() { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91C20 Offset: 0x91020 VA: 0x180091C20
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92FC0 Offset: 0x923C0 VA: 0x180092FC0
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93160 Offset: 0x92560 VA: 0x180093160
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x931F0 Offset: 0x925F0 VA: 0x1800931F0
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93250 Offset: 0x92650 VA: 0x180093250
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93380 Offset: 0x92780 VA: 0x180093380
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x93510 Offset: 0x92910 VA: 0x180093510
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

	[FreeFunctionAttribute] // RVA: 0x93590 Offset: 0x92990 VA: 0x180093590
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x93700 Offset: 0x92B00 VA: 0x180093700
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public int GetPropertyCount() { }

	public string GetPropertyName(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

