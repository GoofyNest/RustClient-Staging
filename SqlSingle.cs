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

	// RVA: 0x119910 Offset: 0x118D10 VA: 0x180119910
	private void .ctor(bool fNull) { }

	// RVA: 0x11B1B0 Offset: 0x11A5B0 VA: 0x18011B1B0
	public void .ctor(float value) { }

	// RVA: 0x11B1C0 Offset: 0x11A5C0 VA: 0x18011B1C0
	public void .ctor(double value) { }

	// RVA: 0x1181D0 Offset: 0x1175D0 VA: 0x1801181D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11B1D0 Offset: 0x11A5D0 VA: 0x18011B1D0
	public float get_Value() { }

	// RVA: 0xCC89A0 Offset: 0xCC6FA0 VA: 0x180CC89A0
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x11B190 Offset: 0x11A590 VA: 0x18011B190 Slot: 3
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

	// RVA: 0x11B080 Offset: 0x11A480 VA: 0x18011B080
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11AB50 Offset: 0x119F50 VA: 0x18011AB50 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11AB40 Offset: 0x119F40 VA: 0x18011AB40
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x11AC50 Offset: 0x11A050 VA: 0x18011AC50 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11ADF0 Offset: 0x11A1F0 VA: 0x18011ADF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11AE80 Offset: 0x11A280 VA: 0x18011AE80 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11AFA0 Offset: 0x11A3A0 VA: 0x18011AFA0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC7CB0 Offset: 0xCC62B0 VA: 0x180CC7CB0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC7F00 Offset: 0xCC6500 VA: 0x180CC7F00
	private static void .cctor() { }

}

