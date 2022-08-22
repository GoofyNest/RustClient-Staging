public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 6008
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18115D0 Offset: 0x180FBD0 VA: 0x1818115D0 Slot: 12
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x1811540 Offset: 0x180FB40 VA: 0x181811540 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

