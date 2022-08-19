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

	// RVA: 0x1209000 Offset: 0x1207600 VA: 0x181209000
	internal void ObjectEnd() { }

	// RVA: 0x1208F30 Offset: 0x1207530 VA: 0x181208F30
	private void InternalInit() { }

	// RVA: 0x1209100 Offset: 0x1207700 VA: 0x181209100
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1208340 Offset: 0x1206940 VA: 0x181208340
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1209060 Offset: 0x1207660 VA: 0x181209060
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1207D90 Offset: 0x1206390 VA: 0x181207D90
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x1208B70 Offset: 0x1207170 VA: 0x181208B70
	private void InitSiWrite() { }

	// RVA: 0x1207220 Offset: 0x1205820 VA: 0x181207220
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x1207C70 Offset: 0x1206270 VA: 0x181207C70
	private void InitNoMembers() { }

	// RVA: 0x1207880 Offset: 0x1205E80 VA: 0x181207880
	private void InitMemberInfo() { }

	// RVA: 0x1207850 Offset: 0x1205E50 VA: 0x181207850
	internal string GetTypeFullName() { }

	// RVA: 0x1207380 Offset: 0x1205980 VA: 0x181207380
	internal string GetAssemblyString() { }

	// RVA: 0x1208FC0 Offset: 0x12075C0 VA: 0x181208FC0
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x12074A0 Offset: 0x1205AA0 VA: 0x1812074A0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x12073B0 Offset: 0x12059B0 VA: 0x1812073B0
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x1207710 Offset: 0x1205D10 VA: 0x181207710
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x1209030 Offset: 0x1207630 VA: 0x181209030
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

}

