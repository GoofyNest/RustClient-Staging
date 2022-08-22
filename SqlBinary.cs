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

	// RVA: 0x137B50 Offset: 0x136F50 VA: 0x180137B50
	public void .ctor(byte[] value) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x137BE0 Offset: 0x136FE0 VA: 0x180137BE0
	public byte[] get_Value() { }

	// RVA: 0xE9CAD0 Offset: 0xE9B0D0 VA: 0x180E9CAD0
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x137AA0 Offset: 0x136EA0 VA: 0x180137AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE9C670 Offset: 0xE9AC70 VA: 0x180E9C670
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0xE9C910 Offset: 0xE9AF10 VA: 0x180E9C910
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9CB60 Offset: 0xE9B160 VA: 0x180E9CB60
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xE9C9F0 Offset: 0xE9AFF0 VA: 0x180E9C9F0
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x137690 Offset: 0x136A90 VA: 0x180137690 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137680 Offset: 0x136A80 VA: 0x180137680
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x137790 Offset: 0x136B90 VA: 0x180137790 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xE9C600 Offset: 0xE9AC00 VA: 0x180E9C600
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x1377A0 Offset: 0x136BA0 VA: 0x1801377A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x137890 Offset: 0x136C90 VA: 0x180137890 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1379D0 Offset: 0x136DD0 VA: 0x1801379D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9C5A0 Offset: 0xE9ABA0 VA: 0x180E9C5A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9C780 Offset: 0xE9AD80 VA: 0x180E9C780
	private static void .cctor() { }

}

