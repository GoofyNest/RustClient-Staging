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

	// RVA: 0x11FFFC0 Offset: 0x11FE5C0 VA: 0x1811FFFC0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11FC950 Offset: 0x11FAF50 VA: 0x1811FC950
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x11FF5E0 Offset: 0x11FDBE0 VA: 0x1811FF5E0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x11FF140 Offset: 0x11FD740 VA: 0x1811FF140
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x11FE600 Offset: 0x11FCC00 VA: 0x1811FE600
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FE770 Offset: 0x11FCD70 VA: 0x1811FE770
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FD7D0 Offset: 0x11FBDD0 VA: 0x1811FD7D0
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11FD3E0 Offset: 0x11FB9E0 VA: 0x1811FD3E0
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x11FED40 Offset: 0x11FD340 VA: 0x1811FED40
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x11FC3F0 Offset: 0x11FA9F0 VA: 0x1811FC3F0
	private object GetNext(out long objID) { }

	// RVA: 0x11FC580 Offset: 0x11FAB80 VA: 0x1811FC580
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x11FC830 Offset: 0x11FAE30 VA: 0x1811FC830
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x11FC6E0 Offset: 0x11FACE0 VA: 0x1811FC6E0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x11FE3D0 Offset: 0x11FC9D0 VA: 0x1811FE3D0
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FED20 Offset: 0x11FD320 VA: 0x1811FED20
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x11FEFD0 Offset: 0x11FD5D0 VA: 0x1811FEFD0
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x11FBFA0 Offset: 0x11FA5A0 VA: 0x1811FBFA0
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11FEFA0 Offset: 0x11FD5A0 VA: 0x1811FEFA0
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x11FD240 Offset: 0x11FB840 VA: 0x1811FD240
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x11FD1E0 Offset: 0x11FB7E0 VA: 0x1811FD1E0
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x11FD030 Offset: 0x11FB630 VA: 0x1811FD030
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x11FD0E0 Offset: 0x11FB6E0 VA: 0x1811FD0E0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x11FD330 Offset: 0x11FB930 VA: 0x1811FD330
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x11FC670 Offset: 0x11FAC70 VA: 0x1811FC670
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x11FCF70 Offset: 0x11FB570 VA: 0x1811FCF70
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11FC070 Offset: 0x11FA670 VA: 0x1811FC070
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x98C180 Offset: 0x98A780 VA: 0x18098C180
	private Type GetType(object obj) { }

	// RVA: 0x11FC300 Offset: 0x11FA900 VA: 0x1811FC300
	private NameInfo GetNameInfo() { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x11FC6B0 Offset: 0x11FACB0 VA: 0x1811FC6B0
	private void PutNameInfo(NameInfo nameInfo) { }

}

