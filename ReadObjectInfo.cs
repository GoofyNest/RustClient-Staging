internal sealed class ReadObjectInfo // TypeDefIndex: 1108
{	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void ObjectEnd() { }

	// RVA: 0x1202E00 Offset: 0x1201400 VA: 0x181202E00
	internal void PrepareForReuse() { }

	// RVA: 0x12014A0 Offset: 0x11FFAA0 VA: 0x1812014A0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x12029E0 Offset: 0x1200FE0 VA: 0x1812029E0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1201330 Offset: 0x11FF930 VA: 0x181201330
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202AA0 Offset: 0x12010A0 VA: 0x181202AA0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202720 Offset: 0x1200D20 VA: 0x181202720
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1202970 Offset: 0x1200F70 VA: 0x181202970
	private void InitSiRead() { }

	// RVA: 0x12026B0 Offset: 0x1200CB0 VA: 0x1812026B0
	private void InitNoMembers() { }

	// RVA: 0x12023E0 Offset: 0x12009E0 VA: 0x1812023E0
	private void InitMemberInfo() { }

	// RVA: 0x12015D0 Offset: 0x11FFBD0 VA: 0x1812015D0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1202170 Offset: 0x1200770 VA: 0x181202170
	internal Type GetType(string name) { }

	// RVA: 0x1201270 Offset: 0x11FF870 VA: 0x181201270
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x12022F0 Offset: 0x12008F0 VA: 0x1812022F0
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1202E10 Offset: 0x1201410 VA: 0x181202E10
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1202BB0 Offset: 0x12011B0 VA: 0x181202BB0
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x1202C40 Offset: 0x1201240 VA: 0x181202C40
	private int Position(string name) { }

	// RVA: 0x1201A40 Offset: 0x1200040 VA: 0x181201A40
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x12017D0 Offset: 0x11FFDD0 VA: 0x1812017D0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1202100 Offset: 0x1200700 VA: 0x181202100
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

}

