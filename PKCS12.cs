internal class PKCS12 : ICloneable // TypeDefIndex: 55
{	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1751F40 Offset: 0x1750540 VA: 0x181751F40
	public void .ctor() { }

	// RVA: 0x1751E70 Offset: 0x1750470 VA: 0x181751E70
	public void .ctor(byte[] data) { }

	// RVA: 0x1751EF0 Offset: 0x17504F0 VA: 0x181751EF0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x174D590 Offset: 0x174BB90 VA: 0x18174D590
	private void Decode(byte[] data) { }

	// RVA: 0x174E560 Offset: 0x174CB60 VA: 0x18174E560 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1752A40 Offset: 0x1751040 VA: 0x181752A40
	public void set_Password(string value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_IterationCount() { }

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_IterationCount(int value) { }

	// RVA: 0x1752360 Offset: 0x1750960 VA: 0x181752360
	public ArrayList get_Keys() { }

	// RVA: 0x1752030 Offset: 0x1750630 VA: 0x181752030
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1752A00 Offset: 0x1751000 VA: 0x181752A00
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174D510 Offset: 0x174BB10 VA: 0x18174D510
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1750730 Offset: 0x174ED30 VA: 0x181750730
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x174DDA0 Offset: 0x174C3A0 VA: 0x18174DDA0
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x174DEF0 Offset: 0x174C4F0 VA: 0x18174DEF0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x174E020 Offset: 0x174C620 VA: 0x18174E020
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1750460 Offset: 0x174EA60 VA: 0x181750460
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x174C8D0 Offset: 0x174AED0 VA: 0x18174C8D0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x17511C0 Offset: 0x174F7C0 VA: 0x1817511C0
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x174CA40 Offset: 0x174B040 VA: 0x18174CA40
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1750F50 Offset: 0x174F550 VA: 0x181750F50
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x174E610 Offset: 0x174CC10 VA: 0x18174E610
	public byte[] GetBytes() { }

	// RVA: 0x174E170 Offset: 0x174C770 VA: 0x18174E170
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x174C5B0 Offset: 0x174ABB0 VA: 0x18174C5B0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x174C5C0 Offset: 0x174ABC0 VA: 0x18174C5C0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x17518A0 Offset: 0x174FEA0 VA: 0x1817518A0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x17518B0 Offset: 0x174FEB0 VA: 0x1817518B0
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x174D3D0 Offset: 0x174B9D0 VA: 0x18174D3D0 Slot: 4
	public object Clone() { }

	// RVA: 0x1752940 Offset: 0x1750F40 VA: 0x181752940
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1751E30 Offset: 0x1750430 VA: 0x181751E30
	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 56
{	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_HashName(string value) { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_IterationCount(int value) { }

	// RVA: 0x17480F0 Offset: 0x17466F0 VA: 0x1817480F0
	public void set_Password(byte[] value) { }

	// RVA: 0x17481A0 Offset: 0x17467A0 VA: 0x1817481A0
	public void set_Salt(byte[] value) { }

	// RVA: 0x17478D0 Offset: 0x1745ED0 VA: 0x1817478D0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1747B40 Offset: 0x1746140 VA: 0x181747B40
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1747A40 Offset: 0x1746040 VA: 0x181747A40
	public byte[] DeriveKey(int size) { }

	// RVA: 0x17479C0 Offset: 0x1745FC0 VA: 0x1817479C0
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1747AC0 Offset: 0x17460C0 VA: 0x181747AC0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1748000 Offset: 0x1746600 VA: 0x181748000
	private static void .cctor() { }

}

public class PKCS12 : ICloneable // TypeDefIndex: 1711
{	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1ABFEB0 Offset: 0x1ABE4B0 VA: 0x181ABFEB0
	public void .ctor() { }

	// RVA: 0x1ABFFA0 Offset: 0x1ABE5A0 VA: 0x181ABFFA0
	public void .ctor(byte[] data) { }

	// RVA: 0x1ABFE60 Offset: 0x1ABE460 VA: 0x181ABFE60
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1ABACE0 Offset: 0x1AB92E0 VA: 0x181ABACE0
	private void Decode(byte[] data) { }

	// RVA: 0x174E560 Offset: 0x174CB60 VA: 0x18174E560 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC09F0 Offset: 0x1ABEFF0 VA: 0x181AC09F0
	public void set_Password(string value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_IterationCount() { }

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_IterationCount(int value) { }

	// RVA: 0x1AC0350 Offset: 0x1ABE950 VA: 0x181AC0350
	public ArrayList get_Keys() { }

	// RVA: 0x1AC0020 Offset: 0x1ABE620 VA: 0x181AC0020
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1752A00 Offset: 0x1751000 VA: 0x181752A00
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174D510 Offset: 0x174BB10 VA: 0x18174D510
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1ABE880 Offset: 0x1ABCE80 VA: 0x181ABE880
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1ABB550 Offset: 0x1AB9B50 VA: 0x181ABB550
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1ABB6A0 Offset: 0x1AB9CA0 VA: 0x181ABB6A0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1ABB7D0 Offset: 0x1AB9DD0 VA: 0x181ABB7D0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1ABE650 Offset: 0x1ABCC50 VA: 0x181ABE650
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1AB9E00 Offset: 0x1AB8400 VA: 0x181AB9E00
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1ABF110 Offset: 0x1ABD710 VA: 0x181ABF110
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1AB9F70 Offset: 0x1AB8570 VA: 0x181AB9F70
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1ABEEA0 Offset: 0x1ABD4A0 VA: 0x181ABEEA0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1ABC150 Offset: 0x1ABA750 VA: 0x181ABC150
	public byte[] GetBytes() { }

	// RVA: 0x1ABB920 Offset: 0x1AB9F20 VA: 0x181ABB920
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1AB9DF0 Offset: 0x1AB83F0 VA: 0x181AB9DF0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1AB9B00 Offset: 0x1AB8100 VA: 0x181AB9B00
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1ABF810 Offset: 0x1ABDE10 VA: 0x181ABF810
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1ABF820 Offset: 0x1ABDE20 VA: 0x181ABF820
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1ABABA0 Offset: 0x1AB91A0 VA: 0x181ABABA0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AC0930 Offset: 0x1ABEF30 VA: 0x181AC0930
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1ABFE20 Offset: 0x1ABE420 VA: 0x181ABFE20
	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 1712
{	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_HashName(string value) { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_IterationCount(int value) { }

	// RVA: 0x1AB4AB0 Offset: 0x1AB30B0 VA: 0x181AB4AB0
	public void set_Password(byte[] value) { }

	// RVA: 0x1AB4B60 Offset: 0x1AB3160 VA: 0x181AB4B60
	public void set_Salt(byte[] value) { }

	// RVA: 0x17478D0 Offset: 0x1745ED0 VA: 0x1817478D0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1AB4500 Offset: 0x1AB2B00 VA: 0x181AB4500
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1AB4400 Offset: 0x1AB2A00 VA: 0x181AB4400
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1AB4380 Offset: 0x1AB2980 VA: 0x181AB4380
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1AB4480 Offset: 0x1AB2A80 VA: 0x181AB4480
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1AB49C0 Offset: 0x1AB2FC0 VA: 0x181AB49C0
	private static void .cctor() { }

}

