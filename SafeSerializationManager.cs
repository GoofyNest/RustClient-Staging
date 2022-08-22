internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1047
{	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x12A5C70 Offset: 0x12A4270 VA: 0x1812A5C70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A5E30 Offset: 0x12A4430 VA: 0x1812A5E30
	internal bool get_IsActive() { }

	// RVA: 0x12A5510 Offset: 0x12A3B10 VA: 0x1812A5510
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A5200 Offset: 0x12A3800 VA: 0x1812A5200
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x12A5B30 Offset: 0x12A4130 VA: 0x1812A5B30 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A5830 Offset: 0x12A3E30 VA: 0x1812A5830 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12A5770 Offset: 0x12A3D70 VA: 0x1812A5770
	private void OnDeserialized(StreamingContext context) { }

}

