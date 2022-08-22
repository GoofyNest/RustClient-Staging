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

	// RVA: 0x1216150 Offset: 0x1214750 VA: 0x181216150
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1216060 Offset: 0x1214660 VA: 0x181216060
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x1216A60 Offset: 0x1215060 VA: 0x181216A60
	private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0x1216110 Offset: 0x1214710 VA: 0x181216110
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x12161F0 Offset: 0x12147F0 VA: 0x1812161F0 Slot: 6
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x1216250 Offset: 0x1214850 VA: 0x181216250 Slot: 7
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

	// RVA: 0x1216370 Offset: 0x1214970 VA: 0x181216370 Slot: 4
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1216470 Offset: 0x1214A70 VA: 0x181216470
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1216560 Offset: 0x1214B60 VA: 0x181216560
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

