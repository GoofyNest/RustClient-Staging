internal static class CallbackHelpers // TypeDefIndex: 2556
{	// Methods

	// RVA: 0x1216130 Offset: 0x1214730 VA: 0x181216130
	internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

	// RVA: 0x1216070 Offset: 0x1214670 VA: 0x181216070
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass5_0 // TypeDefIndex: 2557
{	// Fields
	public MonoRemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E9F0 Offset: 0x121CFF0 VA: 0x18121E9F0
	internal bool <MonoToPublic>b__0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass8_0 // TypeDefIndex: 2558
{	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121EA80 Offset: 0x121D080 VA: 0x18121EA80
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

