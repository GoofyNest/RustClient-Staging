internal sealed class ObjectReader // TypeDefIndex: 1112
{	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x11FC580 Offset: 0x11FAB80 VA: 0x1811FC580
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal object get_TopObject() { }

	// RVA: 0x11FC600 Offset: 0x11FAC00 VA: 0x1811FC600
	internal void set_TopObject(object value) { }

	// RVA: 0x11FC450 Offset: 0x11FAA50 VA: 0x1811FC450
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11F8030 Offset: 0x11F6630 VA: 0x1811F8030
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x11F8EE0 Offset: 0x11F74E0 VA: 0x1811F8EE0
	private bool HasSurrogate(Type t) { }

	// RVA: 0x11F7BF0 Offset: 0x11F61F0 VA: 0x1811F7BF0
	private void CheckSerializable(Type t) { }

	// RVA: 0x11F8FD0 Offset: 0x11F75D0 VA: 0x1811F8FD0
	private void InitFullDeserialization() { }

	// RVA: 0x11F7FF0 Offset: 0x11F65F0 VA: 0x1811F7FF0
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x11F7FA0 Offset: 0x11F65A0 VA: 0x1811F7FA0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x11F7E20 Offset: 0x11F6420 VA: 0x1811F7E20
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11FBF90 Offset: 0x11FA590 VA: 0x1811FBF90
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x11FAA10 Offset: 0x11F9010 VA: 0x1811FAA10
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x11FBE40 Offset: 0x11FA440 VA: 0x1811FBE40
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x11FBE10 Offset: 0x11FA410 VA: 0x1811FBE10
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x11FBA90 Offset: 0x11FA090 VA: 0x1811FBA90
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x11FB5E0 Offset: 0x11F9BE0 VA: 0x1811FB5E0
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x11FA080 Offset: 0x11F8680 VA: 0x1811FA080
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x11F90E0 Offset: 0x11F76E0 VA: 0x1811F90E0
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x11F9220 Offset: 0x11F7820 VA: 0x1811F9220
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x11F91F0 Offset: 0x11F77F0 VA: 0x1811F91F0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FAD10 Offset: 0x11F9310 VA: 0x1811FAD10
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x11FAC60 Offset: 0x11F9260 VA: 0x1811FAC60
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FBE70 Offset: 0x11FA470 VA: 0x1811FBE70
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x11FC1C0 Offset: 0x11FA7C0 VA: 0x1811FC1C0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x11FC2A0 Offset: 0x11FA8A0 VA: 0x1811FC2A0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x11F8780 Offset: 0x11F6D80 VA: 0x1811F8780
	internal long GetId(long objectId) { }

	// RVA: 0x11F7B90 Offset: 0x11F6190 VA: 0x1811F7B90
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x11F8440 Offset: 0x11F6A40 VA: 0x1811F8440
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x11FC3E0 Offset: 0x11FA9E0 VA: 0x1811FC3E0
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x11F89D0 Offset: 0x11F6FD0 VA: 0x1811F89D0
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x11F8BD0 Offset: 0x11F71D0 VA: 0x1811F8BD0
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x11F7D40 Offset: 0x11F6340 VA: 0x1811F7D40
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }

}

internal class ObjectReader.TypeNAssembly // TypeDefIndex: 1113
{	// Fields
	public Type type; // 0x10
	public string assemblyName; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 1114
{	// Fields
	private Assembly m_topLevelAssembly; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x1206030 Offset: 0x1204630 VA: 0x181206030
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

}

