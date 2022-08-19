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

	// RVA: 0x22811B0 Offset: 0x227F7B0 VA: 0x1822811B0
	public void .ctor(byte[] crl) { }

	// RVA: 0x2280560 Offset: 0x227EB60 VA: 0x182280560
	private void Parse(byte[] crl) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2281290 Offset: 0x227F890 VA: 0x182281290
	public byte[] get_Hash() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_IssuerName() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public DateTime get_NextUpdate() { }

	// RVA: 0x2280240 Offset: 0x227E840 VA: 0x182280240
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x22802C0 Offset: 0x227E8C0 VA: 0x1822802C0
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x2280350 Offset: 0x227E950 VA: 0x182280350
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x2280BC0 Offset: 0x227F1C0 VA: 0x182280BC0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2280E60 Offset: 0x227F460 VA: 0x182280E60
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2280F40 Offset: 0x227F540 VA: 0x182280F40
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

	// RVA: 0x22800C0 Offset: 0x227E6C0 VA: 0x1822800C0
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x22801C0 Offset: 0x227E7C0 VA: 0x1822801C0
	public byte[] get_SerialNumber() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DateTime get_RevocationDate() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public X509ExtensionCollection get_Extensions() { }

}

