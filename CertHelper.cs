internal static class CertHelper // TypeDefIndex: 2455
{	// Methods

	// RVA: 0x1215A50 Offset: 0x1214050 VA: 0x181215A50
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1215890 Offset: 0x1213E90 VA: 0x181215890
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1215B80 Offset: 0x1214180 VA: 0x181215B80
	public static X509CertificateCollection NativeChainToManagedCollection(UnityTls.unitytls_x509list_ref nativeCertificateChain, UnityTls.unitytls_errorstate* errorState) { }

}

