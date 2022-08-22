internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 536
{	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x18CB3F0 Offset: 0x18C99F0 VA: 0x1818CB3F0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x18CB420 Offset: 0x18C9A20 VA: 0x1818CB420
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x18CB670 Offset: 0x18C9C70 VA: 0x1818CB670
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CA490 Offset: 0x18C8A90 VA: 0x1818CA490 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CA500 Offset: 0x18C8B00 VA: 0x1818CA500 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

