public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{	// Fields
	public static readonly DBNull Value; // 0x13C84

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1792D00 Offset: 0x1791300 VA: 0x181792D00
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1792550 Offset: 0x1790B50 VA: 0x181792550 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1792C60 Offset: 0x1791260 VA: 0x181792C60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1792C20 Offset: 0x1791220 VA: 0x181792C20 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1792580 Offset: 0x1790B80 VA: 0x181792580 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1792660 Offset: 0x1790C60 VA: 0x181792660 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1792970 Offset: 0x1790F70 VA: 0x181792970 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x17925F0 Offset: 0x1790BF0 VA: 0x1817925F0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1792820 Offset: 0x1790E20 VA: 0x181792820 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1792AD0 Offset: 0x17910D0 VA: 0x181792AD0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1792890 Offset: 0x1790E90 VA: 0x181792890 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1792B40 Offset: 0x1791140 VA: 0x181792B40 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1792900 Offset: 0x1790F00 VA: 0x181792900 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1792BB0 Offset: 0x17911B0 VA: 0x181792BB0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x17929E0 Offset: 0x1790FE0 VA: 0x1817929E0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x17927B0 Offset: 0x1790DB0 VA: 0x1817927B0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1792740 Offset: 0x1790D40 VA: 0x181792740 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x17926D0 Offset: 0x1790CD0 VA: 0x1817926D0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1792A50 Offset: 0x1791050 VA: 0x181792A50 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1792CA0 Offset: 0x17912A0 VA: 0x181792CA0
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

	// RVA: 0x120AF0 Offset: 0x11FEF0 VA: 0x180120AF0
	internal void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	// RVA: 0x120AD0 Offset: 0x11FED0 VA: 0x180120AD0
	internal void Disable() { }

	// RVA: 0x120C90 Offset: 0x120090 VA: 0x180120C90
	internal EventSource.EventData* Finish() { }

	// RVA: 0x120A70 Offset: 0x11FE70 VA: 0x180120A70
	internal void AddScalar(void* value, int size) { }

	// RVA: 0x120A30 Offset: 0x11FE30 VA: 0x180120A30
	internal void AddBinary(string value, int size) { }

	// RVA: 0x120A40 Offset: 0x11FE40 VA: 0x180120A40
	internal void AddBinary(Array value, int size) { }

	// RVA: 0x120A20 Offset: 0x11FE20 VA: 0x180120A20
	internal void AddArray(Array value, int length, int itemSize) { }

	// RVA: 0x120A80 Offset: 0x11FE80 VA: 0x180120A80
	internal int BeginBufferedArray() { }

	// RVA: 0x120B40 Offset: 0x11FF40 VA: 0x180120B40
	internal void EndBufferedArray(int bookmark, int count) { }

	// RVA: 0x120AB0 Offset: 0x11FEB0 VA: 0x180120AB0
	internal void BeginBuffered() { }

	// RVA: 0x120C10 Offset: 0x120010 VA: 0x180120C10
	internal void EndBuffered() { }

	// RVA: 0x120C70 Offset: 0x120070 VA: 0x180120C70
	private void EnsureBuffer() { }

	// RVA: 0x120C80 Offset: 0x120080 VA: 0x180120C80
	private void EnsureBuffer(int additionalSize) { }

	// RVA: 0x120CB0 Offset: 0x1200B0 VA: 0x180120CB0
	private void GrowBuffer(int required) { }

	// RVA: 0x120D10 Offset: 0x120110 VA: 0x180120D10
	private void PinArray(object value, int size) { }

	// RVA: 0x120D20 Offset: 0x120120 VA: 0x180120D20
	private void ScalarsBegin() { }

	// RVA: 0x120D30 Offset: 0x120130 VA: 0x180120D30
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

	// RVA: 0x15059A0 Offset: 0x1503FA0 VA: 0x1815059A0
	private static void .cctor() { }

	// RVA: 0x150B590 Offset: 0x1509B90 VA: 0x18150B590
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x150B690 Offset: 0x1509C90 VA: 0x18150B690
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x1504480 Offset: 0x1502A80 VA: 0x181504480
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x15043F0 Offset: 0x15029F0 VA: 0x1815043F0
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1504300 Offset: 0x1502900 VA: 0x181504300
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x1504210 Offset: 0x1502810 VA: 0x181504210
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x15055C0 Offset: 0x1503BC0 VA: 0x1815055C0
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1503F60 Offset: 0x1502560 VA: 0x181503F60
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x15028E0 Offset: 0x1500EE0 VA: 0x1815028E0
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1504940 Offset: 0x1502F40 VA: 0x181504940
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x15049D0 Offset: 0x1502FD0 VA: 0x1815049D0
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1504570 Offset: 0x1502B70 VA: 0x181504570
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1504AA0 Offset: 0x15030A0 VA: 0x181504AA0
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x1504510 Offset: 0x1502B10 VA: 0x181504510
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x15047D0 Offset: 0x1502DD0 VA: 0x1815047D0
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1503CD0 Offset: 0x15022D0 VA: 0x181503CD0 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1503CC0 Offset: 0x15022C0 VA: 0x181503CC0 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x1503990 Offset: 0x1501F90 VA: 0x181503990
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x1503E20 Offset: 0x1502420 VA: 0x181503E20
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1504E80 Offset: 0x1503480 VA: 0x181504E80 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x15051C0 Offset: 0x15037C0 VA: 0x1815051C0 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1504D80 Offset: 0x1503380 VA: 0x181504D80 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150B5F0 Offset: 0x1509BF0 VA: 0x18150B5F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150B6F0 Offset: 0x1509CF0 VA: 0x18150B6F0 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B730 Offset: 0x1509D30 VA: 0x18150B730 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x150B650 Offset: 0x1509C50 VA: 0x18150B650 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x150B670 Offset: 0x1509C70 VA: 0x18150B670 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1505390 Offset: 0x1503990 VA: 0x181505390 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15051E0 Offset: 0x15037E0 VA: 0x1815051E0 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x1505690 Offset: 0x1503C90 VA: 0x181505690 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1504D00 Offset: 0x1503300 VA: 0x181504D00
	internal string GetTypeName() { }

	// RVA: 0x1502860 Offset: 0x1500E60 VA: 0x181502860
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x13862C0 Offset: 0x13848C0 VA: 0x1813862C0
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x14B8020 Offset: 0x14B6620 VA: 0x1814B8020
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_ParentIndex() { }

	// RVA: 0x151E9B0 Offset: 0x151CFB0 VA: 0x18151E9B0 Slot: 4
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

	// RVA: 0x150BAE0 Offset: 0x150A0E0 VA: 0x18150BAE0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150C860 Offset: 0x150AE60 VA: 0x18150C860
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x150B7D0 Offset: 0x1509DD0 VA: 0x18150B7D0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0xFCB5E0 Offset: 0xFC9BE0 VA: 0x180FCB5E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150C9B0 Offset: 0x150AFB0 VA: 0x18150C9B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C980 Offset: 0x150AF80 VA: 0x18150C980 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150C920 Offset: 0x150AF20 VA: 0x18150C920 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150C9E0 Offset: 0x150AFE0 VA: 0x18150C9E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150BE40 Offset: 0x150A440 VA: 0x18150BE40 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x150C3A0 Offset: 0x150A9A0 VA: 0x18150C3A0 Slot: 16
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

	// RVA: 0x1513C70 Offset: 0x1512270 VA: 0x181513C70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x15144F0 Offset: 0x1512AF0 VA: 0x1815144F0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1513B70 Offset: 0x1512170 VA: 0x181513B70 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514660 Offset: 0x1512C60 VA: 0x181514660 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15145A0 Offset: 0x1512BA0 VA: 0x1815145A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1514600 Offset: 0x1512C00 VA: 0x181514600 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xED99E0 Offset: 0xED7FE0 VA: 0x180ED99E0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1513C80 Offset: 0x1512280 VA: 0x181513C80
	internal bool HasAtomicMembers() { }

	// RVA: 0x1513D20 Offset: 0x1512320 VA: 0x181513D20
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1513DE0 Offset: 0x15123E0 VA: 0x181513DE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514050 Offset: 0x1512650 VA: 0x181514050 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514450 Offset: 0x1512A50 VA: 0x181514450
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

	// RVA: 0x150DBA0 Offset: 0x150C1A0 VA: 0x18150DBA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150DD30 Offset: 0x150C330 VA: 0x18150DD30 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150DDF0 Offset: 0x150C3F0 VA: 0x18150DDF0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150DD90 Offset: 0x150C390 VA: 0x18150DD90 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150DB30 Offset: 0x150C130 VA: 0x18150DB30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150DC00 Offset: 0x150C200 VA: 0x18150DC00 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150DCD0 Offset: 0x150C2D0 VA: 0x18150DCD0
	public void .ctor() { }

	// RVA: 0x150DC30 Offset: 0x150C230 VA: 0x18150DC30
	private static void .cctor() { }

}

internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 2184
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150DA40 Offset: 0x150C040 VA: 0x18150DA40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150DAA0 Offset: 0x150C0A0 VA: 0x18150DAA0
	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515AD0 Offset: 0x15140D0 VA: 0x181515AD0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11BB1E0 Offset: 0x11B97E0 VA: 0x1811BB1E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515B30 Offset: 0x1514130 VA: 0x181515B30
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

	// RVA: 0x1513820 Offset: 0x1511E20 VA: 0x181513820 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15139E0 Offset: 0x1511FE0 VA: 0x1815139E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1513830 Offset: 0x1511E30 VA: 0x181513830 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513950 Offset: 0x1511F50 VA: 0x181513950
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

	// RVA: 0x150E970 Offset: 0x150CF70 VA: 0x18150E970 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150EBD0 Offset: 0x150D1D0 VA: 0x18150EBD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x132C780 Offset: 0x132AD80 VA: 0x18132C780 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150EC90 Offset: 0x150D290 VA: 0x18150EC90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150EC30 Offset: 0x150D230 VA: 0x18150EC30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xED9A20 Offset: 0xED8020 VA: 0x180ED9A20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E8F0 Offset: 0x150CEF0 VA: 0x18150E8F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E980 Offset: 0x150CF80 VA: 0x18150E980 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150EB40 Offset: 0x150D140 VA: 0x18150EB40
	public void .ctor() { }

	// RVA: 0x150EAA0 Offset: 0x150D0A0 VA: 0x18150EAA0
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

	// RVA: 0x1510900 Offset: 0x150EF00 VA: 0x181510900 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1511AB0 Offset: 0x15100B0 VA: 0x181511AB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x10E4E80 Offset: 0x10E3480 VA: 0x1810E4E80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511B70 Offset: 0x1510170 VA: 0x181511B70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1511B10 Offset: 0x1510110 VA: 0x181511B10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150FC90 Offset: 0x150E290 VA: 0x18150FC90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1511770 Offset: 0x150FD70 VA: 0x181511770 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15117F0 Offset: 0x150FDF0 VA: 0x1815117F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511A20 Offset: 0x1510020 VA: 0x181511A20
	public void .ctor() { }

	// RVA: 0x1511980 Offset: 0x150FF80 VA: 0x181511980
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

	// RVA: 0x1510900 Offset: 0x150EF00 VA: 0x181510900 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510BD0 Offset: 0x150F1D0 VA: 0x181510BD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED99F0 Offset: 0xED7FF0 VA: 0x180ED99F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510C90 Offset: 0x150F290 VA: 0x181510C90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1510C30 Offset: 0x150F230 VA: 0x181510C30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150FC90 Offset: 0x150E290 VA: 0x18150FC90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510880 Offset: 0x150EE80 VA: 0x181510880 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1510910 Offset: 0x150EF10 VA: 0x181510910 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510B40 Offset: 0x150F140 VA: 0x181510B40
	public void .ctor() { }

	// RVA: 0x1510AA0 Offset: 0x150F0A0 VA: 0x181510AA0
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

	// RVA: 0x15101C0 Offset: 0x150E7C0 VA: 0x1815101C0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510540 Offset: 0x150EB40 VA: 0x181510540 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xBA51A0 Offset: 0xBA37A0 VA: 0x180BA51A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510610 Offset: 0x150EC10 VA: 0x181510610 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15105A0 Offset: 0x150EBA0 VA: 0x1815105A0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1510600 Offset: 0x150EC00 VA: 0x181510600 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510140 Offset: 0x150E740 VA: 0x181510140 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15101D0 Offset: 0x150E7D0 VA: 0x1815101D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15104B0 Offset: 0x150EAB0 VA: 0x1815104B0
	public void .ctor() { }

	// RVA: 0x1510360 Offset: 0x150E960 VA: 0x181510360
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1511090 Offset: 0x150F690 VA: 0x181511090 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE61E20 Offset: 0xE60420 VA: 0x180E61E20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511150 Offset: 0x150F750 VA: 0x181511150 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15110F0 Offset: 0x150F6F0 VA: 0x1815110F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150FC90 Offset: 0x150E290 VA: 0x18150FC90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510CF0 Offset: 0x150F2F0 VA: 0x181510CF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1510D70 Offset: 0x150F370 VA: 0x181510D70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511000 Offset: 0x150F600 VA: 0x181511000
	public void .ctor() { }

	// RVA: 0x1510F60 Offset: 0x150F560 VA: 0x181510F60
	private static void .cctor() { }

}

internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 2192
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515F90 Offset: 0x1514590 VA: 0x181515F90 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15161E0 Offset: 0x15147E0 VA: 0x1815161E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1516180 Offset: 0x1514780 VA: 0x181516180
	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150FE80 Offset: 0x150E480 VA: 0x18150FE80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15100D0 Offset: 0x150E6D0 VA: 0x1815100D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510070 Offset: 0x150E670 VA: 0x181510070
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

	// RVA: 0x150F720 Offset: 0x150DD20 VA: 0x18150F720 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150FBC0 Offset: 0x150E1C0 VA: 0x18150FBC0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150FC80 Offset: 0x150E280 VA: 0x18150FC80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FB20 Offset: 0x150E120 VA: 0x18150FB20
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x150FCA0 Offset: 0x150E2A0 VA: 0x18150FCA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150FC20 Offset: 0x150E220 VA: 0x18150FC20 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150FC90 Offset: 0x150E290 VA: 0x18150FC90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150F620 Offset: 0x150DC20 VA: 0x18150F620 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F730 Offset: 0x150DD30 VA: 0x18150F730 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150FA80 Offset: 0x150E080 VA: 0x18150FA80
	private static void .cctor() { }

}

internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2195
{	// Methods

	// RVA: 0x150FD00 Offset: 0x150E300 VA: 0x18150FD00
	internal void .ctor() { }

}

internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2196
{	// Methods

	// RVA: 0x150FD60 Offset: 0x150E360 VA: 0x18150FD60
	internal void .ctor() { }

}

internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 2197
{	// Methods

	// RVA: 0x150FDC0 Offset: 0x150E3C0 VA: 0x18150FDC0
	internal void .ctor() { }

}

internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2198
{	// Methods

	// RVA: 0x1513A40 Offset: 0x1512040 VA: 0x181513A40
	internal void .ctor() { }

}

internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2199
{	// Methods

	// RVA: 0x1513AA0 Offset: 0x15120A0 VA: 0x181513AA0
	internal void .ctor() { }

}

internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 2200
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1513B60 Offset: 0x1512160 VA: 0x181513B60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513B00 Offset: 0x1512100 VA: 0x181513B00
	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED99A0 Offset: 0xED7FA0 VA: 0x180ED99A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FE20 Offset: 0x150E420 VA: 0x18150FE20
	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1514850 VA: 0x181516250 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15161F0 Offset: 0x15147F0 VA: 0x1815161F0
	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15162C0 Offset: 0x15148C0 VA: 0x1815162C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1516260 Offset: 0x1514860 VA: 0x181516260
	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512C40 Offset: 0x1511240 VA: 0x181512C40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512BE0 Offset: 0x15111E0 VA: 0x181512BE0
	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED99E0 Offset: 0xED7FE0 VA: 0x180ED99E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15100E0 Offset: 0x150E6E0 VA: 0x1815100E0
	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x49DC50 Offset: 0x49C250 VA: 0x18049DC50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512C50 Offset: 0x1511250 VA: 0x181512C50
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1511FB0 Offset: 0x15105B0 VA: 0x181511FB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512070 Offset: 0x1510670 VA: 0x181512070 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512080 Offset: 0x1510680 VA: 0x181512080 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512010 Offset: 0x1510610 VA: 0x181512010 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1511BD0 Offset: 0x15101D0 VA: 0x181511BD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1511D00 Offset: 0x1510300 VA: 0x181511D00 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511F20 Offset: 0x1510520 VA: 0x181511F20
	public void .ctor() { }

	// RVA: 0x1511E80 Offset: 0x1510480 VA: 0x181511E80
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150E7C0 Offset: 0x150CDC0 VA: 0x18150E7C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150E880 Offset: 0x150CE80 VA: 0x18150E880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150E890 Offset: 0x150CE90 VA: 0x18150E890 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150E820 Offset: 0x150CE20 VA: 0x18150E820 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E3E0 Offset: 0x150C9E0 VA: 0x18150E3E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E510 Offset: 0x150CB10 VA: 0x18150E510 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E730 Offset: 0x150CD30 VA: 0x18150E730
	public void .ctor() { }

	// RVA: 0x150E690 Offset: 0x150CC90 VA: 0x18150E690
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150E2C0 Offset: 0x150C8C0 VA: 0x18150E2C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED99C0 Offset: 0xED7FC0 VA: 0x180ED99C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150E380 Offset: 0x150C980 VA: 0x18150E380 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150E320 Offset: 0x150C920 VA: 0x18150E320 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150DE50 Offset: 0x150C450 VA: 0x18150DE50 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150DF80 Offset: 0x150C580 VA: 0x18150DF80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E230 Offset: 0x150C830 VA: 0x18150E230
	public void .ctor() { }

	// RVA: 0x150E190 Offset: 0x150C790 VA: 0x18150E190
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150D910 Offset: 0x150BF10 VA: 0x18150D910 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150D9D0 Offset: 0x150BFD0 VA: 0x18150D9D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150D9E0 Offset: 0x150BFE0 VA: 0x18150D9E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D970 Offset: 0x150BF70 VA: 0x18150D970 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150D5F0 Offset: 0x150BBF0 VA: 0x18150D5F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150D880 Offset: 0x150BE80 VA: 0x18150D880
	public void .ctor() { }

	// RVA: 0x150D7E0 Offset: 0x150BDE0 VA: 0x18150D7E0
	private static void .cctor() { }

}

internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 2211
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1513160 Offset: 0x1511760 VA: 0x181513160 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1513160 Offset: 0x1511760 VA: 0x181513160 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xED99D0 Offset: 0xED7FD0 VA: 0x180ED99D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED99D0 Offset: 0xED7FD0 VA: 0x180ED99D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512770 Offset: 0x1510D70 VA: 0x181512770 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xBA4600 Offset: 0xBA2C00 VA: 0x180BA4600 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x91FD00 Offset: 0x91E300 VA: 0x18091FD00 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150D230 Offset: 0x150B830 VA: 0x18150D230 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED9A60 Offset: 0xED8060 VA: 0x180ED9A60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150CA20 Offset: 0x150B020 VA: 0x18150CA20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B7C0 Offset: 0x1509DC0 VA: 0x18150B7C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B7B0 Offset: 0x1509DB0 VA: 0x18150B7B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B7A0 Offset: 0x1509DA0 VA: 0x18150B7A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
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

	// RVA: 0x150CB70 Offset: 0x150B170 VA: 0x18150CB70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150D100 Offset: 0x150B700 VA: 0x18150D100 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150D1C0 Offset: 0x150B7C0 VA: 0x18150D1C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150CA10 Offset: 0x150B010 VA: 0x18150CA10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150D1D0 Offset: 0x150B7D0 VA: 0x18150D1D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D160 Offset: 0x150B760 VA: 0x18150D160 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150CB80 Offset: 0x150B180 VA: 0x18150CB80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150CD70 Offset: 0x150B370 VA: 0x18150CD70 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x150D070 Offset: 0x150B670 VA: 0x18150D070
	public void .ctor() { }

	// RVA: 0x150CFD0 Offset: 0x150B5D0 VA: 0x18150CFD0
	private static void .cctor() { }

}

internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 2223
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED9A20 Offset: 0xED8020 VA: 0x180ED9A20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15125C0 Offset: 0x1510BC0 VA: 0x1815125C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512710 Offset: 0x1510D10 VA: 0x181512710
	public void .ctor() { }

}

internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 2224
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x14250

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x15130F0 Offset: 0x15116F0 VA: 0x1815130F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1513150 Offset: 0x1511750 VA: 0x181513150 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1512710 Offset: 0x1510D10 VA: 0x181512710
	public void .ctor() { }

	// RVA: 0x1513000 Offset: 0x1511600 VA: 0x181513000
	private static void .cctor() { }

}

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 2225
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x142A8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512E30 Offset: 0x1511430 VA: 0x181512E30 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512E90 Offset: 0x1511490 VA: 0x181512E90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512DA0 Offset: 0x15113A0 VA: 0x181512DA0
	public void .ctor() { }

	// RVA: 0x1512CB0 Offset: 0x15112B0 VA: 0x181512CB0
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

	// RVA: 0x1512AB0 Offset: 0x15110B0 VA: 0x181512AB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1512B70 Offset: 0x1511170 VA: 0x181512B70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512780 Offset: 0x1510D80 VA: 0x181512780 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1512B80 Offset: 0x1511180 VA: 0x181512B80 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512B10 Offset: 0x1511110 VA: 0x181512B10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1512800 Offset: 0x1510E00 VA: 0x181512800 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512710 Offset: 0x1510D10 VA: 0x181512710
	public void .ctor() { }

	// RVA: 0x1512980 Offset: 0x1510F80 VA: 0x181512980
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

	// RVA: 0x15124A0 Offset: 0x1510AA0 VA: 0x1815124A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED99B0 Offset: 0xED7FB0 VA: 0x180ED99B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15120E0 Offset: 0x15106E0 VA: 0x1815120E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1512560 Offset: 0x1510B60 VA: 0x181512560 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512500 Offset: 0x1510B00 VA: 0x181512500 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1512160 Offset: 0x1510760 VA: 0x181512160 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512410 Offset: 0x1510A10 VA: 0x181512410
	public void .ctor() { }

	// RVA: 0x15122E0 Offset: 0x15108E0 VA: 0x1815122E0
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

	// RVA: 0x15136F0 Offset: 0x1511CF0 VA: 0x1815136F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15137B0 Offset: 0x1511DB0 VA: 0x1815137B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513360 Offset: 0x1511960 VA: 0x181513360 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15137C0 Offset: 0x1511DC0 VA: 0x1815137C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1513750 Offset: 0x1511D50 VA: 0x181513750 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15133E0 Offset: 0x15119E0 VA: 0x1815133E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513690 Offset: 0x1511C90 VA: 0x181513690
	public void .ctor() { }

	// RVA: 0x1513560 Offset: 0x1511B60 VA: 0x181513560
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

	// RVA: 0x150F0B0 Offset: 0x150D6B0 VA: 0x18150F0B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150F170 Offset: 0x150D770 VA: 0x18150F170 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150ECF0 Offset: 0x150D2F0 VA: 0x18150ECF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F180 Offset: 0x150D780 VA: 0x18150F180 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150F110 Offset: 0x150D710 VA: 0x18150F110 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150ED70 Offset: 0x150D370 VA: 0x18150ED70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F020 Offset: 0x150D620 VA: 0x18150F020
	public void .ctor() { }

	// RVA: 0x150EEF0 Offset: 0x150D4F0 VA: 0x18150EEF0
	private static void .cctor() { }

}

internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 2230
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B112A0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512F90 Offset: 0x1511590 VA: 0x181512F90 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512FF0 Offset: 0x15115F0 VA: 0x181512FF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1512710 Offset: 0x1510D10 VA: 0x181512710
	public void .ctor() { }

	// RVA: 0x1512EA0 Offset: 0x15114A0 VA: 0x181512EA0
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

	// RVA: 0x15154A0 Offset: 0x1513AA0 VA: 0x1815154A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x7D9FF0 Offset: 0x7D85F0 VA: 0x1807D9FF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515070 Offset: 0x1513670 VA: 0x181515070 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1515560 Offset: 0x1513B60 VA: 0x181515560 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515500 Offset: 0x1513B00 VA: 0x181515500 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15150F0 Offset: 0x15136F0 VA: 0x1815150F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515410 Offset: 0x1513A10 VA: 0x181515410
	public void .ctor() { }

	// RVA: 0x15152C0 Offset: 0x15138C0 VA: 0x1815152C0
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

	// RVA: 0x1514F40 Offset: 0x1513540 VA: 0x181514F40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1515000 Offset: 0x1513600 VA: 0x181515000 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514B90 Offset: 0x1513190 VA: 0x181514B90 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1515010 Offset: 0x1513610 VA: 0x181515010 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514FA0 Offset: 0x15135A0 VA: 0x181514FA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514C10 Offset: 0x1513210 VA: 0x181514C10 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514EE0 Offset: 0x15134E0 VA: 0x181514EE0
	public void .ctor() { }

	// RVA: 0x1514D90 Offset: 0x1513390 VA: 0x181514D90
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

	// RVA: 0x15159A0 Offset: 0x1513FA0 VA: 0x1815159A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1515A60 Offset: 0x1514060 VA: 0x181515A60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15155C0 Offset: 0x1513BC0 VA: 0x1815155C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1515A70 Offset: 0x1514070 VA: 0x181515A70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515A00 Offset: 0x1514000 VA: 0x181515A00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1515640 Offset: 0x1513C40 VA: 0x181515640 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515910 Offset: 0x1513F10 VA: 0x181515910
	public void .ctor() { }

	// RVA: 0x15157C0 Offset: 0x1513DC0 VA: 0x1815157C0
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

	// RVA: 0x1514A70 Offset: 0x1513070 VA: 0x181514A70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x50E1B0 Offset: 0x50C7B0 VA: 0x18050E1B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15146C0 Offset: 0x1512CC0 VA: 0x1815146C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514B30 Offset: 0x1513130 VA: 0x181514B30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514AD0 Offset: 0x15130D0 VA: 0x181514AD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514740 Offset: 0x1512D40 VA: 0x181514740 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514A10 Offset: 0x1513010 VA: 0x181514A10
	public void .ctor() { }

	// RVA: 0x15148C0 Offset: 0x1512EC0 VA: 0x1815148C0
	private static void .cctor() { }

}

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 2235
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x142B0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15132F0 Offset: 0x15118F0 VA: 0x1815132F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1513350 Offset: 0x1511950 VA: 0x181513350 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513260 Offset: 0x1511860 VA: 0x181513260
	public void .ctor() { }

	// RVA: 0x1513170 Offset: 0x1511770 VA: 0x181513170
	private static void .cctor() { }

}

internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 2236
{	// Methods

	// RVA: 0x1510670 Offset: 0x150EC70 VA: 0x181510670 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1510820 Offset: 0x150EE20 VA: 0x181510820
	public void .ctor() { }

}

internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 2237
{	// Methods

	// RVA: 0x15115A0 Offset: 0x150FBA0 VA: 0x1815115A0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1511710 Offset: 0x150FD10 VA: 0x181511710
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

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150D240 Offset: 0x150B840 VA: 0x18150D240 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150D590 Offset: 0x150BB90 VA: 0x18150D590 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D530 Offset: 0x150BB30 VA: 0x18150D530 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150D4A0 Offset: 0x150BAA0 VA: 0x18150D4A0
	public void .ctor() { }

	// RVA: 0x150D400 Offset: 0x150BA00 VA: 0x18150D400
	private static void .cctor() { }

}

internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 2239
{	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xE668B0 Offset: 0xE64EB0 VA: 0x180E668B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B790 Offset: 0x1509D90 VA: 0x18150B790
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

	// RVA: 0x150F5C0 Offset: 0x150DBC0 VA: 0x18150F5C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150F560 Offset: 0x150DB60 VA: 0x18150F560 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150F1E0 Offset: 0x150D7E0 VA: 0x18150F1E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F260 Offset: 0x150D860 VA: 0x18150F260 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150F380 Offset: 0x150D980 VA: 0x18150F380 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F4D0 Offset: 0x150DAD0 VA: 0x18150F4D0
	public void .ctor() { }

	// RVA: 0x150F430 Offset: 0x150DA30 VA: 0x18150F430
	private static void .cctor() { }

}

internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 2241
{	// Methods

	// RVA: 0x15111B0 Offset: 0x150F7B0 VA: 0x1815111B0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15113B0 Offset: 0x150F9B0 VA: 0x1815113B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511540 Offset: 0x150FB40 VA: 0x181511540
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

	// RVA: 0x1515F30 Offset: 0x1514530 VA: 0x181515F30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515ED0 Offset: 0x15144D0 VA: 0x181515ED0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1515B40 Offset: 0x1514140 VA: 0x181515B40 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1515BD0 Offset: 0x15141D0 VA: 0x181515BD0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1515CF0 Offset: 0x15142F0 VA: 0x181515CF0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515E40 Offset: 0x1514440 VA: 0x181515E40
	public void .ctor() { }

	// RVA: 0x1515DA0 Offset: 0x15143A0 VA: 0x181515DA0
	private static void .cctor() { }

}

public sealed class DataUtility // TypeDefIndex: 3576
{	// Methods

	// RVA: 0x19AA000 Offset: 0x19A8600 VA: 0x1819AA000
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x19AA180 Offset: 0x19A8780 VA: 0x1819AA180
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x19AA1F0 Offset: 0x19A87F0 VA: 0x1819AA1F0
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x19AA070 Offset: 0x19A8670 VA: 0x1819AA070
	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4171
{	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[EventAttribute] // RVA: 0x9ACD0 Offset: 0x9A0D0 VA: 0x18009ACD0
	// RVA: 0x1234280 Offset: 0x1232880 VA: 0x181234280
	internal void Trace(string message) { }

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE021D0 Offset: 0xE007D0 VA: 0x180E021D0
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0xE016F0 Offset: 0xDFFCF0 VA: 0x180E016F0
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFCD0 Offset: 0xDFE2D0 VA: 0x180DFFCD0
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0xDFFE00 Offset: 0xDFE400 VA: 0x180DFFE00
	|-DataCommonEventSource.Trace<int, ListChangedType>
	|-DataCommonEventSource.Trace<int, MappingType>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0xE00B40 Offset: 0xDFF140 VA: 0x180E00B40
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0xE00C70 Offset: 0xDFF270 VA: 0x180E00C70
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0xE01600 Offset: 0xDFFC00 VA: 0x180E01600
	|-DataCommonEventSource.Trace<int, object>
	|-DataCommonEventSource.Trace<int, string>
	|
	|-RVA: 0xE02110 Offset: 0xE00710 VA: 0x180E02110
	|-DataCommonEventSource.Trace<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFF30 Offset: 0xDFE530 VA: 0x180DFFF30
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0xE00860 Offset: 0xDFEE60 VA: 0x180E00860
	|-DataCommonEventSource.Trace<int, int, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0xE009D0 Offset: 0xDFEFD0 VA: 0x180E009D0
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0xE00DA0 Offset: 0xDFF3A0 VA: 0x180E00DA0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, DataViewRowState>
	|
	|-RVA: 0xE01500 Offset: 0xDFFB00 VA: 0x180E01500
	|-DataCommonEventSource.Trace<int, object, object>
	|-DataCommonEventSource.Trace<int, string, string>
	|
	|-RVA: 0xE02040 Offset: 0xE00640 VA: 0x180E02040
	|-DataCommonEventSource.Trace<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00550 Offset: 0xDFEB50 VA: 0x180E00550
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE01250 Offset: 0xDFF850 VA: 0x180E01250
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, string, DataViewRowState>
	|-DataCommonEventSource.Trace<int, string, string, MappingType>
	|
	|-RVA: 0xE01DF0 Offset: 0xE003F0 VA: 0x180E01DF0
	|-DataCommonEventSource.Trace<object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00EE0 Offset: 0xDFF4E0 VA: 0x180E00EE0
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-RVA: 0xE01B40 Offset: 0xE00140 VA: 0x180E01B40
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE000A0 Offset: 0xDFE6A0 VA: 0x180E000A0
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE017E0 Offset: 0xDFFDE0 VA: 0x180E017E0
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	// RVA: 0x1234190 Offset: 0x1232790 VA: 0x181234190
	internal long EnterScope(string message) { }

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2620 Offset: 0xED0C20 VA: 0x180ED2620
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0xED2AF0 Offset: 0xED10F0 VA: 0x180ED2AF0
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED18B0 Offset: 0xECFEB0 VA: 0x180ED18B0
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0xED1B70 Offset: 0xED0170 VA: 0x180ED1B70
	|-DataCommonEventSource.EnterScope<int, SchemaFormat>
	|-DataCommonEventSource.EnterScope<int, XmlReadMode>
	|-DataCommonEventSource.EnterScope<int, XmlWriteMode>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0xED22A0 Offset: 0xED08A0 VA: 0x180ED22A0
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0xED2530 Offset: 0xED0B30 VA: 0x180ED2530
	|-DataCommonEventSource.EnterScope<int, object>
	|-DataCommonEventSource.EnterScope<int, string>
	|
	|-RVA: 0xED2A30 Offset: 0xED1030 VA: 0x180ED2A30
	|-DataCommonEventSource.EnterScope<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED19F0 Offset: 0xECFFF0 VA: 0x180ED19F0
	|-DataCommonEventSource.EnterScope<int, XmlReadMode, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0xED1FD0 Offset: 0xED05D0 VA: 0x180ED1FD0
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0xED2150 Offset: 0xED0750 VA: 0x180ED2150
	|-DataCommonEventSource.EnterScope<int, int, object>
	|-DataCommonEventSource.EnterScope<int, int, string>
	|
	|-RVA: 0xED23E0 Offset: 0xED09E0 VA: 0x180ED23E0
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|-DataCommonEventSource.EnterScope<int, string, bool>
	|
	|-RVA: 0xED2960 Offset: 0xED0F60 VA: 0x180ED2960
	|-DataCommonEventSource.EnterScope<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED1CB0 Offset: 0xED02B0 VA: 0x180ED1CB0
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0xED2710 Offset: 0xED0D10 VA: 0x180ED2710
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B580 Offset: 0x9A980 VA: 0x18009B580
	// RVA: 0x1234270 Offset: 0x1232870 VA: 0x181234270
	internal void ExitScope(long scopeId) { }

	// RVA: 0x1234340 Offset: 0x1232940 VA: 0x181234340
	public void .ctor() { }

	// RVA: 0x1234290 Offset: 0x1232890 VA: 0x181234290
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

	// RVA: 0x12300F0 Offset: 0x122E6F0 VA: 0x1812300F0
	public void .ctor() { }

	// RVA: 0x12304B0 Offset: 0x122EAB0 VA: 0x1812304B0
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x1230180 Offset: 0x122E780 VA: 0x181230180
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x122FFD0 Offset: 0x122E5D0 VA: 0x18122FFD0
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_AllowDBNull() { }

	// RVA: 0x1230CE0 Offset: 0x122F2E0 VA: 0x181230CE0
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x1230680 Offset: 0x122EC80 VA: 0x181230680
	public bool get_AutoIncrement() { }

	// RVA: 0x12311E0 Offset: 0x122F7E0 VA: 0x1812311E0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x12305C0 Offset: 0x122EBC0 VA: 0x1812305C0
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1230E60 Offset: 0x122F460 VA: 0x181230E60
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x12304E0 Offset: 0x122EAE0 VA: 0x1812304E0
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1230630 Offset: 0x122EC30 VA: 0x181230630
	public long get_AutoIncrementSeed() { }

	// RVA: 0x1231010 Offset: 0x122F610 VA: 0x181231010
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1230650 Offset: 0x122EC50 VA: 0x181230650
	public long get_AutoIncrementStep() { }

	// RVA: 0x12310F0 Offset: 0x122F6F0 VA: 0x1812310F0
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x12306A0 Offset: 0x122ECA0 VA: 0x1812306A0
	public string get_Caption() { }

	// RVA: 0x1231390 Offset: 0x122F990 VA: 0x181231390
	public void set_Caption(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_ColumnName() { }

	// RVA: 0x1231700 Offset: 0x122FD00 VA: 0x181231700
	public void set_ColumnName(string value) { }

	// RVA: 0x1230830 Offset: 0x122EE30 VA: 0x181230830
	internal string get_EncodedColumnName() { }

	// RVA: 0x12309A0 Offset: 0x122EFA0 VA: 0x1812309A0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1230B00 Offset: 0x122F100 VA: 0x181230B00
	internal CultureInfo get_Locale() { }

	// RVA: 0x1050730 Offset: 0x104ED30 VA: 0x181050730
	internal int get_ObjectID() { }

	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public string get_Prefix() { }

	// RVA: 0x1233640 Offset: 0x1231C40 VA: 0x181233640
	public void set_Prefix(string value) { }

	// RVA: 0x122E9A0 Offset: 0x122CFA0 VA: 0x18122E9A0
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x12306B0 Offset: 0x122ECB0 VA: 0x1812306B0
	internal bool get_Computed() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal DataExpression get_DataExpression() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_DataType() { }

	// RVA: 0x1231B00 Offset: 0x1230100 VA: 0x181231B00
	public void set_DataType(Type value) { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1232480 Offset: 0x1230A80 VA: 0x181232480
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x12306D0 Offset: 0x122ECD0 VA: 0x1812306D0
	public object get_DefaultValue() { }

	// RVA: 0x12325D0 Offset: 0x1230BD0 VA: 0x1812325D0
	public void set_DefaultValue(object value) { }

	// RVA: 0x12306C0 Offset: 0x122ECC0 VA: 0x1812306C0
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x12308B0 Offset: 0x122EEB0 VA: 0x1812308B0
	public string get_Expression() { }

	// RVA: 0x12328A0 Offset: 0x1230EA0 VA: 0x1812328A0
	public void set_Expression(string value) { }

	// RVA: 0x1230920 Offset: 0x122EF20 VA: 0x181230920
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1230A10 Offset: 0x122F010 VA: 0x181230A10
	internal bool get_HasData() { }

	// RVA: 0x11888F0 Offset: 0x1186EF0 VA: 0x1811888F0
	internal bool get_ImplementsINullable() { }

	// RVA: 0x1230A20 Offset: 0x122F020 VA: 0x181230A20
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xE668A0 Offset: 0xE64EA0 VA: 0x180E668A0
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x1230AB0 Offset: 0x122F0B0 VA: 0x181230AB0
	internal bool get_IsValueType() { }

	// RVA: 0x11888E0 Offset: 0x1186EE0 VA: 0x1811888E0
	internal bool get_IsSqlType() { }

	// RVA: 0x122FA80 Offset: 0x122E080 VA: 0x18122FA80
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_MaxLength() { }

	// RVA: 0x1233160 Offset: 0x1231760 VA: 0x181233160
	public void set_MaxLength(int value) { }

	// RVA: 0x1230B70 Offset: 0x122F170 VA: 0x181230B70
	public string get_Namespace() { }

	// RVA: 0x1233510 Offset: 0x1231B10 VA: 0x181233510
	public void set_Namespace(string value) { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public int get_Ordinal() { }

	// RVA: 0x122FB80 Offset: 0x122E180 VA: 0x18122FB80
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool get_ReadOnly() { }

	// RVA: 0x1233790 Offset: 0x1231D90 VA: 0x181233790
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1230BE0 Offset: 0x122F1E0 VA: 0x181230BE0
	private Index get_SortIndex() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public DataTable get_Table() { }

	// RVA: 0x122FD20 Offset: 0x122E320 VA: 0x18122FD20
	internal void SetTable(DataTable table) { }

	// RVA: 0x122EA90 Offset: 0x122D090 VA: 0x18122EA90
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1230AD0 Offset: 0x122F0D0 VA: 0x181230AD0
	internal object get_Item(int record) { }

	// RVA: 0x1232FD0 Offset: 0x12315D0 VA: 0x181232FD0
	internal void set_Item(int record, object value) { }

	// RVA: 0x122EE40 Offset: 0x122D440 VA: 0x18122EE40
	internal void InitializeRecord(int record) { }

	// RVA: 0x122FE00 Offset: 0x122E400 VA: 0x18122FE00
	internal void SetValue(int record, object value) { }

	// RVA: 0x122E890 Offset: 0x122CE90 VA: 0x18122E890
	internal void FreeRecord(int record) { }

	// RVA: 0x1230CD0 Offset: 0x122F2D0 VA: 0x181230CD0
	public bool get_Unique() { }

	// RVA: 0x12338C0 Offset: 0x1231EC0 VA: 0x1812338C0
	public void set_Unique(bool value) { }

	// RVA: 0x7AF000 Offset: 0x7AD600 VA: 0x1807AF000
	internal void InternalUnique(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void set_XmlDataType(string value) { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1233850 Offset: 0x1231E50 VA: 0x181233850
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x10507D0 Offset: 0x104EDD0 VA: 0x1810507D0 Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x1231480 Offset: 0x122FA80 VA: 0x181231480 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x122D740 Offset: 0x122BD40 VA: 0x18122D740
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x122D920 Offset: 0x122BF20 VA: 0x18122D920
	internal bool CheckMaxLength() { }

	// RVA: 0x122D880 Offset: 0x122BE80 VA: 0x18122D880
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x122DB90 Offset: 0x122C190 VA: 0x18122DB90
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x122DE70 Offset: 0x122C470 VA: 0x18122DE70
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x122DF20 Offset: 0x122C520 VA: 0x18122DF20
	protected void CheckUnique() { }

	// RVA: 0x122E660 Offset: 0x122CC60 VA: 0x18122E660
	internal int Compare(int record1, int record2) { }

	// RVA: 0x122E460 Offset: 0x122CA60 VA: 0x18122E460
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x122E430 Offset: 0x122CA30 VA: 0x18122E430
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x122E750 Offset: 0x122CD50 VA: 0x18122E750
	internal object ConvertValue(object value) { }

	// RVA: 0x122E860 Offset: 0x122CE60 VA: 0x18122E860
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x122DFA0 Offset: 0x122C5A0 VA: 0x18122DFA0
	internal DataColumn Clone() { }

	// RVA: 0x122E8C0 Offset: 0x122CEC0 VA: 0x18122E8C0
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x122EB00 Offset: 0x122D100 VA: 0x18122EB00
	private int GetStringLength(int record) { }

	// RVA: 0x122ED90 Offset: 0x122D390 VA: 0x18122ED90
	internal void Init(int record) { }

	// RVA: 0x122EF30 Offset: 0x122D530 VA: 0x18122EF30
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x1230A40 Offset: 0x122F040 VA: 0x181230A40
	internal bool get_IsCustomType() { }

	// RVA: 0x122F850 Offset: 0x122DE50 VA: 0x18122F850
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x1230A30 Offset: 0x122F030 VA: 0x181230A30
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x122F820 Offset: 0x122DE20 VA: 0x18122F820
	internal bool IsNull(int record) { }

	// RVA: 0x122F1D0 Offset: 0x122D7D0 VA: 0x18122F1D0
	internal bool IsInRelation() { }

	// RVA: 0x122F360 Offset: 0x122D960 VA: 0x18122F360
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x122F6C0 Offset: 0x122DCC0 VA: 0x18122F6C0
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x10131D0 Offset: 0x10117D0 VA: 0x1810131D0 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x122F920 Offset: 0x122DF20 VA: 0x18122F920
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x122EE90 Offset: 0x122D490 VA: 0x18122EE90
	private void InsureStorage() { }

	// RVA: 0x122FA30 Offset: 0x122E030 VA: 0x18122FA30
	internal void SetCapacity(int capacity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void OnSetDataSet() { }

	// RVA: 0x122FF00 Offset: 0x122E500 VA: 0x18122FF00 Slot: 3
	public override string ToString() { }

	// RVA: 0x122E780 Offset: 0x122CD80 VA: 0x18122E780
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x122E7D0 Offset: 0x122CDD0 VA: 0x18122E7D0
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122E690 Offset: 0x122CC90 VA: 0x18122E690
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x122E6E0 Offset: 0x122CCE0 VA: 0x18122E6E0
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122EAC0 Offset: 0x122D0C0 VA: 0x18122EAC0
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x122E830 Offset: 0x122CE30 VA: 0x18122E830
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x122FCD0 Offset: 0x122E2D0 VA: 0x18122FCD0
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x122D680 Offset: 0x122BC80 VA: 0x18122D680
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122F9A0 Offset: 0x122DFA0 VA: 0x18122F9A0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122EB30 Offset: 0x122D130 VA: 0x18122EB30
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

	// RVA: 0x1229C40 Offset: 0x1228240 VA: 0x181229C40
	internal void .ctor(DataRow row) { }

	// RVA: 0x1229B90 Offset: 0x1228190 VA: 0x181229B90
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ProposedValue(object value) { }

	// RVA: 0x1229B50 Offset: 0x1228150 VA: 0x181229B50
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x122CAE0 Offset: 0x122B0E0 VA: 0x18122CAE0
	internal void .ctor(DataTable table) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x122CF10 Offset: 0x122B510 VA: 0x18122CF10
	public DataColumn get_Item(int index) { }

	// RVA: 0x122CDC0 Offset: 0x122B3C0 VA: 0x18122CDC0
	public DataColumn get_Item(string name) { }

	// RVA: 0x122CD10 Offset: 0x122B310 VA: 0x18122CD10
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x122A150 Offset: 0x1228750 VA: 0x18122A150
	public void Add(DataColumn column) { }

	// RVA: 0x1229CB0 Offset: 0x12282B0 VA: 0x181229CB0
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0x122A160 Offset: 0x1228760 VA: 0x18122A160
	public DataColumn Add(string columnName, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122CBD0 Offset: 0x122B1D0 VA: 0x18122CBD0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122CFF0 Offset: 0x122B5F0 VA: 0x18122CFF0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122CC70 Offset: 0x122B270 VA: 0x18122CC70
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122D090 Offset: 0x122B690 VA: 0x18122D090
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x122A270 Offset: 0x1228870 VA: 0x18122A270
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x122A200 Offset: 0x1228800 VA: 0x18122A200
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x122A300 Offset: 0x1228900 VA: 0x18122A300
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x122A630 Offset: 0x1228C30 VA: 0x18122A630
	internal string AssignName() { }

	// RVA: 0x122A740 Offset: 0x1228D40 VA: 0x18122A740
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x122AB70 Offset: 0x1229170 VA: 0x18122AB70
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x122AEC0 Offset: 0x12294C0 VA: 0x18122AEC0
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x122B090 Offset: 0x1229690 VA: 0x18122B090
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x122B980 Offset: 0x1229F80 VA: 0x18122B980
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x122B9D0 Offset: 0x1229FD0 VA: 0x18122B9D0
	public void Clear() { }

	// RVA: 0x122BF10 Offset: 0x122A510 VA: 0x18122BF10
	public bool Contains(string name) { }

	// RVA: 0x122BFA0 Offset: 0x122A5A0 VA: 0x18122BFA0
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x122C200 Offset: 0x122A800 VA: 0x18122C200
	public int IndexOf(string columnName) { }

	// RVA: 0x122C060 Offset: 0x122A660 VA: 0x18122C060
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x122C300 Offset: 0x122A900 VA: 0x18122C300
	private string MakeName(int index) { }

	// RVA: 0x122C390 Offset: 0x122A990 VA: 0x18122C390
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C430 Offset: 0x122AA30 VA: 0x18122C430
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C450 Offset: 0x122AA50 VA: 0x18122C450
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C4A0 Offset: 0x122AAA0 VA: 0x18122C4A0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x122B030 Offset: 0x1229630 VA: 0x18122B030
	internal bool CanRegisterName(string name) { }

	// RVA: 0x122C7C0 Offset: 0x122ADC0 VA: 0x18122C7C0
	public void Remove(DataColumn column) { }

	// RVA: 0x122C930 Offset: 0x122AF30 VA: 0x18122C930
	internal void UnregisterName(string name) { }

	// RVA: 0x122A060 Offset: 0x1228660 VA: 0x18122A060
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x122C6A0 Offset: 0x122ACA0 VA: 0x18122C6A0
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

	// RVA: 0x122D3D0 Offset: 0x122B9D0 VA: 0x18122D3D0
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x122D420 Offset: 0x122BA20 VA: 0x18122D420 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal DataColumn get_Column() { }

	// RVA: 0x122D5E0 Offset: 0x122BBE0 VA: 0x18122D5E0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x122D640 Offset: 0x122BC40 VA: 0x18122D640 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x122D660 Offset: 0x122BC60 VA: 0x18122D660 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x122D130 Offset: 0x122B730 VA: 0x18122D130 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4530 Offset: 0xAE2B30 VA: 0x180AE4530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122D1C0 Offset: 0x122B7C0 VA: 0x18122D1C0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x122D2A0 Offset: 0x122B8A0 VA: 0x18122D2A0 Slot: 19
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

	// RVA: 0x1234C20 Offset: 0x1233220 VA: 0x181234C20
	internal void .ctor() { }

	// RVA: 0x1234B70 Offset: 0x1233170 VA: 0x181234B70
	internal void .ctor(string rowError) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Text() { }

	// RVA: 0x1234CA0 Offset: 0x12332A0 VA: 0x181234CA0
	internal void set_Text(string value) { }

	// RVA: 0x1234C70 Offset: 0x1233270 VA: 0x181234C70
	internal bool get_HasErrors() { }

	// RVA: 0x1234820 Offset: 0x1232E20 VA: 0x181234820
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1234500 Offset: 0x1232B00 VA: 0x181234500
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1234440 Offset: 0x1232A40 VA: 0x181234440
	internal void Clear(DataColumn column) { }

	// RVA: 0x12343A0 Offset: 0x12329A0 VA: 0x1812343A0
	internal void Clear() { }

	// RVA: 0x12345B0 Offset: 0x1232BB0 VA: 0x1812345B0
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x1234B10 Offset: 0x1233110 VA: 0x181234B10
	private void SetText(string errorText) { }

	// RVA: 0x12346C0 Offset: 0x1232CC0 VA: 0x1812346C0
	internal int IndexOf(DataColumn column) { }

}

internal struct DataError.ColumnError // TypeDefIndex: 4190
{	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8

}

public class DataException : SystemException // TypeDefIndex: 4191
{	// Methods

	// RVA: 0x1234D00 Offset: 0x1233300 VA: 0x181234D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1234D80 Offset: 0x1233380 VA: 0x181234D80
	public void .ctor() { }

	// RVA: 0x1234DD0 Offset: 0x12333D0 VA: 0x181234DD0
	public void .ctor(string s) { }

	// RVA: 0x117A9B0 Offset: 0x1178FB0 VA: 0x18117A9B0
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

	// RVA: 0x1D2C20 Offset: 0x1D2020 VA: 0x1801D2C20
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50
	internal bool get_HasValue() { }

	// RVA: 0x1D2C30 Offset: 0x1D2030 VA: 0x1801D2C30
	internal DataTable get_Table() { }

	// RVA: 0x1D27E0 Offset: 0x1D1BE0 VA: 0x1801D27E0
	internal void CheckState() { }

	// RVA: 0x1D27F0 Offset: 0x1D1BF0 VA: 0x1801D27F0
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x12359B0 Offset: 0x1233FB0 VA: 0x1812359B0
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1D2800 Offset: 0x1D1C00 VA: 0x1801D2800
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1D28F0 Offset: 0x1D1CF0 VA: 0x1801D28F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2870 Offset: 0x1D1C70 VA: 0x1801D2870 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D2860 Offset: 0x1D1C60 VA: 0x1801D2860
	internal bool Equals(DataKey value) { }

	// RVA: 0x1D2950 Offset: 0x1D1D50 VA: 0x1801D2950
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1D2960 Offset: 0x1D1D60 VA: 0x1801D2960
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1D2AE0 Offset: 0x1D1EE0 VA: 0x1801D2AE0
	internal Index GetSortIndex() { }

	// RVA: 0x1D2AD0 Offset: 0x1D1ED0 VA: 0x1801D2AD0
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1D2B50 Offset: 0x1D1F50 VA: 0x1801D2B50
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1D2C10 Offset: 0x1D2010 VA: 0x1801D2C10
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

	// RVA: 0x1238550 Offset: 0x1236B50 VA: 0x181238550
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1238850 Offset: 0x1236E50 VA: 0x181238850
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1238790 Offset: 0x1236D90 VA: 0x181238790
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1238890 Offset: 0x1236E90 VA: 0x181238890 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1238870 Offset: 0x1236E70 VA: 0x181238870
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1238870 Offset: 0x1236E70 VA: 0x181238870
	internal DataKey get_ChildKey() { }

	// RVA: 0x12388D0 Offset: 0x1236ED0 VA: 0x1812388D0 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1238920 Offset: 0x1236F20 VA: 0x181238920 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1237EB0 Offset: 0x12364B0 VA: 0x181237EB0
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1237990 Offset: 0x1235F90 VA: 0x181237990
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1237C10 Offset: 0x1236210 VA: 0x181237C10
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1237A70 Offset: 0x1236070 VA: 0x181237A70
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1238110 Offset: 0x1236710 VA: 0x181238110
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x12389D0 Offset: 0x1236FD0 VA: 0x1812389D0 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1238A10 Offset: 0x1237010 VA: 0x181238A10
	internal DataKey get_ParentKey() { }

	// RVA: 0x1238A30 Offset: 0x1237030 VA: 0x181238A30 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1238A80 Offset: 0x1237080 VA: 0x181238A80 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1236580 Offset: 0x1234B80 VA: 0x181236580
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x12367F0 Offset: 0x1234DF0 VA: 0x1812367F0
	internal void CheckNestedRelations() { }

	// RVA: 0x12389B0 Offset: 0x1236FB0 VA: 0x1812389B0 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1238AB0 Offset: 0x12370B0 VA: 0x181238AB0 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x12389F0 Offset: 0x1236FF0 VA: 0x1812389F0 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x12388B0 Offset: 0x1236EB0 VA: 0x1812388B0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1238940 Offset: 0x1236F40 VA: 0x181238940
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1238AA0 Offset: 0x12370A0 VA: 0x181238AA0
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1236CD0 Offset: 0x12352D0 VA: 0x181236CD0
	internal void CheckState() { }

	// RVA: 0x1236BB0 Offset: 0x12351B0 VA: 0x181236BB0
	protected void CheckStateForProperty() { }

	// RVA: 0x1237690 Offset: 0x1235C90 VA: 0x181237690
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1237000 Offset: 0x1235600 VA: 0x181237000
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1237F70 Offset: 0x1236570 VA: 0x181237F70
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1238020 Offset: 0x1236620 VA: 0x181238020
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1238130 Offset: 0x1236730 VA: 0x181238130
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1237CF0 Offset: 0x12362F0 VA: 0x181237CF0
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
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

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(string name);

	// RVA: 0xAE3290 Offset: 0xAE1890 VA: 0x180AE3290
	public void Add(DataRelation relation) { }

	// RVA: 0xAE2FE0 Offset: 0xAE15E0 VA: 0x180AE2FE0 Slot: 14
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xAE4300 Offset: 0xAE2900 VA: 0x180AE4300
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE43D0 Offset: 0xAE29D0 VA: 0x180AE43D0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE34D0 Offset: 0xAE1AD0 VA: 0x180AE34D0
	internal string AssignName() { }

	// RVA: 0xAE34F0 Offset: 0xAE1AF0 VA: 0x180AE34F0 Slot: 15
	public virtual void Clear() { }

	// RVA: 0xAE3730 Offset: 0xAE1D30 VA: 0x180AE3730 Slot: 16
	public virtual bool Contains(string name) { }

	// RVA: 0xAE3750 Offset: 0xAE1D50 VA: 0x180AE3750
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DataSet GetDataSet();

	// RVA: 0xAE3910 Offset: 0xAE1F10 VA: 0x180AE3910
	private string MakeName(int index) { }

	// RVA: 0xAE39A0 Offset: 0xAE1FA0 VA: 0x180AE39A0 Slot: 18
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3A50 Offset: 0xAE2050 VA: 0x180AE3A50 Slot: 19
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3B00 Offset: 0xAE2100 VA: 0x180AE3B00
	internal void RegisterName(string name) { }

	// RVA: 0xAE3F20 Offset: 0xAE2520 VA: 0x180AE3F20
	public void Remove(DataRelation relation) { }

	// RVA: 0xAE3CD0 Offset: 0xAE22D0 VA: 0x180AE3CD0
	public void RemoveAt(int index) { }

	// RVA: 0xAE3D60 Offset: 0xAE2360 VA: 0x180AE3D60 Slot: 20
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xAE40E0 Offset: 0xAE26E0 VA: 0x180AE40E0
	internal void UnregisterName(string name) { }

	// RVA: 0xAE4290 Offset: 0xAE2890 VA: 0x180AE4290
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

	// RVA: 0xAF71E0 Offset: 0xAF57E0 VA: 0x180AF71E0
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAF6E40 Offset: 0xAF5440 VA: 0x180AF6E40
	private void EnsureDataSet() { }

	// RVA: 0xAF6EA0 Offset: 0xAF54A0 VA: 0x180AF6EA0 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAF7440 Offset: 0xAF5A40 VA: 0x180AF7440 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAF7330 Offset: 0xAF5930 VA: 0x180AF7330 Slot: 13
	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF7290 Offset: 0xAF5890 VA: 0x180AF7290
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAF7540 Offset: 0xAF5B40 VA: 0x180AF7540
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAF6CC0 Offset: 0xAF52C0 VA: 0x180AF6CC0
	private void AddCache(DataRelation relation) { }

	// RVA: 0xAF6D20 Offset: 0xAF5320 VA: 0x180AF6D20 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAF6F00 Offset: 0xAF5500 VA: 0x180AF6F00
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xAF7010 Offset: 0xAF5610 VA: 0x180AF7010 Slot: 20
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

	// RVA: 0xAEB220 Offset: 0xAE9820 VA: 0x180AEB220
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAEAED0 Offset: 0xAE94D0 VA: 0x180AEAED0 Slot: 15
	public override void Clear() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAEB2C0 Offset: 0xAE98C0 VA: 0x180AEB2C0 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAEB3C0 Offset: 0xAE99C0 VA: 0x180AEB3C0 Slot: 13
	public override DataRelation get_Item(string name) { }

	// RVA: 0xAEA7F0 Offset: 0xAE8DF0 VA: 0x180AEA7F0 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAEAF20 Offset: 0xAE9520 VA: 0x180AEAF20 Slot: 20
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

	// RVA: 0xAE4650 Offset: 0xAE2C50 VA: 0x180AE4650
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal DataRelation get_Relation() { }

	// RVA: 0xAE46B0 Offset: 0xAE2CB0 VA: 0x180AE46B0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xAE4710 Offset: 0xAE2D10 VA: 0x180AE4710 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0xAE44A0 Offset: 0xAE2AA0 VA: 0x180AE44A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4530 Offset: 0xAE2B30 VA: 0x180AE4530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE4560 Offset: 0xAE2B60 VA: 0x180AE4560 Slot: 17
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

	// RVA: 0xAE94F0 Offset: 0xAE7AF0 VA: 0x180AE94F0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xAE9A90 Offset: 0xAE8090 VA: 0x180AE9A90
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xAEA5B0 Offset: 0xAE8BB0 VA: 0x180AEA5B0
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xAE95C0 Offset: 0xAE7BC0 VA: 0x180AE95C0
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	internal int get_RBTreeNodeId() { }

	// RVA: 0xAEA5C0 Offset: 0xAE8BC0 VA: 0x180AEA5C0
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xAE9AB0 Offset: 0xAE80B0 VA: 0x180AE9AB0
	public string get_RowError() { }

	// RVA: 0xAEA660 Offset: 0xAE8C60 VA: 0x180AEA660
	public void set_RowError(string value) { }

	// RVA: 0xAE86B0 Offset: 0xAE6CB0 VA: 0x180AE86B0
	private void RowErrorChanged() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal long get_rowID() { }

	// RVA: 0xAEA7B0 Offset: 0xAE8DB0 VA: 0x180AEA7B0
	internal void set_rowID(long value) { }

	// RVA: 0xAE9B00 Offset: 0xAE8100 VA: 0x180AE9B00
	public DataRowState get_RowState() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DataTable get_Table() { }

	// RVA: 0xAE9760 Offset: 0xAE7D60 VA: 0x180AE9760
	public object get_Item(int columnIndex) { }

	// RVA: 0xAEA560 Offset: 0xAE8B60 VA: 0x180AEA560
	public void set_Item(int columnIndex, object value) { }

	// RVA: 0xAE6840 Offset: 0xAE4E40 VA: 0x180AE6840
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xAE7650 Offset: 0xAE5C50 VA: 0x180AE7650
	internal int GetNestedParentCount() { }

	// RVA: 0xAE9920 Offset: 0xAE7F20 VA: 0x180AE9920
	public object get_Item(string columnName) { }

	// RVA: 0xAEA520 Offset: 0xAE8B20 VA: 0x180AEA520
	public void set_Item(string columnName, object value) { }

	// RVA: 0xAE9800 Offset: 0xAE7E00 VA: 0x180AE9800
	public object get_Item(DataColumn column) { }

	// RVA: 0xAEA110 Offset: 0xAE8710 VA: 0x180AEA110
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xAE99B0 Offset: 0xAE7FB0 VA: 0x180AE99B0
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xAE95D0 Offset: 0xAE7BD0 VA: 0x180AE95D0
	public object[] get_ItemArray() { }

	// RVA: 0xAE9CB0 Offset: 0xAE82B0 VA: 0x180AE9CB0
	public void set_ItemArray(object[] value) { }

	// RVA: 0xAE6250 Offset: 0xAE4850 VA: 0x180AE6250
	public void AcceptChanges() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE66E0 Offset: 0xAE4CE0 VA: 0x180AE66E0
	public void BeginEdit() { }

	// RVA: 0xAE6600 Offset: 0xAE4C00 VA: 0x180AE6600
	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE66F0 Offset: 0xAE4CF0 VA: 0x180AE66F0
	public void CancelEdit() { }

	// RVA: 0xAE6780 Offset: 0xAE4D80 VA: 0x180AE6780
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xAE6950 Offset: 0xAE4F50 VA: 0x180AE6950
	internal void CheckInTable() { }

	// RVA: 0xAE6E00 Offset: 0xAE5400 VA: 0x180AE6E00
	public void Delete() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0xAE6EE0 Offset: 0xAE54E0 VA: 0x180AE6EE0
	public void EndEdit() { }

	// RVA: 0xAE8700 Offset: 0xAE6D00 VA: 0x180AE8700
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xAE8790 Offset: 0xAE6D90 VA: 0x180AE8790
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xAE7190 Offset: 0xAE5790 VA: 0x180AE7190
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xAE6A00 Offset: 0xAE5000 VA: 0x180AE6A00
	public void ClearErrors() { }

	// RVA: 0xAE69A0 Offset: 0xAE4FA0 VA: 0x180AE69A0
	internal void ClearError(DataColumn column) { }

	// RVA: 0xAE95A0 Offset: 0xAE7BA0 VA: 0x180AE95A0
	public bool get_HasErrors() { }

	// RVA: 0xAE73D0 Offset: 0xAE59D0 VA: 0x180AE73D0
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xAE7000 Offset: 0xAE5600 VA: 0x180AE7000
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xAE7010 Offset: 0xAE5610 VA: 0x180AE7010
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7470 Offset: 0xAE5A70 VA: 0x180AE7470
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xAE79D0 Offset: 0xAE5FD0 VA: 0x180AE79D0
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xAE7860 Offset: 0xAE5E60 VA: 0x180AE7860
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7730 Offset: 0xAE5D30 VA: 0x180AE7730
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xAE7B60 Offset: 0xAE6160 VA: 0x180AE7B60
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xAE79E0 Offset: 0xAE5FE0 VA: 0x180AE79E0
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE72C0 Offset: 0xAE58C0 VA: 0x180AE72C0
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xAE7370 Offset: 0xAE5970 VA: 0x180AE7370
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xAE75A0 Offset: 0xAE5BA0 VA: 0x180AE75A0
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xAE7620 Offset: 0xAE5C20 VA: 0x180AE7620
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xAE7420 Offset: 0xAE5A20 VA: 0x180AE7420
	internal int GetCurrentRecordNo() { }

	// RVA: 0xAE7500 Offset: 0xAE5B00 VA: 0x180AE7500
	internal int GetDefaultRecord() { }

	// RVA: 0xAE7810 Offset: 0xAE5E10 VA: 0x180AE7810
	internal int GetOriginalRecordNo() { }

	// RVA: 0xAE7B70 Offset: 0xAE6170 VA: 0x180AE7B70
	private int GetProposedRecordNo() { }

	// RVA: 0xAE7BC0 Offset: 0xAE61C0 VA: 0x180AE7BC0
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xAE7570 Offset: 0xAE5B70 VA: 0x180AE7570
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xAE7D60 Offset: 0xAE6360 VA: 0x180AE7D60
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xAE7DB0 Offset: 0xAE63B0 VA: 0x180AE7DB0
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xAE7DE0 Offset: 0xAE63E0 VA: 0x180AE7DE0
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE7E80 Offset: 0xAE6480 VA: 0x180AE7E80
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xAE80F0 Offset: 0xAE66F0 VA: 0x180AE80F0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xAE7F40 Offset: 0xAE6540 VA: 0x180AE7F40
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE8120 Offset: 0xAE6720 VA: 0x180AE8120
	public bool IsNull(string columnName) { }

	// RVA: 0xAE81B0 Offset: 0xAE67B0 VA: 0x180AE81B0
	public void RejectChanges() { }

	// RVA: 0xAE8680 Offset: 0xAE6C80 VA: 0x180AE8680
	internal void ResetLastChangedColumn() { }

	// RVA: 0xAE8A50 Offset: 0xAE7050 VA: 0x180AE8A50
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xAE8BA0 Offset: 0xAE71A0 VA: 0x180AE8BA0
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xAE8FB0 Offset: 0xAE75B0 VA: 0x180AE8FB0
	internal void SetParentRowToDBNull() { }

	// RVA: 0xAE9340 Offset: 0xAE7940 VA: 0x180AE9340
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xAE6A60 Offset: 0xAE5060 VA: 0x180AE6A60
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

public sealed class DataRowBuilder // TypeDefIndex: 4209
{	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xAE4770 Offset: 0xAE2D70 VA: 0x180AE4770
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

	// RVA: 0xAE47C0 Offset: 0xAE2DC0 VA: 0x180AE47C0
	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4212
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0xAE5820 Offset: 0xAE3E20 VA: 0x180AE5820
	internal void .ctor(DataTable table) { }

	// RVA: 0xAE58F0 Offset: 0xAE3EF0 VA: 0x180AE58F0 Slot: 8
	public override int get_Count() { }

	// RVA: 0xAE5940 Offset: 0xAE3F40 VA: 0x180AE5940
	public DataRow get_Item(int index) { }

	// RVA: 0xAE4E70 Offset: 0xAE3470 VA: 0x180AE4E70
	public void Add(DataRow row) { }

	// RVA: 0xAE51E0 Offset: 0xAE37E0 VA: 0x180AE51E0
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xAE5480 Offset: 0xAE3A80 VA: 0x180AE5480
	public int IndexOf(DataRow row) { }

	// RVA: 0xAE4D60 Offset: 0xAE3360 VA: 0x180AE4D60
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xAE4EB0 Offset: 0xAE34B0 VA: 0x180AE4EB0
	public DataRow Add(object[] values) { }

	// RVA: 0xAE4F30 Offset: 0xAE3530 VA: 0x180AE4F30
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xAE4FF0 Offset: 0xAE35F0 VA: 0x180AE4FF0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xAE4FA0 Offset: 0xAE35A0 VA: 0x180AE4FA0
	internal void ArrayClear() { }

	// RVA: 0xAE5070 Offset: 0xAE3670 VA: 0x180AE5070
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xAE5170 Offset: 0xAE3770 VA: 0x180AE5170 Slot: 9
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xAE5100 Offset: 0xAE3700 VA: 0x180AE5100
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xAE5430 Offset: 0xAE3A30 VA: 0x180AE5430 Slot: 10
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xAE56B0 Offset: 0xAE3CB0 VA: 0x180AE56B0
	public void Remove(DataRow row) { }

	// RVA: 0xAE5510 Offset: 0xAE3B10 VA: 0x180AE5510
	public void RemoveAt(int index) { }

}

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4214
{	// Methods

	// RVA: 0xAE5A20 Offset: 0xAE4020 VA: 0x180AE5A20
	internal void .ctor() { }

	// RVA: 0xAE59A0 Offset: 0xAE3FA0 VA: 0x180AE59A0 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4215
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataRow r) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4216
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataTable table) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE5D30 Offset: 0xAE4330 VA: 0x180AE5D30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DataView get_DataView() { }

	// RVA: 0xAE61F0 Offset: 0xAE47F0 VA: 0x180AE61F0
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xAE5D60 Offset: 0xAE4360 VA: 0x180AE5D60
	internal int GetRecord() { }

	// RVA: 0xAE5DE0 Offset: 0xAE43E0 VA: 0x180AE5DE0
	internal bool HasRecord() { }

	// RVA: 0xAE5CB0 Offset: 0xAE42B0 VA: 0x180AE5CB0
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xAE5EF0 Offset: 0xAE44F0 VA: 0x180AE5EF0
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xAE5A60 Offset: 0xAE4060 VA: 0x180AE5A60
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xAE5C40 Offset: 0xAE4240 VA: 0x180AE5C40
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DataRow get_Row() { }

	// RVA: 0xAE5C50 Offset: 0xAE4250 VA: 0x180AE5C50 Slot: 9
	public void EndEdit() { }

	// RVA: 0xAE61C0 Offset: 0xAE47C0 VA: 0x180AE61C0
	public bool get_IsNew() { }

	// RVA: 0xAE5E60 Offset: 0xAE4460 VA: 0x180AE5E60
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xAE5FC0 Offset: 0xAE45C0 VA: 0x180AE5FC0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xAE6010 Offset: 0xAE4610 VA: 0x180AE6010 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xAE60C0 Offset: 0xAE46C0 VA: 0x180AE60C0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xAE6160 Offset: 0xAE4760 VA: 0x180AE6160
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

	// RVA: 0xAF5B30 Offset: 0xAF4130 VA: 0x180AF5B30
	public void .ctor() { }

	// RVA: 0xAF5DB0 Offset: 0xAF43B0 VA: 0x180AF5DB0
	public void .ctor(string dataSetName) { }

	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xAF6B80 Offset: 0xAF5180 VA: 0x180AF6B80
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xAF5B00 Offset: 0xAF4100 VA: 0x180AF5B00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF5DE0 Offset: 0xAF43E0 VA: 0x180AF5DE0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xAEE1B0 Offset: 0xAEC7B0 VA: 0x180AEE1B0 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xAF32C0 Offset: 0xAF18C0 VA: 0x180AF32C0
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAECEE0 Offset: 0xAEB4E0 VA: 0x180AECEE0
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAEC950 Offset: 0xAEAF50 VA: 0x180AEC950
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAEC5A0 Offset: 0xAEABA0 VA: 0x180AEC5A0
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAF3160 Offset: 0xAF1760 VA: 0x180AF3160
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEC740 Offset: 0xAEAD40 VA: 0x180AEC740
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF3AA0 Offset: 0xAF20A0 VA: 0x180AF3AA0
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAED0B0 Offset: 0xAEB6B0 VA: 0x180AED0B0
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEDEF0 Offset: 0xAEC4F0 VA: 0x180AEDEF0
	internal void FailedEnableConstraints() { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	public bool get_CaseSensitive() { }

	// RVA: 0xAF6030 Offset: 0xAF4630 VA: 0x180AF6030
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_EnforceConstraints() { }

	// RVA: 0xAF6400 Offset: 0xAF4A00 VA: 0x180AF6400
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xAED790 Offset: 0xAEBD90 VA: 0x180AED790
	internal void EnableConstraints() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_DataSetName() { }

	// RVA: 0xAF62C0 Offset: 0xAF48C0 VA: 0x180AF62C0
	public void set_DataSetName(string value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Namespace() { }

	// RVA: 0xAF6700 Offset: 0xAF4D00 VA: 0x180AF6700
	public void set_Namespace(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Prefix() { }

	// RVA: 0xAF6A60 Offset: 0xAF5060 VA: 0x180AF6A60
	public void set_Prefix(string value) { }

	// RVA: 0xAF5FB0 Offset: 0xAF45B0 VA: 0x180AF5FB0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public CultureInfo get_Locale() { }

	// RVA: 0xAF6570 Offset: 0xAF4B70 VA: 0x180AF6570
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xAF3FB0 Offset: 0xAF25B0 VA: 0x180AF3FB0
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DataRelationCollection get_Relations() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public DataTableCollection get_Tables() { }

	// RVA: 0xAEB4D0 Offset: 0xAE9AD0 VA: 0x180AEB4D0
	public void Clear() { }

	// RVA: 0xAEB6C0 Offset: 0xAE9CC0 VA: 0x180AEB6C0 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0xAEDDA0 Offset: 0xAEC3A0 VA: 0x180AEDDA0
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xAEE1E0 Offset: 0xAEC7E0 VA: 0x180AEE1E0
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xAEE300 Offset: 0xAEC900 VA: 0x180AEE300
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xAF0590 Offset: 0xAEEB90 VA: 0x180AF0590
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xAF05A0 Offset: 0xAEEBA0 VA: 0x180AF05A0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEED00 Offset: 0xAED300 VA: 0x180AEED00
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xAEEDC0 Offset: 0xAED3C0 VA: 0x180AEEDC0
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xAEF0E0 Offset: 0xAED6E0 VA: 0x180AEF0E0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xAEF2F0 Offset: 0xAED8F0 VA: 0x180AEF2F0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEF190 Offset: 0xAED790 VA: 0x180AEF190
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAF5700 Offset: 0xAF3D00 VA: 0x180AF5700
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0xAF10F0 Offset: 0xAEF6F0 VA: 0x180AF10F0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xAF1120 Offset: 0xAEF720 VA: 0x180AF1120
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEE480 Offset: 0xAECA80 VA: 0x180AEE480
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xAEE730 Offset: 0xAECD30 VA: 0x180AEE730
	private bool IsEmpty() { }

	// RVA: 0xAEF560 Offset: 0xAEDB60 VA: 0x180AEF560
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xAF1100 Offset: 0xAEF700 VA: 0x180AF1100
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xAF21D0 Offset: 0xAF07D0 VA: 0x180AF21D0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAF5910 Offset: 0xAF3F10 VA: 0x180AF5910
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xAEEB90 Offset: 0xAED190 VA: 0x180AEEB90
	public void Merge(DataSet dataSet) { }

	// RVA: 0xAEE960 Offset: 0xAECF60 VA: 0x180AEE960
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEEF00 Offset: 0xAED500 VA: 0x180AEEF00 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xAEEE80 Offset: 0xAED480 VA: 0x180AEEE80
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xAEEF70 Offset: 0xAED570 VA: 0x180AEEF70
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEEE60 Offset: 0xAED460 VA: 0x180AEEE60
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xAEEE40 Offset: 0xAED440 VA: 0x180AEEE40
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xAEEF40 Offset: 0xAED540 VA: 0x180AEEF40
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xAEF060 Offset: 0xAED660 VA: 0x180AEF060
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xAF4E40 Offset: 0xAF3440 VA: 0x180AF4E40
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xAF4C50 Offset: 0xAF3250 VA: 0x180AF4C50
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xAF2EC0 Offset: 0xAF14C0 VA: 0x180AF2EC0 Slot: 21
	public virtual void Reset() { }

	// RVA: 0xAF4E50 Offset: 0xAF3450 VA: 0x180AF4E50
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xAF5260 Offset: 0xAF3860 VA: 0x180AF5260
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xAF0E40 Offset: 0xAEF440 VA: 0x180AF0E40 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xAEDF40 Offset: 0xAEC540 VA: 0x180AEDF40
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xAF4920 Offset: 0xAF2F20 VA: 0x180AF4920 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xAF4AB0 Offset: 0xAF30B0 VA: 0x180AF4AB0 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xAF4C00 Offset: 0xAF3200 VA: 0x180AF4C00 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal string get_MainTableName() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_MainTableName(string value) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
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

	// RVA: 0xB0DCE0 Offset: 0xB0C2E0 VA: 0x180B0DCE0
	public void .ctor() { }

	// RVA: 0xB0E150 Offset: 0xB0C750 VA: 0x180B0E150
	public void .ctor(string tableName) { }

	// RVA: 0xB0E1C0 Offset: 0xB0C7C0 VA: 0x180B0E1C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB00D60 Offset: 0xAFF360 VA: 0x180B00D60 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB0A210 Offset: 0xB08810 VA: 0x180B0A210
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xAFC3F0 Offset: 0xAFA9F0 VA: 0x180AFC3F0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xB0AD10 Offset: 0xB09310 VA: 0x180B0AD10
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xAFD530 Offset: 0xAFBB30 VA: 0x180AFD530
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xB09A60 Offset: 0xB08060 VA: 0x180B09A60
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xAFB920 Offset: 0xAF9F20 VA: 0x180AFB920
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xB0A580 Offset: 0xB08B80 VA: 0x180B0A580
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFC700 Offset: 0xAFAD00 VA: 0x180AFC700
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xB0A6F0 Offset: 0xB08CF0 VA: 0x180B0A6F0
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFC880 Offset: 0xAFAE80 VA: 0x180AFC880
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFAED0 Offset: 0xAF94D0 VA: 0x180AFAED0
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xB01120 Offset: 0xAFF720 VA: 0x180B01120
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xAFAB40 Offset: 0xAF9140 VA: 0x180AFAB40
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xB0E350 Offset: 0xB0C950 VA: 0x180B0E350
	public bool get_CaseSensitive() { }

	// RVA: 0xB0F090 Offset: 0xB0D690 VA: 0x180B0F090
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xB0E340 Offset: 0xB0C940 VA: 0x180B0E340
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xB095B0 Offset: 0xB07BB0 VA: 0x180B095B0
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xB0D320 Offset: 0xB0B920 VA: 0x180B0D320
	internal void SuspendIndexEvents() { }

	// RVA: 0xB0E6E0 Offset: 0xB0CCE0 VA: 0x180B0E6E0
	private bool get_IsTypedDataTable() { }

	// RVA: 0xB0B8B0 Offset: 0xB09EB0 VA: 0x180B0B8B0
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xB0D160 Offset: 0xB0B760 VA: 0x180B0D160
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	internal bool get_SelfNested() { }

	// RVA: 0xB0E790 Offset: 0xB0CD90 VA: 0x180B0E790
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0xB0ED20 Offset: 0xB0D320 VA: 0x180B0ED20
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xB0FEA0 Offset: 0xB0E4A0 VA: 0x180B0FEA0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x7ED300 Offset: 0x7EB900 VA: 0x1807ED300
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x7ED380 Offset: 0x7EB980 VA: 0x1807ED380
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xB0E360 Offset: 0xB0C960 VA: 0x180B0E360
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public DataColumnCollection get_Columns() { }

	// RVA: 0xB0E430 Offset: 0xB0CA30 VA: 0x180B0E430
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xB09040 Offset: 0xB07640 VA: 0x180B09040
	private void ResetConstraints() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataSet get_DataSet() { }

	// RVA: 0xB0BB40 Offset: 0xB0A140 VA: 0x180B0BB40
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xB0E490 Offset: 0xB0CA90 VA: 0x180B0E490
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xB0E580 Offset: 0xB0CB80 VA: 0x180B0E580
	internal bool get_EnforceConstraints() { }

	// RVA: 0xB0F1D0 Offset: 0xB0D7D0 VA: 0x180B0F1D0
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xB0EFC0 Offset: 0xB0D5C0 VA: 0x180B0EFC0
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xB0FF20 Offset: 0xB0E520 VA: 0x180B0FF20
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xAFE630 Offset: 0xAFCC30 VA: 0x180AFE630
	internal void EnableConstraints() { }

	// RVA: 0xB0E5B0 Offset: 0xB0CBB0 VA: 0x180B0E5B0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xB0E630 Offset: 0xB0CC30 VA: 0x180B0E630
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public CultureInfo get_Locale() { }

	// RVA: 0xB0F210 Offset: 0xB0D810 VA: 0x180B0F210
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xB0BCB0 Offset: 0xB0A2B0 VA: 0x180B0BCB0
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xB0E880 Offset: 0xB0CE80 VA: 0x180B0E880
	public int get_MinimumCapacity() { }

	// RVA: 0xB0F640 Offset: 0xB0DC40 VA: 0x180B0F640
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xB0ED00 Offset: 0xB0D300 VA: 0x180B0ED00
	internal int get_RecordCapacity() { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	internal int get_ElementColumnCount() { }

	// RVA: 0xB0F170 Offset: 0xB0D770 VA: 0x180B0F170
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xB0EBD0 Offset: 0xB0D1D0 VA: 0x180B0EBD0
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xB0E860 Offset: 0xB0CE60 VA: 0x180B0E860
	internal bool get_MergingData() { }

	// RVA: 0xB0F620 Offset: 0xB0DC20 VA: 0x180B0F620
	internal void set_MergingData(bool value) { }

	// RVA: 0xB0E950 Offset: 0xB0CF50 VA: 0x180B0E950
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xB0EDB0 Offset: 0xB0D3B0 VA: 0x180B0EDB0
	internal bool get_SchemaLoading() { }

	// RVA: 0xAF7F30 Offset: 0xAF6530 VA: 0x180AF7F30
	internal void CacheNestedParent() { }

	// RVA: 0xB00300 Offset: 0xAFE900 VA: 0x180B00300
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xB0E960 Offset: 0xB0CF60 VA: 0x180B0E960
	internal int get_NestedParentsCount() { }

	// RVA: 0xB0ECA0 Offset: 0xB0D2A0 VA: 0x180B0ECA0
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xB0FA40 Offset: 0xB0E040 VA: 0x180B0FA40
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public DataRowCollection get_Rows() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_TableName() { }

	// RVA: 0xB0FF30 Offset: 0xB0E530 VA: 0x180B0FF30
	public void set_TableName(string value) { }

	// RVA: 0xB0E4F0 Offset: 0xB0CAF0 VA: 0x180B0E4F0
	internal string get_EncodedTableName() { }

	// RVA: 0xB00B10 Offset: 0xAFF110 VA: 0x180B00B10
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0xB0E8A0 Offset: 0xB0CEA0 VA: 0x180B0E8A0
	public string get_Namespace() { }

	// RVA: 0xB0F670 Offset: 0xB0DC70 VA: 0x180B0F670
	public void set_Namespace(string value) { }

	// RVA: 0xB02600 Offset: 0xB00C00 VA: 0x180B02600
	internal bool IsNamespaceInherited() { }

	// RVA: 0xAF8030 Offset: 0xAF6630 VA: 0x180AF8030
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xAF8940 Offset: 0xAF6F40 VA: 0x180AF8940
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xAF86F0 Offset: 0xAF6CF0 VA: 0x180AF86F0
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xAFE180 Offset: 0xAFC780 VA: 0x180AFE180
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_Prefix() { }

	// RVA: 0xB0F8F0 Offset: 0xB0DEF0 VA: 0x180B0F8F0
	public void set_Prefix(string value) { }

	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	internal DataColumn get_XmlText() { }

	// RVA: 0xB10440 Offset: 0xB0EA40 VA: 0x180B10440
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xB0E850 Offset: 0xB0CE50 VA: 0x180B0E850
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xB0F610 Offset: 0xB0DC10 VA: 0x180B0F610
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xB0E870 Offset: 0xB0CE70 VA: 0x180B0E870
	internal Decimal get_MinOccurs() { }

	// RVA: 0xB0F630 Offset: 0xB0DC30 VA: 0x180B0F630
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xB0BC10 Offset: 0xB0A210 VA: 0x180B0BC10
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xB00180 Offset: 0xAFE780 VA: 0x180B00180
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xB00210 Offset: 0xAFE810 VA: 0x180B00210
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xB0C270 Offset: 0xB0A870 VA: 0x180B0C270
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xB026C0 Offset: 0xB00CC0 VA: 0x180B026C0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xAF75E0 Offset: 0xAF5BE0 VA: 0x180AF75E0
	public void AcceptChanges() { }

	// RVA: 0xAFB260 Offset: 0xAF9860 VA: 0x180AFB260 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xAFA520 Offset: 0xAF8B20 VA: 0x180AFA520 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0xAFA530 Offset: 0xAF8B30 VA: 0x180AFA530
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xB01780 Offset: 0xAFFD80 VA: 0x180B01780
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xAF9490 Offset: 0xAF7A90 VA: 0x180AF9490
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xAF9850 Offset: 0xAF7E50 VA: 0x180AF9850
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0xAF79D0 Offset: 0xAF5FD0 VA: 0x180AF79D0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xB01C70 Offset: 0xB00270 VA: 0x180B01C70
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xB020A0 Offset: 0xB006A0 VA: 0x180B020A0
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0xAF8C40 Offset: 0xAF7240 VA: 0x180AF8C40
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xAF8C70 Offset: 0xAF7270 VA: 0x180AF8C70
	public void Clear() { }

	// RVA: 0xAF8C80 Offset: 0xAF7280 VA: 0x180AF8C80
	internal void Clear(bool clearAll) { }

	// RVA: 0xAF7F60 Offset: 0xAF6560 VA: 0x180AF7F60
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xAFA710 Offset: 0xAF8D10 VA: 0x180AFA710
	internal void CommitRow(DataRow row) { }

	// RVA: 0xAFA9E0 Offset: 0xAF8FE0 VA: 0x180AFA9E0
	internal int Compare(string s1, string s2) { }

	// RVA: 0xAFA850 Offset: 0xAF8E50 VA: 0x180AFA850
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xB01A00 Offset: 0xB00000 VA: 0x180B01A00
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xB02610 Offset: 0xB00C10 VA: 0x180B02610
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xAFB890 Offset: 0xAF9E90 VA: 0x180AFB890
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xB00590 Offset: 0xAFEB90 VA: 0x180B00590
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xB006B0 Offset: 0xAFECB0 VA: 0x180B006B0
	internal void FreeRecord(ref int record) { }

	// RVA: 0xB00AC0 Offset: 0xAFF0C0 VA: 0x180B00AC0
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xB008F0 Offset: 0xAFEEF0 VA: 0x180B008F0
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x77AB40 Offset: 0x779140 VA: 0x18077AB40
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0xB01670 Offset: 0xAFFC70 VA: 0x180B01670
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xB01C90 Offset: 0xB00290 VA: 0x180B01C90
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0xB032B0 Offset: 0xB018B0 VA: 0x180B032B0
	internal int NewRecord() { }

	// RVA: 0xB03890 Offset: 0xB01E90 VA: 0x180B03890
	internal int NewUninitializedRecord() { }

	// RVA: 0xB03030 Offset: 0xB01630 VA: 0x180B03030
	internal int NewRecordFromArray(object[] value) { }

	// RVA: 0xB03350 Offset: 0xB01950 VA: 0x180B03350
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xB02FC0 Offset: 0xB015C0 VA: 0x180B02FC0
	internal DataRow NewEmptyRow() { }

	// RVA: 0xB038B0 Offset: 0xB01EB0 VA: 0x180B038B0
	private DataRow NewUninitializedRow() { }

	// RVA: 0xB03790 Offset: 0xB01D90 VA: 0x180B03790
	public DataRow NewRow() { }

	// RVA: 0xAFAFC0 Offset: 0xAF95C0 VA: 0x180AFAFC0
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xB03590 Offset: 0xB01B90 VA: 0x180B03590
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xB036E0 Offset: 0xB01CE0 VA: 0x180B036E0
	internal DataRow NewRow(int record) { }

	// RVA: 0xB03610 Offset: 0xB01C10 VA: 0x180B03610 Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xB01480 Offset: 0xAFFA80 VA: 0x180B01480 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0xB03440 Offset: 0xB01A40 VA: 0x180B03440
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xB0E910 Offset: 0xB0CF10 VA: 0x180B0E910
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xB039B0 Offset: 0xB01FB0 VA: 0x180B039B0 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xB038F0 Offset: 0xB01EF0 VA: 0x180B038F0 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xB03A70 Offset: 0xB02070 VA: 0x180B03A70 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xB03B30 Offset: 0xB02130 VA: 0x180B03B30
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xB03B50 Offset: 0xB02150 VA: 0x180B03B50
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB03CC0 Offset: 0xB022C0 VA: 0x180B03CC0
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB03C00 Offset: 0xB02200 VA: 0x180B03C00 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xB03D70 Offset: 0xB02370 VA: 0x180B03D70 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xB03EF0 Offset: 0xB024F0 VA: 0x180B03EF0 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xB03E30 Offset: 0xB02430 VA: 0x180B03E30 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xB03FB0 Offset: 0xB025B0 VA: 0x180B03FB0 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xB04070 Offset: 0xB02670 VA: 0x180B04070 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xB04130 Offset: 0xB02730 VA: 0x180B04130 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xB041F0 Offset: 0xB027F0 VA: 0x180B041F0
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xB04530 Offset: 0xB02B30 VA: 0x180B04530
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xB083F0 Offset: 0xB069F0 VA: 0x180B083F0
	internal void RecordChanged(int record) { }

	// RVA: 0xB08560 Offset: 0xB06B60 VA: 0x180B08560
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xB08740 Offset: 0xB06D40 VA: 0x180B08740
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xB088D0 Offset: 0xB06ED0 VA: 0x180B088D0
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xB08B60 Offset: 0xB07160 VA: 0x180B08B60
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB01AB0 Offset: 0xB000B0 VA: 0x180B01AB0
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB0D170 Offset: 0xB0B770 VA: 0x180B0D170
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xB08D80 Offset: 0xB07380 VA: 0x180B08D80
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xB09250 Offset: 0xB07850 VA: 0x180B09250 Slot: 30
	public virtual void Reset() { }

	// RVA: 0xB09060 Offset: 0xB07660 VA: 0x180B09060
	internal void ResetIndexes() { }

	// RVA: 0xB09070 Offset: 0xB07670 VA: 0x180B09070
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xB098F0 Offset: 0xB07EF0 VA: 0x180B098F0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xB045B0 Offset: 0xB02BB0 VA: 0x180B045B0
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB047F0 Offset: 0xB02DF0 VA: 0x180B047F0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB04A80 Offset: 0xB03080 VA: 0x180B04A80
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xB09950 Offset: 0xB07F50 VA: 0x180B09950
	public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xB0CC20 Offset: 0xB0B220 VA: 0x180B0CC20
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0xB0C330 Offset: 0xB0A930 VA: 0x180B0C330
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0xB0CCE0 Offset: 0xB0B2E0 VA: 0x180B0CCE0
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xB098D0 Offset: 0xB07ED0 VA: 0x180B098D0
	private void RestoreShadowIndexes() { }

	// RVA: 0xB0D080 Offset: 0xB0B680 VA: 0x180B0D080
	private void SetShadowIndexes() { }

	// RVA: 0xB0D0E0 Offset: 0xB0B6E0 VA: 0x180B0D0E0
	internal void ShadowIndexCopy() { }

	// RVA: 0xB0D500 Offset: 0xB0BB00 VA: 0x180B0D500 Slot: 3
	public override string ToString() { }

	// RVA: 0xAF7CF0 Offset: 0xAF62F0 VA: 0x180AF7CF0
	public void BeginLoadData() { }

	// RVA: 0xAFEB40 Offset: 0xAFD140 VA: 0x180AFEB40
	public void EndLoadData() { }

	// RVA: 0xB0D5D0 Offset: 0xB0BBD0 VA: 0x180B0D5D0
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xAF7A10 Offset: 0xAF6010 VA: 0x180AF7A10
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xAF7A00 Offset: 0xAF6000 VA: 0x180AF7A00
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xAF7910 Offset: 0xAF5F10 VA: 0x180AF7910
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xB0D5B0 Offset: 0xB0BBB0 VA: 0x180B0D5B0
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xB00E50 Offset: 0xAFF450 VA: 0x180B00E50
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xB0EFD0 Offset: 0xB0D5D0 VA: 0x180B0EFD0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x7019B0 Offset: 0x6FFFB0 VA: 0x1807019B0
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xB02D70 Offset: 0xB01370 VA: 0x180B02D70
	public void Merge(DataTable table) { }

	// RVA: 0xB02D90 Offset: 0xB01390 VA: 0x180B02D90
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xB0D960 Offset: 0xB0BF60 VA: 0x180B0D960
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xAF8640 Offset: 0xAF6C40 VA: 0x180AF8640
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xAF82E0 Offset: 0xAF68E0 VA: 0x180AF82E0
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0xB0D600 Offset: 0xB0BC00 VA: 0x180B0D600
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xB08350 Offset: 0xB06950 VA: 0x180B08350
	public XmlReadMode ReadXml(TextReader reader) { }

	// RVA: 0xB09550 Offset: 0xB07B50 VA: 0x180B09550
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xB02420 Offset: 0xB00A20 VA: 0x180B02420
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xB075A0 Offset: 0xB05BA0 VA: 0x180B075A0
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB06790 Offset: 0xB04D90 VA: 0x180B06790
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAEF0E0 Offset: 0xAED6E0 VA: 0x180AEF0E0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xB04C40 Offset: 0xB03240 VA: 0x180B04C40
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAEED00 Offset: 0xAED300 VA: 0x180AEED00
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xB04E00 Offset: 0xB03400 VA: 0x180B04E00
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xB04CB0 Offset: 0xB032B0 VA: 0x180B04CB0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB056D0 Offset: 0xB03CD0 VA: 0x180B056D0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAFB600 Offset: 0xAF9C00 VA: 0x180AFB600
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0xAFB2F0 Offset: 0xAF98F0 VA: 0x180AFB2F0
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0xB006D0 Offset: 0xAFECD0 VA: 0x180B006D0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xB0D3C0 Offset: 0xB0B9C0 VA: 0x180B0D3C0 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xB014E0 Offset: 0xAFFAE0 VA: 0x180B014E0 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xB0D3E0 Offset: 0xB0B9E0 VA: 0x180B0D3E0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xB0D4B0 Offset: 0xB0BAB0 VA: 0x180B0D4B0 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xB06770 Offset: 0xB04D70 VA: 0x180B06770 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xB0ED30 Offset: 0xB0D330 VA: 0x180B0ED30
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xB0EBC0 Offset: 0xB0D1C0 VA: 0x180B0EBC0
	internal int get_ObjectID() { }

	// RVA: 0xAF7850 Offset: 0xAF5E50 VA: 0x180AF7850
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xB08AE0 Offset: 0xB070E0 VA: 0x180B08AE0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xAFF700 Offset: 0xAFDD00 VA: 0x180AFF700
	internal void EvaluateExpressions() { }

	// RVA: 0xAFFC30 Offset: 0xAFE230 VA: 0x180AFFC30
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0xAFF990 Offset: 0xAFDF90 VA: 0x180AFF990
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xAFED70 Offset: 0xAFD370 VA: 0x180AFED70
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xAFEEA0 Offset: 0xAFD4A0 VA: 0x180AFEEA0
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

}

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4224
{	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1EF210 Offset: 0x1EE610 VA: 0x1801EF210
	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4225
{	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1EF0D0 Offset: 0x1EE4D0 VA: 0x1801EF0D0
	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4226
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CFC60 Offset: 0x13CE260 VA: 0x1813CFC60
	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x13D22B0 Offset: 0x13D08B0 VA: 0x1813D22B0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int get_ObjectID() { }

	// RVA: 0x13D2600 Offset: 0x13D0C00 VA: 0x1813D2600
	public DataTable get_Item(int index) { }

	// RVA: 0x13D2500 Offset: 0x13D0B00 VA: 0x1813D2500
	public DataTable get_Item(string name) { }

	// RVA: 0x13D23E0 Offset: 0x13D09E0 VA: 0x1813D23E0
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x13D1370 Offset: 0x13CF970 VA: 0x1813D1370
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x13D1200 Offset: 0x13CF800 VA: 0x1813D1200
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x13CFCD0 Offset: 0x13CE2D0 VA: 0x1813CFCD0
	public void Add(DataTable table) { }

	// RVA: 0x13CFF30 Offset: 0x13CE530 VA: 0x1813CFF30
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x13CFF60 Offset: 0x13CE560 VA: 0x1813CFF60
	internal string AssignName() { }

	// RVA: 0x13D0020 Offset: 0x13CE620 VA: 0x1813D0020
	private void BaseAdd(DataTable table) { }

	// RVA: 0x13D0240 Offset: 0x13CE840 VA: 0x1813D0240
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x13D0400 Offset: 0x13CEA00 VA: 0x1813D0400
	private void BaseRemove(DataTable table) { }

	// RVA: 0x13D0600 Offset: 0x13CEC00 VA: 0x1813D0600
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x13D0A80 Offset: 0x13CF080 VA: 0x1813D0A80
	public void Clear() { }

	// RVA: 0x13D1060 Offset: 0x13CF660 VA: 0x1813D1060
	public bool Contains(string name) { }

	// RVA: 0x13D0EA0 Offset: 0x13CF4A0 VA: 0x1813D0EA0
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x13D1080 Offset: 0x13CF680 VA: 0x1813D1080
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x13D14C0 Offset: 0x13CFAC0 VA: 0x1813D14C0
	public int IndexOf(DataTable table) { }

	// RVA: 0x13D15C0 Offset: 0x13CFBC0 VA: 0x1813D15C0
	public int IndexOf(string tableName) { }

	// RVA: 0x13D15E0 Offset: 0x13CFBE0 VA: 0x1813D15E0
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x13D20D0 Offset: 0x13D06D0 VA: 0x1813D20D0
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x13D1860 Offset: 0x13CFE60 VA: 0x1813D1860
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x13D16A0 Offset: 0x13CFCA0 VA: 0x1813D16A0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x13D1AA0 Offset: 0x13D00A0 VA: 0x1813D1AA0
	private string MakeName(int index) { }

	// RVA: 0x13D1B30 Offset: 0x13D0130 VA: 0x1813D1B30
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D1BE0 Offset: 0x13D01E0 VA: 0x1813D1BE0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D1C90 Offset: 0x13D0290 VA: 0x1813D1C90
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x13D1F10 Offset: 0x13D0510 VA: 0x1813D1F10
	public void Remove(DataTable table) { }

	// RVA: 0x13D2130 Offset: 0x13D0730 VA: 0x1813D2130
	internal void UnregisterName(string name) { }

}

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13D26E0 Offset: 0x13D0CE0 VA: 0x1813D26E0
	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4230
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x13D6C50 Offset: 0x13D5250 VA: 0x1813D6C50
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool get_AllowDelete() { }

	// RVA: 0x1086850 Offset: 0x1084E50 VA: 0x181086850
	public bool get_AllowNew() { }

	// RVA: 0x13D6F70 Offset: 0x13D5570 VA: 0x1813D6F70 Slot: 22
	public int get_Count() { }

	// RVA: 0x13D6F40 Offset: 0x13D5540 VA: 0x1813D6F40
	private int get_CountFromIndex() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x7AE600 Offset: 0x7ACC00 VA: 0x1807AE600
	protected bool get_IsOpen() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x13D6FC0 Offset: 0x13D55C0 VA: 0x1813D6FC0
	public string get_Sort() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public DataTable get_Table() { }

	// RVA: 0x13D67C0 Offset: 0x13D4DC0 VA: 0x1813D67C0 Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x13D6820 Offset: 0x13D4E20 VA: 0x1813D6820 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x13D67C0 Offset: 0x13D4DC0 VA: 0x1813D67C0
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x13D3F70 Offset: 0x13D2570 VA: 0x1813D3F70 Slot: 25
	public virtual DataRowView AddNew() { }

	// RVA: 0x13D4230 Offset: 0x13D2830 VA: 0x1813D4230
	private void CheckOpen() { }

	// RVA: 0x13D44C0 Offset: 0x13D2AC0 VA: 0x1813D44C0
	protected void Close() { }

	// RVA: 0x13D4970 Offset: 0x13D2F70 VA: 0x1813D4970 Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13D4760 Offset: 0x13D2D60 VA: 0x1813D4760
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x13D4AD0 Offset: 0x13D30D0 VA: 0x1813D4AD0
	public void Delete(int index) { }

	// RVA: 0x13D4B00 Offset: 0x13D3100 VA: 0x1813D4B00
	internal void Delete(DataRow row) { }

	// RVA: 0x13D4CE0 Offset: 0x13D32E0 VA: 0x1813D4CE0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13D4D40 Offset: 0x13D3340 VA: 0x1813D4D40
	internal void FinishAddNew(bool success) { }

	// RVA: 0x13D4F10 Offset: 0x13D3510 VA: 0x1813D4F10 Slot: 24
	public IEnumerator GetEnumerator() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x13D6470 Offset: 0x13D4A70 VA: 0x1813D6470 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x13D6510 Offset: 0x13D4B10 VA: 0x1813D6510 Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x13D6550 Offset: 0x13D4B50 VA: 0x1813D6550 Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x13D65E0 Offset: 0x13D4BE0 VA: 0x1813D65E0 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x13D5460 Offset: 0x13D3A60 VA: 0x1813D5460
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x13D5400 Offset: 0x13D3A00 VA: 0x1813D5400
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x13D6660 Offset: 0x13D4C60 VA: 0x1813D6660 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13D66A0 Offset: 0x13D4CA0 VA: 0x1813D66A0 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x13D4AD0 Offset: 0x13D30D0 VA: 0x1813D4AD0 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 26
	internal virtual IFilter GetFilter() { }

	// RVA: 0x13D4FB0 Offset: 0x13D35B0 VA: 0x1813D4FB0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x13D5140 Offset: 0x13D3740 VA: 0x1813D5140
	internal DataRow GetRow(int index) { }

	// RVA: 0x13D5070 Offset: 0x13D3670 VA: 0x1813D5070
	private DataRowView GetRowView(int record) { }

	// RVA: 0x13D50E0 Offset: 0x13D36E0 VA: 0x1813D50E0
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x13D5380 Offset: 0x13D3980 VA: 0x1813D5380 Slot: 27
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x13D52B0 Offset: 0x13D38B0 VA: 0x1813D52B0
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x13D55C0 Offset: 0x13D3BC0 VA: 0x1813D55C0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D5870 Offset: 0x13D3E70 VA: 0x1813D5870 Slot: 28
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D6000 Offset: 0x13D4600 VA: 0x1813D6000
	protected void Reset() { }

	// RVA: 0x13D5DD0 Offset: 0x13D43D0 VA: 0x1813D5DD0
	internal void ResetRowViewCache() { }

	// RVA: 0x13D6030 Offset: 0x13D4630 VA: 0x1813D6030
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D6450 Offset: 0x13D4A50 VA: 0x1813D6450 Slot: 29
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x13D6240 Offset: 0x13D4840 VA: 0x1813D6240
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x13D6BC0 Offset: 0x13D51C0 VA: 0x1813D6BC0
	protected void UpdateIndex() { }

	// RVA: 0x13D6BE0 Offset: 0x13D51E0 VA: 0x1813D6BE0 Slot: 30
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x13D6860 Offset: 0x13D4E60 VA: 0x1813D6860
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x13D4280 Offset: 0x13D2880 VA: 0x1813D4280
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D5B90 Offset: 0x13D4190 VA: 0x1813D5B90
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D4520 Offset: 0x13D2B20 VA: 0x1813D4520 Slot: 31
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D4500 Offset: 0x13D2B00 VA: 0x1813D4500
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x107A070 Offset: 0x1078670 VA: 0x18107A070
	internal int get_ObjectID() { }

	// RVA: 0x13D6BF0 Offset: 0x13D51F0 VA: 0x1813D6BF0
	private static void .cctor() { }

}

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4233
{	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x135AD

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13CFBD0 Offset: 0x13CE1D0 VA: 0x1813CFBD0 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x13CFBE0 Offset: 0x13CE1E0 VA: 0x1813CFBE0 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x13CFC00 Offset: 0x13CE200 VA: 0x1813CFC00
	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4234
{	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x13D3B80 Offset: 0x13D2180 VA: 0x1813D3B80
	internal void .ctor(DataView dv) { }

	// RVA: 0x13D2E80 Offset: 0x13D1480 VA: 0x1813D2E80
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D32F0 Offset: 0x13D18F0 VA: 0x1813D32F0
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D2F90 Offset: 0x13D1590 VA: 0x1813D2F90
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D3200 Offset: 0x13D1800 VA: 0x1813D3200
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D3080 Offset: 0x13D1680 VA: 0x1813D3080
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D3640 Offset: 0x13D1C40 VA: 0x1813D3640
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x13D38F0 Offset: 0x13D1EF0 VA: 0x1813D38F0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x13D3900 Offset: 0x13D1F00 VA: 0x1813D3900
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x13D33E0 Offset: 0x13D19E0 VA: 0x1813D33E0
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x13D3810 Offset: 0x13D1E10 VA: 0x1813D3810
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x13D2F70 Offset: 0x13D1570 VA: 0x1813D2F70
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x13D34B0 Offset: 0x13D1AB0 VA: 0x1813D34B0
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

	// RVA: 0x13D3C10 Offset: 0x13D2210 VA: 0x1813D3C10
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

	// RVA: 0x13D3EF0 Offset: 0x13D24F0 VA: 0x1813D3EF0
	internal void .ctor() { }

	// RVA: 0xBA1D40 Offset: 0xBA0340 VA: 0x180BA1D40
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1238110 Offset: 0x1236710 VA: 0x181238110
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D3ED0 Offset: 0x13D24D0 VA: 0x1813D3ED0
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_RowFilter() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
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

	// RVA: 0x13D3CA0 Offset: 0x13D22A0 VA: 0x1813D3CA0 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x13D3E10 Offset: 0x13D2410 VA: 0x1813D3E10 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x13D3C70 Offset: 0x13D2270 VA: 0x1813D3C70
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

	// RVA: 0x1235840 Offset: 0x1233E40 VA: 0x181235840
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x12355E0 Offset: 0x1233BE0 VA: 0x1812355E0
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x1235860 Offset: 0x1233E60 VA: 0x181235860
	internal string get_Expression() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExpressionNode get_ExpressionNode() { }

	// RVA: 0x12358A0 Offset: 0x1233EA0 VA: 0x1812358A0
	internal bool get_HasValue() { }

	// RVA: 0x1234DF0 Offset: 0x12333F0 VA: 0x181234DF0
	internal void Bind(DataTable table) { }

	// RVA: 0x1234F20 Offset: 0x1233520 VA: 0x181234F20
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x1235140 Offset: 0x1233740 VA: 0x181235140
	internal object Evaluate() { }

	// RVA: 0x1234F40 Offset: 0x1233540 VA: 0x181234F40
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1235190 Offset: 0x1233790 VA: 0x181235190 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1235270 Offset: 0x1233870 VA: 0x181235270
	internal bool IsTableAggregate() { }

	// RVA: 0x1235290 Offset: 0x1233890 VA: 0x181235290
	internal static bool IsUnknown(object value) { }

	// RVA: 0x1235150 Offset: 0x1233750 VA: 0x181235150
	internal bool HasLocalAggregate() { }

	// RVA: 0x1235170 Offset: 0x1233770 VA: 0x181235170
	internal bool HasRemoteAggregate() { }

	// RVA: 0x12352F0 Offset: 0x12338F0 VA: 0x1812352F0
	internal static bool ToBoolean(object value) { }

}

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4333
{	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x13D28F0 Offset: 0x13D0EF0 VA: 0x1813D28F0
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x13D2DA0 Offset: 0x13D13A0 VA: 0x1813D2DA0
	private void .ctor(XmlWriter w) { }

	// RVA: 0x13D2DD0 Offset: 0x13D13D0 VA: 0x1813D2DD0
	internal Stream get_BaseStream() { }

	// RVA: 0x13D2CB0 Offset: 0x13D12B0 VA: 0x1813D2CB0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x13D2C80 Offset: 0x13D1280 VA: 0x1813D2C80 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13D2B30 Offset: 0x13D1130 VA: 0x1813D2B30 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x13D2AD0 Offset: 0x13D10D0 VA: 0x1813D2AD0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13D2CE0 Offset: 0x13D12E0 VA: 0x1813D2CE0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131A810 Offset: 0x1318E10 VA: 0x18131A810 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13D2B90 Offset: 0x13D1190 VA: 0x1813D2B90 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x13D2C50 Offset: 0x13D1250 VA: 0x1813D2C50 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x13D2B00 Offset: 0x13D1100 VA: 0x1813D2B00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x13D2A10 Offset: 0x13D1010 VA: 0x1813D2A10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13D2AA0 Offset: 0x13D10A0 VA: 0x1813D2AA0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13D2BC0 Offset: 0x13D11C0 VA: 0x1813D2BC0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13D2B60 Offset: 0x13D1160 VA: 0x1813D2B60 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x13D2A40 Offset: 0x13D1040 VA: 0x1813D2A40 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x13D2D70 Offset: 0x13D1370 VA: 0x1813D2D70 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13D2D10 Offset: 0x13D1310 VA: 0x1813D2D10 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x13D2D40 Offset: 0x13D1340 VA: 0x1813D2D40 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13D2A70 Offset: 0x13D1070 VA: 0x1813D2A70 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13D2BF0 Offset: 0x13D11F0 VA: 0x1813D2BF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13D2C20 Offset: 0x13D1220 VA: 0x1813D2C20 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x13D29B0 Offset: 0x13D0FB0 VA: 0x1813D29B0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x13D29E0 Offset: 0x13D0FE0 VA: 0x1813D29E0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x13D2E50 Offset: 0x13D1450 VA: 0x1813D2E50 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x13D28C0 Offset: 0x13D0EC0 VA: 0x1813D28C0 Slot: 28
	public override void Close() { }

	// RVA: 0x13D2950 Offset: 0x13D0F50 VA: 0x1813D2950 Slot: 29
	public override void Flush() { }

	// RVA: 0x13D2980 Offset: 0x13D0F80 VA: 0x1813D2980 Slot: 30
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

	// RVA: 0x13D2750 Offset: 0x13D0D50 VA: 0x1813D2750
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x13D27F0 Offset: 0x13D0DF0 VA: 0x1813D27F0
	private void .ctor(XmlReader input) { }

	// RVA: 0x132F9D0 Offset: 0x132DFD0 VA: 0x18132F9D0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB191B0 Offset: 0xB177B0 VA: 0x180B191B0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8DB0 Offset: 0xBC73B0 VA: 0x180BC8DB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8D50 Offset: 0xBC7350 VA: 0x180BC8D50 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8EE0 Offset: 0xBC74E0 VA: 0x180BC8EE0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8C00 Offset: 0xBC7200 VA: 0x180BC8C00 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8CC0 Offset: 0xBC72C0 VA: 0x180BC8CC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC8C90 Offset: 0xBC7290 VA: 0x180BC8C90 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8450 Offset: 0xBC6A50 VA: 0x180BC8450 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC84B0 Offset: 0xBC6AB0 VA: 0x180BC84B0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8550 Offset: 0xBC6B50 VA: 0x180BC8550 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC8520 Offset: 0xBC6B20 VA: 0x180BC8520 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC85B0 Offset: 0xBC6BB0 VA: 0x180BC85B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC85E0 Offset: 0xBC6BE0 VA: 0x180BC85E0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8580 Offset: 0xBC6B80 VA: 0x180BC8580 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8610 Offset: 0xBC6C10 VA: 0x180BC8610 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8670 Offset: 0xBC6C70 VA: 0x180BC8670 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC8C60 Offset: 0xBC7260 VA: 0x180BC8C60 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F100 Offset: 0xB9D700 VA: 0x180B9F100 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC86D0 Offset: 0xBC6CD0 VA: 0x180BC86D0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8740 Offset: 0xBC6D40 VA: 0x180BC8740 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x13D2890 Offset: 0x13D0E90 VA: 0x1813D2890 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC86A0 Offset: 0xBC6CA0 VA: 0x180BC86A0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x13D2860 Offset: 0x13D0E60 VA: 0x1813D2860 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xB9EB30 Offset: 0xB9D130 VA: 0x180B9EB30 Slot: 42
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

	// RVA: 0x127EF20 Offset: 0x127D520 VA: 0x18127EF20
	protected void .ctor() { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40 Slot: 12
	public virtual ConflictOption get_ConflictOption() { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940 Slot: 13
	public virtual CatalogLocation get_CatalogLocation() { }

	// RVA: 0x127EFF0 Offset: 0x127D5F0 VA: 0x18127EFF0 Slot: 14
	public virtual string get_CatalogSeparator() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public DbDataAdapter get_DataAdapter() { }

	// RVA: 0x127F130 Offset: 0x127D730 VA: 0x18127F130
	public void set_DataAdapter(DbDataAdapter value) { }

	// RVA: 0x107A120 Offset: 0x1078720 VA: 0x18107A120
	internal int get_ParameterNameMaxLength() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	internal string get_ParameterNamePattern() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	private string get_QuotedBaseTableName() { }

	// RVA: 0x127F040 Offset: 0x127D640 VA: 0x18127F040 Slot: 15
	public virtual string get_QuotePrefix() { }

	// RVA: 0x127F1D0 Offset: 0x127D7D0 VA: 0x18127F1D0 Slot: 16
	public virtual void set_QuotePrefix(string value) { }

	// RVA: 0x127F090 Offset: 0x127D690 VA: 0x18127F090 Slot: 17
	public virtual string get_QuoteSuffix() { }

	// RVA: 0x127F260 Offset: 0x127D860 VA: 0x18127F260 Slot: 18
	public virtual void set_QuoteSuffix(string value) { }

	// RVA: 0x127F0E0 Offset: 0x127D6E0 VA: 0x18127F0E0 Slot: 19
	public virtual string get_SchemaSeparator() { }

	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	public bool get_SetAllValues() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	private DbCommand get_InsertCommand() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_InsertCommand(DbCommand value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	private DbCommand get_UpdateCommand() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	private DbCommand get_DeleteCommand() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127B180 Offset: 0x1279780 VA: 0x18127B180
	private void BuildCache(bool closeConnection, DataRow dataRow, bool useColumnsForParameterNames) { }

	// RVA: 0x127DC90 Offset: 0x127C290 VA: 0x18127DC90 Slot: 20
	protected virtual DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x127B8E0 Offset: 0x1279EE0 VA: 0x18127B8E0
	private void BuildInformation(DataTable schemaTable) { }

	// RVA: 0x127B740 Offset: 0x1279D40 VA: 0x18127B740
	private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127C1E0 Offset: 0x127A7E0 VA: 0x18127C1E0
	private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127C750 Offset: 0x127AD50 VA: 0x18127C750
	private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127CBE0 Offset: 0x127B1E0 VA: 0x18127CBE0
	private int BuildWhereClause(DataTableMapping mappings, DataRow dataRow, StringBuilder builder, DbCommand command, int parameterCount, bool isUpdate) { }

	// RVA: 0x127D210 Offset: 0x127B810 VA: 0x18127D210
	private string CreateParameterForNullTest(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127D620 Offset: 0x127BC20 VA: 0x18127D620
	private string CreateParameterForValue(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127D900 Offset: 0x127BF00 VA: 0x18127D900 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x127D980 Offset: 0x127BF80 VA: 0x18127D980
	private string GetBaseParameterName(int index) { }

	// RVA: 0x127DC40 Offset: 0x127C240 VA: 0x18127DC40
	private string GetOriginalParameterName(int index) { }

	// RVA: 0x127DBF0 Offset: 0x127C1F0 VA: 0x18127DBF0
	private string GetNullParameterName(int index) { }

	// RVA: 0x127DE10 Offset: 0x127C410 VA: 0x18127DE10
	private DbCommand GetSelectCommand() { }

	// RVA: 0x127D9D0 Offset: 0x127BFD0 VA: 0x18127D9D0
	private object GetColumnValue(DataRow row, string columnName, DataTableMapping mappings, DataRowVersion version) { }

	// RVA: 0x127DA80 Offset: 0x127C080 VA: 0x18127DA80
	private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version) { }

	// RVA: 0x127DAC0 Offset: 0x127C0C0 VA: 0x18127DAC0
	private DataColumn GetDataColumn(string columnName, DataTableMapping tablemapping, DataRow row) { }

	// RVA: 0x127DB50 Offset: 0x127C150 VA: 0x18127DB50
	private static DbParameter GetNextParameter(DbCommand command, int pcount) { }

	// RVA: 0x127DF10 Offset: 0x127C510 VA: 0x18127DF10
	private bool IncludeInInsertValues(DbSchemaRow row) { }

	// RVA: 0x127E090 Offset: 0x127C690 VA: 0x18127E090
	private bool IncludeInUpdateSet(DbSchemaRow row) { }

	// RVA: 0x127E0F0 Offset: 0x127C6F0 VA: 0x18127E0F0
	private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate) { }

	// RVA: 0x127E250 Offset: 0x127C850 VA: 0x18127E250
	private bool IncrementWhereCount(DbSchemaRow row) { }

	// RVA: 0x127E390 Offset: 0x127C990 VA: 0x18127E390 Slot: 21
	protected virtual DbCommand InitializeCommand(DbCommand command) { }

	// RVA: 0x127E4F0 Offset: 0x127CAF0 VA: 0x18127E4F0
	private string QuotedColumn(string column) { }

	// RVA: 0x127E490 Offset: 0x127CA90 VA: 0x18127E490 Slot: 22
	public virtual string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x127E590 Offset: 0x127CB90 VA: 0x18127E590 Slot: 23
	public virtual void RefreshSchema() { }

	// RVA: 0x127E8A0 Offset: 0x127CEA0 VA: 0x18127E8A0
	private static void RemoveExtraParameters(DbCommand command, int usedParameterCount) { }

	// RVA: 0x127EA80 Offset: 0x127D080 VA: 0x18127EA80
	protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127E940 Offset: 0x127CF40 VA: 0x18127E940
	private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127EEC0 Offset: 0x127D4C0 VA: 0x18127EEC0 Slot: 24
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

	// RVA: 0x12828E0 Offset: 0x1280EE0 VA: 0x1812828E0
	internal void .ctor(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows) { }

	// RVA: 0x1282760 Offset: 0x1280D60 VA: 0x181282760
	private void SetAndValidateNamePrefixes() { }

	// RVA: 0x1281FB0 Offset: 0x12805B0 VA: 0x181281FB0
	private void ApplyProviderSpecificFormat() { }

	// RVA: 0x12821C0 Offset: 0x12807C0 VA: 0x1812821C0
	private void EliminateConflictingNames() { }

	// RVA: 0x1282360 Offset: 0x1280960 VA: 0x181282360
	internal void GenerateMissingNames(DbSchemaRow[] schemaRows) { }

	// RVA: 0x1282530 Offset: 0x1280B30 VA: 0x181282530
	private int GetAdjustedParameterNameMaxLength() { }

	// RVA: 0x1282600 Offset: 0x1280C00 VA: 0x181282600
	private string GetNextGenericParameterName() { }

	// RVA: 0xE95930 Offset: 0xE93F30 VA: 0x180E95930
	internal string GetBaseParameterName(int index) { }

	// RVA: 0x1282720 Offset: 0x1280D20 VA: 0x181282720
	internal string GetOriginalParameterName(int index) { }

	// RVA: 0x12826E0 Offset: 0x1280CE0 VA: 0x1812826E0
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

	// RVA: 0x1280BD0 Offset: 0x127F1D0 VA: 0x181280BD0
	internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(DbSchemaTable schemaTable, DataRow dataRow) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal DataRow get_DataRow() { }

	// RVA: 0x12815A0 Offset: 0x127FBA0 VA: 0x1812815A0
	internal string get_ColumnName() { }

	// RVA: 0x12810E0 Offset: 0x127F6E0 VA: 0x1812810E0
	internal string get_BaseColumnName() { }

	// RVA: 0x1281340 Offset: 0x127F940 VA: 0x181281340
	internal string get_BaseServerName() { }

	// RVA: 0x1280FB0 Offset: 0x127F5B0 VA: 0x181280FB0
	internal string get_BaseCatalogName() { }

	// RVA: 0x1281210 Offset: 0x127F810 VA: 0x181281210
	internal string get_BaseSchemaName() { }

	// RVA: 0x1281470 Offset: 0x127FA70 VA: 0x181281470
	internal string get_BaseTableName() { }

	// RVA: 0x12816B0 Offset: 0x127FCB0 VA: 0x1812816B0
	internal bool get_IsAutoIncrement() { }

	// RVA: 0x1281E90 Offset: 0x1280490 VA: 0x181281E90
	internal bool get_IsUnique() { }

	// RVA: 0x1281D70 Offset: 0x1280370 VA: 0x181281D70
	internal bool get_IsRowVersion() { }

	// RVA: 0x1281A10 Offset: 0x1280010 VA: 0x181281A10
	internal bool get_IsKey() { }

	// RVA: 0x12817D0 Offset: 0x127FDD0 VA: 0x1812817D0
	internal bool get_IsExpression() { }

	// RVA: 0x12818F0 Offset: 0x127FEF0 VA: 0x1812818F0
	internal bool get_IsHidden() { }

	// RVA: 0x1281B30 Offset: 0x1280130 VA: 0x181281B30
	internal bool get_IsLong() { }

	// RVA: 0x1281C50 Offset: 0x1280250 VA: 0x181281C50
	internal bool get_IsReadOnly() { }

	// RVA: 0x1280E90 Offset: 0x127F490 VA: 0x181280E90
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

	// RVA: 0x17CDD50 Offset: 0x17CC350 VA: 0x1817CDD50
	internal void .ctor(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x17CDE90 Offset: 0x17CC490 VA: 0x1817CDE90
	internal DataColumn get_ColumnName() { }

	// RVA: 0x17CDE70 Offset: 0x17CC470 VA: 0x1817CDE70
	internal DataColumn get_BaseServerName() { }

	// RVA: 0x17CDE50 Offset: 0x17CC450 VA: 0x1817CDE50
	internal DataColumn get_BaseColumnName() { }

	// RVA: 0x17CDE80 Offset: 0x17CC480 VA: 0x1817CDE80
	internal DataColumn get_BaseTableName() { }

	// RVA: 0x17CDE40 Offset: 0x17CC440 VA: 0x1817CDE40
	internal DataColumn get_BaseCatalogName() { }

	// RVA: 0x17CDE60 Offset: 0x17CC460 VA: 0x1817CDE60
	internal DataColumn get_BaseSchemaName() { }

	// RVA: 0x17CDEA0 Offset: 0x17CC4A0 VA: 0x1817CDEA0
	internal DataColumn get_IsAutoIncrement() { }

	// RVA: 0x17CDF10 Offset: 0x17CC510 VA: 0x1817CDF10
	internal DataColumn get_IsUnique() { }

	// RVA: 0x17CDED0 Offset: 0x17CC4D0 VA: 0x1817CDED0
	internal DataColumn get_IsKey() { }

	// RVA: 0x17CDF00 Offset: 0x17CC500 VA: 0x1817CDF00
	internal DataColumn get_IsRowVersion() { }

	// RVA: 0x17CDE30 Offset: 0x17CC430 VA: 0x1817CDE30
	internal DataColumn get_AllowDBNull() { }

	// RVA: 0x17CDEB0 Offset: 0x17CC4B0 VA: 0x1817CDEB0
	internal DataColumn get_IsExpression() { }

	// RVA: 0x17CDEC0 Offset: 0x17CC4C0 VA: 0x1817CDEC0
	internal DataColumn get_IsHidden() { }

	// RVA: 0x17CDEE0 Offset: 0x17CC4E0 VA: 0x1817CDEE0
	internal DataColumn get_IsLong() { }

	// RVA: 0x17CDEF0 Offset: 0x17CC4F0 VA: 0x1817CDEF0
	internal DataColumn get_IsReadOnly() { }

	// RVA: 0x17CD200 Offset: 0x17CB800 VA: 0x1817CD200
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column) { }

	// RVA: 0x17CD210 Offset: 0x17CB810 VA: 0x1817CD210
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2) { }

	// RVA: 0x17CD400 Offset: 0x17CBA00 VA: 0x1817CD400
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

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 12
	public MissingMappingAction get_MissingMappingAction() { }

	// RVA: 0x1274AC0 Offset: 0x12730C0 VA: 0x181274AC0
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

	// RVA: 0x1275570 Offset: 0x1273B70 VA: 0x181275570 Slot: 6
	public string get_DataSetColumn() { }

	// RVA: 0x12755C0 Offset: 0x1273BC0 VA: 0x1812755C0 Slot: 7
	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x12754A0 Offset: 0x1273AA0 VA: 0x1812754A0
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1275180 Offset: 0x1273780 VA: 0x181275180
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	// RVA: 0x1275040 Offset: 0x1273640 VA: 0x181275040
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

	// RVA: 0x1275000 Offset: 0x1273600 VA: 0x181275000 Slot: 6
	public int get_Count() { }

	// RVA: 0x1274E80 Offset: 0x1273480 VA: 0x181274E80 Slot: 7
	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1274B20 Offset: 0x1273120 VA: 0x181274B20
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

	// RVA: 0x10E4B30 Offset: 0x10E3130 VA: 0x1810E4B30
	internal void .ctor(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup) { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840 Slot: 15
	public override int get_FieldCount() { }

	// RVA: 0x1275710 Offset: 0x1273D10 VA: 0x181275710 Slot: 21
	public override int GetValues(object[] values) { }

	// RVA: 0x1275690 Offset: 0x1273C90 VA: 0x181275690 Slot: 19
	public override string GetName(int i) { }

	// RVA: 0x12756D0 Offset: 0x1273CD0 VA: 0x1812756D0 Slot: 20
	public override object GetValue(int i) { }

	// RVA: 0x1275610 Offset: 0x1273C10 VA: 0x181275610 Slot: 17
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1275650 Offset: 0x1273C50 VA: 0x181275650 Slot: 18
	public override Type GetFieldType(int i) { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 16
	public override object get_Item(int i) { }

	// RVA: 0x1275870 Offset: 0x1273E70 VA: 0x181275870 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1275930 Offset: 0x1273F30 VA: 0x181275930 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x12758C0 Offset: 0x1273EC0 VA: 0x1812758C0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 8
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

	// RVA: 0x1278500 Offset: 0x1276B00 VA: 0x181278500
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x12784D0 Offset: 0x1276AD0 VA: 0x1812784D0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x12785B0 Offset: 0x1276BB0 VA: 0x1812785B0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1278760 Offset: 0x1276D60 VA: 0x181278760
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1278780 Offset: 0x1276D80 VA: 0x181278780
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1275A30 Offset: 0x1274030 VA: 0x181275A30 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1275970 Offset: 0x1273F70 VA: 0x181275970
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1275B00 Offset: 0x1274100 VA: 0x181275B00
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1275C10 Offset: 0x1274210 VA: 0x181275C10
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x12767E0 Offset: 0x1274DE0 VA: 0x1812767E0
	protected object GetBits(int recordNo) { }

	// RVA: 0x1276A10 Offset: 0x1275010 VA: 0x181276A10 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1276BB0 Offset: 0x12751B0 VA: 0x181276BB0
	protected bool HasValue(int recordNo) { }

	// RVA: 0x1276F50 Offset: 0x1275550 VA: 0x181276F50 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1277310 Offset: 0x1275910 VA: 0x181277310
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1277280 Offset: 0x1275880 VA: 0x181277280 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1275BC0 Offset: 0x12741C0 VA: 0x181275BC0 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1275B80 Offset: 0x1274180 VA: 0x181275B80 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1275C80 Offset: 0x1274280 VA: 0x181275C80
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x12768B0 Offset: 0x1274EB0 VA: 0x1812768B0
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x1276A20 Offset: 0x1275020 VA: 0x181276A20
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1277200 Offset: 0x1275800 VA: 0x181277200
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1277270 Offset: 0x1275870 VA: 0x181277270
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x12771F0 Offset: 0x12757F0 VA: 0x1812771F0
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x12770B0 Offset: 0x12756B0 VA: 0x1812770B0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1276750 Offset: 0x1274D50 VA: 0x181276750
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1276CA0 Offset: 0x12752A0 VA: 0x181276CA0
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1276DE0 Offset: 0x12753E0 VA: 0x181276DE0
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1276BE0 Offset: 0x12751E0 VA: 0x181276BE0
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1276F70 Offset: 0x1275570 VA: 0x181276F70
	public static bool IsObjectNull(object value) { }

	// RVA: 0x1277050 Offset: 0x1275650 VA: 0x181277050
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1276820 Offset: 0x1274E20 VA: 0x181276820
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x1275C60 Offset: 0x1274260 VA: 0x181275C60
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1277330 Offset: 0x1275930 VA: 0x181277330
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1276AB0 Offset: 0x12750B0 VA: 0x181276AB0
	internal static Type GetType(string value) { }

	// RVA: 0x1276840 Offset: 0x1274E40 VA: 0x181276840
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1277350 Offset: 0x1275950 VA: 0x181277350
	private static void .cctor() { }

}

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4382
{	// Fields
	private DataColumnMappingCollection _columnMappings; // 0x18

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x12787A0 Offset: 0x1276DA0 VA: 0x1812787A0
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

	// RVA: 0x127F310 Offset: 0x127D910 VA: 0x18127F310
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

	// RVA: 0x127F370 Offset: 0x127D970 VA: 0x18127F370
	public DbConnection get_Connection() { }

	// RVA: 0x1276820 Offset: 0x1274E20 VA: 0x181276820
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

	// RVA: 0x11D2A50 Offset: 0x11D1050 VA: 0x1811D2A50
	public DbParameterCollection get_Parameters() { }

	// RVA: 0x127F390 Offset: 0x127D990 VA: 0x18127F390
	public DbTransaction get_Transaction() { }

	// RVA: 0xE2D440 Offset: 0xE2BA40 VA: 0x180E2D440
	public void set_Transaction(DbTransaction value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract UpdateRowSource get_UpdatedRowSource();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_UpdatedRowSource(UpdateRowSource value);

	// RVA: 0xFCB5E0 Offset: 0xFC9BE0 VA: 0x180FCB5E0
	public DbParameter CreateParameter() { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract DbParameter CreateDbParameter();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int ExecuteNonQuery();

	// RVA: 0x127F2F0 Offset: 0x127D8F0 VA: 0x18127F2F0
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

	// RVA: 0x127F4D0 Offset: 0x127DAD0 VA: 0x18127F4D0
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

	// RVA: 0x127F370 Offset: 0x127D970 VA: 0x18127F370
	public DbCommand CreateCommand() { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbCommand CreateDbCommand();

	// RVA: 0x127F3B0 Offset: 0x127D9B0 VA: 0x18127F3B0 Slot: 18
	public virtual void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x127F470 Offset: 0x127DA70 VA: 0x18127F470 Slot: 19
	public virtual DataTable GetSchema(string collectionName) { }

	// RVA: 0x127F410 Offset: 0x127DA10 VA: 0x18127F410 Slot: 20
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

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	private IDbDataAdapter get__IDbDataAdapter() { }

	// RVA: 0x127F5C0 Offset: 0x127DBC0 VA: 0x18127F5C0
	public DbCommand get_DeleteCommand() { }

	// RVA: 0x127F840 Offset: 0x127DE40 VA: 0x18127F840
	public void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127F660 Offset: 0x127DC60 VA: 0x18127F660
	public DbCommand get_InsertCommand() { }

	// RVA: 0x127F8A0 Offset: 0x127DEA0 VA: 0x18127F8A0
	public void set_InsertCommand(DbCommand value) { }

	// RVA: 0x127F700 Offset: 0x127DD00 VA: 0x18127F700
	public DbCommand get_SelectCommand() { }

	// RVA: 0x127F7A0 Offset: 0x127DDA0 VA: 0x18127F7A0
	public DbCommand get_UpdateCommand() { }

	// RVA: 0x127F900 Offset: 0x127DF00 VA: 0x18127F900
	public void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x127F530 Offset: 0x127DB30 VA: 0x18127F530
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

	// RVA: 0x127F370 Offset: 0x127D970 VA: 0x18127F370 Slot: 19
	public virtual int get_VisibleFieldCount() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Item(int ordinal);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void Close() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x127F960 Offset: 0x127DF60 VA: 0x18127F960 Slot: 9
	public void Dispose() { }

	// RVA: 0x127F980 Offset: 0x127DF80 VA: 0x18127F980 Slot: 22
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

	// RVA: 0x127F9A0 Offset: 0x127DFA0 VA: 0x18127F9A0 Slot: 27
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

	// RVA: 0x127F9F0 Offset: 0x127DFF0 VA: 0x18127F9F0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x127FA40 Offset: 0x127E040 VA: 0x18127FA40 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x127FA80 Offset: 0x127E080 VA: 0x18127FA80 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 8
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

	// RVA: 0x12802D0 Offset: 0x127E8D0 VA: 0x1812802D0
	public void .ctor(IDataReader reader, bool closeReader) { }

	// RVA: 0x12802D0 Offset: 0x127E8D0 VA: 0x1812802D0
	public void .ctor(DbDataReader reader, bool closeReader) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object get_Current() { }

	// RVA: 0x1280090 Offset: 0x127E690 VA: 0x181280090 Slot: 4
	public bool MoveNext() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x1280270 Offset: 0x127E870 VA: 0x181280270 Slot: 6
	public void Reset() { }

	// RVA: 0x127FAD0 Offset: 0x127E0D0 VA: 0x18127FAD0
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

	// RVA: 0x127B0D0 Offset: 0x12796D0 VA: 0x18127B0D0
	internal void .ctor(int ordinal, string name, Type type) { }

	// RVA: 0x127B120 Offset: 0x1279720 VA: 0x18127B120 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x127AF50 Offset: 0x1279550 VA: 0x18127AF50 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x127B070 Offset: 0x1279670 VA: 0x18127B070 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public abstract class DbException : ExternalException // TypeDefIndex: 4393
{	// Methods

	// RVA: 0x1280390 Offset: 0x127E990 VA: 0x181280390
	protected void .ctor() { }

	// RVA: 0x1280380 Offset: 0x127E980 VA: 0x181280380
	protected void .ctor(string message) { }

	// RVA: 0x12803A0 Offset: 0x127E9A0 VA: 0x1812803A0
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

	// RVA: 0x1280420 Offset: 0x127EA20 VA: 0x181280420
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

	// RVA: 0x12804F0 Offset: 0x127EAF0 VA: 0x1812804F0
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

	// RVA: 0x1280BC0 Offset: 0x127F1C0 VA: 0x181280BC0 Slot: 18
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

	// RVA: 0x1280AF0 Offset: 0x127F0F0 VA: 0x181280AF0 Slot: 6
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1280B10 Offset: 0x127F110 VA: 0x181280B10 Slot: 7
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1280AF0 Offset: 0x127F0F0 VA: 0x181280AF0
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

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4400
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Commit();

	// RVA: 0x162ECC0 Offset: 0x162D2C0 VA: 0x18162ECC0 Slot: 6
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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Order() { }

	// RVA: 0x7D0D40 Offset: 0x7CF340 VA: 0x1807D0D40
	public bool get_IsRequired() { }

	// RVA: 0x7D0D30 Offset: 0x7CF330 VA: 0x1807D0D30
	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6181
{	// Methods

	// RVA: 0x14ABCC0 Offset: 0x14AA2C0 VA: 0x1814ABCC0
	public static void Insert(string parent, object contents, Action<bool> onFinished) { }

	// RVA: 0x14ABA10 Offset: 0x14AA010 VA: 0x1814ABA10
	public static void Insert(string parent, object contents, Action<bool, string> onFinished) { }

	// RVA: 0x14ABD90 Offset: 0x14AA390 VA: 0x1814ABD90
	public static void Remove(string parent, string id, Action<bool> onFinished) { }

	// RVA: -1 Offset: -1
	public static Result<T> Query<T>(string parent, int limit, Action<Result<T>> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CE50 Offset: 0x125B450 VA: 0x18125CE50
	|-Database.Query<object>
	*/

	// RVA: 0x14AB860 Offset: 0x14A9E60 VA: 0x1814AB860
	public static void Count(string parent, Action<int> onResult) { }

}

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6182
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCD60 Offset: 0x14BB360 VA: 0x1814BCD60
	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6183
{	// Fields
	public Action<bool, string> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCE50 Offset: 0x14BB450 VA: 0x1814BCE50
	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6184
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCFD0 Offset: 0x14BB5D0 VA: 0x1814BCFD0
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
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-Database.<>c__DisplayClass3_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__0(object s, DownloadStringCompletedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E93B0 Offset: 0x15E79B0 VA: 0x1815E93B0
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9740 Offset: 0x15E7D40 VA: 0x1815E9740
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
	|-RVA: 0xD65540 Offset: 0xD63B40 VA: 0x180D65540
	|-Database.<>c__3<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-Database.<>c__3<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Result.Entry<T> <Query>b__3_2(QueryResponse x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9200 Offset: 0x15E7800 VA: 0x1815E9200
	|-Database.<>c__3<object>.<Query>b__3_2
	*/

}

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6187
{	// Fields
	public Action<int> onResult; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BD0C0 Offset: 0x14BB6C0 VA: 0x1814BD0C0
	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6188
{	// Fields
	public int count; // 0x10
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BD250 Offset: 0x14BB850 VA: 0x1814BD250
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
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	private void set_IsConnectionOpen(bool value) { }

	// RVA: 0x231DB40 Offset: 0x231C140 VA: 0x18231DB40
	public void Open(string path, bool fastMode = False) { }

	// RVA: 0x231E290 Offset: 0x231C890 VA: 0x18231E290
	public bool TableExists(string name) { }

	// RVA: 0x231DAD0 Offset: 0x231C0D0 VA: 0x18231DAD0
	public bool IndexExists(string tableName, string indexName) { }

	// RVA: 0x231D300 Offset: 0x231B900 VA: 0x18231D300
	public bool ColumnExists(string tableName, string columnName) { }

	// RVA: 0x231D230 Offset: 0x231B830 VA: 0x18231D230
	public void Close() { }

	// RVA: 0x231E2F0 Offset: 0x231C8F0 VA: 0x18231E2F0
	public int get_AffectedRows() { }

	// RVA: 0x231D600 Offset: 0x231BC00 VA: 0x18231D600
	public void Execute(string query) { }

	// RVA: -1 Offset: -1
	public void Execute<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15727A0 Offset: 0x1570DA0 VA: 0x1815727A0
	|-Database.Execute<int>
	|
	|-RVA: 0x1572B40 Offset: 0x1571140 VA: 0x181572B40
	|-Database.Execute<object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572610 Offset: 0x1570C10 VA: 0x181572610
	|-Database.Execute<int, int>
	|
	|-RVA: 0x1572AA0 Offset: 0x15710A0 VA: 0x181572AA0
	|-Database.Execute<object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3>(string query, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572550 Offset: 0x1570B50 VA: 0x181572550
	|-Database.Execute<int, int, int>
	|
	|-RVA: 0x15729E0 Offset: 0x1570FE0 VA: 0x1815729E0
	|-Database.Execute<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572470 Offset: 0x1570A70 VA: 0x181572470
	|-Database.Execute<int, int, int, int>
	|
	|-RVA: 0x1572900 Offset: 0x1570F00 VA: 0x181572900
	|-Database.Execute<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4, T5>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15726B0 Offset: 0x1570CB0 VA: 0x1815726B0
	|-Database.Execute<int, byte[], int, int, int>
	|-Database.Execute<int, object, int, int, int>
	|
	|-RVA: 0x1572810 Offset: 0x1570E10 VA: 0x181572810
	|-Database.Execute<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	protected static void Bind<T>(IntPtr stmHandle, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571860 Offset: 0x156FE60 VA: 0x181571860
	|-Database.Bind<int>
	|
	|-RVA: 0x1571E60 Offset: 0x1570460 VA: 0x181571E60
	|-Database.Bind<object>
	*/

	// RVA: -1 Offset: -1
	protected static T GetColumnValue<T>(IntPtr stmHandle, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CBD60 Offset: 0x5CA360 VA: 0x1805CBD60
	|-Database.GetColumnValue<int>
	|
	|-RVA: 0x5CC4D0 Offset: 0x5CAAD0 VA: 0x1805CC4D0
	|-Database.GetColumnValue<long>
	|
	|-RVA: 0x5CCC40 Offset: 0x5CB240 VA: 0x1805CCC40
	|-Database.GetColumnValue<object>
	*/

	// RVA: 0x231DFF0 Offset: 0x231C5F0 VA: 0x18231DFF0
	public int QueryInt(string query) { }

	// RVA: -1 Offset: -1
	public int QueryInt<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179070 Offset: 0x1177670 VA: 0x181179070
	|-Database.QueryInt<object>
	|-Database.QueryInt<string>
	*/

	// RVA: -1 Offset: -1
	public int QueryInt<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178FA0 Offset: 0x11775A0 VA: 0x181178FA0
	|-Database.QueryInt<object, object>
	|-Database.QueryInt<string, string>
	*/

	// RVA: 0x231E050 Offset: 0x231C650 VA: 0x18231E050
	public long QueryLong(string query) { }

	// RVA: -1 Offset: -1
	public string QueryString<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2BB0 Offset: 0xED11B0 VA: 0x180ED2BB0
	|-Database.QueryString<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537D70 Offset: 0x1536370 VA: 0x181537D70
	|-Database.QueryBlob<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEDA0 Offset: 0xBED3A0 VA: 0x180BEEDA0
	|-Database.QueryBlob<int, int, int, int>
	|
	|-RVA: 0xBEEEA0 Offset: 0xBED4A0 VA: 0x180BEEEA0
	|-Database.QueryBlob<object, object, object, object>
	*/

	// RVA: 0x231D1E0 Offset: 0x231B7E0 VA: 0x18231D1E0
	public void BeginTransaction() { }

	// RVA: 0x231D370 Offset: 0x231B970 VA: 0x18231D370
	public void Commit() { }

	// RVA: 0x231E240 Offset: 0x231C840 VA: 0x18231E240
	public void Rollback() { }

	// RVA: 0x231D3C0 Offset: 0x231B9C0 VA: 0x18231D3C0
	protected void ExecuteQuery(IntPtr stmHandle, bool finalize = True) { }

	// RVA: -1 Offset: -1
	protected T ExecuteAndReadQueryResult<T>(IntPtr stmHandle, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CBC00 Offset: 0x5CA200 VA: 0x1805CBC00
	|-Database.ExecuteAndReadQueryResult<byte[]>
	|-Database.ExecuteAndReadQueryResult<object>
	|-Database.ExecuteAndReadQueryResult<string>
	|
	|-RVA: 0x5CB950 Offset: 0x5C9F50 VA: 0x1805CB950
	|-Database.ExecuteAndReadQueryResult<int>
	|
	|-RVA: 0x5CBAA0 Offset: 0x5CA0A0 VA: 0x1805CBAA0
	|-Database.ExecuteAndReadQueryResult<long>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x9A710 Offset: 0x99B10 VA: 0x18009A710
	// RVA: -1 Offset: -1
	protected IEnumerable<T> ExecuteAndReadQueryResults<T>(IntPtr stmHandle, Func<IntPtr, T> rowReader, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFAA0 Offset: 0xCFE0A0 VA: 0x180CFFAA0
	|-Database.ExecuteAndReadQueryResults<object>
	*/

	// RVA: 0x231DDC0 Offset: 0x231C3C0 VA: 0x18231DDC0
	protected IntPtr Prepare(string query) { }

	// RVA: 0x231D630 Offset: 0x231BC30 VA: 0x18231D630
	private void FinalizeOrReset(IntPtr stmHandle, bool finalize = True) { }

	// RVA: 0x231D940 Offset: 0x231BF40 VA: 0x18231D940
	protected void Finalize(IntPtr stmHandle) { }

	// RVA: 0x231E0B0 Offset: 0x231C6B0 VA: 0x18231E0B0
	protected void Reset(IntPtr stmHandle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Exception <GetColumnValue>g__TypeError|19_0<T>(ref Database.<>c__DisplayClass19_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B19E10 Offset: 0x1B18410 VA: 0x181B19E10
	|-Database.<GetColumnValue>g__TypeError|19_0<int>
	|
	|-RVA: 0x1B19F10 Offset: 0x1B18510 VA: 0x181B19F10
	|-Database.<GetColumnValue>g__TypeError|19_0<long>
	|
	|-RVA: 0x1B1A010 Offset: 0x1B18610 VA: 0x181B1A010
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
	|-RVA: 0x144BB00 Offset: 0x144A100 VA: 0x18144BB00
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7C0 Offset: 0x1449DC0 VA: 0x18144B7C0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8B40 Offset: 0x15E7140 VA: 0x1815E8B40
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8DC0 Offset: 0x15E73C0 VA: 0x1815E8DC0
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
	|-RVA: 0x15E8D70 Offset: 0x15E7370 VA: 0x1815E8D70
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
	|-RVA: 0x15E8C70 Offset: 0x15E7270 VA: 0x1815E8C70
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8D40 Offset: 0x15E7340 VA: 0x1815E8D40
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7622
{	// Methods

	// RVA: 0x13979A0 Offset: 0x1395FA0 VA: 0x1813979A0
	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	// RVA: 0x1397990 Offset: 0x1395F90 VA: 0x181397990
	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1397C10 Offset: 0x1396210 VA: 0x181397C10
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1397B50 Offset: 0x1396150 VA: 0x181397B50
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static byte GetTail(short number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1397A00 Offset: 0x1396000 VA: 0x181397A00
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1397AB0 Offset: 0x13960B0 VA: 0x181397AB0
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1397AA0 Offset: 0x13960A0 VA: 0x181397AA0
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7825
{	// Properties
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }

	// Methods

	// RVA: 0x224EBD0 Offset: 0x224D1D0 VA: 0x18224EBD0
	public void .ctor(int codePage) { }

	// RVA: 0x224EBE0 Offset: 0x224D1E0 VA: 0x18224EBE0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract DbcsConvert GetConvert();

	// RVA: 0x224E630 Offset: 0x224CC30 VA: 0x18224E630 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x224E7B0 Offset: 0x224CDB0 VA: 0x18224E7B0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224E910 Offset: 0x224CF10 VA: 0x18224E910 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224EAD0 Offset: 0x224D0D0 VA: 0x18224EAD0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224EB50 Offset: 0x224D150 VA: 0x18224EB50 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

}

internal abstract class DbcsEncoding.DbcsDecoder : Decoder // TypeDefIndex: 7826
{	// Fields
	protected DbcsConvert convert; // 0x20

	// Methods

	// RVA: 0x15C0FC0 Offset: 0x15BF5C0 VA: 0x1815C0FC0
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224E510 Offset: 0x224CB10 VA: 0x18224E510
	internal void CheckRange(byte[] bytes, int index, int count) { }

	// RVA: 0x224E350 Offset: 0x224C950 VA: 0x18224E350
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

	// RVA: 0x224E1C0 Offset: 0x224C7C0 VA: 0x18224E1C0
	internal void .ctor(string fileName) { }

	// RVA: 0x224E0E0 Offset: 0x224C6E0 VA: 0x18224E0E0
	private static void .cctor() { }

}

public class Data : ConsoleSystem // TypeDefIndex: 11898
{	// Methods

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6D5DF0 Offset: 0x6D43F0 VA: 0x1806D5DF0
	public static void export(ConsoleSystem.Arg args) { }

	// RVA: 0x6D5D90 Offset: 0x6D4390 VA: 0x1806D5D90
	public void .ctor() { }

}

