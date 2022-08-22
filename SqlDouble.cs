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

	// RVA: 0xCC1350 Offset: 0xCBF950 VA: 0x180CC1350
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x118110 Offset: 0x117510 VA: 0x180118110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC1680 Offset: 0xCBFC80 VA: 0x180CC1680
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xCC0A20 Offset: 0xCBF020 VA: 0x180CC0A20
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1550 Offset: 0xCBFB50 VA: 0x180CC1550
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1420 Offset: 0xCBFA20 VA: 0x180CC1420
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0B50 Offset: 0xCBF150 VA: 0x180CC0B50
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0F10 Offset: 0xCBF510 VA: 0x180CC0F10
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xCC0FC0 Offset: 0xCBF5C0 VA: 0x180CC0FC0
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC0E50 Offset: 0xCBF450 VA: 0x180CC0E50
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC11D0 Offset: 0xCBF7D0 VA: 0x180CC11D0
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC1290 Offset: 0xCBF890 VA: 0x180CC1290
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xCC1080 Offset: 0xCBF680 VA: 0x180CC1080
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xCC1120 Offset: 0xCBF720 VA: 0x180CC1120
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC0CD0 Offset: 0xCBF2D0 VA: 0x180CC0CD0
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1370 Offset: 0xCBF970 VA: 0x180CC1370
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0DA0 Offset: 0xCBF3A0 VA: 0x180CC0DA0
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0560 Offset: 0xCBEB60 VA: 0x180CC0560
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0470 Offset: 0xCBEA70 VA: 0x180CC0470
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

	// RVA: 0xCC0410 Offset: 0xCBEA10 VA: 0x180CC0410
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC07D0 Offset: 0xCBEDD0 VA: 0x180CC07D0
	private static void .cctor() { }

}

