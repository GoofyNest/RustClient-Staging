internal class FormatProvider // TypeDefIndex: 3970
{	// Methods

	// RVA: 0x22340E0 Offset: 0x22326E0 VA: 0x1822340E0
	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x2234330 Offset: 0x2232930 VA: 0x182234330
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

private class FormatProvider.Number // TypeDefIndex: 3971
{	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x167E220 Offset: 0x167C820 VA: 0x18167E220
	private static bool IsWhite(char ch) { }

	// RVA: 0x22355D0 Offset: 0x2233BD0 VA: 0x1822355D0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x2235680 Offset: 0x2233C80 VA: 0x182235680
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x2236DC0 Offset: 0x22353C0 VA: 0x182236DC0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x22379E0 Offset: 0x2235FE0 VA: 0x1822379E0
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2237A60 Offset: 0x2236060 VA: 0x182237A60
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2235570 Offset: 0x2233B70 VA: 0x182235570
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x2236CD0 Offset: 0x22352D0 VA: 0x182236CD0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2236330 Offset: 0x2234930 VA: 0x182236330
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2234520 Offset: 0x2232B20 VA: 0x182234520
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2238E10 Offset: 0x2237410 VA: 0x182238E10
	private static int wcslen(char* s) { }

	// RVA: 0x2234930 Offset: 0x2232F30 VA: 0x182234930
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x2234F10 Offset: 0x2233510 VA: 0x182234F10
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2235410 Offset: 0x2233A10 VA: 0x182235410
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x22347C0 Offset: 0x2232DC0 VA: 0x1822347C0
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2234D60 Offset: 0x2233360 VA: 0x182234D60
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2235160 Offset: 0x2233760 VA: 0x182235160
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2237900 Offset: 0x2235F00 VA: 0x182237900
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x2234450 Offset: 0x2232A50 VA: 0x182234450
	private static int FindSection(string format, int section) { }

	// RVA: 0x22356D0 Offset: 0x2233CD0 VA: 0x1822356D0
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x2237C90 Offset: 0x2236290 VA: 0x182237C90
	private static void .cctor() { }

}

internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 3972
{	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	public bool sign; // 0x8
	public char* overrideDigits; // 0x10

	// Properties
	public char* digits { get; }

	// Methods

	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public char* get_digits() { }

}

