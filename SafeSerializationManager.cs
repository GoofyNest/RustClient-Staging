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

	// RVA: 0x12A55D0 Offset: 0x12A3BD0 VA: 0x1812A55D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A5790 Offset: 0x12A3D90 VA: 0x1812A5790
	internal bool get_IsActive() { }

	// RVA: 0x12A4E70 Offset: 0x12A3470 VA: 0x1812A4E70
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A4B60 Offset: 0x12A3160 VA: 0x1812A4B60
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x12A5490 Offset: 0x12A3A90 VA: 0x1812A5490 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A5190 Offset: 0x12A3790 VA: 0x1812A5190 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12A50D0 Offset: 0x12A36D0 VA: 0x1812A50D0
	private void OnDeserialized(StreamingContext context) { }

}

