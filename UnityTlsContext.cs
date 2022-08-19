internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 2509
{	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x12200E0 Offset: 0x121E6E0 VA: 0x1812200E0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x121E830 Offset: 0x121CE30 VA: 0x18121E830
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x8084F0 Offset: 0x806AF0 VA: 0x1808084F0 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x121F390 Offset: 0x121D990 VA: 0x18121F390 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x121FEF0 Offset: 0x121E4F0 VA: 0x18121FEF0 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x121F580 Offset: 0x121DB80 VA: 0x18121F580 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x121E6F0 Offset: 0x121CCF0 VA: 0x18121E6F0 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x121F690 Offset: 0x121DC90 VA: 0x18121F690 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x121EC20 Offset: 0x121D220 VA: 0x18121EC20 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x121EAE0 Offset: 0x121D0E0 VA: 0x18121EAE0 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F990 Offset: 0x9ED90 VA: 0x18009F990
	// RVA: 0x121FBD0 Offset: 0x121E1D0 VA: 0x18121FBD0
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121FCF0 Offset: 0x121E2F0 VA: 0x18121FCF0
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FA60 Offset: 0x9EE60 VA: 0x18009FA60
	// RVA: 0x121EFF0 Offset: 0x121D5F0 VA: 0x18121EFF0
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121F110 Offset: 0x121D710 VA: 0x18121F110
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FB50 Offset: 0x9EF50 VA: 0x18009FB50
	// RVA: 0x121F900 Offset: 0x121DF00 VA: 0x18121F900
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121FA10 Offset: 0x121E010 VA: 0x18121FA10
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xA0F70 Offset: 0xA0370 VA: 0x1800A0F70
	// RVA: 0x121E1B0 Offset: 0x121C7B0 VA: 0x18121E1B0
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121E320 Offset: 0x121C920 VA: 0x18121E320
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

