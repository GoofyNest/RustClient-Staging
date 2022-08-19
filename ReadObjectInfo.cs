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

	// RVA: 0x12024A0 Offset: 0x1200AA0 VA: 0x1812024A0
	internal void PrepareForReuse() { }

	// RVA: 0x1200B40 Offset: 0x11FF140 VA: 0x181200B40
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202080 Offset: 0x1200680 VA: 0x181202080
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x12009D0 Offset: 0x11FEFD0 VA: 0x1812009D0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202140 Offset: 0x1200740 VA: 0x181202140
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1201DC0 Offset: 0x12003C0 VA: 0x181201DC0
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1202010 Offset: 0x1200610 VA: 0x181202010
	private void InitSiRead() { }

	// RVA: 0x1201D50 Offset: 0x1200350 VA: 0x181201D50
	private void InitNoMembers() { }

	// RVA: 0x1201A80 Offset: 0x1200080 VA: 0x181201A80
	private void InitMemberInfo() { }

	// RVA: 0x1200C70 Offset: 0x11FF270 VA: 0x181200C70
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1201810 Offset: 0x11FFE10 VA: 0x181201810
	internal Type GetType(string name) { }

	// RVA: 0x1200910 Offset: 0x11FEF10 VA: 0x181200910
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1201990 Offset: 0x11FFF90 VA: 0x181201990
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x12024B0 Offset: 0x1200AB0 VA: 0x1812024B0
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1202250 Offset: 0x1200850 VA: 0x181202250
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x12022E0 Offset: 0x12008E0 VA: 0x1812022E0
	private int Position(string name) { }

	// RVA: 0x12010E0 Offset: 0x11FF6E0 VA: 0x1812010E0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1200E70 Offset: 0x11FF470 VA: 0x181200E70
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x12017A0 Offset: 0x11FFDA0 VA: 0x1812017A0
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

}

