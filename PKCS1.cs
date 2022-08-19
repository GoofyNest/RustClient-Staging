internal sealed class PKCS1 // TypeDefIndex: 70
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1752BC0 Offset: 0x17511C0 VA: 0x181752BC0
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x1753420 Offset: 0x1751A20 VA: 0x181753420
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x17534A0 Offset: 0x1751AA0 VA: 0x1817534A0
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x1753570 Offset: 0x1751B70 VA: 0x181753570
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x1753970 Offset: 0x1751F70 VA: 0x181753970
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x17535A0 Offset: 0x1751BA0 VA: 0x1817535A0
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x1753130 Offset: 0x1751730 VA: 0x181753130
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x1752C60 Offset: 0x1751260 VA: 0x181752C60
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1753AB0 Offset: 0x17520B0 VA: 0x181753AB0
	private static void .cctor() { }

}

public sealed class PKCS1 // TypeDefIndex: 1757
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1AC1020 Offset: 0x1ABF620 VA: 0x181AC1020
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1AC0FC0 Offset: 0x1ABF5C0 VA: 0x181AC0FC0
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1AC0B70 Offset: 0x1ABF170 VA: 0x181AC0B70
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1AC1310 Offset: 0x1ABF910 VA: 0x181AC1310
	private static void .cctor() { }

}

