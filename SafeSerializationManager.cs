internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1047
{	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x12A5310 Offset: 0x12A3910 VA: 0x1812A5310
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A54D0 Offset: 0x12A3AD0 VA: 0x1812A54D0
	internal bool get_IsActive() { }

	// RVA: 0x12A4BB0 Offset: 0x12A31B0 VA: 0x1812A4BB0
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A48A0 Offset: 0x12A2EA0 VA: 0x1812A48A0
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x12A51D0 Offset: 0x12A37D0 VA: 0x1812A51D0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A4ED0 Offset: 0x12A34D0 VA: 0x1812A4ED0 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x12A4E10 Offset: 0x12A3410 VA: 0x1812A4E10
	private void OnDeserialized(StreamingContext context) { }

}

