public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4344
{	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x138F10 Offset: 0x138310 VA: 0x180138F10
	private byte CalculatePrecision() { }

	// RVA: 0x1398A0 Offset: 0x138CA0 VA: 0x1801398A0
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x139910 Offset: 0x138D10 VA: 0x180139910
	private void .ctor(bool fNull) { }

	// RVA: 0x1398D0 Offset: 0x138CD0 VA: 0x1801398D0
	public void .ctor(Decimal value) { }

	// RVA: 0x139900 Offset: 0x138D00 VA: 0x180139900
	public void .ctor(int value) { }

	// RVA: 0x1398F0 Offset: 0x138CF0 VA: 0x1801398F0
	public void .ctor(long value) { }

	// RVA: 0x1398B0 Offset: 0x138CB0 VA: 0x1801398B0
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x139930 Offset: 0x138D30 VA: 0x180139930 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x139A70 Offset: 0x138E70 VA: 0x180139A70
	public Decimal get_Value() { }

	// RVA: 0x1399A0 Offset: 0x138DA0 VA: 0x1801399A0
	public bool get_IsPositive() { }

	// RVA: 0x139340 Offset: 0x138740 VA: 0x180139340
	private void SetPositive() { }

	// RVA: 0x139350 Offset: 0x138750 VA: 0x180139350
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x1399B0 Offset: 0x138DB0 VA: 0x1801399B0
	public byte get_Scale() { }

	// RVA: 0x139920 Offset: 0x138D20 VA: 0x180139920
	public int[] get_Data() { }

	// RVA: 0x139890 Offset: 0x138C90 VA: 0x180139890 Slot: 3
	public override string ToString() { }

	// RVA: 0xEA4890 Offset: 0xEA2E90 VA: 0x180EA4890
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1396D0 Offset: 0x138AD0 VA: 0x1801396D0
	public double ToDouble() { }

	// RVA: 0x1396B0 Offset: 0x138AB0 VA: 0x1801396B0
	private Decimal ToDecimal() { }

	// RVA: 0xEA8380 Offset: 0xEA6980 VA: 0x180EA8380
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xEA8560 Offset: 0xEA6B60 VA: 0x180EA8560
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0xEA9860 Offset: 0xEA7E60 VA: 0x180EA9860
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xEA7020 Offset: 0xEA5620 VA: 0x180EA7020
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA9590 Offset: 0xEA7B90 VA: 0x180EA9590
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA87D0 Offset: 0xEA6DD0 VA: 0x180EA87D0
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7880 Offset: 0xEA5E80 VA: 0x180EA7880
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA8490 Offset: 0xEA6A90 VA: 0x180EA8490
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xEA8220 Offset: 0xEA6820 VA: 0x180EA8220
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xEA82D0 Offset: 0xEA68D0 VA: 0x180EA82D0
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xEA85B0 Offset: 0xEA6BB0 VA: 0x180EA85B0
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xEA83C0 Offset: 0xEA69C0 VA: 0x180EA83C0
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xEA5EA0 Offset: 0xEA44A0 VA: 0x180EA5EA0
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x139160 Offset: 0x138560 VA: 0x180139160
	private bool FZero() { }

	// RVA: 0x1390C0 Offset: 0x1384C0 VA: 0x1801390C0
	private bool FGt10_38() { }

	// RVA: 0x139100 Offset: 0x138500 VA: 0x180139100
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0xEA1A60 Offset: 0xEA0060 VA: 0x180EA1A60
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0xEA1C50 Offset: 0xEA0250 VA: 0x180EA1C50
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x138EF0 Offset: 0x1382F0 VA: 0x180138EF0
	private void AddULong(uint ulAdd) { }

	// RVA: 0x139330 Offset: 0x138730 VA: 0x180139330
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x1390A0 Offset: 0x1384A0 VA: 0x1801390A0
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x138F00 Offset: 0x138300 VA: 0x180138F00
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x139300 Offset: 0x138700 VA: 0x180139300
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xEA4350 Offset: 0xEA2950 VA: 0x180EA4350
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0xEA4530 Offset: 0xEA2B30 VA: 0x180EA4530
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0xEA44E0 Offset: 0xEA2AE0 VA: 0x180EA44E0
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA43C0 Offset: 0xEA29C0 VA: 0x180EA43C0
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0xEA3200 Offset: 0xEA1800 VA: 0x180EA3200
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA2820 Offset: 0xEA0E20 VA: 0x180EA2820
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0xEA2F30 Offset: 0xEA1530 VA: 0x180EA2F30
	private static uint HI(ulong x) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	private static uint LO(ulong x) { }

	// RVA: 0xEA3330 Offset: 0xEA1930 VA: 0x180EA3330
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x138F20 Offset: 0x138320 VA: 0x180138F20
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xEA2340 Offset: 0xEA0940 VA: 0x180EA2340
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0xEA7F60 Offset: 0xEA6560 VA: 0x180EA7F60
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA8670 Offset: 0xEA6C70 VA: 0x180EA8670
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA80C0 Offset: 0xEA66C0 VA: 0x180EA80C0
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA3170 Offset: 0xEA1770 VA: 0x180EA3170
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA2EA0 Offset: 0xEA14A0 VA: 0x180EA2EA0
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1396E0 Offset: 0x138AE0 VA: 0x1801396E0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x139770 Offset: 0x138B70 VA: 0x180139770
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x139800 Offset: 0x138C00 VA: 0x180139800
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xEA2330 Offset: 0xEA0930 VA: 0x180EA2330
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x139370 Offset: 0x138770 VA: 0x180139370
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x139360 Offset: 0x138760 VA: 0x180139360
	private void SetToZero() { }

	// RVA: 0x138F50 Offset: 0x138350 VA: 0x180138F50 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x139070 Offset: 0x138470 VA: 0x180139070
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x1390B0 Offset: 0x1384B0 VA: 0x1801390B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x139180 Offset: 0x138580 VA: 0x180139180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x139400 Offset: 0x138800 VA: 0x180139400 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1395A0 Offset: 0x1389A0 VA: 0x1801395A0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEA2E40 Offset: 0xEA1440 VA: 0x180EA2E40
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEA5F30 Offset: 0xEA4530 VA: 0x180EA5F30
	private static void .cctor() { }

}

