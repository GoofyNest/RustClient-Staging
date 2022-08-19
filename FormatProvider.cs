internal class FormatProvider // TypeDefIndex: 3970
{	// Methods

	// RVA: 0x22337C0 Offset: 0x2231DC0 VA: 0x1822337C0
	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x2233A10 Offset: 0x2232010 VA: 0x182233A10
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

	// RVA: 0x2234CB0 Offset: 0x22332B0 VA: 0x182234CB0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x2234D60 Offset: 0x2233360 VA: 0x182234D60
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x22364A0 Offset: 0x2234AA0 VA: 0x1822364A0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x22370C0 Offset: 0x22356C0 VA: 0x1822370C0
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2237140 Offset: 0x2235740 VA: 0x182237140
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2234C50 Offset: 0x2233250 VA: 0x182234C50
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x22363B0 Offset: 0x22349B0 VA: 0x1822363B0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2235A10 Offset: 0x2234010 VA: 0x182235A10
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2233C00 Offset: 0x2232200 VA: 0x182233C00
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x22384F0 Offset: 0x2236AF0 VA: 0x1822384F0
	private static int wcslen(char* s) { }

	// RVA: 0x2234010 Offset: 0x2232610 VA: 0x182234010
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x22345F0 Offset: 0x2232BF0 VA: 0x1822345F0
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2234AF0 Offset: 0x22330F0 VA: 0x182234AF0
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x2233EA0 Offset: 0x22324A0 VA: 0x182233EA0
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2234440 Offset: 0x2232A40 VA: 0x182234440
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2234840 Offset: 0x2232E40 VA: 0x182234840
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2236FE0 Offset: 0x22355E0 VA: 0x182236FE0
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x2233B30 Offset: 0x2232130 VA: 0x182233B30
	private static int FindSection(string format, int section) { }

	// RVA: 0x2234DB0 Offset: 0x22333B0 VA: 0x182234DB0
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x2237370 Offset: 0x2235970 VA: 0x182237370
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

	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public char* get_digits() { }

}

