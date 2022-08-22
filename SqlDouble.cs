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

	// RVA: 0xCC17F0 Offset: 0xCBFDF0 VA: 0x180CC17F0
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x118110 Offset: 0x117510 VA: 0x180118110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC1B20 Offset: 0xCC0120 VA: 0x180CC1B20
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xCC0EC0 Offset: 0xCBF4C0 VA: 0x180CC0EC0
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC19F0 Offset: 0xCBFFF0 VA: 0x180CC19F0
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC18C0 Offset: 0xCBFEC0 VA: 0x180CC18C0
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0FF0 Offset: 0xCBF5F0 VA: 0x180CC0FF0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC13B0 Offset: 0xCBF9B0 VA: 0x180CC13B0
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xCC1460 Offset: 0xCBFA60 VA: 0x180CC1460
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC12F0 Offset: 0xCBF8F0 VA: 0x180CC12F0
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC1670 Offset: 0xCBFC70 VA: 0x180CC1670
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC1730 Offset: 0xCBFD30 VA: 0x180CC1730
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xCC1520 Offset: 0xCBFB20 VA: 0x180CC1520
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xCC15C0 Offset: 0xCBFBC0 VA: 0x180CC15C0
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC1170 Offset: 0xCBF770 VA: 0x180CC1170
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1810 Offset: 0xCBFE10 VA: 0x180CC1810
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC1240 Offset: 0xCBF840 VA: 0x180CC1240
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0A00 Offset: 0xCBF000 VA: 0x180CC0A00
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCC0910 Offset: 0xCBEF10 VA: 0x180CC0910
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

	// RVA: 0xCC08B0 Offset: 0xCBEEB0 VA: 0x180CC08B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC0C70 Offset: 0xCBF270 VA: 0x180CC0C70
	private static void .cctor() { }

}

