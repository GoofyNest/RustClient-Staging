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

	// RVA: 0xCC9100 Offset: 0xCC7700 VA: 0x180CC9100
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x11B110 Offset: 0x11A510 VA: 0x18011B110 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC97C0 Offset: 0xCC7DC0 VA: 0x180CC97C0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xCC8880 Offset: 0xCC6E80 VA: 0x180CC8880
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC96C0 Offset: 0xCC7CC0 VA: 0x180CC96C0
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC95C0 Offset: 0xCC7BC0 VA: 0x180CC95C0
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8980 Offset: 0xCC6F80 VA: 0x180CC8980
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8D80 Offset: 0xCC7380 VA: 0x180CC8D80
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xCC92D0 Offset: 0xCC78D0 VA: 0x180CC92D0
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC8EB0 Offset: 0xCC74B0 VA: 0x180CC8EB0
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC8FE0 Offset: 0xCC75E0 VA: 0x180CC8FE0
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC9400 Offset: 0xCC7A00 VA: 0x180CC9400
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xCC91B0 Offset: 0xCC77B0 VA: 0x180CC91B0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC8BB0 Offset: 0xCC71B0 VA: 0x180CC8BB0
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xCC8AE0 Offset: 0xCC70E0 VA: 0x180CC8AE0
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC9510 Offset: 0xCC7B10 VA: 0x180CC9510
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8CD0 Offset: 0xCC72D0 VA: 0x180CC8CD0
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC84E0 Offset: 0xCC6AE0 VA: 0x180CC84E0
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC8470 Offset: 0xCC6A70 VA: 0x180CC8470
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

	// RVA: 0xCC8410 Offset: 0xCC6A10 VA: 0x180CC8410
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC8660 Offset: 0xCC6C60 VA: 0x180CC8660
	private static void .cctor() { }

}

