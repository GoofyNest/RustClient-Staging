internal sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 1024
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12A5EF0 Offset: 0x12A44F0 VA: 0x1812A5EF0 Slot: 12
	public virtual void Invoke(StreamingContext context) { }

	// RVA: 0x12A5E70 Offset: 0x12A4470 VA: 0x1812A5E70 Slot: 13
	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

