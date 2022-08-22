internal static class X509Helper2 // TypeDefIndex: 2834
{	// Methods

	// RVA: 0x14DB830 Offset: 0x14D9E30 VA: 0x1814DB830
	internal static void Initialize() { }

	// RVA: 0x14DB900 Offset: 0x14D9F00 VA: 0x1814DB900
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x14DB790 Offset: 0x14D9D90 VA: 0x1814DB790
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x14DB600 Offset: 0x14D9C00 VA: 0x1814DB600
	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	[MonoTODOAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	// RVA: 0x14DB520 Offset: 0x14D9B20 VA: 0x1814DB520
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x14DB380 Offset: 0x14D9980 VA: 0x1814DB380
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x14DB880 Offset: 0x14D9E80 VA: 0x1814DB880
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x14DB8A0 Offset: 0x14D9EA0 VA: 0x1814DB8A0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x14DB4B0 Offset: 0x14D9AB0 VA: 0x1814DB4B0
	internal static Exception GetInvalidChainContextException() { }

}

private class X509Helper2.MyNativeHelper : INativeCertificateHelper // TypeDefIndex: 2835
{	// Methods

	// RVA: 0x14C1BB0 Offset: 0x14C01B0 VA: 0x1814C1BB0 Slot: 4
	public X509CertificateImpl Import(X509Certificate cert) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

