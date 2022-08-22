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

	// RVA: 0xB293B0 Offset: 0xB279B0 VA: 0x180B293B0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xB293D0 Offset: 0xB279D0 VA: 0x180B293D0
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0xB293C0 Offset: 0xB279C0 VA: 0x180B293C0
	private void .ctor() { }

	// RVA: 0xB292E0 Offset: 0xB278E0 VA: 0x180B292E0 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xB292C0 Offset: 0xB278C0 VA: 0x180B292C0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x804120 Offset: 0x802720 VA: 0x180804120 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x804100 Offset: 0x802700 VA: 0x180804100 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0xB29280 Offset: 0xB27880 VA: 0x180B29280 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xB292B0 Offset: 0xB278B0 VA: 0x180B292B0 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0xB292F0 Offset: 0xB278F0 VA: 0x180B292F0 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xB29340 Offset: 0xB27940 VA: 0x180B29340 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x804100 Offset: 0x802700 VA: 0x180804100
	internal int get_LinePosition() { }

	// RVA: 0x804130 Offset: 0x802730 VA: 0x180804130
	internal void set_LinePosition(int value) { }

	// RVA: 0x804120 Offset: 0x802720 VA: 0x180804120
	internal int get_LineNumber() { }

	// RVA: 0x804150 Offset: 0x802750 VA: 0x180804150
	internal void set_LineNumber(int value) { }

	// RVA: 0xB29340 Offset: 0xB27940 VA: 0x180B29340
	internal int get_ValueLinePosition() { }

	// RVA: 0xB294A0 Offset: 0xB27AA0 VA: 0x180B294A0
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110
	internal int get_ValueLineNumber() { }

	// RVA: 0x804140 Offset: 0x802740 VA: 0x180804140
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0xB293E0 Offset: 0xB279E0 VA: 0x180B293E0
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0xB29430 Offset: 0xB27A30 VA: 0x180B29430
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xB29470 Offset: 0xB27A70 VA: 0x180B29470
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0xB29460 Offset: 0xB27A60 VA: 0x180B29460
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x966700 Offset: 0x964D00 VA: 0x180966700
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0xB28FE0 Offset: 0xB275E0 VA: 0x180B28FE0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0xB29220 Offset: 0xB27820 VA: 0x180B29220
	internal SchemaAttDef Clone() { }

	// RVA: 0xB29350 Offset: 0xB27950 VA: 0x180B29350
	private static void .cctor() { }

}

internal enum SchemaAttDef.Reserve // TypeDefIndex: 2270
{	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;

}

