internal static class UnityTlsConversions // TypeDefIndex: 2510
{	// Methods

	// RVA: 0x15D6C00 Offset: 0x15D5200 VA: 0x1815D6C00
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x15D6AB0 Offset: 0x15D50B0 VA: 0x1815D6AB0
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x15D6A80 Offset: 0x15D5080 VA: 0x1815D6A80
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x15D6D50 Offset: 0x15D5350 VA: 0x1815D6D50
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x15D7210 Offset: 0x15D5810 VA: 0x1815D7210
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

}

