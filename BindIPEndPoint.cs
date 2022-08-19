public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 2989
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151F970 Offset: 0x151DF70 VA: 0x18151F970 Slot: 12
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	// RVA: 0x151F8E0 Offset: 0x151DEE0 VA: 0x18151F8E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }

}

