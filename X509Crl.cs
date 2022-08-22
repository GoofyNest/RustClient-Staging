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

	// RVA: 0x2281AD0 Offset: 0x22800D0 VA: 0x182281AD0
	public void .ctor(byte[] crl) { }

	// RVA: 0x2280E80 Offset: 0x227F480 VA: 0x182280E80
	private void Parse(byte[] crl) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2281BB0 Offset: 0x22801B0 VA: 0x182281BB0
	public byte[] get_Hash() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_IssuerName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public DateTime get_NextUpdate() { }

	// RVA: 0x2280B60 Offset: 0x227F160 VA: 0x182280B60
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x2280BE0 Offset: 0x227F1E0 VA: 0x182280BE0
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x2280C70 Offset: 0x227F270 VA: 0x182280C70
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x22814E0 Offset: 0x227FAE0 VA: 0x1822814E0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2281780 Offset: 0x227FD80 VA: 0x182281780
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2281860 Offset: 0x227FE60 VA: 0x182281860
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

	// RVA: 0x22809E0 Offset: 0x227EFE0 VA: 0x1822809E0
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x2280AE0 Offset: 0x227F0E0 VA: 0x182280AE0
	public byte[] get_SerialNumber() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DateTime get_RevocationDate() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public X509ExtensionCollection get_Extensions() { }

}

