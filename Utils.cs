internal static class Utils // TypeDefIndex: 1002
{	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x2B111C0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x17C9E70 Offset: 0x17C8470 VA: 0x1817C9E70
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x17C9B00 Offset: 0x17C8100 VA: 0x1817C9B00
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x17C98B0 Offset: 0x17C7EB0 VA: 0x1817C98B0
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x17C9730 Offset: 0x17C7D30 VA: 0x1817C9730
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17C9210 Offset: 0x17C7810 VA: 0x1817C9210
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x17C9270 Offset: 0x17C7870 VA: 0x1817C9270
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x17C9A10 Offset: 0x17C8010 VA: 0x1817C9A10
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x17C9410 Offset: 0x17C7A10 VA: 0x1817C9410
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C95D0 Offset: 0x17C7BD0 VA: 0x1817C95D0
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C93B0 Offset: 0x17C79B0 VA: 0x1817C93B0
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C9470 Offset: 0x17C7A70 VA: 0x1817C9470
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C9B70 Offset: 0x17C8170 VA: 0x1817C9B70
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x17C9C00 Offset: 0x17C8200 VA: 0x1817C9C00
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool _ProduceLegacyHmacValues() { }

}

public static class Utils // TypeDefIndex: 11553
{	// Fields
	private static Utils.FloatPackingPrecision ms_FloatPackingPrecision; // 0x20060
	private const int kFloatPackingHighMinShaderLevel = 35;

	// Methods

	// RVA: 0xACA1E0 Offset: 0xAC87E0 VA: 0x180ACA1E0
	public static string GetPath(Transform current) { }

	// RVA: -1 Offset: -1
	public static T NewWithComponent<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBCC0 Offset: 0x15BA2C0 VA: 0x1815BBCC0
	|-Utils.NewWithComponent<object>
	|-Utils.NewWithComponent<BeamGeometry>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBB90 Offset: 0x15BA190 VA: 0x1815BBB90
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
	|-RVA: 0x15BBC40 Offset: 0x15BA240 VA: 0x1815BBC40
	|-Utils.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA840 Offset: 0xAC8E40 VA: 0x180ACA840
	public static bool HasFlag(Enum mask, Enum flags) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAFA0 Offset: 0xAC95A0 VA: 0x180ACAFA0
	public static Vector2 xy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAFD0 Offset: 0xAC95D0 VA: 0x180ACAFD0
	public static Vector2 xz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB040 Offset: 0xAC9640 VA: 0x180ACB040
	public static Vector2 yz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB010 Offset: 0xAC9610 VA: 0x180ACB010
	public static Vector2 yx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB080 Offset: 0xAC9680 VA: 0x180ACB080
	public static Vector2 zx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB0C0 Offset: 0xAC96C0 VA: 0x180ACB0C0
	public static Vector2 zy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA2E0 Offset: 0xAC88E0 VA: 0x180ACA2E0
	public static float GetVolumeCubic(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA0B0 Offset: 0xAC86B0 VA: 0x180ACA0B0
	public static float GetMaxArea2D(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA960 Offset: 0xAC8F60 VA: 0x180ACA960
	public static Color Opaque(Color self) { }

	// RVA: 0xACA360 Offset: 0xAC8960 VA: 0x180ACA360
	public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAD90 Offset: 0xAC9390 VA: 0x180ACAD90
	public static Plane TranslateCustom(Plane plane, Vector3 translation) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA920 Offset: 0xAC8F20 VA: 0x180ACA920
	public static bool IsValid(Plane plane) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAC60 Offset: 0xAC9260 VA: 0x180ACAC60
	public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAB60 Offset: 0xAC9160 VA: 0x180ACAB60
	public static Color[] SampleInArray(Gradient self, int samplesCount) { }

	// RVA: 0xACAEC0 Offset: 0xAC94C0 VA: 0x180ACAEC0
	private static Vector4 Vector4_Floor(Vector4 vec) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA9B0 Offset: 0xAC8FB0 VA: 0x180ACA9B0
	public static float PackToFloat(Color color, int floatPackingPrecision) { }

	// RVA: 0xAC9FC0 Offset: 0xAC85C0 VA: 0x180AC9FC0
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

