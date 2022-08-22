internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 2291
{	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0xEFAF60 Offset: 0xEF9560 VA: 0x180EFAF60
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xEF44A0 Offset: 0xEF2AA0 VA: 0x180EF44A0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xEF3FA0 Offset: 0xEF25A0 VA: 0x180EF3FA0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xEFB1E0 Offset: 0xEF97E0 VA: 0x180EFB1E0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEF3310 Offset: 0xEF1910 VA: 0x180EF3310
	private bool LoadSchema(string uri) { }

	// RVA: 0xEF3140 Offset: 0xEF1740 VA: 0x180EF3140
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xEF4700 Offset: 0xEF2D00 VA: 0x180EF4700 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xEF4420 Offset: 0xEF2A20 VA: 0x180EF4420 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xEF4C30 Offset: 0xEF3230 VA: 0x180EF4C30 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xEF25E0 Offset: 0xEF0BE0 VA: 0x180EF25E0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xEF47D0 Offset: 0xEF2DD0 VA: 0x180EF47D0
	private void Push() { }

	// RVA: 0xEF3F20 Offset: 0xEF2520 VA: 0x180EF3F20
	private void Pop() { }

	// RVA: 0xEF4770 Offset: 0xEF2D70 VA: 0x180EF4770
	private void PushGroupInfo() { }

	// RVA: 0xEF3EA0 Offset: 0xEF24A0 VA: 0x180EF3EA0
	private void PopGroupInfo() { }

	// RVA: 0xEF8C90 Offset: 0xEF7290 VA: 0x180EF8C90
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0xEF70A0 Offset: 0xEF56A0 VA: 0x180EF70A0
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5410 Offset: 0xEF3A10 VA: 0x180EF5410
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0xEF8180 Offset: 0xEF6780 VA: 0x180EF8180
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0xEF88D0 Offset: 0xEF6ED0 VA: 0x180EF88D0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF67C0 Offset: 0xEF4DC0 VA: 0x180EF67C0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6020 Offset: 0xEF4620 VA: 0x180EF6020
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6620 Offset: 0xEF4C20 VA: 0x180EF6620
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF69B0 Offset: 0xEF4FB0 VA: 0x180EF69B0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6400 Offset: 0xEF4A00 VA: 0x180EF6400
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6540 Offset: 0xEF4B40 VA: 0x180EF6540
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF60E0 Offset: 0xEF46E0 VA: 0x180EF60E0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6270 Offset: 0xEF4870 VA: 0x180EF6270
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5110 Offset: 0xEF3710 VA: 0x180EF5110
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0xEF7770 Offset: 0xEF5D70 VA: 0x180EF7770
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0xEF8640 Offset: 0xEF6C40 VA: 0x180EF8640
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF5B30 Offset: 0xEF4130 VA: 0x180EF5B30
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5DF0 Offset: 0xEF43F0 VA: 0x180EF5DF0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF54F0 Offset: 0xEF3AF0 VA: 0x180EF54F0
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5840 Offset: 0xEF3E40 VA: 0x180EF5840
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5A50 Offset: 0xEF4050 VA: 0x180EF5A50
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5520 Offset: 0xEF3B20 VA: 0x180EF5520
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF56B0 Offset: 0xEF3CB0 VA: 0x180EF56B0
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF4C60 Offset: 0xEF3260 VA: 0x180EF4C60
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF7340 Offset: 0xEF5940 VA: 0x180EF7340
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF8A50 Offset: 0xEF7050 VA: 0x180EF8A50
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6BA0 Offset: 0xEF51A0 VA: 0x180EF6BA0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6B10 Offset: 0xEF5110 VA: 0x180EF6B10
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6A80 Offset: 0xEF5080 VA: 0x180EF6A80
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7E60 Offset: 0xEF6460 VA: 0x180EF7E60
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0xEF8750 Offset: 0xEF6D50 VA: 0x180EF8750
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0xEF5F40 Offset: 0xEF4540 VA: 0x180EF5F40
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5EB0 Offset: 0xEF44B0 VA: 0x180EF5EB0
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5E80 Offset: 0xEF4480 VA: 0x180EF5E80
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF4D00 Offset: 0xEF3300 VA: 0x180EF4D00
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0xEF7620 Offset: 0xEF5C20 VA: 0x180EF7620
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0xEF8B30 Offset: 0xEF7130 VA: 0x180EF8B30
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6F80 Offset: 0xEF5580 VA: 0x180EF6F80
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6EF0 Offset: 0xEF54F0 VA: 0x180EF6EF0
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6E60 Offset: 0xEF5460 VA: 0x180EF6E60
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7F80 Offset: 0xEF6580 VA: 0x180EF7F80
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0xEF87E0 Offset: 0xEF6DE0 VA: 0x180EF87E0
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7650 Offset: 0xEF5C50 VA: 0x180EF7650
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0xEF85B0 Offset: 0xEF6BB0 VA: 0x180EF85B0
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7240 Offset: 0xEF5840 VA: 0x180EF7240
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0xEF29F0 Offset: 0xEF0FF0 VA: 0x180EF29F0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xEF3020 Offset: 0xEF1620 VA: 0x180EF3020
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xEF2E60 Offset: 0xEF1460 VA: 0x180EF2E60
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0xEF2C40 Offset: 0xEF1240 VA: 0x180EF2C40
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0xEF2210 Offset: 0xEF0810 VA: 0x180EF2210
	private void AddOrder() { }

	// RVA: 0xEF31E0 Offset: 0xEF17E0 VA: 0x180EF31E0
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0xEF3D80 Offset: 0xEF2380 VA: 0x180EF3D80
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF3C40 Offset: 0xEF2240 VA: 0x180EF3C40
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF2E20 Offset: 0xEF1420 VA: 0x180EF2E20
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0xEF3980 Offset: 0xEF1F80 VA: 0x180EF3980
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF3AC0 Offset: 0xEF20C0 VA: 0x180EF3AC0
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF2570 Offset: 0xEF0B70 VA: 0x180EF2570
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0xEF3C00 Offset: 0xEF2200 VA: 0x180EF3C00
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0xEF7130 Offset: 0xEF5730 VA: 0x180EF7130
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0xEF4BD0 Offset: 0xEF31D0 VA: 0x180EF4BD0
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0xEF2680 Offset: 0xEF0C80 VA: 0x180EF2680
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0xEF28C0 Offset: 0xEF0EC0 VA: 0x180EF28C0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0xEF22C0 Offset: 0xEF08C0 VA: 0x180EF22C0
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0xEF2420 Offset: 0xEF0A20 VA: 0x180EF2420
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0xEF2E50 Offset: 0xEF1450 VA: 0x180EF2E50
	private bool IsGlobal(int flags) { }

	// RVA: 0xEF4AB0 Offset: 0xEF30B0 VA: 0x180EF4AB0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xEF4940 Offset: 0xEF2F40 VA: 0x180EF4940
	private void SendValidationEvent(string code) { }

	// RVA: 0xEF4830 Offset: 0xEF2E30 VA: 0x180EF4830
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xEF49A0 Offset: 0xEF2FA0 VA: 0x180EF49A0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xEF8D10 Offset: 0xEF7310 VA: 0x180EF8D10
	private static void .cctor() { }

}

private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 2292
{	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal uint _MaxOccurs; // 0x40
	internal uint _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal XdrBuilder.DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x14295D0 Offset: 0x1427BD0 VA: 0x1814295D0
	internal void .ctor() { }

	// RVA: 0x14294C0 Offset: 0x1427AC0 VA: 0x1814294C0
	internal void Reset() { }

}

private sealed class XdrBuilder.GroupContent // TypeDefIndex: 2293
{	// Fields
	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x14296E0 Offset: 0x1427CE0 VA: 0x1814296E0
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x1429710 Offset: 0x1427D10 VA: 0x181429710
	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.ElementContent // TypeDefIndex: 2294
{	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal uint _MinVal; // 0x28
	internal uint _MaxVal; // 0x2C
	internal uint _MaxLength; // 0x30
	internal uint _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 2295
{	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal uint _MinVal; // 0x2C
	internal uint _MaxVal; // 0x30
	internal uint _MaxLength; // 0x34
	internal uint _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 2296
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1429C60 Offset: 0x1428260 VA: 0x181429C60 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x130FC60 Offset: 0x130E260 VA: 0x18130FC60 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 2297
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 2298
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14299B0 Offset: 0x1427FB0 VA: 0x1814299B0 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 2299
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14299B0 Offset: 0x1427FB0 VA: 0x1814299B0 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 2300
{	// Fields
	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x14298D0 Offset: 0x1427ED0 VA: 0x1814298D0
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x1429940 Offset: 0x1427F40 VA: 0x181429940
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }

}

private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 2301
{	// Fields
	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x142A160 Offset: 0x1428760 VA: 0x18142A160
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}

