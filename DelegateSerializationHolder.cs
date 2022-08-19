internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0xD70E10 Offset: 0xD6F410 VA: 0x180D70E10
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD70BA0 Offset: 0xD6F1A0 VA: 0x180D70BA0
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD70DC0 Offset: 0xD6F3C0 VA: 0x180D70DC0 Slot: 4
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

	// RVA: 0xD709B0 Offset: 0xD6EFB0 VA: 0x180D709B0
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0xD70610 Offset: 0xD6EC10 VA: 0x180D70610
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

