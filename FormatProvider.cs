internal class FormatProvider // TypeDefIndex: 3970
{	// Methods

	// RVA: 0x22338C0 Offset: 0x2231EC0 VA: 0x1822338C0
	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x2233B10 Offset: 0x2232110 VA: 0x182233B10
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

	// RVA: 0x1680630 Offset: 0x167EC30 VA: 0x181680630
	private static bool IsWhite(char ch) { }

	// RVA: 0x2234DB0 Offset: 0x22333B0 VA: 0x182234DB0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x2234E60 Offset: 0x2233460 VA: 0x182234E60
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x22365A0 Offset: 0x2234BA0 VA: 0x1822365A0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x22371C0 Offset: 0x22357C0 VA: 0x1822371C0
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2237240 Offset: 0x2235840 VA: 0x182237240
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2234D50 Offset: 0x2233350 VA: 0x182234D50
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x22364B0 Offset: 0x2234AB0 VA: 0x1822364B0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2235B10 Offset: 0x2234110 VA: 0x182235B10
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2233D00 Offset: 0x2232300 VA: 0x182233D00
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x22385F0 Offset: 0x2236BF0 VA: 0x1822385F0
	private static int wcslen(char* s) { }

	// RVA: 0x2234110 Offset: 0x2232710 VA: 0x182234110
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x22346F0 Offset: 0x2232CF0 VA: 0x1822346F0
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2234BF0 Offset: 0x22331F0 VA: 0x182234BF0
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x2233FA0 Offset: 0x22325A0 VA: 0x182233FA0
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2234540 Offset: 0x2232B40 VA: 0x182234540
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2234940 Offset: 0x2232F40 VA: 0x182234940
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x22370E0 Offset: 0x22356E0 VA: 0x1822370E0
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x2233C30 Offset: 0x2232230 VA: 0x182233C30
	private static int FindSection(string format, int section) { }

	// RVA: 0x2234EB0 Offset: 0x22334B0 VA: 0x182234EB0
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x2237470 Offset: 0x2235A70 VA: 0x182237470
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

