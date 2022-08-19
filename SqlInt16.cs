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

	// RVA: 0x119100 Offset: 0x118500 VA: 0x180119100
	private void .ctor(bool fNull) { }

	// RVA: 0x119110 Offset: 0x118510 VA: 0x180119110
	public void .ctor(short value) { }

	// RVA: 0x1181D0 Offset: 0x1175D0 VA: 0x1801181D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x119120 Offset: 0x118520 VA: 0x180119120
	public short get_Value() { }

	// RVA: 0xCC2B50 Offset: 0xCC1150 VA: 0x180CC2B50
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x1190E0 Offset: 0x1184E0 VA: 0x1801190E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC2E40 Offset: 0xCC1440 VA: 0x180CC2E40
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xCC2660 Offset: 0xCC0C60 VA: 0x180CC2660
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2D50 Offset: 0xCC1350 VA: 0x180CC2D50
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2C10 Offset: 0xCC1210 VA: 0x180CC2C10
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2750 Offset: 0xCC0D50 VA: 0x180CC2750
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2AB0 Offset: 0xCC10B0 VA: 0x180CC2AB0
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xCC2920 Offset: 0xCC0F20 VA: 0x180CC2920
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCC2880 Offset: 0xCC0E80 VA: 0x180CC2880
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2B70 Offset: 0xCC1170 VA: 0x180CC2B70
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2A10 Offset: 0xCC1010 VA: 0x180CC2A10
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2260 Offset: 0xCC0860 VA: 0x180CC2260
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2200 Offset: 0xCC0800 VA: 0x180CC2200
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x118E60 Offset: 0x118260 VA: 0x180118E60
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x118FA0 Offset: 0x1183A0 VA: 0x180118FA0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x118980 Offset: 0x117D80 VA: 0x180118980 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x118970 Offset: 0x117D70 VA: 0x180118970
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x118A80 Offset: 0x117E80 VA: 0x180118A80 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x118BF0 Offset: 0x117FF0 VA: 0x180118BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x118C70 Offset: 0x118070 VA: 0x180118C70 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118D90 Offset: 0x118190 VA: 0x180118D90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC21A0 Offset: 0xCC07A0 VA: 0x180CC21A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC2530 Offset: 0xCC0B30 VA: 0x180CC2530
	private static void .cctor() { }

}
