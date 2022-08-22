internal static class UnityTlsConversions // TypeDefIndex: 2510
{	// Methods

	// RVA: 0x15D7B30 Offset: 0x15D6130 VA: 0x1815D7B30
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x15D79E0 Offset: 0x15D5FE0 VA: 0x1815D79E0
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x15D79B0 Offset: 0x15D5FB0 VA: 0x1815D79B0
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x15D7C80 Offset: 0x15D6280 VA: 0x1815D7C80
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x15D8140 Offset: 0x15D6740 VA: 0x1815D8140
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

}

