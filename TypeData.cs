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

	// RVA: 0x1106FA0 Offset: 0x11055A0 VA: 0x181106FA0
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1106AB0 Offset: 0x11050B0 VA: 0x181106AB0
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x1104990 Offset: 0x1102F90 VA: 0x181104990
	private void LookupTypeConvertor() { }

	// RVA: 0x1104430 Offset: 0x1102A30 VA: 0x181104430
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

	// RVA: 0x8C1110 Offset: 0x8BF710 VA: 0x1808C1110
	public bool get_IsListType() { }

	// RVA: 0x1106FC0 Offset: 0x11055C0 VA: 0x181106FC0
	public bool get_IsComplexType() { }

	// RVA: 0x1107170 Offset: 0x1105770 VA: 0x181107170
	public bool get_IsValueType() { }

	// RVA: 0x1106FE0 Offset: 0x11055E0 VA: 0x181106FE0
	public bool get_IsNullable() { }

	// RVA: 0x10868B0 Offset: 0x1084EB0 VA: 0x1810868B0
	public void set_IsNullable(bool value) { }

	// RVA: 0x1107210 Offset: 0x1105810 VA: 0x181107210
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x11072E0 Offset: 0x11058E0 VA: 0x1811072E0
	public Type get_ListItemType() { }

	// RVA: 0x831A30 Offset: 0x830030 VA: 0x180831A30
	public bool get_IsXsdType() { }

	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0
	public bool get_HasPublicConstructor() { }

	// RVA: 0x1104840 Offset: 0x1102E40 VA: 0x181104840
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1104530 Offset: 0x1102B30 VA: 0x181104530
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x1104630 Offset: 0x1102C30 VA: 0x181104630
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x1104A40 Offset: 0x1103040 VA: 0x181104A40
	private static void .cctor() { }

}

