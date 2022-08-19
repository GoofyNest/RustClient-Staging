internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 536
{	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x18CB430 Offset: 0x18C9A30 VA: 0x1818CB430
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x18CB460 Offset: 0x18C9A60 VA: 0x1818CB460
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x18CB6B0 Offset: 0x18C9CB0 VA: 0x1818CB6B0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CA4D0 Offset: 0x18C8AD0 VA: 0x1818CA4D0 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CA540 Offset: 0x18C8B40 VA: 0x1818CA540 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}
