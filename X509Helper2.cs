internal static class X509Helper2 // TypeDefIndex: 2834
{	// Methods

	// RVA: 0x14DB570 Offset: 0x14D9B70 VA: 0x1814DB570
	internal static void Initialize() { }

	// RVA: 0x14DB640 Offset: 0x14D9C40 VA: 0x1814DB640
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x14DB4D0 Offset: 0x14D9AD0 VA: 0x1814DB4D0
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x14DB340 Offset: 0x14D9940 VA: 0x1814DB340
	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	[MonoTODOAttribute] // RVA: 0xB08E0 Offset: 0xAFCE0 VA: 0x1800B08E0
	// RVA: 0x14DB260 Offset: 0x14D9860 VA: 0x1814DB260
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x14DB0C0 Offset: 0x14D96C0 VA: 0x1814DB0C0
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x14DB5C0 Offset: 0x14D9BC0 VA: 0x1814DB5C0
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x14DB5E0 Offset: 0x14D9BE0 VA: 0x1814DB5E0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x14DB1F0 Offset: 0x14D97F0 VA: 0x1814DB1F0
	internal static Exception GetInvalidChainContextException() { }

}

private class X509Helper2.MyNativeHelper : INativeCertificateHelper // TypeDefIndex: 2835
{	// Methods

	// RVA: 0x14C18F0 Offset: 0x14BFEF0 VA: 0x1814C18F0 Slot: 4
	public X509CertificateImpl Import(X509Certificate cert) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

