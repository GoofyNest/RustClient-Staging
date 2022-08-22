public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 2911
{	// Properties
	public virtual long ContentLength { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1191B40 Offset: 0x1190140 VA: 0x181191B40 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Close() { }

	// RVA: 0x1193E10 Offset: 0x1192410 VA: 0x181193E10 Slot: 7
	public void Dispose() { }

	// RVA: 0x1193E80 Offset: 0x1192480 VA: 0x181193E80 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1193F30 Offset: 0x1192530 VA: 0x181193F30 Slot: 11
	public virtual long get_ContentLength() { }

	// RVA: 0x1193EF0 Offset: 0x11924F0 VA: 0x181193EF0 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1193FB0 Offset: 0x11925B0 VA: 0x181193FB0 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1193F70 Offset: 0x1192570 VA: 0x181193F70 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }

}

