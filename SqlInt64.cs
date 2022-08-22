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

	// RVA: 0xCC5600 Offset: 0xCC3C00 VA: 0x180CC5600
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x11A300 Offset: 0x119700 VA: 0x18011A300 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC5CC0 Offset: 0xCC42C0 VA: 0x180CC5CC0
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xCC4D40 Offset: 0xCC3340 VA: 0x180CC4D40
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5B40 Offset: 0xCC4140 VA: 0x180CC5B40
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5870 Offset: 0xCC3E70 VA: 0x180CC5870
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC4EC0 Offset: 0xCC34C0 VA: 0x180CC4EC0
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC56E0 Offset: 0xCC3CE0 VA: 0x180CC56E0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC53E0 Offset: 0xCC39E0 VA: 0x180CC53E0
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xCC5540 Offset: 0xCC3B40 VA: 0x180CC5540
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC5480 Offset: 0xCC3A80 VA: 0x180CC5480
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC5110 Offset: 0xCC3710 VA: 0x180CC5110
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC4730 Offset: 0xCC2D30 VA: 0x180CC4730
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0xCC5050 Offset: 0xCC3650 VA: 0x180CC5050
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5620 Offset: 0xCC3C20 VA: 0x180CC5620
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC5320 Offset: 0xCC3920 VA: 0x180CC5320
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC4620 Offset: 0xCC2C20 VA: 0x180CC4620
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC4510 Offset: 0xCC2B10 VA: 0x180CC4510
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

	// RVA: 0xCC44B0 Offset: 0xCC2AB0 VA: 0x180CC44B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC4BE0 Offset: 0xCC31E0 VA: 0x180CC4BE0
	private static void .cctor() { }

}

