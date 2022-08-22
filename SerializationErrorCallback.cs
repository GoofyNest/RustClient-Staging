public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 6008
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17FEA10 Offset: 0x17FD010 VA: 0x1817FEA10 Slot: 12
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x17FE980 Offset: 0x17FCF80 VA: 0x1817FE980 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

