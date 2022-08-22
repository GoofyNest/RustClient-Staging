internal static class Utils // TypeDefIndex: 1002
{	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x13CE6

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x17C79C0 Offset: 0x17C5FC0 VA: 0x1817C79C0
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x17C7650 Offset: 0x17C5C50 VA: 0x1817C7650
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x17C7400 Offset: 0x17C5A00 VA: 0x1817C7400
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x17C7280 Offset: 0x17C5880 VA: 0x1817C7280
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17C6D60 Offset: 0x17C5360 VA: 0x1817C6D60
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x17C6DC0 Offset: 0x17C53C0 VA: 0x1817C6DC0
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x17C7560 Offset: 0x17C5B60 VA: 0x1817C7560
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x17C6F60 Offset: 0x17C5560 VA: 0x1817C6F60
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C7120 Offset: 0x17C5720 VA: 0x1817C7120
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C6F00 Offset: 0x17C5500 VA: 0x1817C6F00
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C6FC0 Offset: 0x17C55C0 VA: 0x1817C6FC0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C76C0 Offset: 0x17C5CC0 VA: 0x1817C76C0
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x17C7750 Offset: 0x17C5D50 VA: 0x1817C7750
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool _ProduceLegacyHmacValues() { }

}

public static class Utils // TypeDefIndex: 11553
{	// Fields
	private static Utils.FloatPackingPrecision ms_FloatPackingPrecision; // 0x2B103D0
	private const int kFloatPackingHighMinShaderLevel = 35;

	// Methods

	// RVA: 0xACA6B0 Offset: 0xAC8CB0 VA: 0x180ACA6B0
	public static string GetPath(Transform current) { }

	// RVA: -1 Offset: -1
	public static T NewWithComponent<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD90 Offset: 0x15B9390 VA: 0x1815BAD90
	|-Utils.NewWithComponent<object>
	|-Utils.NewWithComponent<BeamGeometry>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC60 Offset: 0x15B9260 VA: 0x1815BAC60
	|-Utils.GetOrAddComponent<object>
	|-Utils.GetOrAddComponent<MeshCollider>
	|-Utils.GetOrAddComponent<MeshFilter>
	|-Utils.GetOrAddComponent<MeshRenderer>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(MonoBehaviour self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD10 Offset: 0x15B9310 VA: 0x1815BAD10
	|-Utils.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAD10 Offset: 0xAC9310 VA: 0x180ACAD10
	public static bool HasFlag(Enum mask, Enum flags) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB470 Offset: 0xAC9A70 VA: 0x180ACB470
	public static Vector2 xy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB4A0 Offset: 0xAC9AA0 VA: 0x180ACB4A0
	public static Vector2 xz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB510 Offset: 0xAC9B10 VA: 0x180ACB510
	public static Vector2 yz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB4E0 Offset: 0xAC9AE0 VA: 0x180ACB4E0
	public static Vector2 yx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB550 Offset: 0xAC9B50 VA: 0x180ACB550
	public static Vector2 zx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB590 Offset: 0xAC9B90 VA: 0x180ACB590
	public static Vector2 zy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA7B0 Offset: 0xAC8DB0 VA: 0x180ACA7B0
	public static float GetVolumeCubic(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA580 Offset: 0xAC8B80 VA: 0x180ACA580
	public static float GetMaxArea2D(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAE30 Offset: 0xAC9430 VA: 0x180ACAE30
	public static Color Opaque(Color self) { }

	// RVA: 0xACA830 Offset: 0xAC8E30 VA: 0x180ACA830
	public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB260 Offset: 0xAC9860 VA: 0x180ACB260
	public static Plane TranslateCustom(Plane plane, Vector3 translation) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACADF0 Offset: 0xAC93F0 VA: 0x180ACADF0
	public static bool IsValid(Plane plane) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB130 Offset: 0xAC9730 VA: 0x180ACB130
	public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB030 Offset: 0xAC9630 VA: 0x180ACB030
	public static Color[] SampleInArray(Gradient self, int samplesCount) { }

	// RVA: 0xACB390 Offset: 0xAC9990 VA: 0x180ACB390
	private static Vector4 Vector4_Floor(Vector4 vec) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAE80 Offset: 0xAC9480 VA: 0x180ACAE80
	public static float PackToFloat(Color color, int floatPackingPrecision) { }

	// RVA: 0xACA490 Offset: 0xAC8A90 VA: 0x180ACA490
	public static Utils.FloatPackingPrecision GetFloatPackingPrecision() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void MarkCurrentSceneDirty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public enum Utils.FloatPackingPrecision // TypeDefIndex: 11554
{	// Fields
	public int value__; // 0x0
	public const Utils.FloatPackingPrecision High = 64;
	public const Utils.FloatPackingPrecision Low = 8;
	public const Utils.FloatPackingPrecision Undef = 0;

}

