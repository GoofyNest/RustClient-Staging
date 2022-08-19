internal static class Utils // TypeDefIndex: 1002
{	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x2B11160

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x17C9BB0 Offset: 0x17C81B0 VA: 0x1817C9BB0
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x17C9840 Offset: 0x17C7E40 VA: 0x1817C9840
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x17C95F0 Offset: 0x17C7BF0 VA: 0x1817C95F0
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x17C9470 Offset: 0x17C7A70 VA: 0x1817C9470
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17C8F50 Offset: 0x17C7550 VA: 0x1817C8F50
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x17C8FB0 Offset: 0x17C75B0 VA: 0x1817C8FB0
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x17C9750 Offset: 0x17C7D50 VA: 0x1817C9750
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x17C9150 Offset: 0x17C7750 VA: 0x1817C9150
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C9310 Offset: 0x17C7910 VA: 0x1817C9310
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C90F0 Offset: 0x17C76F0 VA: 0x1817C90F0
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C91B0 Offset: 0x17C77B0 VA: 0x1817C91B0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C98B0 Offset: 0x17C7EB0 VA: 0x1817C98B0
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x17C9940 Offset: 0x17C7F40 VA: 0x1817C9940
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool _ProduceLegacyHmacValues() { }

}

public static class Utils // TypeDefIndex: 11553
{	// Fields
	private static Utils.FloatPackingPrecision ms_FloatPackingPrecision; // 0x20060
	private const int kFloatPackingHighMinShaderLevel = 35;

	// Methods

	// RVA: 0xAC9F20 Offset: 0xAC8520 VA: 0x180AC9F20
	public static string GetPath(Transform current) { }

	// RVA: -1 Offset: -1
	public static T NewWithComponent<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBA00 Offset: 0x15BA000 VA: 0x1815BBA00
	|-Utils.NewWithComponent<object>
	|-Utils.NewWithComponent<BeamGeometry>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB8D0 Offset: 0x15B9ED0 VA: 0x1815BB8D0
	|-Utils.GetOrAddComponent<object>
	|-Utils.GetOrAddComponent<MeshCollider>
	|-Utils.GetOrAddComponent<MeshFilter>
	|-Utils.GetOrAddComponent<MeshRenderer>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(MonoBehaviour self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB980 Offset: 0x15B9F80 VA: 0x1815BB980
	|-Utils.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA580 Offset: 0xAC8B80 VA: 0x180ACA580
	public static bool HasFlag(Enum mask, Enum flags) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACACE0 Offset: 0xAC92E0 VA: 0x180ACACE0
	public static Vector2 xy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD10 Offset: 0xAC9310 VA: 0x180ACAD10
	public static Vector2 xz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD80 Offset: 0xAC9380 VA: 0x180ACAD80
	public static Vector2 yz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD50 Offset: 0xAC9350 VA: 0x180ACAD50
	public static Vector2 yx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACADC0 Offset: 0xAC93C0 VA: 0x180ACADC0
	public static Vector2 zx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAE00 Offset: 0xAC9400 VA: 0x180ACAE00
	public static Vector2 zy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA020 Offset: 0xAC8620 VA: 0x180ACA020
	public static float GetVolumeCubic(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAC9DF0 Offset: 0xAC83F0 VA: 0x180AC9DF0
	public static float GetMaxArea2D(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA6A0 Offset: 0xAC8CA0 VA: 0x180ACA6A0
	public static Color Opaque(Color self) { }

	// RVA: 0xACA0A0 Offset: 0xAC86A0 VA: 0x180ACA0A0
	public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAAD0 Offset: 0xAC90D0 VA: 0x180ACAAD0
	public static Plane TranslateCustom(Plane plane, Vector3 translation) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA660 Offset: 0xAC8C60 VA: 0x180ACA660
	public static bool IsValid(Plane plane) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA9A0 Offset: 0xAC8FA0 VA: 0x180ACA9A0
	public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA8A0 Offset: 0xAC8EA0 VA: 0x180ACA8A0
	public static Color[] SampleInArray(Gradient self, int samplesCount) { }

	// RVA: 0xACAC00 Offset: 0xAC9200 VA: 0x180ACAC00
	private static Vector4 Vector4_Floor(Vector4 vec) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACA6F0 Offset: 0xAC8CF0 VA: 0x180ACA6F0
	public static float PackToFloat(Color color, int floatPackingPrecision) { }

	// RVA: 0xAC9D00 Offset: 0xAC8300 VA: 0x180AC9D00
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

