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

	// RVA: 0xE9BDD0 Offset: 0xE9A3D0 VA: 0x180E9BDD0
	internal void .ctor(string baseType) { }

	// RVA: 0xE9BF20 Offset: 0xE9A520 VA: 0x180E9BF20
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xE9B8F0 Offset: 0xE99EF0 VA: 0x180E9B8F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9B030 Offset: 0xE99630 VA: 0x180E9B030
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xE9AF20 Offset: 0xE99520 VA: 0x180E9AF20
	internal bool IsPlainString() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string get_BaseType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal string get_Name() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal string get_Namespace() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal int get_Length() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	internal int get_MaxLength() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	internal void set_MaxLength(int value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xE9C110 Offset: 0xE9A710 VA: 0x180E9C110
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xE9B880 Offset: 0xE99E80 VA: 0x180E9B880
	internal string QualifiedName(string name) { }

	// RVA: 0xE9B940 Offset: 0xE99F40 VA: 0x180E9B940
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xE9AC80 Offset: 0xE99280 VA: 0x180E9AC80
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xE9AC30 Offset: 0xE99230 VA: 0x180E9AC30
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xE9AD00 Offset: 0xE99300 VA: 0x180E9AD00
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xE9AD70 Offset: 0xE99370 VA: 0x180E9AD70
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xE9AE30 Offset: 0xE99430 VA: 0x180E9AE30
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xE9AAF0 Offset: 0xE990F0 VA: 0x180E9AAF0
	internal bool CanHaveMaxLength() { }

	// RVA: 0xE9AB70 Offset: 0xE99170 VA: 0x180E9AB70
	internal void ConvertToAnnonymousSimpleType() { }

}

