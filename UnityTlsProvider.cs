internal class UnityTlsProvider : MonoTlsProvider // TypeDefIndex: 2511
{	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x15D7A60 Offset: 0x15D6060 VA: 0x1815D7A60 Slot: 5
	public override string get_Name() { }

	// RVA: 0x15D79F0 Offset: 0x15D5FF0 VA: 0x1815D79F0 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x15D7A90 Offset: 0x15D6090 VA: 0x1815D7A90 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x15D73B0 Offset: 0x15D59B0 VA: 0x1815D73B0 Slot: 10
	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15D72D0 Offset: 0x15D58D0 VA: 0x1815D72D0 Slot: 11
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15D73D0 Offset: 0x15D59D0 VA: 0x1815D73D0 Slot: 12
	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

