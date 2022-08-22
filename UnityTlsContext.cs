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

	// RVA: 0x1220A40 Offset: 0x121F040 VA: 0x181220A40
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x121F190 Offset: 0x121D790 VA: 0x18121F190
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x808B90 Offset: 0x807190 VA: 0x180808B90 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x121FCF0 Offset: 0x121E2F0 VA: 0x18121FCF0 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1220850 Offset: 0x121EE50 VA: 0x181220850 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x121FEE0 Offset: 0x121E4E0 VA: 0x18121FEE0 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x121F050 Offset: 0x121D650 VA: 0x18121F050 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x121FFF0 Offset: 0x121E5F0 VA: 0x18121FFF0 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x121F580 Offset: 0x121DB80 VA: 0x18121F580 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x121F440 Offset: 0x121DA40 VA: 0x18121F440 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F9D0 Offset: 0x9EDD0 VA: 0x18009F9D0
	// RVA: 0x1220530 Offset: 0x121EB30 VA: 0x181220530
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1220650 Offset: 0x121EC50 VA: 0x181220650
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FAF0 Offset: 0x9EEF0 VA: 0x18009FAF0
	// RVA: 0x121F950 Offset: 0x121DF50 VA: 0x18121F950
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121FA70 Offset: 0x121E070 VA: 0x18121FA70
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FB70 Offset: 0x9EF70 VA: 0x18009FB70
	// RVA: 0x1220260 Offset: 0x121E860 VA: 0x181220260
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1220370 Offset: 0x121E970 VA: 0x181220370
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xA1000 Offset: 0xA0400 VA: 0x1800A1000
	// RVA: 0x121EB10 Offset: 0x121D110 VA: 0x18121EB10
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121EC80 Offset: 0x121D280 VA: 0x18121EC80
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

