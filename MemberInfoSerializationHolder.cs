internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 536
{	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x18CADD0 Offset: 0x18C93D0 VA: 0x1818CADD0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x18CAE00 Offset: 0x18C9400 VA: 0x1818CAE00
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x18CB050 Offset: 0x18C9650 VA: 0x1818CB050
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C9E70 Offset: 0x18C8470 VA: 0x1818C9E70 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C9EE0 Offset: 0x18C84E0 VA: 0x1818C9EE0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

