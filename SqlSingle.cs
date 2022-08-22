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

	// RVA: 0xCC89A0 Offset: 0xCC6FA0 VA: 0x180CC89A0
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x11B110 Offset: 0x11A510 VA: 0x18011B110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9060 Offset: 0xCC7660 VA: 0x180CC9060
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xCC8120 Offset: 0xCC6720 VA: 0x180CC8120
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8F60 Offset: 0xCC7560 VA: 0x180CC8F60
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8E60 Offset: 0xCC7460 VA: 0x180CC8E60
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8220 Offset: 0xCC6820 VA: 0x180CC8220
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8620 Offset: 0xCC6C20 VA: 0x180CC8620
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xCC8B70 Offset: 0xCC7170 VA: 0x180CC8B70
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC8750 Offset: 0xCC6D50 VA: 0x180CC8750
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC8880 Offset: 0xCC6E80 VA: 0x180CC8880
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC8CA0 Offset: 0xCC72A0 VA: 0x180CC8CA0
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xCC8A50 Offset: 0xCC7050 VA: 0x180CC8A50
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC8450 Offset: 0xCC6A50 VA: 0x180CC8450
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xCC8380 Offset: 0xCC6980 VA: 0x180CC8380
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8DB0 Offset: 0xCC73B0 VA: 0x180CC8DB0
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8570 Offset: 0xCC6B70 VA: 0x180CC8570
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC7D80 Offset: 0xCC6380 VA: 0x180CC7D80
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC7D10 Offset: 0xCC6310 VA: 0x180CC7D10
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

	// RVA: 0xCC7CB0 Offset: 0xCC62B0 VA: 0x180CC7CB0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC7F00 Offset: 0xCC6500 VA: 0x180CC7F00
	private static void .cctor() { }

}

