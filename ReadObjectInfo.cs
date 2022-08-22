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

	// RVA: 0x1202760 Offset: 0x1200D60 VA: 0x181202760
	internal void PrepareForReuse() { }

	// RVA: 0x1200E00 Offset: 0x11FF400 VA: 0x181200E00
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202340 Offset: 0x1200940 VA: 0x181202340
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1200C90 Offset: 0x11FF290 VA: 0x181200C90
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202400 Offset: 0x1200A00 VA: 0x181202400
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1202080 Offset: 0x1200680 VA: 0x181202080
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x12022D0 Offset: 0x12008D0 VA: 0x1812022D0
	private void InitSiRead() { }

	// RVA: 0x1202010 Offset: 0x1200610 VA: 0x181202010
	private void InitNoMembers() { }

	// RVA: 0x1201D40 Offset: 0x1200340 VA: 0x181201D40
	private void InitMemberInfo() { }

	// RVA: 0x1200F30 Offset: 0x11FF530 VA: 0x181200F30
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1201AD0 Offset: 0x12000D0 VA: 0x181201AD0
	internal Type GetType(string name) { }

	// RVA: 0x1200BD0 Offset: 0x11FF1D0 VA: 0x181200BD0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1201C50 Offset: 0x1200250 VA: 0x181201C50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1202770 Offset: 0x1200D70 VA: 0x181202770
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1202510 Offset: 0x1200B10 VA: 0x181202510
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x12025A0 Offset: 0x1200BA0 VA: 0x1812025A0
	private int Position(string name) { }

	// RVA: 0x12013A0 Offset: 0x11FF9A0 VA: 0x1812013A0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1201130 Offset: 0x11FF730 VA: 0x181201130
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1201A60 Offset: 0x1200060 VA: 0x181201A60
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

}

