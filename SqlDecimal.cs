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

	// RVA: 0x1390F0 Offset: 0x1384F0 VA: 0x1801390F0
	private byte CalculatePrecision() { }

	// RVA: 0x139A80 Offset: 0x138E80 VA: 0x180139A80
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x139AF0 Offset: 0x138EF0 VA: 0x180139AF0
	private void .ctor(bool fNull) { }

	// RVA: 0x139AB0 Offset: 0x138EB0 VA: 0x180139AB0
	public void .ctor(Decimal value) { }

	// RVA: 0x139AE0 Offset: 0x138EE0 VA: 0x180139AE0
	public void .ctor(int value) { }

	// RVA: 0x139AD0 Offset: 0x138ED0 VA: 0x180139AD0
	public void .ctor(long value) { }

	// RVA: 0x139A90 Offset: 0x138E90 VA: 0x180139A90
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x139B10 Offset: 0x138F10 VA: 0x180139B10 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x139C50 Offset: 0x139050 VA: 0x180139C50
	public Decimal get_Value() { }

	// RVA: 0x139B80 Offset: 0x138F80 VA: 0x180139B80
	public bool get_IsPositive() { }

	// RVA: 0x139520 Offset: 0x138920 VA: 0x180139520
	private void SetPositive() { }

	// RVA: 0x139530 Offset: 0x138930 VA: 0x180139530
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x139B90 Offset: 0x138F90 VA: 0x180139B90
	public byte get_Scale() { }

	// RVA: 0x139B00 Offset: 0x138F00 VA: 0x180139B00
	public int[] get_Data() { }

	// RVA: 0x139A70 Offset: 0x138E70 VA: 0x180139A70 Slot: 3
	public override string ToString() { }

	// RVA: 0xEA3B20 Offset: 0xEA2120 VA: 0x180EA3B20
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1398B0 Offset: 0x138CB0 VA: 0x1801398B0
	public double ToDouble() { }

	// RVA: 0x139890 Offset: 0x138C90 VA: 0x180139890
	private Decimal ToDecimal() { }

	// RVA: 0xEA7610 Offset: 0xEA5C10 VA: 0x180EA7610
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xEA77F0 Offset: 0xEA5DF0 VA: 0x180EA77F0
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0xEA8AF0 Offset: 0xEA70F0 VA: 0x180EA8AF0
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xEA62B0 Offset: 0xEA48B0 VA: 0x180EA62B0
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA8820 Offset: 0xEA6E20 VA: 0x180EA8820
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7A60 Offset: 0xEA6060 VA: 0x180EA7A60
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA6B10 Offset: 0xEA5110 VA: 0x180EA6B10
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7720 Offset: 0xEA5D20 VA: 0x180EA7720
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xEA74B0 Offset: 0xEA5AB0 VA: 0x180EA74B0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xEA7560 Offset: 0xEA5B60 VA: 0x180EA7560
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xEA7840 Offset: 0xEA5E40 VA: 0x180EA7840
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xEA7650 Offset: 0xEA5C50 VA: 0x180EA7650
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xEA5130 Offset: 0xEA3730 VA: 0x180EA5130
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x139340 Offset: 0x138740 VA: 0x180139340
	private bool FZero() { }

	// RVA: 0x1392A0 Offset: 0x1386A0 VA: 0x1801392A0
	private bool FGt10_38() { }

	// RVA: 0x1392E0 Offset: 0x1386E0 VA: 0x1801392E0
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0xEA0CF0 Offset: 0xE9F2F0 VA: 0x180EA0CF0
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0xEA0EE0 Offset: 0xE9F4E0 VA: 0x180EA0EE0
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x1390D0 Offset: 0x1384D0 VA: 0x1801390D0
	private void AddULong(uint ulAdd) { }

	// RVA: 0x139510 Offset: 0x138910 VA: 0x180139510
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x139280 Offset: 0x138680 VA: 0x180139280
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x1390E0 Offset: 0x1384E0 VA: 0x1801390E0
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x1394E0 Offset: 0x1388E0 VA: 0x1801394E0
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xEA35E0 Offset: 0xEA1BE0 VA: 0x180EA35E0
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0xEA37C0 Offset: 0xEA1DC0 VA: 0x180EA37C0
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0xEA3770 Offset: 0xEA1D70 VA: 0x180EA3770
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA3650 Offset: 0xEA1C50 VA: 0x180EA3650
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0xEA2490 Offset: 0xEA0A90 VA: 0x180EA2490
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA1AB0 Offset: 0xEA00B0 VA: 0x180EA1AB0
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0xEA21C0 Offset: 0xEA07C0 VA: 0x180EA21C0
	private static uint HI(ulong x) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	private static uint LO(ulong x) { }

	// RVA: 0xEA25C0 Offset: 0xEA0BC0 VA: 0x180EA25C0
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x139100 Offset: 0x138500 VA: 0x180139100
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xEA15D0 Offset: 0xE9FBD0 VA: 0x180EA15D0
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0xEA71F0 Offset: 0xEA57F0 VA: 0x180EA71F0
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7900 Offset: 0xEA5F00 VA: 0x180EA7900
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7350 Offset: 0xEA5950 VA: 0x180EA7350
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA2400 Offset: 0xEA0A00 VA: 0x180EA2400
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA2130 Offset: 0xEA0730 VA: 0x180EA2130
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1398C0 Offset: 0x138CC0 VA: 0x1801398C0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x139950 Offset: 0x138D50 VA: 0x180139950
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1399E0 Offset: 0x138DE0 VA: 0x1801399E0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xEA15C0 Offset: 0xE9FBC0 VA: 0x180EA15C0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x139550 Offset: 0x138950 VA: 0x180139550
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x139540 Offset: 0x138940 VA: 0x180139540
	private void SetToZero() { }

	// RVA: 0x139130 Offset: 0x138530 VA: 0x180139130 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x139250 Offset: 0x138650 VA: 0x180139250
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x139290 Offset: 0x138690 VA: 0x180139290 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x139360 Offset: 0x138760 VA: 0x180139360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1395E0 Offset: 0x1389E0 VA: 0x1801395E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x139780 Offset: 0x138B80 VA: 0x180139780 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEA20D0 Offset: 0xEA06D0 VA: 0x180EA20D0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEA51C0 Offset: 0xEA37C0 VA: 0x180EA51C0
	private static void .cctor() { }

}

