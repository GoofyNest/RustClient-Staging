internal static class UnityTlsConversions // TypeDefIndex: 2510
{	// Methods

	// RVA: 0x15D7870 Offset: 0x15D5E70 VA: 0x1815D7870
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x15D7720 Offset: 0x15D5D20 VA: 0x1815D7720
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x15D76F0 Offset: 0x15D5CF0 VA: 0x1815D76F0
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x15D79C0 Offset: 0x15D5FC0 VA: 0x1815D79C0
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x15D7E80 Offset: 0x15D6480 VA: 0x1815D7E80
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

}

