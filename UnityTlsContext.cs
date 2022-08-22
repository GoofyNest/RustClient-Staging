internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 2509
{	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
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

	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }


	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	public override bool get_IsAuthenticated() { }

	internal override X509Certificate get_LocalClientCertificate() { }

	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	public override void Shutdown() { }

	protected override void Dispose(bool disposing) { }

	public override void StartHandshake() { }

	public override bool ProcessHandshake() { }

	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F9D0 Offset: 0x9EDD0 VA: 0x18009F9D0
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FAF0 Offset: 0x9EEF0 VA: 0x18009FAF0
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FB70 Offset: 0x9EF70 VA: 0x18009FB70
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xA1000 Offset: 0xA0400 VA: 0x1800A1000
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

