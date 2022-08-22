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

	// RVA: 0x1107A10 Offset: 0x1106010 VA: 0x181107A10
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1107520 Offset: 0x1105B20 VA: 0x181107520
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x1105400 Offset: 0x1103A00 VA: 0x181105400
	private void LookupTypeConvertor() { }

	// RVA: 0x1104EA0 Offset: 0x11034A0 VA: 0x181104EA0
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_TypeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_XmlType() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Type get_Type() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_FullTypeName() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x8C1620 Offset: 0x8BFC20 VA: 0x1808C1620
	public bool get_IsListType() { }

	// RVA: 0x1107A30 Offset: 0x1106030 VA: 0x181107A30
	public bool get_IsComplexType() { }

	// RVA: 0x1107BE0 Offset: 0x11061E0 VA: 0x181107BE0
	public bool get_IsValueType() { }

	// RVA: 0x1107A50 Offset: 0x1106050 VA: 0x181107A50
	public bool get_IsNullable() { }

	// RVA: 0x1087320 Offset: 0x1085920 VA: 0x181087320
	public void set_IsNullable(bool value) { }

	// RVA: 0x1107C80 Offset: 0x1106280 VA: 0x181107C80
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x1107D50 Offset: 0x1106350 VA: 0x181107D50
	public Type get_ListItemType() { }

	// RVA: 0x831F80 Offset: 0x830580 VA: 0x180831F80
	public bool get_IsXsdType() { }

	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780
	public bool get_HasPublicConstructor() { }

	// RVA: 0x11052B0 Offset: 0x11038B0 VA: 0x1811052B0
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1104FA0 Offset: 0x11035A0 VA: 0x181104FA0
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x11050A0 Offset: 0x11036A0 VA: 0x1811050A0
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x11054B0 Offset: 0x1103AB0 VA: 0x1811054B0
	private static void .cctor() { }

}

