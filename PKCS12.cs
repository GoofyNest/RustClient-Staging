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

	// RVA: 0x174FDC0 Offset: 0x174E3C0 VA: 0x18174FDC0
	public void .ctor() { }

	// RVA: 0x174FCF0 Offset: 0x174E2F0 VA: 0x18174FCF0
	public void .ctor(byte[] data) { }

	// RVA: 0x174FD70 Offset: 0x174E370 VA: 0x18174FD70
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x174B410 Offset: 0x1749A10 VA: 0x18174B410
	private void Decode(byte[] data) { }

	// RVA: 0x174C3E0 Offset: 0x174A9E0 VA: 0x18174C3E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17508C0 Offset: 0x174EEC0 VA: 0x1817508C0
	public void set_Password(string value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public int get_IterationCount() { }

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_IterationCount(int value) { }

	// RVA: 0x17501E0 Offset: 0x174E7E0 VA: 0x1817501E0
	public ArrayList get_Keys() { }

	// RVA: 0x174FEB0 Offset: 0x174E4B0 VA: 0x18174FEB0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1750880 Offset: 0x174EE80 VA: 0x181750880
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174B390 Offset: 0x1749990 VA: 0x18174B390
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x174E5B0 Offset: 0x174CBB0 VA: 0x18174E5B0
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x174BC20 Offset: 0x174A220 VA: 0x18174BC20
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x174BD70 Offset: 0x174A370 VA: 0x18174BD70
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x174BEA0 Offset: 0x174A4A0 VA: 0x18174BEA0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x174E2E0 Offset: 0x174C8E0 VA: 0x18174E2E0
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x174A750 Offset: 0x1748D50 VA: 0x18174A750
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x174F040 Offset: 0x174D640 VA: 0x18174F040
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x174A8C0 Offset: 0x1748EC0 VA: 0x18174A8C0
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x174EDD0 Offset: 0x174D3D0 VA: 0x18174EDD0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x174C490 Offset: 0x174AA90 VA: 0x18174C490
	public byte[] GetBytes() { }

	// RVA: 0x174BFF0 Offset: 0x174A5F0 VA: 0x18174BFF0
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x174A430 Offset: 0x1748A30 VA: 0x18174A430
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x174A440 Offset: 0x1748A40 VA: 0x18174A440
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x174F720 Offset: 0x174DD20 VA: 0x18174F720
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x174F730 Offset: 0x174DD30 VA: 0x18174F730
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x174B250 Offset: 0x1749850 VA: 0x18174B250 Slot: 4
	public object Clone() { }

	// RVA: 0x17507C0 Offset: 0x174EDC0 VA: 0x1817507C0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x174FCB0 Offset: 0x174E2B0 VA: 0x18174FCB0
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

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_HashName(string value) { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_IterationCount(int value) { }

	// RVA: 0x1745F70 Offset: 0x1744570 VA: 0x181745F70
	public void set_Password(byte[] value) { }

	// RVA: 0x1746020 Offset: 0x1744620 VA: 0x181746020
	public void set_Salt(byte[] value) { }

	// RVA: 0x1745750 Offset: 0x1743D50 VA: 0x181745750
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x17459C0 Offset: 0x1743FC0 VA: 0x1817459C0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x17458C0 Offset: 0x1743EC0 VA: 0x1817458C0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1745840 Offset: 0x1743E40 VA: 0x181745840
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1745940 Offset: 0x1743F40 VA: 0x181745940
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1745E80 Offset: 0x1744480 VA: 0x181745E80
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

	// RVA: 0x1AC07A0 Offset: 0x1ABEDA0 VA: 0x181AC07A0
	public void .ctor() { }

	// RVA: 0x1AC0890 Offset: 0x1ABEE90 VA: 0x181AC0890
	public void .ctor(byte[] data) { }

	// RVA: 0x1AC0750 Offset: 0x1ABED50 VA: 0x181AC0750
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1ABB5D0 Offset: 0x1AB9BD0 VA: 0x181ABB5D0
	private void Decode(byte[] data) { }

	// RVA: 0x174C3E0 Offset: 0x174A9E0 VA: 0x18174C3E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC12E0 Offset: 0x1ABF8E0 VA: 0x181AC12E0
	public void set_Password(string value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public int get_IterationCount() { }

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_IterationCount(int value) { }

	// RVA: 0x1AC0C40 Offset: 0x1ABF240 VA: 0x181AC0C40
	public ArrayList get_Keys() { }

	// RVA: 0x1AC0910 Offset: 0x1ABEF10 VA: 0x181AC0910
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1750880 Offset: 0x174EE80 VA: 0x181750880
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x174B390 Offset: 0x1749990 VA: 0x18174B390
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1ABF170 Offset: 0x1ABD770 VA: 0x181ABF170
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1ABBE40 Offset: 0x1ABA440 VA: 0x181ABBE40
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1ABBF90 Offset: 0x1ABA590 VA: 0x181ABBF90
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1ABC0C0 Offset: 0x1ABA6C0 VA: 0x181ABC0C0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1ABEF40 Offset: 0x1ABD540 VA: 0x181ABEF40
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1ABA6F0 Offset: 0x1AB8CF0 VA: 0x181ABA6F0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1ABFA00 Offset: 0x1ABE000 VA: 0x181ABFA00
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1ABA860 Offset: 0x1AB8E60 VA: 0x181ABA860
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1ABF790 Offset: 0x1ABDD90 VA: 0x181ABF790
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1ABCA40 Offset: 0x1ABB040 VA: 0x181ABCA40
	public byte[] GetBytes() { }

	// RVA: 0x1ABC210 Offset: 0x1ABA810 VA: 0x181ABC210
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1ABA6E0 Offset: 0x1AB8CE0 VA: 0x181ABA6E0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1ABA3F0 Offset: 0x1AB89F0 VA: 0x181ABA3F0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1AC0100 Offset: 0x1ABE700 VA: 0x181AC0100
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1AC0110 Offset: 0x1ABE710 VA: 0x181AC0110
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1ABB490 Offset: 0x1AB9A90 VA: 0x181ABB490 Slot: 4
	public object Clone() { }

	// RVA: 0x1AC1220 Offset: 0x1ABF820 VA: 0x181AC1220
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1AC0710 Offset: 0x1ABED10 VA: 0x181AC0710
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

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_HashName(string value) { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_IterationCount(int value) { }

	// RVA: 0x1AB53A0 Offset: 0x1AB39A0 VA: 0x181AB53A0
	public void set_Password(byte[] value) { }

	// RVA: 0x1AB5450 Offset: 0x1AB3A50 VA: 0x181AB5450
	public void set_Salt(byte[] value) { }

	// RVA: 0x1745750 Offset: 0x1743D50 VA: 0x181745750
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1AB4DF0 Offset: 0x1AB33F0 VA: 0x181AB4DF0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1AB4CF0 Offset: 0x1AB32F0 VA: 0x181AB4CF0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1AB4C70 Offset: 0x1AB3270 VA: 0x181AB4C70
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1AB4D70 Offset: 0x1AB3370 VA: 0x181AB4D70
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1AB52B0 Offset: 0x1AB38B0 VA: 0x181AB52B0
	private static void .cctor() { }

}

