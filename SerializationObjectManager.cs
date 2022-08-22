public sealed class SerializationObjectManager // TypeDefIndex: 1061
{	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x12AA370 Offset: 0x12A8970 VA: 0x1812AA370
	public void .ctor(StreamingContext context) { }

	// RVA: 0x12AA1C0 Offset: 0x12A87C0 VA: 0x1812AA1C0
	public void RegisterObject(object obj) { }

	// RVA: 0x12AA190 Offset: 0x12A8790 VA: 0x1812AA190
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x12AA0E0 Offset: 0x12A86E0 VA: 0x1812AA0E0
	private void AddOnSerialized(object obj) { }

}

