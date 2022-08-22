public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 2891
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2B20 Offset: 0xDE1120 VA: 0x180DE2B20 Slot: 12
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0x133BD30 Offset: 0x133A330 VA: 0x18133BD30 Slot: 13
	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

