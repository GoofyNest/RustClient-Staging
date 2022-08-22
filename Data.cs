public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{	// Fields
	public static readonly DBNull Value; // 0x139B0

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1795110 Offset: 0x1793710 VA: 0x181795110
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1794960 Offset: 0x1792F60 VA: 0x181794960 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1795070 Offset: 0x1793670 VA: 0x181795070 Slot: 3
	public override string ToString() { }

	// RVA: 0x1795030 Offset: 0x1793630 VA: 0x181795030 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1794990 Offset: 0x1792F90 VA: 0x181794990 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1794A70 Offset: 0x1793070 VA: 0x181794A70 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1794D80 Offset: 0x1793380 VA: 0x181794D80 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1794A00 Offset: 0x1793000 VA: 0x181794A00 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1794C30 Offset: 0x1793230 VA: 0x181794C30 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1794EE0 Offset: 0x17934E0 VA: 0x181794EE0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1794CA0 Offset: 0x17932A0 VA: 0x181794CA0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1794F50 Offset: 0x1793550 VA: 0x181794F50 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1794D10 Offset: 0x1793310 VA: 0x181794D10 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1794FC0 Offset: 0x17935C0 VA: 0x181794FC0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1794DF0 Offset: 0x17933F0 VA: 0x181794DF0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1794BC0 Offset: 0x17931C0 VA: 0x181794BC0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1794B50 Offset: 0x1793150 VA: 0x181794B50 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1794AE0 Offset: 0x17930E0 VA: 0x181794AE0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1794E60 Offset: 0x1793460 VA: 0x181794E60 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17950B0 Offset: 0x17936B0 VA: 0x1817950B0
	private static void .cctor() { }

}

internal struct DataCollector // TypeDefIndex: 1509
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static DataCollector ThreadInstance; // 0x80000000
	private byte* scratchEnd; // 0x0
	private EventSource.EventData* datasEnd; // 0x8
	private GCHandle* pinsEnd; // 0x10
	private EventSource.EventData* datasStart; // 0x18
	private byte* scratch; // 0x20
	private EventSource.EventData* datas; // 0x28
	private GCHandle* pins; // 0x30
	private byte[] buffer; // 0x38
	private int bufferPos; // 0x40
	private int bufferNesting; // 0x44
	private bool writingScalars; // 0x48

	// Methods

	// RVA: 0x120910 Offset: 0x11FD10 VA: 0x180120910
	internal void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	// RVA: 0x1208F0 Offset: 0x11FCF0 VA: 0x1801208F0
	internal void Disable() { }

	// RVA: 0x120AB0 Offset: 0x11FEB0 VA: 0x180120AB0
	internal EventSource.EventData* Finish() { }

	// RVA: 0x120890 Offset: 0x11FC90 VA: 0x180120890
	internal void AddScalar(void* value, int size) { }

	// RVA: 0x120850 Offset: 0x11FC50 VA: 0x180120850
	internal void AddBinary(string value, int size) { }

	// RVA: 0x120860 Offset: 0x11FC60 VA: 0x180120860
	internal void AddBinary(Array value, int size) { }

	// RVA: 0x120840 Offset: 0x11FC40 VA: 0x180120840
	internal void AddArray(Array value, int length, int itemSize) { }

	// RVA: 0x1208A0 Offset: 0x11FCA0 VA: 0x1801208A0
	internal int BeginBufferedArray() { }

	// RVA: 0x120960 Offset: 0x11FD60 VA: 0x180120960
	internal void EndBufferedArray(int bookmark, int count) { }

	// RVA: 0x1208D0 Offset: 0x11FCD0 VA: 0x1801208D0
	internal void BeginBuffered() { }

	// RVA: 0x120A30 Offset: 0x11FE30 VA: 0x180120A30
	internal void EndBuffered() { }

	// RVA: 0x120A90 Offset: 0x11FE90 VA: 0x180120A90
	private void EnsureBuffer() { }

	// RVA: 0x120AA0 Offset: 0x11FEA0 VA: 0x180120AA0
	private void EnsureBuffer(int additionalSize) { }

	// RVA: 0x120AD0 Offset: 0x11FED0 VA: 0x180120AD0
	private void GrowBuffer(int required) { }

	// RVA: 0x120B30 Offset: 0x11FF30 VA: 0x180120B30
	private void PinArray(object value, int size) { }

	// RVA: 0x120B40 Offset: 0x11FF40 VA: 0x180120B40
	private void ScalarsBegin() { }

	// RVA: 0x120B50 Offset: 0x11FF50 VA: 0x180120B50
	private void ScalarsEnd() { }

}

internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 2179
{	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1504A70 Offset: 0x1503070 VA: 0x181504A70
	private static void .cctor() { }

	// RVA: 0x150A660 Offset: 0x1508C60 VA: 0x18150A660
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x150A760 Offset: 0x1508D60 VA: 0x18150A760
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x1503550 Offset: 0x1501B50 VA: 0x181503550
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x15034C0 Offset: 0x1501AC0 VA: 0x1815034C0
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x15033D0 Offset: 0x15019D0 VA: 0x1815033D0
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x15032E0 Offset: 0x15018E0 VA: 0x1815032E0
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x1504690 Offset: 0x1502C90 VA: 0x181504690
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1503030 Offset: 0x1501630 VA: 0x181503030
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x15019B0 Offset: 0x14FFFB0 VA: 0x1815019B0
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1503A10 Offset: 0x1502010 VA: 0x181503A10
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1503AA0 Offset: 0x15020A0 VA: 0x181503AA0
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1503640 Offset: 0x1501C40 VA: 0x181503640
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1503B70 Offset: 0x1502170 VA: 0x181503B70
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x15035E0 Offset: 0x1501BE0 VA: 0x1815035E0
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x15038A0 Offset: 0x1501EA0 VA: 0x1815038A0
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1502DA0 Offset: 0x15013A0 VA: 0x181502DA0 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1502D90 Offset: 0x1501390 VA: 0x181502D90 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x1502A60 Offset: 0x1501060 VA: 0x181502A60
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x1502EF0 Offset: 0x15014F0 VA: 0x181502EF0
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1503F50 Offset: 0x1502550 VA: 0x181503F50 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1504290 Offset: 0x1502890 VA: 0x181504290 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1503E50 Offset: 0x1502450 VA: 0x181503E50 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150A6C0 Offset: 0x1508CC0 VA: 0x18150A6C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150A7C0 Offset: 0x1508DC0 VA: 0x18150A7C0 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A800 Offset: 0x1508E00 VA: 0x18150A800 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x150A720 Offset: 0x1508D20 VA: 0x18150A720 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x150A740 Offset: 0x1508D40 VA: 0x18150A740 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1504460 Offset: 0x1502A60 VA: 0x181504460 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15042B0 Offset: 0x15028B0 VA: 0x1815042B0 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x1504760 Offset: 0x1502D60 VA: 0x181504760 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1503DD0 Offset: 0x15023D0 VA: 0x181503DD0
	internal string GetTypeName() { }

	// RVA: 0x1501930 Offset: 0x14FFF30 VA: 0x181501930
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 2180
{	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x13853C0 Offset: 0x13839C0 VA: 0x1813853C0
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x14B70F0 Offset: 0x14B56F0 VA: 0x1814B70F0
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_ParentIndex() { }

	// RVA: 0x151DA80 Offset: 0x151C080 VA: 0x18151DA80 Slot: 4
	public int CompareTo(object obj) { }

}

internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 2181
{	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150ABB0 Offset: 0x15091B0 VA: 0x18150ABB0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150B930 Offset: 0x1509F30 VA: 0x18150B930
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x150A8A0 Offset: 0x1508EA0 VA: 0x18150A8A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150BA80 Offset: 0x150A080 VA: 0x18150BA80 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150BA50 Offset: 0x150A050 VA: 0x18150BA50 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150B9F0 Offset: 0x1509FF0 VA: 0x18150B9F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150BAB0 Offset: 0x150A0B0 VA: 0x18150BAB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150AF10 Offset: 0x1509510 VA: 0x18150AF10 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x150B470 Offset: 0x1509A70 VA: 0x18150B470 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 2182
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x1512D40 Offset: 0x1511340 VA: 0x181512D40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x15135C0 Offset: 0x1511BC0 VA: 0x1815135C0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1512C40 Offset: 0x1511240 VA: 0x181512C40 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1513730 Offset: 0x1511D30 VA: 0x181513730 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513670 Offset: 0x1511C70 VA: 0x181513670 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15136D0 Offset: 0x1511CD0 VA: 0x1815136D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xEDA490 Offset: 0xED8A90 VA: 0x180EDA490 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1512D50 Offset: 0x1511350 VA: 0x181512D50
	internal bool HasAtomicMembers() { }

	// RVA: 0x1512DF0 Offset: 0x15113F0 VA: 0x181512DF0
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1512EB0 Offset: 0x15114B0 VA: 0x181512EB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513120 Offset: 0x1511720 VA: 0x181513120 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513520 Offset: 0x1511B20 VA: 0x181513520
	private static void .cctor() { }

}

internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 2183
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x150CC70 Offset: 0x150B270 VA: 0x18150CC70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150CE00 Offset: 0x150B400 VA: 0x18150CE00 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150CEC0 Offset: 0x150B4C0 VA: 0x18150CEC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150CE60 Offset: 0x150B460 VA: 0x18150CE60 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150CC00 Offset: 0x150B200 VA: 0x18150CC00 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150CCD0 Offset: 0x150B2D0 VA: 0x18150CCD0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150CDA0 Offset: 0x150B3A0 VA: 0x18150CDA0
	public void .ctor() { }

	// RVA: 0x150CD00 Offset: 0x150B300 VA: 0x18150CD00
	private static void .cctor() { }

}

internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 2184
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150CB10 Offset: 0x150B110 VA: 0x18150CB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70
	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1514BA0 Offset: 0x15131A0 VA: 0x181514BA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11BB880 Offset: 0x11B9E80 VA: 0x1811BB880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514C00 Offset: 0x1513200 VA: 0x181514C00
	public void .ctor() { }

}

internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 2186
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x15128F0 Offset: 0x1510EF0 VA: 0x1815128F0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1512AB0 Offset: 0x15110B0 VA: 0x181512AB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1512900 Offset: 0x1510F00 VA: 0x181512900 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512A20 Offset: 0x1511020 VA: 0x181512A20
	public void .ctor() { }

}

internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 2187
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150DA40 Offset: 0x150C040 VA: 0x18150DA40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150DCA0 Offset: 0x150C2A0 VA: 0x18150DCA0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x132B880 Offset: 0x1329E80 VA: 0x18132B880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150DD60 Offset: 0x150C360 VA: 0x18150DD60 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150DD00 Offset: 0x150C300 VA: 0x18150DD00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xEDA4D0 Offset: 0xED8AD0 VA: 0x180EDA4D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150D9C0 Offset: 0x150BFC0 VA: 0x18150D9C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150DA50 Offset: 0x150C050 VA: 0x18150DA50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150DC10 Offset: 0x150C210 VA: 0x18150DC10
	public void .ctor() { }

	// RVA: 0x150DB70 Offset: 0x150C170 VA: 0x18150DB70
	private static void .cctor() { }

}

internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 2188
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510B80 Offset: 0x150F180 VA: 0x181510B80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x10E58F0 Offset: 0x10E3EF0 VA: 0x1810E58F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510C40 Offset: 0x150F240 VA: 0x181510C40 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1510BE0 Offset: 0x150F1E0 VA: 0x181510BE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150ED60 Offset: 0x150D360 VA: 0x18150ED60 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510840 Offset: 0x150EE40 VA: 0x181510840 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15108C0 Offset: 0x150EEC0 VA: 0x1815108C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510AF0 Offset: 0x150F0F0 VA: 0x181510AF0
	public void .ctor() { }

	// RVA: 0x1510A50 Offset: 0x150F050 VA: 0x181510A50
	private static void .cctor() { }

}

internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 2189
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150FCA0 Offset: 0x150E2A0 VA: 0x18150FCA0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xEDA4A0 Offset: 0xED8AA0 VA: 0x180EDA4A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FD60 Offset: 0x150E360 VA: 0x18150FD60 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150FD00 Offset: 0x150E300 VA: 0x18150FD00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150ED60 Offset: 0x150D360 VA: 0x18150ED60 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150F950 Offset: 0x150DF50 VA: 0x18150F950 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F9E0 Offset: 0x150DFE0 VA: 0x18150F9E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150FC10 Offset: 0x150E210 VA: 0x18150FC10
	public void .ctor() { }

	// RVA: 0x150FB70 Offset: 0x150E170 VA: 0x18150FB70
	private static void .cctor() { }

}

internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 2190
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150F290 Offset: 0x150D890 VA: 0x18150F290 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150F610 Offset: 0x150DC10 VA: 0x18150F610 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xBA5670 Offset: 0xBA3C70 VA: 0x180BA5670 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150F6E0 Offset: 0x150DCE0 VA: 0x18150F6E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150F670 Offset: 0x150DC70 VA: 0x18150F670 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150F6D0 Offset: 0x150DCD0 VA: 0x18150F6D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150F210 Offset: 0x150D810 VA: 0x18150F210 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F2A0 Offset: 0x150D8A0 VA: 0x18150F2A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F580 Offset: 0x150DB80 VA: 0x18150F580
	public void .ctor() { }

	// RVA: 0x150F430 Offset: 0x150DA30 VA: 0x18150F430
	private static void .cctor() { }

}

internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 2191
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510160 Offset: 0x150E760 VA: 0x181510160 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE628D0 Offset: 0xE60ED0 VA: 0x180E628D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510220 Offset: 0x150E820 VA: 0x181510220 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15101C0 Offset: 0x150E7C0 VA: 0x1815101C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150ED60 Offset: 0x150D360 VA: 0x18150ED60 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150FDC0 Offset: 0x150E3C0 VA: 0x18150FDC0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150FE40 Offset: 0x150E440 VA: 0x18150FE40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15100D0 Offset: 0x150E6D0 VA: 0x1815100D0
	public void .ctor() { }

	// RVA: 0x1510030 Offset: 0x150E630 VA: 0x181510030
	private static void .cctor() { }

}

internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 2192
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515060 Offset: 0x1513660 VA: 0x181515060 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15152B0 Offset: 0x15138B0 VA: 0x1815152B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515250 Offset: 0x1513850 VA: 0x181515250
	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150EF50 Offset: 0x150D550 VA: 0x18150EF50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F1A0 Offset: 0x150D7A0 VA: 0x18150F1A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150F140 Offset: 0x150D740 VA: 0x18150F140
	public void .ctor() { }

}

internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 2194
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150E7F0 Offset: 0x150CDF0 VA: 0x18150E7F0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150EC90 Offset: 0x150D290 VA: 0x18150EC90 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150ED50 Offset: 0x150D350 VA: 0x18150ED50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150EBF0 Offset: 0x150D1F0 VA: 0x18150EBF0
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x150ED70 Offset: 0x150D370 VA: 0x18150ED70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150ECF0 Offset: 0x150D2F0 VA: 0x18150ECF0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150ED60 Offset: 0x150D360 VA: 0x18150ED60 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E6F0 Offset: 0x150CCF0 VA: 0x18150E6F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E800 Offset: 0x150CE00 VA: 0x18150E800 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150EB50 Offset: 0x150D150 VA: 0x18150EB50
	private static void .cctor() { }

}

internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2195
{	// Methods

	// RVA: 0x150EDD0 Offset: 0x150D3D0 VA: 0x18150EDD0
	internal void .ctor() { }

}

internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2196
{	// Methods

	// RVA: 0x150EE30 Offset: 0x150D430 VA: 0x18150EE30
	internal void .ctor() { }

}

internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 2197
{	// Methods

	// RVA: 0x150EE90 Offset: 0x150D490 VA: 0x18150EE90
	internal void .ctor() { }

}

internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2198
{	// Methods

	// RVA: 0x1512B10 Offset: 0x1511110 VA: 0x181512B10
	internal void .ctor() { }

}

internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2199
{	// Methods

	// RVA: 0x1512B70 Offset: 0x1511170 VA: 0x181512B70
	internal void .ctor() { }

}

internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 2200
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512C30 Offset: 0x1511230 VA: 0x181512C30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512BD0 Offset: 0x15111D0 VA: 0x181512BD0
	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xEDA450 Offset: 0xED8A50 VA: 0x180EDA450 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150EEF0 Offset: 0x150D4F0 VA: 0x18150EEF0
	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515320 Offset: 0x1513920 VA: 0x181515320 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15152C0 Offset: 0x15138C0 VA: 0x1815152C0
	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515390 Offset: 0x1513990 VA: 0x181515390 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515330 Offset: 0x1513930 VA: 0x181515330
	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1511D10 Offset: 0x1510310 VA: 0x181511D10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511CB0 Offset: 0x15102B0 VA: 0x181511CB0
	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xEDA490 Offset: 0xED8A90 VA: 0x180EDA490 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150F1B0 Offset: 0x150D7B0 VA: 0x18150F1B0
	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x49DC50 Offset: 0x49C250 VA: 0x18049DC50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511D20 Offset: 0x1510320 VA: 0x181511D20
	internal void .ctor() { }

}

internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 2207
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1511080 Offset: 0x150F680 VA: 0x181511080 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1511140 Offset: 0x150F740 VA: 0x181511140 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511150 Offset: 0x150F750 VA: 0x181511150 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15110E0 Offset: 0x150F6E0 VA: 0x1815110E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510CA0 Offset: 0x150F2A0 VA: 0x181510CA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1510DD0 Offset: 0x150F3D0 VA: 0x181510DD0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510FF0 Offset: 0x150F5F0 VA: 0x181510FF0
	public void .ctor() { }

	// RVA: 0x1510F50 Offset: 0x150F550 VA: 0x181510F50
	private static void .cctor() { }

}

internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 2208
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150D890 Offset: 0x150BE90 VA: 0x18150D890 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150D950 Offset: 0x150BF50 VA: 0x18150D950 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150D960 Offset: 0x150BF60 VA: 0x18150D960 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D8F0 Offset: 0x150BEF0 VA: 0x18150D8F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150D4B0 Offset: 0x150BAB0 VA: 0x18150D4B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150D5E0 Offset: 0x150BBE0 VA: 0x18150D5E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150D800 Offset: 0x150BE00 VA: 0x18150D800
	public void .ctor() { }

	// RVA: 0x150D760 Offset: 0x150BD60 VA: 0x18150D760
	private static void .cctor() { }

}

internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 2209
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150D390 Offset: 0x150B990 VA: 0x18150D390 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xEDA470 Offset: 0xED8A70 VA: 0x180EDA470 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150D450 Offset: 0x150BA50 VA: 0x18150D450 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150D3F0 Offset: 0x150B9F0 VA: 0x18150D3F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150CF20 Offset: 0x150B520 VA: 0x18150CF20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150D050 Offset: 0x150B650 VA: 0x18150D050 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150D300 Offset: 0x150B900 VA: 0x18150D300
	public void .ctor() { }

	// RVA: 0x150D260 Offset: 0x150B860 VA: 0x18150D260
	private static void .cctor() { }

}

internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 2210
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150C9E0 Offset: 0x150AFE0 VA: 0x18150C9E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150CAA0 Offset: 0x150B0A0 VA: 0x18150CAA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150CAB0 Offset: 0x150B0B0 VA: 0x18150CAB0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150CA40 Offset: 0x150B040 VA: 0x18150CA40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150C6C0 Offset: 0x150ACC0 VA: 0x18150C6C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150C950 Offset: 0x150AF50 VA: 0x18150C950
	public void .ctor() { }

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0
	private static void .cctor() { }

}

internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 2211
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512230 Offset: 0x1510830 VA: 0x181512230 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512230 Offset: 0x1510830 VA: 0x181512230 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xEDA480 Offset: 0xED8A80 VA: 0x180EDA480 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xEDA480 Offset: 0xED8A80 VA: 0x180EDA480 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1511840 Offset: 0x150FE40 VA: 0x181511840 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xBA4AD0 Offset: 0xBA30D0 VA: 0x180BA4AD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x920210 Offset: 0x91E810 VA: 0x180920210 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150C300 Offset: 0x150A900 VA: 0x18150C300 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xEDA510 Offset: 0xED8B10 VA: 0x180EDA510 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150BAF0 Offset: 0x150A0F0 VA: 0x18150BAF0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150A890 Offset: 0x1508E90 VA: 0x18150A890 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150A880 Offset: 0x1508E80 VA: 0x18150A880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150A870 Offset: 0x1508E70 VA: 0x18150A870 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 2222
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x150BC40 Offset: 0x150A240 VA: 0x18150BC40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150C1D0 Offset: 0x150A7D0 VA: 0x18150C1D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150C290 Offset: 0x150A890 VA: 0x18150C290 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150C2A0 Offset: 0x150A8A0 VA: 0x18150C2A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150C230 Offset: 0x150A830 VA: 0x18150C230 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150BC50 Offset: 0x150A250 VA: 0x18150BC50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150BE40 Offset: 0x150A440 VA: 0x18150BE40 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x150C140 Offset: 0x150A740 VA: 0x18150C140
	public void .ctor() { }

	// RVA: 0x150C0A0 Offset: 0x150A6A0 VA: 0x18150C0A0
	private static void .cctor() { }

}

internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 2223
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xEDA4D0 Offset: 0xED8AD0 VA: 0x180EDA4D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511690 Offset: 0x150FC90 VA: 0x181511690 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15117E0 Offset: 0x150FDE0 VA: 0x1815117E0
	public void .ctor() { }

}

internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 2224
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B104D4

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x15121C0 Offset: 0x15107C0 VA: 0x1815121C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512220 Offset: 0x1510820 VA: 0x181512220 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x15117E0 Offset: 0x150FDE0 VA: 0x1815117E0
	public void .ctor() { }

	// RVA: 0x15120D0 Offset: 0x15106D0 VA: 0x1815120D0
	private static void .cctor() { }

}

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 2225
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x14010

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1511F00 Offset: 0x1510500 VA: 0x181511F00 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1511F60 Offset: 0x1510560 VA: 0x181511F60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511E70 Offset: 0x1510470 VA: 0x181511E70
	public void .ctor() { }

	// RVA: 0x1511D80 Offset: 0x1510380 VA: 0x181511D80
	private static void .cctor() { }

}

internal class Datatype_long : Datatype_integer // TypeDefIndex: 2226
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1511B80 Offset: 0x1510180 VA: 0x181511B80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1511C40 Offset: 0x1510240 VA: 0x181511C40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511850 Offset: 0x150FE50 VA: 0x181511850 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1511C50 Offset: 0x1510250 VA: 0x181511C50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1511BE0 Offset: 0x15101E0 VA: 0x181511BE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15118D0 Offset: 0x150FED0 VA: 0x1815118D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15117E0 Offset: 0x150FDE0 VA: 0x1815117E0
	public void .ctor() { }

	// RVA: 0x1511A50 Offset: 0x1510050 VA: 0x181511A50
	private static void .cctor() { }

}

internal class Datatype_int : Datatype_long // TypeDefIndex: 2227
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1511570 Offset: 0x150FB70 VA: 0x181511570 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xEDA460 Offset: 0xED8A60 VA: 0x180EDA460 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15111B0 Offset: 0x150F7B0 VA: 0x1815111B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1511630 Offset: 0x150FC30 VA: 0x181511630 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15115D0 Offset: 0x150FBD0 VA: 0x1815115D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1511230 Offset: 0x150F830 VA: 0x181511230 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15114E0 Offset: 0x150FAE0 VA: 0x1815114E0
	public void .ctor() { }

	// RVA: 0x15113B0 Offset: 0x150F9B0 VA: 0x1815113B0
	private static void .cctor() { }

}

internal class Datatype_short : Datatype_int // TypeDefIndex: 2228
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x15127C0 Offset: 0x1510DC0 VA: 0x1815127C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512880 Offset: 0x1510E80 VA: 0x181512880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512430 Offset: 0x1510A30 VA: 0x181512430 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1512890 Offset: 0x1510E90 VA: 0x181512890 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512820 Offset: 0x1510E20 VA: 0x181512820 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15124B0 Offset: 0x1510AB0 VA: 0x1815124B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512760 Offset: 0x1510D60 VA: 0x181512760
	public void .ctor() { }

	// RVA: 0x1512630 Offset: 0x1510C30 VA: 0x181512630
	private static void .cctor() { }

}

internal class Datatype_byte : Datatype_short // TypeDefIndex: 2229
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x150E180 Offset: 0x150C780 VA: 0x18150E180 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150E240 Offset: 0x150C840 VA: 0x18150E240 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150DDC0 Offset: 0x150C3C0 VA: 0x18150DDC0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E250 Offset: 0x150C850 VA: 0x18150E250 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150E1E0 Offset: 0x150C7E0 VA: 0x18150E1E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150DE40 Offset: 0x150C440 VA: 0x18150DE40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E0F0 Offset: 0x150C6F0 VA: 0x18150E0F0
	public void .ctor() { }

	// RVA: 0x150DFC0 Offset: 0x150C5C0 VA: 0x18150DFC0
	private static void .cctor() { }

}

internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 2230
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x1406F

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512060 Offset: 0x1510660 VA: 0x181512060 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15120C0 Offset: 0x15106C0 VA: 0x1815120C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x15117E0 Offset: 0x150FDE0 VA: 0x1815117E0
	public void .ctor() { }

	// RVA: 0x1511F70 Offset: 0x1510570 VA: 0x181511F70
	private static void .cctor() { }

}

internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 2231
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1514570 Offset: 0x1512B70 VA: 0x181514570 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x7A5910 Offset: 0x7A3F10 VA: 0x1807A5910 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514140 Offset: 0x1512740 VA: 0x181514140 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514630 Offset: 0x1512C30 VA: 0x181514630 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15145D0 Offset: 0x1512BD0 VA: 0x1815145D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15141C0 Offset: 0x15127C0 VA: 0x1815141C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15144E0 Offset: 0x1512AE0 VA: 0x1815144E0
	public void .ctor() { }

	// RVA: 0x1514390 Offset: 0x1512990 VA: 0x181514390
	private static void .cctor() { }

}

internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 2232
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1514010 Offset: 0x1512610 VA: 0x181514010 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15140D0 Offset: 0x15126D0 VA: 0x1815140D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513C60 Offset: 0x1512260 VA: 0x181513C60 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15140E0 Offset: 0x15126E0 VA: 0x1815140E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514070 Offset: 0x1512670 VA: 0x181514070 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1513CE0 Offset: 0x15122E0 VA: 0x181513CE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513FB0 Offset: 0x15125B0 VA: 0x181513FB0
	public void .ctor() { }

	// RVA: 0x1513E60 Offset: 0x1512460 VA: 0x181513E60
	private static void .cctor() { }

}

internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 2233
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1514A70 Offset: 0x1513070 VA: 0x181514A70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1514B30 Offset: 0x1513130 VA: 0x181514B30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514690 Offset: 0x1512C90 VA: 0x181514690 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514B40 Offset: 0x1513140 VA: 0x181514B40 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514AD0 Offset: 0x15130D0 VA: 0x181514AD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514710 Offset: 0x1512D10 VA: 0x181514710 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15149E0 Offset: 0x1512FE0 VA: 0x1815149E0
	public void .ctor() { }

	// RVA: 0x1514890 Offset: 0x1512E90 VA: 0x181514890
	private static void .cctor() { }

}

internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 2234
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1513B40 Offset: 0x1512140 VA: 0x181513B40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x50E140 Offset: 0x50C740 VA: 0x18050E140 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513790 Offset: 0x1511D90 VA: 0x181513790 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1513C00 Offset: 0x1512200 VA: 0x181513C00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1513BA0 Offset: 0x15121A0 VA: 0x181513BA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1513810 Offset: 0x1511E10 VA: 0x181513810 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513AE0 Offset: 0x15120E0 VA: 0x181513AE0
	public void .ctor() { }

	// RVA: 0x1513990 Offset: 0x1511F90 VA: 0x181513990
	private static void .cctor() { }

}

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 2235
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B104D4

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15123C0 Offset: 0x15109C0 VA: 0x1815123C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512420 Offset: 0x1510A20 VA: 0x181512420 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512330 Offset: 0x1510930 VA: 0x181512330
	public void .ctor() { }

	// RVA: 0x1512240 Offset: 0x1510840 VA: 0x181512240
	private static void .cctor() { }

}

internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 2236
{	// Methods

	// RVA: 0x150F740 Offset: 0x150DD40 VA: 0x18150F740 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150F8F0 Offset: 0x150DEF0 VA: 0x18150F8F0
	public void .ctor() { }

}

internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 2237
{	// Methods

	// RVA: 0x1510670 Offset: 0x150EC70 VA: 0x181510670 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15107E0 Offset: 0x150EDE0 VA: 0x1815107E0
	public void .ctor() { }

}

internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 2238
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C310 Offset: 0x150A910 VA: 0x18150C310 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150C660 Offset: 0x150AC60 VA: 0x18150C660 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150C600 Offset: 0x150AC00 VA: 0x18150C600 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150C570 Offset: 0x150AB70 VA: 0x18150C570
	public void .ctor() { }

	// RVA: 0x150C4D0 Offset: 0x150AAD0 VA: 0x18150C4D0
	private static void .cctor() { }

}

internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 2239
{	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xE67360 Offset: 0xE65960 VA: 0x180E67360 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150A860 Offset: 0x1508E60 VA: 0x18150A860
	public void .ctor() { }

}

internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 2240
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x150E690 Offset: 0x150CC90 VA: 0x18150E690 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150E630 Offset: 0x150CC30 VA: 0x18150E630 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E2B0 Offset: 0x150C8B0 VA: 0x18150E2B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E330 Offset: 0x150C930 VA: 0x18150E330 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150E450 Offset: 0x150CA50 VA: 0x18150E450 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E5A0 Offset: 0x150CBA0 VA: 0x18150E5A0
	public void .ctor() { }

	// RVA: 0x150E500 Offset: 0x150CB00 VA: 0x18150E500
	private static void .cctor() { }

}

internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 2241
{	// Methods

	// RVA: 0x1510280 Offset: 0x150E880 VA: 0x181510280 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1510480 Offset: 0x150EA80 VA: 0x181510480 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510610 Offset: 0x150EC10 VA: 0x181510610
	public void .ctor() { }

}

internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 2242
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1515000 Offset: 0x1513600 VA: 0x181515000 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514FA0 Offset: 0x15135A0 VA: 0x181514FA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1514C10 Offset: 0x1513210 VA: 0x181514C10 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514CA0 Offset: 0x15132A0 VA: 0x181514CA0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1514DC0 Offset: 0x15133C0 VA: 0x181514DC0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514F10 Offset: 0x1513510 VA: 0x181514F10
	public void .ctor() { }

	// RVA: 0x1514E70 Offset: 0x1513470 VA: 0x181514E70
	private static void .cctor() { }

}

public sealed class DataUtility // TypeDefIndex: 3576
{	// Methods

	// RVA: 0x1997400 Offset: 0x1995A00 VA: 0x181997400
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x1997580 Offset: 0x1995B80 VA: 0x181997580
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x19975F0 Offset: 0x1995BF0 VA: 0x1819975F0
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x1997470 Offset: 0x1995A70 VA: 0x181997470
	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4171
{	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[EventAttribute] // RVA: 0x9ACD0 Offset: 0x9A0D0 VA: 0x18009ACD0
	// RVA: 0x1234920 Offset: 0x1232F20 VA: 0x181234920
	internal void Trace(string message) { }

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02C80 Offset: 0xE01280 VA: 0x180E02C80
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0xE021A0 Offset: 0xE007A0 VA: 0x180E021A0
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00780 Offset: 0xDFED80 VA: 0x180E00780
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0xE008B0 Offset: 0xDFEEB0 VA: 0x180E008B0
	|-DataCommonEventSource.Trace<int, ListChangedType>
	|-DataCommonEventSource.Trace<int, MappingType>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0xE015F0 Offset: 0xDFFBF0 VA: 0x180E015F0
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0xE01720 Offset: 0xDFFD20 VA: 0x180E01720
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0xE020B0 Offset: 0xE006B0 VA: 0x180E020B0
	|-DataCommonEventSource.Trace<int, object>
	|-DataCommonEventSource.Trace<int, string>
	|
	|-RVA: 0xE02BC0 Offset: 0xE011C0 VA: 0x180E02BC0
	|-DataCommonEventSource.Trace<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE009E0 Offset: 0xDFEFE0 VA: 0x180E009E0
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0xE01310 Offset: 0xDFF910 VA: 0x180E01310
	|-DataCommonEventSource.Trace<int, int, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0xE01480 Offset: 0xDFFA80 VA: 0x180E01480
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0xE01850 Offset: 0xDFFE50 VA: 0x180E01850
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, DataViewRowState>
	|
	|-RVA: 0xE01FB0 Offset: 0xE005B0 VA: 0x180E01FB0
	|-DataCommonEventSource.Trace<int, object, object>
	|-DataCommonEventSource.Trace<int, string, string>
	|
	|-RVA: 0xE02AF0 Offset: 0xE010F0 VA: 0x180E02AF0
	|-DataCommonEventSource.Trace<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE01000 Offset: 0xDFF600 VA: 0x180E01000
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE01D00 Offset: 0xE00300 VA: 0x180E01D00
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, string, DataViewRowState>
	|-DataCommonEventSource.Trace<int, string, string, MappingType>
	|
	|-RVA: 0xE028A0 Offset: 0xE00EA0 VA: 0x180E028A0
	|-DataCommonEventSource.Trace<object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE01990 Offset: 0xDFFF90 VA: 0x180E01990
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-RVA: 0xE025F0 Offset: 0xE00BF0 VA: 0x180E025F0
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00B50 Offset: 0xDFF150 VA: 0x180E00B50
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE02290 Offset: 0xE00890 VA: 0x180E02290
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	// RVA: 0x1234830 Offset: 0x1232E30 VA: 0x181234830
	internal long EnterScope(string message) { }

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED30D0 Offset: 0xED16D0 VA: 0x180ED30D0
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0xED35A0 Offset: 0xED1BA0 VA: 0x180ED35A0
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2360 Offset: 0xED0960 VA: 0x180ED2360
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0xED2620 Offset: 0xED0C20 VA: 0x180ED2620
	|-DataCommonEventSource.EnterScope<int, SchemaFormat>
	|-DataCommonEventSource.EnterScope<int, XmlReadMode>
	|-DataCommonEventSource.EnterScope<int, XmlWriteMode>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0xED2D50 Offset: 0xED1350 VA: 0x180ED2D50
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0xED2FE0 Offset: 0xED15E0 VA: 0x180ED2FE0
	|-DataCommonEventSource.EnterScope<int, object>
	|-DataCommonEventSource.EnterScope<int, string>
	|
	|-RVA: 0xED34E0 Offset: 0xED1AE0 VA: 0x180ED34E0
	|-DataCommonEventSource.EnterScope<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED24A0 Offset: 0xED0AA0 VA: 0x180ED24A0
	|-DataCommonEventSource.EnterScope<int, XmlReadMode, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0xED2A80 Offset: 0xED1080 VA: 0x180ED2A80
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0xED2C00 Offset: 0xED1200 VA: 0x180ED2C00
	|-DataCommonEventSource.EnterScope<int, int, object>
	|-DataCommonEventSource.EnterScope<int, int, string>
	|
	|-RVA: 0xED2E90 Offset: 0xED1490 VA: 0x180ED2E90
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|-DataCommonEventSource.EnterScope<int, string, bool>
	|
	|-RVA: 0xED3410 Offset: 0xED1A10 VA: 0x180ED3410
	|-DataCommonEventSource.EnterScope<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2760 Offset: 0xED0D60 VA: 0x180ED2760
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0xED31C0 Offset: 0xED17C0 VA: 0x180ED31C0
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B580 Offset: 0x9A980 VA: 0x18009B580
	// RVA: 0x1234910 Offset: 0x1232F10 VA: 0x181234910
	internal void ExitScope(long scopeId) { }

	// RVA: 0x12349E0 Offset: 0x1232FE0 VA: 0x1812349E0
	public void .ctor() { }

	// RVA: 0x1234930 Offset: 0x1232F30 VA: 0x181234930
	private static void .cctor() { }

}

public class DataColumn : MarshalByValueComponent // TypeDefIndex: 4181
{	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValueAttribute] // RVA: 0x9D670 Offset: 0x9CA70 VA: 0x18009D670
	public bool AllowDBNull { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D970 Offset: 0x9CD70 VA: 0x18009D970
	[RefreshPropertiesAttribute] // RVA: 0x9D970 Offset: 0x9CD70 VA: 0x18009D970
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValueAttribute] // RVA: 0x9DBC0 Offset: 0x9CFC0 VA: 0x18009DBC0
	public long AutoIncrementSeed { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DC10 Offset: 0x9D010 VA: 0x18009DC10
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DCA0 Offset: 0x9D0A0 VA: 0x18009DCA0
	[RefreshPropertiesAttribute] // RVA: 0x9DCA0 Offset: 0x9D0A0 VA: 0x18009DCA0
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[RefreshPropertiesAttribute] // RVA: 0x9DDD0 Offset: 0x9D1D0 VA: 0x18009DDD0
	[DefaultValueAttribute] // RVA: 0x9DDD0 Offset: 0x9D1D0 VA: 0x18009DDD0
	[TypeConverterAttribute] // RVA: 0x9DDD0 Offset: 0x9D1D0 VA: 0x18009DDD0
	public Type DataType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9E010 Offset: 0x9D410 VA: 0x18009E010
	[RefreshPropertiesAttribute] // RVA: 0x9E010 Offset: 0x9D410 VA: 0x18009E010
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverterAttribute] // RVA: 0x9E1F0 Offset: 0x9D5F0 VA: 0x18009E1F0
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValueAttribute] // RVA: 0x9DCA0 Offset: 0x9D0A0 VA: 0x18009DCA0
	[RefreshPropertiesAttribute] // RVA: 0x9DCA0 Offset: 0x9D0A0 VA: 0x18009DCA0
	public string Expression { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValueAttribute] // RVA: 0x9E830 Offset: 0x9DC30 VA: 0x18009E830
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public int Ordinal { get; }
	[DefaultValueAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public bool ReadOnly { get; set; }
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private Index SortIndex { get; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9EAF0 Offset: 0x9DEF0 VA: 0x18009EAF0
	[DefaultValueAttribute] // RVA: 0x9EAF0 Offset: 0x9DEF0 VA: 0x18009EAF0
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9EBB0 Offset: 0x9DFB0 VA: 0x18009EBB0
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x1230790 Offset: 0x122ED90 VA: 0x181230790
	public void .ctor() { }

	// RVA: 0x1230B50 Offset: 0x122F150 VA: 0x181230B50
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x1230820 Offset: 0x122EE20 VA: 0x181230820
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x1230670 Offset: 0x122EC70 VA: 0x181230670
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_AllowDBNull() { }

	// RVA: 0x1231380 Offset: 0x122F980 VA: 0x181231380
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x1230D20 Offset: 0x122F320 VA: 0x181230D20
	public bool get_AutoIncrement() { }

	// RVA: 0x1231880 Offset: 0x122FE80 VA: 0x181231880
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x1230C60 Offset: 0x122F260 VA: 0x181230C60
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1231500 Offset: 0x122FB00 VA: 0x181231500
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x1230B80 Offset: 0x122F180 VA: 0x181230B80
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1230CD0 Offset: 0x122F2D0 VA: 0x181230CD0
	public long get_AutoIncrementSeed() { }

	// RVA: 0x12316B0 Offset: 0x122FCB0 VA: 0x1812316B0
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1230CF0 Offset: 0x122F2F0 VA: 0x181230CF0
	public long get_AutoIncrementStep() { }

	// RVA: 0x1231790 Offset: 0x122FD90 VA: 0x181231790
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x1230D40 Offset: 0x122F340 VA: 0x181230D40
	public string get_Caption() { }

	// RVA: 0x1231A30 Offset: 0x1230030 VA: 0x181231A30
	public void set_Caption(string value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_ColumnName() { }

	// RVA: 0x1231DA0 Offset: 0x12303A0 VA: 0x181231DA0
	public void set_ColumnName(string value) { }

	// RVA: 0x1230ED0 Offset: 0x122F4D0 VA: 0x181230ED0
	internal string get_EncodedColumnName() { }

	// RVA: 0x1231040 Offset: 0x122F640 VA: 0x181231040
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x12311A0 Offset: 0x122F7A0 VA: 0x1812311A0
	internal CultureInfo get_Locale() { }

	// RVA: 0x10511C0 Offset: 0x104F7C0 VA: 0x1810511C0
	internal int get_ObjectID() { }

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public string get_Prefix() { }

	// RVA: 0x1233CE0 Offset: 0x12322E0 VA: 0x181233CE0
	public void set_Prefix(string value) { }

	// RVA: 0x122F040 Offset: 0x122D640 VA: 0x18122F040
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x1230D50 Offset: 0x122F350 VA: 0x181230D50
	internal bool get_Computed() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal DataExpression get_DataExpression() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Type get_DataType() { }

	// RVA: 0x12321A0 Offset: 0x12307A0 VA: 0x1812321A0
	public void set_DataType(Type value) { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1232B20 Offset: 0x1231120 VA: 0x181232B20
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x1230D70 Offset: 0x122F370 VA: 0x181230D70
	public object get_DefaultValue() { }

	// RVA: 0x1232C70 Offset: 0x1231270 VA: 0x181232C70
	public void set_DefaultValue(object value) { }

	// RVA: 0x1230D60 Offset: 0x122F360 VA: 0x181230D60
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x1230F50 Offset: 0x122F550 VA: 0x181230F50
	public string get_Expression() { }

	// RVA: 0x1232F40 Offset: 0x1231540 VA: 0x181232F40
	public void set_Expression(string value) { }

	// RVA: 0x1230FC0 Offset: 0x122F5C0 VA: 0x181230FC0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x12310B0 Offset: 0x122F6B0 VA: 0x1812310B0
	internal bool get_HasData() { }

	// RVA: 0x118D210 Offset: 0x118B810 VA: 0x18118D210
	internal bool get_ImplementsINullable() { }

	// RVA: 0x12310C0 Offset: 0x122F6C0 VA: 0x1812310C0
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xE67350 Offset: 0xE65950 VA: 0x180E67350
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x1231150 Offset: 0x122F750 VA: 0x181231150
	internal bool get_IsValueType() { }

	// RVA: 0x118D200 Offset: 0x118B800 VA: 0x18118D200
	internal bool get_IsSqlType() { }

	// RVA: 0x1230120 Offset: 0x122E720 VA: 0x181230120
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_MaxLength() { }

	// RVA: 0x1233800 Offset: 0x1231E00 VA: 0x181233800
	public void set_MaxLength(int value) { }

	// RVA: 0x1231210 Offset: 0x122F810 VA: 0x181231210
	public string get_Namespace() { }

	// RVA: 0x1233BB0 Offset: 0x12321B0 VA: 0x181233BB0
	public void set_Namespace(string value) { }

	// RVA: 0x574320 Offset: 0x572920 VA: 0x180574320
	public int get_Ordinal() { }

	// RVA: 0x1230220 Offset: 0x122E820 VA: 0x181230220
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool get_ReadOnly() { }

	// RVA: 0x1233E30 Offset: 0x1232430 VA: 0x181233E30
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1231280 Offset: 0x122F880 VA: 0x181231280
	private Index get_SortIndex() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public DataTable get_Table() { }

	// RVA: 0x12303C0 Offset: 0x122E9C0 VA: 0x1812303C0
	internal void SetTable(DataTable table) { }

	// RVA: 0x122F130 Offset: 0x122D730 VA: 0x18122F130
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1231170 Offset: 0x122F770 VA: 0x181231170
	internal object get_Item(int record) { }

	// RVA: 0x1233670 Offset: 0x1231C70 VA: 0x181233670
	internal void set_Item(int record, object value) { }

	// RVA: 0x122F4E0 Offset: 0x122DAE0 VA: 0x18122F4E0
	internal void InitializeRecord(int record) { }

	// RVA: 0x12304A0 Offset: 0x122EAA0 VA: 0x1812304A0
	internal void SetValue(int record, object value) { }

	// RVA: 0x122EF30 Offset: 0x122D530 VA: 0x18122EF30
	internal void FreeRecord(int record) { }

	// RVA: 0x1231370 Offset: 0x122F970 VA: 0x181231370
	public bool get_Unique() { }

	// RVA: 0x1233F60 Offset: 0x1232560 VA: 0x181233F60
	public void set_Unique(bool value) { }

	// RVA: 0x7CD3F0 Offset: 0x7CB9F0 VA: 0x1807CD3F0
	internal void InternalUnique(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	internal void set_XmlDataType(string value) { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1233EF0 Offset: 0x12324F0 VA: 0x181233EF0
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x79BE30 Offset: 0x79A430 VA: 0x18079BE30 Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x1231B20 Offset: 0x1230120 VA: 0x181231B20 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x122DDE0 Offset: 0x122C3E0 VA: 0x18122DDE0
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x122DFC0 Offset: 0x122C5C0 VA: 0x18122DFC0
	internal bool CheckMaxLength() { }

	// RVA: 0x122DF20 Offset: 0x122C520 VA: 0x18122DF20
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x122E230 Offset: 0x122C830 VA: 0x18122E230
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x122E510 Offset: 0x122CB10 VA: 0x18122E510
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x122E5C0 Offset: 0x122CBC0 VA: 0x18122E5C0
	protected void CheckUnique() { }

	// RVA: 0x122ED00 Offset: 0x122D300 VA: 0x18122ED00
	internal int Compare(int record1, int record2) { }

	// RVA: 0x122EB00 Offset: 0x122D100 VA: 0x18122EB00
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x122EAD0 Offset: 0x122D0D0 VA: 0x18122EAD0
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x122EDF0 Offset: 0x122D3F0 VA: 0x18122EDF0
	internal object ConvertValue(object value) { }

	// RVA: 0x122EF00 Offset: 0x122D500 VA: 0x18122EF00
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x122E640 Offset: 0x122CC40 VA: 0x18122E640
	internal DataColumn Clone() { }

	// RVA: 0x122EF60 Offset: 0x122D560 VA: 0x18122EF60
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x122F1A0 Offset: 0x122D7A0 VA: 0x18122F1A0
	private int GetStringLength(int record) { }

	// RVA: 0x122F430 Offset: 0x122DA30 VA: 0x18122F430
	internal void Init(int record) { }

	// RVA: 0x122F5D0 Offset: 0x122DBD0 VA: 0x18122F5D0
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x12310E0 Offset: 0x122F6E0 VA: 0x1812310E0
	internal bool get_IsCustomType() { }

	// RVA: 0x122FEF0 Offset: 0x122E4F0 VA: 0x18122FEF0
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x12310D0 Offset: 0x122F6D0 VA: 0x1812310D0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x122FEC0 Offset: 0x122E4C0 VA: 0x18122FEC0
	internal bool IsNull(int record) { }

	// RVA: 0x122F870 Offset: 0x122DE70 VA: 0x18122F870
	internal bool IsInRelation() { }

	// RVA: 0x122FA00 Offset: 0x122E000 VA: 0x18122FA00
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x122FD60 Offset: 0x122E360 VA: 0x18122FD60
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x1013C70 Offset: 0x1012270 VA: 0x181013C70 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x122FFC0 Offset: 0x122E5C0 VA: 0x18122FFC0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x122F530 Offset: 0x122DB30 VA: 0x18122F530
	private void InsureStorage() { }

	// RVA: 0x12300D0 Offset: 0x122E6D0 VA: 0x1812300D0
	internal void SetCapacity(int capacity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void OnSetDataSet() { }

	// RVA: 0x12305A0 Offset: 0x122EBA0 VA: 0x1812305A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x122EE20 Offset: 0x122D420 VA: 0x18122EE20
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x122EE70 Offset: 0x122D470 VA: 0x18122EE70
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122ED30 Offset: 0x122D330 VA: 0x18122ED30
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x122ED80 Offset: 0x122D380 VA: 0x18122ED80
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122F160 Offset: 0x122D760 VA: 0x18122F160
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x122EED0 Offset: 0x122D4D0 VA: 0x18122EED0
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1230370 Offset: 0x122E970 VA: 0x181230370
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x122DD20 Offset: 0x122C320 VA: 0x18122DD20
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1230040 Offset: 0x122E640 VA: 0x181230040
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122F1D0 Offset: 0x122D7D0 VA: 0x18122F1D0
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4185
{	// Fields
	private DataColumn _column; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x122A2E0 Offset: 0x12288E0 VA: 0x18122A2E0
	internal void .ctor(DataRow row) { }

	// RVA: 0x122A230 Offset: 0x1228830 VA: 0x18122A230
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ProposedValue(object value) { }

	// RVA: 0x122A1F0 Offset: 0x12287F0 VA: 0x18122A1F0
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataColumnChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 4187
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x122D180 Offset: 0x122B780 VA: 0x18122D180
	internal void .ctor(DataTable table) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x122D5B0 Offset: 0x122BBB0 VA: 0x18122D5B0
	public DataColumn get_Item(int index) { }

	// RVA: 0x122D460 Offset: 0x122BA60 VA: 0x18122D460
	public DataColumn get_Item(string name) { }

	// RVA: 0x122D3B0 Offset: 0x122B9B0 VA: 0x18122D3B0
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x122A7F0 Offset: 0x1228DF0 VA: 0x18122A7F0
	public void Add(DataColumn column) { }

	// RVA: 0x122A350 Offset: 0x1228950 VA: 0x18122A350
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0x122A800 Offset: 0x1228E00 VA: 0x18122A800
	public DataColumn Add(string columnName, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122D270 Offset: 0x122B870 VA: 0x18122D270
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122D690 Offset: 0x122BC90 VA: 0x18122D690
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122D310 Offset: 0x122B910 VA: 0x18122D310
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122D730 Offset: 0x122BD30 VA: 0x18122D730
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x122A910 Offset: 0x1228F10 VA: 0x18122A910
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x122A8A0 Offset: 0x1228EA0 VA: 0x18122A8A0
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x122A9A0 Offset: 0x1228FA0 VA: 0x18122A9A0
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x122ACD0 Offset: 0x12292D0 VA: 0x18122ACD0
	internal string AssignName() { }

	// RVA: 0x122ADE0 Offset: 0x12293E0 VA: 0x18122ADE0
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x122B210 Offset: 0x1229810 VA: 0x18122B210
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x122B560 Offset: 0x1229B60 VA: 0x18122B560
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x122B730 Offset: 0x1229D30 VA: 0x18122B730
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x122C020 Offset: 0x122A620 VA: 0x18122C020
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x122C070 Offset: 0x122A670 VA: 0x18122C070
	public void Clear() { }

	// RVA: 0x122C5B0 Offset: 0x122ABB0 VA: 0x18122C5B0
	public bool Contains(string name) { }

	// RVA: 0x122C640 Offset: 0x122AC40 VA: 0x18122C640
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x122C8A0 Offset: 0x122AEA0 VA: 0x18122C8A0
	public int IndexOf(string columnName) { }

	// RVA: 0x122C700 Offset: 0x122AD00 VA: 0x18122C700
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x122C9A0 Offset: 0x122AFA0 VA: 0x18122C9A0
	private string MakeName(int index) { }

	// RVA: 0x122CA30 Offset: 0x122B030 VA: 0x18122CA30
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122CAD0 Offset: 0x122B0D0 VA: 0x18122CAD0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122CAF0 Offset: 0x122B0F0 VA: 0x18122CAF0
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122CB40 Offset: 0x122B140 VA: 0x18122CB40
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x122B6D0 Offset: 0x1229CD0 VA: 0x18122B6D0
	internal bool CanRegisterName(string name) { }

	// RVA: 0x122CE60 Offset: 0x122B460 VA: 0x18122CE60
	public void Remove(DataColumn column) { }

	// RVA: 0x122CFD0 Offset: 0x122B5D0 VA: 0x18122CFD0
	internal void UnregisterName(string name) { }

	// RVA: 0x122A700 Offset: 0x1228D00 VA: 0x18122A700
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x122CD40 Offset: 0x122B340 VA: 0x18122CD40
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4188
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x122DA70 Offset: 0x122C070 VA: 0x18122DA70
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x122DAC0 Offset: 0x122C0C0 VA: 0x18122DAC0 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal DataColumn get_Column() { }

	// RVA: 0x122DC80 Offset: 0x122C280 VA: 0x18122DC80 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x122DCE0 Offset: 0x122C2E0 VA: 0x18122DCE0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x122DD00 Offset: 0x122C300 VA: 0x18122DD00 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x122D7D0 Offset: 0x122BDD0 VA: 0x18122D7D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4A00 Offset: 0xAE3000 VA: 0x180AE4A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122D860 Offset: 0x122BE60 VA: 0x18122D860 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x122D940 Offset: 0x122BF40 VA: 0x18122D940 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

internal sealed class DataError // TypeDefIndex: 4189
{	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x12352C0 Offset: 0x12338C0 VA: 0x1812352C0
	internal void .ctor() { }

	// RVA: 0x1235210 Offset: 0x1233810 VA: 0x181235210
	internal void .ctor(string rowError) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string get_Text() { }

	// RVA: 0x1235340 Offset: 0x1233940 VA: 0x181235340
	internal void set_Text(string value) { }

	// RVA: 0x1235310 Offset: 0x1233910 VA: 0x181235310
	internal bool get_HasErrors() { }

	// RVA: 0x1234EC0 Offset: 0x12334C0 VA: 0x181234EC0
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1234BA0 Offset: 0x12331A0 VA: 0x181234BA0
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1234AE0 Offset: 0x12330E0 VA: 0x181234AE0
	internal void Clear(DataColumn column) { }

	// RVA: 0x1234A40 Offset: 0x1233040 VA: 0x181234A40
	internal void Clear() { }

	// RVA: 0x1234C50 Offset: 0x1233250 VA: 0x181234C50
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x12351B0 Offset: 0x12337B0 VA: 0x1812351B0
	private void SetText(string errorText) { }

	// RVA: 0x1234D60 Offset: 0x1233360 VA: 0x181234D60
	internal int IndexOf(DataColumn column) { }

}

internal struct DataError.ColumnError // TypeDefIndex: 4190
{	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8

}

public class DataException : SystemException // TypeDefIndex: 4191
{	// Methods

	// RVA: 0x12353A0 Offset: 0x12339A0 VA: 0x1812353A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1235420 Offset: 0x1233A20 VA: 0x181235420
	public void .ctor() { }

	// RVA: 0x1235470 Offset: 0x1233A70 VA: 0x181235470
	public void .ctor(string s) { }

	// RVA: 0x117F2D0 Offset: 0x117D8D0 VA: 0x18117F2D0
	public void .ctor(string s, Exception innerException) { }

}

internal struct DataKey // TypeDefIndex: 4202
{	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1D3290 Offset: 0x1D2690 VA: 0x1801D3290
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50
	internal bool get_HasValue() { }

	// RVA: 0x1D32A0 Offset: 0x1D26A0 VA: 0x1801D32A0
	internal DataTable get_Table() { }

	// RVA: 0x1D2E50 Offset: 0x1D2250 VA: 0x1801D2E50
	internal void CheckState() { }

	// RVA: 0x1D2E60 Offset: 0x1D2260 VA: 0x1801D2E60
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x1236050 Offset: 0x1234650 VA: 0x181236050
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1D2E70 Offset: 0x1D2270 VA: 0x1801D2E70
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1D2F60 Offset: 0x1D2360 VA: 0x1801D2F60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2EE0 Offset: 0x1D22E0 VA: 0x1801D2EE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D2ED0 Offset: 0x1D22D0 VA: 0x1801D2ED0
	internal bool Equals(DataKey value) { }

	// RVA: 0x1D2FC0 Offset: 0x1D23C0 VA: 0x1801D2FC0
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1D2FD0 Offset: 0x1D23D0 VA: 0x1801D2FD0
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1D3150 Offset: 0x1D2550 VA: 0x1801D3150
	internal Index GetSortIndex() { }

	// RVA: 0x1D3140 Offset: 0x1D2540 VA: 0x1801D3140
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1D31C0 Offset: 0x1D25C0 VA: 0x1801D31C0
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1D3280 Offset: 0x1D2680 VA: 0x1801D3280
	internal DataColumn[] ToArray() { }

}

public class DataRelation // TypeDefIndex: 4203
{	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal bool _nested; // 0x48
	internal bool _createConstraints; // 0x49
	private bool _checkMultipleNested; // 0x4A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanging; // 0x50

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public virtual DataSet DataSet { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public virtual string RelationName { get; }
	[DefaultValueAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1238BF0 Offset: 0x12371F0 VA: 0x181238BF0
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1238EF0 Offset: 0x12374F0 VA: 0x181238EF0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1238E30 Offset: 0x1237430 VA: 0x181238E30
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1238F30 Offset: 0x1237530 VA: 0x181238F30 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1238F10 Offset: 0x1237510 VA: 0x181238F10
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1238F10 Offset: 0x1237510 VA: 0x181238F10
	internal DataKey get_ChildKey() { }

	// RVA: 0x1238F70 Offset: 0x1237570 VA: 0x181238F70 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1238FC0 Offset: 0x12375C0 VA: 0x181238FC0 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1238550 Offset: 0x1236B50 VA: 0x181238550
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1238030 Offset: 0x1236630 VA: 0x181238030
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x12382B0 Offset: 0x12368B0 VA: 0x1812382B0
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1238110 Offset: 0x1236710 VA: 0x181238110
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x12387B0 Offset: 0x1236DB0 VA: 0x1812387B0
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1239070 Offset: 0x1237670 VA: 0x181239070 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x12390B0 Offset: 0x12376B0 VA: 0x1812390B0
	internal DataKey get_ParentKey() { }

	// RVA: 0x12390D0 Offset: 0x12376D0 VA: 0x1812390D0 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1239120 Offset: 0x1237720 VA: 0x181239120 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1236C20 Offset: 0x1235220 VA: 0x181236C20
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1236E90 Offset: 0x1235490 VA: 0x181236E90
	internal void CheckNestedRelations() { }

	// RVA: 0x1239050 Offset: 0x1237650 VA: 0x181239050 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1239150 Offset: 0x1237750 VA: 0x181239150 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1239090 Offset: 0x1237690 VA: 0x181239090 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x1238F50 Offset: 0x1237550 VA: 0x181238F50 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1238FE0 Offset: 0x12375E0 VA: 0x181238FE0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1239140 Offset: 0x1237740 VA: 0x181239140
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1237370 Offset: 0x1235970 VA: 0x181237370
	internal void CheckState() { }

	// RVA: 0x1237250 Offset: 0x1235850 VA: 0x181237250
	protected void CheckStateForProperty() { }

	// RVA: 0x1237D30 Offset: 0x1236330 VA: 0x181237D30
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x12376A0 Offset: 0x1235CA0 VA: 0x1812376A0
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1238610 Offset: 0x1236C10 VA: 0x181238610
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x12386C0 Offset: 0x1236CC0 VA: 0x1812386C0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x4C2760 Offset: 0x4C0D60 VA: 0x1804C2760 Slot: 3
	public override string ToString() { }

	// RVA: 0x12387D0 Offset: 0x1236DD0 VA: 0x1812387D0
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1238390 Offset: 0x1236990 VA: 0x181238390
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	internal int get_ObjectID() { }

}

public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 4204
{	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(string name);

	// RVA: 0xAE3760 Offset: 0xAE1D60 VA: 0x180AE3760
	public void Add(DataRelation relation) { }

	// RVA: 0xAE34B0 Offset: 0xAE1AB0 VA: 0x180AE34B0 Slot: 14
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xAE47D0 Offset: 0xAE2DD0 VA: 0x180AE47D0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE48A0 Offset: 0xAE2EA0 VA: 0x180AE48A0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE39A0 Offset: 0xAE1FA0 VA: 0x180AE39A0
	internal string AssignName() { }

	// RVA: 0xAE39C0 Offset: 0xAE1FC0 VA: 0x180AE39C0 Slot: 15
	public virtual void Clear() { }

	// RVA: 0xAE3C00 Offset: 0xAE2200 VA: 0x180AE3C00 Slot: 16
	public virtual bool Contains(string name) { }

	// RVA: 0xAE3C20 Offset: 0xAE2220 VA: 0x180AE3C20
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DataSet GetDataSet();

	// RVA: 0xAE3DE0 Offset: 0xAE23E0 VA: 0x180AE3DE0
	private string MakeName(int index) { }

	// RVA: 0xAE3E70 Offset: 0xAE2470 VA: 0x180AE3E70 Slot: 18
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3F20 Offset: 0xAE2520 VA: 0x180AE3F20 Slot: 19
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3FD0 Offset: 0xAE25D0 VA: 0x180AE3FD0
	internal void RegisterName(string name) { }

	// RVA: 0xAE43F0 Offset: 0xAE29F0 VA: 0x180AE43F0
	public void Remove(DataRelation relation) { }

	// RVA: 0xAE41A0 Offset: 0xAE27A0 VA: 0x180AE41A0
	public void RemoveAt(int index) { }

	// RVA: 0xAE4230 Offset: 0xAE2830 VA: 0x180AE4230 Slot: 20
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xAE45B0 Offset: 0xAE2BB0 VA: 0x180AE45B0
	internal void UnregisterName(string name) { }

	// RVA: 0xAE4760 Offset: 0xAE2D60 VA: 0x180AE4760
	protected void .ctor() { }

}

internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4205
{	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0xAF76B0 Offset: 0xAF5CB0 VA: 0x180AF76B0
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAF7310 Offset: 0xAF5910 VA: 0x180AF7310
	private void EnsureDataSet() { }

	// RVA: 0xAF7370 Offset: 0xAF5970 VA: 0x180AF7370 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAF7910 Offset: 0xAF5F10 VA: 0x180AF7910 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAF7800 Offset: 0xAF5E00 VA: 0x180AF7800 Slot: 13
	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF7760 Offset: 0xAF5D60 VA: 0x180AF7760
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF7A10 Offset: 0xAF6010 VA: 0x180AF7A10
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAF7190 Offset: 0xAF5790 VA: 0x180AF7190
	private void AddCache(DataRelation relation) { }

	// RVA: 0xAF71F0 Offset: 0xAF57F0 VA: 0x180AF71F0 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAF73D0 Offset: 0xAF59D0 VA: 0x180AF73D0
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xAF74E0 Offset: 0xAF5AE0 VA: 0x180AF74E0 Slot: 20
	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 4206
{	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0xAEB6F0 Offset: 0xAE9CF0 VA: 0x180AEB6F0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAEB3A0 Offset: 0xAE99A0 VA: 0x180AEB3A0 Slot: 15
	public override void Clear() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAEB790 Offset: 0xAE9D90 VA: 0x180AEB790 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAEB890 Offset: 0xAE9E90 VA: 0x180AEB890 Slot: 13
	public override DataRelation get_Item(string name) { }

	// RVA: 0xAEACC0 Offset: 0xAE92C0 VA: 0x180AEACC0 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAEB3F0 Offset: 0xAE99F0 VA: 0x180AEB3F0 Slot: 20
	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4207
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0xAE4B20 Offset: 0xAE3120 VA: 0x180AE4B20
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal DataRelation get_Relation() { }

	// RVA: 0xAE4B80 Offset: 0xAE3180 VA: 0x180AE4B80 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xAE4BE0 Offset: 0xAE31E0 VA: 0x180AE4BE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0xAE4970 Offset: 0xAE2F70 VA: 0x180AE4970 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4A00 Offset: 0xAE3000 VA: 0x180AE4A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE4A30 Offset: 0xAE3030 VA: 0x180AE4A30 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public class DataRow // TypeDefIndex: 4208
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public object Item { get; set; }
	public object Item { get; set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { get; set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0xAE99C0 Offset: 0xAE7FC0 VA: 0x180AE99C0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xAE9F60 Offset: 0xAE8560 VA: 0x180AE9F60
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xAEAA80 Offset: 0xAE9080 VA: 0x180AEAA80
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xAE9A90 Offset: 0xAE8090 VA: 0x180AE9A90
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	internal int get_RBTreeNodeId() { }

	// RVA: 0xAEAA90 Offset: 0xAE9090 VA: 0x180AEAA90
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xAE9F80 Offset: 0xAE8580 VA: 0x180AE9F80
	public string get_RowError() { }

	// RVA: 0xAEAB30 Offset: 0xAE9130 VA: 0x180AEAB30
	public void set_RowError(string value) { }

	// RVA: 0xAE8B80 Offset: 0xAE7180 VA: 0x180AE8B80
	private void RowErrorChanged() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal long get_rowID() { }

	// RVA: 0xAEAC80 Offset: 0xAE9280 VA: 0x180AEAC80
	internal void set_rowID(long value) { }

	// RVA: 0xAE9FD0 Offset: 0xAE85D0 VA: 0x180AE9FD0
	public DataRowState get_RowState() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public DataTable get_Table() { }

	// RVA: 0xAE9C30 Offset: 0xAE8230 VA: 0x180AE9C30
	public object get_Item(int columnIndex) { }

	// RVA: 0xAEAA30 Offset: 0xAE9030 VA: 0x180AEAA30
	public void set_Item(int columnIndex, object value) { }

	// RVA: 0xAE6D10 Offset: 0xAE5310 VA: 0x180AE6D10
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xAE7B20 Offset: 0xAE6120 VA: 0x180AE7B20
	internal int GetNestedParentCount() { }

	// RVA: 0xAE9DF0 Offset: 0xAE83F0 VA: 0x180AE9DF0
	public object get_Item(string columnName) { }

	// RVA: 0xAEA9F0 Offset: 0xAE8FF0 VA: 0x180AEA9F0
	public void set_Item(string columnName, object value) { }

	// RVA: 0xAE9CD0 Offset: 0xAE82D0 VA: 0x180AE9CD0
	public object get_Item(DataColumn column) { }

	// RVA: 0xAEA5E0 Offset: 0xAE8BE0 VA: 0x180AEA5E0
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xAE9E80 Offset: 0xAE8480 VA: 0x180AE9E80
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public object[] get_ItemArray() { }

	// RVA: 0xAEA180 Offset: 0xAE8780 VA: 0x180AEA180
	public void set_ItemArray(object[] value) { }

	// RVA: 0xAE6720 Offset: 0xAE4D20 VA: 0x180AE6720
	public void AcceptChanges() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE6BB0 Offset: 0xAE51B0 VA: 0x180AE6BB0
	public void BeginEdit() { }

	// RVA: 0xAE6AD0 Offset: 0xAE50D0 VA: 0x180AE6AD0
	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE6BC0 Offset: 0xAE51C0 VA: 0x180AE6BC0
	public void CancelEdit() { }

	// RVA: 0xAE6C50 Offset: 0xAE5250 VA: 0x180AE6C50
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xAE6E20 Offset: 0xAE5420 VA: 0x180AE6E20
	internal void CheckInTable() { }

	// RVA: 0xAE72D0 Offset: 0xAE58D0 VA: 0x180AE72D0
	public void Delete() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE73B0 Offset: 0xAE59B0 VA: 0x180AE73B0
	public void EndEdit() { }

	// RVA: 0xAE8BD0 Offset: 0xAE71D0 VA: 0x180AE8BD0
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xAE8C60 Offset: 0xAE7260 VA: 0x180AE8C60
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xAE7660 Offset: 0xAE5C60 VA: 0x180AE7660
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xAE6ED0 Offset: 0xAE54D0 VA: 0x180AE6ED0
	public void ClearErrors() { }

	// RVA: 0xAE6E70 Offset: 0xAE5470 VA: 0x180AE6E70
	internal void ClearError(DataColumn column) { }

	// RVA: 0xAE9A70 Offset: 0xAE8070 VA: 0x180AE9A70
	public bool get_HasErrors() { }

	// RVA: 0xAE78A0 Offset: 0xAE5EA0 VA: 0x180AE78A0
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xAE74D0 Offset: 0xAE5AD0 VA: 0x180AE74D0
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xAE74E0 Offset: 0xAE5AE0 VA: 0x180AE74E0
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7940 Offset: 0xAE5F40 VA: 0x180AE7940
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xAE7EA0 Offset: 0xAE64A0 VA: 0x180AE7EA0
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xAE7D30 Offset: 0xAE6330 VA: 0x180AE7D30
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7C00 Offset: 0xAE6200 VA: 0x180AE7C00
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xAE8030 Offset: 0xAE6630 VA: 0x180AE8030
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xAE7EB0 Offset: 0xAE64B0 VA: 0x180AE7EB0
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7790 Offset: 0xAE5D90 VA: 0x180AE7790
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xAE7840 Offset: 0xAE5E40 VA: 0x180AE7840
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xAE7A70 Offset: 0xAE6070 VA: 0x180AE7A70
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xAE7AF0 Offset: 0xAE60F0 VA: 0x180AE7AF0
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xAE78F0 Offset: 0xAE5EF0 VA: 0x180AE78F0
	internal int GetCurrentRecordNo() { }

	// RVA: 0xAE79D0 Offset: 0xAE5FD0 VA: 0x180AE79D0
	internal int GetDefaultRecord() { }

	// RVA: 0xAE7CE0 Offset: 0xAE62E0 VA: 0x180AE7CE0
	internal int GetOriginalRecordNo() { }

	// RVA: 0xAE8040 Offset: 0xAE6640 VA: 0x180AE8040
	private int GetProposedRecordNo() { }

	// RVA: 0xAE8090 Offset: 0xAE6690 VA: 0x180AE8090
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xAE7A40 Offset: 0xAE6040 VA: 0x180AE7A40
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xAE8230 Offset: 0xAE6830 VA: 0x180AE8230
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xAE8280 Offset: 0xAE6880 VA: 0x180AE8280
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xAE82B0 Offset: 0xAE68B0 VA: 0x180AE82B0
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE8350 Offset: 0xAE6950 VA: 0x180AE8350
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xAE85C0 Offset: 0xAE6BC0 VA: 0x180AE85C0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xAE8410 Offset: 0xAE6A10 VA: 0x180AE8410
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE85F0 Offset: 0xAE6BF0 VA: 0x180AE85F0
	public bool IsNull(string columnName) { }

	// RVA: 0xAE8680 Offset: 0xAE6C80 VA: 0x180AE8680
	public void RejectChanges() { }

	// RVA: 0xAE8B50 Offset: 0xAE7150 VA: 0x180AE8B50
	internal void ResetLastChangedColumn() { }

	// RVA: 0xAE8F20 Offset: 0xAE7520 VA: 0x180AE8F20
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xAE9070 Offset: 0xAE7670 VA: 0x180AE9070
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xAE9480 Offset: 0xAE7A80 VA: 0x180AE9480
	internal void SetParentRowToDBNull() { }

	// RVA: 0xAE9810 Offset: 0xAE7E10 VA: 0x180AE9810
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xAE6F30 Offset: 0xAE5530 VA: 0x180AE6F30
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

public sealed class DataRowBuilder // TypeDefIndex: 4209
{	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xAE4C40 Offset: 0xAE3240 VA: 0x180AE4C40
	internal void .ctor(DataTable table, int record) { }

}

public enum DataRowAction // TypeDefIndex: 4210
{	// Fields
	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;

}

public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 4211
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0xAE4C90 Offset: 0xAE3290 VA: 0x180AE4C90
	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4212
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRowChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 4213
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0xAE5CF0 Offset: 0xAE42F0 VA: 0x180AE5CF0
	internal void .ctor(DataTable table) { }

	// RVA: 0xAE5DC0 Offset: 0xAE43C0 VA: 0x180AE5DC0 Slot: 8
	public override int get_Count() { }

	// RVA: 0xAE5E10 Offset: 0xAE4410 VA: 0x180AE5E10
	public DataRow get_Item(int index) { }

	// RVA: 0xAE5340 Offset: 0xAE3940 VA: 0x180AE5340
	public void Add(DataRow row) { }

	// RVA: 0xAE56B0 Offset: 0xAE3CB0 VA: 0x180AE56B0
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xAE5950 Offset: 0xAE3F50 VA: 0x180AE5950
	public int IndexOf(DataRow row) { }

	// RVA: 0xAE5230 Offset: 0xAE3830 VA: 0x180AE5230
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xAE5380 Offset: 0xAE3980 VA: 0x180AE5380
	public DataRow Add(object[] values) { }

	// RVA: 0xAE5400 Offset: 0xAE3A00 VA: 0x180AE5400
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xAE54C0 Offset: 0xAE3AC0 VA: 0x180AE54C0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xAE5470 Offset: 0xAE3A70 VA: 0x180AE5470
	internal void ArrayClear() { }

	// RVA: 0xAE5540 Offset: 0xAE3B40 VA: 0x180AE5540
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xAE5640 Offset: 0xAE3C40 VA: 0x180AE5640 Slot: 9
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xAE55D0 Offset: 0xAE3BD0 VA: 0x180AE55D0
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xAE5900 Offset: 0xAE3F00 VA: 0x180AE5900 Slot: 10
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xAE5B80 Offset: 0xAE4180 VA: 0x180AE5B80
	public void Remove(DataRow row) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public void RemoveAt(int index) { }

}

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4214
{	// Methods

	// RVA: 0xAE5EF0 Offset: 0xAE44F0 VA: 0x180AE5EF0
	internal void .ctor() { }

	// RVA: 0xAE5E70 Offset: 0xAE4470 VA: 0x180AE5E70 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xAE5EB0 Offset: 0xAE44B0 VA: 0x180AE5EB0 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4215
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataRow r) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4216
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataTable table) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTable table, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum DataRowState // TypeDefIndex: 4217
{	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;

}

public enum DataRowVersion // TypeDefIndex: 4218
{	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;

}

public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 4219
{	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE6200 Offset: 0xAE4800 VA: 0x180AE6200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public DataView get_DataView() { }

	// RVA: 0xAE66C0 Offset: 0xAE4CC0 VA: 0x180AE66C0
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xAE6230 Offset: 0xAE4830 VA: 0x180AE6230
	internal int GetRecord() { }

	// RVA: 0xAE62B0 Offset: 0xAE48B0 VA: 0x180AE62B0
	internal bool HasRecord() { }

	// RVA: 0xAE6180 Offset: 0xAE4780 VA: 0x180AE6180
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xAE63C0 Offset: 0xAE49C0 VA: 0x180AE63C0
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xAE5F30 Offset: 0xAE4530 VA: 0x180AE5F30
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xAE6110 Offset: 0xAE4710 VA: 0x180AE6110
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DataRow get_Row() { }

	// RVA: 0xAE6120 Offset: 0xAE4720 VA: 0x180AE6120 Slot: 9
	public void EndEdit() { }

	// RVA: 0xAE6690 Offset: 0xAE4C90 VA: 0x180AE6690
	public bool get_IsNew() { }

	// RVA: 0xAE6330 Offset: 0xAE4930 VA: 0x180AE6330
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xAE6490 Offset: 0xAE4A90 VA: 0x180AE6490 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xAE64E0 Offset: 0xAE4AE0 VA: 0x180AE64E0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xAE6590 Offset: 0xAE4B90 VA: 0x180AE6590 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xAE6630 Offset: 0xAE4C30 VA: 0x180AE6630
	private static void .cctor() { }

}

public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 4221
{	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValueAttribute] // RVA: 0xA2C70 Offset: 0xA2070 VA: 0x1800A2C70
	public SerializationFormat RemotingFormat { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValueAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public bool CaseSensitive { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D670 Offset: 0x9CA70 VA: 0x18009D670
	public bool EnforceConstraints { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string DataSetName { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string Prefix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public override ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0xAF6000 Offset: 0xAF4600 VA: 0x180AF6000
	public void .ctor() { }

	// RVA: 0xAF6280 Offset: 0xAF4880 VA: 0x180AF6280
	public void .ctor(string dataSetName) { }

	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xAF7050 Offset: 0xAF5650 VA: 0x180AF7050
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xAF5FD0 Offset: 0xAF45D0 VA: 0x180AF5FD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF62B0 Offset: 0xAF48B0 VA: 0x180AF62B0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xAEE680 Offset: 0xAECC80 VA: 0x180AEE680 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xAF3790 Offset: 0xAF1D90 VA: 0x180AF3790
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAED3B0 Offset: 0xAEB9B0 VA: 0x180AED3B0
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAECE20 Offset: 0xAEB420 VA: 0x180AECE20
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAECA70 Offset: 0xAEB070 VA: 0x180AECA70
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAF3630 Offset: 0xAF1C30 VA: 0x180AF3630
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAECC10 Offset: 0xAEB210 VA: 0x180AECC10
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF3F70 Offset: 0xAF2570 VA: 0x180AF3F70
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAED580 Offset: 0xAEBB80 VA: 0x180AED580
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEE3C0 Offset: 0xAEC9C0 VA: 0x180AEE3C0
	internal void FailedEnableConstraints() { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	public bool get_CaseSensitive() { }

	// RVA: 0xAF6500 Offset: 0xAF4B00 VA: 0x180AF6500
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_EnforceConstraints() { }

	// RVA: 0xAF68D0 Offset: 0xAF4ED0 VA: 0x180AF68D0
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xAEDC60 Offset: 0xAEC260 VA: 0x180AEDC60
	internal void EnableConstraints() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_DataSetName() { }

	// RVA: 0xAF6790 Offset: 0xAF4D90 VA: 0x180AF6790
	public void set_DataSetName(string value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Namespace() { }

	// RVA: 0xAF6BD0 Offset: 0xAF51D0 VA: 0x180AF6BD0
	public void set_Namespace(string value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_Prefix() { }

	// RVA: 0xAF6F30 Offset: 0xAF5530 VA: 0x180AF6F30
	public void set_Prefix(string value) { }

	// RVA: 0xAF6480 Offset: 0xAF4A80 VA: 0x180AF6480
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public CultureInfo get_Locale() { }

	// RVA: 0xAF6A40 Offset: 0xAF5040 VA: 0x180AF6A40
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xAF4480 Offset: 0xAF2A80 VA: 0x180AF4480
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public DataRelationCollection get_Relations() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public DataTableCollection get_Tables() { }

	// RVA: 0xAEB9A0 Offset: 0xAE9FA0 VA: 0x180AEB9A0
	public void Clear() { }

	// RVA: 0xAEBB90 Offset: 0xAEA190 VA: 0x180AEBB90 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0xAEE270 Offset: 0xAEC870 VA: 0x180AEE270
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xAEE6B0 Offset: 0xAECCB0 VA: 0x180AEE6B0
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xAEE7D0 Offset: 0xAECDD0 VA: 0x180AEE7D0
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xAF0A60 Offset: 0xAEF060 VA: 0x180AF0A60
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xAF0A70 Offset: 0xAEF070 VA: 0x180AF0A70
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEF1D0 Offset: 0xAED7D0 VA: 0x180AEF1D0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xAEF290 Offset: 0xAED890 VA: 0x180AEF290
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xAEF5B0 Offset: 0xAEDBB0 VA: 0x180AEF5B0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xAEF7C0 Offset: 0xAEDDC0 VA: 0x180AEF7C0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEF660 Offset: 0xAEDC60 VA: 0x180AEF660
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAF5BD0 Offset: 0xAF41D0 VA: 0x180AF5BD0
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0xAF15C0 Offset: 0xAEFBC0 VA: 0x180AF15C0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xAF15F0 Offset: 0xAEFBF0 VA: 0x180AF15F0
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEE950 Offset: 0xAECF50 VA: 0x180AEE950
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xAEEC00 Offset: 0xAED200 VA: 0x180AEEC00
	private bool IsEmpty() { }

	// RVA: 0xAEFA30 Offset: 0xAEE030 VA: 0x180AEFA30
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xAF15D0 Offset: 0xAEFBD0 VA: 0x180AF15D0
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xAF26A0 Offset: 0xAF0CA0 VA: 0x180AF26A0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAF5DE0 Offset: 0xAF43E0 VA: 0x180AF5DE0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xAEF060 Offset: 0xAED660 VA: 0x180AEF060
	public void Merge(DataSet dataSet) { }

	// RVA: 0xAEEE30 Offset: 0xAED430 VA: 0x180AEEE30
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEF3D0 Offset: 0xAED9D0 VA: 0x180AEF3D0 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xAEF350 Offset: 0xAED950 VA: 0x180AEF350
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xAEF440 Offset: 0xAEDA40 VA: 0x180AEF440
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEF330 Offset: 0xAED930 VA: 0x180AEF330
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xAEF310 Offset: 0xAED910 VA: 0x180AEF310
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xAEF410 Offset: 0xAEDA10 VA: 0x180AEF410
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xAEF530 Offset: 0xAEDB30 VA: 0x180AEF530
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xAF5310 Offset: 0xAF3910 VA: 0x180AF5310
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xAF5120 Offset: 0xAF3720 VA: 0x180AF5120
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xAF3390 Offset: 0xAF1990 VA: 0x180AF3390 Slot: 21
	public virtual void Reset() { }

	// RVA: 0xAF5320 Offset: 0xAF3920 VA: 0x180AF5320
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xAF5730 Offset: 0xAF3D30 VA: 0x180AF5730
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xAF1310 Offset: 0xAEF910 VA: 0x180AF1310 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xAEE410 Offset: 0xAECA10 VA: 0x180AEE410
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xAF4DF0 Offset: 0xAF33F0 VA: 0x180AF4DF0 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xAF4F80 Offset: 0xAF3580 VA: 0x180AF4F80 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xAF50D0 Offset: 0xAF36D0 VA: 0x180AF50D0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal string get_MainTableName() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_MainTableName(string value) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	internal int get_ObjectID() { }

}

public enum DataSetDateTime // TypeDefIndex: 4222
{	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;

}

public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 4223
{	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _savedEnforceConstraints; // 0x16C
	private bool _inDataLoad; // 0x16D
	private bool _initialLoad; // 0x16E
	private bool _schemaLoading; // 0x16F
	private bool _enforceConstraints; // 0x170
	internal bool _suspendEnforceConstraints; // 0x171
	protected internal bool fInitInProgress; // 0x172
	private bool _inLoad; // 0x173
	internal bool _fInLoadDiffgram; // 0x174
	private byte _isTypedDataTable; // 0x175
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	internal List<Index> LiveIndexes { get; }
	[DefaultValueAttribute] // RVA: 0xA3540 Offset: 0xA2940 VA: 0x1800A3540
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public ConstraintCollection Constraints { get; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValueAttribute] // RVA: 0xA3970 Offset: 0xA2D70 VA: 0x1800A3970
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverterAttribute] // RVA: 0xA3A90 Offset: 0xA2E90 VA: 0x1800A3A90
	public DataColumn[] PrimaryKey { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public DataRowCollection Rows { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA3D20 Offset: 0xA3120 VA: 0x1800A3D20
	[DefaultValueAttribute] // RVA: 0xA3D20 Offset: 0xA3120 VA: 0x1800A3D20
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0xB0E1B0 Offset: 0xB0C7B0 VA: 0x180B0E1B0
	public void .ctor() { }

	// RVA: 0xB0E620 Offset: 0xB0CC20 VA: 0x180B0E620
	public void .ctor(string tableName) { }

	// RVA: 0xB0E690 Offset: 0xB0CC90 VA: 0x180B0E690
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB01230 Offset: 0xAFF830 VA: 0x180B01230 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB0A6E0 Offset: 0xB08CE0 VA: 0x180B0A6E0
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xAFC8C0 Offset: 0xAFAEC0 VA: 0x180AFC8C0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xB0B1E0 Offset: 0xB097E0 VA: 0x180B0B1E0
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xAFDA00 Offset: 0xAFC000 VA: 0x180AFDA00
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xB09F30 Offset: 0xB08530 VA: 0x180B09F30
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xAFBDF0 Offset: 0xAFA3F0 VA: 0x180AFBDF0
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xB0AA50 Offset: 0xB09050 VA: 0x180B0AA50
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFCBD0 Offset: 0xAFB1D0 VA: 0x180AFCBD0
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xB0ABC0 Offset: 0xB091C0 VA: 0x180B0ABC0
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFCD50 Offset: 0xAFB350 VA: 0x180AFCD50
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFB3A0 Offset: 0xAF99A0 VA: 0x180AFB3A0
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xB015F0 Offset: 0xAFFBF0 VA: 0x180B015F0
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xAFB010 Offset: 0xAF9610 VA: 0x180AFB010
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xB0E820 Offset: 0xB0CE20 VA: 0x180B0E820
	public bool get_CaseSensitive() { }

	// RVA: 0xB0F560 Offset: 0xB0DB60 VA: 0x180B0F560
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xB0E810 Offset: 0xB0CE10 VA: 0x180B0E810
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xB09A80 Offset: 0xB08080 VA: 0x180B09A80
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xB0D7F0 Offset: 0xB0BDF0 VA: 0x180B0D7F0
	internal void SuspendIndexEvents() { }

	// RVA: 0xB0EBB0 Offset: 0xB0D1B0 VA: 0x180B0EBB0
	private bool get_IsTypedDataTable() { }

	// RVA: 0xB0BD80 Offset: 0xB0A380 VA: 0x180B0BD80
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xB0D630 Offset: 0xB0BC30 VA: 0x180B0D630
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xB0F290 Offset: 0xB0D890 VA: 0x180B0F290
	internal bool get_SelfNested() { }

	// RVA: 0xB0EC60 Offset: 0xB0D260 VA: 0x180B0EC60
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0xB0F1F0 Offset: 0xB0D7F0 VA: 0x180B0F1F0
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xB10370 Offset: 0xB0E970 VA: 0x180B10370
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x7B8C20 Offset: 0x7B7220 VA: 0x1807B8C20
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x7B8CA0 Offset: 0x7B72A0 VA: 0x1807B8CA0
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xB0E830 Offset: 0xB0CE30 VA: 0x180B0E830
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public DataColumnCollection get_Columns() { }

	// RVA: 0xB0E900 Offset: 0xB0CF00 VA: 0x180B0E900
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xB09510 Offset: 0xB07B10 VA: 0x180B09510
	private void ResetConstraints() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataSet get_DataSet() { }

	// RVA: 0xB0C010 Offset: 0xB0A610 VA: 0x180B0C010
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xB0E960 Offset: 0xB0CF60 VA: 0x180B0E960
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xB0EA50 Offset: 0xB0D050 VA: 0x180B0EA50
	internal bool get_EnforceConstraints() { }

	// RVA: 0xB0F6A0 Offset: 0xB0DCA0 VA: 0x180B0F6A0
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xB0F490 Offset: 0xB0DA90 VA: 0x180B0F490
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xAFEB00 Offset: 0xAFD100 VA: 0x180AFEB00
	internal void EnableConstraints() { }

	// RVA: 0xB0EA80 Offset: 0xB0D080 VA: 0x180B0EA80
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xB0EB00 Offset: 0xB0D100 VA: 0x180B0EB00
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public CultureInfo get_Locale() { }

	// RVA: 0xB0F6E0 Offset: 0xB0DCE0 VA: 0x180B0F6E0
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xB0C180 Offset: 0xB0A780 VA: 0x180B0C180
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xB0ED50 Offset: 0xB0D350 VA: 0x180B0ED50
	public int get_MinimumCapacity() { }

	// RVA: 0xB0FB10 Offset: 0xB0E110 VA: 0x180B0FB10
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xB0F1D0 Offset: 0xB0D7D0 VA: 0x180B0F1D0
	internal int get_RecordCapacity() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	internal int get_ElementColumnCount() { }

	// RVA: 0xB0F640 Offset: 0xB0DC40 VA: 0x180B0F640
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xB0F0A0 Offset: 0xB0D6A0 VA: 0x180B0F0A0
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xB0ED30 Offset: 0xB0D330 VA: 0x180B0ED30
	internal bool get_MergingData() { }

	// RVA: 0xB0FAF0 Offset: 0xB0E0F0 VA: 0x180B0FAF0
	internal void set_MergingData(bool value) { }

	// RVA: 0xB0EE20 Offset: 0xB0D420 VA: 0x180B0EE20
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xB0F280 Offset: 0xB0D880 VA: 0x180B0F280
	internal bool get_SchemaLoading() { }

	// RVA: 0xAF8400 Offset: 0xAF6A00 VA: 0x180AF8400
	internal void CacheNestedParent() { }

	// RVA: 0xB007D0 Offset: 0xAFEDD0 VA: 0x180B007D0
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xB0EE30 Offset: 0xB0D430 VA: 0x180B0EE30
	internal int get_NestedParentsCount() { }

	// RVA: 0xB0F170 Offset: 0xB0D770 VA: 0x180B0F170
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xB0FF10 Offset: 0xB0E510 VA: 0x180B0FF10
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public DataRowCollection get_Rows() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public string get_TableName() { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public void set_TableName(string value) { }

	// RVA: 0xB0E9C0 Offset: 0xB0CFC0 VA: 0x180B0E9C0
	internal string get_EncodedTableName() { }

	// RVA: 0xB00FE0 Offset: 0xAFF5E0 VA: 0x180B00FE0
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0xB0ED70 Offset: 0xB0D370 VA: 0x180B0ED70
	public string get_Namespace() { }

	// RVA: 0xB0FB40 Offset: 0xB0E140 VA: 0x180B0FB40
	public void set_Namespace(string value) { }

	// RVA: 0xB02AD0 Offset: 0xB010D0 VA: 0x180B02AD0
	internal bool IsNamespaceInherited() { }

	// RVA: 0xAF8500 Offset: 0xAF6B00 VA: 0x180AF8500
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xAF8E10 Offset: 0xAF7410 VA: 0x180AF8E10
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xAF8BC0 Offset: 0xAF71C0 VA: 0x180AF8BC0
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xAFE650 Offset: 0xAFCC50 VA: 0x180AFE650
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public string get_Prefix() { }

	// RVA: 0xB0FDC0 Offset: 0xB0E3C0 VA: 0x180B0FDC0
	public void set_Prefix(string value) { }

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	internal DataColumn get_XmlText() { }

	// RVA: 0xB10910 Offset: 0xB0EF10 VA: 0x180B10910
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xB0ED20 Offset: 0xB0D320 VA: 0x180B0ED20
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xB0FAE0 Offset: 0xB0E0E0 VA: 0x180B0FAE0
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xB0ED40 Offset: 0xB0D340 VA: 0x180B0ED40
	internal Decimal get_MinOccurs() { }

	// RVA: 0xB0FB00 Offset: 0xB0E100 VA: 0x180B0FB00
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xB0C0E0 Offset: 0xB0A6E0 VA: 0x180B0C0E0
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xB00650 Offset: 0xAFEC50 VA: 0x180B00650
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xB006E0 Offset: 0xAFECE0 VA: 0x180B006E0
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xB0C740 Offset: 0xB0AD40 VA: 0x180B0C740
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xB02B90 Offset: 0xB01190 VA: 0x180B02B90
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xAF7AB0 Offset: 0xAF60B0 VA: 0x180AF7AB0
	public void AcceptChanges() { }

	// RVA: 0xAFB730 Offset: 0xAF9D30 VA: 0x180AFB730 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xAFA9F0 Offset: 0xAF8FF0 VA: 0x180AFA9F0 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0xAFAA00 Offset: 0xAF9000 VA: 0x180AFAA00
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xB01C50 Offset: 0xB00250 VA: 0x180B01C50
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xAF9960 Offset: 0xAF7F60 VA: 0x180AF9960
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xAF9D20 Offset: 0xAF8320 VA: 0x180AF9D20
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0xAF7EA0 Offset: 0xAF64A0 VA: 0x180AF7EA0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xB02140 Offset: 0xB00740 VA: 0x180B02140
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xB02570 Offset: 0xB00B70 VA: 0x180B02570
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0xAF9110 Offset: 0xAF7710 VA: 0x180AF9110
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xAF9140 Offset: 0xAF7740 VA: 0x180AF9140
	public void Clear() { }

	// RVA: 0xAF9150 Offset: 0xAF7750 VA: 0x180AF9150
	internal void Clear(bool clearAll) { }

	// RVA: 0xAF8430 Offset: 0xAF6A30 VA: 0x180AF8430
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xAFABE0 Offset: 0xAF91E0 VA: 0x180AFABE0
	internal void CommitRow(DataRow row) { }

	// RVA: 0xAFAEB0 Offset: 0xAF94B0 VA: 0x180AFAEB0
	internal int Compare(string s1, string s2) { }

	// RVA: 0xAFAD20 Offset: 0xAF9320 VA: 0x180AFAD20
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xB01ED0 Offset: 0xB004D0 VA: 0x180B01ED0
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xB02AE0 Offset: 0xB010E0 VA: 0x180B02AE0
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xAFBD60 Offset: 0xAFA360 VA: 0x180AFBD60
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xB00A60 Offset: 0xAFF060 VA: 0x180B00A60
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xB00B80 Offset: 0xAFF180 VA: 0x180B00B80
	internal void FreeRecord(ref int record) { }

	// RVA: 0xB00F90 Offset: 0xAFF590 VA: 0x180B00F90
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xB00DC0 Offset: 0xAFF3C0 VA: 0x180B00DC0
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x77AA90 Offset: 0x779090 VA: 0x18077AA90
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0xB01B40 Offset: 0xB00140 VA: 0x180B01B40
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xB02160 Offset: 0xB00760 VA: 0x180B02160
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0xB03780 Offset: 0xB01D80 VA: 0x180B03780
	internal int NewRecord() { }

	// RVA: 0xB03D60 Offset: 0xB02360 VA: 0x180B03D60
	internal int NewUninitializedRecord() { }

	// RVA: 0xB03500 Offset: 0xB01B00 VA: 0x180B03500
	internal int NewRecordFromArray(object[] value) { }

	// RVA: 0xB03820 Offset: 0xB01E20 VA: 0x180B03820
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xB03490 Offset: 0xB01A90 VA: 0x180B03490
	internal DataRow NewEmptyRow() { }

	// RVA: 0xB03D80 Offset: 0xB02380 VA: 0x180B03D80
	private DataRow NewUninitializedRow() { }

	// RVA: 0xB03C60 Offset: 0xB02260 VA: 0x180B03C60
	public DataRow NewRow() { }

	// RVA: 0xAFB490 Offset: 0xAF9A90 VA: 0x180AFB490
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xB03A60 Offset: 0xB02060 VA: 0x180B03A60
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xB03BB0 Offset: 0xB021B0 VA: 0x180B03BB0
	internal DataRow NewRow(int record) { }

	// RVA: 0xB03AE0 Offset: 0xB020E0 VA: 0x180B03AE0 Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xB01950 Offset: 0xAFFF50 VA: 0x180B01950 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0xB03910 Offset: 0xB01F10 VA: 0x180B03910
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xB0EDE0 Offset: 0xB0D3E0 VA: 0x180B0EDE0
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xB03E80 Offset: 0xB02480 VA: 0x180B03E80 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xB03DC0 Offset: 0xB023C0 VA: 0x180B03DC0 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xB03F40 Offset: 0xB02540 VA: 0x180B03F40 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xB04000 Offset: 0xB02600 VA: 0x180B04000
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xB04020 Offset: 0xB02620 VA: 0x180B04020
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB04190 Offset: 0xB02790 VA: 0x180B04190
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB040D0 Offset: 0xB026D0 VA: 0x180B040D0 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xB04240 Offset: 0xB02840 VA: 0x180B04240 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xB043C0 Offset: 0xB029C0 VA: 0x180B043C0 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xB04300 Offset: 0xB02900 VA: 0x180B04300 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xB04480 Offset: 0xB02A80 VA: 0x180B04480 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xB04540 Offset: 0xB02B40 VA: 0x180B04540 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xB04600 Offset: 0xB02C00 VA: 0x180B04600 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xB046C0 Offset: 0xB02CC0 VA: 0x180B046C0
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xB04A00 Offset: 0xB03000 VA: 0x180B04A00
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xB088C0 Offset: 0xB06EC0 VA: 0x180B088C0
	internal void RecordChanged(int record) { }

	// RVA: 0xB08A30 Offset: 0xB07030 VA: 0x180B08A30
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xB08C10 Offset: 0xB07210 VA: 0x180B08C10
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xB08DA0 Offset: 0xB073A0 VA: 0x180B08DA0
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xB09030 Offset: 0xB07630 VA: 0x180B09030
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB01F80 Offset: 0xB00580 VA: 0x180B01F80
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB0D640 Offset: 0xB0BC40 VA: 0x180B0D640
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xB09250 Offset: 0xB07850 VA: 0x180B09250
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xB09720 Offset: 0xB07D20 VA: 0x180B09720 Slot: 30
	public virtual void Reset() { }

	// RVA: 0xB09530 Offset: 0xB07B30 VA: 0x180B09530
	internal void ResetIndexes() { }

	// RVA: 0xB09540 Offset: 0xB07B40 VA: 0x180B09540
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xB09DC0 Offset: 0xB083C0 VA: 0x180B09DC0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xB04A80 Offset: 0xB03080 VA: 0x180B04A80
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB04CC0 Offset: 0xB032C0 VA: 0x180B04CC0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB04F50 Offset: 0xB03550 VA: 0x180B04F50
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xB09E20 Offset: 0xB08420 VA: 0x180B09E20
	public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xB0D0F0 Offset: 0xB0B6F0 VA: 0x180B0D0F0
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0xB0C800 Offset: 0xB0AE00 VA: 0x180B0C800
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0xB0D1B0 Offset: 0xB0B7B0 VA: 0x180B0D1B0
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xB09DA0 Offset: 0xB083A0 VA: 0x180B09DA0
	private void RestoreShadowIndexes() { }

	// RVA: 0xB0D550 Offset: 0xB0BB50 VA: 0x180B0D550
	private void SetShadowIndexes() { }

	// RVA: 0xB0D5B0 Offset: 0xB0BBB0 VA: 0x180B0D5B0
	internal void ShadowIndexCopy() { }

	// RVA: 0xB0D9D0 Offset: 0xB0BFD0 VA: 0x180B0D9D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xAF81C0 Offset: 0xAF67C0 VA: 0x180AF81C0
	public void BeginLoadData() { }

	// RVA: 0xAFF010 Offset: 0xAFD610 VA: 0x180AFF010
	public void EndLoadData() { }

	// RVA: 0xB0DAA0 Offset: 0xB0C0A0 VA: 0x180B0DAA0
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xAF7EE0 Offset: 0xAF64E0 VA: 0x180AF7EE0
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xAF7ED0 Offset: 0xAF64D0 VA: 0x180AF7ED0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xAF7DE0 Offset: 0xAF63E0 VA: 0x180AF7DE0
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xB0DA80 Offset: 0xB0C080 VA: 0x180B0DA80
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xB01320 Offset: 0xAFF920 VA: 0x180B01320
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xB0F4A0 Offset: 0xB0DAA0 VA: 0x180B0F4A0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x701900 Offset: 0x6FFF00 VA: 0x180701900
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xB03240 Offset: 0xB01840 VA: 0x180B03240
	public void Merge(DataTable table) { }

	// RVA: 0xB03260 Offset: 0xB01860 VA: 0x180B03260
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xB0DE30 Offset: 0xB0C430 VA: 0x180B0DE30
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xAF8B10 Offset: 0xAF7110 VA: 0x180AF8B10
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xAF87B0 Offset: 0xAF6DB0 VA: 0x180AF87B0
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0xB0DAD0 Offset: 0xB0C0D0 VA: 0x180B0DAD0
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xB08820 Offset: 0xB06E20 VA: 0x180B08820
	public XmlReadMode ReadXml(TextReader reader) { }

	// RVA: 0xB09A20 Offset: 0xB08020 VA: 0x180B09A20
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xB028F0 Offset: 0xB00EF0 VA: 0x180B028F0
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xB07A70 Offset: 0xB06070 VA: 0x180B07A70
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB06C60 Offset: 0xB05260 VA: 0x180B06C60
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAEF5B0 Offset: 0xAEDBB0 VA: 0x180AEF5B0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xB05110 Offset: 0xB03710 VA: 0x180B05110
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAEF1D0 Offset: 0xAED7D0 VA: 0x180AEF1D0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xB052D0 Offset: 0xB038D0 VA: 0x180B052D0
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xB05180 Offset: 0xB03780 VA: 0x180B05180
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB05BA0 Offset: 0xB041A0 VA: 0x180B05BA0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAFBAD0 Offset: 0xAFA0D0 VA: 0x180AFBAD0
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0xAFB7C0 Offset: 0xAF9DC0 VA: 0x180AFB7C0
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0xB00BA0 Offset: 0xAFF1A0 VA: 0x180B00BA0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xB0D890 Offset: 0xB0BE90 VA: 0x180B0D890 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xB019B0 Offset: 0xAFFFB0 VA: 0x180B019B0 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xB0D8B0 Offset: 0xB0BEB0 VA: 0x180B0D8B0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xB0D980 Offset: 0xB0BF80 VA: 0x180B0D980 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xB06C40 Offset: 0xB05240 VA: 0x180B06C40 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xB0F200 Offset: 0xB0D800 VA: 0x180B0F200
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xB0F090 Offset: 0xB0D690 VA: 0x180B0F090
	internal int get_ObjectID() { }

	// RVA: 0xAF7D20 Offset: 0xAF6320 VA: 0x180AF7D20
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xB08FB0 Offset: 0xB075B0 VA: 0x180B08FB0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xAFFBD0 Offset: 0xAFE1D0 VA: 0x180AFFBD0
	internal void EvaluateExpressions() { }

	// RVA: 0xB00100 Offset: 0xAFE700 VA: 0x180B00100
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0xAFFE60 Offset: 0xAFE460 VA: 0x180AFFE60
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xAFF240 Offset: 0xAFD840 VA: 0x180AFF240
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xAFF370 Offset: 0xAFD970 VA: 0x180AFF370
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

}

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4224
{	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1EF630 Offset: 0x1EEA30 VA: 0x1801EF630
	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4225
{	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1EF4F0 Offset: 0x1EE8F0 VA: 0x1801EF4F0
	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4226
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CED60 Offset: 0x13CD360 VA: 0x1813CED60
	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTableClearEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 4228
{	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x13D13B0 Offset: 0x13CF9B0 VA: 0x1813D13B0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	internal int get_ObjectID() { }

	// RVA: 0x13D1700 Offset: 0x13CFD00 VA: 0x1813D1700
	public DataTable get_Item(int index) { }

	// RVA: 0x13D1600 Offset: 0x13CFC00 VA: 0x1813D1600
	public DataTable get_Item(string name) { }

	// RVA: 0x13D14E0 Offset: 0x13CFAE0 VA: 0x1813D14E0
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x13D0470 Offset: 0x13CEA70 VA: 0x1813D0470
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x13D0300 Offset: 0x13CE900 VA: 0x1813D0300
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x13CEDD0 Offset: 0x13CD3D0 VA: 0x1813CEDD0
	public void Add(DataTable table) { }

	// RVA: 0x13CF030 Offset: 0x13CD630 VA: 0x1813CF030
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x13CF060 Offset: 0x13CD660 VA: 0x1813CF060
	internal string AssignName() { }

	// RVA: 0x13CF120 Offset: 0x13CD720 VA: 0x1813CF120
	private void BaseAdd(DataTable table) { }

	// RVA: 0x13CF340 Offset: 0x13CD940 VA: 0x1813CF340
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x13CF500 Offset: 0x13CDB00 VA: 0x1813CF500
	private void BaseRemove(DataTable table) { }

	// RVA: 0x13CF700 Offset: 0x13CDD00 VA: 0x1813CF700
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x13CFB80 Offset: 0x13CE180 VA: 0x1813CFB80
	public void Clear() { }

	// RVA: 0x13D0160 Offset: 0x13CE760 VA: 0x1813D0160
	public bool Contains(string name) { }

	// RVA: 0x13CFFA0 Offset: 0x13CE5A0 VA: 0x1813CFFA0
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x13D0180 Offset: 0x13CE780 VA: 0x1813D0180
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x13D05C0 Offset: 0x13CEBC0 VA: 0x1813D05C0
	public int IndexOf(DataTable table) { }

	// RVA: 0x13D06C0 Offset: 0x13CECC0 VA: 0x1813D06C0
	public int IndexOf(string tableName) { }

	// RVA: 0x13D06E0 Offset: 0x13CECE0 VA: 0x1813D06E0
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x13D11D0 Offset: 0x13CF7D0 VA: 0x1813D11D0
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x13D0960 Offset: 0x13CEF60 VA: 0x1813D0960
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x13D07A0 Offset: 0x13CEDA0 VA: 0x1813D07A0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x13D0BA0 Offset: 0x13CF1A0 VA: 0x1813D0BA0
	private string MakeName(int index) { }

	// RVA: 0x13D0C30 Offset: 0x13CF230 VA: 0x1813D0C30
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D0CE0 Offset: 0x13CF2E0 VA: 0x1813D0CE0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D0D90 Offset: 0x13CF390 VA: 0x1813D0D90
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x13D1010 Offset: 0x13CF610 VA: 0x1813D1010
	public void Remove(DataTable table) { }

	// RVA: 0x13D1230 Offset: 0x13CF830 VA: 0x1813D1230
	internal void UnregisterName(string name) { }

}

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13D17E0 Offset: 0x13CFDE0 VA: 0x1813D17E0
	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4230
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTableNewRowEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
{
// Namespace: System.Data
[DefaultEventAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
[DefaultPropertyAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
[DefaultMemberAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataViewRowState _delayedRecordStates; // 0x88
	private bool _fEndInitInProgress; // 0x8C
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x90
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0x98
	private DataViewListener _dvListener; // 0xA0
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xA8

	// Properties
	[DefaultValueAttribute] // RVA: 0x9D670 Offset: 0x9CA70 VA: 0x18009D670
	public bool AllowDelete { get; }
	[DefaultValueAttribute] // RVA: 0x9D670 Offset: 0x9CA70 VA: 0x18009D670
	public bool AllowNew { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public int Count { get; }
	private int CountFromIndex { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public DataViewManager DataViewManager { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	protected bool IsOpen { get; }
	[DefaultValueAttribute] // RVA: 0xA4C10 Offset: 0xA4010 VA: 0x1800A4C10
	public DataViewRowState RowStateFilter { get; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA4E50 Offset: 0xA4250 VA: 0x1800A4E50
	[DefaultValueAttribute] // RVA: 0xA4E50 Offset: 0xA4250 VA: 0x1800A4E50
	[TypeConverterAttribute] // RVA: 0xA4E50 Offset: 0xA4250 VA: 0x1800A4E50
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x13D5D50 Offset: 0x13D4350 VA: 0x1813D5D50
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool get_AllowDelete() { }

	// RVA: 0x10872C0 Offset: 0x10858C0 VA: 0x1810872C0
	public bool get_AllowNew() { }

	// RVA: 0x13D6070 Offset: 0x13D4670 VA: 0x1813D6070 Slot: 22
	public int get_Count() { }

	// RVA: 0x13D6040 Offset: 0x13D4640 VA: 0x1813D6040
	private int get_CountFromIndex() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x7CC9F0 Offset: 0x7CAFF0 VA: 0x1807CC9F0
	protected bool get_IsOpen() { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x13D60C0 Offset: 0x13D46C0 VA: 0x1813D60C0
	public string get_Sort() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public DataTable get_Table() { }

	// RVA: 0x13D58C0 Offset: 0x13D3EC0 VA: 0x1813D58C0 Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x13D5920 Offset: 0x13D3F20 VA: 0x1813D5920 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x13D58C0 Offset: 0x13D3EC0 VA: 0x1813D58C0
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x13D3070 Offset: 0x13D1670 VA: 0x1813D3070 Slot: 25
	public virtual DataRowView AddNew() { }

	// RVA: 0x13D3330 Offset: 0x13D1930 VA: 0x1813D3330
	private void CheckOpen() { }

	// RVA: 0x13D35C0 Offset: 0x13D1BC0 VA: 0x1813D35C0
	protected void Close() { }

	// RVA: 0x13D3A70 Offset: 0x13D2070 VA: 0x1813D3A70 Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13D3860 Offset: 0x13D1E60 VA: 0x1813D3860
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x13D3BD0 Offset: 0x13D21D0 VA: 0x1813D3BD0
	public void Delete(int index) { }

	// RVA: 0x13D3C00 Offset: 0x13D2200 VA: 0x1813D3C00
	internal void Delete(DataRow row) { }

	// RVA: 0x13D3DE0 Offset: 0x13D23E0 VA: 0x1813D3DE0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13D3E40 Offset: 0x13D2440 VA: 0x1813D3E40
	internal void FinishAddNew(bool success) { }

	// RVA: 0x13D4010 Offset: 0x13D2610 VA: 0x1813D4010 Slot: 24
	public IEnumerator GetEnumerator() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x13D5570 Offset: 0x13D3B70 VA: 0x1813D5570 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x13D5610 Offset: 0x13D3C10 VA: 0x1813D5610 Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x13D5650 Offset: 0x13D3C50 VA: 0x1813D5650 Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x13D56E0 Offset: 0x13D3CE0 VA: 0x1813D56E0 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x13D4560 Offset: 0x13D2B60 VA: 0x1813D4560
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x13D4500 Offset: 0x13D2B00 VA: 0x1813D4500
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x13D5760 Offset: 0x13D3D60 VA: 0x1813D5760 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13D57A0 Offset: 0x13D3DA0 VA: 0x1813D57A0 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x13D3BD0 Offset: 0x13D21D0 VA: 0x1813D3BD0 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 26
	internal virtual IFilter GetFilter() { }

	// RVA: 0x13D40B0 Offset: 0x13D26B0 VA: 0x1813D40B0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x13D4240 Offset: 0x13D2840 VA: 0x1813D4240
	internal DataRow GetRow(int index) { }

	// RVA: 0x13D4170 Offset: 0x13D2770 VA: 0x1813D4170
	private DataRowView GetRowView(int record) { }

	// RVA: 0x13D41E0 Offset: 0x13D27E0 VA: 0x1813D41E0
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x13D4480 Offset: 0x13D2A80 VA: 0x1813D4480 Slot: 27
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x13D43B0 Offset: 0x13D29B0 VA: 0x1813D43B0
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x13D46C0 Offset: 0x13D2CC0 VA: 0x1813D46C0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D4970 Offset: 0x13D2F70 VA: 0x1813D4970 Slot: 28
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D5100 Offset: 0x13D3700 VA: 0x1813D5100
	protected void Reset() { }

	// RVA: 0x13D4ED0 Offset: 0x13D34D0 VA: 0x1813D4ED0
	internal void ResetRowViewCache() { }

	// RVA: 0x13D5130 Offset: 0x13D3730 VA: 0x1813D5130
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D5550 Offset: 0x13D3B50 VA: 0x1813D5550 Slot: 29
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x13D5340 Offset: 0x13D3940 VA: 0x1813D5340
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x13D5CC0 Offset: 0x13D42C0 VA: 0x1813D5CC0
	protected void UpdateIndex() { }

	// RVA: 0x13D5CE0 Offset: 0x13D42E0 VA: 0x1813D5CE0 Slot: 30
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x13D5960 Offset: 0x13D3F60 VA: 0x1813D5960
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x13D3380 Offset: 0x13D1980 VA: 0x1813D3380
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D4C90 Offset: 0x13D3290 VA: 0x1813D4C90
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D3620 Offset: 0x13D1C20 VA: 0x1813D3620 Slot: 31
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D3600 Offset: 0x13D1C00 VA: 0x1813D3600
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x107AAE0 Offset: 0x10790E0 VA: 0x18107AAE0
	internal int get_ObjectID() { }

	// RVA: 0x13D5CF0 Offset: 0x13D42F0 VA: 0x1813D5CF0
	private static void .cctor() { }

}

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4233
{	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x13340

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13CECD0 Offset: 0x13CD2D0 VA: 0x1813CECD0 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x13CECE0 Offset: 0x13CD2E0 VA: 0x1813CECE0 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x13CED00 Offset: 0x13CD300 VA: 0x1813CED00
	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4234
{	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x13D2C80 Offset: 0x13D1280 VA: 0x1813D2C80
	internal void .ctor(DataView dv) { }

	// RVA: 0x13D1F80 Offset: 0x13D0580 VA: 0x1813D1F80
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D23F0 Offset: 0x13D09F0 VA: 0x1813D23F0
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D2090 Offset: 0x13D0690 VA: 0x1813D2090
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D2300 Offset: 0x13D0900 VA: 0x1813D2300
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D2180 Offset: 0x13D0780 VA: 0x1813D2180
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D2740 Offset: 0x13D0D40 VA: 0x1813D2740
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x13D29F0 Offset: 0x13D0FF0 VA: 0x1813D29F0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x13D2A00 Offset: 0x13D1000 VA: 0x1813D2A00
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x13D24E0 Offset: 0x13D0AE0 VA: 0x1813D24E0
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x13D2910 Offset: 0x13D0F10 VA: 0x1813D2910
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x13D2070 Offset: 0x13D0670 VA: 0x1813D2070
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x13D25B0 Offset: 0x13D0BB0 VA: 0x1813D25B0
	private void RegisterListener(DataTable table) { }

}

public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4235
{	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x13D2D10 Offset: 0x13D1310 VA: 0x1813D2D10
	private static void .cctor() { }

}

public enum DataViewRowState // TypeDefIndex: 4236
{	// Fields
	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;

}

public class DataViewSetting // TypeDefIndex: 4237
{	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x13D2FF0 Offset: 0x13D15F0 VA: 0x1813D2FF0
	internal void .ctor() { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x12387B0 Offset: 0x1236DB0 VA: 0x1812387B0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D2FD0 Offset: 0x13D15D0 VA: 0x1813D2FD0
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_RowFilter() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Sort() { }

}

public class DataViewSettingCollection // TypeDefIndex: 4238
{	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }

	// Methods

	// RVA: 0x13D2DA0 Offset: 0x13D13A0 VA: 0x1813D2DA0 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x13D2F10 Offset: 0x13D1510 VA: 0x1813D2F10 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x13D2D70 Offset: 0x13D1370 VA: 0x1813D2D70
	internal void Remove(DataTable table) { }

}

public enum DbType // TypeDefIndex: 4239
{	// Fields
	public int value__; // 0x0
	public const DbType AnsiString = 0;
	public const DbType Binary = 1;
	public const DbType Byte = 2;
	public const DbType Boolean = 3;
	public const DbType Currency = 4;
	public const DbType Date = 5;
	public const DbType DateTime = 6;
	public const DbType Decimal = 7;
	public const DbType Double = 8;
	public const DbType Guid = 9;
	public const DbType Int16 = 10;
	public const DbType Int32 = 11;
	public const DbType Int64 = 12;
	public const DbType Object = 13;
	public const DbType SByte = 14;
	public const DbType Single = 15;
	public const DbType String = 16;
	public const DbType Time = 17;
	public const DbType UInt16 = 18;
	public const DbType UInt32 = 19;
	public const DbType UInt64 = 20;
	public const DbType VarNumeric = 21;
	public const DbType AnsiStringFixedLength = 22;
	public const DbType StringFixedLength = 23;
	public const DbType Xml = 25;
	public const DbType DateTime2 = 26;
	public const DbType DateTimeOffset = 27;

}

internal sealed class DataExpression : IFilter // TypeDefIndex: 4247
{	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal ExpressionNode ExpressionNode { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x1235EE0 Offset: 0x12344E0 VA: 0x181235EE0
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x1235C80 Offset: 0x1234280 VA: 0x181235C80
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x1235F00 Offset: 0x1234500 VA: 0x181235F00
	internal string get_Expression() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExpressionNode get_ExpressionNode() { }

	// RVA: 0x1235F40 Offset: 0x1234540 VA: 0x181235F40
	internal bool get_HasValue() { }

	// RVA: 0x1235490 Offset: 0x1233A90 VA: 0x181235490
	internal void Bind(DataTable table) { }

	// RVA: 0x12355C0 Offset: 0x1233BC0 VA: 0x1812355C0
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x12357E0 Offset: 0x1233DE0 VA: 0x1812357E0
	internal object Evaluate() { }

	// RVA: 0x12355E0 Offset: 0x1233BE0 VA: 0x1812355E0
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1235830 Offset: 0x1233E30 VA: 0x181235830 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1235910 Offset: 0x1233F10 VA: 0x181235910
	internal bool IsTableAggregate() { }

	// RVA: 0x1235930 Offset: 0x1233F30 VA: 0x181235930
	internal static bool IsUnknown(object value) { }

	// RVA: 0x12357F0 Offset: 0x1233DF0 VA: 0x1812357F0
	internal bool HasLocalAggregate() { }

	// RVA: 0x1235810 Offset: 0x1233E10 VA: 0x181235810
	internal bool HasRemoteAggregate() { }

	// RVA: 0x1235990 Offset: 0x1233F90 VA: 0x181235990
	internal static bool ToBoolean(object value) { }

}

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4333
{	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x13D19F0 Offset: 0x13CFFF0 VA: 0x1813D19F0
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x13D1EA0 Offset: 0x13D04A0 VA: 0x1813D1EA0
	private void .ctor(XmlWriter w) { }

	// RVA: 0x13D1ED0 Offset: 0x13D04D0 VA: 0x1813D1ED0
	internal Stream get_BaseStream() { }

	// RVA: 0x13D1DB0 Offset: 0x13D03B0 VA: 0x1813D1DB0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x13D1D80 Offset: 0x13D0380 VA: 0x1813D1D80 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13D1C30 Offset: 0x13D0230 VA: 0x1813D1C30 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x13D1BD0 Offset: 0x13D01D0 VA: 0x1813D1BD0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13D1DE0 Offset: 0x13D03E0 VA: 0x1813D1DE0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1319910 Offset: 0x1317F10 VA: 0x181319910 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13D1C90 Offset: 0x13D0290 VA: 0x1813D1C90 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x13D1D50 Offset: 0x13D0350 VA: 0x1813D1D50 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x13D1C00 Offset: 0x13D0200 VA: 0x1813D1C00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x13D1B10 Offset: 0x13D0110 VA: 0x1813D1B10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13D1BA0 Offset: 0x13D01A0 VA: 0x1813D1BA0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13D1CC0 Offset: 0x13D02C0 VA: 0x1813D1CC0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13D1C60 Offset: 0x13D0260 VA: 0x1813D1C60 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x13D1B40 Offset: 0x13D0140 VA: 0x1813D1B40 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x13D1E70 Offset: 0x13D0470 VA: 0x1813D1E70 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13D1E10 Offset: 0x13D0410 VA: 0x1813D1E10 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x13D1E40 Offset: 0x13D0440 VA: 0x1813D1E40 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13D1B70 Offset: 0x13D0170 VA: 0x1813D1B70 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13D1CF0 Offset: 0x13D02F0 VA: 0x1813D1CF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13D1D20 Offset: 0x13D0320 VA: 0x1813D1D20 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x13D1AB0 Offset: 0x13D00B0 VA: 0x1813D1AB0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x13D1AE0 Offset: 0x13D00E0 VA: 0x1813D1AE0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x13D1F50 Offset: 0x13D0550 VA: 0x1813D1F50 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x13D19C0 Offset: 0x13CFFC0 VA: 0x1813D19C0 Slot: 28
	public override void Close() { }

	// RVA: 0x13D1A50 Offset: 0x13D0050 VA: 0x1813D1A50 Slot: 29
	public override void Flush() { }

	// RVA: 0x13D1A80 Offset: 0x13D0080 VA: 0x1813D1A80 Slot: 30
	public override string LookupPrefix(string ns) { }

}

internal sealed class DataTextReader : XmlReader // TypeDefIndex: 4334
{	// Fields
	private XmlReader _xmlreader; // 0x10

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x13D1850 Offset: 0x13CFE50 VA: 0x1813D1850
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x13D18F0 Offset: 0x13CFEF0 VA: 0x1813D18F0
	private void .ctor(XmlReader input) { }

	// RVA: 0x132EAD0 Offset: 0x132D0D0 VA: 0x18132EAD0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB19680 Offset: 0xB17C80 VA: 0x180B19680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9280 Offset: 0xBC7880 VA: 0x180BC9280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC9220 Offset: 0xBC7820 VA: 0x180BC9220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC93B0 Offset: 0xBC79B0 VA: 0x180BC93B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC9190 Offset: 0xBC7790 VA: 0x180BC9190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC9160 Offset: 0xBC7760 VA: 0x180BC9160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8920 Offset: 0xBC6F20 VA: 0x180BC8920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8950 Offset: 0xBC6F50 VA: 0x180BC8950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC8980 Offset: 0xBC6F80 VA: 0x180BC8980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8A20 Offset: 0xBC7020 VA: 0x180BC8A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC89F0 Offset: 0xBC6FF0 VA: 0x180BC89F0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC8A80 Offset: 0xBC7080 VA: 0x180BC8A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8AB0 Offset: 0xBC70B0 VA: 0x180BC8AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8A50 Offset: 0xBC7050 VA: 0x180BC8A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8AE0 Offset: 0xBC70E0 VA: 0x180BC8AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8B40 Offset: 0xBC7140 VA: 0x180BC8B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC9130 Offset: 0xBC7730 VA: 0x180BC9130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F5D0 Offset: 0xB9DBD0 VA: 0x180B9F5D0 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8C10 Offset: 0xBC7210 VA: 0x180BC8C10 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x13D1990 Offset: 0x13CFF90 VA: 0x1813D1990 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC8B70 Offset: 0xBC7170 VA: 0x180BC8B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x13D1960 Offset: 0x13CFF60 VA: 0x1813D1960 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xB9F000 Offset: 0xB9D600 VA: 0x180B9F000 Slot: 42
	public override string ReadString() { }

}

public abstract class DbCommandBuilder : Component // TypeDefIndex: 4369
{	// Fields
	private DbDataAdapter _dataAdapter; // 0x28
	private DbCommand _insertCommand; // 0x30
	private DbCommand _updateCommand; // 0x38
	private DbCommand _deleteCommand; // 0x40
	private MissingMappingAction _missingMappingAction; // 0x48
	private ConflictOption _conflictDetection; // 0x4C
	private bool _setAllValues; // 0x50
	private bool _hasPartialPrimaryKey; // 0x51
	private DataTable _dbSchemaTable; // 0x58
	private DbSchemaRow[] _dbSchemaRows; // 0x60
	private string[] _sourceColumnNames; // 0x68
	private DbCommandBuilder.ParameterNames _parameterNames; // 0x70
	private string _quotedBaseTableName; // 0x78
	private CatalogLocation _catalogLocation; // 0x80
	private string _catalogSeparator; // 0x88
	private string _schemaSeparator; // 0x90
	private string _quotePrefix; // 0x98
	private string _quoteSuffix; // 0xA0
	private string _parameterNamePattern; // 0xA8
	private string _parameterMarkerFormat; // 0xB0
	private int _parameterNameMaxLength; // 0xB8

	// Properties
	[DefaultValueAttribute] // RVA: 0xA9840 Offset: 0xA8C40 VA: 0x1800A9840
	public virtual ConflictOption ConflictOption { get; }
	[DefaultValueAttribute] // RVA: 0xA99B0 Offset: 0xA8DB0 VA: 0x1800A99B0
	public virtual CatalogLocation CatalogLocation { get; }
	[DefaultValueAttribute] // RVA: 0xA9AC0 Offset: 0xA8EC0 VA: 0x1800A9AC0
	public virtual string CatalogSeparator { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public DbDataAdapter DataAdapter { get; set; }
	internal int ParameterNameMaxLength { get; }
	internal string ParameterNamePattern { get; }
	private string QuotedBaseTableName { get; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public virtual string QuotePrefix { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public virtual string QuoteSuffix { get; set; }
	[DefaultValueAttribute] // RVA: 0xA9AC0 Offset: 0xA8EC0 VA: 0x1800A9AC0
	public virtual string SchemaSeparator { get; }
	[DefaultValueAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public bool SetAllValues { get; }
	private DbCommand InsertCommand { get; set; }
	private DbCommand UpdateCommand { get; set; }
	private DbCommand DeleteCommand { get; set; }

	// Methods

	// RVA: 0x127F5C0 Offset: 0x127DBC0 VA: 0x18127F5C0
	protected void .ctor() { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0 Slot: 12
	public virtual ConflictOption get_ConflictOption() { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0 Slot: 13
	public virtual CatalogLocation get_CatalogLocation() { }

	// RVA: 0x127F690 Offset: 0x127DC90 VA: 0x18127F690 Slot: 14
	public virtual string get_CatalogSeparator() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public DbDataAdapter get_DataAdapter() { }

	// RVA: 0x127F7D0 Offset: 0x127DDD0 VA: 0x18127F7D0
	public void set_DataAdapter(DbDataAdapter value) { }

	// RVA: 0x107AB90 Offset: 0x1079190 VA: 0x18107AB90
	internal int get_ParameterNameMaxLength() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	internal string get_ParameterNamePattern() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	private string get_QuotedBaseTableName() { }

	// RVA: 0x127F6E0 Offset: 0x127DCE0 VA: 0x18127F6E0 Slot: 15
	public virtual string get_QuotePrefix() { }

	// RVA: 0x127F870 Offset: 0x127DE70 VA: 0x18127F870 Slot: 16
	public virtual void set_QuotePrefix(string value) { }

	// RVA: 0x127F730 Offset: 0x127DD30 VA: 0x18127F730 Slot: 17
	public virtual string get_QuoteSuffix() { }

	// RVA: 0x127F900 Offset: 0x127DF00 VA: 0x18127F900 Slot: 18
	public virtual void set_QuoteSuffix(string value) { }

	// RVA: 0x127F780 Offset: 0x127DD80 VA: 0x18127F780 Slot: 19
	public virtual string get_SchemaSeparator() { }

	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	public bool get_SetAllValues() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	private DbCommand get_InsertCommand() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_InsertCommand(DbCommand value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	private DbCommand get_UpdateCommand() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	private DbCommand get_DeleteCommand() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	private void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127B820 Offset: 0x1279E20 VA: 0x18127B820
	private void BuildCache(bool closeConnection, DataRow dataRow, bool useColumnsForParameterNames) { }

	// RVA: 0x127E330 Offset: 0x127C930 VA: 0x18127E330 Slot: 20
	protected virtual DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x127BF80 Offset: 0x127A580 VA: 0x18127BF80
	private void BuildInformation(DataTable schemaTable) { }

	// RVA: 0x127BDE0 Offset: 0x127A3E0 VA: 0x18127BDE0
	private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127C880 Offset: 0x127AE80 VA: 0x18127C880
	private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127CDF0 Offset: 0x127B3F0 VA: 0x18127CDF0
	private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127D280 Offset: 0x127B880 VA: 0x18127D280
	private int BuildWhereClause(DataTableMapping mappings, DataRow dataRow, StringBuilder builder, DbCommand command, int parameterCount, bool isUpdate) { }

	// RVA: 0x127D8B0 Offset: 0x127BEB0 VA: 0x18127D8B0
	private string CreateParameterForNullTest(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127DCC0 Offset: 0x127C2C0 VA: 0x18127DCC0
	private string CreateParameterForValue(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127DFA0 Offset: 0x127C5A0 VA: 0x18127DFA0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x127E020 Offset: 0x127C620 VA: 0x18127E020
	private string GetBaseParameterName(int index) { }

	// RVA: 0x127E2E0 Offset: 0x127C8E0 VA: 0x18127E2E0
	private string GetOriginalParameterName(int index) { }

	// RVA: 0x127E290 Offset: 0x127C890 VA: 0x18127E290
	private string GetNullParameterName(int index) { }

	// RVA: 0x127E4B0 Offset: 0x127CAB0 VA: 0x18127E4B0
	private DbCommand GetSelectCommand() { }

	// RVA: 0x127E070 Offset: 0x127C670 VA: 0x18127E070
	private object GetColumnValue(DataRow row, string columnName, DataTableMapping mappings, DataRowVersion version) { }

	// RVA: 0x127E120 Offset: 0x127C720 VA: 0x18127E120
	private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version) { }

	// RVA: 0x127E160 Offset: 0x127C760 VA: 0x18127E160
	private DataColumn GetDataColumn(string columnName, DataTableMapping tablemapping, DataRow row) { }

	// RVA: 0x127E1F0 Offset: 0x127C7F0 VA: 0x18127E1F0
	private static DbParameter GetNextParameter(DbCommand command, int pcount) { }

	// RVA: 0x127E5B0 Offset: 0x127CBB0 VA: 0x18127E5B0
	private bool IncludeInInsertValues(DbSchemaRow row) { }

	// RVA: 0x127E730 Offset: 0x127CD30 VA: 0x18127E730
	private bool IncludeInUpdateSet(DbSchemaRow row) { }

	// RVA: 0x127E790 Offset: 0x127CD90 VA: 0x18127E790
	private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate) { }

	// RVA: 0x127E8F0 Offset: 0x127CEF0 VA: 0x18127E8F0
	private bool IncrementWhereCount(DbSchemaRow row) { }

	// RVA: 0x127EA30 Offset: 0x127D030 VA: 0x18127EA30 Slot: 21
	protected virtual DbCommand InitializeCommand(DbCommand command) { }

	// RVA: 0x127EB90 Offset: 0x127D190 VA: 0x18127EB90
	private string QuotedColumn(string column) { }

	// RVA: 0x127EB30 Offset: 0x127D130 VA: 0x18127EB30 Slot: 22
	public virtual string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x127EC30 Offset: 0x127D230 VA: 0x18127EC30 Slot: 23
	public virtual void RefreshSchema() { }

	// RVA: 0x127EF40 Offset: 0x127D540 VA: 0x18127EF40
	private static void RemoveExtraParameters(DbCommand command, int usedParameterCount) { }

	// RVA: 0x127F120 Offset: 0x127D720 VA: 0x18127F120
	protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127EFE0 Offset: 0x127D5E0 VA: 0x18127EFE0
	private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127F560 Offset: 0x127DB60 VA: 0x18127F560 Slot: 24
	public virtual string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause);

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract string GetParameterName(int parameterOrdinal);

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract string GetParameterName(string parameterName);

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract string GetParameterPlaceholder(int parameterOrdinal);

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void SetRowUpdatingHandler(DbDataAdapter adapter);

}

private class DbCommandBuilder.ParameterNames // TypeDefIndex: 4370
{	// Fields
	private string _originalPrefix; // 0x10
	private string _isNullPrefix; // 0x18
	private Regex _parameterNameParser; // 0x20
	private DbCommandBuilder _dbCommandBuilder; // 0x28
	private string[] _baseParameterNames; // 0x30
	private string[] _originalParameterNames; // 0x38
	private string[] _nullParameterNames; // 0x40
	private bool[] _isMutatedName; // 0x48
	private int _count; // 0x50
	private int _genericParameterCount; // 0x54
	private int _adjustedParameterNameMaxLength; // 0x58

	// Methods

	// RVA: 0x1282F80 Offset: 0x1281580 VA: 0x181282F80
	internal void .ctor(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows) { }

	// RVA: 0x1282E00 Offset: 0x1281400 VA: 0x181282E00
	private void SetAndValidateNamePrefixes() { }

	// RVA: 0x1282650 Offset: 0x1280C50 VA: 0x181282650
	private void ApplyProviderSpecificFormat() { }

	// RVA: 0x1282860 Offset: 0x1280E60 VA: 0x181282860
	private void EliminateConflictingNames() { }

	// RVA: 0x1282A00 Offset: 0x1281000 VA: 0x181282A00
	internal void GenerateMissingNames(DbSchemaRow[] schemaRows) { }

	// RVA: 0x1282BD0 Offset: 0x12811D0 VA: 0x181282BD0
	private int GetAdjustedParameterNameMaxLength() { }

	// RVA: 0x1282CA0 Offset: 0x12812A0 VA: 0x181282CA0
	private string GetNextGenericParameterName() { }

	// RVA: 0xE963E0 Offset: 0xE949E0 VA: 0x180E963E0
	internal string GetBaseParameterName(int index) { }

	// RVA: 0x1282DC0 Offset: 0x12813C0 VA: 0x181282DC0
	internal string GetOriginalParameterName(int index) { }

	// RVA: 0x1282D80 Offset: 0x1281380 VA: 0x181282D80
	internal string GetNullParameterName(int index) { }

}

internal sealed class DbSchemaRow // TypeDefIndex: 4371
{	// Fields
	private DbSchemaTable _schemaTable; // 0x10
	private DataRow _dataRow; // 0x18

	// Properties
	internal DataRow DataRow { get; }
	internal string ColumnName { get; }
	internal string BaseColumnName { get; }
	internal string BaseServerName { get; }
	internal string BaseCatalogName { get; }
	internal string BaseSchemaName { get; }
	internal string BaseTableName { get; }
	internal bool IsAutoIncrement { get; }
	internal bool IsUnique { get; }
	internal bool IsRowVersion { get; }
	internal bool IsKey { get; }
	internal bool IsExpression { get; }
	internal bool IsHidden { get; }
	internal bool IsLong { get; }
	internal bool IsReadOnly { get; }
	internal bool AllowDBNull { get; }

	// Methods

	// RVA: 0x1281270 Offset: 0x127F870 VA: 0x181281270
	internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(DbSchemaTable schemaTable, DataRow dataRow) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal DataRow get_DataRow() { }

	// RVA: 0x1281C40 Offset: 0x1280240 VA: 0x181281C40
	internal string get_ColumnName() { }

	// RVA: 0x1281780 Offset: 0x127FD80 VA: 0x181281780
	internal string get_BaseColumnName() { }

	// RVA: 0x12819E0 Offset: 0x127FFE0 VA: 0x1812819E0
	internal string get_BaseServerName() { }

	// RVA: 0x1281650 Offset: 0x127FC50 VA: 0x181281650
	internal string get_BaseCatalogName() { }

	// RVA: 0x12818B0 Offset: 0x127FEB0 VA: 0x1812818B0
	internal string get_BaseSchemaName() { }

	// RVA: 0x1281B10 Offset: 0x1280110 VA: 0x181281B10
	internal string get_BaseTableName() { }

	// RVA: 0x1281D50 Offset: 0x1280350 VA: 0x181281D50
	internal bool get_IsAutoIncrement() { }

	// RVA: 0x1282530 Offset: 0x1280B30 VA: 0x181282530
	internal bool get_IsUnique() { }

	// RVA: 0x1282410 Offset: 0x1280A10 VA: 0x181282410
	internal bool get_IsRowVersion() { }

	// RVA: 0x12820B0 Offset: 0x12806B0 VA: 0x1812820B0
	internal bool get_IsKey() { }

	// RVA: 0x1281E70 Offset: 0x1280470 VA: 0x181281E70
	internal bool get_IsExpression() { }

	// RVA: 0x1281F90 Offset: 0x1280590 VA: 0x181281F90
	internal bool get_IsHidden() { }

	// RVA: 0x12821D0 Offset: 0x12807D0 VA: 0x1812821D0
	internal bool get_IsLong() { }

	// RVA: 0x12822F0 Offset: 0x12808F0 VA: 0x1812822F0
	internal bool get_IsReadOnly() { }

	// RVA: 0x1281530 Offset: 0x127FB30 VA: 0x181281530
	internal bool get_AllowDBNull() { }

}

internal sealed class DbSchemaTable // TypeDefIndex: 4372
{	// Fields
	private static readonly string[] s_DBCOLUMN_NAME; // 0x0
	internal DataTable _dataTable; // 0x10
	private DataColumnCollection _columns; // 0x18
	private DataColumn[] _columnCache; // 0x20
	private bool _returnProviderSpecificTypes; // 0x28

	// Properties
	internal DataColumn ColumnName { get; }
	internal DataColumn BaseServerName { get; }
	internal DataColumn BaseColumnName { get; }
	internal DataColumn BaseTableName { get; }
	internal DataColumn BaseCatalogName { get; }
	internal DataColumn BaseSchemaName { get; }
	internal DataColumn IsAutoIncrement { get; }
	internal DataColumn IsUnique { get; }
	internal DataColumn IsKey { get; }
	internal DataColumn IsRowVersion { get; }
	internal DataColumn AllowDBNull { get; }
	internal DataColumn IsExpression { get; }
	internal DataColumn IsHidden { get; }
	internal DataColumn IsLong { get; }
	internal DataColumn IsReadOnly { get; }

	// Methods

	// RVA: 0x17CB8A0 Offset: 0x17C9EA0 VA: 0x1817CB8A0
	internal void .ctor(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x17CB9E0 Offset: 0x17C9FE0 VA: 0x1817CB9E0
	internal DataColumn get_ColumnName() { }

	// RVA: 0x17CB9C0 Offset: 0x17C9FC0 VA: 0x1817CB9C0
	internal DataColumn get_BaseServerName() { }

	// RVA: 0x17CB9A0 Offset: 0x17C9FA0 VA: 0x1817CB9A0
	internal DataColumn get_BaseColumnName() { }

	// RVA: 0x17CB9D0 Offset: 0x17C9FD0 VA: 0x1817CB9D0
	internal DataColumn get_BaseTableName() { }

	// RVA: 0x17CB990 Offset: 0x17C9F90 VA: 0x1817CB990
	internal DataColumn get_BaseCatalogName() { }

	// RVA: 0x17CB9B0 Offset: 0x17C9FB0 VA: 0x1817CB9B0
	internal DataColumn get_BaseSchemaName() { }

	// RVA: 0x17CB9F0 Offset: 0x17C9FF0 VA: 0x1817CB9F0
	internal DataColumn get_IsAutoIncrement() { }

	// RVA: 0x17CBA60 Offset: 0x17CA060 VA: 0x1817CBA60
	internal DataColumn get_IsUnique() { }

	// RVA: 0x17CBA20 Offset: 0x17CA020 VA: 0x1817CBA20
	internal DataColumn get_IsKey() { }

	// RVA: 0x17CBA50 Offset: 0x17CA050 VA: 0x1817CBA50
	internal DataColumn get_IsRowVersion() { }

	// RVA: 0x17CB980 Offset: 0x17C9F80 VA: 0x1817CB980
	internal DataColumn get_AllowDBNull() { }

	// RVA: 0x17CBA00 Offset: 0x17CA000 VA: 0x1817CBA00
	internal DataColumn get_IsExpression() { }

	// RVA: 0x17CBA10 Offset: 0x17CA010 VA: 0x1817CBA10
	internal DataColumn get_IsHidden() { }

	// RVA: 0x17CBA30 Offset: 0x17CA030 VA: 0x1817CBA30
	internal DataColumn get_IsLong() { }

	// RVA: 0x17CBA40 Offset: 0x17CA040 VA: 0x1817CBA40
	internal DataColumn get_IsReadOnly() { }

	// RVA: 0x17CAD50 Offset: 0x17C9350 VA: 0x1817CAD50
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column) { }

	// RVA: 0x17CAD60 Offset: 0x17C9360 VA: 0x1817CAD60
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2) { }

	// RVA: 0x17CAF50 Offset: 0x17C9550 VA: 0x1817CAF50
	private static void .cctor() { }

}

private enum DbSchemaTable.ColumnEnum // TypeDefIndex: 4373
{	// Fields
	public int value__; // 0x0
	public const DbSchemaTable.ColumnEnum ColumnName = 0;
	public const DbSchemaTable.ColumnEnum ColumnOrdinal = 1;
	public const DbSchemaTable.ColumnEnum ColumnSize = 2;
	public const DbSchemaTable.ColumnEnum BaseServerName = 3;
	public const DbSchemaTable.ColumnEnum BaseCatalogName = 4;
	public const DbSchemaTable.ColumnEnum BaseColumnName = 5;
	public const DbSchemaTable.ColumnEnum BaseSchemaName = 6;
	public const DbSchemaTable.ColumnEnum BaseTableName = 7;
	public const DbSchemaTable.ColumnEnum IsAutoIncrement = 8;
	public const DbSchemaTable.ColumnEnum IsUnique = 9;
	public const DbSchemaTable.ColumnEnum IsKey = 10;
	public const DbSchemaTable.ColumnEnum IsRowVersion = 11;
	public const DbSchemaTable.ColumnEnum DataType = 12;
	public const DbSchemaTable.ColumnEnum ProviderSpecificDataType = 13;
	public const DbSchemaTable.ColumnEnum AllowDBNull = 14;
	public const DbSchemaTable.ColumnEnum ProviderType = 15;
	public const DbSchemaTable.ColumnEnum IsExpression = 16;
	public const DbSchemaTable.ColumnEnum IsHidden = 17;
	public const DbSchemaTable.ColumnEnum IsLong = 18;
	public const DbSchemaTable.ColumnEnum IsReadOnly = 19;
	public const DbSchemaTable.ColumnEnum SchemaMappingUnsortedIndex = 20;

}

public class DataAdapter : Component // TypeDefIndex: 4374
{	// Fields
	private static readonly object s_eventFillError; // 0x0
	private MissingMappingAction _missingMappingAction; // 0x28

	// Properties
	[DefaultValueAttribute] // RVA: 0xA9E40 Offset: 0xA9240 VA: 0x1800A9E40
	public MissingMappingAction MissingMappingAction { get; }

	// Methods

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 12
	public MissingMappingAction get_MissingMappingAction() { }

	// RVA: 0x1275160 Offset: 0x1273760 VA: 0x181275160
	private static void .cctor() { }

}

public sealed class DataColumnMapping : MarshalByRefObject // TypeDefIndex: 4375
{	// Fields
	private string _dataSetColumnName; // 0x18
	private string _sourceColumnName; // 0x20

	// Properties
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string DataSetColumn { get; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public string SourceColumn { get; }

	// Methods

	// RVA: 0x1275C10 Offset: 0x1274210 VA: 0x181275C10 Slot: 6
	public string get_DataSetColumn() { }

	// RVA: 0x1275C60 Offset: 0x1274260 VA: 0x181275C60 Slot: 7
	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1275B40 Offset: 0x1274140 VA: 0x181275B40
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1275820 Offset: 0x1273E20 VA: 0x181275820
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	// RVA: 0x12756E0 Offset: 0x1273CE0 VA: 0x1812756E0
	internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

}

public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
{
// Namespace: System.Data.Common
[DefaultMemberAttribute] // RVA: 0x70CB0 Offset: 0x700B0 VA: 0x180070CB0
public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
	// Fields
	private List<DataColumnMapping> _items; // 0x18

	// Properties
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public int Count { get; }

	// Methods

	// RVA: 0x12756A0 Offset: 0x1273CA0 VA: 0x1812756A0 Slot: 6
	public int get_Count() { }

	// RVA: 0x1275520 Offset: 0x1273B20 VA: 0x181275520 Slot: 7
	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x12751C0 Offset: 0x12737C0 VA: 0x1812751C0
	public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

internal sealed class DataRecordInternal : DbDataRecord, ICustomTypeDescriptor // TypeDefIndex: 4378
{	// Fields
	private SchemaInfo[] _schemaInfo; // 0x10
	private object[] _values; // 0x18
	private PropertyDescriptorCollection _propertyDescriptors; // 0x20
	private FieldNameLookup _fieldNameLookup; // 0x28

	// Properties
	public override int FieldCount { get; }
	public override object Item { get; }

	// Methods

	// RVA: 0x10E55A0 Offset: 0x10E3BA0 VA: 0x1810E55A0
	internal void .ctor(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup) { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30 Slot: 15
	public override int get_FieldCount() { }

	// RVA: 0x1275DB0 Offset: 0x12743B0 VA: 0x181275DB0 Slot: 21
	public override int GetValues(object[] values) { }

	// RVA: 0x1275D30 Offset: 0x1274330 VA: 0x181275D30 Slot: 19
	public override string GetName(int i) { }

	// RVA: 0x1275D70 Offset: 0x1274370 VA: 0x181275D70 Slot: 20
	public override object GetValue(int i) { }

	// RVA: 0x1275CB0 Offset: 0x12742B0 VA: 0x181275CB0 Slot: 17
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1275CF0 Offset: 0x12742F0 VA: 0x181275CF0 Slot: 18
	public override Type GetFieldType(int i) { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 16
	public override object get_Item(int i) { }

	// RVA: 0x1275F10 Offset: 0x1274510 VA: 0x181275F10 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1275FD0 Offset: 0x12745D0 VA: 0x181275FD0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1275F60 Offset: 0x1274560 VA: 0x181275F60 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

internal abstract class DataStorage // TypeDefIndex: 4381
{	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1278BA0 Offset: 0x12771A0 VA: 0x181278BA0
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1278B70 Offset: 0x1277170 VA: 0x181278B70
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x1278C50 Offset: 0x1277250 VA: 0x181278C50
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1278E00 Offset: 0x1277400 VA: 0x181278E00
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1278E20 Offset: 0x1277420 VA: 0x181278E20
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x12760D0 Offset: 0x12746D0 VA: 0x1812760D0 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1276010 Offset: 0x1274610 VA: 0x181276010
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x12761A0 Offset: 0x12747A0 VA: 0x1812761A0
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x12762B0 Offset: 0x12748B0 VA: 0x1812762B0
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1276E80 Offset: 0x1275480 VA: 0x181276E80
	protected object GetBits(int recordNo) { }

	// RVA: 0x12770B0 Offset: 0x12756B0 VA: 0x1812770B0 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1277250 Offset: 0x1275850 VA: 0x181277250
	protected bool HasValue(int recordNo) { }

	// RVA: 0x12775F0 Offset: 0x1275BF0 VA: 0x1812775F0 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x12779B0 Offset: 0x1275FB0 VA: 0x1812779B0
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1277920 Offset: 0x1275F20 VA: 0x181277920 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1276260 Offset: 0x1274860 VA: 0x181276260 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1276220 Offset: 0x1274820 VA: 0x181276220 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1276320 Offset: 0x1274920 VA: 0x181276320
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x1276F50 Offset: 0x1275550 VA: 0x181276F50
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x12770C0 Offset: 0x12756C0 VA: 0x1812770C0
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x12778A0 Offset: 0x1275EA0 VA: 0x1812778A0
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1277910 Offset: 0x1275F10 VA: 0x181277910
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1277890 Offset: 0x1275E90 VA: 0x181277890
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1277750 Offset: 0x1275D50 VA: 0x181277750
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1276DF0 Offset: 0x12753F0 VA: 0x181276DF0
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1277340 Offset: 0x1275940 VA: 0x181277340
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1277480 Offset: 0x1275A80 VA: 0x181277480
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1277280 Offset: 0x1275880 VA: 0x181277280
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1277610 Offset: 0x1275C10 VA: 0x181277610
	public static bool IsObjectNull(object value) { }

	// RVA: 0x12776F0 Offset: 0x1275CF0 VA: 0x1812776F0
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1276EC0 Offset: 0x12754C0 VA: 0x181276EC0
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x1276300 Offset: 0x1274900 VA: 0x181276300
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12779D0 Offset: 0x1275FD0 VA: 0x1812779D0
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1277150 Offset: 0x1275750 VA: 0x181277150
	internal static Type GetType(string value) { }

	// RVA: 0x1276EE0 Offset: 0x12754E0 VA: 0x181276EE0
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x12779F0 Offset: 0x1275FF0 VA: 0x1812779F0
	private static void .cctor() { }

}

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4382
{	// Fields
	private DataColumnMappingCollection _columnMappings; // 0x18

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1278E40 Offset: 0x1277440 VA: 0x181278E40
	public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

public abstract class DbCommand : Component, IDbCommand, IDisposable // TypeDefIndex: 4386
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xA3D20 Offset: 0xA3120 VA: 0x1800A3D20
	[DefaultValueAttribute] // RVA: 0xA3D20 Offset: 0xA3120 VA: 0x1800A3D20
	public abstract string CommandText { get; set; }
	public abstract int CommandTimeout { get; set; }
	[DefaultValueAttribute] // RVA: 0xAA630 Offset: 0xA9A30 VA: 0x1800AA630
	[RefreshPropertiesAttribute] // RVA: 0xAA630 Offset: 0xA9A30 VA: 0x1800AA630
	public abstract CommandType CommandType { set; }
	[DefaultValueAttribute] // RVA: 0xAA8E0 Offset: 0xA9CE0 VA: 0x1800AA8E0
	[BrowsableAttribute] // RVA: 0xAA8E0 Offset: 0xA9CE0 VA: 0x1800AA8E0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAA8E0 Offset: 0xA9CE0 VA: 0x1800AA8E0
	public DbConnection Connection { get; set; }
	protected abstract DbConnection DbConnection { get; set; }
	protected abstract DbParameterCollection DbParameterCollection { get; }
	protected abstract DbTransaction DbTransaction { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAAA00 Offset: 0xA9E00 VA: 0x1800AAA00
	[DefaultValueAttribute] // RVA: 0xAAA00 Offset: 0xA9E00 VA: 0x1800AAA00
	[DesignOnlyAttribute] // RVA: 0xAAA00 Offset: 0xA9E00 VA: 0x1800AAA00
	[BrowsableAttribute] // RVA: 0xAAA00 Offset: 0xA9E00 VA: 0x1800AAA00
	public abstract bool DesignTimeVisible { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public DbParameterCollection Parameters { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	[BrowsableAttribute] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	[DefaultValueAttribute] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	public DbTransaction Transaction { get; set; }
	[DefaultValueAttribute] // RVA: 0xAAF70 Offset: 0xAA370 VA: 0x1800AAF70
	public abstract UpdateRowSource UpdatedRowSource { get; set; }

	// Methods

	// RVA: 0x127F9B0 Offset: 0x127DFB0 VA: 0x18127F9B0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_CommandText();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_CommandText(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_CommandTimeout();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_CommandTimeout(int value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_CommandType(CommandType value);

	// RVA: 0x127FA10 Offset: 0x127E010 VA: 0x18127FA10
	public DbConnection get_Connection() { }

	// RVA: 0x1276EC0 Offset: 0x12754C0 VA: 0x181276EC0
	public void set_Connection(DbConnection value) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbConnection get_DbConnection();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void set_DbConnection(DbConnection value);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract DbParameterCollection get_DbParameterCollection();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract DbTransaction get_DbTransaction();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void set_DbTransaction(DbTransaction value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_DesignTimeVisible();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_DesignTimeVisible(bool value);

	// RVA: 0x11D30F0 Offset: 0x11D16F0 VA: 0x1811D30F0
	public DbParameterCollection get_Parameters() { }

	// RVA: 0x127FA30 Offset: 0x127E030 VA: 0x18127FA30
	public DbTransaction get_Transaction() { }

	// RVA: 0xE2DEF0 Offset: 0xE2C4F0 VA: 0x180E2DEF0
	public void set_Transaction(DbTransaction value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract UpdateRowSource get_UpdatedRowSource();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_UpdatedRowSource(UpdateRowSource value);

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080
	public DbParameter CreateParameter() { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract DbParameter CreateDbParameter();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int ExecuteNonQuery();

	// RVA: 0x127F990 Offset: 0x127DF90 VA: 0x18127F990
	public DbDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Prepare();

}

public abstract class DbConnection : Component, IDisposable // TypeDefIndex: 4387
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xAB140 Offset: 0xAA540 VA: 0x1800AB140
	[DefaultValueAttribute] // RVA: 0xAB140 Offset: 0xAA540 VA: 0x1800AB140
	[RecommendedAsConfigurableAttribute] // RVA: 0xAB140 Offset: 0xAA540 VA: 0x1800AB140
	[SettingsBindableAttribute] // RVA: 0xAB140 Offset: 0xAA540 VA: 0x1800AB140
	public abstract string ConnectionString { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public abstract ConnectionState State { get; }

	// Methods

	// RVA: 0x127FB70 Offset: 0x127E170 VA: 0x18127FB70
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_ConnectionString();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ConnectionString(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ConnectionState get_State();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Close();

	// RVA: 0x127FA10 Offset: 0x127E010 VA: 0x18127FA10
	public DbCommand CreateCommand() { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbCommand CreateDbCommand();

	// RVA: 0x127FA50 Offset: 0x127E050 VA: 0x18127FA50 Slot: 18
	public virtual void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x127FB10 Offset: 0x127E110 VA: 0x18127FB10 Slot: 19
	public virtual DataTable GetSchema(string collectionName) { }

	// RVA: 0x127FAB0 Offset: 0x127E0B0 VA: 0x18127FAB0 Slot: 20
	public virtual DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Open();

}

public abstract class DbDataAdapter : DataAdapter // TypeDefIndex: 4388
{	// Fields
	internal static readonly object s_parameterValueNonNullValue; // 0x0
	internal static readonly object s_parameterValueNullValue; // 0x8

	// Properties
	private IDbDataAdapter _IDbDataAdapter { get; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DbCommand DeleteCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DbCommand InsertCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public DbCommand SelectCommand { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public DbCommand UpdateCommand { get; set; }

	// Methods

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	private IDbDataAdapter get__IDbDataAdapter() { }

	// RVA: 0x127FC60 Offset: 0x127E260 VA: 0x18127FC60
	public DbCommand get_DeleteCommand() { }

	// RVA: 0x127FEE0 Offset: 0x127E4E0 VA: 0x18127FEE0
	public void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127FD00 Offset: 0x127E300 VA: 0x18127FD00
	public DbCommand get_InsertCommand() { }

	// RVA: 0x127FF40 Offset: 0x127E540 VA: 0x18127FF40
	public void set_InsertCommand(DbCommand value) { }

	// RVA: 0x127FDA0 Offset: 0x127E3A0 VA: 0x18127FDA0
	public DbCommand get_SelectCommand() { }

	// RVA: 0x127FE40 Offset: 0x127E440 VA: 0x18127FE40
	public DbCommand get_UpdateCommand() { }

	// RVA: 0x127FFA0 Offset: 0x127E5A0 VA: 0x18127FFA0
	public void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x127FBD0 Offset: 0x127E1D0 VA: 0x18127FBD0
	private static void .cctor() { }

}

public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable // TypeDefIndex: 4389
{	// Properties
	public abstract int FieldCount { get; }
	public abstract int RecordsAffected { get; }
	public virtual int VisibleFieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int get_RecordsAffected();

	// RVA: 0x127FA10 Offset: 0x127E010 VA: 0x18127FA10 Slot: 19
	public virtual int get_VisibleFieldCount() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Item(int ordinal);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void Close() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x1280000 Offset: 0x127E600 VA: 0x181280000 Slot: 9
	public void Dispose() { }

	// RVA: 0x1280020 Offset: 0x127E620 VA: 0x181280020 Slot: 22
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetDataTypeName(int ordinal);

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: -1 Offset: -1 Slot: 24
	public abstract IEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Type GetFieldType(int ordinal);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string GetName(int ordinal);

	// RVA: 0x1280040 Offset: 0x127E640 VA: 0x181280040 Slot: 27
	public virtual DataTable GetSchemaTable() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool GetBoolean(int ordinal);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetInt32(int ordinal);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract long GetInt64(int ordinal);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string GetString(int ordinal);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract object GetValue(int ordinal);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetValues(object[] values);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool IsDBNull(int ordinal);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool NextResult();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool Read();

}

public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord // TypeDefIndex: 4390
{	// Properties
	public abstract int FieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract object get_Item(int i);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract string GetDataTypeName(int i);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type GetFieldType(int i);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int GetValues(object[] values);

	// RVA: 0x1280090 Offset: 0x127E690 VA: 0x181280090 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12800E0 Offset: 0x127E6E0 VA: 0x1812800E0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1280120 Offset: 0x127E720 VA: 0x181280120 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

public class DbEnumerator : IEnumerator // TypeDefIndex: 4391
{	// Fields
	internal IDataReader _reader; // 0x10
	internal DbDataRecord _current; // 0x18
	internal SchemaInfo[] _schemaInfo; // 0x20
	internal PropertyDescriptorCollection _descriptors; // 0x28
	private FieldNameLookup _fieldNameLookup; // 0x30
	private bool _closeReader; // 0x38

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1280970 Offset: 0x127EF70 VA: 0x181280970
	public void .ctor(IDataReader reader, bool closeReader) { }

	// RVA: 0x1280970 Offset: 0x127EF70 VA: 0x181280970
	public void .ctor(DbDataReader reader, bool closeReader) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object get_Current() { }

	// RVA: 0x1280730 Offset: 0x127ED30 VA: 0x181280730 Slot: 4
	public bool MoveNext() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x1280910 Offset: 0x127EF10 VA: 0x181280910 Slot: 6
	public void Reset() { }

	// RVA: 0x1280170 Offset: 0x127E770 VA: 0x181280170
	private void BuildSchemaInfo() { }

}

private sealed class DbEnumerator.DbColumnDescriptor : PropertyDescriptor // TypeDefIndex: 4392
{	// Fields
	private int _ordinal; // 0x88
	private Type _type; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x127B770 Offset: 0x1279D70 VA: 0x18127B770
	internal void .ctor(int ordinal, string name, Type type) { }

	// RVA: 0x127B7C0 Offset: 0x1279DC0 VA: 0x18127B7C0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x127B5F0 Offset: 0x1279BF0 VA: 0x18127B5F0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x127B710 Offset: 0x1279D10 VA: 0x18127B710 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public abstract class DbException : ExternalException // TypeDefIndex: 4393
{	// Methods

	// RVA: 0x1280A30 Offset: 0x127F030 VA: 0x181280A30
	protected void .ctor() { }

	// RVA: 0x1280A20 Offset: 0x127F020 VA: 0x181280A20
	protected void .ctor(string message) { }

	// RVA: 0x1280A40 Offset: 0x127F040 VA: 0x181280A40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public static class DbMetaDataCollectionNames // TypeDefIndex: 4394
{	// Fields
	public static readonly string MetaDataCollections; // 0x0
	public static readonly string DataSourceInformation; // 0x8
	public static readonly string DataTypes; // 0x10
	public static readonly string Restrictions; // 0x18
	public static readonly string ReservedWords; // 0x20

	// Methods

	// RVA: 0x1280AC0 Offset: 0x127F0C0 VA: 0x181280AC0
	private static void .cctor() { }

}

public static class DbMetaDataColumnNames // TypeDefIndex: 4395
{	// Fields
	public static readonly string CollectionName; // 0x0
	public static readonly string ColumnSize; // 0x8
	public static readonly string CompositeIdentifierSeparatorPattern; // 0x10
	public static readonly string CreateFormat; // 0x18
	public static readonly string CreateParameters; // 0x20
	public static readonly string DataSourceProductName; // 0x28
	public static readonly string DataSourceProductVersion; // 0x30
	public static readonly string DataType; // 0x38
	public static readonly string DataSourceProductVersionNormalized; // 0x40
	public static readonly string GroupByBehavior; // 0x48
	public static readonly string IdentifierCase; // 0x50
	public static readonly string IdentifierPattern; // 0x58
	public static readonly string IsAutoIncrementable; // 0x60
	public static readonly string IsBestMatch; // 0x68
	public static readonly string IsCaseSensitive; // 0x70
	public static readonly string IsConcurrencyType; // 0x78
	public static readonly string IsFixedLength; // 0x80
	public static readonly string IsFixedPrecisionScale; // 0x88
	public static readonly string IsLiteralSupported; // 0x90
	public static readonly string IsLong; // 0x98
	public static readonly string IsNullable; // 0xA0
	public static readonly string IsSearchable; // 0xA8
	public static readonly string IsSearchableWithLike; // 0xB0
	public static readonly string IsUnsigned; // 0xB8
	public static readonly string LiteralPrefix; // 0xC0
	public static readonly string LiteralSuffix; // 0xC8
	public static readonly string MaximumScale; // 0xD0
	public static readonly string MinimumScale; // 0xD8
	public static readonly string NumberOfIdentifierParts; // 0xE0
	public static readonly string NumberOfRestrictions; // 0xE8
	public static readonly string OrderByColumnsInSelect; // 0xF0
	public static readonly string ParameterMarkerFormat; // 0xF8
	public static readonly string ParameterMarkerPattern; // 0x100
	public static readonly string ParameterNameMaxLength; // 0x108
	public static readonly string ParameterNamePattern; // 0x110
	public static readonly string ProviderDbType; // 0x118
	public static readonly string QuotedIdentifierCase; // 0x120
	public static readonly string QuotedIdentifierPattern; // 0x128
	public static readonly string ReservedWord; // 0x130
	public static readonly string StatementSeparatorPattern; // 0x138
	public static readonly string StringLiteralPattern; // 0x140
	public static readonly string SupportedJoinOperators; // 0x148
	public static readonly string TypeName; // 0x150

	// Methods

	// RVA: 0x1280B90 Offset: 0x127F190 VA: 0x181280B90
	private static void .cctor() { }

}

public abstract class DbParameter : MarshalByRefObject // TypeDefIndex: 4396
{	// Properties
	[BrowsableAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	[RefreshPropertiesAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	public abstract DbType DbType { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xABF20 Offset: 0xAB320 VA: 0x1800ABF20
	[DefaultValueAttribute] // RVA: 0xABF20 Offset: 0xAB320 VA: 0x1800ABF20
	public abstract ParameterDirection Direction { get; set; }
	[DesignOnlyAttribute] // RVA: 0xAC030 Offset: 0xAB430 VA: 0x1800AC030
	[BrowsableAttribute] // RVA: 0xAC030 Offset: 0xAB430 VA: 0x1800AC030
	[EditorBrowsableAttribute] // RVA: 0xAC030 Offset: 0xAB430 VA: 0x1800AC030
	public abstract bool IsNullable { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public abstract string ParameterName { get; set; }
	public abstract int Size { set; }
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public abstract string SourceColumn { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAC2C0 Offset: 0xAB6C0 VA: 0x1800AC2C0
	[DefaultValueAttribute] // RVA: 0xAC2C0 Offset: 0xAB6C0 VA: 0x1800AC2C0
	[RefreshPropertiesAttribute] // RVA: 0xAC2C0 Offset: 0xAB6C0 VA: 0x1800AC2C0
	public abstract bool SourceColumnNullMapping { set; }
	[DefaultValueAttribute] // RVA: 0xAC440 Offset: 0xAB840 VA: 0x1800AC440
	public virtual DataRowVersion SourceVersion { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xAC570 Offset: 0xAB970 VA: 0x1800AC570
	[DefaultValueAttribute] // RVA: 0xAC570 Offset: 0xAB970 VA: 0x1800AC570
	public abstract object Value { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract DbType get_DbType();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_DbType(DbType value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract ParameterDirection get_Direction();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_Direction(ParameterDirection value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsNullable();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_IsNullable(bool value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_ParameterName();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ParameterName(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_Size(int value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string get_SourceColumn();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_SourceColumn(string value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_SourceColumnNullMapping(bool value);

	// RVA: 0x1281260 Offset: 0x127F860 VA: 0x181281260 Slot: 18
	public virtual DataRowVersion get_SourceVersion() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	public virtual void set_SourceVersion(DataRowVersion value) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_Value(object value);

}

public abstract class DbParameterCollection : MarshalByRefObject, IList, ICollection, IEnumerable // TypeDefIndex: 4397
{	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public abstract int Count { get; }
	[EditorBrowsableAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	[BrowsableAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	public virtual bool IsFixedSize { get; }
	[BrowsableAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	[EditorBrowsableAttribute] // RVA: 0xABDB0 Offset: 0xAB1B0 VA: 0x1800ABDB0
	public virtual bool IsReadOnly { get; }
	[EditorBrowsableAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	[BrowsableAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	public abstract object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	public DbParameter Item { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_Count();

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 23
	public virtual bool get_IsReadOnly() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract object get_SyncRoot();

	// RVA: 0x1281190 Offset: 0x127F790 VA: 0x181281190 Slot: 6
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12811B0 Offset: 0x127F7B0 VA: 0x1812811B0 Slot: 7
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1281190 Offset: 0x127F790 VA: 0x181281190
	public DbParameter get_Item(int index) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void Clear();

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: -1 Offset: -1 Slot: 29
	public abstract IEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract DbParameter GetParameter(int index);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int IndexOf(string parameterName);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void RemoveAt(int index);

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void SetParameter(int index, DbParameter value);

}

public abstract class DbProviderFactory // TypeDefIndex: 4398
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public sealed class DbProviderSpecificTypePropertyAttribute : Attribute // TypeDefIndex: 4399
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsProviderSpecificTypeProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFDD8E0 Offset: 0xFDBEE0 VA: 0x180FDD8E0
	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4400
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Commit();

	// RVA: 0x161BFE0 Offset: 0x161A5E0 VA: 0x18161BFE0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Rollback();

}

public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
{
// Namespace: System.Runtime.Serialization
[AttributeUsageAttribute] // RVA: 0xC9B60 Offset: 0xC8F60 VA: 0x1800C9B60
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReference() { }

}

public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 5706
{	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Order() { }

	// RVA: 0x79C660 Offset: 0x79AC60 VA: 0x18079C660
	public bool get_IsRequired() { }

	// RVA: 0x79C650 Offset: 0x79AC50 VA: 0x18079C650
	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6181
{	// Methods

	// RVA: 0x14AAD90 Offset: 0x14A9390 VA: 0x1814AAD90
	public static void Insert(string parent, object contents, Action<bool> onFinished) { }

	// RVA: 0x14AAAE0 Offset: 0x14A90E0 VA: 0x1814AAAE0
	public static void Insert(string parent, object contents, Action<bool, string> onFinished) { }

	// RVA: 0x14AAE60 Offset: 0x14A9460 VA: 0x1814AAE60
	public static void Remove(string parent, string id, Action<bool> onFinished) { }

	// RVA: -1 Offset: -1
	public static Result<T> Query<T>(string parent, int limit, Action<Result<T>> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D4F0 Offset: 0x125BAF0 VA: 0x18125D4F0
	|-Database.Query<object>
	*/

	// RVA: 0x14AA930 Offset: 0x14A8F30 VA: 0x1814AA930
	public static void Count(string parent, Action<int> onResult) { }

}

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6182
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBE30 Offset: 0x14BA430 VA: 0x1814BBE30
	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6183
{	// Fields
	public Action<bool, string> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBF20 Offset: 0x14BA520 VA: 0x1814BBF20
	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6184
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC0A0 Offset: 0x14BA6A0 VA: 0x1814BC0A0
	internal void <Remove>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass3_0<T> // TypeDefIndex: 6185
{	// Fields
	public Result<T> result; // 0x0
	public Action<Result<T>> onFinished; // 0x0
	public Action <>9__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-Database.<>c__DisplayClass3_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__0(object s, DownloadStringCompletedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18959B0 Offset: 0x1893FB0 VA: 0x1818959B0
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895D40 Offset: 0x1894340 VA: 0x181895D40
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__1
	*/

}

private sealed class Database.<>c__3<T> // TypeDefIndex: 6186
{	// Fields
	public static readonly Database.<>c__3<T> <>9; // 0x0
	public static Func<QueryResponse, Result.Entry<T>> <>9__3_2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66290 Offset: 0xD64890 VA: 0x180D66290
	|-Database.<>c__3<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-Database.<>c__3<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Result.Entry<T> <Query>b__3_2(QueryResponse x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895800 Offset: 0x1893E00 VA: 0x181895800
	|-Database.<>c__3<object>.<Query>b__3_2
	*/

}

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6187
{	// Fields
	public Action<int> onResult; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC190 Offset: 0x14BA790 VA: 0x1814BC190
	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6188
{	// Fields
	public int count; // 0x10
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC320 Offset: 0x14BA920 VA: 0x1814BC320
	internal void <Count>b__1() { }

}

public class Database // TypeDefIndex: 7356
{
// Namespace: Facepunch.Sqlite
public class Database // TypeDefIndex: 7356
	// Fields
	private IntPtr _connection; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsConnectionOpen>k__BackingField; // 0x18

	// Properties
	private bool IsConnectionOpen { get; set; }
	public int AffectedRows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	private void set_IsConnectionOpen(bool value) { }

	// RVA: 0x231E360 Offset: 0x231C960 VA: 0x18231E360
	public void Open(string path, bool fastMode = False) { }

	// RVA: 0x231EAB0 Offset: 0x231D0B0 VA: 0x18231EAB0
	public bool TableExists(string name) { }

	// RVA: 0x231E2F0 Offset: 0x231C8F0 VA: 0x18231E2F0
	public bool IndexExists(string tableName, string indexName) { }

	// RVA: 0x231DB20 Offset: 0x231C120 VA: 0x18231DB20
	public bool ColumnExists(string tableName, string columnName) { }

	// RVA: 0x231DA50 Offset: 0x231C050 VA: 0x18231DA50
	public void Close() { }

	// RVA: 0x231EB10 Offset: 0x231D110 VA: 0x18231EB10
	public int get_AffectedRows() { }

	// RVA: 0x231DE20 Offset: 0x231C420 VA: 0x18231DE20
	public void Execute(string query) { }

	// RVA: -1 Offset: -1
	public void Execute<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571870 Offset: 0x156FE70 VA: 0x181571870
	|-Database.Execute<int>
	|
	|-RVA: 0x1571C10 Offset: 0x1570210 VA: 0x181571C10
	|-Database.Execute<object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15716E0 Offset: 0x156FCE0 VA: 0x1815716E0
	|-Database.Execute<int, int>
	|
	|-RVA: 0x1571B70 Offset: 0x1570170 VA: 0x181571B70
	|-Database.Execute<object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3>(string query, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571620 Offset: 0x156FC20 VA: 0x181571620
	|-Database.Execute<int, int, int>
	|
	|-RVA: 0x1571AB0 Offset: 0x15700B0 VA: 0x181571AB0
	|-Database.Execute<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571540 Offset: 0x156FB40 VA: 0x181571540
	|-Database.Execute<int, int, int, int>
	|
	|-RVA: 0x15719D0 Offset: 0x156FFD0 VA: 0x1815719D0
	|-Database.Execute<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4, T5>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571780 Offset: 0x156FD80 VA: 0x181571780
	|-Database.Execute<int, byte[], int, int, int>
	|-Database.Execute<int, object, int, int, int>
	|
	|-RVA: 0x15718E0 Offset: 0x156FEE0 VA: 0x1815718E0
	|-Database.Execute<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	protected static void Bind<T>(IntPtr stmHandle, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1570930 Offset: 0x156EF30 VA: 0x181570930
	|-Database.Bind<int>
	|
	|-RVA: 0x1570F30 Offset: 0x156F530 VA: 0x181570F30
	|-Database.Bind<object>
	*/

	// RVA: -1 Offset: -1
	protected static T GetColumnValue<T>(IntPtr stmHandle, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CBCF0 Offset: 0x5CA2F0 VA: 0x1805CBCF0
	|-Database.GetColumnValue<int>
	|
	|-RVA: 0x5CC460 Offset: 0x5CAA60 VA: 0x1805CC460
	|-Database.GetColumnValue<long>
	|
	|-RVA: 0x5CCBD0 Offset: 0x5CB1D0 VA: 0x1805CCBD0
	|-Database.GetColumnValue<object>
	*/

	// RVA: 0x231E810 Offset: 0x231CE10 VA: 0x18231E810
	public int QueryInt(string query) { }

	// RVA: -1 Offset: -1
	public int QueryInt<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179AE0 Offset: 0x11780E0 VA: 0x181179AE0
	|-Database.QueryInt<object>
	|-Database.QueryInt<string>
	*/

	// RVA: -1 Offset: -1
	public int QueryInt<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179A10 Offset: 0x1178010 VA: 0x181179A10
	|-Database.QueryInt<object, object>
	|-Database.QueryInt<string, string>
	*/

	// RVA: 0x231E870 Offset: 0x231CE70 VA: 0x18231E870
	public long QueryLong(string query) { }

	// RVA: -1 Offset: -1
	public string QueryString<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3660 Offset: 0xED1C60 VA: 0x180ED3660
	|-Database.QueryString<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1536E40 Offset: 0x1535440 VA: 0x181536E40
	|-Database.QueryBlob<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF270 Offset: 0xBED870 VA: 0x180BEF270
	|-Database.QueryBlob<int, int, int, int>
	|
	|-RVA: 0xBEF370 Offset: 0xBED970 VA: 0x180BEF370
	|-Database.QueryBlob<object, object, object, object>
	*/

	// RVA: 0x231DA00 Offset: 0x231C000 VA: 0x18231DA00
	public void BeginTransaction() { }

	// RVA: 0x231DB90 Offset: 0x231C190 VA: 0x18231DB90
	public void Commit() { }

	// RVA: 0x231EA60 Offset: 0x231D060 VA: 0x18231EA60
	public void Rollback() { }

	// RVA: 0x231DBE0 Offset: 0x231C1E0 VA: 0x18231DBE0
	protected void ExecuteQuery(IntPtr stmHandle, bool finalize = True) { }

	// RVA: -1 Offset: -1
	protected T ExecuteAndReadQueryResult<T>(IntPtr stmHandle, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CBB90 Offset: 0x5CA190 VA: 0x1805CBB90
	|-Database.ExecuteAndReadQueryResult<byte[]>
	|-Database.ExecuteAndReadQueryResult<object>
	|-Database.ExecuteAndReadQueryResult<string>
	|
	|-RVA: 0x5CB8E0 Offset: 0x5C9EE0 VA: 0x1805CB8E0
	|-Database.ExecuteAndReadQueryResult<int>
	|
	|-RVA: 0x5CBA30 Offset: 0x5CA030 VA: 0x1805CBA30
	|-Database.ExecuteAndReadQueryResult<long>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x9A710 Offset: 0x99B10 VA: 0x18009A710
	// RVA: -1 Offset: -1
	protected IEnumerable<T> ExecuteAndReadQueryResults<T>(IntPtr stmHandle, Func<IntPtr, T> rowReader, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFF40 Offset: 0xCFE540 VA: 0x180CFFF40
	|-Database.ExecuteAndReadQueryResults<object>
	*/

	// RVA: 0x231E5E0 Offset: 0x231CBE0 VA: 0x18231E5E0
	protected IntPtr Prepare(string query) { }

	// RVA: 0x231DE50 Offset: 0x231C450 VA: 0x18231DE50
	private void FinalizeOrReset(IntPtr stmHandle, bool finalize = True) { }

	// RVA: 0x231E160 Offset: 0x231C760 VA: 0x18231E160
	protected void Finalize(IntPtr stmHandle) { }

	// RVA: 0x231E8D0 Offset: 0x231CED0 VA: 0x18231E8D0
	protected void Reset(IntPtr stmHandle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Exception <GetColumnValue>g__TypeError|19_0<T>(ref Database.<>c__DisplayClass19_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1A600 Offset: 0x1B18C00 VA: 0x181B1A600
	|-Database.<GetColumnValue>g__TypeError|19_0<int>
	|
	|-RVA: 0x1B1A700 Offset: 0x1B18D00 VA: 0x181B1A700
	|-Database.<GetColumnValue>g__TypeError|19_0<long>
	|
	|-RVA: 0x1B1A800 Offset: 0x1B18E00 VA: 0x181B1A800
	|-Database.<GetColumnValue>g__TypeError|19_0<object>
	*/

}

private struct Database.<>c__DisplayClass19_0<T> // TypeDefIndex: 7357
{	// Fields
	public int type; // 0x0

}

private sealed class Database.<ExecuteAndReadQueryResults>d__32<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 7358
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IntPtr, T> rowReader; // 0x0
	public Func<IntPtr, T> <>3__rowReader; // 0x0
	private IntPtr stmHandle; // 0x0
	public IntPtr <>3__stmHandle; // 0x0
	public Database <>4__this; // 0x0
	private bool finalize; // 0x0
	public bool <>3__finalize; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18951D0 Offset: 0x18937D0 VA: 0x1818951D0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895420 Offset: 0x1893A20 VA: 0x181895420
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18953D0 Offset: 0x18939D0 VA: 0x1818953D0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895300 Offset: 0x1893900 VA: 0x181895300
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645900 Offset: 0x1643F00 VA: 0x181645900
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7622
{	// Methods

	// RVA: 0x1396AA0 Offset: 0x13950A0 VA: 0x181396AA0
	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	// RVA: 0x1396A90 Offset: 0x1395090 VA: 0x181396A90
	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1396D10 Offset: 0x1395310 VA: 0x181396D10
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1396C50 Offset: 0x1395250 VA: 0x181396C50
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static byte GetTail(short number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1396B00 Offset: 0x1395100 VA: 0x181396B00
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1396BB0 Offset: 0x13951B0 VA: 0x181396BB0
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1396BA0 Offset: 0x13951A0 VA: 0x181396BA0
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7825
{	// Properties
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }

	// Methods

	// RVA: 0x224F3F0 Offset: 0x224D9F0 VA: 0x18224F3F0
	public void .ctor(int codePage) { }

	// RVA: 0x224F400 Offset: 0x224DA00 VA: 0x18224F400
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract DbcsConvert GetConvert();

	// RVA: 0x224EE50 Offset: 0x224D450 VA: 0x18224EE50 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x224EFD0 Offset: 0x224D5D0 VA: 0x18224EFD0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224F130 Offset: 0x224D730 VA: 0x18224F130 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224F2F0 Offset: 0x224D8F0 VA: 0x18224F2F0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224F370 Offset: 0x224D970 VA: 0x18224F370 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsMailNewsSave() { }

}

internal abstract class DbcsEncoding.DbcsDecoder : Decoder // TypeDefIndex: 7826
{	// Fields
	protected DbcsConvert convert; // 0x20

	// Methods

	// RVA: 0x15C0090 Offset: 0x15BE690 VA: 0x1815C0090
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224ED30 Offset: 0x224D330 VA: 0x18224ED30
	internal void CheckRange(byte[] bytes, int index, int count) { }

	// RVA: 0x224EB70 Offset: 0x224D170 VA: 0x18224EB70
	internal void CheckRange(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

internal class DbcsConvert // TypeDefIndex: 7827
{	// Fields
	public byte[] n2u; // 0x10
	public byte[] u2n; // 0x18
	internal static readonly DbcsConvert Gb2312; // 0x0
	internal static readonly DbcsConvert Big5; // 0x8
	internal static readonly DbcsConvert KS; // 0x10

	// Methods

	// RVA: 0x224E9E0 Offset: 0x224CFE0 VA: 0x18224E9E0
	internal void .ctor(string fileName) { }

	// RVA: 0x224E900 Offset: 0x224CF00 VA: 0x18224E900
	private static void .cctor() { }

}

public class Data : ConsoleSystem // TypeDefIndex: 11898
{	// Methods

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6D5D80 Offset: 0x6D4380 VA: 0x1806D5D80
	public static void export(ConsoleSystem.Arg args) { }

	// RVA: 0x6D5D20 Offset: 0x6D4320 VA: 0x1806D5D20
	public void .ctor() { }

}

