public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4338
{	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x138400 Offset: 0x137800 VA: 0x180138400
	public void .ctor(bool value) { }

	// RVA: 0x1383F0 Offset: 0x1377F0 VA: 0x1801383F0
	public void .ctor(int value) { }

	// RVA: 0x138410 Offset: 0x137810 VA: 0x180138410
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1384B0 Offset: 0x1378B0 VA: 0x1801384B0
	public bool get_Value() { }

	// RVA: 0x1384A0 Offset: 0x1378A0 VA: 0x1801384A0
	public bool get_IsTrue() { }

	// RVA: 0x138490 Offset: 0x137890 VA: 0x180138490
	public bool get_IsFalse() { }

	// RVA: 0xE9CB10 Offset: 0xE9B110 VA: 0x180E9CB10
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xE9CB20 Offset: 0xE9B120 VA: 0x180E9CB20
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xE9C860 Offset: 0xE9AE60 VA: 0x180E9C860
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9C970 Offset: 0xE9AF70 VA: 0x180E9C970
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x138430 Offset: 0x137830 VA: 0x180138430
	public byte get_ByteValue() { }

	// RVA: 0x138340 Offset: 0x137740 VA: 0x180138340 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9CA80 Offset: 0xE9B080 VA: 0x180E9CA80
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9C190 Offset: 0xE9A790 VA: 0x180E9C190
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9C610 Offset: 0xE9AC10 VA: 0x180E9C610
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x137E30 Offset: 0x137230 VA: 0x180137E30 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137F30 Offset: 0x137330 VA: 0x180137F30
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x137F40 Offset: 0x137340 VA: 0x180137F40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1380E0 Offset: 0x1374E0 VA: 0x1801380E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138170 Offset: 0x137570 VA: 0x180138170 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138290 Offset: 0x137690 VA: 0x180138290 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9C5B0 Offset: 0xE9ABB0 VA: 0x180E9C5B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9C740 Offset: 0xE9AD40 VA: 0x180E9C740
	private static void .cctor() { }

}

