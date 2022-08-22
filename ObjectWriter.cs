internal sealed class ObjectWriter // TypeDefIndex: 1115
{	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x1200660 Offset: 0x11FEC60 VA: 0x181200660
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11FCFF0 Offset: 0x11FB5F0 VA: 0x1811FCFF0
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x11FFC80 Offset: 0x11FE280 VA: 0x1811FFC80
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x11FF7E0 Offset: 0x11FDDE0 VA: 0x1811FF7E0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x11FECA0 Offset: 0x11FD2A0 VA: 0x1811FECA0
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FEE10 Offset: 0x11FD410 VA: 0x1811FEE10
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FDE70 Offset: 0x11FC470 VA: 0x1811FDE70
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FDA80 Offset: 0x11FC080 VA: 0x1811FDA80
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x11FF3E0 Offset: 0x11FD9E0 VA: 0x1811FF3E0
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x11FCA90 Offset: 0x11FB090 VA: 0x1811FCA90
	private object GetNext(out long objID) { }

	// RVA: 0x11FCC20 Offset: 0x11FB220 VA: 0x1811FCC20
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x11FCED0 Offset: 0x11FB4D0 VA: 0x1811FCED0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x11FCD80 Offset: 0x11FB380 VA: 0x1811FCD80
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x11FEA70 Offset: 0x11FD070 VA: 0x1811FEA70
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FF3C0 Offset: 0x11FD9C0 VA: 0x1811FF3C0
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x11FF670 Offset: 0x11FDC70 VA: 0x1811FF670
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x11FC640 Offset: 0x11FAC40 VA: 0x1811FC640
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FF640 Offset: 0x11FDC40 VA: 0x1811FF640
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x11FD8E0 Offset: 0x11FBEE0 VA: 0x1811FD8E0
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x11FD880 Offset: 0x11FBE80 VA: 0x1811FD880
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x11FD6D0 Offset: 0x11FBCD0 VA: 0x1811FD6D0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x11FD780 Offset: 0x11FBD80 VA: 0x1811FD780
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x11FD9D0 Offset: 0x11FBFD0 VA: 0x1811FD9D0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x11FCD10 Offset: 0x11FB310 VA: 0x1811FCD10
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x11FD610 Offset: 0x11FBC10 VA: 0x1811FD610
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11FC710 Offset: 0x11FAD10 VA: 0x1811FC710
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x98C680 Offset: 0x98AC80 VA: 0x18098C680
	private Type GetType(object obj) { }

	// RVA: 0x11FC9A0 Offset: 0x11FAFA0 VA: 0x1811FC9A0
	private NameInfo GetNameInfo() { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x11FCD50 Offset: 0x11FB350 VA: 0x1811FCD50
	private void PutNameInfo(NameInfo nameInfo) { }

}

