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

	// RVA: 0x12092C0 Offset: 0x12078C0 VA: 0x1812092C0
	internal void ObjectEnd() { }

	// RVA: 0x12091F0 Offset: 0x12077F0 VA: 0x1812091F0
	private void InternalInit() { }

	// RVA: 0x12093C0 Offset: 0x12079C0 VA: 0x1812093C0
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1208600 Offset: 0x1206C00 VA: 0x181208600
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1209320 Offset: 0x1207920 VA: 0x181209320
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1208050 Offset: 0x1206650 VA: 0x181208050
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1208E30 Offset: 0x1207430 VA: 0x181208E30
	private void InitSiWrite() { }

	// RVA: 0x12074E0 Offset: 0x1205AE0 VA: 0x1812074E0
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x1207F30 Offset: 0x1206530 VA: 0x181207F30
	private void InitNoMembers() { }

	// RVA: 0x1207B40 Offset: 0x1206140 VA: 0x181207B40
	private void InitMemberInfo() { }

	// RVA: 0x1207B10 Offset: 0x1206110 VA: 0x181207B10
	internal string GetTypeFullName() { }

	// RVA: 0x1207640 Offset: 0x1205C40 VA: 0x181207640
	internal string GetAssemblyString() { }

	// RVA: 0x1209280 Offset: 0x1207880 VA: 0x181209280
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x1207760 Offset: 0x1205D60 VA: 0x181207760
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1207670 Offset: 0x1205C70 VA: 0x181207670
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x12079D0 Offset: 0x1205FD0 VA: 0x1812079D0
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x12092F0 Offset: 0x12078F0 VA: 0x1812092F0
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

}

