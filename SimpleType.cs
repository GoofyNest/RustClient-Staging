internal sealed class SimpleType : ISerializable // TypeDefIndex: 4307
{	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0xE9B320 Offset: 0xE99920 VA: 0x180E9B320
	internal void .ctor(string baseType) { }

	// RVA: 0xE9B470 Offset: 0xE99A70 VA: 0x180E9B470
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xE9AE40 Offset: 0xE99440 VA: 0x180E9AE40 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9A580 Offset: 0xE98B80 VA: 0x180E9A580
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xE9A470 Offset: 0xE98A70 VA: 0x180E9A470
	internal bool IsPlainString() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_BaseType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal string get_Name() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_Namespace() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal int get_Length() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	internal int get_MaxLength() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	internal void set_MaxLength(int value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xE9B660 Offset: 0xE99C60 VA: 0x180E9B660
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xE9ADD0 Offset: 0xE993D0 VA: 0x180E9ADD0
	internal string QualifiedName(string name) { }

	// RVA: 0xE9AE90 Offset: 0xE99490 VA: 0x180E9AE90
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xE9A1D0 Offset: 0xE987D0 VA: 0x180E9A1D0
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xE9A180 Offset: 0xE98780 VA: 0x180E9A180
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xE9A250 Offset: 0xE98850 VA: 0x180E9A250
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xE9A2C0 Offset: 0xE988C0 VA: 0x180E9A2C0
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xE9A380 Offset: 0xE98980 VA: 0x180E9A380
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xE9A040 Offset: 0xE98640 VA: 0x180E9A040
	internal bool CanHaveMaxLength() { }

	// RVA: 0xE9A0C0 Offset: 0xE986C0 VA: 0x180E9A0C0
	internal void ConvertToAnnonymousSimpleType() { }

}

