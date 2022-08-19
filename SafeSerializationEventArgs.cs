public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1045
{	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x12A47F0 Offset: 0x12A2DF0 VA: 0x1812A47F0
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal IList<object> get_SerializedStates() { }

}

