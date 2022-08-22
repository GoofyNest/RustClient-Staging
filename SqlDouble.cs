public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4345
{	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x118130 Offset: 0x117530 VA: 0x180118130
	private void .ctor(bool fNull) { }

	// RVA: 0x118140 Offset: 0x117540 VA: 0x180118140
	public void .ctor(double value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x118160 Offset: 0x117560 VA: 0x180118160
	public double get_Value() { }

	// RVA: 0xCC1090 Offset: 0xCBF690 VA: 0x180CC1090
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x118110 Offset: 0x117510 VA: 0x180118110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC13C0 Offset: 0xCBF9C0 VA: 0x180CC13C0
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xCC0760 Offset: 0xCBED60 VA: 0x180CC0760
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1290 Offset: 0xCBF890 VA: 0x180CC1290
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1160 Offset: 0xCBF760 VA: 0x180CC1160
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0890 Offset: 0xCBEE90 VA: 0x180CC0890
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0C50 Offset: 0xCBF250 VA: 0x180CC0C50
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xCC0D00 Offset: 0xCBF300 VA: 0x180CC0D00
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC0B90 Offset: 0xCBF190 VA: 0x180CC0B90
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC0F10 Offset: 0xCBF510 VA: 0x180CC0F10
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC0FD0 Offset: 0xCBF5D0 VA: 0x180CC0FD0
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xCC0DC0 Offset: 0xCBF3C0 VA: 0x180CC0DC0
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xCC0E60 Offset: 0xCBF460 VA: 0x180CC0E60
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC0A10 Offset: 0xCBF010 VA: 0x180CC0A10
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC10B0 Offset: 0xCBF6B0 VA: 0x180CC10B0
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0AE0 Offset: 0xCBF0E0 VA: 0x180CC0AE0
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC02A0 Offset: 0xCBE8A0 VA: 0x180CC02A0
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC01B0 Offset: 0xCBE7B0 VA: 0x180CC01B0
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x117F90 Offset: 0x117390 VA: 0x180117F90
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x117A00 Offset: 0x116E00 VA: 0x180117A00 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x117B10 Offset: 0x116F10 VA: 0x180117B10
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x117B30 Offset: 0x116F30 VA: 0x180117B30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x117CF0 Offset: 0x1170F0 VA: 0x180117CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x117D90 Offset: 0x117190 VA: 0x180117D90 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x117EB0 Offset: 0x1172B0 VA: 0x180117EB0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC0150 Offset: 0xCBE750 VA: 0x180CC0150
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC0510 Offset: 0xCBEB10 VA: 0x180CC0510
	private static void .cctor() { }

}

