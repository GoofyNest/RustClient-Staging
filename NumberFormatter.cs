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

	// RVA: 0x167D2A0 Offset: 0x167B8A0 VA: 0x18167D2A0
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x167FA40 Offset: 0x167E040 VA: 0x18167FA40
	private static void .cctor() { }

	// RVA: 0x167D4E0 Offset: 0x167BAE0 VA: 0x18167D4E0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x167D890 Offset: 0x167BE90 VA: 0x18167D890
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x167D750 Offset: 0x167BD50 VA: 0x18167D750
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x167D550 Offset: 0x167BB50 VA: 0x18167D550
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x167B710 Offset: 0x1679D10 VA: 0x18167B710
	private static uint FastToDecHex(int val) { }

	// RVA: 0x167F8F0 Offset: 0x167DEF0 VA: 0x18167F8F0
	private static uint ToDecHex(int val) { }

	// RVA: 0x167B6E0 Offset: 0x1679CE0 VA: 0x18167B6E0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x167B610 Offset: 0x1679C10 VA: 0x18167B610
	private static int DecHexLen(uint val) { }

	// RVA: 0x167B4E0 Offset: 0x1679AE0 VA: 0x18167B4E0
	private int DecHexLen() { }

	// RVA: 0x167F870 Offset: 0x167DE70 VA: 0x18167F870
	private static int ScaleOrder(long hi) { }

	// RVA: 0x167E400 Offset: 0x167CA00 VA: 0x18167E400
	private int InitialFloatingPrecision() { }

	// RVA: 0x167F2C0 Offset: 0x167D8C0 VA: 0x18167F2C0
	private static int ParsePrecision(string format) { }

	// RVA: 0x167FAA0 Offset: 0x167E0A0 VA: 0x18167FAA0
	private void .ctor(Thread current) { }

	// RVA: 0x167E110 Offset: 0x167C710 VA: 0x18167E110
	private void Init(string format) { }

	// RVA: 0x167D9E0 Offset: 0x167BFE0 VA: 0x18167D9E0
	private void InitHex(ulong value) { }

	// RVA: 0x167DAC0 Offset: 0x167C0C0 VA: 0x18167DAC0
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x167DB70 Offset: 0x167C170 VA: 0x18167DB70
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x167DC10 Offset: 0x167C210 VA: 0x18167DC10
	private void Init(string format, long value) { }

	// RVA: 0x167DA30 Offset: 0x167C030 VA: 0x18167DA30
	private void Init(string format, ulong value) { }

	// RVA: 0x167DCB0 Offset: 0x167C2B0 VA: 0x18167DCB0
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x167E250 Offset: 0x167C850 VA: 0x18167E250
	private void Init(string format, Decimal value) { }

	// RVA: 0x167F410 Offset: 0x167DA10 VA: 0x18167F410
	private void ResetCharBuf(int size) { }

	// RVA: 0x167F480 Offset: 0x167DA80 VA: 0x18167F480
	private void Resize(int len) { }

	// RVA: 0x167B0B0 Offset: 0x16796B0 VA: 0x18167B0B0
	private void Append(char c) { }

	// RVA: 0x167AFD0 Offset: 0x16795D0 VA: 0x18167AFD0
	private void Append(char c, int cnt) { }

	// RVA: 0x167B160 Offset: 0x1679760 VA: 0x18167B160
	private void Append(string s) { }

	// RVA: 0x167D4C0 Offset: 0x167BAC0 VA: 0x18167D4C0
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x167FBD0 Offset: 0x167E1D0 VA: 0x18167FBD0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x167FB80 Offset: 0x167E180 VA: 0x18167FB80
	private int get_IntegerDigits() { }

	// RVA: 0x167FB70 Offset: 0x167E170 VA: 0x18167FB70
	private int get_DecimalDigits() { }

	// RVA: 0x167FB90 Offset: 0x167E190 VA: 0x18167FB90
	private bool get_IsFloatingSource() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330
	private bool get_IsZero() { }

	// RVA: 0x167FBB0 Offset: 0x167E1B0 VA: 0x18167FBB0
	private bool get_IsZeroInteger() { }

	// RVA: 0x167F860 Offset: 0x167DE60 VA: 0x18167F860
	private void RoundPos(int pos) { }

	// RVA: 0x167F840 Offset: 0x167DE40 VA: 0x18167F840
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x167F4D0 Offset: 0x167DAD0 VA: 0x18167F4D0
	private bool RoundBits(int shift) { }

	// RVA: 0x167F3E0 Offset: 0x167D9E0 VA: 0x18167F3E0
	private void RemoveTrailingZeros() { }

	// RVA: 0x167A080 Offset: 0x1678680 VA: 0x18167A080
	private void AddOneToDecHex() { }

	// RVA: 0x167A000 Offset: 0x1678600 VA: 0x18167A000
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x167B2A0 Offset: 0x16798A0 VA: 0x18167B2A0
	private int CountTrailingZeros() { }

	// RVA: 0x167B250 Offset: 0x1679850 VA: 0x18167B250
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x167D2B0 Offset: 0x167B8B0 VA: 0x18167D2B0
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x167F340 Offset: 0x167D940 VA: 0x18167F340
	private void Release() { }

	// RVA: 0x167EF40 Offset: 0x167D540 VA: 0x18167EF40
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x167F060 Offset: 0x167D660 VA: 0x18167F060
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x167ED40 Offset: 0x167D340 VA: 0x18167ED40
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x167F190 Offset: 0x167D790 VA: 0x18167F190
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x167E7B0 Offset: 0x167CDB0 VA: 0x18167E7B0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x167E980 Offset: 0x167CF80 VA: 0x18167E980
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x167EE60 Offset: 0x167D460 VA: 0x18167EE60
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x167E4D0 Offset: 0x167CAD0 VA: 0x18167E4D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x167EBA0 Offset: 0x167D1A0 VA: 0x18167EBA0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167B7E0 Offset: 0x1679DE0 VA: 0x18167B7E0
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C390 Offset: 0x167A990 VA: 0x18167C390
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167CAC0 Offset: 0x167B0C0 VA: 0x18167CAC0
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x167C7C0 Offset: 0x167ADC0 VA: 0x18167C7C0
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167D040 Offset: 0x167B640 VA: 0x18167D040
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x167D170 Offset: 0x167B770 VA: 0x18167D170
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x167C950 Offset: 0x167AF50 VA: 0x18167C950
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167CC70 Offset: 0x167B270 VA: 0x18167CC70
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167CE60 Offset: 0x167B460 VA: 0x18167CE60
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C760 Offset: 0x167AD60 VA: 0x18167C760
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x167C450 Offset: 0x167AA50 VA: 0x18167C450
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x167BBB0 Offset: 0x167A1B0 VA: 0x18167BBB0
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167F9A0 Offset: 0x167DFA0 VA: 0x18167F9A0
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x167E6D0 Offset: 0x167CCD0 VA: 0x18167E6D0
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x167AD20 Offset: 0x1679320 VA: 0x18167AD20
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x167AC30 Offset: 0x1679230 VA: 0x18167AC30
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x167ACC0 Offset: 0x16792C0 VA: 0x18167ACC0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x167A1B0 Offset: 0x16787B0 VA: 0x18167A1B0
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x167A1E0 Offset: 0x16787E0 VA: 0x18167A1E0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x167A8E0 Offset: 0x1678EE0 VA: 0x18167A8E0
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x167A780 Offset: 0x1678D80 VA: 0x18167A780
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x167AEE0 Offset: 0x16794E0 VA: 0x18167AEE0
	private void AppendOneDigit(int start) { }

	// RVA: 0x167A440 Offset: 0x1678A40 VA: 0x18167A440
	private void AppendDigits(int start, int end) { }

	// RVA: 0x167A200 Offset: 0x1678800 VA: 0x18167A200
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x167E7A0 Offset: 0x167CDA0 VA: 0x18167E7A0
	private void Multiply10(int count) { }

	// RVA: 0x167B6D0 Offset: 0x1679CD0 VA: 0x18167B6D0
	private void Divide10(int count) { }

	// RVA: 0x167D240 Offset: 0x167B840 VA: 0x18167D240
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

	// RVA: 0x1671910 Offset: 0x166FF10 VA: 0x181671910
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x1671D20 Offset: 0x1670320 VA: 0x181671D20
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x1671160 Offset: 0x166F760 VA: 0x181671160
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x1672090 Offset: 0x1670690 VA: 0x181672090
	public void .ctor() { }

}

