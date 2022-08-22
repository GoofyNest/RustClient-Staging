internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 3071
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFA0F0 Offset: 0xFF86F0 VA: 0x180FFA0F0 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFFA0A0 Offset: 0xFF86A0 VA: 0x180FFA0A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

