internal static class CertHelper // TypeDefIndex: 2455
{	// Methods

	// RVA: 0x12163B0 Offset: 0x12149B0 VA: 0x1812163B0
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12161F0 Offset: 0x12147F0 VA: 0x1812161F0
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12164E0 Offset: 0x1214AE0 VA: 0x1812164E0
	public static X509CertificateCollection NativeChainToManagedCollection(UnityTls.unitytls_x509list_ref nativeCertificateChain, UnityTls.unitytls_errorstate* errorState) { }

}

