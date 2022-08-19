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

	// RVA: 0x119910 Offset: 0x118D10 VA: 0x180119910
	private void .ctor(bool fNull) { }

	// RVA: 0x119920 Offset: 0x118D20 VA: 0x180119920
	public void .ctor(int value) { }

	// RVA: 0x1181D0 Offset: 0x1175D0 VA: 0x1801181D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x119930 Offset: 0x118D30 VA: 0x180119930
	public int get_Value() { }

	// RVA: 0xCC3CD0 Offset: 0xCC22D0 VA: 0x180CC3CD0
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x1198F0 Offset: 0x118CF0 VA: 0x1801198F0 Slot: 3
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

	// RVA: 0x1196A0 Offset: 0x118AA0 VA: 0x1801196A0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1197B0 Offset: 0x118BB0 VA: 0x1801197B0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1191B0 Offset: 0x1185B0 VA: 0x1801191B0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1192B0 Offset: 0x1186B0 VA: 0x1801192B0
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1192C0 Offset: 0x1186C0 VA: 0x1801192C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x119440 Offset: 0x118840 VA: 0x180119440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1194C0 Offset: 0x1188C0 VA: 0x1801194C0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1195D0 Offset: 0x1189D0 VA: 0x1801195D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC3190 Offset: 0xCC1790 VA: 0x180CC3190
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC3540 Offset: 0xCC1B40 VA: 0x180CC3540
	private static void .cctor() { }

}

