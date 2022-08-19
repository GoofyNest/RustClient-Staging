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
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x167CFE0 Offset: 0x167B5E0 VA: 0x18167CFE0
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x167F780 Offset: 0x167DD80 VA: 0x18167F780
	private static void .cctor() { }

	// RVA: 0x167D220 Offset: 0x167B820 VA: 0x18167D220
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x167D5D0 Offset: 0x167BBD0 VA: 0x18167D5D0
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x167D490 Offset: 0x167BA90 VA: 0x18167D490
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x167D290 Offset: 0x167B890 VA: 0x18167D290
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x167B450 Offset: 0x1679A50 VA: 0x18167B450
	private static uint FastToDecHex(int val) { }

	// RVA: 0x167F630 Offset: 0x167DC30 VA: 0x18167F630
	private static uint ToDecHex(int val) { }

	// RVA: 0x167B420 Offset: 0x1679A20 VA: 0x18167B420
	private static int FastDecHexLen(int val) { }

	// RVA: 0x167B350 Offset: 0x1679950 VA: 0x18167B350
	private static int DecHexLen(uint val) { }

	// RVA: 0x167B220 Offset: 0x1679820 VA: 0x18167B220
	private int DecHexLen() { }

	// RVA: 0x167F5B0 Offset: 0x167DBB0 VA: 0x18167F5B0
	private static int ScaleOrder(long hi) { }

	// RVA: 0x167E140 Offset: 0x167C740 VA: 0x18167E140
	private int InitialFloatingPrecision() { }

	// RVA: 0x167F000 Offset: 0x167D600 VA: 0x18167F000
	private static int ParsePrecision(string format) { }

	// RVA: 0x167F7E0 Offset: 0x167DDE0 VA: 0x18167F7E0
	private void .ctor(Thread current) { }

	// RVA: 0x167DE50 Offset: 0x167C450 VA: 0x18167DE50
	private void Init(string format) { }

	// RVA: 0x167D720 Offset: 0x167BD20 VA: 0x18167D720
	private void InitHex(ulong value) { }

	// RVA: 0x167D800 Offset: 0x167BE00 VA: 0x18167D800
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x167D8B0 Offset: 0x167BEB0 VA: 0x18167D8B0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x167D950 Offset: 0x167BF50 VA: 0x18167D950
	private void Init(string format, long value) { }

	// RVA: 0x167D770 Offset: 0x167BD70 VA: 0x18167D770
	private void Init(string format, ulong value) { }

	// RVA: 0x167D9F0 Offset: 0x167BFF0 VA: 0x18167D9F0
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x167DF90 Offset: 0x167C590 VA: 0x18167DF90
	private void Init(string format, Decimal value) { }

	// RVA: 0x167F150 Offset: 0x167D750 VA: 0x18167F150
	private void ResetCharBuf(int size) { }

	// RVA: 0x167F1C0 Offset: 0x167D7C0 VA: 0x18167F1C0
	private void Resize(int len) { }

	// RVA: 0x167ADF0 Offset: 0x16793F0 VA: 0x18167ADF0
	private void Append(char c) { }

	// RVA: 0x167AD10 Offset: 0x1679310 VA: 0x18167AD10
	private void Append(char c, int cnt) { }

	// RVA: 0x167AEA0 Offset: 0x16794A0 VA: 0x18167AEA0
	private void Append(string s) { }

	// RVA: 0x167D200 Offset: 0x167B800 VA: 0x18167D200
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x167F910 Offset: 0x167DF10 VA: 0x18167F910
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x167F8C0 Offset: 0x167DEC0 VA: 0x18167F8C0
	private int get_IntegerDigits() { }

	// RVA: 0x167F8B0 Offset: 0x167DEB0 VA: 0x18167F8B0
	private int get_DecimalDigits() { }

	// RVA: 0x167F8D0 Offset: 0x167DED0 VA: 0x18167F8D0
	private bool get_IsFloatingSource() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330
	private bool get_IsZero() { }

	// RVA: 0x167F8F0 Offset: 0x167DEF0 VA: 0x18167F8F0
	private bool get_IsZeroInteger() { }

	// RVA: 0x167F5A0 Offset: 0x167DBA0 VA: 0x18167F5A0
	private void RoundPos(int pos) { }

	// RVA: 0x167F580 Offset: 0x167DB80 VA: 0x18167F580
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x167F210 Offset: 0x167D810 VA: 0x18167F210
	private bool RoundBits(int shift) { }

	// RVA: 0x167F120 Offset: 0x167D720 VA: 0x18167F120
	private void RemoveTrailingZeros() { }

	// RVA: 0x1679DC0 Offset: 0x16783C0 VA: 0x181679DC0
	private void AddOneToDecHex() { }

	// RVA: 0x1679D40 Offset: 0x1678340 VA: 0x181679D40
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x167AFE0 Offset: 0x16795E0 VA: 0x18167AFE0
	private int CountTrailingZeros() { }

	// RVA: 0x167AF90 Offset: 0x1679590 VA: 0x18167AF90
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x167CFF0 Offset: 0x167B5F0 VA: 0x18167CFF0
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x167F080 Offset: 0x167D680 VA: 0x18167F080
	private void Release() { }

	// RVA: 0x167EC80 Offset: 0x167D280 VA: 0x18167EC80
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x167EDA0 Offset: 0x167D3A0 VA: 0x18167EDA0
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x167EA80 Offset: 0x167D080 VA: 0x18167EA80
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x167EED0 Offset: 0x167D4D0 VA: 0x18167EED0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x167E4F0 Offset: 0x167CAF0 VA: 0x18167E4F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x167E6C0 Offset: 0x167CCC0 VA: 0x18167E6C0
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x167EBA0 Offset: 0x167D1A0 VA: 0x18167EBA0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x167E210 Offset: 0x167C810 VA: 0x18167E210
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x167E8E0 Offset: 0x167CEE0 VA: 0x18167E8E0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167B520 Offset: 0x1679B20 VA: 0x18167B520
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C0D0 Offset: 0x167A6D0 VA: 0x18167C0D0
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C800 Offset: 0x167AE00 VA: 0x18167C800
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x167C500 Offset: 0x167AB00 VA: 0x18167C500
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167CD80 Offset: 0x167B380 VA: 0x18167CD80
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x167CEB0 Offset: 0x167B4B0 VA: 0x18167CEB0
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x167C690 Offset: 0x167AC90 VA: 0x18167C690
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C9B0 Offset: 0x167AFB0 VA: 0x18167C9B0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167CBA0 Offset: 0x167B1A0 VA: 0x18167CBA0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C4A0 Offset: 0x167AAA0 VA: 0x18167C4A0
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C190 Offset: 0x167A790 VA: 0x18167C190
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x167B8F0 Offset: 0x1679EF0 VA: 0x18167B8F0
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167F6E0 Offset: 0x167DCE0 VA: 0x18167F6E0
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x167E410 Offset: 0x167CA10 VA: 0x18167E410
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x167AA60 Offset: 0x1679060 VA: 0x18167AA60
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x167A970 Offset: 0x1678F70 VA: 0x18167A970
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x167AA00 Offset: 0x1679000 VA: 0x18167AA00
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x1679EF0 Offset: 0x16784F0 VA: 0x181679EF0
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x1679F20 Offset: 0x1678520 VA: 0x181679F20
	private void AppendDecimalString(int precision) { }

	// RVA: 0x167A620 Offset: 0x1678C20 VA: 0x18167A620
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x167A4C0 Offset: 0x1678AC0 VA: 0x18167A4C0
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x167AC20 Offset: 0x1679220 VA: 0x18167AC20
	private void AppendOneDigit(int start) { }

	// RVA: 0x167A180 Offset: 0x1678780 VA: 0x18167A180
	private void AppendDigits(int start, int end) { }

	// RVA: 0x1679F40 Offset: 0x1678540 VA: 0x181679F40
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x167E4E0 Offset: 0x167CAE0 VA: 0x18167E4E0
	private void Multiply10(int count) { }

	// RVA: 0x167B410 Offset: 0x1679A10 VA: 0x18167B410
	private void Divide10(int count) { }

	// RVA: 0x167CF80 Offset: 0x167B580 VA: 0x18167CF80
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

	// RVA: 0x1671650 Offset: 0x166FC50 VA: 0x181671650
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x1671A60 Offset: 0x1670060 VA: 0x181671A60
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x1670EA0 Offset: 0x166F4A0 VA: 0x181670EA0
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x1671DD0 Offset: 0x16703D0 VA: 0x181671DD0
	public void .ctor() { }

}

