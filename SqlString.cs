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

	// RVA: 0x11B520 Offset: 0x11A920 VA: 0x18011B520
	private void .ctor(bool fNull) { }

	// RVA: 0x11B560 Offset: 0x11A960 VA: 0x18011B560
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x11B510 Offset: 0x11A910 VA: 0x18011B510
	public void .ctor(string data) { }

	// RVA: 0x11B570 Offset: 0x11A970 VA: 0x18011B570
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x11B640 Offset: 0x11AA40 VA: 0x18011B640 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11B650 Offset: 0x11AA50 VA: 0x18011B650
	public string get_Value() { }

	// RVA: 0x11B340 Offset: 0x11A740 VA: 0x18011B340
	private void SetCompareInfo() { }

	// RVA: 0xCCAD80 Offset: 0xCC9380 VA: 0x180CCAD80
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x11B4F0 Offset: 0x11A8F0 VA: 0x18011B4F0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCAAA0 Offset: 0xCC90A0 VA: 0x180CCAAA0
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xCCA0C0 Offset: 0xCC86C0 VA: 0x180CCA0C0
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xCC99C0 Offset: 0xCC7FC0 VA: 0x180CC99C0
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xCCAC20 Offset: 0xCC9220 VA: 0x180CCAC20
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xCCA590 Offset: 0xCC8B90 VA: 0x180CCA590
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xCC9810 Offset: 0xCC7E10 VA: 0x180CC9810
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x11B310 Offset: 0x11A710 VA: 0x18011B310
	private bool FBinarySort() { }

	// RVA: 0xCC95A0 Offset: 0xCC7BA0 VA: 0x180CC95A0
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xCC9430 Offset: 0xCC7A30 VA: 0x180CC9430
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x11B1B0 Offset: 0x11A5B0 VA: 0x18011B1B0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11B2D0 Offset: 0x11A6D0 VA: 0x18011B2D0
	public int CompareTo(SqlString value) { }

	// RVA: 0x11B300 Offset: 0x11A700 VA: 0x18011B300 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11B330 Offset: 0x11A730 VA: 0x18011B330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11B350 Offset: 0x11A750 VA: 0x18011B350 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11B450 Offset: 0x11A850 VA: 0x18011B450 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC9FC0 Offset: 0xCC85C0 VA: 0x180CC9FC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCCA630 Offset: 0xCC8C30 VA: 0x180CCA630
	private static void .cctor() { }

}

