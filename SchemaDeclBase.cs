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

	// RVA: 0xEE6FA0 Offset: 0xEE55A0 VA: 0x180EE6FA0
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE7070 Offset: 0xEE5670 VA: 0x180EE7070
	protected void .ctor() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0xEE7140 Offset: 0xEE5740 VA: 0x180EE7140
	internal string get_Prefix() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Prefix(string value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal long get_MaxLength() { }

	// RVA: 0xEE7190 Offset: 0xEE5790 VA: 0x180EE7190
	internal void set_MaxLength(long value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal long get_MinLength() { }

	// RVA: 0xEE71A0 Offset: 0xEE57A0 VA: 0x180EE71A0
	internal void set_MinLength(long value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0xEE6DF0 Offset: 0xEE53F0 VA: 0x180EE6DF0
	internal void AddValue(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal List<string> get_Values() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void set_Values(List<string> value) { }

	// RVA: 0xEE70F0 Offset: 0xEE56F0 VA: 0x180EE70F0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal object get_DefaultValueTyped() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0xEE6F50 Offset: 0xEE5550 VA: 0x180EE6F50
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

