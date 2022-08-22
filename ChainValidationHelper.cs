internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator // TypeDefIndex: 2543
{	// Fields
	private readonly object sender; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MonoTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; // 0x38
	private readonly MonoTlsStream tlsStream; // 0x40
	private readonly HttpWebRequest request; // 0x48

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x12167F0 Offset: 0x1214DF0 VA: 0x1812167F0
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1216700 Offset: 0x1214D00 VA: 0x181216700
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x1217100 Offset: 0x1215700 VA: 0x181217100
	private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0x12167B0 Offset: 0x1214DB0 VA: 0x1812167B0
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x1216890 Offset: 0x1214E90 VA: 0x181216890 Slot: 6
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x12168F0 Offset: 0x1214EF0 VA: 0x1812168F0 Slot: 7
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

	// RVA: 0x1216A10 Offset: 0x1215010 VA: 0x181216A10 Slot: 4
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1216B10 Offset: 0x1215110 VA: 0x181216B10
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1216C00 Offset: 0x1215200 VA: 0x181216C00
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

