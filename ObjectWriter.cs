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

	// RVA: 0x11FFD00 Offset: 0x11FE300 VA: 0x1811FFD00
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11FC690 Offset: 0x11FAC90 VA: 0x1811FC690
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x11FF320 Offset: 0x11FD920 VA: 0x1811FF320
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x11FEE80 Offset: 0x11FD480 VA: 0x1811FEE80
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x11FE340 Offset: 0x11FC940 VA: 0x1811FE340
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FE4B0 Offset: 0x11FCAB0 VA: 0x1811FE4B0
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FD510 Offset: 0x11FBB10 VA: 0x1811FD510
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FD120 Offset: 0x11FB720 VA: 0x1811FD120
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x11FEA80 Offset: 0x11FD080 VA: 0x1811FEA80
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x11FC130 Offset: 0x11FA730 VA: 0x1811FC130
	private object GetNext(out long objID) { }

	// RVA: 0x11FC2C0 Offset: 0x11FA8C0 VA: 0x1811FC2C0
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x11FC570 Offset: 0x11FAB70 VA: 0x1811FC570
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x11FC420 Offset: 0x11FAA20 VA: 0x1811FC420
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x11FE110 Offset: 0x11FC710 VA: 0x1811FE110
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FEA60 Offset: 0x11FD060 VA: 0x1811FEA60
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x11FED10 Offset: 0x11FD310 VA: 0x1811FED10
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x11FBCE0 Offset: 0x11FA2E0 VA: 0x1811FBCE0
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FECE0 Offset: 0x11FD2E0 VA: 0x1811FECE0
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x11FCF80 Offset: 0x11FB580 VA: 0x1811FCF80
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x11FCF20 Offset: 0x11FB520 VA: 0x1811FCF20
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x11FCD70 Offset: 0x11FB370 VA: 0x1811FCD70
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x11FCE20 Offset: 0x11FB420 VA: 0x1811FCE20
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x11FD070 Offset: 0x11FB670 VA: 0x1811FD070
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x11FC3B0 Offset: 0x11FA9B0 VA: 0x1811FC3B0
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x11FCCB0 Offset: 0x11FB2B0 VA: 0x1811FCCB0
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11FBDB0 Offset: 0x11FA3B0 VA: 0x1811FBDB0
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x98C070 Offset: 0x98A670 VA: 0x18098C070
	private Type GetType(object obj) { }

	// RVA: 0x11FC040 Offset: 0x11FA640 VA: 0x1811FC040
	private NameInfo GetNameInfo() { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x11FC3F0 Offset: 0x11FA9F0 VA: 0x1811FC3F0
	private void PutNameInfo(NameInfo nameInfo) { }

}

