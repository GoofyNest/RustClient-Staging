public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 3069
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFC390 Offset: 0xFFA990 VA: 0x180FFC390 Slot: 12
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFFC2F0 Offset: 0xFFA8F0 VA: 0x180FFC2F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

