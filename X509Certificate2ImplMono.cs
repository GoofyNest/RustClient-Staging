internal class X509Certificate2ImplMono : X509Certificate2Impl // TypeDefIndex: 2818
{	// Fields
	private bool _archived; // 0x18
	private X509ExtensionCollection _extensions; // 0x20
	private PublicKey _publicKey; // 0x28
	private X500DistinguishedName issuer_name; // 0x30
	private X500DistinguishedName subject_name; // 0x38
	private Oid signature_algorithm; // 0x40
	private X509CertificateImplCollection intermediateCerts; // 0x48
	private X509Certificate _cert; // 0x50
	private static string empty_error; // 0x0
	private static byte[] commonName; // 0x8
	private static byte[] email; // 0x10
	private static byte[] signedData; // 0x18

	// Properties
	public override bool IsValid { get; }
	public override X509ExtensionCollection Extensions { get; }
	public override X500DistinguishedName IssuerName { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	public override PublicKey PublicKey { get; }
	public override Oid SignatureAlgorithm { get; }
	public override X500DistinguishedName SubjectName { get; }
	public override int Version { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }
	internal override X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: 0xE6B6F0 Offset: 0xE69CF0 VA: 0x180E6B6F0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0xEEEEB0 Offset: 0xEED4B0 VA: 0x180EEEEB0
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x14D1260 Offset: 0x14CF860 VA: 0x1814D1260
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x14CF500 Offset: 0x14CDB00 VA: 0x1814CF500 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x14CF740 Offset: 0x14CDD40 VA: 0x1814CF740 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x14CFB20 Offset: 0x14CE120 VA: 0x1814CFB20 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x14CFAA0 Offset: 0x14CE0A0 VA: 0x1814CFAA0 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x14CF6E0 Offset: 0x14CDCE0 VA: 0x1814CF6E0 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x14CFBE0 Offset: 0x14CE1E0 VA: 0x1814CFBE0 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x14CFC20 Offset: 0x14CE220 VA: 0x1814CFC20 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CF5D0 Offset: 0x14CDBD0 VA: 0x1814CF5D0 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x14CFAE0 Offset: 0x14CE0E0 VA: 0x1814CFAE0 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x14D1230 Offset: 0x14CF830 VA: 0x1814D1230
	public void .ctor() { }

	// RVA: 0x14D1300 Offset: 0x14CF900 VA: 0x1814D1300 Slot: 17
	public override X509ExtensionCollection get_Extensions() { }

	// RVA: 0x14D13F0 Offset: 0x14CF9F0 VA: 0x1814D13F0 Slot: 18
	public override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x14D1500 Offset: 0x14CFB00 VA: 0x1814D1500 Slot: 19
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x14D1C10 Offset: 0x14D0210 VA: 0x1814D1C10 Slot: 20
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x14D1810 Offset: 0x14CFE10 VA: 0x1814D1810 Slot: 21
	public override PublicKey get_PublicKey() { }

	// RVA: 0x14D1950 Offset: 0x14CFF50 VA: 0x1814D1950 Slot: 22
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x14D1A50 Offset: 0x14D0050 VA: 0x1814D1A50 Slot: 23
	public override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x14D1B60 Offset: 0x14D0160 VA: 0x1814D1B60 Slot: 24
	public override int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	// RVA: 0x14CF800 Offset: 0x14CDE00 VA: 0x1814CF800 Slot: 27
	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x14CF5E0 Offset: 0x14CDBE0 VA: 0x1814CF5E0
	private ASN1 Find(byte[] oid, ASN1 dn) { }

	// RVA: 0x14CFC60 Offset: 0x14CE260 VA: 0x1814CFC60
	private string GetValueAsString(ASN1 pair) { }

	// RVA: 0x14CFDF0 Offset: 0x14CE3F0 VA: 0x1814CFDF0
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x14D04A0 Offset: 0x14CEAA0 VA: 0x1814D04A0 Slot: 28
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x14D05D0 Offset: 0x14CEBD0 VA: 0x1814D05D0 Slot: 30
	public override void Reset() { }

	// RVA: 0x14D0E20 Offset: 0x14CF420 VA: 0x1814D0E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x14D06C0 Offset: 0x14CECC0 VA: 0x1814D06C0 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x14CF440 Offset: 0x14CDA40 VA: 0x1814CF440
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF50 Offset: 0xAF350 VA: 0x1800AFF50
	// RVA: 0x14D0E80 Offset: 0x14CF480 VA: 0x1814D0E80 Slot: 29
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 25
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 26
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0x14D1110 Offset: 0x14CF710 VA: 0x1814D1110
	private static void .cctor() { }

}

