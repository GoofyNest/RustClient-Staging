public sealed class SerializationObjectManager // TypeDefIndex: 1061
{	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x12AAA10 Offset: 0x12A9010 VA: 0x1812AAA10
	public void .ctor(StreamingContext context) { }

	// RVA: 0x12AA860 Offset: 0x12A8E60 VA: 0x1812AA860
	public void RegisterObject(object obj) { }

	// RVA: 0x12AA830 Offset: 0x12A8E30 VA: 0x1812AA830
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x12AA780 Offset: 0x12A8D80 VA: 0x1812AA780
	private void AddOnSerialized(object obj) { }

}

