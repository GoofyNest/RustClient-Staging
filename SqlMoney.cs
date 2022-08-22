public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4350
{	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x118130 Offset: 0x117530 VA: 0x180118130
	private void .ctor(bool fNull) { }

	// RVA: 0x11A320 Offset: 0x119720 VA: 0x18011A320
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x11AA00 Offset: 0x119E00 VA: 0x18011AA00
	public void .ctor(int value) { }

	// RVA: 0x11AA10 Offset: 0x119E10 VA: 0x18011AA10
	public void .ctor(long value) { }

	// RVA: 0x11AA20 Offset: 0x119E20 VA: 0x18011AA20
	public void .ctor(Decimal value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11AA40 Offset: 0x119E40 VA: 0x18011AA40
	public Decimal get_Value() { }

	// RVA: 0x11A8B0 Offset: 0x119CB0 VA: 0x18011A8B0
	public Decimal ToDecimal() { }

	// RVA: 0x11A8D0 Offset: 0x119CD0 VA: 0x18011A8D0
	public double ToDouble() { }

	// RVA: 0xCC74D0 Offset: 0xCC5AD0 VA: 0x180CC74D0
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xCC7300 Offset: 0xCC5900 VA: 0x180CC7300
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x11A990 Offset: 0x119D90 VA: 0x18011A990 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC7850 Offset: 0xCC5E50 VA: 0x180CC7850
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xCC6CD0 Offset: 0xCC52D0 VA: 0x180CC6CD0
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC76F0 Offset: 0xCC5CF0 VA: 0x180CC76F0
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC75C0 Offset: 0xCC5BC0 VA: 0x180CC75C0
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC6E30 Offset: 0xCC5430 VA: 0x180CC6E30
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC71A0 Offset: 0xCC57A0 VA: 0x180CC71A0
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xCC7240 Offset: 0xCC5840 VA: 0x180CC7240
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC7350 Offset: 0xCC5950 VA: 0x180CC7350
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC7410 Offset: 0xCC5A10 VA: 0x180CC7410
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC7020 Offset: 0xCC5620 VA: 0x180CC7020
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC6F60 Offset: 0xCC5560 VA: 0x180CC6F60
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7500 Offset: 0xCC5B00 VA: 0x180CC7500
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC70E0 Offset: 0xCC56E0 VA: 0x180CC70E0
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC62B0 Offset: 0xCC48B0 VA: 0x180CC62B0
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC61A0 Offset: 0xCC47A0 VA: 0x180CC61A0
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x11A970 Offset: 0x119D70 VA: 0x18011A970
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11A8E0 Offset: 0x119CE0 VA: 0x18011A8E0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x11A3B0 Offset: 0x1197B0 VA: 0x18011A3B0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11A390 Offset: 0x119790 VA: 0x18011A390
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x11A4C0 Offset: 0x1198C0 VA: 0x18011A4C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11A650 Offset: 0x119A50 VA: 0x18011A650 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11A670 Offset: 0x119A70 VA: 0x18011A670 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11A7C0 Offset: 0x119BC0 VA: 0x18011A7C0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC6140 Offset: 0xCC4740 VA: 0x180CC6140
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC67B0 Offset: 0xCC4DB0 VA: 0x180CC67B0
	private static void .cctor() { }

}

