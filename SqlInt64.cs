public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4349
{	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x118130 Offset: 0x117530 VA: 0x180118130
	private void .ctor(bool fNull) { }

	// RVA: 0x11A320 Offset: 0x119720 VA: 0x18011A320
	public void .ctor(long value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11A330 Offset: 0x119730 VA: 0x18011A330
	public long get_Value() { }

	// RVA: 0xCC5D60 Offset: 0xCC4360 VA: 0x180CC5D60
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x11A300 Offset: 0x119700 VA: 0x18011A300 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC6420 Offset: 0xCC4A20 VA: 0x180CC6420
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xCC54A0 Offset: 0xCC3AA0 VA: 0x180CC54A0
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC62A0 Offset: 0xCC48A0 VA: 0x180CC62A0
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5FD0 Offset: 0xCC45D0 VA: 0x180CC5FD0
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5620 Offset: 0xCC3C20 VA: 0x180CC5620
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5E40 Offset: 0xCC4440 VA: 0x180CC5E40
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5B40 Offset: 0xCC4140 VA: 0x180CC5B40
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xCC5CA0 Offset: 0xCC42A0 VA: 0x180CC5CA0
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC5BE0 Offset: 0xCC41E0 VA: 0x180CC5BE0
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC5870 Offset: 0xCC3E70 VA: 0x180CC5870
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC4E90 Offset: 0xCC3490 VA: 0x180CC4E90
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0xCC57B0 Offset: 0xCC3DB0 VA: 0x180CC57B0
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5D80 Offset: 0xCC4380 VA: 0x180CC5D80
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5A80 Offset: 0xCC4080 VA: 0x180CC5A80
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC4D80 Offset: 0xCC3380 VA: 0x180CC4D80
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC4C70 Offset: 0xCC3270 VA: 0x180CC4C70
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x119E60 Offset: 0x119260 VA: 0x180119E60
	public SqlByte ToSqlByte() { }

	// RVA: 0x119F60 Offset: 0x119360 VA: 0x180119F60
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11A080 Offset: 0x119480 VA: 0x18011A080
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x11A1C0 Offset: 0x1195C0 VA: 0x18011A1C0
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x119ED0 Offset: 0x1192D0 VA: 0x180119ED0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x119930 Offset: 0x118D30 VA: 0x180119930 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x119A40 Offset: 0x118E40 VA: 0x180119A40
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x119A60 Offset: 0x118E60 VA: 0x180119A60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x119BF0 Offset: 0x118FF0 VA: 0x180119BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x119C70 Offset: 0x119070 VA: 0x180119C70 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x119D90 Offset: 0x119190 VA: 0x180119D90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC4C10 Offset: 0xCC3210 VA: 0x180CC4C10
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC5340 Offset: 0xCC3940 VA: 0x180CC5340
	private static void .cctor() { }

}

