public class X509Crl // TypeDefIndex: 1714
{	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x22812B0 Offset: 0x227F8B0 VA: 0x1822812B0
	public void .ctor(byte[] crl) { }

	// RVA: 0x2280660 Offset: 0x227EC60 VA: 0x182280660
	private void Parse(byte[] crl) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2281390 Offset: 0x227F990 VA: 0x182281390
	public byte[] get_Hash() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_IssuerName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public DateTime get_NextUpdate() { }

	// RVA: 0x2280340 Offset: 0x227E940 VA: 0x182280340
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x22803C0 Offset: 0x227E9C0 VA: 0x1822803C0
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x2280450 Offset: 0x227EA50 VA: 0x182280450
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x2280CC0 Offset: 0x227F2C0 VA: 0x182280CC0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2280F60 Offset: 0x227F560 VA: 0x182280F60
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2281040 Offset: 0x227F640 VA: 0x182281040
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

}

public class X509Crl.X509CrlEntry // TypeDefIndex: 1715
{	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x22801C0 Offset: 0x227E7C0 VA: 0x1822801C0
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x22802C0 Offset: 0x227E8C0 VA: 0x1822802C0
	public byte[] get_SerialNumber() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DateTime get_RevocationDate() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public X509ExtensionCollection get_Extensions() { }

}

