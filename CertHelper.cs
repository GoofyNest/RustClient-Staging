internal static class CertHelper // TypeDefIndex: 2455
{	// Methods

	// RVA: 0x1215D10 Offset: 0x1214310 VA: 0x181215D10
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1215B50 Offset: 0x1214150 VA: 0x181215B50
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1215E40 Offset: 0x1214440 VA: 0x181215E40
	public static X509CertificateCollection NativeChainToManagedCollection(UnityTls.unitytls_x509list_ref nativeCertificateChain, UnityTls.unitytls_errorstate* errorState) { }

}

