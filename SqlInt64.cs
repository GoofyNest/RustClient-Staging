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

	// RVA: 0xCC58C0 Offset: 0xCC3EC0 VA: 0x180CC58C0
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x11A300 Offset: 0x119700 VA: 0x18011A300 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC5F80 Offset: 0xCC4580 VA: 0x180CC5F80
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xCC5000 Offset: 0xCC3600 VA: 0x180CC5000
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5E00 Offset: 0xCC4400 VA: 0x180CC5E00
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5B30 Offset: 0xCC4130 VA: 0x180CC5B30
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5180 Offset: 0xCC3780 VA: 0x180CC5180
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC59A0 Offset: 0xCC3FA0 VA: 0x180CC59A0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC56A0 Offset: 0xCC3CA0 VA: 0x180CC56A0
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xCC5800 Offset: 0xCC3E00 VA: 0x180CC5800
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC5740 Offset: 0xCC3D40 VA: 0x180CC5740
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC53D0 Offset: 0xCC39D0 VA: 0x180CC53D0
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC49F0 Offset: 0xCC2FF0 VA: 0x180CC49F0
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0xCC5310 Offset: 0xCC3910 VA: 0x180CC5310
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC58E0 Offset: 0xCC3EE0 VA: 0x180CC58E0
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC55E0 Offset: 0xCC3BE0 VA: 0x180CC55E0
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC48E0 Offset: 0xCC2EE0 VA: 0x180CC48E0
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC47D0 Offset: 0xCC2DD0 VA: 0x180CC47D0
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

	// RVA: 0xCC4770 Offset: 0xCC2D70 VA: 0x180CC4770
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC4EA0 Offset: 0xCC34A0 VA: 0x180CC4EA0
	private static void .cctor() { }

}

