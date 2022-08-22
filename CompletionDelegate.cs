internal sealed class CompletionDelegate : MulticastDelegate // TypeDefIndex: 2957
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428D40 Offset: 0x1427340 VA: 0x181428D40 Slot: 12
	public virtual void Invoke(byte[] responseBytes, Exception exception, object State) { }

	// RVA: 0x12C39E0 Offset: 0x12C1FE0 VA: 0x1812C39E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] responseBytes, Exception exception, object State, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

