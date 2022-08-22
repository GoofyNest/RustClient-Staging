public sealed class Shader : Object // TypeDefIndex: 3405
{	[NativePropertyAttribute] // RVA: 0x936F0 Offset: 0x92AF0 VA: 0x1800936F0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }


	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	public static Shader Find(string name) { }

	public static int get_globalMaximumLOD() { }

	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91410 Offset: 0x90810 VA: 0x180091410
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91480 Offset: 0x90880 VA: 0x180091480
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91580 Offset: 0x90980 VA: 0x180091580
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x916C0 Offset: 0x90AC0 VA: 0x1800916C0
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x917E0 Offset: 0x90BE0 VA: 0x1800917E0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91910 Offset: 0x90D10 VA: 0x180091910
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x919F0 Offset: 0x90DF0 VA: 0x1800919F0
	public int get_passCount() { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91B70 Offset: 0x90F70 VA: 0x180091B70
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92F30 Offset: 0x92330 VA: 0x180092F30
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93050 Offset: 0x92450 VA: 0x180093050
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93240 Offset: 0x92640 VA: 0x180093240
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x933D0 Offset: 0x927D0 VA: 0x1800933D0
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

	[FreeFunctionAttribute] // RVA: 0x93450 Offset: 0x92850 VA: 0x180093450
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x935F0 Offset: 0x929F0 VA: 0x1800935F0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public int GetPropertyCount() { }

	public string GetPropertyName(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

