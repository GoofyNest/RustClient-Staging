public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4337
{	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x118880 Offset: 0x117C80 VA: 0x180118880
	private void .ctor(bool fNull) { }

	// RVA: 0x137DB0 Offset: 0x1371B0 VA: 0x180137DB0
	public void .ctor(byte[] value) { }

	// RVA: 0x1188A0 Offset: 0x117CA0 VA: 0x1801188A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x137E40 Offset: 0x137240 VA: 0x180137E40
	public byte[] get_Value() { }

	// RVA: 0xE9BD60 Offset: 0xE9A360 VA: 0x180E9BD60
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x137D00 Offset: 0x137100 VA: 0x180137D00 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9B900 Offset: 0xE99F00 VA: 0x180E9B900
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0xE9BBA0 Offset: 0xE9A1A0 VA: 0x180E9BBA0
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9BDF0 Offset: 0xE9A3F0 VA: 0x180E9BDF0
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9BC80 Offset: 0xE9A280 VA: 0x180E9BC80
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1378F0 Offset: 0x136CF0 VA: 0x1801378F0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1378E0 Offset: 0x136CE0 VA: 0x1801378E0
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1379F0 Offset: 0x136DF0 VA: 0x1801379F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xE9B890 Offset: 0xE99E90 VA: 0x180E9B890
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x137A00 Offset: 0x136E00 VA: 0x180137A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x137AF0 Offset: 0x136EF0 VA: 0x180137AF0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x137C30 Offset: 0x137030 VA: 0x180137C30 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9B830 Offset: 0xE99E30 VA: 0x180E9B830
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9BA10 Offset: 0xE9A010 VA: 0x180E9BA10
	private static void .cctor() { }

}

