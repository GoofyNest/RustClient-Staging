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

	// RVA: 0x1ABFCF0 Offset: 0x1ABE2F0 VA: 0x181ABFCF0
	public void .ctor() { }

	// RVA: 0x1ABFDE0 Offset: 0x1ABE3E0 VA: 0x181ABFDE0
	public void .ctor(byte[] data) { }

	// RVA: 0x1ABFCA0 Offset: 0x1ABE2A0 VA: 0x181ABFCA0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1ABAB20 Offset: 0x1AB9120 VA: 0x181ABAB20
	private void Decode(byte[] data) { }

	// RVA: 0x174E560 Offset: 0x174CB60 VA: 0x18174E560 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC0830 Offset: 0x1ABEE30 VA: 0x181AC0830
	public void set_Password(string value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_IterationCount() { }

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_IterationCount(int value) { }

	// RVA: 0x1AC0190 Offset: 0x1ABE790 VA: 0x181AC0190
	public ArrayList get_Keys() { }

	// RVA: 0x1ABFE60 Offset: 0x1ABE460 VA: 0x181ABFE60
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1752A00 Offset: 0x1751000 VA: 0x181752A00
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174D510 Offset: 0x174BB10 VA: 0x18174D510
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1ABE6C0 Offset: 0x1ABCCC0 VA: 0x181ABE6C0
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1ABB390 Offset: 0x1AB9990 VA: 0x181ABB390
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1ABB4E0 Offset: 0x1AB9AE0 VA: 0x181ABB4E0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1ABB610 Offset: 0x1AB9C10 VA: 0x181ABB610
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1ABE490 Offset: 0x1ABCA90 VA: 0x181ABE490
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1AB9C40 Offset: 0x1AB8240 VA: 0x181AB9C40
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1ABEF50 Offset: 0x1ABD550 VA: 0x181ABEF50
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1AB9DB0 Offset: 0x1AB83B0 VA: 0x181AB9DB0
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1ABECE0 Offset: 0x1ABD2E0 VA: 0x181ABECE0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1ABBF90 Offset: 0x1ABA590 VA: 0x181ABBF90
	public byte[] GetBytes() { }

	// RVA: 0x1ABB760 Offset: 0x1AB9D60 VA: 0x181ABB760
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1AB9C30 Offset: 0x1AB8230 VA: 0x181AB9C30
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1AB9940 Offset: 0x1AB7F40 VA: 0x181AB9940
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1ABF650 Offset: 0x1ABDC50 VA: 0x181ABF650
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1ABF660 Offset: 0x1ABDC60 VA: 0x181ABF660
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1ABA9E0 Offset: 0x1AB8FE0 VA: 0x181ABA9E0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AC0770 Offset: 0x1ABED70 VA: 0x181AC0770
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1ABFC60 Offset: 0x1ABE260 VA: 0x181ABFC60
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

	// RVA: 0x1AB48F0 Offset: 0x1AB2EF0 VA: 0x181AB48F0
	public void set_Password(byte[] value) { }

	// RVA: 0x1AB49A0 Offset: 0x1AB2FA0 VA: 0x181AB49A0
	public void set_Salt(byte[] value) { }

	// RVA: 0x17478D0 Offset: 0x1745ED0 VA: 0x1817478D0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1AB4340 Offset: 0x1AB2940 VA: 0x181AB4340
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1AB4240 Offset: 0x1AB2840 VA: 0x181AB4240
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1AB41C0 Offset: 0x1AB27C0 VA: 0x181AB41C0
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1AB42C0 Offset: 0x1AB28C0 VA: 0x181AB42C0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1AB4800 Offset: 0x1AB2E00 VA: 0x181AB4800
	private static void .cctor() { }

}

