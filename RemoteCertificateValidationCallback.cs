public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 3069
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFB8F0 Offset: 0xFF9EF0 VA: 0x180FFB8F0 Slot: 12
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFFB850 Offset: 0xFF9E50 VA: 0x180FFB850 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

