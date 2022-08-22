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

	// RVA: 0x138B10 Offset: 0x137F10 VA: 0x180138B10
	private void .ctor(bool fNull) { }

	// RVA: 0x138B20 Offset: 0x137F20 VA: 0x180138B20
	public void .ctor(byte value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x138B30 Offset: 0x137F30 VA: 0x180138B30
	public byte get_Value() { }

	// RVA: 0xE9D2F0 Offset: 0xE9B8F0 VA: 0x180E9D2F0
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x138AC0 Offset: 0x137EC0 VA: 0x180138AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9CEF0 Offset: 0xE9B4F0 VA: 0x180E9CEF0
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D4A0 Offset: 0xE9BAA0 VA: 0x180E9D4A0
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D390 Offset: 0xE9B990 VA: 0x180E9D390
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xE9CFF0 Offset: 0xE9B5F0 VA: 0x180E9CFF0
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D160 Offset: 0xE9B760 VA: 0x180E9D160
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xE9D0D0 Offset: 0xE9B6D0 VA: 0x180E9D0D0
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D300 Offset: 0xE9B900 VA: 0x180E9D300
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9D260 Offset: 0xE9B860 VA: 0x180E9D260
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9CC80 Offset: 0xE9B280 VA: 0x180E9CC80
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xE9CC10 Offset: 0xE9B210 VA: 0x180E9CC10
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1389C0 Offset: 0x137DC0 VA: 0x1801389C0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x138A40 Offset: 0x137E40 VA: 0x180138A40
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1384C0 Offset: 0x1378C0 VA: 0x1801384C0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1385C0 Offset: 0x1379C0 VA: 0x1801385C0
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1385D0 Offset: 0x1379D0 VA: 0x1801385D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138760 Offset: 0x137B60 VA: 0x180138760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1387E0 Offset: 0x137BE0 VA: 0x1801387E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1388F0 Offset: 0x137CF0 VA: 0x1801388F0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9CBB0 Offset: 0xE9B1B0 VA: 0x180E9CBB0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9CDD0 Offset: 0xE9B3D0 VA: 0x180E9CDD0
	private static void .cctor() { }

}

