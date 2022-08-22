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

	// RVA: 0xE6C1A0 Offset: 0xE6A7A0 VA: 0x180E6C1A0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0xEEF960 Offset: 0xEEDF60 VA: 0x180EEF960
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x14D0330 Offset: 0x14CE930 VA: 0x1814D0330
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x14CE5D0 Offset: 0x14CCBD0 VA: 0x1814CE5D0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x14CE810 Offset: 0x14CCE10 VA: 0x1814CE810 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x14CEBF0 Offset: 0x14CD1F0 VA: 0x1814CEBF0 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x14CEB70 Offset: 0x14CD170 VA: 0x1814CEB70 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x14CE7B0 Offset: 0x14CCDB0 VA: 0x1814CE7B0 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x14CECB0 Offset: 0x14CD2B0 VA: 0x1814CECB0 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x14CECF0 Offset: 0x14CD2F0 VA: 0x1814CECF0 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CE6A0 Offset: 0x14CCCA0 VA: 0x1814CE6A0 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x14CEBB0 Offset: 0x14CD1B0 VA: 0x1814CEBB0 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x14D0300 Offset: 0x14CE900 VA: 0x1814D0300
	public void .ctor() { }

	// RVA: 0x14D03D0 Offset: 0x14CE9D0 VA: 0x1814D03D0 Slot: 17
	public override X509ExtensionCollection get_Extensions() { }

	// RVA: 0x14D04C0 Offset: 0x14CEAC0 VA: 0x1814D04C0 Slot: 18
	public override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x14D05D0 Offset: 0x14CEBD0 VA: 0x1814D05D0 Slot: 19
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x14D0CE0 Offset: 0x14CF2E0 VA: 0x1814D0CE0 Slot: 20
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x14D08E0 Offset: 0x14CEEE0 VA: 0x1814D08E0 Slot: 21
	public override PublicKey get_PublicKey() { }

	// RVA: 0x14D0A20 Offset: 0x14CF020 VA: 0x1814D0A20 Slot: 22
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x14D0B20 Offset: 0x14CF120 VA: 0x1814D0B20 Slot: 23
	public override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x14D0C30 Offset: 0x14CF230 VA: 0x1814D0C30 Slot: 24
	public override int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	// RVA: 0x14CE8D0 Offset: 0x14CCED0 VA: 0x1814CE8D0 Slot: 27
	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x14CE6B0 Offset: 0x14CCCB0 VA: 0x1814CE6B0
	private ASN1 Find(byte[] oid, ASN1 dn) { }

	// RVA: 0x14CED30 Offset: 0x14CD330 VA: 0x1814CED30
	private string GetValueAsString(ASN1 pair) { }

	// RVA: 0x14CEEC0 Offset: 0x14CD4C0 VA: 0x1814CEEC0
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x14CF570 Offset: 0x14CDB70 VA: 0x1814CF570 Slot: 28
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x14CF6A0 Offset: 0x14CDCA0 VA: 0x1814CF6A0 Slot: 30
	public override void Reset() { }

	// RVA: 0x14CFEF0 Offset: 0x14CE4F0 VA: 0x1814CFEF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14CF790 Offset: 0x14CDD90 VA: 0x1814CF790 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x14CE510 Offset: 0x14CCB10 VA: 0x1814CE510
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF50 Offset: 0xAF350 VA: 0x1800AFF50
	// RVA: 0x14CFF50 Offset: 0x14CE550 VA: 0x1814CFF50 Slot: 29
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 25
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 26
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0x14D01E0 Offset: 0x14CE7E0 VA: 0x1814D01E0
	private static void .cctor() { }

}

