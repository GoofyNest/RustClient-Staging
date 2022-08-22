internal sealed class PKCS1 // TypeDefIndex: 70
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1750A40 Offset: 0x174F040 VA: 0x181750A40
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x17512A0 Offset: 0x174F8A0 VA: 0x1817512A0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x1751320 Offset: 0x174F920 VA: 0x181751320
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x17513F0 Offset: 0x174F9F0 VA: 0x1817513F0
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x17517F0 Offset: 0x174FDF0 VA: 0x1817517F0
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x1751420 Offset: 0x174FA20 VA: 0x181751420
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x1750FB0 Offset: 0x174F5B0 VA: 0x181750FB0
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x1750AE0 Offset: 0x174F0E0 VA: 0x181750AE0
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1751930 Offset: 0x174FF30 VA: 0x181751930
	private static void .cctor() { }

}

public sealed class PKCS1 // TypeDefIndex: 1757
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1AC1910 Offset: 0x1ABFF10 VA: 0x181AC1910
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1AC18B0 Offset: 0x1ABFEB0 VA: 0x181AC18B0
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1AC1460 Offset: 0x1ABFA60 VA: 0x181AC1460
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1AC1C00 Offset: 0x1AC0200 VA: 0x181AC1C00
	private static void .cctor() { }

}

