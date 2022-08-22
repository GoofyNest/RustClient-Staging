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

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Close() { }

	// RVA: 0x118F4F0 Offset: 0x118DAF0 VA: 0x18118F4F0 Slot: 7
	public void Dispose() { }

	// RVA: 0x118F560 Offset: 0x118DB60 VA: 0x18118F560 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x118F610 Offset: 0x118DC10 VA: 0x18118F610 Slot: 11
	public virtual long get_ContentLength() { }

	// RVA: 0x118F5D0 Offset: 0x118DBD0 VA: 0x18118F5D0 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x118F690 Offset: 0x118DC90 VA: 0x18118F690 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x118F650 Offset: 0x118DC50 VA: 0x18118F650 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }

}

