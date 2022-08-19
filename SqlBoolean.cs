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

	// RVA: 0x138480 Offset: 0x137880 VA: 0x180138480
	public void .ctor(bool value) { }

	// RVA: 0x138470 Offset: 0x137870 VA: 0x180138470
	public void .ctor(int value) { }

	// RVA: 0x138490 Offset: 0x137890 VA: 0x180138490
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x1181D0 Offset: 0x1175D0 VA: 0x1801181D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x138530 Offset: 0x137930 VA: 0x180138530
	public bool get_Value() { }

	// RVA: 0x138520 Offset: 0x137920 VA: 0x180138520
	public bool get_IsTrue() { }

	// RVA: 0x138510 Offset: 0x137910 VA: 0x180138510
	public bool get_IsFalse() { }

	// RVA: 0xE9C850 Offset: 0xE9AE50 VA: 0x180E9C850
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xE9C860 Offset: 0xE9AE60 VA: 0x180E9C860
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xE9C5A0 Offset: 0xE9ABA0 VA: 0x180E9C5A0
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9C6B0 Offset: 0xE9ACB0 VA: 0x180E9C6B0
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1384B0 Offset: 0x1378B0 VA: 0x1801384B0
	public byte get_ByteValue() { }

	// RVA: 0x1383C0 Offset: 0x1377C0 VA: 0x1801383C0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9C7C0 Offset: 0xE9ADC0 VA: 0x180E9C7C0
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9BED0 Offset: 0xE9A4D0 VA: 0x180E9BED0
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9C350 Offset: 0xE9A950 VA: 0x180E9C350
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x137EB0 Offset: 0x1372B0 VA: 0x180137EB0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137FB0 Offset: 0x1373B0 VA: 0x180137FB0
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x137FC0 Offset: 0x1373C0 VA: 0x180137FC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138160 Offset: 0x137560 VA: 0x180138160 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1381F0 Offset: 0x1375F0 VA: 0x1801381F0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138310 Offset: 0x137710 VA: 0x180138310 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9C2F0 Offset: 0xE9A8F0 VA: 0x180E9C2F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9C480 Offset: 0xE9AA80 VA: 0x180E9C480
	private static void .cctor() { }

}

