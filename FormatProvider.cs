internal class FormatProvider // TypeDefIndex: 3970
{	// Methods

	// RVA: 0x2233600 Offset: 0x2231C00 VA: 0x182233600
	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x2233850 Offset: 0x2231E50 VA: 0x182233850
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

	// RVA: 0x1680370 Offset: 0x167E970 VA: 0x181680370
	private static bool IsWhite(char ch) { }

	// RVA: 0x2234AF0 Offset: 0x22330F0 VA: 0x182234AF0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x2234BA0 Offset: 0x22331A0 VA: 0x182234BA0
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x22362E0 Offset: 0x22348E0 VA: 0x1822362E0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2236F00 Offset: 0x2235500 VA: 0x182236F00
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2236F80 Offset: 0x2235580 VA: 0x182236F80
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2234A90 Offset: 0x2233090 VA: 0x182234A90
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x22361F0 Offset: 0x22347F0 VA: 0x1822361F0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2235850 Offset: 0x2233E50 VA: 0x182235850
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2233A40 Offset: 0x2232040 VA: 0x182233A40
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2238330 Offset: 0x2236930 VA: 0x182238330
	private static int wcslen(char* s) { }

	// RVA: 0x2233E50 Offset: 0x2232450 VA: 0x182233E50
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x2234430 Offset: 0x2232A30 VA: 0x182234430
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2234930 Offset: 0x2232F30 VA: 0x182234930
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x2233CE0 Offset: 0x22322E0 VA: 0x182233CE0
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2234280 Offset: 0x2232880 VA: 0x182234280
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2234680 Offset: 0x2232C80 VA: 0x182234680
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2236E20 Offset: 0x2235420 VA: 0x182236E20
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x2233970 Offset: 0x2231F70 VA: 0x182233970
	private static int FindSection(string format, int section) { }

	// RVA: 0x2234BF0 Offset: 0x22331F0 VA: 0x182234BF0
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x22371B0 Offset: 0x22357B0 VA: 0x1822371B0
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

