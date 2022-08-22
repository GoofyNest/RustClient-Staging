public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4337
{	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x118800 Offset: 0x117C00 VA: 0x180118800
	private void .ctor(bool fNull) { }

	// RVA: 0x137D30 Offset: 0x137130 VA: 0x180137D30
	public void .ctor(byte[] value) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x137DC0 Offset: 0x1371C0 VA: 0x180137DC0
	public byte[] get_Value() { }

	// RVA: 0xE9C020 Offset: 0xE9A620 VA: 0x180E9C020
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x137C80 Offset: 0x137080 VA: 0x180137C80 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9BBC0 Offset: 0xE9A1C0 VA: 0x180E9BBC0
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0xE9BE60 Offset: 0xE9A460 VA: 0x180E9BE60
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9C0B0 Offset: 0xE9A6B0 VA: 0x180E9C0B0
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9BF40 Offset: 0xE9A540 VA: 0x180E9BF40
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x137870 Offset: 0x136C70 VA: 0x180137870 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137860 Offset: 0x136C60 VA: 0x180137860
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x137970 Offset: 0x136D70 VA: 0x180137970 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xE9BB50 Offset: 0xE9A150 VA: 0x180E9BB50
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x137980 Offset: 0x136D80 VA: 0x180137980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x137A70 Offset: 0x136E70 VA: 0x180137A70 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x137BB0 Offset: 0x136FB0 VA: 0x180137BB0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9BAF0 Offset: 0xE9A0F0 VA: 0x180E9BAF0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9BCD0 Offset: 0xE9A2D0 VA: 0x180E9BCD0
	private static void .cctor() { }

}

