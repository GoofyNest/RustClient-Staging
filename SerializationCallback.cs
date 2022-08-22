public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 6007
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1810FF0 Offset: 0x180F5F0 VA: 0x181810FF0 Slot: 12
	public virtual void Invoke(object o, StreamingContext context) { }

	// RVA: 0x1810F60 Offset: 0x180F560 VA: 0x181810F60 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

