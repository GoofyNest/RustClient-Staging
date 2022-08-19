public sealed class SerializationObjectManager // TypeDefIndex: 1061
{	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x12AA0B0 Offset: 0x12A86B0 VA: 0x1812AA0B0
	public void .ctor(StreamingContext context) { }

	// RVA: 0x12A9F00 Offset: 0x12A8500 VA: 0x1812A9F00
	public void RegisterObject(object obj) { }

	// RVA: 0x12A9ED0 Offset: 0x12A84D0 VA: 0x1812A9ED0
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x12A9E20 Offset: 0x12A8420 VA: 0x1812A9E20
	private void AddOnSerialized(object obj) { }

}

