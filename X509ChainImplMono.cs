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

	// RVA: 0x14D7820 Offset: 0x14D5E20 VA: 0x1814D7820
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D7BD0 Offset: 0x14D61D0 VA: 0x1814D7BD0 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06A0 Offset: 0xAFAA0 VA: 0x1800B06A0
	// RVA: 0x14D4B90 Offset: 0x14D3190 VA: 0x1814D4B90 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D7010 Offset: 0x14D5610 VA: 0x1814D7010 Slot: 10
	public override void Reset() { }

	// RVA: 0x14D7DC0 Offset: 0x14D63C0 VA: 0x1814D7DC0
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x14D7920 Offset: 0x14D5F20 VA: 0x1814D7920
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x14D7D00 Offset: 0x14D6300 VA: 0x1814D7D00
	private X509Store get_LMRootStore() { }

	// RVA: 0x14D7F70 Offset: 0x14D6570 VA: 0x1814D7F70
	private X509Store get_UserRootStore() { }

	// RVA: 0x14D7C40 Offset: 0x14D6240 VA: 0x1814D7C40
	private X509Store get_LMCAStore() { }

	// RVA: 0x14D7EB0 Offset: 0x14D64B0 VA: 0x1814D7EB0
	private X509Store get_UserCAStore() { }

	// RVA: 0x14D7A10 Offset: 0x14D6010 VA: 0x1814D7A10
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x14D49B0 Offset: 0x14D2FB0 VA: 0x1814D49B0
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x14D71E0 Offset: 0x14D57E0 VA: 0x1814D71E0
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x14D5CF0 Offset: 0x14D42F0 VA: 0x1814D5CF0
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x14D6230 Offset: 0x14D4830 VA: 0x1814D6230
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x14D6350 Offset: 0x14D4950 VA: 0x1814D6350
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x14D7440 Offset: 0x14D5A40 VA: 0x1814D7440
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D6C60 Offset: 0x14D5260 VA: 0x1814D6C60
	private void Process(int n) { }

	// RVA: 0x14D63F0 Offset: 0x14D49F0 VA: 0x1814D63F0
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x14D76E0 Offset: 0x14D5CE0 VA: 0x1814D76E0
	private void WrapUp() { }

	// RVA: 0x14D6660 Offset: 0x14D4C60 VA: 0x1814D6660
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x14D63A0 Offset: 0x14D49A0 VA: 0x1814D63A0
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x14D6120 Offset: 0x14D4720 VA: 0x1814D6120
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D5EB0 Offset: 0x14D44B0 VA: 0x1814D5EB0
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D5F40 Offset: 0x14D4540 VA: 0x1814D5F40
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x14D5FC0 Offset: 0x14D45C0 VA: 0x1814D5FC0
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x14D5510 Offset: 0x14D3B10 VA: 0x1814D5510
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D59E0 Offset: 0x14D3FE0 VA: 0x1814D59E0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x14D5770 Offset: 0x14D3D70 VA: 0x1814D5770
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x14D5250 Offset: 0x14D3850 VA: 0x1814D5250
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x14D5B20 Offset: 0x14D4120 VA: 0x1814D5B20
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x14D6A50 Offset: 0x14D5050 VA: 0x1814D6A50
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x14D6860 Offset: 0x14D4E60 VA: 0x1814D6860
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x14D77D0 Offset: 0x14D5DD0 VA: 0x1814D77D0
	private static void .cctor() { }

}

