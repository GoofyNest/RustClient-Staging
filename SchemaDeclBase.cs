internal abstract class SchemaDeclBase // TypeDefIndex: 2275
{	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0xEE64F0 Offset: 0xEE4AF0 VA: 0x180EE64F0
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE65C0 Offset: 0xEE4BC0 VA: 0x180EE65C0
	protected void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0xEE6690 Offset: 0xEE4C90 VA: 0x180EE6690
	internal string get_Prefix() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Prefix(string value) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal long get_MaxLength() { }

	// RVA: 0xEE66E0 Offset: 0xEE4CE0 VA: 0x180EE66E0
	internal void set_MaxLength(long value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal long get_MinLength() { }

	// RVA: 0xEE66F0 Offset: 0xEE4CF0 VA: 0x180EE66F0
	internal void set_MinLength(long value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0xEE6340 Offset: 0xEE4940 VA: 0x180EE6340
	internal void AddValue(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal List<string> get_Values() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void set_Values(List<string> value) { }

	// RVA: 0xEE6640 Offset: 0xEE4C40 VA: 0x180EE6640
	internal string get_DefaultValueRaw() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal object get_DefaultValueTyped() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0xEE63E0 Offset: 0xEE49E0 VA: 0x180EE63E0
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0xEE64A0 Offset: 0xEE4AA0 VA: 0x180EE64A0
	internal bool CheckValue(object pVal) { }

}

internal enum SchemaDeclBase.Use // TypeDefIndex: 2276
{	// Fields
	public int value__; // 0x0
	public const SchemaDeclBase.Use Default = 0;
	public const SchemaDeclBase.Use Required = 1;
	public const SchemaDeclBase.Use Implied = 2;
	public const SchemaDeclBase.Use Fixed = 3;
	public const SchemaDeclBase.Use RequiredFixed = 4;

}

