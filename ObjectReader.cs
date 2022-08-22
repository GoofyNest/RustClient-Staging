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

	// RVA: 0x11FBEE0 Offset: 0x11FA4E0 VA: 0x1811FBEE0
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal object get_TopObject() { }

	// RVA: 0x11FBF60 Offset: 0x11FA560 VA: 0x1811FBF60
	internal void set_TopObject(object value) { }

	// RVA: 0x11FBDB0 Offset: 0x11FA3B0 VA: 0x1811FBDB0
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11F7990 Offset: 0x11F5F90 VA: 0x1811F7990
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x11F8840 Offset: 0x11F6E40 VA: 0x1811F8840
	private bool HasSurrogate(Type t) { }

	// RVA: 0x11F7550 Offset: 0x11F5B50 VA: 0x1811F7550
	private void CheckSerializable(Type t) { }

	// RVA: 0x11F8930 Offset: 0x11F6F30 VA: 0x1811F8930
	private void InitFullDeserialization() { }

	// RVA: 0x11F7950 Offset: 0x11F5F50 VA: 0x1811F7950
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x11F7900 Offset: 0x11F5F00 VA: 0x1811F7900
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x11F7780 Offset: 0x11F5D80 VA: 0x1811F7780
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11FB8F0 Offset: 0x11F9EF0 VA: 0x1811FB8F0
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x11FA370 Offset: 0x11F8970 VA: 0x1811FA370
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x11FB7A0 Offset: 0x11F9DA0 VA: 0x1811FB7A0
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x11FB770 Offset: 0x11F9D70 VA: 0x1811FB770
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x11FB3F0 Offset: 0x11F99F0 VA: 0x1811FB3F0
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x11FAF40 Offset: 0x11F9540 VA: 0x1811FAF40
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x11F99E0 Offset: 0x11F7FE0 VA: 0x1811F99E0
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x11F8A40 Offset: 0x11F7040 VA: 0x1811F8A40
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x11F8B80 Offset: 0x11F7180 VA: 0x1811F8B80
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x11F8B50 Offset: 0x11F7150 VA: 0x1811F8B50
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FA670 Offset: 0x11F8C70 VA: 0x1811FA670
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x11FA5C0 Offset: 0x11F8BC0 VA: 0x1811FA5C0
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FB7D0 Offset: 0x11F9DD0 VA: 0x1811FB7D0
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x11FBB20 Offset: 0x11FA120 VA: 0x1811FBB20
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x11FBC00 Offset: 0x11FA200 VA: 0x1811FBC00
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x11F80E0 Offset: 0x11F66E0 VA: 0x1811F80E0
	internal long GetId(long objectId) { }

	// RVA: 0x11F74F0 Offset: 0x11F5AF0 VA: 0x1811F74F0
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x11F7DA0 Offset: 0x11F63A0 VA: 0x1811F7DA0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x11FBD40 Offset: 0x11FA340 VA: 0x1811FBD40
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x11F8330 Offset: 0x11F6930 VA: 0x1811F8330
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x11F8530 Offset: 0x11F6B30 VA: 0x1811F8530
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x11F76A0 Offset: 0x11F5CA0 VA: 0x1811F76A0
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x1205990 Offset: 0x1203F90 VA: 0x181205990
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

}

