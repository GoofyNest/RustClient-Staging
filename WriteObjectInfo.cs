internal sealed class WriteObjectInfo // TypeDefIndex: 1107
{	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1209960 Offset: 0x1207F60 VA: 0x181209960
	internal void ObjectEnd() { }

	// RVA: 0x1209890 Offset: 0x1207E90 VA: 0x181209890
	private void InternalInit() { }

	// RVA: 0x1209A60 Offset: 0x1208060 VA: 0x181209A60
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1208CA0 Offset: 0x12072A0 VA: 0x181208CA0
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x12099C0 Offset: 0x1207FC0 VA: 0x1812099C0
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x12086F0 Offset: 0x1206CF0 VA: 0x1812086F0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x12094D0 Offset: 0x1207AD0 VA: 0x1812094D0
	private void InitSiWrite() { }

	// RVA: 0x1207B80 Offset: 0x1206180 VA: 0x181207B80
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x12085D0 Offset: 0x1206BD0 VA: 0x1812085D0
	private void InitNoMembers() { }

	// RVA: 0x12081E0 Offset: 0x12067E0 VA: 0x1812081E0
	private void InitMemberInfo() { }

	// RVA: 0x12081B0 Offset: 0x12067B0 VA: 0x1812081B0
	internal string GetTypeFullName() { }

	// RVA: 0x1207CE0 Offset: 0x12062E0 VA: 0x181207CE0
	internal string GetAssemblyString() { }

	// RVA: 0x1209920 Offset: 0x1207F20 VA: 0x181209920
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x1207E00 Offset: 0x1206400 VA: 0x181207E00
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1207D10 Offset: 0x1206310 VA: 0x181207D10
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x1208070 Offset: 0x1206670 VA: 0x181208070
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x1209990 Offset: 0x1207F90 VA: 0x181209990
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

}

