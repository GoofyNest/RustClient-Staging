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

	// RVA: 0x15D86D0 Offset: 0x15D6CD0 VA: 0x1815D86D0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x15D8660 Offset: 0x15D6C60 VA: 0x1815D8660 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x15D8700 Offset: 0x15D6D00 VA: 0x1815D8700 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x15D8020 Offset: 0x15D6620 VA: 0x1815D8020 Slot: 10
	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15D7F40 Offset: 0x15D6540 VA: 0x1815D7F40 Slot: 11
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15D8040 Offset: 0x15D6640 VA: 0x1815D8040 Slot: 12
	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

