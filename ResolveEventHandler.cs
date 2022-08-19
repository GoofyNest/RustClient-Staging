public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 387
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFEB870 Offset: 0xFE9E70 VA: 0x180FEB870 Slot: 12
	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual Assembly EndInvoke(IAsyncResult result) { }

}

