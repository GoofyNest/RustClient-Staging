internal sealed class CompletionDelegate : MulticastDelegate // TypeDefIndex: 2957
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1429C60 Offset: 0x1428260 VA: 0x181429C60 Slot: 12
	public virtual void Invoke(byte[] responseBytes, Exception exception, object State) { }

	// RVA: 0x130FC60 Offset: 0x130E260 VA: 0x18130FC60 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] responseBytes, Exception exception, object State, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

