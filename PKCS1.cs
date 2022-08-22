internal sealed class PKCS1 // TypeDefIndex: 70
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1752E80 Offset: 0x1751480 VA: 0x181752E80
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x17536E0 Offset: 0x1751CE0 VA: 0x1817536E0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x1753760 Offset: 0x1751D60 VA: 0x181753760
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x1753830 Offset: 0x1751E30 VA: 0x181753830
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x1753C30 Offset: 0x1752230 VA: 0x181753C30
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x1753860 Offset: 0x1751E60 VA: 0x181753860
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x17533F0 Offset: 0x17519F0 VA: 0x1817533F0
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x1752F20 Offset: 0x1751520 VA: 0x181752F20
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1753D70 Offset: 0x1752370 VA: 0x181753D70
	private static void .cctor() { }

}

public sealed class PKCS1 // TypeDefIndex: 1757
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1AC1120 Offset: 0x1ABF720 VA: 0x181AC1120
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1AC10C0 Offset: 0x1ABF6C0 VA: 0x181AC10C0
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1AC0C70 Offset: 0x1ABF270 VA: 0x181AC0C70
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1AC1410 Offset: 0x1ABFA10 VA: 0x181AC1410
	private static void .cctor() { }

}

