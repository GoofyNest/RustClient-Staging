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

	// RVA: 0xE9B060 Offset: 0xE99660 VA: 0x180E9B060
	internal void .ctor(string baseType) { }

	// RVA: 0xE9B1B0 Offset: 0xE997B0 VA: 0x180E9B1B0
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xE9AB80 Offset: 0xE99180 VA: 0x180E9AB80 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9A2C0 Offset: 0xE988C0 VA: 0x180E9A2C0
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xE9A1B0 Offset: 0xE987B0 VA: 0x180E9A1B0
	internal bool IsPlainString() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_BaseType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal string get_Name() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_Namespace() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal int get_Length() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	internal int get_MaxLength() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	internal void set_MaxLength(int value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xE9B3A0 Offset: 0xE999A0 VA: 0x180E9B3A0
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xE9AB10 Offset: 0xE99110 VA: 0x180E9AB10
	internal string QualifiedName(string name) { }

	// RVA: 0xE9ABD0 Offset: 0xE991D0 VA: 0x180E9ABD0
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xE99F10 Offset: 0xE98510 VA: 0x180E99F10
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xE99EC0 Offset: 0xE984C0 VA: 0x180E99EC0
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xE99F90 Offset: 0xE98590 VA: 0x180E99F90
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xE9A000 Offset: 0xE98600 VA: 0x180E9A000
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xE9A0C0 Offset: 0xE986C0 VA: 0x180E9A0C0
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xE99D80 Offset: 0xE98380 VA: 0x180E99D80
	internal bool CanHaveMaxLength() { }

	// RVA: 0xE99E00 Offset: 0xE98400 VA: 0x180E99E00
	internal void ConvertToAnnonymousSimpleType() { }

}

