internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 2512
{	// Methods

	// RVA: 0x15D87D0 Offset: 0x15D6DD0 VA: 0x1815D87D0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0x15D8710 Offset: 0x15D6D10 VA: 0x1815D8710 Slot: 52
	protected override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

}

