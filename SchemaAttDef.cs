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

	// RVA: 0xB28EE0 Offset: 0xB274E0 VA: 0x180B28EE0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xB28F00 Offset: 0xB27500 VA: 0x180B28F00
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0xB28EF0 Offset: 0xB274F0 VA: 0x180B28EF0
	private void .ctor() { }

	// RVA: 0xB28E10 Offset: 0xB27410 VA: 0x180B28E10 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xB28DF0 Offset: 0xB273F0 VA: 0x180B28DF0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x803B90 Offset: 0x802190 VA: 0x180803B90 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x803B70 Offset: 0x802170 VA: 0x180803B70 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0xB28DB0 Offset: 0xB273B0 VA: 0x180B28DB0 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xB28DE0 Offset: 0xB273E0 VA: 0x180B28DE0 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0xB28E20 Offset: 0xB27420 VA: 0x180B28E20 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xB28E70 Offset: 0xB27470 VA: 0x180B28E70 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x803B70 Offset: 0x802170 VA: 0x180803B70
	internal int get_LinePosition() { }

	// RVA: 0x803BA0 Offset: 0x8021A0 VA: 0x180803BA0
	internal void set_LinePosition(int value) { }

	// RVA: 0x803B90 Offset: 0x802190 VA: 0x180803B90
	internal int get_LineNumber() { }

	// RVA: 0x803BC0 Offset: 0x8021C0 VA: 0x180803BC0
	internal void set_LineNumber(int value) { }

	// RVA: 0xB28E70 Offset: 0xB27470 VA: 0x180B28E70
	internal int get_ValueLinePosition() { }

	// RVA: 0xB28FD0 Offset: 0xB275D0 VA: 0x180B28FD0
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80
	internal int get_ValueLineNumber() { }

	// RVA: 0x803BB0 Offset: 0x8021B0 VA: 0x180803BB0
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0xB28F10 Offset: 0xB27510 VA: 0x180B28F10
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0xB28F60 Offset: 0xB27560 VA: 0x180B28F60
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xB28FA0 Offset: 0xB275A0 VA: 0x180B28FA0
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0xB28F90 Offset: 0xB27590 VA: 0x180B28F90
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x966200 Offset: 0x964800 VA: 0x180966200
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0xB28B10 Offset: 0xB27110 VA: 0x180B28B10
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0xB28D50 Offset: 0xB27350 VA: 0x180B28D50
	internal SchemaAttDef Clone() { }

	// RVA: 0xB28E80 Offset: 0xB27480 VA: 0x180B28E80
	private static void .cctor() { }

}

internal enum SchemaAttDef.Reserve // TypeDefIndex: 2270
{	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;

}

