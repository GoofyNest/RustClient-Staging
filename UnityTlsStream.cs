internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 2512
{	// Methods

	// RVA: 0x15D7B60 Offset: 0x15D6160 VA: 0x1815D7B60
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0x15D7AA0 Offset: 0x15D60A0 VA: 0x1815D7AA0 Slot: 52
	protected override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

}

