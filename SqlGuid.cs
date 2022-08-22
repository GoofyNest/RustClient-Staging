public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4346
{	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x118800 Offset: 0x117C00 VA: 0x180118800
	private void .ctor(bool fNull) { }

	// RVA: 0x1187C0 Offset: 0x117BC0 VA: 0x1801187C0
	public void .ctor(Guid g) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x118830 Offset: 0x117C30 VA: 0x180118830
	public Guid get_Value() { }

	// RVA: 0xCC20A0 Offset: 0xCC06A0 VA: 0x180CC20A0
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x118780 Offset: 0x117B80 VA: 0x180118780 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC1A50 Offset: 0xCC0050 VA: 0x180CC1A50
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC1F00 Offset: 0xCC0500 VA: 0x180CC1F00
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC20E0 Offset: 0xCC06E0 VA: 0x180CC20E0
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC1FD0 Offset: 0xCC05D0 VA: 0x180CC1FD0
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x118200 Offset: 0x117600 VA: 0x180118200 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1181F0 Offset: 0x1175F0 VA: 0x1801181F0
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x118300 Offset: 0x117700 VA: 0x180118300 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1184C0 Offset: 0x1178C0 VA: 0x1801184C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x118560 Offset: 0x117960 VA: 0x180118560 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118680 Offset: 0x117A80 VA: 0x180118680 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC1D20 Offset: 0xCC0320 VA: 0x180CC1D20
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC1D80 Offset: 0xCC0380 VA: 0x180CC1D80
	private static void .cctor() { }

}

