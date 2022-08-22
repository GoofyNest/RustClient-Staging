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

	// RVA: 0xE6B430 Offset: 0xE69A30 VA: 0x180E6B430 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0xEEEBF0 Offset: 0xEED1F0 VA: 0x180EEEBF0
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x14D0FA0 Offset: 0x14CF5A0 VA: 0x1814D0FA0
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x14CF240 Offset: 0x14CD840 VA: 0x1814CF240 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x14CF480 Offset: 0x14CDA80 VA: 0x1814CF480 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x14CF860 Offset: 0x14CDE60 VA: 0x1814CF860 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x14CF7E0 Offset: 0x14CDDE0 VA: 0x1814CF7E0 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x14CF420 Offset: 0x14CDA20 VA: 0x1814CF420 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x14CF920 Offset: 0x14CDF20 VA: 0x1814CF920 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x14CF960 Offset: 0x14CDF60 VA: 0x1814CF960 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CF310 Offset: 0x14CD910 VA: 0x1814CF310 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x14CF820 Offset: 0x14CDE20 VA: 0x1814CF820 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x14D0F70 Offset: 0x14CF570 VA: 0x1814D0F70
	public void .ctor() { }

	// RVA: 0x14D1040 Offset: 0x14CF640 VA: 0x1814D1040 Slot: 17
	public override X509ExtensionCollection get_Extensions() { }

	// RVA: 0x14D1130 Offset: 0x14CF730 VA: 0x1814D1130 Slot: 18
	public override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x14D1240 Offset: 0x14CF840 VA: 0x1814D1240 Slot: 19
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x14D1950 Offset: 0x14CFF50 VA: 0x1814D1950 Slot: 20
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x14D1550 Offset: 0x14CFB50 VA: 0x1814D1550 Slot: 21
	public override PublicKey get_PublicKey() { }

	// RVA: 0x14D1690 Offset: 0x14CFC90 VA: 0x1814D1690 Slot: 22
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x14D1790 Offset: 0x14CFD90 VA: 0x1814D1790 Slot: 23
	public override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x14D18A0 Offset: 0x14CFEA0 VA: 0x1814D18A0 Slot: 24
	public override int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	// RVA: 0x14CF540 Offset: 0x14CDB40 VA: 0x1814CF540 Slot: 27
	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x14CF320 Offset: 0x14CD920 VA: 0x1814CF320
	private ASN1 Find(byte[] oid, ASN1 dn) { }

	// RVA: 0x14CF9A0 Offset: 0x14CDFA0 VA: 0x1814CF9A0
	private string GetValueAsString(ASN1 pair) { }

	// RVA: 0x14CFB30 Offset: 0x14CE130 VA: 0x1814CFB30
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x14D01E0 Offset: 0x14CE7E0 VA: 0x1814D01E0 Slot: 28
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x14D0310 Offset: 0x14CE910 VA: 0x1814D0310 Slot: 30
	public override void Reset() { }

	// RVA: 0x14D0B60 Offset: 0x14CF160 VA: 0x1814D0B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x14D0400 Offset: 0x14CEA00 VA: 0x1814D0400 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x14CF180 Offset: 0x14CD780 VA: 0x1814CF180
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF50 Offset: 0xAF350 VA: 0x1800AFF50
	// RVA: 0x14D0BC0 Offset: 0x14CF1C0 VA: 0x1814D0BC0 Slot: 29
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 25
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 26
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0x14D0E50 Offset: 0x14CF450 VA: 0x1814D0E50
	private static void .cctor() { }

}

