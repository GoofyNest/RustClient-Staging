internal sealed class NumberFormatter // TypeDefIndex: 381
{	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x167AE90 Offset: 0x1679490 VA: 0x18167AE90
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x167D630 Offset: 0x167BC30 VA: 0x18167D630
	private static void .cctor() { }

	// RVA: 0x167B0D0 Offset: 0x16796D0 VA: 0x18167B0D0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x167B480 Offset: 0x1679A80 VA: 0x18167B480
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x167B340 Offset: 0x1679940 VA: 0x18167B340
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x167B140 Offset: 0x1679740 VA: 0x18167B140
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x1679300 Offset: 0x1677900 VA: 0x181679300
	private static uint FastToDecHex(int val) { }

	// RVA: 0x167D4E0 Offset: 0x167BAE0 VA: 0x18167D4E0
	private static uint ToDecHex(int val) { }

	// RVA: 0x16792D0 Offset: 0x16778D0 VA: 0x1816792D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x1679200 Offset: 0x1677800 VA: 0x181679200
	private static int DecHexLen(uint val) { }

	// RVA: 0x16790D0 Offset: 0x16776D0 VA: 0x1816790D0
	private int DecHexLen() { }

	// RVA: 0x167D460 Offset: 0x167BA60 VA: 0x18167D460
	private static int ScaleOrder(long hi) { }

	// RVA: 0x167BFF0 Offset: 0x167A5F0 VA: 0x18167BFF0
	private int InitialFloatingPrecision() { }

	// RVA: 0x167CEB0 Offset: 0x167B4B0 VA: 0x18167CEB0
	private static int ParsePrecision(string format) { }

	// RVA: 0x167D690 Offset: 0x167BC90 VA: 0x18167D690
	private void .ctor(Thread current) { }

	// RVA: 0x167BD00 Offset: 0x167A300 VA: 0x18167BD00
	private void Init(string format) { }

	// RVA: 0x167B5D0 Offset: 0x1679BD0 VA: 0x18167B5D0
	private void InitHex(ulong value) { }

	// RVA: 0x167B6B0 Offset: 0x1679CB0 VA: 0x18167B6B0
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x167B760 Offset: 0x1679D60 VA: 0x18167B760
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x167B800 Offset: 0x1679E00 VA: 0x18167B800
	private void Init(string format, long value) { }

	// RVA: 0x167B620 Offset: 0x1679C20 VA: 0x18167B620
	private void Init(string format, ulong value) { }

	// RVA: 0x167B8A0 Offset: 0x1679EA0 VA: 0x18167B8A0
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x167BE40 Offset: 0x167A440 VA: 0x18167BE40
	private void Init(string format, Decimal value) { }

	// RVA: 0x167D000 Offset: 0x167B600 VA: 0x18167D000
	private void ResetCharBuf(int size) { }

	// RVA: 0x167D070 Offset: 0x167B670 VA: 0x18167D070
	private void Resize(int len) { }

	// RVA: 0x1678CA0 Offset: 0x16772A0 VA: 0x181678CA0
	private void Append(char c) { }

	// RVA: 0x1678BC0 Offset: 0x16771C0 VA: 0x181678BC0
	private void Append(char c, int cnt) { }

	// RVA: 0x1678D50 Offset: 0x1677350 VA: 0x181678D50
	private void Append(string s) { }

	// RVA: 0x167B0B0 Offset: 0x16796B0 VA: 0x18167B0B0
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x167D7C0 Offset: 0x167BDC0 VA: 0x18167D7C0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x167D770 Offset: 0x167BD70 VA: 0x18167D770
	private int get_IntegerDigits() { }

	// RVA: 0x167D760 Offset: 0x167BD60 VA: 0x18167D760
	private int get_DecimalDigits() { }

	// RVA: 0x167D780 Offset: 0x167BD80 VA: 0x18167D780
	private bool get_IsFloatingSource() { }

	// RVA: 0x5DE2C0 Offset: 0x5DC8C0 VA: 0x1805DE2C0
	private bool get_IsZero() { }

	// RVA: 0x167D7A0 Offset: 0x167BDA0 VA: 0x18167D7A0
	private bool get_IsZeroInteger() { }

	// RVA: 0x167D450 Offset: 0x167BA50 VA: 0x18167D450
	private void RoundPos(int pos) { }

	// RVA: 0x167D430 Offset: 0x167BA30 VA: 0x18167D430
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x167D0C0 Offset: 0x167B6C0 VA: 0x18167D0C0
	private bool RoundBits(int shift) { }

	// RVA: 0x167CFD0 Offset: 0x167B5D0 VA: 0x18167CFD0
	private void RemoveTrailingZeros() { }

	// RVA: 0x1677C70 Offset: 0x1676270 VA: 0x181677C70
	private void AddOneToDecHex() { }

	// RVA: 0x1677BF0 Offset: 0x16761F0 VA: 0x181677BF0
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x1678E90 Offset: 0x1677490 VA: 0x181678E90
	private int CountTrailingZeros() { }

	// RVA: 0x1678E40 Offset: 0x1677440 VA: 0x181678E40
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x167AEA0 Offset: 0x16794A0 VA: 0x18167AEA0
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x167CF30 Offset: 0x167B530 VA: 0x18167CF30
	private void Release() { }

	// RVA: 0x167CB30 Offset: 0x167B130 VA: 0x18167CB30
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x167CC50 Offset: 0x167B250 VA: 0x18167CC50
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x167C930 Offset: 0x167AF30 VA: 0x18167C930
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x167CD80 Offset: 0x167B380 VA: 0x18167CD80
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x167C3A0 Offset: 0x167A9A0 VA: 0x18167C3A0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x167C570 Offset: 0x167AB70 VA: 0x18167C570
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x167CA50 Offset: 0x167B050 VA: 0x18167CA50
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x167C0C0 Offset: 0x167A6C0 VA: 0x18167C0C0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x167C790 Offset: 0x167AD90 VA: 0x18167C790
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x16793D0 Offset: 0x16779D0 VA: 0x1816793D0
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1679F80 Offset: 0x1678580 VA: 0x181679F80
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167A6B0 Offset: 0x1678CB0 VA: 0x18167A6B0
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x167A3B0 Offset: 0x16789B0 VA: 0x18167A3B0
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167AC30 Offset: 0x1679230 VA: 0x18167AC30
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x167AD60 Offset: 0x1679360 VA: 0x18167AD60
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x167A540 Offset: 0x1678B40 VA: 0x18167A540
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167A860 Offset: 0x1678E60 VA: 0x18167A860
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167AA50 Offset: 0x1679050 VA: 0x18167AA50
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167A350 Offset: 0x1678950 VA: 0x18167A350
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167A040 Offset: 0x1678640 VA: 0x18167A040
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x16797A0 Offset: 0x1677DA0 VA: 0x1816797A0
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167D590 Offset: 0x167BB90 VA: 0x18167D590
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x167C2C0 Offset: 0x167A8C0 VA: 0x18167C2C0
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x1678910 Offset: 0x1676F10 VA: 0x181678910
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x1678820 Offset: 0x1676E20 VA: 0x181678820
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x16788B0 Offset: 0x1676EB0 VA: 0x1816788B0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x1677DA0 Offset: 0x16763A0 VA: 0x181677DA0
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x1677DD0 Offset: 0x16763D0 VA: 0x181677DD0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x16784D0 Offset: 0x1676AD0 VA: 0x1816784D0
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x1678370 Offset: 0x1676970 VA: 0x181678370
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x1678AD0 Offset: 0x16770D0 VA: 0x181678AD0
	private void AppendOneDigit(int start) { }

	// RVA: 0x1678030 Offset: 0x1676630 VA: 0x181678030
	private void AppendDigits(int start, int end) { }

	// RVA: 0x1677DF0 Offset: 0x16763F0 VA: 0x181677DF0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x167C390 Offset: 0x167A990 VA: 0x18167C390
	private void Multiply10(int count) { }

	// RVA: 0x16792C0 Offset: 0x16778C0 VA: 0x1816792C0
	private void Divide10(int count) { }

	// RVA: 0x167AE30 Offset: 0x1679430 VA: 0x18167AE30
	private NumberFormatter GetClone() { }

}

private class NumberFormatter.CustomInfo // TypeDefIndex: 382
{	// Fields
	public bool UseGroup; // 0x10
	public int DecimalDigits; // 0x14
	public int DecimalPointPos; // 0x18
	public int DecimalTailSharpDigits; // 0x1C
	public int IntegerDigits; // 0x20
	public int IntegerHeadSharpDigits; // 0x24
	public int IntegerHeadPos; // 0x28
	public bool UseExponent; // 0x2C
	public int ExponentDigits; // 0x30
	public int ExponentTailSharpDigits; // 0x34
	public bool ExponentNegativeSignOnly; // 0x38
	public int DividePlaces; // 0x3C
	public int Percents; // 0x40
	public int Permilles; // 0x44

	// Methods

	// RVA: 0x166F500 Offset: 0x166DB00 VA: 0x18166F500
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x166F910 Offset: 0x166DF10 VA: 0x18166F910
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x166ED50 Offset: 0x166D350 VA: 0x18166ED50
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x166FC80 Offset: 0x166E280 VA: 0x18166FC80
	public void .ctor() { }

}

