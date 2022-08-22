internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 2551
{	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x1219CC0 Offset: 0x12182C0 VA: 0x181219CC0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x1219E30 Offset: 0x1218430 VA: 0x181219E30
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_IsServer() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected string get_TargetHost() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	protected string get_ServerName() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown();

	// RVA: 0x1219AB0 Offset: 0x12180B0 VA: 0x181219AB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1219BC0 Offset: 0x12181C0 VA: 0x181219BC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x1219930 Offset: 0x1217F30 VA: 0x181219930
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1219820 Offset: 0x1217E20 VA: 0x181219820 Slot: 4
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1219890 Offset: 0x1217E90 VA: 0x181219890 Slot: 1
	protected override void Finalize() { }

}

