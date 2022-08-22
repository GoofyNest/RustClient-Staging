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

	// RVA: 0x12203A0 Offset: 0x121E9A0 VA: 0x1812203A0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x121EAF0 Offset: 0x121D0F0 VA: 0x18121EAF0
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x808600 Offset: 0x806C00 VA: 0x180808600 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x121F650 Offset: 0x121DC50 VA: 0x18121F650 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x12201B0 Offset: 0x121E7B0 VA: 0x1812201B0 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x121F840 Offset: 0x121DE40 VA: 0x18121F840 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x121E9B0 Offset: 0x121CFB0 VA: 0x18121E9B0 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x121F950 Offset: 0x121DF50 VA: 0x18121F950 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x121EEE0 Offset: 0x121D4E0 VA: 0x18121EEE0 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x121EDA0 Offset: 0x121D3A0 VA: 0x18121EDA0 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F9D0 Offset: 0x9EDD0 VA: 0x18009F9D0
	// RVA: 0x121FE90 Offset: 0x121E490 VA: 0x18121FE90
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121FFB0 Offset: 0x121E5B0 VA: 0x18121FFB0
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FAF0 Offset: 0x9EEF0 VA: 0x18009FAF0
	// RVA: 0x121F2B0 Offset: 0x121D8B0 VA: 0x18121F2B0
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121F3D0 Offset: 0x121D9D0 VA: 0x18121F3D0
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9FB70 Offset: 0x9EF70 VA: 0x18009FB70
	// RVA: 0x121FBC0 Offset: 0x121E1C0 VA: 0x18121FBC0
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121FCD0 Offset: 0x121E2D0 VA: 0x18121FCD0
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xA1000 Offset: 0xA0400 VA: 0x1800A1000
	// RVA: 0x121E470 Offset: 0x121CA70 VA: 0x18121E470
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121E5E0 Offset: 0x121CBE0 VA: 0x18121E5E0
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

