internal class SerializationEvents // TypeDefIndex: 1054
{	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	internal bool HasOnSerializingEvents { get; }


	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	internal void .ctor(Type t) { }

	internal bool get_HasOnSerializingEvents() { }

	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

}

