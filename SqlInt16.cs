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

	// RVA: 0xCC32B0 Offset: 0xCC18B0 VA: 0x180CC32B0
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x119060 Offset: 0x118460 VA: 0x180119060 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC35A0 Offset: 0xCC1BA0 VA: 0x180CC35A0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xCC2DC0 Offset: 0xCC13C0 VA: 0x180CC2DC0
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC34B0 Offset: 0xCC1AB0 VA: 0x180CC34B0
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC3370 Offset: 0xCC1970 VA: 0x180CC3370
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2EB0 Offset: 0xCC14B0 VA: 0x180CC2EB0
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC3210 Offset: 0xCC1810 VA: 0x180CC3210
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xCC3080 Offset: 0xCC1680 VA: 0x180CC3080
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCC2FE0 Offset: 0xCC15E0 VA: 0x180CC2FE0
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC32D0 Offset: 0xCC18D0 VA: 0x180CC32D0
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC3170 Offset: 0xCC1770 VA: 0x180CC3170
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC29C0 Offset: 0xCC0FC0 VA: 0x180CC29C0
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCC2960 Offset: 0xCC0F60 VA: 0x180CC2960
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

	// RVA: 0xCC2900 Offset: 0xCC0F00 VA: 0x180CC2900
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC2C90 Offset: 0xCC1290 VA: 0x180CC2C90
	private static void .cctor() { }

}

