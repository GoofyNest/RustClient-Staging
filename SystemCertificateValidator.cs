internal static class SystemCertificateValidator // TypeDefIndex: 2555
{	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x121BFF0 Offset: 0x121A5F0 VA: 0x18121BFF0
	private static void .cctor() { }

	// RVA: 0x121BF10 Offset: 0x121A510 VA: 0x18121BF10
	public static X509Chain CreateX509Chain(X509CertificateCollection certs) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

