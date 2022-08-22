public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4351
{	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x119890 Offset: 0x118C90 VA: 0x180119890
	private void .ctor(bool fNull) { }

	// RVA: 0x11B130 Offset: 0x11A530 VA: 0x18011B130
	public void .ctor(float value) { }

	// RVA: 0x11B140 Offset: 0x11A540 VA: 0x18011B140
	public void .ctor(double value) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11B150 Offset: 0x11A550 VA: 0x18011B150
	public float get_Value() { }

	// RVA: 0xCC8C60 Offset: 0xCC7260 VA: 0x180CC8C60
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x11B110 Offset: 0x11A510 VA: 0x18011B110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9320 Offset: 0xCC7920 VA: 0x180CC9320
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xCC83E0 Offset: 0xCC69E0 VA: 0x180CC83E0
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC9220 Offset: 0xCC7820 VA: 0x180CC9220
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC9120 Offset: 0xCC7720 VA: 0x180CC9120
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC84E0 Offset: 0xCC6AE0 VA: 0x180CC84E0
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC88E0 Offset: 0xCC6EE0 VA: 0x180CC88E0
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xCC8E30 Offset: 0xCC7430 VA: 0x180CC8E30
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC8A10 Offset: 0xCC7010 VA: 0x180CC8A10
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC8B40 Offset: 0xCC7140 VA: 0x180CC8B40
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC8F60 Offset: 0xCC7560 VA: 0x180CC8F60
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xCC8D10 Offset: 0xCC7310 VA: 0x180CC8D10
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC8710 Offset: 0xCC6D10 VA: 0x180CC8710
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xCC8640 Offset: 0xCC6C40 VA: 0x180CC8640
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC9070 Offset: 0xCC7670 VA: 0x180CC9070
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8830 Offset: 0xCC6E30 VA: 0x180CC8830
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8040 Offset: 0xCC6640 VA: 0x180CC8040
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC7FD0 Offset: 0xCC65D0 VA: 0x180CC7FD0
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x11B000 Offset: 0x11A400 VA: 0x18011B000
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11AAD0 Offset: 0x119ED0 VA: 0x18011AAD0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11AAC0 Offset: 0x119EC0 VA: 0x18011AAC0
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x11ABD0 Offset: 0x119FD0 VA: 0x18011ABD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11AD70 Offset: 0x11A170 VA: 0x18011AD70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11AE00 Offset: 0x11A200 VA: 0x18011AE00 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11AF20 Offset: 0x11A320 VA: 0x18011AF20 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC7F70 Offset: 0xCC6570 VA: 0x180CC7F70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC81C0 Offset: 0xCC67C0 VA: 0x180CC81C0
	private static void .cctor() { }

}

