internal static class CallbackHelpers // TypeDefIndex: 2556
{	// Methods

	// RVA: 0x1215A90 Offset: 0x1214090 VA: 0x181215A90
	internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

	// RVA: 0x12159D0 Offset: 0x1213FD0 VA: 0x1812159D0
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass5_0 // TypeDefIndex: 2557
{	// Fields
	public MonoRemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E350 Offset: 0x121C950 VA: 0x18121E350
	internal bool <MonoToPublic>b__0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass8_0 // TypeDefIndex: 2558
{	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E3E0 Offset: 0x121C9E0 VA: 0x18121E3E0
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

