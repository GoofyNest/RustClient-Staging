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

	// RVA: 0x1752200 Offset: 0x1750800 VA: 0x181752200
	public void .ctor() { }

	// RVA: 0x1752130 Offset: 0x1750730 VA: 0x181752130
	public void .ctor(byte[] data) { }

	// RVA: 0x17521B0 Offset: 0x17507B0 VA: 0x1817521B0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x174D850 Offset: 0x174BE50 VA: 0x18174D850
	private void Decode(byte[] data) { }

	// RVA: 0x174E820 Offset: 0x174CE20 VA: 0x18174E820 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1752D00 Offset: 0x1751300 VA: 0x181752D00
	public void set_Password(string value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_IterationCount() { }

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_IterationCount(int value) { }

	// RVA: 0x1752620 Offset: 0x1750C20 VA: 0x181752620
	public ArrayList get_Keys() { }

	// RVA: 0x17522F0 Offset: 0x17508F0 VA: 0x1817522F0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1752CC0 Offset: 0x17512C0 VA: 0x181752CC0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174D7D0 Offset: 0x174BDD0 VA: 0x18174D7D0
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x17509F0 Offset: 0x174EFF0 VA: 0x1817509F0
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x174E060 Offset: 0x174C660 VA: 0x18174E060
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x174E1B0 Offset: 0x174C7B0 VA: 0x18174E1B0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x174E2E0 Offset: 0x174C8E0 VA: 0x18174E2E0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1750720 Offset: 0x174ED20 VA: 0x181750720
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x174CB90 Offset: 0x174B190 VA: 0x18174CB90
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1751480 Offset: 0x174FA80 VA: 0x181751480
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x174CD00 Offset: 0x174B300 VA: 0x18174CD00
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1751210 Offset: 0x174F810 VA: 0x181751210
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x174E8D0 Offset: 0x174CED0 VA: 0x18174E8D0
	public byte[] GetBytes() { }

	// RVA: 0x174E430 Offset: 0x174CA30 VA: 0x18174E430
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x174C870 Offset: 0x174AE70 VA: 0x18174C870
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x174C880 Offset: 0x174AE80 VA: 0x18174C880
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1751B60 Offset: 0x1750160 VA: 0x181751B60
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1751B70 Offset: 0x1750170 VA: 0x181751B70
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x174D690 Offset: 0x174BC90 VA: 0x18174D690 Slot: 4
	public object Clone() { }

	// RVA: 0x1752C00 Offset: 0x1751200 VA: 0x181752C00
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x17520F0 Offset: 0x17506F0 VA: 0x1817520F0
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

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_IterationCount(int value) { }

	// RVA: 0x17483B0 Offset: 0x17469B0 VA: 0x1817483B0
	public void set_Password(byte[] value) { }

	// RVA: 0x1748460 Offset: 0x1746A60 VA: 0x181748460
	public void set_Salt(byte[] value) { }

	// RVA: 0x1747B90 Offset: 0x1746190 VA: 0x181747B90
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1747E00 Offset: 0x1746400 VA: 0x181747E00
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1747D00 Offset: 0x1746300 VA: 0x181747D00
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1747C80 Offset: 0x1746280 VA: 0x181747C80
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1747D80 Offset: 0x1746380 VA: 0x181747D80
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x17482C0 Offset: 0x17468C0 VA: 0x1817482C0
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

	// RVA: 0x1ABFFB0 Offset: 0x1ABE5B0 VA: 0x181ABFFB0
	public void .ctor() { }

	// RVA: 0x1AC00A0 Offset: 0x1ABE6A0 VA: 0x181AC00A0
	public void .ctor(byte[] data) { }

	// RVA: 0x1ABFF60 Offset: 0x1ABE560 VA: 0x181ABFF60
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1ABADE0 Offset: 0x1AB93E0 VA: 0x181ABADE0
	private void Decode(byte[] data) { }

	// RVA: 0x174E820 Offset: 0x174CE20 VA: 0x18174E820 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC0AF0 Offset: 0x1ABF0F0 VA: 0x181AC0AF0
	public void set_Password(string value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_IterationCount() { }

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_IterationCount(int value) { }

	// RVA: 0x1AC0450 Offset: 0x1ABEA50 VA: 0x181AC0450
	public ArrayList get_Keys() { }

	// RVA: 0x1AC0120 Offset: 0x1ABE720 VA: 0x181AC0120
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1752CC0 Offset: 0x17512C0 VA: 0x181752CC0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174D7D0 Offset: 0x174BDD0 VA: 0x18174D7D0
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1ABE980 Offset: 0x1ABCF80 VA: 0x181ABE980
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1ABB650 Offset: 0x1AB9C50 VA: 0x181ABB650
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1ABB7A0 Offset: 0x1AB9DA0 VA: 0x181ABB7A0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1ABB8D0 Offset: 0x1AB9ED0 VA: 0x181ABB8D0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1ABE750 Offset: 0x1ABCD50 VA: 0x181ABE750
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1AB9F00 Offset: 0x1AB8500 VA: 0x181AB9F00
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1ABF210 Offset: 0x1ABD810 VA: 0x181ABF210
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1ABA070 Offset: 0x1AB8670 VA: 0x181ABA070
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1ABEFA0 Offset: 0x1ABD5A0 VA: 0x181ABEFA0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1ABC250 Offset: 0x1ABA850 VA: 0x181ABC250
	public byte[] GetBytes() { }

	// RVA: 0x1ABBA20 Offset: 0x1ABA020 VA: 0x181ABBA20
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1AB9EF0 Offset: 0x1AB84F0 VA: 0x181AB9EF0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1AB9C00 Offset: 0x1AB8200 VA: 0x181AB9C00
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1ABF910 Offset: 0x1ABDF10 VA: 0x181ABF910
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1ABF920 Offset: 0x1ABDF20 VA: 0x181ABF920
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1ABACA0 Offset: 0x1AB92A0 VA: 0x181ABACA0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AC0A30 Offset: 0x1ABF030 VA: 0x181AC0A30
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1ABFF20 Offset: 0x1ABE520 VA: 0x181ABFF20
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

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_IterationCount(int value) { }

	// RVA: 0x1AB4BB0 Offset: 0x1AB31B0 VA: 0x181AB4BB0
	public void set_Password(byte[] value) { }

	// RVA: 0x1AB4C60 Offset: 0x1AB3260 VA: 0x181AB4C60
	public void set_Salt(byte[] value) { }

	// RVA: 0x1747B90 Offset: 0x1746190 VA: 0x181747B90
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1AB4600 Offset: 0x1AB2C00 VA: 0x181AB4600
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1AB4500 Offset: 0x1AB2B00 VA: 0x181AB4500
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1AB4480 Offset: 0x1AB2A80 VA: 0x181AB4480
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1AB4580 Offset: 0x1AB2B80 VA: 0x181AB4580
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1AB4AC0 Offset: 0x1AB30C0 VA: 0x181AB4AC0
	private static void .cctor() { }

}

