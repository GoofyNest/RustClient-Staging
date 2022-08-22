public sealed class Shader : Object // TypeDefIndex: 3405
{	// Properties
	[NativePropertyAttribute] // RVA: 0x936F0 Offset: 0x92AF0 VA: 0x1800936F0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	// RVA: 0x19A29A0 Offset: 0x19A0FA0 VA: 0x1819A29A0
	public static Shader Find(string name) { }

	// RVA: 0x19A3690 Offset: 0x19A1C90 VA: 0x1819A3690
	public static int get_globalMaximumLOD() { }

	// RVA: 0x19A3740 Offset: 0x19A1D40 VA: 0x1819A3740
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	// RVA: 0x19A36C0 Offset: 0x19A1CC0 VA: 0x1819A36C0
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91410 Offset: 0x90810 VA: 0x180091410
	// RVA: 0x19A2890 Offset: 0x19A0E90 VA: 0x1819A2890
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91480 Offset: 0x90880 VA: 0x180091480
	// RVA: 0x19A2850 Offset: 0x19A0E50 VA: 0x1819A2850
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91580 Offset: 0x90980 VA: 0x180091580
	// RVA: 0x19A2D70 Offset: 0x19A1370 VA: 0x1819A2D70
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x916C0 Offset: 0x90AC0 VA: 0x1800916C0
	// RVA: 0x19A35F0 Offset: 0x19A1BF0 VA: 0x1819A35F0
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x917E0 Offset: 0x90BE0 VA: 0x1800917E0
	// RVA: 0x19A2CE0 Offset: 0x19A12E0 VA: 0x1819A2CE0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91910 Offset: 0x90D10 VA: 0x180091910
	// RVA: 0x19A2DB0 Offset: 0x19A13B0 VA: 0x1819A2DB0
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x919F0 Offset: 0x90DF0 VA: 0x1800919F0
	// RVA: 0x19A3700 Offset: 0x19A1D00 VA: 0x1819A3700
	public int get_passCount() { }

	// RVA: 0x19A28D0 Offset: 0x19A0ED0 VA: 0x1819A28D0
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91B70 Offset: 0x90F70 VA: 0x180091B70
	// RVA: 0x19A2D20 Offset: 0x19A1320 VA: 0x1819A2D20
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92F30 Offset: 0x92330 VA: 0x180092F30
	// RVA: 0x19A2EE0 Offset: 0x19A14E0 VA: 0x1819A2EE0
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x93050 Offset: 0x92450 VA: 0x180093050
	// RVA: 0x19A34F0 Offset: 0x19A1AF0 VA: 0x1819A34F0
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	// RVA: 0x19A3050 Offset: 0x19A1650 VA: 0x1819A3050
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	// RVA: 0x19A3180 Offset: 0x19A1780 VA: 0x1819A3180
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93240 Offset: 0x92640 VA: 0x180093240
	// RVA: 0x19A29E0 Offset: 0x19A0FE0 VA: 0x1819A29E0
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x933D0 Offset: 0x927D0 VA: 0x1800933D0
	// RVA: 0x19A3230 Offset: 0x19A1830 VA: 0x1819A3230
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x19A3390 Offset: 0x19A1990 VA: 0x1819A3390
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x19A2F30 Offset: 0x19A1530 VA: 0x1819A2F30
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19A2EE0 Offset: 0x19A14E0 VA: 0x1819A2EE0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x19A2FA0 Offset: 0x19A15A0 VA: 0x1819A2FA0
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x19A3530 Offset: 0x19A1B30 VA: 0x1819A3530
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19A35B0 Offset: 0x19A1BB0 VA: 0x1819A35B0
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x19A2E50 Offset: 0x19A1450 VA: 0x1819A2E50
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19A2DF0 Offset: 0x19A13F0 VA: 0x1819A2DF0
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x19A3090 Offset: 0x19A1690 VA: 0x1819A3090
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19A3120 Offset: 0x19A1720 VA: 0x1819A3120
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x19A31C0 Offset: 0x19A17C0 VA: 0x1819A31C0
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x19A3180 Offset: 0x19A1780 VA: 0x1819A3180
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x19A3280 Offset: 0x19A1880 VA: 0x1819A3280
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x19A2A20 Offset: 0x19A1020 VA: 0x1819A2A20
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x19A3630 Offset: 0x19A1C30 VA: 0x1819A3630
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x93450 Offset: 0x92850 VA: 0x180093450
	// RVA: 0x19A2AC0 Offset: 0x19A10C0 VA: 0x1819A2AC0
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x935F0 Offset: 0x929F0 VA: 0x1800935F0
	// RVA: 0x19A2BD0 Offset: 0x19A11D0 VA: 0x1819A2BD0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	// RVA: 0x19A27B0 Offset: 0x19A0DB0 VA: 0x1819A27B0
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x19A2A80 Offset: 0x19A1080 VA: 0x1819A2A80
	public int GetPropertyCount() { }

	// RVA: 0x19A2B00 Offset: 0x19A1100 VA: 0x1819A2B00
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x19A2C10 Offset: 0x19A1210 VA: 0x1819A2C10
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x19A34B0 Offset: 0x19A1AB0 VA: 0x1819A34B0
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x19A3010 Offset: 0x19A1610 VA: 0x1819A3010
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

