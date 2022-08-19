internal class TypeData // TypeDefIndex: 2062
{	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x1106CE0 Offset: 0x11052E0 VA: 0x181106CE0
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x11067F0 Offset: 0x1104DF0 VA: 0x1811067F0
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x11046D0 Offset: 0x1102CD0 VA: 0x1811046D0
	private void LookupTypeConvertor() { }

	// RVA: 0x1104170 Offset: 0x1102770 VA: 0x181104170
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_TypeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_XmlType() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Type get_Type() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_FullTypeName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x8C1000 Offset: 0x8BF600 VA: 0x1808C1000
	public bool get_IsListType() { }

	// RVA: 0x1106D00 Offset: 0x1105300 VA: 0x181106D00
	public bool get_IsComplexType() { }

	// RVA: 0x1106EB0 Offset: 0x11054B0 VA: 0x181106EB0
	public bool get_IsValueType() { }

	// RVA: 0x1106D20 Offset: 0x1105320 VA: 0x181106D20
	public bool get_IsNullable() { }

	// RVA: 0x10865F0 Offset: 0x1084BF0 VA: 0x1810865F0
	public void set_IsNullable(bool value) { }

	// RVA: 0x1106F50 Offset: 0x1105550 VA: 0x181106F50
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x1107020 Offset: 0x1105620 VA: 0x181107020
	public Type get_ListItemType() { }

	// RVA: 0x831920 Offset: 0x82FF20 VA: 0x180831920
	public bool get_IsXsdType() { }

	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0
	public bool get_HasPublicConstructor() { }

	// RVA: 0x1104580 Offset: 0x1102B80 VA: 0x181104580
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1104270 Offset: 0x1102870 VA: 0x181104270
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x1104370 Offset: 0x1102970 VA: 0x181104370
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x1104780 Offset: 0x1102D80 VA: 0x181104780
	private static void .cctor() { }

}

