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

	// RVA: 0x14D8490 Offset: 0x14D6A90 VA: 0x1814D8490
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D8840 Offset: 0x14D6E40 VA: 0x1814D8840 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06B0 Offset: 0xAFAB0 VA: 0x1800B06B0
	// RVA: 0x14D5800 Offset: 0x14D3E00 VA: 0x1814D5800 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D7C80 Offset: 0x14D6280 VA: 0x1814D7C80 Slot: 10
	public override void Reset() { }

	// RVA: 0x14D8A30 Offset: 0x14D7030 VA: 0x1814D8A30
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x14D8590 Offset: 0x14D6B90 VA: 0x1814D8590
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x14D8970 Offset: 0x14D6F70 VA: 0x1814D8970
	private X509Store get_LMRootStore() { }

	// RVA: 0x14D8BE0 Offset: 0x14D71E0 VA: 0x1814D8BE0
	private X509Store get_UserRootStore() { }

	// RVA: 0x14D88B0 Offset: 0x14D6EB0 VA: 0x1814D88B0
	private X509Store get_LMCAStore() { }

	// RVA: 0x14D8B20 Offset: 0x14D7120 VA: 0x1814D8B20
	private X509Store get_UserCAStore() { }

	// RVA: 0x14D8680 Offset: 0x14D6C80 VA: 0x1814D8680
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x14D5620 Offset: 0x14D3C20 VA: 0x1814D5620
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x14D7E50 Offset: 0x14D6450 VA: 0x1814D7E50
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x14D6960 Offset: 0x14D4F60 VA: 0x1814D6960
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x14D6EA0 Offset: 0x14D54A0 VA: 0x1814D6EA0
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x14D6FC0 Offset: 0x14D55C0 VA: 0x1814D6FC0
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x14D80B0 Offset: 0x14D66B0 VA: 0x1814D80B0
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D78D0 Offset: 0x14D5ED0 VA: 0x1814D78D0
	private void Process(int n) { }

	// RVA: 0x14D7060 Offset: 0x14D5660 VA: 0x1814D7060
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x14D8350 Offset: 0x14D6950 VA: 0x1814D8350
	private void WrapUp() { }

	// RVA: 0x14D72D0 Offset: 0x14D58D0 VA: 0x1814D72D0
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x14D7010 Offset: 0x14D5610 VA: 0x1814D7010
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x14D6D90 Offset: 0x14D5390 VA: 0x1814D6D90
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D6B20 Offset: 0x14D5120 VA: 0x1814D6B20
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D6BB0 Offset: 0x14D51B0 VA: 0x1814D6BB0
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x14D6C30 Offset: 0x14D5230 VA: 0x1814D6C30
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x14D6180 Offset: 0x14D4780 VA: 0x1814D6180
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D6650 Offset: 0x14D4C50 VA: 0x1814D6650
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x14D63E0 Offset: 0x14D49E0 VA: 0x1814D63E0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x14D5EC0 Offset: 0x14D44C0 VA: 0x1814D5EC0
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x14D6790 Offset: 0x14D4D90 VA: 0x1814D6790
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x14D76C0 Offset: 0x14D5CC0 VA: 0x1814D76C0
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x14D74D0 Offset: 0x14D5AD0 VA: 0x1814D74D0
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x14D8440 Offset: 0x14D6A40 VA: 0x1814D8440
	private static void .cctor() { }

}

