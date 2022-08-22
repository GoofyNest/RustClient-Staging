internal static class X509Helper // TypeDefIndex: 1020
{	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x13F00

	// Methods

	// RVA: 0x17CCF60 Offset: 0x17CB560 VA: 0x1817CCF60
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x17CCC30 Offset: 0x17CB230 VA: 0x1817CCC30
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x17CCE30 Offset: 0x17CB430 VA: 0x1817CCE30
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x17CCD20 Offset: 0x17CB320 VA: 0x1817CCD20
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x14DB880 Offset: 0x14D9E80 VA: 0x1814DB880
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x17CD0C0 Offset: 0x17CB6C0 VA: 0x1817CD0C0
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x17CC710 Offset: 0x17CAD10 VA: 0x1817CC710
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x17CC870 Offset: 0x17CAE70 VA: 0x1817CC870
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x17CCFB0 Offset: 0x17CB5B0 VA: 0x1817CCFB0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x17CC560 Offset: 0x17CAB60 VA: 0x1817CC560
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x17CC780 Offset: 0x17CAD80 VA: 0x1817CC780
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x17CCC40 Offset: 0x17CB240 VA: 0x1817CCC40
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x17CD120 Offset: 0x17CB720 VA: 0x1817CD120
	public static string ToHexString(byte[] data) { }

}

