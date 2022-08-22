internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0xD71B80 Offset: 0xD70180 VA: 0x180D71B80
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD71910 Offset: 0xD6FF10 VA: 0x180D71910
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD71B30 Offset: 0xD70130 VA: 0x180D71B30 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 5
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

	// RVA: 0xD71720 Offset: 0xD6FD20 VA: 0x180D71720
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0xD71380 Offset: 0xD6F980 VA: 0x180D71380
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

