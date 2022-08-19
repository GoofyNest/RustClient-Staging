internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 2269
{	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0xB28C20 Offset: 0xB27220 VA: 0x180B28C20
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xB28C40 Offset: 0xB27240 VA: 0x180B28C40
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0xB28C30 Offset: 0xB27230 VA: 0x180B28C30
	private void .ctor() { }

	// RVA: 0xB28B50 Offset: 0xB27150 VA: 0x180B28B50 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x803A80 Offset: 0x802080 VA: 0x180803A80 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x803A60 Offset: 0x802060 VA: 0x180803A60 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0xB28AF0 Offset: 0xB270F0 VA: 0x180B28AF0 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xB28B20 Offset: 0xB27120 VA: 0x180B28B20 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0xB28B60 Offset: 0xB27160 VA: 0x180B28B60 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xB28BB0 Offset: 0xB271B0 VA: 0x180B28BB0 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x803A60 Offset: 0x802060 VA: 0x180803A60
	internal int get_LinePosition() { }

	// RVA: 0x803A90 Offset: 0x802090 VA: 0x180803A90
	internal void set_LinePosition(int value) { }

	// RVA: 0x803A80 Offset: 0x802080 VA: 0x180803A80
	internal int get_LineNumber() { }

	// RVA: 0x803AB0 Offset: 0x8020B0 VA: 0x180803AB0
	internal void set_LineNumber(int value) { }

	// RVA: 0xB28BB0 Offset: 0xB271B0 VA: 0x180B28BB0
	internal int get_ValueLinePosition() { }

	// RVA: 0xB28D10 Offset: 0xB27310 VA: 0x180B28D10
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70
	internal int get_ValueLineNumber() { }

	// RVA: 0x803AA0 Offset: 0x8020A0 VA: 0x180803AA0
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0xB28C50 Offset: 0xB27250 VA: 0x180B28C50
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0xB28CA0 Offset: 0xB272A0 VA: 0x180B28CA0
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xB28CE0 Offset: 0xB272E0 VA: 0x180B28CE0
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x9660F0 Offset: 0x9646F0 VA: 0x1809660F0
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0xB28850 Offset: 0xB26E50 VA: 0x180B28850
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0xB28A90 Offset: 0xB27090 VA: 0x180B28A90
	internal SchemaAttDef Clone() { }

	// RVA: 0xB28BC0 Offset: 0xB271C0 VA: 0x180B28BC0
	private static void .cctor() { }

}

internal enum SchemaAttDef.Reserve // TypeDefIndex: 2270
{	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;

}

