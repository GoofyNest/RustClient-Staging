internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0xD710D0 Offset: 0xD6F6D0 VA: 0x180D710D0
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD70E60 Offset: 0xD6F460 VA: 0x180D70E60
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD71080 Offset: 0xD6F680 VA: 0x180D71080 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public object GetRealObject(StreamingContext context) { }

}

private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 358
{	// Fields
	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40

	// Methods

	// RVA: 0xD70C70 Offset: 0xD6F270 VA: 0x180D70C70
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0xD708D0 Offset: 0xD6EED0 VA: 0x180D708D0
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

