internal static class X509Helper2 // TypeDefIndex: 2834
{	// Methods

	// RVA: 0x14DA900 Offset: 0x14D8F00 VA: 0x1814DA900
	internal static void Initialize() { }

	// RVA: 0x14DA9D0 Offset: 0x14D8FD0 VA: 0x1814DA9D0
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x14DA860 Offset: 0x14D8E60 VA: 0x1814DA860
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x14DA6D0 Offset: 0x14D8CD0 VA: 0x1814DA6D0
	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	[MonoTODOAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	// RVA: 0x14DA5F0 Offset: 0x14D8BF0 VA: 0x1814DA5F0
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x14DA450 Offset: 0x14D8A50 VA: 0x1814DA450
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x14DA950 Offset: 0x14D8F50 VA: 0x1814DA950
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x14DA970 Offset: 0x14D8F70 VA: 0x1814DA970
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x14DA580 Offset: 0x14D8B80 VA: 0x1814DA580
	internal static Exception GetInvalidChainContextException() { }

}

private class X509Helper2.MyNativeHelper : INativeCertificateHelper // TypeDefIndex: 2835
{	// Methods

	// RVA: 0x14C0C80 Offset: 0x14BF280 VA: 0x1814C0C80 Slot: 4
	public X509CertificateImpl Import(X509Certificate cert) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

