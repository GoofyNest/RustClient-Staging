public class PKCS8.PrivateKeyInfo // TypeDefIndex: 72
{
// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 72
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x1754690 Offset: 0x1752C90 VA: 0x181754690
	public void .ctor() { }

	// RVA: 0x1754600 Offset: 0x1752C00 VA: 0x181754600
	public void .ctor(byte[] data) { }

	// RVA: 0x1754700 Offset: 0x1752D00 VA: 0x181754700
	public byte[] get_PrivateKey() { }

	// RVA: 0x1754200 Offset: 0x1752800 VA: 0x181754200
	private void Decode(byte[] data) { }

	// RVA: 0x1754550 Offset: 0x1752B50 VA: 0x181754550
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x17544A0 Offset: 0x1752AA0 VA: 0x1817544A0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1753D80 Offset: 0x1752380 VA: 0x181753D80
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1753BE0 Offset: 0x17521E0 VA: 0x181753BE0
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 73
{	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1748950 Offset: 0x1746F50 VA: 0x181748950
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Algorithm() { }

	// RVA: 0x1748980 Offset: 0x1746F80 VA: 0x181748980
	public byte[] get_EncryptedData() { }

	// RVA: 0x1748A00 Offset: 0x1747000 VA: 0x181748A00
	public byte[] get_Salt() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_IterationCount() { }

	// RVA: 0x1748650 Offset: 0x1746C50 VA: 0x181748650
	private void Decode(byte[] data) { }

}

public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1759
{
// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1759
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x1AC3090 Offset: 0x1AC1690 VA: 0x181AC3090
	public void .ctor() { }

	// RVA: 0x1AC3000 Offset: 0x1AC1600 VA: 0x181AC3000
	public void .ctor(byte[] data) { }

	// RVA: 0x1AC3100 Offset: 0x1AC1700 VA: 0x181AC3100
	public byte[] get_PrivateKey() { }

	// RVA: 0x1AC23E0 Offset: 0x1AC09E0 VA: 0x181AC23E0
	private void Decode(byte[] data) { }

	// RVA: 0x1AC2F50 Offset: 0x1AC1550 VA: 0x181AC2F50
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1AC2EA0 Offset: 0x1AC14A0 VA: 0x181AC2EA0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1AC1F50 Offset: 0x1AC0550 VA: 0x181AC1F50
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1AC2900 Offset: 0x1AC0F00 VA: 0x181AC2900
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1AC1DB0 Offset: 0x1AC03B0 VA: 0x181AC1DB0
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1AC26A0 Offset: 0x1AC0CA0 VA: 0x181AC26A0
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1AC2710 Offset: 0x1AC0D10 VA: 0x181AC2710
	public static byte[] Encode(AsymmetricAlgorithm aa) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1760
{	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1AB5320 Offset: 0x1AB3920 VA: 0x181AB5320
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Algorithm() { }

	// RVA: 0x1AB5350 Offset: 0x1AB3950 VA: 0x181AB5350
	public byte[] get_EncryptedData() { }

	// RVA: 0x1AB53D0 Offset: 0x1AB39D0 VA: 0x181AB53D0
	public byte[] get_Salt() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_IterationCount() { }

	// RVA: 0x1AB5010 Offset: 0x1AB3610 VA: 0x181AB5010
	private void Decode(byte[] data) { }

}

