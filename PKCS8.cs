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

	// RVA: 0x1752510 Offset: 0x1750B10 VA: 0x181752510
	public void .ctor() { }

	// RVA: 0x1752480 Offset: 0x1750A80 VA: 0x181752480
	public void .ctor(byte[] data) { }

	// RVA: 0x1752580 Offset: 0x1750B80 VA: 0x181752580
	public byte[] get_PrivateKey() { }

	// RVA: 0x1752080 Offset: 0x1750680 VA: 0x181752080
	private void Decode(byte[] data) { }

	// RVA: 0x17523D0 Offset: 0x17509D0 VA: 0x1817523D0
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1752320 Offset: 0x1750920 VA: 0x181752320
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1751C00 Offset: 0x1750200 VA: 0x181751C00
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1751A60 Offset: 0x1750060 VA: 0x181751A60
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

	// RVA: 0x17467D0 Offset: 0x1744DD0 VA: 0x1817467D0
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Algorithm() { }

	// RVA: 0x1746800 Offset: 0x1744E00 VA: 0x181746800
	public byte[] get_EncryptedData() { }

	// RVA: 0x1746880 Offset: 0x1744E80 VA: 0x181746880
	public byte[] get_Salt() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_IterationCount() { }

	// RVA: 0x17464D0 Offset: 0x1744AD0 VA: 0x1817464D0
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

	// RVA: 0x1AC3980 Offset: 0x1AC1F80 VA: 0x181AC3980
	public void .ctor() { }

	// RVA: 0x1AC38F0 Offset: 0x1AC1EF0 VA: 0x181AC38F0
	public void .ctor(byte[] data) { }

	// RVA: 0x1AC39F0 Offset: 0x1AC1FF0 VA: 0x181AC39F0
	public byte[] get_PrivateKey() { }

	// RVA: 0x1AC2CD0 Offset: 0x1AC12D0 VA: 0x181AC2CD0
	private void Decode(byte[] data) { }

	// RVA: 0x1AC3840 Offset: 0x1AC1E40 VA: 0x181AC3840
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1AC3790 Offset: 0x1AC1D90 VA: 0x181AC3790
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1AC2840 Offset: 0x1AC0E40 VA: 0x181AC2840
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1AC31F0 Offset: 0x1AC17F0 VA: 0x181AC31F0
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1AC26A0 Offset: 0x1AC0CA0 VA: 0x181AC26A0
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1AC2F90 Offset: 0x1AC1590 VA: 0x181AC2F90
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1AC3000 Offset: 0x1AC1600 VA: 0x181AC3000
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

	// RVA: 0x1AB5C10 Offset: 0x1AB4210 VA: 0x181AB5C10
	public void .ctor(byte[] data) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Algorithm() { }

	// RVA: 0x1AB5C40 Offset: 0x1AB4240 VA: 0x181AB5C40
	public byte[] get_EncryptedData() { }

	// RVA: 0x1AB5CC0 Offset: 0x1AB42C0 VA: 0x181AB5CC0
	public byte[] get_Salt() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_IterationCount() { }

	// RVA: 0x1AB5900 Offset: 0x1AB3F00 VA: 0x181AB5900
	private void Decode(byte[] data) { }

}

