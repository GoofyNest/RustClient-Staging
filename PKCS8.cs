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

	// RVA: 0x1AC2ED0 Offset: 0x1AC14D0 VA: 0x181AC2ED0
	public void .ctor() { }

	// RVA: 0x1AC2E40 Offset: 0x1AC1440 VA: 0x181AC2E40
	public void .ctor(byte[] data) { }

	// RVA: 0x1AC2F40 Offset: 0x1AC1540 VA: 0x181AC2F40
	public byte[] get_PrivateKey() { }

	// RVA: 0x1AC2220 Offset: 0x1AC0820 VA: 0x181AC2220
	private void Decode(byte[] data) { }

	// RVA: 0x1AC2D90 Offset: 0x1AC1390 VA: 0x181AC2D90
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1AC2CE0 Offset: 0x1AC12E0 VA: 0x181AC2CE0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1AC1D90 Offset: 0x1AC0390 VA: 0x181AC1D90
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1AC2740 Offset: 0x1AC0D40 VA: 0x181AC2740
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1AC1BF0 Offset: 0x1AC01F0 VA: 0x181AC1BF0
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1AC24E0 Offset: 0x1AC0AE0 VA: 0x181AC24E0
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1AC2550 Offset: 0x1AC0B50 VA: 0x181AC2550
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

	// RVA: 0x1AB5160 Offset: 0x1AB3760 VA: 0x181AB5160
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Algorithm() { }

	// RVA: 0x1AB5190 Offset: 0x1AB3790 VA: 0x181AB5190
	public byte[] get_EncryptedData() { }

	// RVA: 0x1AB5210 Offset: 0x1AB3810 VA: 0x181AB5210
	public byte[] get_Salt() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_IterationCount() { }

	// RVA: 0x1AB4E50 Offset: 0x1AB3450 VA: 0x181AB4E50
	private void Decode(byte[] data) { }

}

