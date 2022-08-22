public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4348
{	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x119890 Offset: 0x118C90 VA: 0x180119890
	private void .ctor(bool fNull) { }

	// RVA: 0x1198A0 Offset: 0x118CA0 VA: 0x1801198A0
	public void .ctor(int value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1198B0 Offset: 0x118CB0 VA: 0x1801198B0
	public int get_Value() { }

	// RVA: 0xCC3CD0 Offset: 0xCC22D0 VA: 0x180CC3CD0
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x119870 Offset: 0x118C70 VA: 0x180119870 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC4040 Offset: 0xCC2640 VA: 0x180CC4040
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xCC3690 Offset: 0xCC1C90 VA: 0x180CC3690
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3EF0 Offset: 0xCC24F0 VA: 0x180CC3EF0
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3DA0 Offset: 0xCC23A0 VA: 0x180CC3DA0
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC37E0 Offset: 0xCC1DE0 VA: 0x180CC37E0
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3B90 Offset: 0xCC2190 VA: 0x180CC3B90
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xCC3C30 Offset: 0xCC2230 VA: 0x180CC3C30
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC39F0 Offset: 0xCC1FF0 VA: 0x180CC39F0
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCC32D0 Offset: 0xCC18D0 VA: 0x180CC32D0
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0xCC3940 Offset: 0xCC1F40 VA: 0x180CC3940
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3CF0 Offset: 0xCC22F0 VA: 0x180CC3CF0
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3AE0 Offset: 0xCC20E0 VA: 0x180CC3AE0
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC3260 Offset: 0xCC1860 VA: 0x180CC3260
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCC31F0 Offset: 0xCC17F0 VA: 0x180CC31F0
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x119620 Offset: 0x118A20 VA: 0x180119620
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x119730 Offset: 0x118B30 VA: 0x180119730
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x119130 Offset: 0x118530 VA: 0x180119130 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x119230 Offset: 0x118630 VA: 0x180119230
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x119240 Offset: 0x118640 VA: 0x180119240 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1193C0 Offset: 0x1187C0 VA: 0x1801193C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x119440 Offset: 0x118840 VA: 0x180119440 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x119550 Offset: 0x118950 VA: 0x180119550 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC3190 Offset: 0xCC1790 VA: 0x180CC3190
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC3540 Offset: 0xCC1B40 VA: 0x180CC3540
	private static void .cctor() { }

}

