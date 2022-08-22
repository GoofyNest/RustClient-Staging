public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4339
{	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x138930 Offset: 0x137D30 VA: 0x180138930
	private void .ctor(bool fNull) { }

	// RVA: 0x138940 Offset: 0x137D40 VA: 0x180138940
	public void .ctor(byte value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x138950 Offset: 0x137D50 VA: 0x180138950
	public byte get_Value() { }

	// RVA: 0xE9E060 Offset: 0xE9C660 VA: 0x180E9E060
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x1388E0 Offset: 0x137CE0 VA: 0x1801388E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9DC60 Offset: 0xE9C260 VA: 0x180E9DC60
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xE9E210 Offset: 0xE9C810 VA: 0x180E9E210
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xE9E100 Offset: 0xE9C700 VA: 0x180E9E100
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xE9DD60 Offset: 0xE9C360 VA: 0x180E9DD60
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xE9DED0 Offset: 0xE9C4D0 VA: 0x180E9DED0
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xE9DE40 Offset: 0xE9C440 VA: 0x180E9DE40
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xE9E070 Offset: 0xE9C670 VA: 0x180E9E070
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9DFD0 Offset: 0xE9C5D0 VA: 0x180E9DFD0
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D9F0 Offset: 0xE9BFF0 VA: 0x180E9D9F0
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D980 Offset: 0xE9BF80 VA: 0x180E9D980
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1387E0 Offset: 0x137BE0 VA: 0x1801387E0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x138860 Offset: 0x137C60 VA: 0x180138860
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1382E0 Offset: 0x1376E0 VA: 0x1801382E0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1383E0 Offset: 0x1377E0 VA: 0x1801383E0
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1383F0 Offset: 0x1377F0 VA: 0x1801383F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138580 Offset: 0x137980 VA: 0x180138580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138600 Offset: 0x137A00 VA: 0x180138600 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138710 Offset: 0x137B10 VA: 0x180138710 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9D920 Offset: 0xE9BF20 VA: 0x180E9D920
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9DB40 Offset: 0xE9C140 VA: 0x180E9DB40
	private static void .cctor() { }

}

