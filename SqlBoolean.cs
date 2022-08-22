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

	// RVA: 0x138220 Offset: 0x137620 VA: 0x180138220
	public void .ctor(bool value) { }

	// RVA: 0x138210 Offset: 0x137610 VA: 0x180138210
	public void .ctor(int value) { }

	// RVA: 0x138230 Offset: 0x137630 VA: 0x180138230
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1382D0 Offset: 0x1376D0 VA: 0x1801382D0
	public bool get_Value() { }

	// RVA: 0x1382C0 Offset: 0x1376C0 VA: 0x1801382C0
	public bool get_IsTrue() { }

	// RVA: 0x1382B0 Offset: 0x1376B0 VA: 0x1801382B0
	public bool get_IsFalse() { }

	// RVA: 0xE9D5C0 Offset: 0xE9BBC0 VA: 0x180E9D5C0
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xE9D5D0 Offset: 0xE9BBD0 VA: 0x180E9D5D0
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xE9D310 Offset: 0xE9B910 VA: 0x180E9D310
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9D420 Offset: 0xE9BA20 VA: 0x180E9D420
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x138250 Offset: 0x137650 VA: 0x180138250
	public byte get_ByteValue() { }

	// RVA: 0x138160 Offset: 0x137560 VA: 0x180138160 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9D530 Offset: 0xE9BB30 VA: 0x180E9D530
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9CC40 Offset: 0xE9B240 VA: 0x180E9CC40
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xE9D0C0 Offset: 0xE9B6C0 VA: 0x180E9D0C0
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x137C50 Offset: 0x137050 VA: 0x180137C50 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137D50 Offset: 0x137150 VA: 0x180137D50
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x137D60 Offset: 0x137160 VA: 0x180137D60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x137F00 Offset: 0x137300 VA: 0x180137F00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x137F90 Offset: 0x137390 VA: 0x180137F90 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1380B0 Offset: 0x1374B0 VA: 0x1801380B0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9D060 Offset: 0xE9B660 VA: 0x180E9D060
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9D1F0 Offset: 0xE9B7F0 VA: 0x180E9D1F0
	private static void .cctor() { }

}

