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

	// RVA: 0xEA3DE0 Offset: 0xEA23E0 VA: 0x180EA3DE0
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1398B0 Offset: 0x138CB0 VA: 0x1801398B0
	public double ToDouble() { }

	// RVA: 0x139890 Offset: 0x138C90 VA: 0x180139890
	private Decimal ToDecimal() { }

	// RVA: 0xEA78D0 Offset: 0xEA5ED0 VA: 0x180EA78D0
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xEA7AB0 Offset: 0xEA60B0 VA: 0x180EA7AB0
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0xEA8DB0 Offset: 0xEA73B0 VA: 0x180EA8DB0
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xEA6570 Offset: 0xEA4B70 VA: 0x180EA6570
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA8AE0 Offset: 0xEA70E0 VA: 0x180EA8AE0
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7D20 Offset: 0xEA6320 VA: 0x180EA7D20
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA6DD0 Offset: 0xEA53D0 VA: 0x180EA6DD0
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA79E0 Offset: 0xEA5FE0 VA: 0x180EA79E0
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xEA7770 Offset: 0xEA5D70 VA: 0x180EA7770
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xEA7820 Offset: 0xEA5E20 VA: 0x180EA7820
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xEA7B00 Offset: 0xEA6100 VA: 0x180EA7B00
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xEA7910 Offset: 0xEA5F10 VA: 0x180EA7910
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xEA53F0 Offset: 0xEA39F0 VA: 0x180EA53F0
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x139340 Offset: 0x138740 VA: 0x180139340
	private bool FZero() { }

	// RVA: 0x1392A0 Offset: 0x1386A0 VA: 0x1801392A0
	private bool FGt10_38() { }

	// RVA: 0x1392E0 Offset: 0x1386E0 VA: 0x1801392E0
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0xEA0FB0 Offset: 0xE9F5B0 VA: 0x180EA0FB0
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0xEA11A0 Offset: 0xE9F7A0 VA: 0x180EA11A0
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

	// RVA: 0xEA38A0 Offset: 0xEA1EA0 VA: 0x180EA38A0
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0xEA3A80 Offset: 0xEA2080 VA: 0x180EA3A80
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0xEA3A30 Offset: 0xEA2030 VA: 0x180EA3A30
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA3910 Offset: 0xEA1F10 VA: 0x180EA3910
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0xEA2750 Offset: 0xEA0D50 VA: 0x180EA2750
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA1D70 Offset: 0xEA0370 VA: 0x180EA1D70
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0xEA2480 Offset: 0xEA0A80 VA: 0x180EA2480
	private static uint HI(ulong x) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	private static uint LO(ulong x) { }

	// RVA: 0xEA2880 Offset: 0xEA0E80 VA: 0x180EA2880
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x139100 Offset: 0x138500 VA: 0x180139100
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xEA1890 Offset: 0xE9FE90 VA: 0x180EA1890
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0xEA74B0 Offset: 0xEA5AB0 VA: 0x180EA74B0
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7BC0 Offset: 0xEA61C0 VA: 0x180EA7BC0
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA7610 Offset: 0xEA5C10 VA: 0x180EA7610
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA26C0 Offset: 0xEA0CC0 VA: 0x180EA26C0
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEA23F0 Offset: 0xEA09F0 VA: 0x180EA23F0
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1398C0 Offset: 0x138CC0 VA: 0x1801398C0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x139950 Offset: 0x138D50 VA: 0x180139950
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1399E0 Offset: 0x138DE0 VA: 0x1801399E0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xEA1880 Offset: 0xE9FE80 VA: 0x180EA1880
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

	// RVA: 0xEA2390 Offset: 0xEA0990 VA: 0x180EA2390
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEA5480 Offset: 0xEA3A80 VA: 0x180EA5480
	private static void .cctor() { }

}

