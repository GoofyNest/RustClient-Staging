public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 387
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFEBB30 Offset: 0xFEA130 VA: 0x180FEBB30 Slot: 12
	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual Assembly EndInvoke(IAsyncResult result) { }

}

