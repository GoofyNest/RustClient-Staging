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

	// RVA: 0x118CF60 Offset: 0x118B560 VA: 0x18118CF60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Close() { }

	// RVA: 0x118F230 Offset: 0x118D830 VA: 0x18118F230 Slot: 7
	public void Dispose() { }

	// RVA: 0x118F2A0 Offset: 0x118D8A0 VA: 0x18118F2A0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x118F350 Offset: 0x118D950 VA: 0x18118F350 Slot: 11
	public virtual long get_ContentLength() { }

	// RVA: 0x118F310 Offset: 0x118D910 VA: 0x18118F310 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x118F3D0 Offset: 0x118D9D0 VA: 0x18118F3D0 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x118F390 Offset: 0x118D990 VA: 0x18118F390 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }

}

