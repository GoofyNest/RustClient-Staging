public sealed class UnreferencedObjectEventHandler : MulticastDelegate // TypeDefIndex: 2052
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, UnreferencedObjectEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

