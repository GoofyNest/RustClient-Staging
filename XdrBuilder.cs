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

	// RVA: 0xEFACA0 Offset: 0xEF92A0 VA: 0x180EFACA0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xEF41E0 Offset: 0xEF27E0 VA: 0x180EF41E0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xEF3CE0 Offset: 0xEF22E0 VA: 0x180EF3CE0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xEFAF20 Offset: 0xEF9520 VA: 0x180EFAF20
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEF3050 Offset: 0xEF1650 VA: 0x180EF3050
	private bool LoadSchema(string uri) { }

	// RVA: 0xEF2E80 Offset: 0xEF1480 VA: 0x180EF2E80
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xEF4440 Offset: 0xEF2A40 VA: 0x180EF4440 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xEF4160 Offset: 0xEF2760 VA: 0x180EF4160 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xEF4970 Offset: 0xEF2F70 VA: 0x180EF4970 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xEF2320 Offset: 0xEF0920 VA: 0x180EF2320 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xEF4510 Offset: 0xEF2B10 VA: 0x180EF4510
	private void Push() { }

	// RVA: 0xEF3C60 Offset: 0xEF2260 VA: 0x180EF3C60
	private void Pop() { }

	// RVA: 0xEF44B0 Offset: 0xEF2AB0 VA: 0x180EF44B0
	private void PushGroupInfo() { }

	// RVA: 0xEF3BE0 Offset: 0xEF21E0 VA: 0x180EF3BE0
	private void PopGroupInfo() { }

	// RVA: 0xEF89D0 Offset: 0xEF6FD0 VA: 0x180EF89D0
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6DE0 Offset: 0xEF53E0 VA: 0x180EF6DE0
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5150 Offset: 0xEF3750 VA: 0x180EF5150
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0xEF7EC0 Offset: 0xEF64C0 VA: 0x180EF7EC0
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0xEF8610 Offset: 0xEF6C10 VA: 0x180EF8610
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6500 Offset: 0xEF4B00 VA: 0x180EF6500
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5D60 Offset: 0xEF4360 VA: 0x180EF5D60
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6360 Offset: 0xEF4960 VA: 0x180EF6360
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF66F0 Offset: 0xEF4CF0 VA: 0x180EF66F0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6140 Offset: 0xEF4740 VA: 0x180EF6140
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6280 Offset: 0xEF4880 VA: 0x180EF6280
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5E20 Offset: 0xEF4420 VA: 0x180EF5E20
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5FB0 Offset: 0xEF45B0 VA: 0x180EF5FB0
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF4E50 Offset: 0xEF3450 VA: 0x180EF4E50
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0xEF74B0 Offset: 0xEF5AB0 VA: 0x180EF74B0
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0xEF8380 Offset: 0xEF6980 VA: 0x180EF8380
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF5870 Offset: 0xEF3E70 VA: 0x180EF5870
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5B30 Offset: 0xEF4130 VA: 0x180EF5B30
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5230 Offset: 0xEF3830 VA: 0x180EF5230
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5580 Offset: 0xEF3B80 VA: 0x180EF5580
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5790 Offset: 0xEF3D90 VA: 0x180EF5790
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5260 Offset: 0xEF3860 VA: 0x180EF5260
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF53F0 Offset: 0xEF39F0 VA: 0x180EF53F0
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF49A0 Offset: 0xEF2FA0 VA: 0x180EF49A0
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF7080 Offset: 0xEF5680 VA: 0x180EF7080
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF8790 Offset: 0xEF6D90 VA: 0x180EF8790
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0xEF68E0 Offset: 0xEF4EE0 VA: 0x180EF68E0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6850 Offset: 0xEF4E50 VA: 0x180EF6850
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF67C0 Offset: 0xEF4DC0 VA: 0x180EF67C0
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7BA0 Offset: 0xEF61A0 VA: 0x180EF7BA0
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0xEF8490 Offset: 0xEF6A90 VA: 0x180EF8490
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0xEF5C80 Offset: 0xEF4280 VA: 0x180EF5C80
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5BF0 Offset: 0xEF41F0 VA: 0x180EF5BF0
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF5BC0 Offset: 0xEF41C0 VA: 0x180EF5BC0
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF4A40 Offset: 0xEF3040 VA: 0x180EF4A40
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0xEF7360 Offset: 0xEF5960 VA: 0x180EF7360
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0xEF8870 Offset: 0xEF6E70 VA: 0x180EF8870
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6CC0 Offset: 0xEF52C0 VA: 0x180EF6CC0
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6C30 Offset: 0xEF5230 VA: 0x180EF6C30
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF6BA0 Offset: 0xEF51A0 VA: 0x180EF6BA0
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF7CC0 Offset: 0xEF62C0 VA: 0x180EF7CC0
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0xEF8520 Offset: 0xEF6B20 VA: 0x180EF8520
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF7390 Offset: 0xEF5990 VA: 0x180EF7390
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0xEF82F0 Offset: 0xEF68F0 VA: 0x180EF82F0
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF6F80 Offset: 0xEF5580 VA: 0x180EF6F80
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0xEF2730 Offset: 0xEF0D30 VA: 0x180EF2730
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xEF2D60 Offset: 0xEF1360 VA: 0x180EF2D60
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xEF2BA0 Offset: 0xEF11A0 VA: 0x180EF2BA0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0xEF2980 Offset: 0xEF0F80 VA: 0x180EF2980
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0xEF1F50 Offset: 0xEF0550 VA: 0x180EF1F50
	private void AddOrder() { }

	// RVA: 0xEF2F20 Offset: 0xEF1520 VA: 0x180EF2F20
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0xEF3AC0 Offset: 0xEF20C0 VA: 0x180EF3AC0
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF3980 Offset: 0xEF1F80 VA: 0x180EF3980
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEF2B60 Offset: 0xEF1160 VA: 0x180EF2B60
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0xEF36C0 Offset: 0xEF1CC0 VA: 0x180EF36C0
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF3800 Offset: 0xEF1E00 VA: 0x180EF3800
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEF22B0 Offset: 0xEF08B0 VA: 0x180EF22B0
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0xEF3940 Offset: 0xEF1F40 VA: 0x180EF3940
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0xEF6E70 Offset: 0xEF5470 VA: 0x180EF6E70
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0xEF4910 Offset: 0xEF2F10 VA: 0x180EF4910
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0xEF23C0 Offset: 0xEF09C0 VA: 0x180EF23C0
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0xEF2600 Offset: 0xEF0C00 VA: 0x180EF2600
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0xEF2000 Offset: 0xEF0600 VA: 0x180EF2000
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0xEF2160 Offset: 0xEF0760 VA: 0x180EF2160
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0xEF2B90 Offset: 0xEF1190 VA: 0x180EF2B90
	private bool IsGlobal(int flags) { }

	// RVA: 0xEF47F0 Offset: 0xEF2DF0 VA: 0x180EF47F0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xEF4680 Offset: 0xEF2C80 VA: 0x180EF4680
	private void SendValidationEvent(string code) { }

	// RVA: 0xEF4570 Offset: 0xEF2B70 VA: 0x180EF4570
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xEF46E0 Offset: 0xEF2CE0 VA: 0x180EF46E0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xEF8A50 Offset: 0xEF7050 VA: 0x180EF8A50
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

	// RVA: 0x1429310 Offset: 0x1427910 VA: 0x181429310
	internal void .ctor() { }

	// RVA: 0x1429200 Offset: 0x1427800 VA: 0x181429200
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

	// RVA: 0x1429420 Offset: 0x1427A20 VA: 0x181429420
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x1429450 Offset: 0x1427A50 VA: 0x181429450
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

	// RVA: 0x14299A0 Offset: 0x1427FA0 VA: 0x1814299A0 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x130F9A0 Offset: 0x130DFA0 VA: 0x18130F9A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 2297
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 2298
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14296F0 Offset: 0x1427CF0 VA: 0x1814296F0 Slot: 12
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

	// RVA: 0x14296F0 Offset: 0x1427CF0 VA: 0x1814296F0 Slot: 12
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

	// RVA: 0x1429610 Offset: 0x1427C10 VA: 0x181429610
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x1429680 Offset: 0x1427C80 VA: 0x181429680
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

	// RVA: 0x1429EA0 Offset: 0x14284A0 VA: 0x181429EA0
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}

