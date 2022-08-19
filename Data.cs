public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{	// Fields
	public static readonly DBNull Value; // 0x13C84

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1792A40 Offset: 0x1791040 VA: 0x181792A40
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1792290 Offset: 0x1790890 VA: 0x181792290 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17929A0 Offset: 0x1790FA0 VA: 0x1817929A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1792960 Offset: 0x1790F60 VA: 0x181792960 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x17922C0 Offset: 0x17908C0 VA: 0x1817922C0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x17923A0 Offset: 0x17909A0 VA: 0x1817923A0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x17926B0 Offset: 0x1790CB0 VA: 0x1817926B0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1792330 Offset: 0x1790930 VA: 0x181792330 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1792560 Offset: 0x1790B60 VA: 0x181792560 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1792810 Offset: 0x1790E10 VA: 0x181792810 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x17925D0 Offset: 0x1790BD0 VA: 0x1817925D0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1792880 Offset: 0x1790E80 VA: 0x181792880 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1792640 Offset: 0x1790C40 VA: 0x181792640 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x17928F0 Offset: 0x1790EF0 VA: 0x1817928F0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1792720 Offset: 0x1790D20 VA: 0x181792720 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x17924F0 Offset: 0x1790AF0 VA: 0x1817924F0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1792480 Offset: 0x1790A80 VA: 0x181792480 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1792410 Offset: 0x1790A10 VA: 0x181792410 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1792790 Offset: 0x1790D90 VA: 0x181792790 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17929E0 Offset: 0x1790FE0 VA: 0x1817929E0
	private static void .cctor() { }

}

internal struct DataCollector // TypeDefIndex: 1509
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x120B70 Offset: 0x11FF70 VA: 0x180120B70
	internal void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	// RVA: 0x120B50 Offset: 0x11FF50 VA: 0x180120B50
	internal void Disable() { }

	// RVA: 0x120D10 Offset: 0x120110 VA: 0x180120D10
	internal EventSource.EventData* Finish() { }

	// RVA: 0x120AF0 Offset: 0x11FEF0 VA: 0x180120AF0
	internal void AddScalar(void* value, int size) { }

	// RVA: 0x120AB0 Offset: 0x11FEB0 VA: 0x180120AB0
	internal void AddBinary(string value, int size) { }

	// RVA: 0x120AC0 Offset: 0x11FEC0 VA: 0x180120AC0
	internal void AddBinary(Array value, int size) { }

	// RVA: 0x120AA0 Offset: 0x11FEA0 VA: 0x180120AA0
	internal void AddArray(Array value, int length, int itemSize) { }

	// RVA: 0x120B00 Offset: 0x11FF00 VA: 0x180120B00
	internal int BeginBufferedArray() { }

	// RVA: 0x120BC0 Offset: 0x11FFC0 VA: 0x180120BC0
	internal void EndBufferedArray(int bookmark, int count) { }

	// RVA: 0x120B30 Offset: 0x11FF30 VA: 0x180120B30
	internal void BeginBuffered() { }

	// RVA: 0x120C90 Offset: 0x120090 VA: 0x180120C90
	internal void EndBuffered() { }

	// RVA: 0x120CF0 Offset: 0x1200F0 VA: 0x180120CF0
	private void EnsureBuffer() { }

	// RVA: 0x120D00 Offset: 0x120100 VA: 0x180120D00
	private void EnsureBuffer(int additionalSize) { }

	// RVA: 0x120D30 Offset: 0x120130 VA: 0x180120D30
	private void GrowBuffer(int required) { }

	// RVA: 0x120D90 Offset: 0x120190 VA: 0x180120D90
	private void PinArray(object value, int size) { }

	// RVA: 0x120DA0 Offset: 0x1201A0 VA: 0x180120DA0
	private void ScalarsBegin() { }

	// RVA: 0x120DB0 Offset: 0x1201B0 VA: 0x180120DB0
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

	// RVA: 0x15056E0 Offset: 0x1503CE0 VA: 0x1815056E0
	private static void .cctor() { }

	// RVA: 0x150B2D0 Offset: 0x15098D0 VA: 0x18150B2D0
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x150B3D0 Offset: 0x15099D0 VA: 0x18150B3D0
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x15041C0 Offset: 0x15027C0 VA: 0x1815041C0
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1504130 Offset: 0x1502730 VA: 0x181504130
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1504040 Offset: 0x1502640 VA: 0x181504040
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x1503F50 Offset: 0x1502550 VA: 0x181503F50
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x1505300 Offset: 0x1503900 VA: 0x181505300
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1503CA0 Offset: 0x15022A0 VA: 0x181503CA0
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x1502620 Offset: 0x1500C20 VA: 0x181502620
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1504680 Offset: 0x1502C80 VA: 0x181504680
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1504710 Offset: 0x1502D10 VA: 0x181504710
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x15042B0 Offset: 0x15028B0 VA: 0x1815042B0
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x15047E0 Offset: 0x1502DE0 VA: 0x1815047E0
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x1504250 Offset: 0x1502850 VA: 0x181504250
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x1504510 Offset: 0x1502B10 VA: 0x181504510
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1503A10 Offset: 0x1502010 VA: 0x181503A10 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1503A00 Offset: 0x1502000 VA: 0x181503A00 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x15036D0 Offset: 0x1501CD0 VA: 0x1815036D0
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x1503B60 Offset: 0x1502160 VA: 0x181503B60
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1504BC0 Offset: 0x15031C0 VA: 0x181504BC0 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1504F00 Offset: 0x1503500 VA: 0x181504F00 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1504AC0 Offset: 0x15030C0 VA: 0x181504AC0 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150B330 Offset: 0x1509930 VA: 0x18150B330 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150B430 Offset: 0x1509A30 VA: 0x18150B430 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B470 Offset: 0x1509A70 VA: 0x18150B470 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x150B390 Offset: 0x1509990 VA: 0x18150B390 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x150B3B0 Offset: 0x15099B0 VA: 0x18150B3B0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15050D0 Offset: 0x15036D0 VA: 0x1815050D0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1504F20 Offset: 0x1503520 VA: 0x181504F20 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x15053D0 Offset: 0x15039D0 VA: 0x1815053D0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1504A40 Offset: 0x1503040 VA: 0x181504A40
	internal string GetTypeName() { }

	// RVA: 0x15025A0 Offset: 0x1500BA0 VA: 0x1815025A0
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x1386000 Offset: 0x1384600 VA: 0x181386000
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x14B7D60 Offset: 0x14B6360 VA: 0x1814B7D60
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_ParentIndex() { }

	// RVA: 0x151E6F0 Offset: 0x151CCF0 VA: 0x18151E6F0 Slot: 4
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

	// RVA: 0x150B820 Offset: 0x1509E20 VA: 0x18150B820 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150C5A0 Offset: 0x150ABA0 VA: 0x18150C5A0
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x150B510 Offset: 0x1509B10 VA: 0x18150B510 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0xFCB320 Offset: 0xFC9920 VA: 0x180FCB320 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150C6F0 Offset: 0x150ACF0 VA: 0x18150C6F0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C6C0 Offset: 0x150ACC0 VA: 0x18150C6C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150C660 Offset: 0x150AC60 VA: 0x18150C660 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150C720 Offset: 0x150AD20 VA: 0x18150C720 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150BB80 Offset: 0x150A180 VA: 0x18150BB80 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x150C0E0 Offset: 0x150A6E0 VA: 0x18150C0E0 Slot: 16
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

	// RVA: 0x15139B0 Offset: 0x1511FB0 VA: 0x1815139B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1514230 Offset: 0x1512830 VA: 0x181514230
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x15138B0 Offset: 0x1511EB0 VA: 0x1815138B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15143A0 Offset: 0x15129A0 VA: 0x1815143A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15142E0 Offset: 0x15128E0 VA: 0x1815142E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1514340 Offset: 0x1512940 VA: 0x181514340 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xED9720 Offset: 0xED7D20 VA: 0x180ED9720 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x15139C0 Offset: 0x1511FC0 VA: 0x1815139C0
	internal bool HasAtomicMembers() { }

	// RVA: 0x1513A60 Offset: 0x1512060 VA: 0x181513A60
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1513B20 Offset: 0x1512120 VA: 0x181513B20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513D90 Offset: 0x1512390 VA: 0x181513D90 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514190 Offset: 0x1512790 VA: 0x181514190
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

	// RVA: 0x150D8E0 Offset: 0x150BEE0 VA: 0x18150D8E0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150DA70 Offset: 0x150C070 VA: 0x18150DA70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150DB30 Offset: 0x150C130 VA: 0x18150DB30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150DAD0 Offset: 0x150C0D0 VA: 0x18150DAD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150D870 Offset: 0x150BE70 VA: 0x18150D870 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150D940 Offset: 0x150BF40 VA: 0x18150D940 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150DA10 Offset: 0x150C010 VA: 0x18150DA10
	public void .ctor() { }

	// RVA: 0x150D970 Offset: 0x150BF70 VA: 0x18150D970
	private static void .cctor() { }

}

internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 2184
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150D780 Offset: 0x150BD80 VA: 0x18150D780 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150D7E0 Offset: 0x150BDE0 VA: 0x18150D7E0
	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515810 Offset: 0x1513E10 VA: 0x181515810 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11BAF20 Offset: 0x11B9520 VA: 0x1811BAF20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515870 Offset: 0x1513E70 VA: 0x181515870
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

	// RVA: 0x1513560 Offset: 0x1511B60 VA: 0x181513560 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1513720 Offset: 0x1511D20 VA: 0x181513720 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1513570 Offset: 0x1511B70 VA: 0x181513570 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1513690 Offset: 0x1511C90 VA: 0x181513690
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

	// RVA: 0x150E6B0 Offset: 0x150CCB0 VA: 0x18150E6B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150E910 Offset: 0x150CF10 VA: 0x18150E910 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x132C4C0 Offset: 0x132AAC0 VA: 0x18132C4C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150E9D0 Offset: 0x150CFD0 VA: 0x18150E9D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150E970 Offset: 0x150CF70 VA: 0x18150E970 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xED9760 Offset: 0xED7D60 VA: 0x180ED9760 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E630 Offset: 0x150CC30 VA: 0x18150E630 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E6C0 Offset: 0x150CCC0 VA: 0x18150E6C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E880 Offset: 0x150CE80 VA: 0x18150E880
	public void .ctor() { }

	// RVA: 0x150E7E0 Offset: 0x150CDE0 VA: 0x18150E7E0
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

	// RVA: 0x1510640 Offset: 0x150EC40 VA: 0x181510640 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x15117F0 Offset: 0x150FDF0 VA: 0x1815117F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x10E4BC0 Offset: 0x10E31C0 VA: 0x1810E4BC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15118B0 Offset: 0x150FEB0 VA: 0x1815118B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1511850 Offset: 0x150FE50 VA: 0x181511850 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x15114B0 Offset: 0x150FAB0 VA: 0x1815114B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1511530 Offset: 0x150FB30 VA: 0x181511530 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511760 Offset: 0x150FD60 VA: 0x181511760
	public void .ctor() { }

	// RVA: 0x15116C0 Offset: 0x150FCC0 VA: 0x1815116C0
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

	// RVA: 0x1510640 Offset: 0x150EC40 VA: 0x181510640 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510910 Offset: 0x150EF10 VA: 0x181510910 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED9730 Offset: 0xED7D30 VA: 0x180ED9730 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15109D0 Offset: 0x150EFD0 VA: 0x1815109D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1510970 Offset: 0x150EF70 VA: 0x181510970 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x15105C0 Offset: 0x150EBC0 VA: 0x1815105C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1510650 Offset: 0x150EC50 VA: 0x181510650 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510880 Offset: 0x150EE80 VA: 0x181510880
	public void .ctor() { }

	// RVA: 0x15107E0 Offset: 0x150EDE0 VA: 0x1815107E0
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

	// RVA: 0x150FF00 Offset: 0x150E500 VA: 0x18150FF00 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510280 Offset: 0x150E880 VA: 0x181510280 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xBA4EE0 Offset: 0xBA34E0 VA: 0x180BA4EE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510350 Offset: 0x150E950 VA: 0x181510350 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15102E0 Offset: 0x150E8E0 VA: 0x1815102E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1510340 Offset: 0x150E940 VA: 0x181510340 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150FE80 Offset: 0x150E480 VA: 0x18150FE80 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150FF10 Offset: 0x150E510 VA: 0x18150FF10 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15101F0 Offset: 0x150E7F0 VA: 0x1815101F0
	public void .ctor() { }

	// RVA: 0x15100A0 Offset: 0x150E6A0 VA: 0x1815100A0
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1510DD0 Offset: 0x150F3D0 VA: 0x181510DD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE61B60 Offset: 0xE60160 VA: 0x180E61B60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1510E90 Offset: 0x150F490 VA: 0x181510E90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1510E30 Offset: 0x150F430 VA: 0x181510E30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1510A30 Offset: 0x150F030 VA: 0x181510A30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1510AB0 Offset: 0x150F0B0 VA: 0x181510AB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1510D40 Offset: 0x150F340 VA: 0x181510D40
	public void .ctor() { }

	// RVA: 0x1510CA0 Offset: 0x150F2A0 VA: 0x181510CA0
	private static void .cctor() { }

}

internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 2192
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515CD0 Offset: 0x15142D0 VA: 0x181515CD0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515F20 Offset: 0x1514520 VA: 0x181515F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515EC0 Offset: 0x15144C0 VA: 0x181515EC0
	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150FBC0 Offset: 0x150E1C0 VA: 0x18150FBC0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150FE10 Offset: 0x150E410 VA: 0x18150FE10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FDB0 Offset: 0x150E3B0 VA: 0x18150FDB0
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

	// RVA: 0x150F460 Offset: 0x150DA60 VA: 0x18150F460 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150F900 Offset: 0x150DF00 VA: 0x18150F900 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150F9C0 Offset: 0x150DFC0 VA: 0x18150F9C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150F860 Offset: 0x150DE60 VA: 0x18150F860
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x150F9E0 Offset: 0x150DFE0 VA: 0x18150F9E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150F960 Offset: 0x150DF60 VA: 0x18150F960 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150F9D0 Offset: 0x150DFD0 VA: 0x18150F9D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150F360 Offset: 0x150D960 VA: 0x18150F360 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150F470 Offset: 0x150DA70 VA: 0x18150F470 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F7C0 Offset: 0x150DDC0 VA: 0x18150F7C0
	private static void .cctor() { }

}

internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2195
{	// Methods

	// RVA: 0x150FA40 Offset: 0x150E040 VA: 0x18150FA40
	internal void .ctor() { }

}

internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2196
{	// Methods

	// RVA: 0x150FAA0 Offset: 0x150E0A0 VA: 0x18150FAA0
	internal void .ctor() { }

}

internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 2197
{	// Methods

	// RVA: 0x150FB00 Offset: 0x150E100 VA: 0x18150FB00
	internal void .ctor() { }

}

internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2198
{	// Methods

	// RVA: 0x1513780 Offset: 0x1511D80 VA: 0x181513780
	internal void .ctor() { }

}

internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2199
{	// Methods

	// RVA: 0x15137E0 Offset: 0x1511DE0 VA: 0x1815137E0
	internal void .ctor() { }

}

internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 2200
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15138A0 Offset: 0x1511EA0 VA: 0x1815138A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1513840 Offset: 0x1511E40 VA: 0x181513840
	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED96E0 Offset: 0xED7CE0 VA: 0x180ED96E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FB60 Offset: 0x150E160 VA: 0x18150FB60
	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1515F90 Offset: 0x1514590 VA: 0x181515F90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515F30 Offset: 0x1514530 VA: 0x181515F30
	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1516000 Offset: 0x1514600 VA: 0x181516000 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515FA0 Offset: 0x15145A0 VA: 0x181515FA0
	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512980 Offset: 0x1510F80 VA: 0x181512980 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512920 Offset: 0x1510F20 VA: 0x181512920
	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED9720 Offset: 0xED7D20 VA: 0x180ED9720 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150FE20 Offset: 0x150E420 VA: 0x18150FE20
	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x49DC50 Offset: 0x49C250 VA: 0x18049DC50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512990 Offset: 0x1510F90 VA: 0x181512990
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1511CF0 Offset: 0x15102F0 VA: 0x181511CF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1511DB0 Offset: 0x15103B0 VA: 0x181511DB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511DC0 Offset: 0x15103C0 VA: 0x181511DC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1511D50 Offset: 0x1510350 VA: 0x181511D50 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1511910 Offset: 0x150FF10 VA: 0x181511910 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1511A40 Offset: 0x1510040 VA: 0x181511A40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511C60 Offset: 0x1510260 VA: 0x181511C60
	public void .ctor() { }

	// RVA: 0x1511BC0 Offset: 0x15101C0 VA: 0x181511BC0
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150E500 Offset: 0x150CB00 VA: 0x18150E500 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150E5C0 Offset: 0x150CBC0 VA: 0x18150E5C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150E5D0 Offset: 0x150CBD0 VA: 0x18150E5D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150E560 Offset: 0x150CB60 VA: 0x18150E560 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150E120 Offset: 0x150C720 VA: 0x18150E120 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150E250 Offset: 0x150C850 VA: 0x18150E250 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150E470 Offset: 0x150CA70 VA: 0x18150E470
	public void .ctor() { }

	// RVA: 0x150E3D0 Offset: 0x150C9D0 VA: 0x18150E3D0
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150E000 Offset: 0x150C600 VA: 0x18150E000 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED9700 Offset: 0xED7D00 VA: 0x180ED9700 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150E0C0 Offset: 0x150C6C0 VA: 0x18150E0C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150E060 Offset: 0x150C660 VA: 0x18150E060 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150DB90 Offset: 0x150C190 VA: 0x18150DB90 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150DCC0 Offset: 0x150C2C0 VA: 0x18150DCC0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150DF70 Offset: 0x150C570 VA: 0x18150DF70
	public void .ctor() { }

	// RVA: 0x150DED0 Offset: 0x150C4D0 VA: 0x18150DED0
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150D650 Offset: 0x150BC50 VA: 0x18150D650 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150D710 Offset: 0x150BD10 VA: 0x18150D710 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150D720 Offset: 0x150BD20 VA: 0x18150D720 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D6B0 Offset: 0x150BCB0 VA: 0x18150D6B0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150D330 Offset: 0x150B930 VA: 0x18150D330 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150D5C0 Offset: 0x150BBC0 VA: 0x18150D5C0
	public void .ctor() { }

	// RVA: 0x150D520 Offset: 0x150BB20 VA: 0x18150D520
	private static void .cctor() { }

}

internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 2211
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512EA0 Offset: 0x15114A0 VA: 0x181512EA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512EA0 Offset: 0x15114A0 VA: 0x181512EA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xED9710 Offset: 0xED7D10 VA: 0x180ED9710 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED9710 Offset: 0xED7D10 VA: 0x180ED9710 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15124B0 Offset: 0x1510AB0 VA: 0x1815124B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xBA4340 Offset: 0xBA2940 VA: 0x180BA4340 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x91FBF0 Offset: 0x91E1F0 VA: 0x18091FBF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x150CF70 Offset: 0x150B570 VA: 0x18150CF70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED97A0 Offset: 0xED7DA0 VA: 0x180ED97A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150C760 Offset: 0x150AD60 VA: 0x18150C760 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B500 Offset: 0x1509B00 VA: 0x18150B500 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B4F0 Offset: 0x1509AF0 VA: 0x18150B4F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x150B4E0 Offset: 0x1509AE0 VA: 0x18150B4E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
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

	// RVA: 0x150C8B0 Offset: 0x150AEB0 VA: 0x18150C8B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x150CE40 Offset: 0x150B440 VA: 0x18150CE40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150CF00 Offset: 0x150B500 VA: 0x18150CF00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150C750 Offset: 0x150AD50 VA: 0x18150C750 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150CF10 Offset: 0x150B510 VA: 0x18150CF10 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150CEA0 Offset: 0x150B4A0 VA: 0x18150CEA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x150C8C0 Offset: 0x150AEC0 VA: 0x18150C8C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150CAB0 Offset: 0x150B0B0 VA: 0x18150CAB0 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x150CDB0 Offset: 0x150B3B0 VA: 0x18150CDB0
	public void .ctor() { }

	// RVA: 0x150CD10 Offset: 0x150B310 VA: 0x18150CD10
	private static void .cctor() { }

}

internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 2223
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xED9760 Offset: 0xED7D60 VA: 0x180ED9760 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512300 Offset: 0x1510900 VA: 0x181512300 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512450 Offset: 0x1510A50 VA: 0x181512450
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

	// RVA: 0x1512E30 Offset: 0x1511430 VA: 0x181512E30 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512E90 Offset: 0x1511490 VA: 0x181512E90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1512450 Offset: 0x1510A50 VA: 0x181512450
	public void .ctor() { }

	// RVA: 0x1512D40 Offset: 0x1511340 VA: 0x181512D40
	private static void .cctor() { }

}

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 2225
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x142A8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1512B70 Offset: 0x1511170 VA: 0x181512B70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512BD0 Offset: 0x15111D0 VA: 0x181512BD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512AE0 Offset: 0x15110E0 VA: 0x181512AE0
	public void .ctor() { }

	// RVA: 0x15129F0 Offset: 0x1510FF0 VA: 0x1815129F0
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

	// RVA: 0x15127F0 Offset: 0x1510DF0 VA: 0x1815127F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x15128B0 Offset: 0x1510EB0 VA: 0x1815128B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15124C0 Offset: 0x1510AC0 VA: 0x1815124C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15128C0 Offset: 0x1510EC0 VA: 0x1815128C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512850 Offset: 0x1510E50 VA: 0x181512850 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1512540 Offset: 0x1510B40 VA: 0x181512540 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512450 Offset: 0x1510A50 VA: 0x181512450
	public void .ctor() { }

	// RVA: 0x15126C0 Offset: 0x1510CC0 VA: 0x1815126C0
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

	// RVA: 0x15121E0 Offset: 0x15107E0 VA: 0x1815121E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xED96F0 Offset: 0xED7CF0 VA: 0x180ED96F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1511E20 Offset: 0x1510420 VA: 0x181511E20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15122A0 Offset: 0x15108A0 VA: 0x1815122A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1512240 Offset: 0x1510840 VA: 0x181512240 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1511EA0 Offset: 0x15104A0 VA: 0x181511EA0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1512150 Offset: 0x1510750 VA: 0x181512150
	public void .ctor() { }

	// RVA: 0x1512020 Offset: 0x1510620 VA: 0x181512020
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

	// RVA: 0x1513430 Offset: 0x1511A30 VA: 0x181513430 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15134F0 Offset: 0x1511AF0 VA: 0x1815134F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15130A0 Offset: 0x15116A0 VA: 0x1815130A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1513500 Offset: 0x1511B00 VA: 0x181513500 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1513490 Offset: 0x1511A90 VA: 0x181513490 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1513120 Offset: 0x1511720 VA: 0x181513120 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15133D0 Offset: 0x15119D0 VA: 0x1815133D0
	public void .ctor() { }

	// RVA: 0x15132A0 Offset: 0x15118A0 VA: 0x1815132A0
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

	// RVA: 0x150EDF0 Offset: 0x150D3F0 VA: 0x18150EDF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x150EEB0 Offset: 0x150D4B0 VA: 0x18150EEB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x150EA30 Offset: 0x150D030 VA: 0x18150EA30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150EEC0 Offset: 0x150D4C0 VA: 0x18150EEC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150EE50 Offset: 0x150D450 VA: 0x18150EE50 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150EAB0 Offset: 0x150D0B0 VA: 0x18150EAB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150ED60 Offset: 0x150D360 VA: 0x18150ED60
	public void .ctor() { }

	// RVA: 0x150EC30 Offset: 0x150D230 VA: 0x18150EC30
	private static void .cctor() { }

}

internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 2230
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B11240

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1512CD0 Offset: 0x15112D0 VA: 0x181512CD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1512D30 Offset: 0x1511330 VA: 0x181512D30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1512450 Offset: 0x1510A50 VA: 0x181512450
	public void .ctor() { }

	// RVA: 0x1512BE0 Offset: 0x15111E0 VA: 0x181512BE0
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

	// RVA: 0x15151E0 Offset: 0x15137E0 VA: 0x1815151E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x7D9EE0 Offset: 0x7D84E0 VA: 0x1807D9EE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514DB0 Offset: 0x15133B0 VA: 0x181514DB0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15152A0 Offset: 0x15138A0 VA: 0x1815152A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515240 Offset: 0x1513840 VA: 0x181515240 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514E30 Offset: 0x1513430 VA: 0x181514E30 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515150 Offset: 0x1513750 VA: 0x181515150
	public void .ctor() { }

	// RVA: 0x1515000 Offset: 0x1513600 VA: 0x181515000
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

	// RVA: 0x1514C80 Offset: 0x1513280 VA: 0x181514C80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1514D40 Offset: 0x1513340 VA: 0x181514D40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15148D0 Offset: 0x1512ED0 VA: 0x1815148D0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514D50 Offset: 0x1513350 VA: 0x181514D50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514CE0 Offset: 0x15132E0 VA: 0x181514CE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514950 Offset: 0x1512F50 VA: 0x181514950 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514C20 Offset: 0x1513220 VA: 0x181514C20
	public void .ctor() { }

	// RVA: 0x1514AD0 Offset: 0x15130D0 VA: 0x181514AD0
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

	// RVA: 0x15156E0 Offset: 0x1513CE0 VA: 0x1815156E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15157A0 Offset: 0x1513DA0 VA: 0x1815157A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1515300 Offset: 0x1513900 VA: 0x181515300 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15157B0 Offset: 0x1513DB0 VA: 0x1815157B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515740 Offset: 0x1513D40 VA: 0x181515740 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1515380 Offset: 0x1513980 VA: 0x181515380 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515650 Offset: 0x1513C50 VA: 0x181515650
	public void .ctor() { }

	// RVA: 0x1515500 Offset: 0x1513B00 VA: 0x181515500
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

	// RVA: 0x15147B0 Offset: 0x1512DB0 VA: 0x1815147B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x50E1B0 Offset: 0x50C7B0 VA: 0x18050E1B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1514400 Offset: 0x1512A00 VA: 0x181514400 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1514870 Offset: 0x1512E70 VA: 0x181514870 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1514810 Offset: 0x1512E10 VA: 0x181514810 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1514480 Offset: 0x1512A80 VA: 0x181514480 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1514750 Offset: 0x1512D50 VA: 0x181514750
	public void .ctor() { }

	// RVA: 0x1514600 Offset: 0x1512C00 VA: 0x181514600
	private static void .cctor() { }

}

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 2235
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x142B0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1513030 Offset: 0x1511630 VA: 0x181513030 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1513090 Offset: 0x1511690 VA: 0x181513090 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1512FA0 Offset: 0x15115A0 VA: 0x181512FA0
	public void .ctor() { }

	// RVA: 0x1512EB0 Offset: 0x15114B0 VA: 0x181512EB0
	private static void .cctor() { }

}

internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 2236
{	// Methods

	// RVA: 0x15103B0 Offset: 0x150E9B0 VA: 0x1815103B0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1510560 Offset: 0x150EB60 VA: 0x181510560
	public void .ctor() { }

}

internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 2237
{	// Methods

	// RVA: 0x15112E0 Offset: 0x150F8E0 VA: 0x1815112E0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1511450 Offset: 0x150FA50 VA: 0x181511450
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

	// RVA: 0x150CF80 Offset: 0x150B580 VA: 0x18150CF80 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150D2D0 Offset: 0x150B8D0 VA: 0x18150D2D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150D270 Offset: 0x150B870 VA: 0x18150D270 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x150D1E0 Offset: 0x150B7E0 VA: 0x18150D1E0
	public void .ctor() { }

	// RVA: 0x150D140 Offset: 0x150B740 VA: 0x18150D140
	private static void .cctor() { }

}

internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 2239
{	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xE665F0 Offset: 0xE64BF0 VA: 0x180E665F0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x150B4D0 Offset: 0x1509AD0 VA: 0x18150B4D0
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

	// RVA: 0x150F300 Offset: 0x150D900 VA: 0x18150F300 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x150F2A0 Offset: 0x150D8A0 VA: 0x18150F2A0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x150EF20 Offset: 0x150D520 VA: 0x18150EF20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x150EFA0 Offset: 0x150D5A0 VA: 0x18150EFA0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x150F0C0 Offset: 0x150D6C0 VA: 0x18150F0C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x150F210 Offset: 0x150D810 VA: 0x18150F210
	public void .ctor() { }

	// RVA: 0x150F170 Offset: 0x150D770 VA: 0x18150F170
	private static void .cctor() { }

}

internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 2241
{	// Methods

	// RVA: 0x1510EF0 Offset: 0x150F4F0 VA: 0x181510EF0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15110F0 Offset: 0x150F6F0 VA: 0x1815110F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1511280 Offset: 0x150F880 VA: 0x181511280
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

	// RVA: 0x1515C70 Offset: 0x1514270 VA: 0x181515C70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1515C10 Offset: 0x1514210 VA: 0x181515C10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1515880 Offset: 0x1513E80 VA: 0x181515880 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1515910 Offset: 0x1513F10 VA: 0x181515910 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1515A30 Offset: 0x1514030 VA: 0x181515A30 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1515B80 Offset: 0x1514180 VA: 0x181515B80
	public void .ctor() { }

	// RVA: 0x1515AE0 Offset: 0x15140E0 VA: 0x181515AE0
	private static void .cctor() { }

}

public sealed class DataUtility // TypeDefIndex: 3576
{	// Methods

	// RVA: 0x19A9D80 Offset: 0x19A8380 VA: 0x1819A9D80
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x19A9F00 Offset: 0x19A8500 VA: 0x1819A9F00
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x19A9F70 Offset: 0x19A8570 VA: 0x1819A9F70
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x19A9DF0 Offset: 0x19A83F0 VA: 0x1819A9DF0
	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4171
{	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[EventAttribute] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	// RVA: 0x1233FC0 Offset: 0x12325C0 VA: 0x181233FC0
	internal void Trace(string message) { }

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE01F10 Offset: 0xE00510 VA: 0x180E01F10
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0xE01430 Offset: 0xDFFA30 VA: 0x180E01430
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFA10 Offset: 0xDFE010 VA: 0x180DFFA10
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0xDFFB40 Offset: 0xDFE140 VA: 0x180DFFB40
	|-DataCommonEventSource.Trace<int, ListChangedType>
	|-DataCommonEventSource.Trace<int, MappingType>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0xE00880 Offset: 0xDFEE80 VA: 0x180E00880
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0xE009B0 Offset: 0xDFEFB0 VA: 0x180E009B0
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0xE01340 Offset: 0xDFF940 VA: 0x180E01340
	|-DataCommonEventSource.Trace<int, object>
	|-DataCommonEventSource.Trace<int, string>
	|
	|-RVA: 0xE01E50 Offset: 0xE00450 VA: 0x180E01E50
	|-DataCommonEventSource.Trace<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFC70 Offset: 0xDFE270 VA: 0x180DFFC70
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0xE005A0 Offset: 0xDFEBA0 VA: 0x180E005A0
	|-DataCommonEventSource.Trace<int, int, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0xE00710 Offset: 0xDFED10 VA: 0x180E00710
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0xE00AE0 Offset: 0xDFF0E0 VA: 0x180E00AE0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, DataViewRowState>
	|
	|-RVA: 0xE01240 Offset: 0xDFF840 VA: 0x180E01240
	|-DataCommonEventSource.Trace<int, object, object>
	|-DataCommonEventSource.Trace<int, string, string>
	|
	|-RVA: 0xE01D80 Offset: 0xE00380 VA: 0x180E01D80
	|-DataCommonEventSource.Trace<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00290 Offset: 0xDFE890 VA: 0x180E00290
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE00F90 Offset: 0xDFF590 VA: 0x180E00F90
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, string, DataViewRowState>
	|-DataCommonEventSource.Trace<int, string, string, MappingType>
	|
	|-RVA: 0xE01B30 Offset: 0xE00130 VA: 0x180E01B30
	|-DataCommonEventSource.Trace<object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE00C20 Offset: 0xDFF220 VA: 0x180E00C20
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-RVA: 0xE01880 Offset: 0xDFFE80 VA: 0x180E01880
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFDE0 Offset: 0xDFE3E0 VA: 0x180DFFDE0
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE01520 Offset: 0xDFFB20 VA: 0x180E01520
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B180 Offset: 0x9A580 VA: 0x18009B180
	// RVA: 0x1233ED0 Offset: 0x12324D0 VA: 0x181233ED0
	internal long EnterScope(string message) { }

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2360 Offset: 0xED0960 VA: 0x180ED2360
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0xED2830 Offset: 0xED0E30 VA: 0x180ED2830
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED15F0 Offset: 0xECFBF0 VA: 0x180ED15F0
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0xED18B0 Offset: 0xECFEB0 VA: 0x180ED18B0
	|-DataCommonEventSource.EnterScope<int, SchemaFormat>
	|-DataCommonEventSource.EnterScope<int, XmlReadMode>
	|-DataCommonEventSource.EnterScope<int, XmlWriteMode>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0xED1FE0 Offset: 0xED05E0 VA: 0x180ED1FE0
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0xED2270 Offset: 0xED0870 VA: 0x180ED2270
	|-DataCommonEventSource.EnterScope<int, object>
	|-DataCommonEventSource.EnterScope<int, string>
	|
	|-RVA: 0xED2770 Offset: 0xED0D70 VA: 0x180ED2770
	|-DataCommonEventSource.EnterScope<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED1730 Offset: 0xECFD30 VA: 0x180ED1730
	|-DataCommonEventSource.EnterScope<int, XmlReadMode, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0xED1D10 Offset: 0xED0310 VA: 0x180ED1D10
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0xED1E90 Offset: 0xED0490 VA: 0x180ED1E90
	|-DataCommonEventSource.EnterScope<int, int, object>
	|-DataCommonEventSource.EnterScope<int, int, string>
	|
	|-RVA: 0xED2120 Offset: 0xED0720 VA: 0x180ED2120
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|-DataCommonEventSource.EnterScope<int, string, bool>
	|
	|-RVA: 0xED26A0 Offset: 0xED0CA0 VA: 0x180ED26A0
	|-DataCommonEventSource.EnterScope<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED19F0 Offset: 0xECFFF0 VA: 0x180ED19F0
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0xED2450 Offset: 0xED0A50 VA: 0x180ED2450
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B4F0 Offset: 0x9A8F0 VA: 0x18009B4F0
	// RVA: 0x1233FB0 Offset: 0x12325B0 VA: 0x181233FB0
	internal void ExitScope(long scopeId) { }

	// RVA: 0x1234080 Offset: 0x1232680 VA: 0x181234080
	public void .ctor() { }

	// RVA: 0x1233FD0 Offset: 0x12325D0 VA: 0x181233FD0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValueAttribute] // RVA: 0x9D5E0 Offset: 0x9C9E0 VA: 0x18009D5E0
	public bool AllowDBNull { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D630 Offset: 0x9CA30 VA: 0x18009D630
	[RefreshPropertiesAttribute] // RVA: 0x9D630 Offset: 0x9CA30 VA: 0x18009D630
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValueAttribute] // RVA: 0x9DB30 Offset: 0x9CF30 VA: 0x18009DB30
	public long AutoIncrementSeed { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DB80 Offset: 0x9CF80 VA: 0x18009DB80
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DC10 Offset: 0x9D010 VA: 0x18009DC10
	[RefreshPropertiesAttribute] // RVA: 0x9DC10 Offset: 0x9D010 VA: 0x18009DC10
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[RefreshPropertiesAttribute] // RVA: 0x9DD40 Offset: 0x9D140 VA: 0x18009DD40
	[DefaultValueAttribute] // RVA: 0x9DD40 Offset: 0x9D140 VA: 0x18009DD40
	[TypeConverterAttribute] // RVA: 0x9DD40 Offset: 0x9D140 VA: 0x18009DD40
	public Type DataType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DF80 Offset: 0x9D380 VA: 0x18009DF80
	[RefreshPropertiesAttribute] // RVA: 0x9DF80 Offset: 0x9D380 VA: 0x18009DF80
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverterAttribute] // RVA: 0x9E150 Offset: 0x9D550 VA: 0x18009E150
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValueAttribute] // RVA: 0x9DC10 Offset: 0x9D010 VA: 0x18009DC10
	[RefreshPropertiesAttribute] // RVA: 0x9DC10 Offset: 0x9D010 VA: 0x18009DC10
	public string Expression { get; set; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValueAttribute] // RVA: 0x9E720 Offset: 0x9DB20 VA: 0x18009E720
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public int Ordinal { get; }
	[DefaultValueAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public bool ReadOnly { get; set; }
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	private Index SortIndex { get; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9EA60 Offset: 0x9DE60 VA: 0x18009EA60
	[DefaultValueAttribute] // RVA: 0x9EA60 Offset: 0x9DE60 VA: 0x18009EA60
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9EB20 Offset: 0x9DF20 VA: 0x18009EB20
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x122FE30 Offset: 0x122E430 VA: 0x18122FE30
	public void .ctor() { }

	// RVA: 0x12301F0 Offset: 0x122E7F0 VA: 0x1812301F0
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x122FEC0 Offset: 0x122E4C0 VA: 0x18122FEC0
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x122FD10 Offset: 0x122E310 VA: 0x18122FD10
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_AllowDBNull() { }

	// RVA: 0x1230A20 Offset: 0x122F020 VA: 0x181230A20
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x12303C0 Offset: 0x122E9C0 VA: 0x1812303C0
	public bool get_AutoIncrement() { }

	// RVA: 0x1230F20 Offset: 0x122F520 VA: 0x181230F20
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x1230300 Offset: 0x122E900 VA: 0x181230300
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1230BA0 Offset: 0x122F1A0 VA: 0x181230BA0
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x1230220 Offset: 0x122E820 VA: 0x181230220
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1230370 Offset: 0x122E970 VA: 0x181230370
	public long get_AutoIncrementSeed() { }

	// RVA: 0x1230D50 Offset: 0x122F350 VA: 0x181230D50
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1230390 Offset: 0x122E990 VA: 0x181230390
	public long get_AutoIncrementStep() { }

	// RVA: 0x1230E30 Offset: 0x122F430 VA: 0x181230E30
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x12303E0 Offset: 0x122E9E0 VA: 0x1812303E0
	public string get_Caption() { }

	// RVA: 0x12310D0 Offset: 0x122F6D0 VA: 0x1812310D0
	public void set_Caption(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_ColumnName() { }

	// RVA: 0x1231440 Offset: 0x122FA40 VA: 0x181231440
	public void set_ColumnName(string value) { }

	// RVA: 0x1230570 Offset: 0x122EB70 VA: 0x181230570
	internal string get_EncodedColumnName() { }

	// RVA: 0x12306E0 Offset: 0x122ECE0 VA: 0x1812306E0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1230840 Offset: 0x122EE40 VA: 0x181230840
	internal CultureInfo get_Locale() { }

	// RVA: 0x1050470 Offset: 0x104EA70 VA: 0x181050470
	internal int get_ObjectID() { }

	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public string get_Prefix() { }

	// RVA: 0x1233380 Offset: 0x1231980 VA: 0x181233380
	public void set_Prefix(string value) { }

	// RVA: 0x122E6E0 Offset: 0x122CCE0 VA: 0x18122E6E0
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x12303F0 Offset: 0x122E9F0 VA: 0x1812303F0
	internal bool get_Computed() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal DataExpression get_DataExpression() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_DataType() { }

	// RVA: 0x1231840 Offset: 0x122FE40 VA: 0x181231840
	public void set_DataType(Type value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x12321C0 Offset: 0x12307C0 VA: 0x1812321C0
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x1230410 Offset: 0x122EA10 VA: 0x181230410
	public object get_DefaultValue() { }

	// RVA: 0x1232310 Offset: 0x1230910 VA: 0x181232310
	public void set_DefaultValue(object value) { }

	// RVA: 0x1230400 Offset: 0x122EA00 VA: 0x181230400
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x12305F0 Offset: 0x122EBF0 VA: 0x1812305F0
	public string get_Expression() { }

	// RVA: 0x12325E0 Offset: 0x1230BE0 VA: 0x1812325E0
	public void set_Expression(string value) { }

	// RVA: 0x1230660 Offset: 0x122EC60 VA: 0x181230660
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1230750 Offset: 0x122ED50 VA: 0x181230750
	internal bool get_HasData() { }

	// RVA: 0x1188630 Offset: 0x1186C30 VA: 0x181188630
	internal bool get_ImplementsINullable() { }

	// RVA: 0x1230760 Offset: 0x122ED60 VA: 0x181230760
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xE665E0 Offset: 0xE64BE0 VA: 0x180E665E0
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x12307F0 Offset: 0x122EDF0 VA: 0x1812307F0
	internal bool get_IsValueType() { }

	// RVA: 0x1188620 Offset: 0x1186C20 VA: 0x181188620
	internal bool get_IsSqlType() { }

	// RVA: 0x122F7C0 Offset: 0x122DDC0 VA: 0x18122F7C0
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_MaxLength() { }

	// RVA: 0x1232EA0 Offset: 0x12314A0 VA: 0x181232EA0
	public void set_MaxLength(int value) { }

	// RVA: 0x12308B0 Offset: 0x122EEB0 VA: 0x1812308B0
	public string get_Namespace() { }

	// RVA: 0x1233250 Offset: 0x1231850 VA: 0x181233250
	public void set_Namespace(string value) { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public int get_Ordinal() { }

	// RVA: 0x122F8C0 Offset: 0x122DEC0 VA: 0x18122F8C0
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool get_ReadOnly() { }

	// RVA: 0x12334D0 Offset: 0x1231AD0 VA: 0x1812334D0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1230920 Offset: 0x122EF20 VA: 0x181230920
	private Index get_SortIndex() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public DataTable get_Table() { }

	// RVA: 0x122FA60 Offset: 0x122E060 VA: 0x18122FA60
	internal void SetTable(DataTable table) { }

	// RVA: 0x122E7D0 Offset: 0x122CDD0 VA: 0x18122E7D0
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1230810 Offset: 0x122EE10 VA: 0x181230810
	internal object get_Item(int record) { }

	// RVA: 0x1232D10 Offset: 0x1231310 VA: 0x181232D10
	internal void set_Item(int record, object value) { }

	// RVA: 0x122EB80 Offset: 0x122D180 VA: 0x18122EB80
	internal void InitializeRecord(int record) { }

	// RVA: 0x122FB40 Offset: 0x122E140 VA: 0x18122FB40
	internal void SetValue(int record, object value) { }

	// RVA: 0x122E5D0 Offset: 0x122CBD0 VA: 0x18122E5D0
	internal void FreeRecord(int record) { }

	// RVA: 0x1230A10 Offset: 0x122F010 VA: 0x181230A10
	public bool get_Unique() { }

	// RVA: 0x1233600 Offset: 0x1231C00 VA: 0x181233600
	public void set_Unique(bool value) { }

	// RVA: 0x7AEEF0 Offset: 0x7AD4F0 VA: 0x1807AEEF0
	internal void InternalUnique(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void set_XmlDataType(string value) { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1233590 Offset: 0x1231B90 VA: 0x181233590
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x1050510 Offset: 0x104EB10 VA: 0x181050510 Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x12311C0 Offset: 0x122F7C0 VA: 0x1812311C0 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x122D480 Offset: 0x122BA80 VA: 0x18122D480
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x122D660 Offset: 0x122BC60 VA: 0x18122D660
	internal bool CheckMaxLength() { }

	// RVA: 0x122D5C0 Offset: 0x122BBC0 VA: 0x18122D5C0
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x122D8D0 Offset: 0x122BED0 VA: 0x18122D8D0
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x122DBB0 Offset: 0x122C1B0 VA: 0x18122DBB0
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x122DC60 Offset: 0x122C260 VA: 0x18122DC60
	protected void CheckUnique() { }

	// RVA: 0x122E3A0 Offset: 0x122C9A0 VA: 0x18122E3A0
	internal int Compare(int record1, int record2) { }

	// RVA: 0x122E1A0 Offset: 0x122C7A0 VA: 0x18122E1A0
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x122E170 Offset: 0x122C770 VA: 0x18122E170
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x122E490 Offset: 0x122CA90 VA: 0x18122E490
	internal object ConvertValue(object value) { }

	// RVA: 0x122E5A0 Offset: 0x122CBA0 VA: 0x18122E5A0
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x122DCE0 Offset: 0x122C2E0 VA: 0x18122DCE0
	internal DataColumn Clone() { }

	// RVA: 0x122E600 Offset: 0x122CC00 VA: 0x18122E600
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x122E840 Offset: 0x122CE40 VA: 0x18122E840
	private int GetStringLength(int record) { }

	// RVA: 0x122EAD0 Offset: 0x122D0D0 VA: 0x18122EAD0
	internal void Init(int record) { }

	// RVA: 0x122EC70 Offset: 0x122D270 VA: 0x18122EC70
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x1230780 Offset: 0x122ED80 VA: 0x181230780
	internal bool get_IsCustomType() { }

	// RVA: 0x122F590 Offset: 0x122DB90 VA: 0x18122F590
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x1230770 Offset: 0x122ED70 VA: 0x181230770
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x122F560 Offset: 0x122DB60 VA: 0x18122F560
	internal bool IsNull(int record) { }

	// RVA: 0x122EF10 Offset: 0x122D510 VA: 0x18122EF10
	internal bool IsInRelation() { }

	// RVA: 0x122F0A0 Offset: 0x122D6A0 VA: 0x18122F0A0
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x122F400 Offset: 0x122DA00 VA: 0x18122F400
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x1012F10 Offset: 0x1011510 VA: 0x181012F10 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x122F660 Offset: 0x122DC60 VA: 0x18122F660
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x122EBD0 Offset: 0x122D1D0 VA: 0x18122EBD0
	private void InsureStorage() { }

	// RVA: 0x122F770 Offset: 0x122DD70 VA: 0x18122F770
	internal void SetCapacity(int capacity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void OnSetDataSet() { }

	// RVA: 0x122FC40 Offset: 0x122E240 VA: 0x18122FC40 Slot: 3
	public override string ToString() { }

	// RVA: 0x122E4C0 Offset: 0x122CAC0 VA: 0x18122E4C0
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x122E510 Offset: 0x122CB10 VA: 0x18122E510
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122E3D0 Offset: 0x122C9D0 VA: 0x18122E3D0
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x122E420 Offset: 0x122CA20 VA: 0x18122E420
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x122E800 Offset: 0x122CE00 VA: 0x18122E800
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x122E570 Offset: 0x122CB70 VA: 0x18122E570
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x122FA10 Offset: 0x122E010 VA: 0x18122FA10
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x122D3C0 Offset: 0x122B9C0 VA: 0x18122D3C0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122F6E0 Offset: 0x122DCE0 VA: 0x18122F6E0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122E870 Offset: 0x122CE70 VA: 0x18122E870
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4185
{	// Fields
	private DataColumn _column; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x1229980 Offset: 0x1227F80 VA: 0x181229980
	internal void .ctor(DataRow row) { }

	// RVA: 0x12298D0 Offset: 0x1227ED0 VA: 0x1812298D0
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ProposedValue(object value) { }

	// RVA: 0x1229890 Offset: 0x1227E90 VA: 0x181229890
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x122C820 Offset: 0x122AE20 VA: 0x18122C820
	internal void .ctor(DataTable table) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x122CC50 Offset: 0x122B250 VA: 0x18122CC50
	public DataColumn get_Item(int index) { }

	// RVA: 0x122CB00 Offset: 0x122B100 VA: 0x18122CB00
	public DataColumn get_Item(string name) { }

	// RVA: 0x122CA50 Offset: 0x122B050 VA: 0x18122CA50
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x1229E90 Offset: 0x1228490 VA: 0x181229E90
	public void Add(DataColumn column) { }

	// RVA: 0x12299F0 Offset: 0x1227FF0 VA: 0x1812299F0
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0x1229EA0 Offset: 0x12284A0 VA: 0x181229EA0
	public DataColumn Add(string columnName, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122C910 Offset: 0x122AF10 VA: 0x18122C910
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122CD30 Offset: 0x122B330 VA: 0x18122CD30
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122C9B0 Offset: 0x122AFB0 VA: 0x18122C9B0
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122CDD0 Offset: 0x122B3D0 VA: 0x18122CDD0
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1229FB0 Offset: 0x12285B0 VA: 0x181229FB0
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x1229F40 Offset: 0x1228540 VA: 0x181229F40
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x122A040 Offset: 0x1228640 VA: 0x18122A040
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x122A370 Offset: 0x1228970 VA: 0x18122A370
	internal string AssignName() { }

	// RVA: 0x122A480 Offset: 0x1228A80 VA: 0x18122A480
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x122A8B0 Offset: 0x1228EB0 VA: 0x18122A8B0
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x122AC00 Offset: 0x1229200 VA: 0x18122AC00
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x122ADD0 Offset: 0x12293D0 VA: 0x18122ADD0
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x122B6C0 Offset: 0x1229CC0 VA: 0x18122B6C0
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x122B710 Offset: 0x1229D10 VA: 0x18122B710
	public void Clear() { }

	// RVA: 0x122BC50 Offset: 0x122A250 VA: 0x18122BC50
	public bool Contains(string name) { }

	// RVA: 0x122BCE0 Offset: 0x122A2E0 VA: 0x18122BCE0
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x122BF40 Offset: 0x122A540 VA: 0x18122BF40
	public int IndexOf(string columnName) { }

	// RVA: 0x122BDA0 Offset: 0x122A3A0 VA: 0x18122BDA0
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x122C040 Offset: 0x122A640 VA: 0x18122C040
	private string MakeName(int index) { }

	// RVA: 0x122C0D0 Offset: 0x122A6D0 VA: 0x18122C0D0
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C170 Offset: 0x122A770 VA: 0x18122C170
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C190 Offset: 0x122A790 VA: 0x18122C190
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x122C1E0 Offset: 0x122A7E0 VA: 0x18122C1E0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x122AD70 Offset: 0x1229370 VA: 0x18122AD70
	internal bool CanRegisterName(string name) { }

	// RVA: 0x122C500 Offset: 0x122AB00 VA: 0x18122C500
	public void Remove(DataColumn column) { }

	// RVA: 0x122C670 Offset: 0x122AC70 VA: 0x18122C670
	internal void UnregisterName(string name) { }

	// RVA: 0x1229DA0 Offset: 0x12283A0 VA: 0x181229DA0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x122C3E0 Offset: 0x122A9E0 VA: 0x18122C3E0
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4188
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x122D110 Offset: 0x122B710 VA: 0x18122D110
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x122D160 Offset: 0x122B760 VA: 0x18122D160 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal DataColumn get_Column() { }

	// RVA: 0x122D320 Offset: 0x122B920 VA: 0x18122D320 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x122D380 Offset: 0x122B980 VA: 0x18122D380 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x122D3A0 Offset: 0x122B9A0 VA: 0x18122D3A0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x122CE70 Offset: 0x122B470 VA: 0x18122CE70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4270 Offset: 0xAE2870 VA: 0x180AE4270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122CF00 Offset: 0x122B500 VA: 0x18122CF00 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x122CFE0 Offset: 0x122B5E0 VA: 0x18122CFE0 Slot: 19
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

	// RVA: 0x1234960 Offset: 0x1232F60 VA: 0x181234960
	internal void .ctor() { }

	// RVA: 0x12348B0 Offset: 0x1232EB0 VA: 0x1812348B0
	internal void .ctor(string rowError) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Text() { }

	// RVA: 0x12349E0 Offset: 0x1232FE0 VA: 0x1812349E0
	internal void set_Text(string value) { }

	// RVA: 0x12349B0 Offset: 0x1232FB0 VA: 0x1812349B0
	internal bool get_HasErrors() { }

	// RVA: 0x1234560 Offset: 0x1232B60 VA: 0x181234560
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1234240 Offset: 0x1232840 VA: 0x181234240
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1234180 Offset: 0x1232780 VA: 0x181234180
	internal void Clear(DataColumn column) { }

	// RVA: 0x12340E0 Offset: 0x12326E0 VA: 0x1812340E0
	internal void Clear() { }

	// RVA: 0x12342F0 Offset: 0x12328F0 VA: 0x1812342F0
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x1234850 Offset: 0x1232E50 VA: 0x181234850
	private void SetText(string errorText) { }

	// RVA: 0x1234400 Offset: 0x1232A00 VA: 0x181234400
	internal int IndexOf(DataColumn column) { }

}

internal struct DataError.ColumnError // TypeDefIndex: 4190
{	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8

}

public class DataException : SystemException // TypeDefIndex: 4191
{	// Methods

	// RVA: 0x1234A40 Offset: 0x1233040 VA: 0x181234A40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1234AC0 Offset: 0x12330C0 VA: 0x181234AC0
	public void .ctor() { }

	// RVA: 0x1234B10 Offset: 0x1233110 VA: 0x181234B10
	public void .ctor(string s) { }

	// RVA: 0x117A6F0 Offset: 0x1178CF0 VA: 0x18117A6F0
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

	// RVA: 0x1D2CA0 Offset: 0x1D20A0 VA: 0x1801D2CA0
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF4FD0 Offset: 0xF43D0 VA: 0x1800F4FD0
	internal bool get_HasValue() { }

	// RVA: 0x1D2CB0 Offset: 0x1D20B0 VA: 0x1801D2CB0
	internal DataTable get_Table() { }

	// RVA: 0x1D2860 Offset: 0x1D1C60 VA: 0x1801D2860
	internal void CheckState() { }

	// RVA: 0x1D2870 Offset: 0x1D1C70 VA: 0x1801D2870
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x12356F0 Offset: 0x1233CF0 VA: 0x1812356F0
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1D2880 Offset: 0x1D1C80 VA: 0x1801D2880
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1D2970 Offset: 0x1D1D70 VA: 0x1801D2970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D28F0 Offset: 0x1D1CF0 VA: 0x1801D28F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D28E0 Offset: 0x1D1CE0 VA: 0x1801D28E0
	internal bool Equals(DataKey value) { }

	// RVA: 0x1D29D0 Offset: 0x1D1DD0 VA: 0x1801D29D0
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1D29E0 Offset: 0x1D1DE0 VA: 0x1801D29E0
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1D2B60 Offset: 0x1D1F60 VA: 0x1801D2B60
	internal Index GetSortIndex() { }

	// RVA: 0x1D2B50 Offset: 0x1D1F50 VA: 0x1801D2B50
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1D2BD0 Offset: 0x1D1FD0 VA: 0x1801D2BD0
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1D2C90 Offset: 0x1D2090 VA: 0x1801D2C90
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PropertyChangedEventHandler PropertyChanging; // 0x50

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public virtual DataSet DataSet { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public virtual string RelationName { get; }
	[DefaultValueAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1238290 Offset: 0x1236890 VA: 0x181238290
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1238590 Offset: 0x1236B90 VA: 0x181238590
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x12384D0 Offset: 0x1236AD0 VA: 0x1812384D0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x12385D0 Offset: 0x1236BD0 VA: 0x1812385D0 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x12385B0 Offset: 0x1236BB0 VA: 0x1812385B0
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x12385B0 Offset: 0x1236BB0 VA: 0x1812385B0
	internal DataKey get_ChildKey() { }

	// RVA: 0x1238610 Offset: 0x1236C10 VA: 0x181238610 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1238660 Offset: 0x1236C60 VA: 0x181238660 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1237BF0 Offset: 0x12361F0 VA: 0x181237BF0
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x12376D0 Offset: 0x1235CD0 VA: 0x1812376D0
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1237950 Offset: 0x1235F50 VA: 0x181237950
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x12377B0 Offset: 0x1235DB0 VA: 0x1812377B0
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1237E50 Offset: 0x1236450 VA: 0x181237E50
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1238710 Offset: 0x1236D10 VA: 0x181238710 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1238750 Offset: 0x1236D50 VA: 0x181238750
	internal DataKey get_ParentKey() { }

	// RVA: 0x1238770 Offset: 0x1236D70 VA: 0x181238770 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x12387C0 Offset: 0x1236DC0 VA: 0x1812387C0 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x12362C0 Offset: 0x12348C0 VA: 0x1812362C0
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1236530 Offset: 0x1234B30 VA: 0x181236530
	internal void CheckNestedRelations() { }

	// RVA: 0x12386F0 Offset: 0x1236CF0 VA: 0x1812386F0 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x12387F0 Offset: 0x1236DF0 VA: 0x1812387F0 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1238730 Offset: 0x1236D30 VA: 0x181238730 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x12385F0 Offset: 0x1236BF0 VA: 0x1812385F0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1238680 Offset: 0x1236C80 VA: 0x181238680
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x12387E0 Offset: 0x1236DE0 VA: 0x1812387E0
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1236A10 Offset: 0x1235010 VA: 0x181236A10
	internal void CheckState() { }

	// RVA: 0x12368F0 Offset: 0x1234EF0 VA: 0x1812368F0
	protected void CheckStateForProperty() { }

	// RVA: 0x12373D0 Offset: 0x12359D0 VA: 0x1812373D0
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1236D40 Offset: 0x1235340 VA: 0x181236D40
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1237CB0 Offset: 0x12362B0 VA: 0x181237CB0
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1237D60 Offset: 0x1236360 VA: 0x181237D60
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1237E70 Offset: 0x1236470 VA: 0x181237E70
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1237A30 Offset: 0x1236030 VA: 0x181237A30
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

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(string name);

	// RVA: 0xAE2FD0 Offset: 0xAE15D0 VA: 0x180AE2FD0
	public void Add(DataRelation relation) { }

	// RVA: 0xAE2D20 Offset: 0xAE1320 VA: 0x180AE2D20 Slot: 14
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xAE4040 Offset: 0xAE2640 VA: 0x180AE4040
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE4110 Offset: 0xAE2710 VA: 0x180AE4110
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAE3210 Offset: 0xAE1810 VA: 0x180AE3210
	internal string AssignName() { }

	// RVA: 0xAE3230 Offset: 0xAE1830 VA: 0x180AE3230 Slot: 15
	public virtual void Clear() { }

	// RVA: 0xAE3470 Offset: 0xAE1A70 VA: 0x180AE3470 Slot: 16
	public virtual bool Contains(string name) { }

	// RVA: 0xAE3490 Offset: 0xAE1A90 VA: 0x180AE3490
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DataSet GetDataSet();

	// RVA: 0xAE3650 Offset: 0xAE1C50 VA: 0x180AE3650
	private string MakeName(int index) { }

	// RVA: 0xAE36E0 Offset: 0xAE1CE0 VA: 0x180AE36E0 Slot: 18
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3790 Offset: 0xAE1D90 VA: 0x180AE3790 Slot: 19
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xAE3840 Offset: 0xAE1E40 VA: 0x180AE3840
	internal void RegisterName(string name) { }

	// RVA: 0xAE3C60 Offset: 0xAE2260 VA: 0x180AE3C60
	public void Remove(DataRelation relation) { }

	// RVA: 0xAE3A10 Offset: 0xAE2010 VA: 0x180AE3A10
	public void RemoveAt(int index) { }

	// RVA: 0xAE3AA0 Offset: 0xAE20A0 VA: 0x180AE3AA0 Slot: 20
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xAE3E20 Offset: 0xAE2420 VA: 0x180AE3E20
	internal void UnregisterName(string name) { }

	// RVA: 0xAE3FD0 Offset: 0xAE25D0 VA: 0x180AE3FD0
	protected void .ctor() { }

}

internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4205
{	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0xAF6F20 Offset: 0xAF5520 VA: 0x180AF6F20
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAF6B80 Offset: 0xAF5180 VA: 0x180AF6B80
	private void EnsureDataSet() { }

	// RVA: 0xAF6BE0 Offset: 0xAF51E0 VA: 0x180AF6BE0 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAF7180 Offset: 0xAF5780 VA: 0x180AF7180 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAF7070 Offset: 0xAF5670 VA: 0x180AF7070 Slot: 13
	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAF6FD0 Offset: 0xAF55D0 VA: 0x180AF6FD0
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAF7280 Offset: 0xAF5880 VA: 0x180AF7280
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAF6A00 Offset: 0xAF5000 VA: 0x180AF6A00
	private void AddCache(DataRelation relation) { }

	// RVA: 0xAF6A60 Offset: 0xAF5060 VA: 0x180AF6A60 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAF6C40 Offset: 0xAF5240 VA: 0x180AF6C40
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xAF6D50 Offset: 0xAF5350 VA: 0x180AF6D50 Slot: 20
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

	// RVA: 0xAEAF60 Offset: 0xAE9560 VA: 0x180AEAF60
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAEAC10 Offset: 0xAE9210 VA: 0x180AEAC10 Slot: 15
	public override void Clear() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAEB000 Offset: 0xAE9600 VA: 0x180AEB000 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAEB100 Offset: 0xAE9700 VA: 0x180AEB100 Slot: 13
	public override DataRelation get_Item(string name) { }

	// RVA: 0xAEA530 Offset: 0xAE8B30 VA: 0x180AEA530 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAEAC60 Offset: 0xAE9260 VA: 0x180AEAC60 Slot: 20
	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4207
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0xAE4390 Offset: 0xAE2990 VA: 0x180AE4390
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal DataRelation get_Relation() { }

	// RVA: 0xAE43F0 Offset: 0xAE29F0 VA: 0x180AE43F0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xAE4450 Offset: 0xAE2A50 VA: 0x180AE4450 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0xAE41E0 Offset: 0xAE27E0 VA: 0x180AE41E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE4270 Offset: 0xAE2870 VA: 0x180AE4270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE42A0 Offset: 0xAE28A0 VA: 0x180AE42A0 Slot: 17
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

	// RVA: 0xAE9230 Offset: 0xAE7830 VA: 0x180AE9230
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xAE97D0 Offset: 0xAE7DD0 VA: 0x180AE97D0
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xAEA2F0 Offset: 0xAE88F0 VA: 0x180AEA2F0
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xAE9300 Offset: 0xAE7900 VA: 0x180AE9300
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	internal int get_RBTreeNodeId() { }

	// RVA: 0xAEA300 Offset: 0xAE8900 VA: 0x180AEA300
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xAE97F0 Offset: 0xAE7DF0 VA: 0x180AE97F0
	public string get_RowError() { }

	// RVA: 0xAEA3A0 Offset: 0xAE89A0 VA: 0x180AEA3A0
	public void set_RowError(string value) { }

	// RVA: 0xAE83F0 Offset: 0xAE69F0 VA: 0x180AE83F0
	private void RowErrorChanged() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal long get_rowID() { }

	// RVA: 0xAEA4F0 Offset: 0xAE8AF0 VA: 0x180AEA4F0
	internal void set_rowID(long value) { }

	// RVA: 0xAE9840 Offset: 0xAE7E40 VA: 0x180AE9840
	public DataRowState get_RowState() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DataTable get_Table() { }

	// RVA: 0xAE94A0 Offset: 0xAE7AA0 VA: 0x180AE94A0
	public object get_Item(int columnIndex) { }

	// RVA: 0xAEA2A0 Offset: 0xAE88A0 VA: 0x180AEA2A0
	public void set_Item(int columnIndex, object value) { }

	// RVA: 0xAE6580 Offset: 0xAE4B80 VA: 0x180AE6580
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xAE7390 Offset: 0xAE5990 VA: 0x180AE7390
	internal int GetNestedParentCount() { }

	// RVA: 0xAE9660 Offset: 0xAE7C60 VA: 0x180AE9660
	public object get_Item(string columnName) { }

	// RVA: 0xAEA260 Offset: 0xAE8860 VA: 0x180AEA260
	public void set_Item(string columnName, object value) { }

	// RVA: 0xAE9540 Offset: 0xAE7B40 VA: 0x180AE9540
	public object get_Item(DataColumn column) { }

	// RVA: 0xAE9E50 Offset: 0xAE8450 VA: 0x180AE9E50
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xAE96F0 Offset: 0xAE7CF0 VA: 0x180AE96F0
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xAE9310 Offset: 0xAE7910 VA: 0x180AE9310
	public object[] get_ItemArray() { }

	// RVA: 0xAE99F0 Offset: 0xAE7FF0 VA: 0x180AE99F0
	public void set_ItemArray(object[] value) { }

	// RVA: 0xAE5F90 Offset: 0xAE4590 VA: 0x180AE5F90
	public void AcceptChanges() { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0xAE6420 Offset: 0xAE4A20 VA: 0x180AE6420
	public void BeginEdit() { }

	// RVA: 0xAE6340 Offset: 0xAE4940 VA: 0x180AE6340
	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0xAE6430 Offset: 0xAE4A30 VA: 0x180AE6430
	public void CancelEdit() { }

	// RVA: 0xAE64C0 Offset: 0xAE4AC0 VA: 0x180AE64C0
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xAE6690 Offset: 0xAE4C90 VA: 0x180AE6690
	internal void CheckInTable() { }

	// RVA: 0xAE6B40 Offset: 0xAE5140 VA: 0x180AE6B40
	public void Delete() { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0xAE6C20 Offset: 0xAE5220 VA: 0x180AE6C20
	public void EndEdit() { }

	// RVA: 0xAE8440 Offset: 0xAE6A40 VA: 0x180AE8440
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xAE84D0 Offset: 0xAE6AD0 VA: 0x180AE84D0
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xAE6ED0 Offset: 0xAE54D0 VA: 0x180AE6ED0
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xAE6740 Offset: 0xAE4D40 VA: 0x180AE6740
	public void ClearErrors() { }

	// RVA: 0xAE66E0 Offset: 0xAE4CE0 VA: 0x180AE66E0
	internal void ClearError(DataColumn column) { }

	// RVA: 0xAE92E0 Offset: 0xAE78E0 VA: 0x180AE92E0
	public bool get_HasErrors() { }

	// RVA: 0xAE7110 Offset: 0xAE5710 VA: 0x180AE7110
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xAE6D40 Offset: 0xAE5340 VA: 0x180AE6D40
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xAE6D50 Offset: 0xAE5350 VA: 0x180AE6D50
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE71B0 Offset: 0xAE57B0 VA: 0x180AE71B0
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xAE7710 Offset: 0xAE5D10 VA: 0x180AE7710
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xAE75A0 Offset: 0xAE5BA0 VA: 0x180AE75A0
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7470 Offset: 0xAE5A70 VA: 0x180AE7470
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xAE78A0 Offset: 0xAE5EA0 VA: 0x180AE78A0
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xAE7720 Offset: 0xAE5D20 VA: 0x180AE7720
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE7000 Offset: 0xAE5600 VA: 0x180AE7000
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xAE70B0 Offset: 0xAE56B0 VA: 0x180AE70B0
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xAE72E0 Offset: 0xAE58E0 VA: 0x180AE72E0
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xAE7360 Offset: 0xAE5960 VA: 0x180AE7360
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xAE7160 Offset: 0xAE5760 VA: 0x180AE7160
	internal int GetCurrentRecordNo() { }

	// RVA: 0xAE7240 Offset: 0xAE5840 VA: 0x180AE7240
	internal int GetDefaultRecord() { }

	// RVA: 0xAE7550 Offset: 0xAE5B50 VA: 0x180AE7550
	internal int GetOriginalRecordNo() { }

	// RVA: 0xAE78B0 Offset: 0xAE5EB0 VA: 0x180AE78B0
	private int GetProposedRecordNo() { }

	// RVA: 0xAE7900 Offset: 0xAE5F00 VA: 0x180AE7900
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xAE72B0 Offset: 0xAE58B0 VA: 0x180AE72B0
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xAE7AA0 Offset: 0xAE60A0 VA: 0x180AE7AA0
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xAE7AF0 Offset: 0xAE60F0 VA: 0x180AE7AF0
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xAE7B20 Offset: 0xAE6120 VA: 0x180AE7B20
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE7BC0 Offset: 0xAE61C0 VA: 0x180AE7BC0
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xAE7E30 Offset: 0xAE6430 VA: 0x180AE7E30
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xAE7C80 Offset: 0xAE6280 VA: 0x180AE7C80
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE7E60 Offset: 0xAE6460 VA: 0x180AE7E60
	public bool IsNull(string columnName) { }

	// RVA: 0xAE7EF0 Offset: 0xAE64F0 VA: 0x180AE7EF0
	public void RejectChanges() { }

	// RVA: 0xAE83C0 Offset: 0xAE69C0 VA: 0x180AE83C0
	internal void ResetLastChangedColumn() { }

	// RVA: 0xAE8790 Offset: 0xAE6D90 VA: 0x180AE8790
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xAE88E0 Offset: 0xAE6EE0 VA: 0x180AE88E0
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xAE8CF0 Offset: 0xAE72F0 VA: 0x180AE8CF0
	internal void SetParentRowToDBNull() { }

	// RVA: 0xAE9080 Offset: 0xAE7680 VA: 0x180AE9080
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xAE67A0 Offset: 0xAE4DA0 VA: 0x180AE67A0
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

public sealed class DataRowBuilder // TypeDefIndex: 4209
{	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xAE44B0 Offset: 0xAE2AB0 VA: 0x180AE44B0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0xAE4500 Offset: 0xAE2B00 VA: 0x180AE4500
	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4212
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0xAE5560 Offset: 0xAE3B60 VA: 0x180AE5560
	internal void .ctor(DataTable table) { }

	// RVA: 0xAE5630 Offset: 0xAE3C30 VA: 0x180AE5630 Slot: 8
	public override int get_Count() { }

	// RVA: 0xAE5680 Offset: 0xAE3C80 VA: 0x180AE5680
	public DataRow get_Item(int index) { }

	// RVA: 0xAE4BB0 Offset: 0xAE31B0 VA: 0x180AE4BB0
	public void Add(DataRow row) { }

	// RVA: 0xAE4F20 Offset: 0xAE3520 VA: 0x180AE4F20
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xAE51C0 Offset: 0xAE37C0 VA: 0x180AE51C0
	public int IndexOf(DataRow row) { }

	// RVA: 0xAE4AA0 Offset: 0xAE30A0 VA: 0x180AE4AA0
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xAE4BF0 Offset: 0xAE31F0 VA: 0x180AE4BF0
	public DataRow Add(object[] values) { }

	// RVA: 0xAE4C70 Offset: 0xAE3270 VA: 0x180AE4C70
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xAE4D30 Offset: 0xAE3330 VA: 0x180AE4D30
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xAE4CE0 Offset: 0xAE32E0 VA: 0x180AE4CE0
	internal void ArrayClear() { }

	// RVA: 0xAE4DB0 Offset: 0xAE33B0 VA: 0x180AE4DB0
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xAE4EB0 Offset: 0xAE34B0 VA: 0x180AE4EB0 Slot: 9
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xAE4E40 Offset: 0xAE3440 VA: 0x180AE4E40
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xAE5170 Offset: 0xAE3770 VA: 0x180AE5170 Slot: 10
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xAE53F0 Offset: 0xAE39F0 VA: 0x180AE53F0
	public void Remove(DataRow row) { }

	// RVA: 0xAE5250 Offset: 0xAE3850 VA: 0x180AE5250
	public void RemoveAt(int index) { }

}

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4214
{	// Methods

	// RVA: 0xAE5760 Offset: 0xAE3D60 VA: 0x180AE5760
	internal void .ctor() { }

	// RVA: 0xAE56E0 Offset: 0xAE3CE0 VA: 0x180AE56E0 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xAE5720 Offset: 0xAE3D20 VA: 0x180AE5720 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4215
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataRow r) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4216
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataTable table) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE5A70 Offset: 0xAE4070 VA: 0x180AE5A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DataView get_DataView() { }

	// RVA: 0xAE5F30 Offset: 0xAE4530 VA: 0x180AE5F30
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xAE5AA0 Offset: 0xAE40A0 VA: 0x180AE5AA0
	internal int GetRecord() { }

	// RVA: 0xAE5B20 Offset: 0xAE4120 VA: 0x180AE5B20
	internal bool HasRecord() { }

	// RVA: 0xAE59F0 Offset: 0xAE3FF0 VA: 0x180AE59F0
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xAE5C30 Offset: 0xAE4230 VA: 0x180AE5C30
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xAE57A0 Offset: 0xAE3DA0 VA: 0x180AE57A0
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xAE5980 Offset: 0xAE3F80 VA: 0x180AE5980
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DataRow get_Row() { }

	// RVA: 0xAE5990 Offset: 0xAE3F90 VA: 0x180AE5990 Slot: 9
	public void EndEdit() { }

	// RVA: 0xAE5F00 Offset: 0xAE4500 VA: 0x180AE5F00
	public bool get_IsNew() { }

	// RVA: 0xAE5BA0 Offset: 0xAE41A0 VA: 0x180AE5BA0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xAE5D00 Offset: 0xAE4300 VA: 0x180AE5D00 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xAE5D50 Offset: 0xAE4350 VA: 0x180AE5D50 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xAE5E00 Offset: 0xAE4400 VA: 0x180AE5E00 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xAE5EA0 Offset: 0xAE44A0 VA: 0x180AE5EA0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValueAttribute] // RVA: 0xA2B90 Offset: 0xA1F90 VA: 0x1800A2B90
	public SerializationFormat RemotingFormat { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValueAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public bool CaseSensitive { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D5E0 Offset: 0x9C9E0 VA: 0x18009D5E0
	public bool EnforceConstraints { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string DataSetName { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string Prefix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public override ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0xAF5870 Offset: 0xAF3E70 VA: 0x180AF5870
	public void .ctor() { }

	// RVA: 0xAF5AF0 Offset: 0xAF40F0 VA: 0x180AF5AF0
	public void .ctor(string dataSetName) { }

	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xAF68C0 Offset: 0xAF4EC0 VA: 0x180AF68C0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xAF5840 Offset: 0xAF3E40 VA: 0x180AF5840
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF5B20 Offset: 0xAF4120 VA: 0x180AF5B20
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xAEDEF0 Offset: 0xAEC4F0 VA: 0x180AEDEF0 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xAF3000 Offset: 0xAF1600 VA: 0x180AF3000
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAECC20 Offset: 0xAEB220 VA: 0x180AECC20
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAEC690 Offset: 0xAEAC90 VA: 0x180AEC690
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAEC2E0 Offset: 0xAEA8E0 VA: 0x180AEC2E0
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAF2EA0 Offset: 0xAF14A0 VA: 0x180AF2EA0
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEC480 Offset: 0xAEAA80 VA: 0x180AEC480
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF37E0 Offset: 0xAF1DE0 VA: 0x180AF37E0
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAECDF0 Offset: 0xAEB3F0 VA: 0x180AECDF0
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEDC30 Offset: 0xAEC230 VA: 0x180AEDC30
	internal void FailedEnableConstraints() { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	public bool get_CaseSensitive() { }

	// RVA: 0xAF5D70 Offset: 0xAF4370 VA: 0x180AF5D70
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_EnforceConstraints() { }

	// RVA: 0xAF6140 Offset: 0xAF4740 VA: 0x180AF6140
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xAED4D0 Offset: 0xAEBAD0 VA: 0x180AED4D0
	internal void EnableConstraints() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_DataSetName() { }

	// RVA: 0xAF6000 Offset: 0xAF4600 VA: 0x180AF6000
	public void set_DataSetName(string value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Namespace() { }

	// RVA: 0xAF6440 Offset: 0xAF4A40 VA: 0x180AF6440
	public void set_Namespace(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Prefix() { }

	// RVA: 0xAF67A0 Offset: 0xAF4DA0 VA: 0x180AF67A0
	public void set_Prefix(string value) { }

	// RVA: 0xAF5CF0 Offset: 0xAF42F0 VA: 0x180AF5CF0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public CultureInfo get_Locale() { }

	// RVA: 0xAF62B0 Offset: 0xAF48B0 VA: 0x180AF62B0
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xAF3CF0 Offset: 0xAF22F0 VA: 0x180AF3CF0
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DataRelationCollection get_Relations() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public DataTableCollection get_Tables() { }

	// RVA: 0xAEB210 Offset: 0xAE9810 VA: 0x180AEB210
	public void Clear() { }

	// RVA: 0xAEB400 Offset: 0xAE9A00 VA: 0x180AEB400 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0xAEDAE0 Offset: 0xAEC0E0 VA: 0x180AEDAE0
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xAEDF20 Offset: 0xAEC520 VA: 0x180AEDF20
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xAEE040 Offset: 0xAEC640 VA: 0x180AEE040
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xAF02D0 Offset: 0xAEE8D0 VA: 0x180AF02D0
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xAF02E0 Offset: 0xAEE8E0 VA: 0x180AF02E0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEEA40 Offset: 0xAED040 VA: 0x180AEEA40
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xAEEB00 Offset: 0xAED100 VA: 0x180AEEB00
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xAEEE20 Offset: 0xAED420 VA: 0x180AEEE20
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xAEF030 Offset: 0xAED630 VA: 0x180AEF030
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEEED0 Offset: 0xAED4D0 VA: 0x180AEEED0
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAF5440 Offset: 0xAF3A40 VA: 0x180AF5440
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0xAF0E30 Offset: 0xAEF430 VA: 0x180AF0E30
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xAF0E60 Offset: 0xAEF460 VA: 0x180AF0E60
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEE1C0 Offset: 0xAEC7C0 VA: 0x180AEE1C0
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xAEE470 Offset: 0xAECA70 VA: 0x180AEE470
	private bool IsEmpty() { }

	// RVA: 0xAEF2A0 Offset: 0xAED8A0 VA: 0x180AEF2A0
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xAF0E40 Offset: 0xAEF440 VA: 0x180AF0E40
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xAF1F10 Offset: 0xAF0510 VA: 0x180AF1F10
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAF5650 Offset: 0xAF3C50 VA: 0x180AF5650
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xAEE8D0 Offset: 0xAECED0 VA: 0x180AEE8D0
	public void Merge(DataSet dataSet) { }

	// RVA: 0xAEE6A0 Offset: 0xAECCA0 VA: 0x180AEE6A0
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEEC40 Offset: 0xAED240 VA: 0x180AEEC40 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xAEEBC0 Offset: 0xAED1C0 VA: 0x180AEEBC0
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xAEECB0 Offset: 0xAED2B0 VA: 0x180AEECB0
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEEBA0 Offset: 0xAED1A0 VA: 0x180AEEBA0
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xAEEB80 Offset: 0xAED180 VA: 0x180AEEB80
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xAEEC80 Offset: 0xAED280 VA: 0x180AEEC80
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xAEEDA0 Offset: 0xAED3A0 VA: 0x180AEEDA0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xAF4B80 Offset: 0xAF3180 VA: 0x180AF4B80
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xAF4990 Offset: 0xAF2F90 VA: 0x180AF4990
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xAF2C00 Offset: 0xAF1200 VA: 0x180AF2C00 Slot: 21
	public virtual void Reset() { }

	// RVA: 0xAF4B90 Offset: 0xAF3190 VA: 0x180AF4B90
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xAF4FA0 Offset: 0xAF35A0 VA: 0x180AF4FA0
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xAF0B80 Offset: 0xAEF180 VA: 0x180AF0B80 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xAEDC80 Offset: 0xAEC280 VA: 0x180AEDC80
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xAF4660 Offset: 0xAF2C60 VA: 0x180AF4660 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xAF47F0 Offset: 0xAF2DF0 VA: 0x180AF47F0 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xAF4940 Offset: 0xAF2F40 VA: 0x180AF4940 Slot: 12
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
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	internal List<Index> LiveIndexes { get; }
	[DefaultValueAttribute] // RVA: 0xA34B0 Offset: 0xA28B0 VA: 0x1800A34B0
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public ConstraintCollection Constraints { get; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValueAttribute] // RVA: 0xA3890 Offset: 0xA2C90 VA: 0x1800A3890
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverterAttribute] // RVA: 0xA3A40 Offset: 0xA2E40 VA: 0x1800A3A40
	public DataColumn[] PrimaryKey { get; set; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public DataRowCollection Rows { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA3C70 Offset: 0xA3070 VA: 0x1800A3C70
	[DefaultValueAttribute] // RVA: 0xA3C70 Offset: 0xA3070 VA: 0x1800A3C70
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0xB0DA20 Offset: 0xB0C020 VA: 0x180B0DA20
	public void .ctor() { }

	// RVA: 0xB0DE90 Offset: 0xB0C490 VA: 0x180B0DE90
	public void .ctor(string tableName) { }

	// RVA: 0xB0DF00 Offset: 0xB0C500 VA: 0x180B0DF00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB00AA0 Offset: 0xAFF0A0 VA: 0x180B00AA0 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB09F50 Offset: 0xB08550 VA: 0x180B09F50
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xAFC130 Offset: 0xAFA730 VA: 0x180AFC130
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xB0AA50 Offset: 0xB09050 VA: 0x180B0AA50
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xAFD270 Offset: 0xAFB870 VA: 0x180AFD270
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xB097A0 Offset: 0xB07DA0 VA: 0x180B097A0
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xAFB660 Offset: 0xAF9C60 VA: 0x180AFB660
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xB0A2C0 Offset: 0xB088C0 VA: 0x180B0A2C0
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFC440 Offset: 0xAFAA40 VA: 0x180AFC440
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xB0A430 Offset: 0xB08A30 VA: 0x180B0A430
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFC5C0 Offset: 0xAFABC0 VA: 0x180AFC5C0
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAFAC10 Offset: 0xAF9210 VA: 0x180AFAC10
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xB00E60 Offset: 0xAFF460 VA: 0x180B00E60
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xAFA880 Offset: 0xAF8E80 VA: 0x180AFA880
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xB0E090 Offset: 0xB0C690 VA: 0x180B0E090
	public bool get_CaseSensitive() { }

	// RVA: 0xB0EDD0 Offset: 0xB0D3D0 VA: 0x180B0EDD0
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xB0E080 Offset: 0xB0C680 VA: 0x180B0E080
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xB092F0 Offset: 0xB078F0 VA: 0x180B092F0
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xB0D060 Offset: 0xB0B660 VA: 0x180B0D060
	internal void SuspendIndexEvents() { }

	// RVA: 0xB0E420 Offset: 0xB0CA20 VA: 0x180B0E420
	private bool get_IsTypedDataTable() { }

	// RVA: 0xB0B5F0 Offset: 0xB09BF0 VA: 0x180B0B5F0
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xB0CEA0 Offset: 0xB0B4A0 VA: 0x180B0CEA0
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xB0EB00 Offset: 0xB0D100 VA: 0x180B0EB00
	internal bool get_SelfNested() { }

	// RVA: 0xB0E4D0 Offset: 0xB0CAD0 VA: 0x180B0E4D0
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0xB0EA60 Offset: 0xB0D060 VA: 0x180B0EA60
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xB0FBE0 Offset: 0xB0E1E0 VA: 0x180B0FBE0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x7ED1F0 Offset: 0x7EB7F0 VA: 0x1807ED1F0
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x7ED270 Offset: 0x7EB870 VA: 0x1807ED270
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xB0E0A0 Offset: 0xB0C6A0 VA: 0x180B0E0A0
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public DataColumnCollection get_Columns() { }

	// RVA: 0xB0E170 Offset: 0xB0C770 VA: 0x180B0E170
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xB08D80 Offset: 0xB07380 VA: 0x180B08D80
	private void ResetConstraints() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataSet get_DataSet() { }

	// RVA: 0xB0B880 Offset: 0xB09E80 VA: 0x180B0B880
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xB0E1D0 Offset: 0xB0C7D0 VA: 0x180B0E1D0
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xB0E2C0 Offset: 0xB0C8C0 VA: 0x180B0E2C0
	internal bool get_EnforceConstraints() { }

	// RVA: 0xB0EF10 Offset: 0xB0D510 VA: 0x180B0EF10
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xB0ED00 Offset: 0xB0D300 VA: 0x180B0ED00
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xB0FC60 Offset: 0xB0E260 VA: 0x180B0FC60
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xAFE370 Offset: 0xAFC970 VA: 0x180AFE370
	internal void EnableConstraints() { }

	// RVA: 0xB0E2F0 Offset: 0xB0C8F0 VA: 0x180B0E2F0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xB0E370 Offset: 0xB0C970 VA: 0x180B0E370
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public CultureInfo get_Locale() { }

	// RVA: 0xB0EF50 Offset: 0xB0D550 VA: 0x180B0EF50
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xB0B9F0 Offset: 0xB09FF0 VA: 0x180B0B9F0
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xB0E5C0 Offset: 0xB0CBC0 VA: 0x180B0E5C0
	public int get_MinimumCapacity() { }

	// RVA: 0xB0F380 Offset: 0xB0D980 VA: 0x180B0F380
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xB0EA40 Offset: 0xB0D040 VA: 0x180B0EA40
	internal int get_RecordCapacity() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	internal int get_ElementColumnCount() { }

	// RVA: 0xB0EEB0 Offset: 0xB0D4B0 VA: 0x180B0EEB0
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xB0E910 Offset: 0xB0CF10 VA: 0x180B0E910
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xB0E5A0 Offset: 0xB0CBA0 VA: 0x180B0E5A0
	internal bool get_MergingData() { }

	// RVA: 0xB0F360 Offset: 0xB0D960 VA: 0x180B0F360
	internal void set_MergingData(bool value) { }

	// RVA: 0xB0E690 Offset: 0xB0CC90 VA: 0x180B0E690
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xB0EAF0 Offset: 0xB0D0F0 VA: 0x180B0EAF0
	internal bool get_SchemaLoading() { }

	// RVA: 0xAF7C70 Offset: 0xAF6270 VA: 0x180AF7C70
	internal void CacheNestedParent() { }

	// RVA: 0xB00040 Offset: 0xAFE640 VA: 0x180B00040
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xB0E6A0 Offset: 0xB0CCA0 VA: 0x180B0E6A0
	internal int get_NestedParentsCount() { }

	// RVA: 0xB0E9E0 Offset: 0xB0CFE0 VA: 0x180B0E9E0
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xB0F780 Offset: 0xB0DD80 VA: 0x180B0F780
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public DataRowCollection get_Rows() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_TableName() { }

	// RVA: 0xB0FC70 Offset: 0xB0E270 VA: 0x180B0FC70
	public void set_TableName(string value) { }

	// RVA: 0xB0E230 Offset: 0xB0C830 VA: 0x180B0E230
	internal string get_EncodedTableName() { }

	// RVA: 0xB00850 Offset: 0xAFEE50 VA: 0x180B00850
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0xB0E5E0 Offset: 0xB0CBE0 VA: 0x180B0E5E0
	public string get_Namespace() { }

	// RVA: 0xB0F3B0 Offset: 0xB0D9B0 VA: 0x180B0F3B0
	public void set_Namespace(string value) { }

	// RVA: 0xB02340 Offset: 0xB00940 VA: 0x180B02340
	internal bool IsNamespaceInherited() { }

	// RVA: 0xAF7D70 Offset: 0xAF6370 VA: 0x180AF7D70
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xAF8680 Offset: 0xAF6C80 VA: 0x180AF8680
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xAF8430 Offset: 0xAF6A30 VA: 0x180AF8430
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xAFDEC0 Offset: 0xAFC4C0 VA: 0x180AFDEC0
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_Prefix() { }

	// RVA: 0xB0F630 Offset: 0xB0DC30 VA: 0x180B0F630
	public void set_Prefix(string value) { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	internal DataColumn get_XmlText() { }

	// RVA: 0xB10180 Offset: 0xB0E780 VA: 0x180B10180
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xB0E590 Offset: 0xB0CB90 VA: 0x180B0E590
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xB0F350 Offset: 0xB0D950 VA: 0x180B0F350
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xB0E5B0 Offset: 0xB0CBB0 VA: 0x180B0E5B0
	internal Decimal get_MinOccurs() { }

	// RVA: 0xB0F370 Offset: 0xB0D970 VA: 0x180B0F370
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xB0B950 Offset: 0xB09F50 VA: 0x180B0B950
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xAFFEC0 Offset: 0xAFE4C0 VA: 0x180AFFEC0
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xAFFF50 Offset: 0xAFE550 VA: 0x180AFFF50
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xB0BFB0 Offset: 0xB0A5B0 VA: 0x180B0BFB0
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xB02400 Offset: 0xB00A00 VA: 0x180B02400
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xAF7320 Offset: 0xAF5920 VA: 0x180AF7320
	public void AcceptChanges() { }

	// RVA: 0xAFAFA0 Offset: 0xAF95A0 VA: 0x180AFAFA0 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xAFA260 Offset: 0xAF8860 VA: 0x180AFA260 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0xAFA270 Offset: 0xAF8870 VA: 0x180AFA270
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xB014C0 Offset: 0xAFFAC0 VA: 0x180B014C0
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xAF91D0 Offset: 0xAF77D0 VA: 0x180AF91D0
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xAF9590 Offset: 0xAF7B90 VA: 0x180AF9590
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0xAF7710 Offset: 0xAF5D10 VA: 0x180AF7710
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xB019B0 Offset: 0xAFFFB0 VA: 0x180B019B0
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xB01DE0 Offset: 0xB003E0 VA: 0x180B01DE0
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0xAF8980 Offset: 0xAF6F80 VA: 0x180AF8980
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xAF89B0 Offset: 0xAF6FB0 VA: 0x180AF89B0
	public void Clear() { }

	// RVA: 0xAF89C0 Offset: 0xAF6FC0 VA: 0x180AF89C0
	internal void Clear(bool clearAll) { }

	// RVA: 0xAF7CA0 Offset: 0xAF62A0 VA: 0x180AF7CA0
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xAFA450 Offset: 0xAF8A50 VA: 0x180AFA450
	internal void CommitRow(DataRow row) { }

	// RVA: 0xAFA720 Offset: 0xAF8D20 VA: 0x180AFA720
	internal int Compare(string s1, string s2) { }

	// RVA: 0xAFA590 Offset: 0xAF8B90 VA: 0x180AFA590
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xB01740 Offset: 0xAFFD40 VA: 0x180B01740
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xB02350 Offset: 0xB00950 VA: 0x180B02350
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xAFB5D0 Offset: 0xAF9BD0 VA: 0x180AFB5D0
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xB002D0 Offset: 0xAFE8D0 VA: 0x180B002D0
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xB003F0 Offset: 0xAFE9F0 VA: 0x180B003F0
	internal void FreeRecord(ref int record) { }

	// RVA: 0xB00800 Offset: 0xAFEE00 VA: 0x180B00800
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xB00630 Offset: 0xAFEC30 VA: 0x180B00630
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x77AA30 Offset: 0x779030 VA: 0x18077AA30
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0xB013B0 Offset: 0xAFF9B0 VA: 0x180B013B0
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xB019D0 Offset: 0xAFFFD0 VA: 0x180B019D0
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0xB02FF0 Offset: 0xB015F0 VA: 0x180B02FF0
	internal int NewRecord() { }

	// RVA: 0xB035D0 Offset: 0xB01BD0 VA: 0x180B035D0
	internal int NewUninitializedRecord() { }

	// RVA: 0xB02D70 Offset: 0xB01370 VA: 0x180B02D70
	internal int NewRecordFromArray(object[] value) { }

	// RVA: 0xB03090 Offset: 0xB01690 VA: 0x180B03090
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xB02D00 Offset: 0xB01300 VA: 0x180B02D00
	internal DataRow NewEmptyRow() { }

	// RVA: 0xB035F0 Offset: 0xB01BF0 VA: 0x180B035F0
	private DataRow NewUninitializedRow() { }

	// RVA: 0xB034D0 Offset: 0xB01AD0 VA: 0x180B034D0
	public DataRow NewRow() { }

	// RVA: 0xAFAD00 Offset: 0xAF9300 VA: 0x180AFAD00
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xB032D0 Offset: 0xB018D0 VA: 0x180B032D0
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xB03420 Offset: 0xB01A20 VA: 0x180B03420
	internal DataRow NewRow(int record) { }

	// RVA: 0xB03350 Offset: 0xB01950 VA: 0x180B03350 Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xB011C0 Offset: 0xAFF7C0 VA: 0x180B011C0 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0xB03180 Offset: 0xB01780 VA: 0x180B03180
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xB0E650 Offset: 0xB0CC50 VA: 0x180B0E650
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xB036F0 Offset: 0xB01CF0 VA: 0x180B036F0 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xB03630 Offset: 0xB01C30 VA: 0x180B03630 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xB037B0 Offset: 0xB01DB0 VA: 0x180B037B0 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xB03870 Offset: 0xB01E70 VA: 0x180B03870
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xB03890 Offset: 0xB01E90 VA: 0x180B03890
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB03A00 Offset: 0xB02000 VA: 0x180B03A00
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB03940 Offset: 0xB01F40 VA: 0x180B03940 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xB03AB0 Offset: 0xB020B0 VA: 0x180B03AB0 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xB03C30 Offset: 0xB02230 VA: 0x180B03C30 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xB03B70 Offset: 0xB02170 VA: 0x180B03B70 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xB03CF0 Offset: 0xB022F0 VA: 0x180B03CF0 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xB03DB0 Offset: 0xB023B0 VA: 0x180B03DB0 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xB03E70 Offset: 0xB02470 VA: 0x180B03E70 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xB03F30 Offset: 0xB02530 VA: 0x180B03F30
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xB04270 Offset: 0xB02870 VA: 0x180B04270
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xB08130 Offset: 0xB06730 VA: 0x180B08130
	internal void RecordChanged(int record) { }

	// RVA: 0xB082A0 Offset: 0xB068A0 VA: 0x180B082A0
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xB08480 Offset: 0xB06A80 VA: 0x180B08480
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xB08610 Offset: 0xB06C10 VA: 0x180B08610
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xB088A0 Offset: 0xB06EA0 VA: 0x180B088A0
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB017F0 Offset: 0xAFFDF0 VA: 0x180B017F0
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB0CEB0 Offset: 0xB0B4B0 VA: 0x180B0CEB0
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xB08AC0 Offset: 0xB070C0 VA: 0x180B08AC0
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xB08F90 Offset: 0xB07590 VA: 0x180B08F90 Slot: 30
	public virtual void Reset() { }

	// RVA: 0xB08DA0 Offset: 0xB073A0 VA: 0x180B08DA0
	internal void ResetIndexes() { }

	// RVA: 0xB08DB0 Offset: 0xB073B0 VA: 0x180B08DB0
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xB09630 Offset: 0xB07C30 VA: 0x180B09630
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xB042F0 Offset: 0xB028F0 VA: 0x180B042F0
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB04530 Offset: 0xB02B30 VA: 0x180B04530
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xB047C0 Offset: 0xB02DC0 VA: 0x180B047C0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xB09690 Offset: 0xB07C90 VA: 0x180B09690
	public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xB0C960 Offset: 0xB0AF60 VA: 0x180B0C960
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0xB0C070 Offset: 0xB0A670 VA: 0x180B0C070
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0xB0CA20 Offset: 0xB0B020 VA: 0x180B0CA20
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xB09610 Offset: 0xB07C10 VA: 0x180B09610
	private void RestoreShadowIndexes() { }

	// RVA: 0xB0CDC0 Offset: 0xB0B3C0 VA: 0x180B0CDC0
	private void SetShadowIndexes() { }

	// RVA: 0xB0CE20 Offset: 0xB0B420 VA: 0x180B0CE20
	internal void ShadowIndexCopy() { }

	// RVA: 0xB0D240 Offset: 0xB0B840 VA: 0x180B0D240 Slot: 3
	public override string ToString() { }

	// RVA: 0xAF7A30 Offset: 0xAF6030 VA: 0x180AF7A30
	public void BeginLoadData() { }

	// RVA: 0xAFE880 Offset: 0xAFCE80 VA: 0x180AFE880
	public void EndLoadData() { }

	// RVA: 0xB0D310 Offset: 0xB0B910 VA: 0x180B0D310
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xAF7750 Offset: 0xAF5D50 VA: 0x180AF7750
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xAF7740 Offset: 0xAF5D40 VA: 0x180AF7740
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xAF7650 Offset: 0xAF5C50 VA: 0x180AF7650
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xB0D2F0 Offset: 0xB0B8F0 VA: 0x180B0D2F0
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xB00B90 Offset: 0xAFF190 VA: 0x180B00B90
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xB0ED10 Offset: 0xB0D310 VA: 0x180B0ED10
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x7018A0 Offset: 0x6FFEA0 VA: 0x1807018A0
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xB02AB0 Offset: 0xB010B0 VA: 0x180B02AB0
	public void Merge(DataTable table) { }

	// RVA: 0xB02AD0 Offset: 0xB010D0 VA: 0x180B02AD0
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xB0D6A0 Offset: 0xB0BCA0 VA: 0x180B0D6A0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xAF8380 Offset: 0xAF6980 VA: 0x180AF8380
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xAF8020 Offset: 0xAF6620 VA: 0x180AF8020
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0xB0D340 Offset: 0xB0B940 VA: 0x180B0D340
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xB08090 Offset: 0xB06690 VA: 0x180B08090
	public XmlReadMode ReadXml(TextReader reader) { }

	// RVA: 0xB09290 Offset: 0xB07890 VA: 0x180B09290
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xB02160 Offset: 0xB00760 VA: 0x180B02160
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xB072E0 Offset: 0xB058E0 VA: 0x180B072E0
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB064D0 Offset: 0xB04AD0 VA: 0x180B064D0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAEEE20 Offset: 0xAED420 VA: 0x180AEEE20
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xB04980 Offset: 0xB02F80 VA: 0x180B04980
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAEEA40 Offset: 0xAED040 VA: 0x180AEEA40
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xB04B40 Offset: 0xB03140 VA: 0x180B04B40
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xB049F0 Offset: 0xB02FF0 VA: 0x180B049F0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB05410 Offset: 0xB03A10 VA: 0x180B05410
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAFB340 Offset: 0xAF9940 VA: 0x180AFB340
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0xAFB030 Offset: 0xAF9630 VA: 0x180AFB030
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0xB00410 Offset: 0xAFEA10 VA: 0x180B00410
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xB0D100 Offset: 0xB0B700 VA: 0x180B0D100 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xB01220 Offset: 0xAFF820 VA: 0x180B01220 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xB0D120 Offset: 0xB0B720 VA: 0x180B0D120 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xB0D1F0 Offset: 0xB0B7F0 VA: 0x180B0D1F0 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xB064B0 Offset: 0xB04AB0 VA: 0x180B064B0 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xB0EA70 Offset: 0xB0D070 VA: 0x180B0EA70
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xB0E900 Offset: 0xB0CF00 VA: 0x180B0E900
	internal int get_ObjectID() { }

	// RVA: 0xAF7590 Offset: 0xAF5B90 VA: 0x180AF7590
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xB08820 Offset: 0xB06E20 VA: 0x180B08820
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xAFF440 Offset: 0xAFDA40 VA: 0x180AFF440
	internal void EvaluateExpressions() { }

	// RVA: 0xAFF970 Offset: 0xAFDF70 VA: 0x180AFF970
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0xAFF6D0 Offset: 0xAFDCD0 VA: 0x180AFF6D0
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xAFEAB0 Offset: 0xAFD0B0 VA: 0x180AFEAB0
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xAFEBE0 Offset: 0xAFD1E0 VA: 0x180AFEBE0
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

}

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4224
{	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1EF290 Offset: 0x1EE690 VA: 0x1801EF290
	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4225
{	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1EF150 Offset: 0x1EE550 VA: 0x1801EF150
	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4226
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CF9A0 Offset: 0x13CDFA0 VA: 0x1813CF9A0
	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x13D1FF0 Offset: 0x13D05F0 VA: 0x1813D1FF0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int get_ObjectID() { }

	// RVA: 0x13D2340 Offset: 0x13D0940 VA: 0x1813D2340
	public DataTable get_Item(int index) { }

	// RVA: 0x13D2240 Offset: 0x13D0840 VA: 0x1813D2240
	public DataTable get_Item(string name) { }

	// RVA: 0x13D2120 Offset: 0x13D0720 VA: 0x1813D2120
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x13D10B0 Offset: 0x13CF6B0 VA: 0x1813D10B0
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x13D0F40 Offset: 0x13CF540 VA: 0x1813D0F40
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x13CFA10 Offset: 0x13CE010 VA: 0x1813CFA10
	public void Add(DataTable table) { }

	// RVA: 0x13CFC70 Offset: 0x13CE270 VA: 0x1813CFC70
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x13CFCA0 Offset: 0x13CE2A0 VA: 0x1813CFCA0
	internal string AssignName() { }

	// RVA: 0x13CFD60 Offset: 0x13CE360 VA: 0x1813CFD60
	private void BaseAdd(DataTable table) { }

	// RVA: 0x13CFF80 Offset: 0x13CE580 VA: 0x1813CFF80
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x13D0140 Offset: 0x13CE740 VA: 0x1813D0140
	private void BaseRemove(DataTable table) { }

	// RVA: 0x13D0340 Offset: 0x13CE940 VA: 0x1813D0340
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x13D07C0 Offset: 0x13CEDC0 VA: 0x1813D07C0
	public void Clear() { }

	// RVA: 0x13D0DA0 Offset: 0x13CF3A0 VA: 0x1813D0DA0
	public bool Contains(string name) { }

	// RVA: 0x13D0BE0 Offset: 0x13CF1E0 VA: 0x1813D0BE0
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x13D0DC0 Offset: 0x13CF3C0 VA: 0x1813D0DC0
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x13D1200 Offset: 0x13CF800 VA: 0x1813D1200
	public int IndexOf(DataTable table) { }

	// RVA: 0x13D1300 Offset: 0x13CF900 VA: 0x1813D1300
	public int IndexOf(string tableName) { }

	// RVA: 0x13D1320 Offset: 0x13CF920 VA: 0x1813D1320
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x13D1E10 Offset: 0x13D0410 VA: 0x1813D1E10
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x13D15A0 Offset: 0x13CFBA0 VA: 0x1813D15A0
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x13D13E0 Offset: 0x13CF9E0 VA: 0x1813D13E0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x13D17E0 Offset: 0x13CFDE0 VA: 0x1813D17E0
	private string MakeName(int index) { }

	// RVA: 0x13D1870 Offset: 0x13CFE70 VA: 0x1813D1870
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D1920 Offset: 0x13CFF20 VA: 0x1813D1920
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13D19D0 Offset: 0x13CFFD0 VA: 0x1813D19D0
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x13D1C50 Offset: 0x13D0250 VA: 0x1813D1C50
	public void Remove(DataTable table) { }

	// RVA: 0x13D1E70 Offset: 0x13D0470 VA: 0x1813D1E70
	internal void UnregisterName(string name) { }

}

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13D2420 Offset: 0x13D0A20 VA: 0x1813D2420
	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4230
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTableNewRowEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
{
// Namespace: System.Data
[DefaultEventAttribute] // RVA: 0xA4430 Offset: 0xA3830 VA: 0x1800A4430
[DefaultPropertyAttribute] // RVA: 0xA4430 Offset: 0xA3830 VA: 0x1800A4430
[DefaultMemberAttribute] // RVA: 0xA4430 Offset: 0xA3830 VA: 0x1800A4430
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
	[DefaultValueAttribute] // RVA: 0x9D5E0 Offset: 0x9C9E0 VA: 0x18009D5E0
	public bool AllowDelete { get; }
	[DefaultValueAttribute] // RVA: 0x9D5E0 Offset: 0x9C9E0 VA: 0x18009D5E0
	public bool AllowNew { get; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public int Count { get; }
	private int CountFromIndex { get; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public DataViewManager DataViewManager { get; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	protected bool IsOpen { get; }
	[DefaultValueAttribute] // RVA: 0xA4B80 Offset: 0xA3F80 VA: 0x1800A4B80
	public DataViewRowState RowStateFilter { get; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA4DC0 Offset: 0xA41C0 VA: 0x1800A4DC0
	[DefaultValueAttribute] // RVA: 0xA4DC0 Offset: 0xA41C0 VA: 0x1800A4DC0
	[TypeConverterAttribute] // RVA: 0xA4DC0 Offset: 0xA41C0 VA: 0x1800A4DC0
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x13D6990 Offset: 0x13D4F90 VA: 0x1813D6990
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool get_AllowDelete() { }

	// RVA: 0x1086590 Offset: 0x1084B90 VA: 0x181086590
	public bool get_AllowNew() { }

	// RVA: 0x13D6CB0 Offset: 0x13D52B0 VA: 0x1813D6CB0 Slot: 22
	public int get_Count() { }

	// RVA: 0x13D6C80 Offset: 0x13D5280 VA: 0x1813D6C80
	private int get_CountFromIndex() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x7AE4F0 Offset: 0x7ACAF0 VA: 0x1807AE4F0
	protected bool get_IsOpen() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x13D6D00 Offset: 0x13D5300 VA: 0x1813D6D00
	public string get_Sort() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public DataTable get_Table() { }

	// RVA: 0x13D6500 Offset: 0x13D4B00 VA: 0x1813D6500 Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x13D6560 Offset: 0x13D4B60 VA: 0x1813D6560 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x13D6500 Offset: 0x13D4B00 VA: 0x1813D6500
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x13D3CB0 Offset: 0x13D22B0 VA: 0x1813D3CB0 Slot: 25
	public virtual DataRowView AddNew() { }

	// RVA: 0x13D3F70 Offset: 0x13D2570 VA: 0x1813D3F70
	private void CheckOpen() { }

	// RVA: 0x13D4200 Offset: 0x13D2800 VA: 0x1813D4200
	protected void Close() { }

	// RVA: 0x13D46B0 Offset: 0x13D2CB0 VA: 0x1813D46B0 Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13D44A0 Offset: 0x13D2AA0 VA: 0x1813D44A0
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x13D4810 Offset: 0x13D2E10 VA: 0x1813D4810
	public void Delete(int index) { }

	// RVA: 0x13D4840 Offset: 0x13D2E40 VA: 0x1813D4840
	internal void Delete(DataRow row) { }

	// RVA: 0x13D4A20 Offset: 0x13D3020 VA: 0x1813D4A20 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13D4A80 Offset: 0x13D3080 VA: 0x1813D4A80
	internal void FinishAddNew(bool success) { }

	// RVA: 0x13D4C50 Offset: 0x13D3250 VA: 0x1813D4C50 Slot: 24
	public IEnumerator GetEnumerator() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x13D61B0 Offset: 0x13D47B0 VA: 0x1813D61B0 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x13D6250 Offset: 0x13D4850 VA: 0x1813D6250 Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x13D6290 Offset: 0x13D4890 VA: 0x1813D6290 Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x13D6320 Offset: 0x13D4920 VA: 0x1813D6320 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x13D51A0 Offset: 0x13D37A0 VA: 0x1813D51A0
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x13D5140 Offset: 0x13D3740 VA: 0x1813D5140
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x13D63A0 Offset: 0x13D49A0 VA: 0x1813D63A0 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13D63E0 Offset: 0x13D49E0 VA: 0x1813D63E0 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x13D4810 Offset: 0x13D2E10 VA: 0x1813D4810 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 26
	internal virtual IFilter GetFilter() { }

	// RVA: 0x13D4CF0 Offset: 0x13D32F0 VA: 0x1813D4CF0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x13D4E80 Offset: 0x13D3480 VA: 0x1813D4E80
	internal DataRow GetRow(int index) { }

	// RVA: 0x13D4DB0 Offset: 0x13D33B0 VA: 0x1813D4DB0
	private DataRowView GetRowView(int record) { }

	// RVA: 0x13D4E20 Offset: 0x13D3420 VA: 0x1813D4E20
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x13D50C0 Offset: 0x13D36C0 VA: 0x1813D50C0 Slot: 27
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x13D4FF0 Offset: 0x13D35F0 VA: 0x1813D4FF0
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x13D5300 Offset: 0x13D3900 VA: 0x1813D5300
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D55B0 Offset: 0x13D3BB0 VA: 0x1813D55B0 Slot: 28
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D5D40 Offset: 0x13D4340 VA: 0x1813D5D40
	protected void Reset() { }

	// RVA: 0x13D5B10 Offset: 0x13D4110 VA: 0x1813D5B10
	internal void ResetRowViewCache() { }

	// RVA: 0x13D5D70 Offset: 0x13D4370 VA: 0x1813D5D70
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D6190 Offset: 0x13D4790 VA: 0x1813D6190 Slot: 29
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x13D5F80 Offset: 0x13D4580 VA: 0x1813D5F80
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x13D6900 Offset: 0x13D4F00 VA: 0x1813D6900
	protected void UpdateIndex() { }

	// RVA: 0x13D6920 Offset: 0x13D4F20 VA: 0x1813D6920 Slot: 30
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x13D65A0 Offset: 0x13D4BA0 VA: 0x1813D65A0
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x13D3FC0 Offset: 0x13D25C0 VA: 0x1813D3FC0
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D58D0 Offset: 0x13D3ED0 VA: 0x1813D58D0
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D4260 Offset: 0x13D2860 VA: 0x1813D4260 Slot: 31
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D4240 Offset: 0x13D2840 VA: 0x1813D4240
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1079DB0 Offset: 0x10783B0 VA: 0x181079DB0
	internal int get_ObjectID() { }

	// RVA: 0x13D6930 Offset: 0x13D4F30 VA: 0x1813D6930
	private static void .cctor() { }

}

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4233
{	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x135AD

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13CF910 Offset: 0x13CDF10 VA: 0x1813CF910 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x13CF920 Offset: 0x13CDF20 VA: 0x1813CF920 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x13CF940 Offset: 0x13CDF40 VA: 0x1813CF940
	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4234
{	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x13D38C0 Offset: 0x13D1EC0 VA: 0x1813D38C0
	internal void .ctor(DataView dv) { }

	// RVA: 0x13D2BC0 Offset: 0x13D11C0 VA: 0x1813D2BC0
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D3030 Offset: 0x13D1630 VA: 0x1813D3030
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D2CD0 Offset: 0x13D12D0 VA: 0x1813D2CD0
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D2F40 Offset: 0x13D1540 VA: 0x1813D2F40
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13D2DC0 Offset: 0x13D13C0 VA: 0x1813D2DC0
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D3380 Offset: 0x13D1980 VA: 0x1813D3380
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x13D3630 Offset: 0x13D1C30 VA: 0x1813D3630
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x13D3640 Offset: 0x13D1C40 VA: 0x1813D3640
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x13D3120 Offset: 0x13D1720 VA: 0x1813D3120
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x13D3550 Offset: 0x13D1B50 VA: 0x1813D3550
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x13D2CB0 Offset: 0x13D12B0 VA: 0x1813D2CB0
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x13D31F0 Offset: 0x13D17F0 VA: 0x1813D31F0
	private void RegisterListener(DataTable table) { }

}

public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4235
{	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x13D3950 Offset: 0x13D1F50 VA: 0x1813D3950
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

	// RVA: 0x13D3C30 Offset: 0x13D2230 VA: 0x1813D3C30
	internal void .ctor() { }

	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1237E50 Offset: 0x1236450 VA: 0x181237E50
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D3C10 Offset: 0x13D2210 VA: 0x1813D3C10
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_RowFilter() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
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

	// RVA: 0x13D39E0 Offset: 0x13D1FE0 VA: 0x1813D39E0 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x13D3B50 Offset: 0x13D2150 VA: 0x1813D3B50 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x13D39B0 Offset: 0x13D1FB0 VA: 0x1813D39B0
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

	// RVA: 0x1235580 Offset: 0x1233B80 VA: 0x181235580
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x1235320 Offset: 0x1233920 VA: 0x181235320
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x12355A0 Offset: 0x1233BA0 VA: 0x1812355A0
	internal string get_Expression() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExpressionNode get_ExpressionNode() { }

	// RVA: 0x12355E0 Offset: 0x1233BE0 VA: 0x1812355E0
	internal bool get_HasValue() { }

	// RVA: 0x1234B30 Offset: 0x1233130 VA: 0x181234B30
	internal void Bind(DataTable table) { }

	// RVA: 0x1234C60 Offset: 0x1233260 VA: 0x181234C60
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x1234E80 Offset: 0x1233480 VA: 0x181234E80
	internal object Evaluate() { }

	// RVA: 0x1234C80 Offset: 0x1233280 VA: 0x181234C80
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1234ED0 Offset: 0x12334D0 VA: 0x181234ED0 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1234FB0 Offset: 0x12335B0 VA: 0x181234FB0
	internal bool IsTableAggregate() { }

	// RVA: 0x1234FD0 Offset: 0x12335D0 VA: 0x181234FD0
	internal static bool IsUnknown(object value) { }

	// RVA: 0x1234E90 Offset: 0x1233490 VA: 0x181234E90
	internal bool HasLocalAggregate() { }

	// RVA: 0x1234EB0 Offset: 0x12334B0 VA: 0x181234EB0
	internal bool HasRemoteAggregate() { }

	// RVA: 0x1235030 Offset: 0x1233630 VA: 0x181235030
	internal static bool ToBoolean(object value) { }

}

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4333
{	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x13D2630 Offset: 0x13D0C30 VA: 0x1813D2630
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x13D2AE0 Offset: 0x13D10E0 VA: 0x1813D2AE0
	private void .ctor(XmlWriter w) { }

	// RVA: 0x13D2B10 Offset: 0x13D1110 VA: 0x1813D2B10
	internal Stream get_BaseStream() { }

	// RVA: 0x13D29F0 Offset: 0x13D0FF0 VA: 0x1813D29F0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x13D29C0 Offset: 0x13D0FC0 VA: 0x1813D29C0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13D2870 Offset: 0x13D0E70 VA: 0x1813D2870 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x13D2810 Offset: 0x13D0E10 VA: 0x1813D2810 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13D2A20 Offset: 0x13D1020 VA: 0x1813D2A20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131A550 Offset: 0x1318B50 VA: 0x18131A550 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13D28D0 Offset: 0x13D0ED0 VA: 0x1813D28D0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x13D2990 Offset: 0x13D0F90 VA: 0x1813D2990 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x13D2840 Offset: 0x13D0E40 VA: 0x1813D2840 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x13D2750 Offset: 0x13D0D50 VA: 0x1813D2750 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13D27E0 Offset: 0x13D0DE0 VA: 0x1813D27E0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13D2900 Offset: 0x13D0F00 VA: 0x1813D2900 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13D28A0 Offset: 0x13D0EA0 VA: 0x1813D28A0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x13D2780 Offset: 0x13D0D80 VA: 0x1813D2780 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x13D2AB0 Offset: 0x13D10B0 VA: 0x1813D2AB0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13D2A50 Offset: 0x13D1050 VA: 0x1813D2A50 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x13D2A80 Offset: 0x13D1080 VA: 0x1813D2A80 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13D27B0 Offset: 0x13D0DB0 VA: 0x1813D27B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13D2930 Offset: 0x13D0F30 VA: 0x1813D2930 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13D2960 Offset: 0x13D0F60 VA: 0x1813D2960 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x13D26F0 Offset: 0x13D0CF0 VA: 0x1813D26F0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x13D2720 Offset: 0x13D0D20 VA: 0x1813D2720 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x13D2B90 Offset: 0x13D1190 VA: 0x1813D2B90 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x13D2600 Offset: 0x13D0C00 VA: 0x1813D2600 Slot: 28
	public override void Close() { }

	// RVA: 0x13D2690 Offset: 0x13D0C90 VA: 0x1813D2690 Slot: 29
	public override void Flush() { }

	// RVA: 0x13D26C0 Offset: 0x13D0CC0 VA: 0x1813D26C0 Slot: 30
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

	// RVA: 0x13D2490 Offset: 0x13D0A90 VA: 0x1813D2490
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x13D2530 Offset: 0x13D0B30 VA: 0x1813D2530
	private void .ctor(XmlReader input) { }

	// RVA: 0x132F710 Offset: 0x132DD10 VA: 0x18132F710 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB18EF0 Offset: 0xB174F0 VA: 0x180B18EF0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8A90 Offset: 0xBC7090 VA: 0x180BC8A90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8C20 Offset: 0xBC7220 VA: 0x180BC8C20 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8940 Offset: 0xBC6F40 VA: 0x180BC8940 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8A00 Offset: 0xBC7000 VA: 0x180BC8A00 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC89D0 Offset: 0xBC6FD0 VA: 0x180BC89D0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8190 Offset: 0xBC6790 VA: 0x180BC8190 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC81C0 Offset: 0xBC67C0 VA: 0x180BC81C0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC81F0 Offset: 0xBC67F0 VA: 0x180BC81F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8290 Offset: 0xBC6890 VA: 0x180BC8290 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC8260 Offset: 0xBC6860 VA: 0x180BC8260 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC82F0 Offset: 0xBC68F0 VA: 0x180BC82F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8320 Offset: 0xBC6920 VA: 0x180BC8320 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC82C0 Offset: 0xBC68C0 VA: 0x180BC82C0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8350 Offset: 0xBC6950 VA: 0x180BC8350 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC83B0 Offset: 0xBC69B0 VA: 0x180BC83B0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC89A0 Offset: 0xBC6FA0 VA: 0x180BC89A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9EE40 Offset: 0xB9D440 VA: 0x180B9EE40 Slot: 33
	public override void Close() { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8410 Offset: 0xBC6A10 VA: 0x180BC8410 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x13D25D0 Offset: 0x13D0BD0 VA: 0x1813D25D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC83E0 Offset: 0xBC69E0 VA: 0x180BC83E0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x13D25A0 Offset: 0x13D0BA0 VA: 0x1813D25A0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xB9E870 Offset: 0xB9CE70 VA: 0x180B9E870 Slot: 42
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
	[DefaultValueAttribute] // RVA: 0xA97F0 Offset: 0xA8BF0 VA: 0x1800A97F0
	public virtual ConflictOption ConflictOption { get; }
	[DefaultValueAttribute] // RVA: 0xA9920 Offset: 0xA8D20 VA: 0x1800A9920
	public virtual CatalogLocation CatalogLocation { get; }
	[DefaultValueAttribute] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	public virtual string CatalogSeparator { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public DbDataAdapter DataAdapter { get; set; }
	internal int ParameterNameMaxLength { get; }
	internal string ParameterNamePattern { get; }
	private string QuotedBaseTableName { get; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public virtual string QuotePrefix { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public virtual string QuoteSuffix { get; set; }
	[DefaultValueAttribute] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	public virtual string SchemaSeparator { get; }
	[DefaultValueAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public bool SetAllValues { get; }
	private DbCommand InsertCommand { get; set; }
	private DbCommand UpdateCommand { get; set; }
	private DbCommand DeleteCommand { get; set; }

	// Methods

	// RVA: 0x127EC60 Offset: 0x127D260 VA: 0x18127EC60
	protected void .ctor() { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40 Slot: 12
	public virtual ConflictOption get_ConflictOption() { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940 Slot: 13
	public virtual CatalogLocation get_CatalogLocation() { }

	// RVA: 0x127ED30 Offset: 0x127D330 VA: 0x18127ED30 Slot: 14
	public virtual string get_CatalogSeparator() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public DbDataAdapter get_DataAdapter() { }

	// RVA: 0x127EE70 Offset: 0x127D470 VA: 0x18127EE70
	public void set_DataAdapter(DbDataAdapter value) { }

	// RVA: 0x1079E60 Offset: 0x1078460 VA: 0x181079E60
	internal int get_ParameterNameMaxLength() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	internal string get_ParameterNamePattern() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	private string get_QuotedBaseTableName() { }

	// RVA: 0x127ED80 Offset: 0x127D380 VA: 0x18127ED80 Slot: 15
	public virtual string get_QuotePrefix() { }

	// RVA: 0x127EF10 Offset: 0x127D510 VA: 0x18127EF10 Slot: 16
	public virtual void set_QuotePrefix(string value) { }

	// RVA: 0x127EDD0 Offset: 0x127D3D0 VA: 0x18127EDD0 Slot: 17
	public virtual string get_QuoteSuffix() { }

	// RVA: 0x127EFA0 Offset: 0x127D5A0 VA: 0x18127EFA0 Slot: 18
	public virtual void set_QuoteSuffix(string value) { }

	// RVA: 0x127EE20 Offset: 0x127D420 VA: 0x18127EE20 Slot: 19
	public virtual string get_SchemaSeparator() { }

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	public bool get_SetAllValues() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	private DbCommand get_InsertCommand() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_InsertCommand(DbCommand value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	private DbCommand get_UpdateCommand() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	private void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	private DbCommand get_DeleteCommand() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127AEC0 Offset: 0x12794C0 VA: 0x18127AEC0
	private void BuildCache(bool closeConnection, DataRow dataRow, bool useColumnsForParameterNames) { }

	// RVA: 0x127D9D0 Offset: 0x127BFD0 VA: 0x18127D9D0 Slot: 20
	protected virtual DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x127B620 Offset: 0x1279C20 VA: 0x18127B620
	private void BuildInformation(DataTable schemaTable) { }

	// RVA: 0x127B480 Offset: 0x1279A80 VA: 0x18127B480
	private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127BF20 Offset: 0x127A520 VA: 0x18127BF20
	private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127C490 Offset: 0x127AA90 VA: 0x18127C490
	private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x127C920 Offset: 0x127AF20 VA: 0x18127C920
	private int BuildWhereClause(DataTableMapping mappings, DataRow dataRow, StringBuilder builder, DbCommand command, int parameterCount, bool isUpdate) { }

	// RVA: 0x127CF50 Offset: 0x127B550 VA: 0x18127CF50
	private string CreateParameterForNullTest(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127D360 Offset: 0x127B960 VA: 0x18127D360
	private string CreateParameterForValue(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x127D640 Offset: 0x127BC40 VA: 0x18127D640 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x127D6C0 Offset: 0x127BCC0 VA: 0x18127D6C0
	private string GetBaseParameterName(int index) { }

	// RVA: 0x127D980 Offset: 0x127BF80 VA: 0x18127D980
	private string GetOriginalParameterName(int index) { }

	// RVA: 0x127D930 Offset: 0x127BF30 VA: 0x18127D930
	private string GetNullParameterName(int index) { }

	// RVA: 0x127DB50 Offset: 0x127C150 VA: 0x18127DB50
	private DbCommand GetSelectCommand() { }

	// RVA: 0x127D710 Offset: 0x127BD10 VA: 0x18127D710
	private object GetColumnValue(DataRow row, string columnName, DataTableMapping mappings, DataRowVersion version) { }

	// RVA: 0x127D7C0 Offset: 0x127BDC0 VA: 0x18127D7C0
	private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version) { }

	// RVA: 0x127D800 Offset: 0x127BE00 VA: 0x18127D800
	private DataColumn GetDataColumn(string columnName, DataTableMapping tablemapping, DataRow row) { }

	// RVA: 0x127D890 Offset: 0x127BE90 VA: 0x18127D890
	private static DbParameter GetNextParameter(DbCommand command, int pcount) { }

	// RVA: 0x127DC50 Offset: 0x127C250 VA: 0x18127DC50
	private bool IncludeInInsertValues(DbSchemaRow row) { }

	// RVA: 0x127DDD0 Offset: 0x127C3D0 VA: 0x18127DDD0
	private bool IncludeInUpdateSet(DbSchemaRow row) { }

	// RVA: 0x127DE30 Offset: 0x127C430 VA: 0x18127DE30
	private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate) { }

	// RVA: 0x127DF90 Offset: 0x127C590 VA: 0x18127DF90
	private bool IncrementWhereCount(DbSchemaRow row) { }

	// RVA: 0x127E0D0 Offset: 0x127C6D0 VA: 0x18127E0D0 Slot: 21
	protected virtual DbCommand InitializeCommand(DbCommand command) { }

	// RVA: 0x127E230 Offset: 0x127C830 VA: 0x18127E230
	private string QuotedColumn(string column) { }

	// RVA: 0x127E1D0 Offset: 0x127C7D0 VA: 0x18127E1D0 Slot: 22
	public virtual string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x127E2D0 Offset: 0x127C8D0 VA: 0x18127E2D0 Slot: 23
	public virtual void RefreshSchema() { }

	// RVA: 0x127E5E0 Offset: 0x127CBE0 VA: 0x18127E5E0
	private static void RemoveExtraParameters(DbCommand command, int usedParameterCount) { }

	// RVA: 0x127E7C0 Offset: 0x127CDC0 VA: 0x18127E7C0
	protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127E680 Offset: 0x127CC80 VA: 0x18127E680
	private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x127EC00 Offset: 0x127D200 VA: 0x18127EC00 Slot: 24
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

	// RVA: 0x1282620 Offset: 0x1280C20 VA: 0x181282620
	internal void .ctor(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows) { }

	// RVA: 0x12824A0 Offset: 0x1280AA0 VA: 0x1812824A0
	private void SetAndValidateNamePrefixes() { }

	// RVA: 0x1281CF0 Offset: 0x12802F0 VA: 0x181281CF0
	private void ApplyProviderSpecificFormat() { }

	// RVA: 0x1281F00 Offset: 0x1280500 VA: 0x181281F00
	private void EliminateConflictingNames() { }

	// RVA: 0x12820A0 Offset: 0x12806A0 VA: 0x1812820A0
	internal void GenerateMissingNames(DbSchemaRow[] schemaRows) { }

	// RVA: 0x1282270 Offset: 0x1280870 VA: 0x181282270
	private int GetAdjustedParameterNameMaxLength() { }

	// RVA: 0x1282340 Offset: 0x1280940 VA: 0x181282340
	private string GetNextGenericParameterName() { }

	// RVA: 0xE95670 Offset: 0xE93C70 VA: 0x180E95670
	internal string GetBaseParameterName(int index) { }

	// RVA: 0x1282460 Offset: 0x1280A60 VA: 0x181282460
	internal string GetOriginalParameterName(int index) { }

	// RVA: 0x1282420 Offset: 0x1280A20 VA: 0x181282420
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

	// RVA: 0x1280910 Offset: 0x127EF10 VA: 0x181280910
	internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(DbSchemaTable schemaTable, DataRow dataRow) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal DataRow get_DataRow() { }

	// RVA: 0x12812E0 Offset: 0x127F8E0 VA: 0x1812812E0
	internal string get_ColumnName() { }

	// RVA: 0x1280E20 Offset: 0x127F420 VA: 0x181280E20
	internal string get_BaseColumnName() { }

	// RVA: 0x1281080 Offset: 0x127F680 VA: 0x181281080
	internal string get_BaseServerName() { }

	// RVA: 0x1280CF0 Offset: 0x127F2F0 VA: 0x181280CF0
	internal string get_BaseCatalogName() { }

	// RVA: 0x1280F50 Offset: 0x127F550 VA: 0x181280F50
	internal string get_BaseSchemaName() { }

	// RVA: 0x12811B0 Offset: 0x127F7B0 VA: 0x1812811B0
	internal string get_BaseTableName() { }

	// RVA: 0x12813F0 Offset: 0x127F9F0 VA: 0x1812813F0
	internal bool get_IsAutoIncrement() { }

	// RVA: 0x1281BD0 Offset: 0x12801D0 VA: 0x181281BD0
	internal bool get_IsUnique() { }

	// RVA: 0x1281AB0 Offset: 0x12800B0 VA: 0x181281AB0
	internal bool get_IsRowVersion() { }

	// RVA: 0x1281750 Offset: 0x127FD50 VA: 0x181281750
	internal bool get_IsKey() { }

	// RVA: 0x1281510 Offset: 0x127FB10 VA: 0x181281510
	internal bool get_IsExpression() { }

	// RVA: 0x1281630 Offset: 0x127FC30 VA: 0x181281630
	internal bool get_IsHidden() { }

	// RVA: 0x1281870 Offset: 0x127FE70 VA: 0x181281870
	internal bool get_IsLong() { }

	// RVA: 0x1281990 Offset: 0x127FF90 VA: 0x181281990
	internal bool get_IsReadOnly() { }

	// RVA: 0x1280BD0 Offset: 0x127F1D0 VA: 0x181280BD0
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

	// RVA: 0x17CDA90 Offset: 0x17CC090 VA: 0x1817CDA90
	internal void .ctor(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x17CDBD0 Offset: 0x17CC1D0 VA: 0x1817CDBD0
	internal DataColumn get_ColumnName() { }

	// RVA: 0x17CDBB0 Offset: 0x17CC1B0 VA: 0x1817CDBB0
	internal DataColumn get_BaseServerName() { }

	// RVA: 0x17CDB90 Offset: 0x17CC190 VA: 0x1817CDB90
	internal DataColumn get_BaseColumnName() { }

	// RVA: 0x17CDBC0 Offset: 0x17CC1C0 VA: 0x1817CDBC0
	internal DataColumn get_BaseTableName() { }

	// RVA: 0x17CDB80 Offset: 0x17CC180 VA: 0x1817CDB80
	internal DataColumn get_BaseCatalogName() { }

	// RVA: 0x17CDBA0 Offset: 0x17CC1A0 VA: 0x1817CDBA0
	internal DataColumn get_BaseSchemaName() { }

	// RVA: 0x17CDBE0 Offset: 0x17CC1E0 VA: 0x1817CDBE0
	internal DataColumn get_IsAutoIncrement() { }

	// RVA: 0x17CDC50 Offset: 0x17CC250 VA: 0x1817CDC50
	internal DataColumn get_IsUnique() { }

	// RVA: 0x17CDC10 Offset: 0x17CC210 VA: 0x1817CDC10
	internal DataColumn get_IsKey() { }

	// RVA: 0x17CDC40 Offset: 0x17CC240 VA: 0x1817CDC40
	internal DataColumn get_IsRowVersion() { }

	// RVA: 0x17CDB70 Offset: 0x17CC170 VA: 0x1817CDB70
	internal DataColumn get_AllowDBNull() { }

	// RVA: 0x17CDBF0 Offset: 0x17CC1F0 VA: 0x1817CDBF0
	internal DataColumn get_IsExpression() { }

	// RVA: 0x17CDC00 Offset: 0x17CC200 VA: 0x1817CDC00
	internal DataColumn get_IsHidden() { }

	// RVA: 0x17CDC20 Offset: 0x17CC220 VA: 0x1817CDC20
	internal DataColumn get_IsLong() { }

	// RVA: 0x17CDC30 Offset: 0x17CC230 VA: 0x1817CDC30
	internal DataColumn get_IsReadOnly() { }

	// RVA: 0x17CCF40 Offset: 0x17CB540 VA: 0x1817CCF40
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column) { }

	// RVA: 0x17CCF50 Offset: 0x17CB550 VA: 0x1817CCF50
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2) { }

	// RVA: 0x17CD140 Offset: 0x17CB740 VA: 0x1817CD140
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
	[DefaultValueAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	public MissingMappingAction MissingMappingAction { get; }

	// Methods

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 12
	public MissingMappingAction get_MissingMappingAction() { }

	// RVA: 0x1274800 Offset: 0x1272E00 VA: 0x181274800
	private static void .cctor() { }

}

public sealed class DataColumnMapping : MarshalByRefObject // TypeDefIndex: 4375
{	// Fields
	private string _dataSetColumnName; // 0x18
	private string _sourceColumnName; // 0x20

	// Properties
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string DataSetColumn { get; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public string SourceColumn { get; }

	// Methods

	// RVA: 0x12752B0 Offset: 0x12738B0 VA: 0x1812752B0 Slot: 6
	public string get_DataSetColumn() { }

	// RVA: 0x1275300 Offset: 0x1273900 VA: 0x181275300 Slot: 7
	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x12751E0 Offset: 0x12737E0 VA: 0x1812751E0
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x1274EC0 Offset: 0x12734C0 VA: 0x181274EC0
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	// RVA: 0x1274D80 Offset: 0x1273380 VA: 0x181274D80
	internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

}

public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
{
// Namespace: System.Data.Common
[DefaultMemberAttribute] // RVA: 0x70BA0 Offset: 0x6FFA0 VA: 0x180070BA0
public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
	// Fields
	private List<DataColumnMapping> _items; // 0x18

	// Properties
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public int Count { get; }

	// Methods

	// RVA: 0x1274D40 Offset: 0x1273340 VA: 0x181274D40 Slot: 6
	public int get_Count() { }

	// RVA: 0x1274BC0 Offset: 0x12731C0 VA: 0x181274BC0 Slot: 7
	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x1274860 Offset: 0x1272E60 VA: 0x181274860
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

	// RVA: 0x10E4870 Offset: 0x10E2E70 VA: 0x1810E4870
	internal void .ctor(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup) { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580 Slot: 15
	public override int get_FieldCount() { }

	// RVA: 0x1275450 Offset: 0x1273A50 VA: 0x181275450 Slot: 21
	public override int GetValues(object[] values) { }

	// RVA: 0x12753D0 Offset: 0x12739D0 VA: 0x1812753D0 Slot: 19
	public override string GetName(int i) { }

	// RVA: 0x1275410 Offset: 0x1273A10 VA: 0x181275410 Slot: 20
	public override object GetValue(int i) { }

	// RVA: 0x1275350 Offset: 0x1273950 VA: 0x181275350 Slot: 17
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1275390 Offset: 0x1273990 VA: 0x181275390 Slot: 18
	public override Type GetFieldType(int i) { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 16
	public override object get_Item(int i) { }

	// RVA: 0x12755B0 Offset: 0x1273BB0 VA: 0x1812755B0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1275670 Offset: 0x1273C70 VA: 0x181275670 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1275600 Offset: 0x1273C00 VA: 0x181275600 Slot: 7
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

	// RVA: 0x1278240 Offset: 0x1276840 VA: 0x181278240
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1278210 Offset: 0x1276810 VA: 0x181278210
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x12782F0 Offset: 0x12768F0 VA: 0x1812782F0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x12784A0 Offset: 0x1276AA0 VA: 0x1812784A0
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x12784C0 Offset: 0x1276AC0 VA: 0x1812784C0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1275770 Offset: 0x1273D70 VA: 0x181275770 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x12756B0 Offset: 0x1273CB0 VA: 0x1812756B0
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1275840 Offset: 0x1273E40 VA: 0x181275840
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1275950 Offset: 0x1273F50 VA: 0x181275950
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1276520 Offset: 0x1274B20 VA: 0x181276520
	protected object GetBits(int recordNo) { }

	// RVA: 0x1276750 Offset: 0x1274D50 VA: 0x181276750 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x12768F0 Offset: 0x1274EF0 VA: 0x1812768F0
	protected bool HasValue(int recordNo) { }

	// RVA: 0x1276C90 Offset: 0x1275290 VA: 0x181276C90 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1277050 Offset: 0x1275650 VA: 0x181277050
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1276FC0 Offset: 0x12755C0 VA: 0x181276FC0 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1275900 Offset: 0x1273F00 VA: 0x181275900 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x12758C0 Offset: 0x1273EC0 VA: 0x1812758C0 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x12759C0 Offset: 0x1273FC0 VA: 0x1812759C0
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x12765F0 Offset: 0x1274BF0 VA: 0x1812765F0
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x1276760 Offset: 0x1274D60 VA: 0x181276760
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1276F40 Offset: 0x1275540 VA: 0x181276F40
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1276FB0 Offset: 0x12755B0 VA: 0x181276FB0
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1276F30 Offset: 0x1275530 VA: 0x181276F30
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1276DF0 Offset: 0x12753F0 VA: 0x181276DF0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1276490 Offset: 0x1274A90 VA: 0x181276490
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x12769E0 Offset: 0x1274FE0 VA: 0x1812769E0
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1276B20 Offset: 0x1275120 VA: 0x181276B20
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1276920 Offset: 0x1274F20 VA: 0x181276920
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1276CB0 Offset: 0x12752B0 VA: 0x181276CB0
	public static bool IsObjectNull(object value) { }

	// RVA: 0x1276D90 Offset: 0x1275390 VA: 0x181276D90
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1276560 Offset: 0x1274B60 VA: 0x181276560
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x12759A0 Offset: 0x1273FA0 VA: 0x1812759A0
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1277070 Offset: 0x1275670 VA: 0x181277070
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x12767F0 Offset: 0x1274DF0 VA: 0x1812767F0
	internal static Type GetType(string value) { }

	// RVA: 0x1276580 Offset: 0x1274B80 VA: 0x181276580
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1277090 Offset: 0x1275690 VA: 0x181277090
	private static void .cctor() { }

}

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4382
{	// Fields
	private DataColumnMappingCollection _columnMappings; // 0x18

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x12784E0 Offset: 0x1276AE0 VA: 0x1812784E0
	public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

public abstract class DbCommand : Component, IDbCommand, IDisposable // TypeDefIndex: 4386
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xA3C70 Offset: 0xA3070 VA: 0x1800A3C70
	[DefaultValueAttribute] // RVA: 0xA3C70 Offset: 0xA3070 VA: 0x1800A3C70
	public abstract string CommandText { get; set; }
	public abstract int CommandTimeout { get; set; }
	[DefaultValueAttribute] // RVA: 0xAA5D0 Offset: 0xA99D0 VA: 0x1800AA5D0
	[RefreshPropertiesAttribute] // RVA: 0xAA5D0 Offset: 0xA99D0 VA: 0x1800AA5D0
	public abstract CommandType CommandType { set; }
	[DefaultValueAttribute] // RVA: 0xAA880 Offset: 0xA9C80 VA: 0x1800AA880
	[BrowsableAttribute] // RVA: 0xAA880 Offset: 0xA9C80 VA: 0x1800AA880
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAA880 Offset: 0xA9C80 VA: 0x1800AA880
	public DbConnection Connection { get; set; }
	protected abstract DbConnection DbConnection { get; set; }
	protected abstract DbParameterCollection DbParameterCollection { get; }
	protected abstract DbTransaction DbTransaction { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAA9B0 Offset: 0xA9DB0 VA: 0x1800AA9B0
	[DefaultValueAttribute] // RVA: 0xAA9B0 Offset: 0xA9DB0 VA: 0x1800AA9B0
	[DesignOnlyAttribute] // RVA: 0xAA9B0 Offset: 0xA9DB0 VA: 0x1800AA9B0
	[BrowsableAttribute] // RVA: 0xAA9B0 Offset: 0xA9DB0 VA: 0x1800AA9B0
	public abstract bool DesignTimeVisible { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public DbParameterCollection Parameters { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAACE0 Offset: 0xAA0E0 VA: 0x1800AACE0
	[BrowsableAttribute] // RVA: 0xAACE0 Offset: 0xAA0E0 VA: 0x1800AACE0
	[DefaultValueAttribute] // RVA: 0xAACE0 Offset: 0xAA0E0 VA: 0x1800AACE0
	public DbTransaction Transaction { get; set; }
	[DefaultValueAttribute] // RVA: 0xAAED0 Offset: 0xAA2D0 VA: 0x1800AAED0
	public abstract UpdateRowSource UpdatedRowSource { get; set; }

	// Methods

	// RVA: 0x127F050 Offset: 0x127D650 VA: 0x18127F050
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

	// RVA: 0x127F0B0 Offset: 0x127D6B0 VA: 0x18127F0B0
	public DbConnection get_Connection() { }

	// RVA: 0x1276560 Offset: 0x1274B60 VA: 0x181276560
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

	// RVA: 0x11D2790 Offset: 0x11D0D90 VA: 0x1811D2790
	public DbParameterCollection get_Parameters() { }

	// RVA: 0x127F0D0 Offset: 0x127D6D0 VA: 0x18127F0D0
	public DbTransaction get_Transaction() { }

	// RVA: 0xE2D180 Offset: 0xE2B780 VA: 0x180E2D180
	public void set_Transaction(DbTransaction value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract UpdateRowSource get_UpdatedRowSource();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_UpdatedRowSource(UpdateRowSource value);

	// RVA: 0xFCB320 Offset: 0xFC9920 VA: 0x180FCB320
	public DbParameter CreateParameter() { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract DbParameter CreateDbParameter();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int ExecuteNonQuery();

	// RVA: 0x127F030 Offset: 0x127D630 VA: 0x18127F030
	public DbDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Prepare();

}

public abstract class DbConnection : Component, IDisposable // TypeDefIndex: 4387
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[DefaultValueAttribute] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[RecommendedAsConfigurableAttribute] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[SettingsBindableAttribute] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	public abstract string ConnectionString { get; set; }
	[BrowsableAttribute] // RVA: 0x9A8A0 Offset: 0x99CA0 VA: 0x18009A8A0
	public abstract ConnectionState State { get; }

	// Methods

	// RVA: 0x127F210 Offset: 0x127D810 VA: 0x18127F210
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

	// RVA: 0x127F0B0 Offset: 0x127D6B0 VA: 0x18127F0B0
	public DbCommand CreateCommand() { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbCommand CreateDbCommand();

	// RVA: 0x127F0F0 Offset: 0x127D6F0 VA: 0x18127F0F0 Slot: 18
	public virtual void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x127F1B0 Offset: 0x127D7B0 VA: 0x18127F1B0 Slot: 19
	public virtual DataTable GetSchema(string collectionName) { }

	// RVA: 0x127F150 Offset: 0x127D750 VA: 0x18127F150 Slot: 20
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
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DbCommand DeleteCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DbCommand InsertCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E960 Offset: 0x9DD60 VA: 0x18009E960
	public DbCommand SelectCommand { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public DbCommand UpdateCommand { get; set; }

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	private IDbDataAdapter get__IDbDataAdapter() { }

	// RVA: 0x127F300 Offset: 0x127D900 VA: 0x18127F300
	public DbCommand get_DeleteCommand() { }

	// RVA: 0x127F580 Offset: 0x127DB80 VA: 0x18127F580
	public void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x127F3A0 Offset: 0x127D9A0 VA: 0x18127F3A0
	public DbCommand get_InsertCommand() { }

	// RVA: 0x127F5E0 Offset: 0x127DBE0 VA: 0x18127F5E0
	public void set_InsertCommand(DbCommand value) { }

	// RVA: 0x127F440 Offset: 0x127DA40 VA: 0x18127F440
	public DbCommand get_SelectCommand() { }

	// RVA: 0x127F4E0 Offset: 0x127DAE0 VA: 0x18127F4E0
	public DbCommand get_UpdateCommand() { }

	// RVA: 0x127F640 Offset: 0x127DC40 VA: 0x18127F640
	public void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x127F270 Offset: 0x127D870 VA: 0x18127F270
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

	// RVA: 0x127F0B0 Offset: 0x127D6B0 VA: 0x18127F0B0 Slot: 19
	public virtual int get_VisibleFieldCount() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Item(int ordinal);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void Close() { }

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: 0x127F6A0 Offset: 0x127DCA0 VA: 0x18127F6A0 Slot: 9
	public void Dispose() { }

	// RVA: 0x127F6C0 Offset: 0x127DCC0 VA: 0x18127F6C0 Slot: 22
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetDataTypeName(int ordinal);

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: -1 Offset: -1 Slot: 24
	public abstract IEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Type GetFieldType(int ordinal);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string GetName(int ordinal);

	// RVA: 0x127F6E0 Offset: 0x127DCE0 VA: 0x18127F6E0 Slot: 27
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

	// RVA: 0x127F730 Offset: 0x127DD30 VA: 0x18127F730 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x127F780 Offset: 0x127DD80 VA: 0x18127F780 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x127F7C0 Offset: 0x127DDC0 VA: 0x18127F7C0 Slot: 7
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

	// RVA: 0x1280010 Offset: 0x127E610 VA: 0x181280010
	public void .ctor(IDataReader reader, bool closeReader) { }

	// RVA: 0x1280010 Offset: 0x127E610 VA: 0x181280010
	public void .ctor(DbDataReader reader, bool closeReader) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object get_Current() { }

	// RVA: 0x127FDD0 Offset: 0x127E3D0 VA: 0x18127FDD0 Slot: 4
	public bool MoveNext() { }

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: 0x127FFB0 Offset: 0x127E5B0 VA: 0x18127FFB0 Slot: 6
	public void Reset() { }

	// RVA: 0x127F810 Offset: 0x127DE10 VA: 0x18127F810
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

	// RVA: 0x127AE10 Offset: 0x1279410 VA: 0x18127AE10
	internal void .ctor(int ordinal, string name, Type type) { }

	// RVA: 0x127AE60 Offset: 0x1279460 VA: 0x18127AE60 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x127AC90 Offset: 0x1279290 VA: 0x18127AC90 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x127ADB0 Offset: 0x12793B0 VA: 0x18127ADB0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public abstract class DbException : ExternalException // TypeDefIndex: 4393
{	// Methods

	// RVA: 0x12800D0 Offset: 0x127E6D0 VA: 0x1812800D0
	protected void .ctor() { }

	// RVA: 0x12800C0 Offset: 0x127E6C0 VA: 0x1812800C0
	protected void .ctor(string message) { }

	// RVA: 0x12800E0 Offset: 0x127E6E0 VA: 0x1812800E0
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

	// RVA: 0x1280160 Offset: 0x127E760 VA: 0x181280160
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

	// RVA: 0x1280230 Offset: 0x127E830 VA: 0x181280230
	private static void .cctor() { }

}

public abstract class DbParameter : MarshalByRefObject // TypeDefIndex: 4396
{	// Properties
	[BrowsableAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	[RefreshPropertiesAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	public abstract DbType DbType { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xABE80 Offset: 0xAB280 VA: 0x1800ABE80
	[DefaultValueAttribute] // RVA: 0xABE80 Offset: 0xAB280 VA: 0x1800ABE80
	public abstract ParameterDirection Direction { get; set; }
	[DesignOnlyAttribute] // RVA: 0xABF90 Offset: 0xAB390 VA: 0x1800ABF90
	[BrowsableAttribute] // RVA: 0xABF90 Offset: 0xAB390 VA: 0x1800ABF90
	[EditorBrowsableAttribute] // RVA: 0xABF90 Offset: 0xAB390 VA: 0x1800ABF90
	public abstract bool IsNullable { get; set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public abstract string ParameterName { get; set; }
	public abstract int Size { set; }
	[DefaultValueAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public abstract string SourceColumn { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAC1F0 Offset: 0xAB5F0 VA: 0x1800AC1F0
	[DefaultValueAttribute] // RVA: 0xAC1F0 Offset: 0xAB5F0 VA: 0x1800AC1F0
	[RefreshPropertiesAttribute] // RVA: 0xAC1F0 Offset: 0xAB5F0 VA: 0x1800AC1F0
	public abstract bool SourceColumnNullMapping { set; }
	[DefaultValueAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	public virtual DataRowVersion SourceVersion { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xAC4D0 Offset: 0xAB8D0 VA: 0x1800AC4D0
	[DefaultValueAttribute] // RVA: 0xAC4D0 Offset: 0xAB8D0 VA: 0x1800AC4D0
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

	// RVA: 0x1280900 Offset: 0x127EF00 VA: 0x181280900 Slot: 18
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
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public abstract int Count { get; }
	[EditorBrowsableAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	[BrowsableAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	[DesignerSerializationVisibilityAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	public virtual bool IsFixedSize { get; }
	[BrowsableAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	[EditorBrowsableAttribute] // RVA: 0xABD40 Offset: 0xAB140 VA: 0x1800ABD40
	public virtual bool IsReadOnly { get; }
	[EditorBrowsableAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	[BrowsableAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	[DesignerSerializationVisibilityAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
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

	// RVA: 0x1280830 Offset: 0x127EE30 VA: 0x181280830 Slot: 6
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1280850 Offset: 0x127EE50 VA: 0x181280850 Slot: 7
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1280830 Offset: 0x127EE30 VA: 0x181280830
	public DbParameter get_Item(int index) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void Clear();

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly bool <IsProviderSpecificTypeProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4400
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Commit();

	// RVA: 0x162EA00 Offset: 0x162D000 VA: 0x18162EA00 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Rollback();

}

public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
{
// Namespace: System.Runtime.Serialization
[AttributeUsageAttribute] // RVA: 0xC9B20 Offset: 0xC8F20 VA: 0x1800C9B20
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

	// RVA: 0x7D0C30 Offset: 0x7CF230 VA: 0x1807D0C30
	public bool get_IsRequired() { }

	// RVA: 0x7D0C20 Offset: 0x7CF220 VA: 0x1807D0C20
	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6181
{	// Methods

	// RVA: 0x14ABA00 Offset: 0x14AA000 VA: 0x1814ABA00
	public static void Insert(string parent, object contents, Action<bool> onFinished) { }

	// RVA: 0x14AB750 Offset: 0x14A9D50 VA: 0x1814AB750
	public static void Insert(string parent, object contents, Action<bool, string> onFinished) { }

	// RVA: 0x14ABAD0 Offset: 0x14AA0D0 VA: 0x1814ABAD0
	public static void Remove(string parent, string id, Action<bool> onFinished) { }

	// RVA: -1 Offset: -1
	public static Result<T> Query<T>(string parent, int limit, Action<Result<T>> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CB90 Offset: 0x125B190 VA: 0x18125CB90
	|-Database.Query<object>
	*/

	// RVA: 0x14AB5A0 Offset: 0x14A9BA0 VA: 0x1814AB5A0
	public static void Count(string parent, Action<int> onResult) { }

}

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6182
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCAA0 Offset: 0x14BB0A0 VA: 0x1814BCAA0
	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6183
{	// Fields
	public Action<bool, string> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCB90 Offset: 0x14BB190 VA: 0x1814BCB90
	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6184
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCD10 Offset: 0x14BB310 VA: 0x1814BCD10
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
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-Database.<>c__DisplayClass3_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__0(object s, DownloadStringCompletedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E90F0 Offset: 0x15E76F0 VA: 0x1815E90F0
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9480 Offset: 0x15E7A80 VA: 0x1815E9480
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
	|-RVA: 0xD65280 Offset: 0xD63880 VA: 0x180D65280
	|-Database.<>c__3<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-Database.<>c__3<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Result.Entry<T> <Query>b__3_2(QueryResponse x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8F40 Offset: 0x15E7540 VA: 0x1815E8F40
	|-Database.<>c__3<object>.<Query>b__3_2
	*/

}

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6187
{	// Fields
	public Action<int> onResult; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCE00 Offset: 0x14BB400 VA: 0x1814BCE00
	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6188
{	// Fields
	public int count; // 0x10
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCF90 Offset: 0x14BB590 VA: 0x1814BCF90
	internal void <Count>b__1() { }

}

public class Database // TypeDefIndex: 7356
{
// Namespace: Facepunch.Sqlite
public class Database // TypeDefIndex: 7356
	// Fields
	private IntPtr _connection; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsConnectionOpen>k__BackingField; // 0x18

	// Properties
	private bool IsConnectionOpen { get; set; }
	public int AffectedRows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	private void set_IsConnectionOpen(bool value) { }

	// RVA: 0x231DA40 Offset: 0x231C040 VA: 0x18231DA40
	public void Open(string path, bool fastMode = False) { }

	// RVA: 0x231E190 Offset: 0x231C790 VA: 0x18231E190
	public bool TableExists(string name) { }

	// RVA: 0x231D9D0 Offset: 0x231BFD0 VA: 0x18231D9D0
	public bool IndexExists(string tableName, string indexName) { }

	// RVA: 0x231D200 Offset: 0x231B800 VA: 0x18231D200
	public bool ColumnExists(string tableName, string columnName) { }

	// RVA: 0x231D130 Offset: 0x231B730 VA: 0x18231D130
	public void Close() { }

	// RVA: 0x231E1F0 Offset: 0x231C7F0 VA: 0x18231E1F0
	public int get_AffectedRows() { }

	// RVA: 0x231D500 Offset: 0x231BB00 VA: 0x18231D500
	public void Execute(string query) { }

	// RVA: -1 Offset: -1
	public void Execute<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15724E0 Offset: 0x1570AE0 VA: 0x1815724E0
	|-Database.Execute<int>
	|
	|-RVA: 0x1572880 Offset: 0x1570E80 VA: 0x181572880
	|-Database.Execute<object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572350 Offset: 0x1570950 VA: 0x181572350
	|-Database.Execute<int, int>
	|
	|-RVA: 0x15727E0 Offset: 0x1570DE0 VA: 0x1815727E0
	|-Database.Execute<object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3>(string query, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572290 Offset: 0x1570890 VA: 0x181572290
	|-Database.Execute<int, int, int>
	|
	|-RVA: 0x1572720 Offset: 0x1570D20 VA: 0x181572720
	|-Database.Execute<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15721B0 Offset: 0x15707B0 VA: 0x1815721B0
	|-Database.Execute<int, int, int, int>
	|
	|-RVA: 0x1572640 Offset: 0x1570C40 VA: 0x181572640
	|-Database.Execute<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4, T5>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15723F0 Offset: 0x15709F0 VA: 0x1815723F0
	|-Database.Execute<int, byte[], int, int, int>
	|-Database.Execute<int, object, int, int, int>
	|
	|-RVA: 0x1572550 Offset: 0x1570B50 VA: 0x181572550
	|-Database.Execute<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	protected static void Bind<T>(IntPtr stmHandle, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15715A0 Offset: 0x156FBA0 VA: 0x1815715A0
	|-Database.Bind<int>
	|
	|-RVA: 0x1571BA0 Offset: 0x15701A0 VA: 0x181571BA0
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

	// RVA: 0x231DEF0 Offset: 0x231C4F0 VA: 0x18231DEF0
	public int QueryInt(string query) { }

	// RVA: -1 Offset: -1
	public int QueryInt<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178DB0 Offset: 0x11773B0 VA: 0x181178DB0
	|-Database.QueryInt<object>
	|-Database.QueryInt<string>
	*/

	// RVA: -1 Offset: -1
	public int QueryInt<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178CE0 Offset: 0x11772E0 VA: 0x181178CE0
	|-Database.QueryInt<object, object>
	|-Database.QueryInt<string, string>
	*/

	// RVA: 0x231DF50 Offset: 0x231C550 VA: 0x18231DF50
	public long QueryLong(string query) { }

	// RVA: -1 Offset: -1
	public string QueryString<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED28F0 Offset: 0xED0EF0 VA: 0x180ED28F0
	|-Database.QueryString<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537AB0 Offset: 0x15360B0 VA: 0x181537AB0
	|-Database.QueryBlob<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEAE0 Offset: 0xBED0E0 VA: 0x180BEEAE0
	|-Database.QueryBlob<int, int, int, int>
	|
	|-RVA: 0xBEEBE0 Offset: 0xBED1E0 VA: 0x180BEEBE0
	|-Database.QueryBlob<object, object, object, object>
	*/

	// RVA: 0x231D0E0 Offset: 0x231B6E0 VA: 0x18231D0E0
	public void BeginTransaction() { }

	// RVA: 0x231D270 Offset: 0x231B870 VA: 0x18231D270
	public void Commit() { }

	// RVA: 0x231E140 Offset: 0x231C740 VA: 0x18231E140
	public void Rollback() { }

	// RVA: 0x231D2C0 Offset: 0x231B8C0 VA: 0x18231D2C0
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

	[IteratorStateMachineAttribute] // RVA: 0x9A680 Offset: 0x99A80 VA: 0x18009A680
	// RVA: -1 Offset: -1
	protected IEnumerable<T> ExecuteAndReadQueryResults<T>(IntPtr stmHandle, Func<IntPtr, T> rowReader, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF7E0 Offset: 0xCFDDE0 VA: 0x180CFF7E0
	|-Database.ExecuteAndReadQueryResults<object>
	*/

	// RVA: 0x231DCC0 Offset: 0x231C2C0 VA: 0x18231DCC0
	protected IntPtr Prepare(string query) { }

	// RVA: 0x231D530 Offset: 0x231BB30 VA: 0x18231D530
	private void FinalizeOrReset(IntPtr stmHandle, bool finalize = True) { }

	// RVA: 0x231D840 Offset: 0x231BE40 VA: 0x18231D840
	protected void Finalize(IntPtr stmHandle) { }

	// RVA: 0x231DFB0 Offset: 0x231C5B0 VA: 0x18231DFB0
	protected void Reset(IntPtr stmHandle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static Exception <GetColumnValue>g__TypeError|19_0<T>(ref Database.<>c__DisplayClass19_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B19D10 Offset: 0x1B18310 VA: 0x181B19D10
	|-Database.<GetColumnValue>g__TypeError|19_0<int>
	|
	|-RVA: 0x1B19E10 Offset: 0x1B18410 VA: 0x181B19E10
	|-Database.<GetColumnValue>g__TypeError|19_0<long>
	|
	|-RVA: 0x1B19F10 Offset: 0x1B18510 VA: 0x181B19F10
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B840 Offset: 0x1449E40 VA: 0x18144B840
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B500 Offset: 0x1449B00 VA: 0x18144B500
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8880 Offset: 0x15E6E80 VA: 0x1815E8880
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8B00 Offset: 0x15E7100 VA: 0x1815E8B00
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8AB0 Offset: 0x15E70B0 VA: 0x1815E8AB0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E89B0 Offset: 0x15E6FB0 VA: 0x1815E89B0
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8A80 Offset: 0x15E7080 VA: 0x1815E8A80
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7622
{	// Methods

	// RVA: 0x13976E0 Offset: 0x1395CE0 VA: 0x1813976E0
	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	// RVA: 0x13976D0 Offset: 0x1395CD0 VA: 0x1813976D0
	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1397950 Offset: 0x1395F50 VA: 0x181397950
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1397890 Offset: 0x1395E90 VA: 0x181397890
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static byte GetTail(short number) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1397740 Offset: 0x1395D40 VA: 0x181397740
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x13977F0 Offset: 0x1395DF0 VA: 0x1813977F0
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x13977E0 Offset: 0x1395DE0 VA: 0x1813977E0
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7825
{	// Properties
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }

	// Methods

	// RVA: 0x224EAD0 Offset: 0x224D0D0 VA: 0x18224EAD0
	public void .ctor(int codePage) { }

	// RVA: 0x224EAE0 Offset: 0x224D0E0 VA: 0x18224EAE0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract DbcsConvert GetConvert();

	// RVA: 0x224E530 Offset: 0x224CB30 VA: 0x18224E530 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x224E6B0 Offset: 0x224CCB0 VA: 0x18224E6B0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224E810 Offset: 0x224CE10 VA: 0x18224E810 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224E9D0 Offset: 0x224CFD0 VA: 0x18224E9D0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224EA50 Offset: 0x224D050 VA: 0x18224EA50 Slot: 41
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

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224E410 Offset: 0x224CA10 VA: 0x18224E410
	internal void CheckRange(byte[] bytes, int index, int count) { }

	// RVA: 0x224E250 Offset: 0x224C850 VA: 0x18224E250
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

	// RVA: 0x224E0C0 Offset: 0x224C6C0 VA: 0x18224E0C0
	internal void .ctor(string fileName) { }

	// RVA: 0x224DFE0 Offset: 0x224C5E0 VA: 0x18224DFE0
	private static void .cctor() { }

}

public class Data : ConsoleSystem // TypeDefIndex: 11898
{	// Methods

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6D5CE0 Offset: 0x6D42E0 VA: 0x1806D5CE0
	public static void export(ConsoleSystem.Arg args) { }

	// RVA: 0x6D5C80 Offset: 0x6D4280 VA: 0x1806D5C80
	public void .ctor() { }

}

