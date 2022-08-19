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

	// RVA: 0x118880 Offset: 0x117C80 VA: 0x180118880
	private void .ctor(bool fNull) { }

	// RVA: 0x118840 Offset: 0x117C40 VA: 0x180118840
	public void .ctor(Guid g) { }

	// RVA: 0x1188A0 Offset: 0x117CA0 VA: 0x1801188A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1188B0 Offset: 0x117CB0 VA: 0x1801188B0
	public Guid get_Value() { }

	// RVA: 0xCC1DE0 Offset: 0xCC03E0 VA: 0x180CC1DE0
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x118800 Offset: 0x117C00 VA: 0x180118800 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC1790 Offset: 0xCBFD90 VA: 0x180CC1790
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC1C40 Offset: 0xCC0240 VA: 0x180CC1C40
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC1E20 Offset: 0xCC0420 VA: 0x180CC1E20
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCC1D10 Offset: 0xCC0310 VA: 0x180CC1D10
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x118280 Offset: 0x117680 VA: 0x180118280 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x118270 Offset: 0x117670 VA: 0x180118270
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x118380 Offset: 0x117780 VA: 0x180118380 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x118540 Offset: 0x117940 VA: 0x180118540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1185E0 Offset: 0x1179E0 VA: 0x1801185E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118700 Offset: 0x117B00 VA: 0x180118700 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC1A60 Offset: 0xCC0060 VA: 0x180CC1A60
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC1AC0 Offset: 0xCC00C0 VA: 0x180CC1AC0
	private static void .cctor() { }

}

