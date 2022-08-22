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

	// RVA: 0xCC7790 Offset: 0xCC5D90 VA: 0x180CC7790
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xCC75C0 Offset: 0xCC5BC0 VA: 0x180CC75C0
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x11A990 Offset: 0x119D90 VA: 0x18011A990 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC7B10 Offset: 0xCC6110 VA: 0x180CC7B10
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xCC6F90 Offset: 0xCC5590 VA: 0x180CC6F90
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC79B0 Offset: 0xCC5FB0 VA: 0x180CC79B0
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7880 Offset: 0xCC5E80 VA: 0x180CC7880
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC70F0 Offset: 0xCC56F0 VA: 0x180CC70F0
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7460 Offset: 0xCC5A60 VA: 0x180CC7460
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xCC7500 Offset: 0xCC5B00 VA: 0x180CC7500
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC7610 Offset: 0xCC5C10 VA: 0x180CC7610
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC76D0 Offset: 0xCC5CD0 VA: 0x180CC76D0
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC72E0 Offset: 0xCC58E0 VA: 0x180CC72E0
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC7220 Offset: 0xCC5820 VA: 0x180CC7220
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC77C0 Offset: 0xCC5DC0 VA: 0x180CC77C0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC73A0 Offset: 0xCC59A0 VA: 0x180CC73A0
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC6570 Offset: 0xCC4B70 VA: 0x180CC6570
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC6460 Offset: 0xCC4A60 VA: 0x180CC6460
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

	// RVA: 0xCC6400 Offset: 0xCC4A00 VA: 0x180CC6400
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC6A70 Offset: 0xCC5070 VA: 0x180CC6A70
	private static void .cctor() { }

}

