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

	// RVA: 0xCC7C30 Offset: 0xCC6230 VA: 0x180CC7C30
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xCC7A60 Offset: 0xCC6060 VA: 0x180CC7A60
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x11A990 Offset: 0x119D90 VA: 0x18011A990 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC7FB0 Offset: 0xCC65B0 VA: 0x180CC7FB0
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xCC7430 Offset: 0xCC5A30 VA: 0x180CC7430
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7E50 Offset: 0xCC6450 VA: 0x180CC7E50
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7D20 Offset: 0xCC6320 VA: 0x180CC7D20
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7590 Offset: 0xCC5B90 VA: 0x180CC7590
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7900 Offset: 0xCC5F00 VA: 0x180CC7900
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xCC79A0 Offset: 0xCC5FA0 VA: 0x180CC79A0
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC7AB0 Offset: 0xCC60B0 VA: 0x180CC7AB0
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC7B70 Offset: 0xCC6170 VA: 0x180CC7B70
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC7780 Offset: 0xCC5D80 VA: 0x180CC7780
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC76C0 Offset: 0xCC5CC0 VA: 0x180CC76C0
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7C60 Offset: 0xCC6260 VA: 0x180CC7C60
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC7840 Offset: 0xCC5E40 VA: 0x180CC7840
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC6A10 Offset: 0xCC5010 VA: 0x180CC6A10
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC6900 Offset: 0xCC4F00 VA: 0x180CC6900
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

	// RVA: 0xCC68A0 Offset: 0xCC4EA0 VA: 0x180CC68A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC6F10 Offset: 0xCC5510 VA: 0x180CC6F10
	private static void .cctor() { }

}

