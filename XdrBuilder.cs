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

	// RVA: 0xEFBA10 Offset: 0xEFA010 VA: 0x180EFBA10
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xEF4F50 Offset: 0xEF3550 VA: 0x180EF4F50 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xEF4A50 Offset: 0xEF3050 VA: 0x180EF4A50 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEF3DC0 Offset: 0xEF23C0 VA: 0x180EF3DC0
	private bool LoadSchema(string uri) { }

	// RVA: 0xEF3BF0 Offset: 0xEF21F0 VA: 0x180EF3BF0
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xEF51B0 Offset: 0xEF37B0 VA: 0x180EF51B0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xEF4ED0 Offset: 0xEF34D0 VA: 0x180EF4ED0 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xEF56E0 Offset: 0xEF3CE0 VA: 0x180EF56E0 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xEF3090 Offset: 0xEF1690 VA: 0x180EF3090 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xEF5280 Offset: 0xEF3880 VA: 0x180EF5280
	private void Push() { }

	// RVA: 0xEF49D0 Offset: 0xEF2FD0 VA: 0x180EF49D0
	private void Pop() { }

	// RVA: 0xEF5220 Offset: 0xEF3820 VA: 0x180EF5220
	private void PushGroupInfo() { }

	// RVA: 0xEF4950 Offset: 0xEF2F50 VA: 0x180EF4950
	private void PopGroupInfo() { }

	// RVA: 0xEF9740 Offset: 0xEF7D40 VA: 0x180EF9740
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7B50 Offset: 0xEF6150 VA: 0x180EF7B50
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5EC0 Offset: 0xEF44C0 VA: 0x180EF5EC0
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0xEF8C30 Offset: 0xEF7230 VA: 0x180EF8C30
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0xEF9380 Offset: 0xEF7980 VA: 0x180EF9380
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7270 Offset: 0xEF5870 VA: 0x180EF7270
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6AD0 Offset: 0xEF50D0 VA: 0x180EF6AD0
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF70D0 Offset: 0xEF56D0 VA: 0x180EF70D0
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7460 Offset: 0xEF5A60 VA: 0x180EF7460
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6EB0 Offset: 0xEF54B0 VA: 0x180EF6EB0
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6FF0 Offset: 0xEF55F0 VA: 0x180EF6FF0
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6B90 Offset: 0xEF5190 VA: 0x180EF6B90
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6D20 Offset: 0xEF5320 VA: 0x180EF6D20
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5BC0 Offset: 0xEF41C0 VA: 0x180EF5BC0
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0xEF8220 Offset: 0xEF6820 VA: 0x180EF8220
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0xEF90F0 Offset: 0xEF76F0 VA: 0x180EF90F0
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF65E0 Offset: 0xEF4BE0 VA: 0x180EF65E0
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF68A0 Offset: 0xEF4EA0 VA: 0x180EF68A0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5FA0 Offset: 0xEF45A0 VA: 0x180EF5FA0
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF62F0 Offset: 0xEF48F0 VA: 0x180EF62F0
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6500 Offset: 0xEF4B00 VA: 0x180EF6500
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5FD0 Offset: 0xEF45D0 VA: 0x180EF5FD0
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6160 Offset: 0xEF4760 VA: 0x180EF6160
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5710 Offset: 0xEF3D10 VA: 0x180EF5710
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF7DF0 Offset: 0xEF63F0 VA: 0x180EF7DF0
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF9500 Offset: 0xEF7B00 VA: 0x180EF9500
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7650 Offset: 0xEF5C50 VA: 0x180EF7650
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF75C0 Offset: 0xEF5BC0 VA: 0x180EF75C0
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7530 Offset: 0xEF5B30 VA: 0x180EF7530
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF8910 Offset: 0xEF6F10 VA: 0x180EF8910
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0xEF9200 Offset: 0xEF7800 VA: 0x180EF9200
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0xEF69F0 Offset: 0xEF4FF0 VA: 0x180EF69F0
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6960 Offset: 0xEF4F60 VA: 0x180EF6960
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6930 Offset: 0xEF4F30 VA: 0x180EF6930
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF57B0 Offset: 0xEF3DB0 VA: 0x180EF57B0
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0xEF80D0 Offset: 0xEF66D0 VA: 0x180EF80D0
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0xEF95E0 Offset: 0xEF7BE0 VA: 0x180EF95E0
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7A30 Offset: 0xEF6030 VA: 0x180EF7A30
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF79A0 Offset: 0xEF5FA0 VA: 0x180EF79A0
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7910 Offset: 0xEF5F10 VA: 0x180EF7910
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF8A30 Offset: 0xEF7030 VA: 0x180EF8A30
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0xEF9290 Offset: 0xEF7890 VA: 0x180EF9290
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF8100 Offset: 0xEF6700 VA: 0x180EF8100
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0xEF9060 Offset: 0xEF7660 VA: 0x180EF9060
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7CF0 Offset: 0xEF62F0 VA: 0x180EF7CF0
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0xEF34A0 Offset: 0xEF1AA0 VA: 0x180EF34A0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xEF3AD0 Offset: 0xEF20D0 VA: 0x180EF3AD0
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xEF3910 Offset: 0xEF1F10 VA: 0x180EF3910
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0xEF36F0 Offset: 0xEF1CF0 VA: 0x180EF36F0
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0xEF2CC0 Offset: 0xEF12C0 VA: 0x180EF2CC0
	private void AddOrder() { }

	// RVA: 0xEF3C90 Offset: 0xEF2290 VA: 0x180EF3C90
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0xEF4830 Offset: 0xEF2E30 VA: 0x180EF4830
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF46F0 Offset: 0xEF2CF0 VA: 0x180EF46F0
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF38D0 Offset: 0xEF1ED0 VA: 0x180EF38D0
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0xEF4430 Offset: 0xEF2A30 VA: 0x180EF4430
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF4570 Offset: 0xEF2B70 VA: 0x180EF4570
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF3020 Offset: 0xEF1620 VA: 0x180EF3020
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0xEF46B0 Offset: 0xEF2CB0 VA: 0x180EF46B0
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0xEF7BE0 Offset: 0xEF61E0 VA: 0x180EF7BE0
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0xEF5680 Offset: 0xEF3C80 VA: 0x180EF5680
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0xEF3130 Offset: 0xEF1730 VA: 0x180EF3130
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0xEF3370 Offset: 0xEF1970 VA: 0x180EF3370
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0xEF2D70 Offset: 0xEF1370 VA: 0x180EF2D70
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0xEF2ED0 Offset: 0xEF14D0 VA: 0x180EF2ED0
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0xEF3900 Offset: 0xEF1F00 VA: 0x180EF3900
	private bool IsGlobal(int flags) { }

	// RVA: 0xEF5560 Offset: 0xEF3B60 VA: 0x180EF5560
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xEF53F0 Offset: 0xEF39F0 VA: 0x180EF53F0
	private void SendValidationEvent(string code) { }

	// RVA: 0xEF52E0 Offset: 0xEF38E0 VA: 0x180EF52E0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xEF5450 Offset: 0xEF3A50 VA: 0x180EF5450
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xEF97C0 Offset: 0xEF7DC0 VA: 0x180EF97C0
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

	// RVA: 0x14286B0 Offset: 0x1426CB0 VA: 0x1814286B0
	internal void .ctor() { }

	// RVA: 0x14285A0 Offset: 0x1426BA0 VA: 0x1814285A0
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

	// RVA: 0x14287C0 Offset: 0x1426DC0 VA: 0x1814287C0
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x14287F0 Offset: 0x1426DF0 VA: 0x1814287F0
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

	// RVA: 0x1428D40 Offset: 0x1427340 VA: 0x181428D40 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x12C39E0 Offset: 0x12C1FE0 VA: 0x1812C39E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 2297
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 2298
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428A90 Offset: 0x1427090 VA: 0x181428A90 Slot: 12
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

	// RVA: 0x1428A90 Offset: 0x1427090 VA: 0x181428A90 Slot: 12
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

	// RVA: 0x14289B0 Offset: 0x1426FB0 VA: 0x1814289B0
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x1428A20 Offset: 0x1427020 VA: 0x181428A20
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

	// RVA: 0x1429240 Offset: 0x1427840 VA: 0x181429240
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}

