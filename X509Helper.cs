internal static class X509Helper // TypeDefIndex: 1020
{	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x2B10360

	// Methods

	// RVA: 0x17CAAB0 Offset: 0x17C90B0 VA: 0x1817CAAB0
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x17CA780 Offset: 0x17C8D80 VA: 0x1817CA780
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x17CA980 Offset: 0x17C8F80 VA: 0x1817CA980
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x17CA870 Offset: 0x17C8E70 VA: 0x1817CA870
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x14DA950 Offset: 0x14D8F50 VA: 0x1814DA950
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x17CAC10 Offset: 0x17C9210 VA: 0x1817CAC10
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x17CA260 Offset: 0x17C8860 VA: 0x1817CA260
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x17CA3C0 Offset: 0x17C89C0 VA: 0x1817CA3C0
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x17CAB00 Offset: 0x17C9100 VA: 0x1817CAB00
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x17CA0B0 Offset: 0x17C86B0 VA: 0x1817CA0B0
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x17CA2D0 Offset: 0x17C88D0 VA: 0x1817CA2D0
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x17CA790 Offset: 0x17C8D90 VA: 0x1817CA790
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x17CAC70 Offset: 0x17C9270 VA: 0x1817CAC70
	public static string ToHexString(byte[] data) { }

}

