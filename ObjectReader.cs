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

	// RVA: 0x11FBC20 Offset: 0x11FA220 VA: 0x1811FBC20
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal object get_TopObject() { }

	// RVA: 0x11FBCA0 Offset: 0x11FA2A0 VA: 0x1811FBCA0
	internal void set_TopObject(object value) { }

	// RVA: 0x11FBAF0 Offset: 0x11FA0F0 VA: 0x1811FBAF0
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11F76D0 Offset: 0x11F5CD0 VA: 0x1811F76D0
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x11F8580 Offset: 0x11F6B80 VA: 0x1811F8580
	private bool HasSurrogate(Type t) { }

	// RVA: 0x11F7290 Offset: 0x11F5890 VA: 0x1811F7290
	private void CheckSerializable(Type t) { }

	// RVA: 0x11F8670 Offset: 0x11F6C70 VA: 0x1811F8670
	private void InitFullDeserialization() { }

	// RVA: 0x11F7690 Offset: 0x11F5C90 VA: 0x1811F7690
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x11F7640 Offset: 0x11F5C40 VA: 0x1811F7640
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x11F74C0 Offset: 0x11F5AC0 VA: 0x1811F74C0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11FB630 Offset: 0x11F9C30 VA: 0x1811FB630
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x11FA0B0 Offset: 0x11F86B0 VA: 0x1811FA0B0
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x11FB4E0 Offset: 0x11F9AE0 VA: 0x1811FB4E0
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x11FB4B0 Offset: 0x11F9AB0 VA: 0x1811FB4B0
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x11FB130 Offset: 0x11F9730 VA: 0x1811FB130
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x11FAC80 Offset: 0x11F9280 VA: 0x1811FAC80
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x11F9720 Offset: 0x11F7D20 VA: 0x1811F9720
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x11F8780 Offset: 0x11F6D80 VA: 0x1811F8780
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x11F88C0 Offset: 0x11F6EC0 VA: 0x1811F88C0
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x11F8890 Offset: 0x11F6E90 VA: 0x1811F8890
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FA3B0 Offset: 0x11F89B0 VA: 0x1811FA3B0
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x11FA300 Offset: 0x11F8900 VA: 0x1811FA300
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x11FB510 Offset: 0x11F9B10 VA: 0x1811FB510
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x11FB860 Offset: 0x11F9E60 VA: 0x1811FB860
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x11FB940 Offset: 0x11F9F40 VA: 0x1811FB940
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x11F7E20 Offset: 0x11F6420 VA: 0x1811F7E20
	internal long GetId(long objectId) { }

	// RVA: 0x11F7230 Offset: 0x11F5830 VA: 0x1811F7230
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x11F7AE0 Offset: 0x11F60E0 VA: 0x1811F7AE0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x11FBA80 Offset: 0x11FA080 VA: 0x1811FBA80
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x11F8070 Offset: 0x11F6670 VA: 0x1811F8070
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x11F8270 Offset: 0x11F6870 VA: 0x1811F8270
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x11F73E0 Offset: 0x11F59E0 VA: 0x1811F73E0
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

	// RVA: 0x12056D0 Offset: 0x1203CD0 VA: 0x1812056D0
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

}

