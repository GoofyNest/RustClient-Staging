internal static class BigNumber // TypeDefIndex: 3966
{	// Methods

	// RVA: 0x2233770 Offset: 0x2231D70 VA: 0x182233770
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x2233520 Offset: 0x2231B20 VA: 0x182233520
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x2232F30 Offset: 0x2231530 VA: 0x182232F30
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2231C20 Offset: 0x2230220 VA: 0x182231C20
	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	// RVA: 0x2233250 Offset: 0x2231850 VA: 0x182233250
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2232950 Offset: 0x2230F50 VA: 0x182232950
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2232BE0 Offset: 0x22311E0 VA: 0x182232BE0
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x22333C0 Offset: 0x22319C0 VA: 0x1822333C0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2231D90 Offset: 0x2230390 VA: 0x182231D90
	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	// RVA: 0x2232080 Offset: 0x2230680 VA: 0x182232080
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x2231BB0 Offset: 0x22301B0 VA: 0x182231BB0
	public static BigNumber.BigNumberBuffer Create() { }

}

