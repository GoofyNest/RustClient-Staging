internal static class BigNumber // TypeDefIndex: 3966
{	// Methods

	// RVA: 0x22334B0 Offset: 0x2231AB0 VA: 0x1822334B0
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x2233260 Offset: 0x2231860 VA: 0x182233260
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x2232C70 Offset: 0x2231270 VA: 0x182232C70
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2231960 Offset: 0x222FF60 VA: 0x182231960
	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	// RVA: 0x2232F90 Offset: 0x2231590 VA: 0x182232F90
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2232690 Offset: 0x2230C90 VA: 0x182232690
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2232920 Offset: 0x2230F20 VA: 0x182232920
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2233100 Offset: 0x2231700 VA: 0x182233100
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2231AD0 Offset: 0x22300D0 VA: 0x182231AD0
	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	// RVA: 0x2231DC0 Offset: 0x22303C0 VA: 0x182231DC0
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x22318F0 Offset: 0x222FEF0 VA: 0x1822318F0
	public static BigNumber.BigNumberBuffer Create() { }

}

