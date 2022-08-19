public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4353
{	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x11B5A0 Offset: 0x11A9A0 VA: 0x18011B5A0
	private void .ctor(bool fNull) { }

	// RVA: 0x11B5E0 Offset: 0x11A9E0 VA: 0x18011B5E0
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x11B590 Offset: 0x11A990 VA: 0x18011B590
	public void .ctor(string data) { }

	// RVA: 0x11B5F0 Offset: 0x11A9F0 VA: 0x18011B5F0
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x11B6C0 Offset: 0x11AAC0 VA: 0x18011B6C0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11B6D0 Offset: 0x11AAD0 VA: 0x18011B6D0
	public string get_Value() { }

	// RVA: 0x11B3C0 Offset: 0x11A7C0 VA: 0x18011B3C0
	private void SetCompareInfo() { }

	// RVA: 0xCCAAC0 Offset: 0xCC90C0 VA: 0x180CCAAC0
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x11B570 Offset: 0x11A970 VA: 0x18011B570 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCA7E0 Offset: 0xCC8DE0 VA: 0x180CCA7E0
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xCC9E00 Offset: 0xCC8400 VA: 0x180CC9E00
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xCC9700 Offset: 0xCC7D00 VA: 0x180CC9700
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xCCA960 Offset: 0xCC8F60 VA: 0x180CCA960
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xCCA2D0 Offset: 0xCC88D0 VA: 0x180CCA2D0
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xCC9550 Offset: 0xCC7B50 VA: 0x180CC9550
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x11B390 Offset: 0x11A790 VA: 0x18011B390
	private bool FBinarySort() { }

	// RVA: 0xCC92E0 Offset: 0xCC78E0 VA: 0x180CC92E0
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xCC9170 Offset: 0xCC7770 VA: 0x180CC9170
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x11B230 Offset: 0x11A630 VA: 0x18011B230 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11B350 Offset: 0x11A750 VA: 0x18011B350
	public int CompareTo(SqlString value) { }

	// RVA: 0x11B380 Offset: 0x11A780 VA: 0x18011B380 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11B3B0 Offset: 0x11A7B0 VA: 0x18011B3B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11B3D0 Offset: 0x11A7D0 VA: 0x18011B3D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11B4D0 Offset: 0x11A8D0 VA: 0x18011B4D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC9D00 Offset: 0xCC8300 VA: 0x180CC9D00
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCCA370 Offset: 0xCC8970 VA: 0x180CCA370
	private static void .cctor() { }

}

