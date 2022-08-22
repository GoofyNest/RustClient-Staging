internal class SerializationEvents // TypeDefIndex: 1054
{	// Fields
	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x12A6440 Offset: 0x12A4A40 VA: 0x1812A6440
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x12A6D00 Offset: 0x12A5300 VA: 0x1812A6D00
	internal void .ctor(Type t) { }

	// RVA: 0x12A6E30 Offset: 0x12A5430 VA: 0x1812A6E30
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x12A6AB0 Offset: 0x12A50B0 VA: 0x1812A6AB0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x12A6860 Offset: 0x12A4E60 VA: 0x1812A6860
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x12A6610 Offset: 0x12A4C10 VA: 0x1812A6610
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x12A6200 Offset: 0x12A4800 VA: 0x1812A6200
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x12A5FC0 Offset: 0x12A45C0 VA: 0x1812A5FC0
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

}

