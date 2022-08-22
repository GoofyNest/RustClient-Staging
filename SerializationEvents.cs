internal class SerializationEvents // TypeDefIndex: 1054
{	// Fields
	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x12A6AE0 Offset: 0x12A50E0 VA: 0x1812A6AE0
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x12A73A0 Offset: 0x12A59A0 VA: 0x1812A73A0
	internal void .ctor(Type t) { }

	// RVA: 0x12A74D0 Offset: 0x12A5AD0 VA: 0x1812A74D0
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x12A7150 Offset: 0x12A5750 VA: 0x1812A7150
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x12A6F00 Offset: 0x12A5500 VA: 0x1812A6F00
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x12A6CB0 Offset: 0x12A52B0 VA: 0x1812A6CB0
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x12A68A0 Offset: 0x12A4EA0 VA: 0x1812A68A0
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x12A6660 Offset: 0x12A4C60 VA: 0x1812A6660
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

}

