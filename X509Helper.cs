internal static class X509Helper // TypeDefIndex: 1020
{	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x13F00

	// Methods

	// RVA: 0x17CCCA0 Offset: 0x17CB2A0 VA: 0x1817CCCA0
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x17CC970 Offset: 0x17CAF70 VA: 0x1817CC970
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x17CCB70 Offset: 0x17CB170 VA: 0x1817CCB70
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x17CCA60 Offset: 0x17CB060 VA: 0x1817CCA60
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x14DB5C0 Offset: 0x14D9BC0 VA: 0x1814DB5C0
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x17CCE00 Offset: 0x17CB400 VA: 0x1817CCE00
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x17CC450 Offset: 0x17CAA50 VA: 0x1817CC450
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x17CC5B0 Offset: 0x17CABB0 VA: 0x1817CC5B0
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x17CCCF0 Offset: 0x17CB2F0 VA: 0x1817CCCF0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x17CC2A0 Offset: 0x17CA8A0 VA: 0x1817CC2A0
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x17CC4C0 Offset: 0x17CAAC0 VA: 0x1817CC4C0
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x17CC980 Offset: 0x17CAF80 VA: 0x1817CC980
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x17CCE60 Offset: 0x17CB460 VA: 0x1817CCE60
	public static string ToHexString(byte[] data) { }

}

