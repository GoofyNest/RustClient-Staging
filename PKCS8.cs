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

	// RVA: 0x1754950 Offset: 0x1752F50 VA: 0x181754950
	public void .ctor() { }

	// RVA: 0x17548C0 Offset: 0x1752EC0 VA: 0x1817548C0
	public void .ctor(byte[] data) { }

	// RVA: 0x17549C0 Offset: 0x1752FC0 VA: 0x1817549C0
	public byte[] get_PrivateKey() { }

	// RVA: 0x17544C0 Offset: 0x1752AC0 VA: 0x1817544C0
	private void Decode(byte[] data) { }

	// RVA: 0x1754810 Offset: 0x1752E10 VA: 0x181754810
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1754760 Offset: 0x1752D60 VA: 0x181754760
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1754040 Offset: 0x1752640 VA: 0x181754040
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1753EA0 Offset: 0x17524A0 VA: 0x181753EA0
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

	// RVA: 0x1748C10 Offset: 0x1747210 VA: 0x181748C10
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Algorithm() { }

	// RVA: 0x1748C40 Offset: 0x1747240 VA: 0x181748C40
	public byte[] get_EncryptedData() { }

	// RVA: 0x1748CC0 Offset: 0x17472C0 VA: 0x181748CC0
	public byte[] get_Salt() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_IterationCount() { }

	// RVA: 0x1748910 Offset: 0x1746F10 VA: 0x181748910
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

	// RVA: 0x1AC3190 Offset: 0x1AC1790 VA: 0x181AC3190
	public void .ctor() { }

	// RVA: 0x1AC3100 Offset: 0x1AC1700 VA: 0x181AC3100
	public void .ctor(byte[] data) { }

	// RVA: 0x1AC3200 Offset: 0x1AC1800 VA: 0x181AC3200
	public byte[] get_PrivateKey() { }

	// RVA: 0x1AC24E0 Offset: 0x1AC0AE0 VA: 0x181AC24E0
	private void Decode(byte[] data) { }

	// RVA: 0x1AC3050 Offset: 0x1AC1650 VA: 0x181AC3050
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1AC2FA0 Offset: 0x1AC15A0 VA: 0x181AC2FA0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1AC2050 Offset: 0x1AC0650 VA: 0x181AC2050
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1AC2A00 Offset: 0x1AC1000 VA: 0x181AC2A00
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1AC1EB0 Offset: 0x1AC04B0 VA: 0x181AC1EB0
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1AC27A0 Offset: 0x1AC0DA0 VA: 0x181AC27A0
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1AC2810 Offset: 0x1AC0E10 VA: 0x181AC2810
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

	// RVA: 0x1AB5420 Offset: 0x1AB3A20 VA: 0x181AB5420
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Algorithm() { }

	// RVA: 0x1AB5450 Offset: 0x1AB3A50 VA: 0x181AB5450
	public byte[] get_EncryptedData() { }

	// RVA: 0x1AB54D0 Offset: 0x1AB3AD0 VA: 0x181AB54D0
	public byte[] get_Salt() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_IterationCount() { }

	// RVA: 0x1AB5110 Offset: 0x1AB3710 VA: 0x181AB5110
	private void Decode(byte[] data) { }

}

