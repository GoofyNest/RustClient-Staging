public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4347
{	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x119080 Offset: 0x118480 VA: 0x180119080
	private void .ctor(bool fNull) { }

	// RVA: 0x119090 Offset: 0x118490 VA: 0x180119090
	public void .ctor(short value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1190A0 Offset: 0x1184A0 VA: 0x1801190A0
	public short get_Value() { }

	// RVA: 0xCC2E10 Offset: 0xCC1410 VA: 0x180CC2E10
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x119060 Offset: 0x118460 VA: 0x180119060 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC3100 Offset: 0xCC1700 VA: 0x180CC3100
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xCC2920 Offset: 0xCC0F20 VA: 0x180CC2920
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC3010 Offset: 0xCC1610 VA: 0x180CC3010
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2ED0 Offset: 0xCC14D0 VA: 0x180CC2ED0
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2A10 Offset: 0xCC1010 VA: 0x180CC2A10
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2D70 Offset: 0xCC1370 VA: 0x180CC2D70
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xCC2BE0 Offset: 0xCC11E0 VA: 0x180CC2BE0
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCC2B40 Offset: 0xCC1140 VA: 0x180CC2B40
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2E30 Offset: 0xCC1430 VA: 0x180CC2E30
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2CD0 Offset: 0xCC12D0 VA: 0x180CC2CD0
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2520 Offset: 0xCC0B20 VA: 0x180CC2520
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC24C0 Offset: 0xCC0AC0 VA: 0x180CC24C0
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x118DE0 Offset: 0x1181E0 VA: 0x180118DE0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x118F20 Offset: 0x118320 VA: 0x180118F20
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x118900 Offset: 0x117D00 VA: 0x180118900 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1188F0 Offset: 0x117CF0 VA: 0x1801188F0
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x118A00 Offset: 0x117E00 VA: 0x180118A00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x118B70 Offset: 0x117F70 VA: 0x180118B70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x118BF0 Offset: 0x117FF0 VA: 0x180118BF0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118D10 Offset: 0x118110 VA: 0x180118D10 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC2460 Offset: 0xCC0A60 VA: 0x180CC2460
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC27F0 Offset: 0xCC0DF0 VA: 0x180CC27F0
	private static void .cctor() { }

}

