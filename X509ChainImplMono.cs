internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 2827
{	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainPolicy ChainPolicy { get; set; }
	public override X509ChainStatus[] ChainStatus { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x14D8750 Offset: 0x14D6D50 VA: 0x1814D8750
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D8B00 Offset: 0x14D7100 VA: 0x1814D8B00 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06A0 Offset: 0xAFAA0 VA: 0x1800B06A0
	// RVA: 0x14D5AC0 Offset: 0x14D40C0 VA: 0x1814D5AC0 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D7F40 Offset: 0x14D6540 VA: 0x1814D7F40 Slot: 10
	public override void Reset() { }

	// RVA: 0x14D8CF0 Offset: 0x14D72F0 VA: 0x1814D8CF0
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x14D8850 Offset: 0x14D6E50 VA: 0x1814D8850
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x14D8C30 Offset: 0x14D7230 VA: 0x1814D8C30
	private X509Store get_LMRootStore() { }

	// RVA: 0x14D8EA0 Offset: 0x14D74A0 VA: 0x1814D8EA0
	private X509Store get_UserRootStore() { }

	// RVA: 0x14D8B70 Offset: 0x14D7170 VA: 0x1814D8B70
	private X509Store get_LMCAStore() { }

	// RVA: 0x14D8DE0 Offset: 0x14D73E0 VA: 0x1814D8DE0
	private X509Store get_UserCAStore() { }

	// RVA: 0x14D8940 Offset: 0x14D6F40 VA: 0x1814D8940
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x14D58E0 Offset: 0x14D3EE0 VA: 0x1814D58E0
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x14D8110 Offset: 0x14D6710 VA: 0x1814D8110
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x14D6C20 Offset: 0x14D5220 VA: 0x1814D6C20
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x14D7160 Offset: 0x14D5760 VA: 0x1814D7160
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x14D7280 Offset: 0x14D5880 VA: 0x1814D7280
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x14D8370 Offset: 0x14D6970 VA: 0x1814D8370
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D7B90 Offset: 0x14D6190 VA: 0x1814D7B90
	private void Process(int n) { }

	// RVA: 0x14D7320 Offset: 0x14D5920 VA: 0x1814D7320
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x14D8610 Offset: 0x14D6C10 VA: 0x1814D8610
	private void WrapUp() { }

	// RVA: 0x14D7590 Offset: 0x14D5B90 VA: 0x1814D7590
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x14D72D0 Offset: 0x14D58D0 VA: 0x1814D72D0
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x14D7050 Offset: 0x14D5650 VA: 0x1814D7050
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D6DE0 Offset: 0x14D53E0 VA: 0x1814D6DE0
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D6E70 Offset: 0x14D5470 VA: 0x1814D6E70
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x14D6EF0 Offset: 0x14D54F0 VA: 0x1814D6EF0
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x14D6440 Offset: 0x14D4A40 VA: 0x1814D6440
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D6910 Offset: 0x14D4F10 VA: 0x1814D6910
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x14D66A0 Offset: 0x14D4CA0 VA: 0x1814D66A0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x14D6180 Offset: 0x14D4780 VA: 0x1814D6180
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x14D6A50 Offset: 0x14D5050 VA: 0x1814D6A50
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x14D7980 Offset: 0x14D5F80 VA: 0x1814D7980
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x14D7790 Offset: 0x14D5D90 VA: 0x1814D7790
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x14D8700 Offset: 0x14D6D00 VA: 0x1814D8700
	private static void .cctor() { }

}

