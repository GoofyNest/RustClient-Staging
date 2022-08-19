internal class SerializationEvents // TypeDefIndex: 1054
{	// Fields
	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x12A6180 Offset: 0x12A4780 VA: 0x1812A6180
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x12A6A40 Offset: 0x12A5040 VA: 0x1812A6A40
	internal void .ctor(Type t) { }

	// RVA: 0x12A6B70 Offset: 0x12A5170 VA: 0x1812A6B70
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x12A67F0 Offset: 0x12A4DF0 VA: 0x1812A67F0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x12A65A0 Offset: 0x12A4BA0 VA: 0x1812A65A0
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x12A6350 Offset: 0x12A4950 VA: 0x1812A6350
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x12A5F40 Offset: 0x12A4540 VA: 0x1812A5F40
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x12A5D00 Offset: 0x12A4300 VA: 0x1812A5D00
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

}

