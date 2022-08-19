internal static class BigNumber // TypeDefIndex: 3966
{	// Methods

	// RVA: 0x2233670 Offset: 0x2231C70 VA: 0x182233670
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x2233420 Offset: 0x2231A20 VA: 0x182233420
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x2232E30 Offset: 0x2231430 VA: 0x182232E30
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2231B20 Offset: 0x2230120 VA: 0x182231B20
	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	// RVA: 0x2233150 Offset: 0x2231750 VA: 0x182233150
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2232850 Offset: 0x2230E50 VA: 0x182232850
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2232AE0 Offset: 0x22310E0 VA: 0x182232AE0
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x22332C0 Offset: 0x22318C0 VA: 0x1822332C0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x2231C90 Offset: 0x2230290 VA: 0x182231C90
	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	// RVA: 0x2231F80 Offset: 0x2230580 VA: 0x182231F80
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x2231AB0 Offset: 0x22300B0 VA: 0x182231AB0
	public static BigNumber.BigNumberBuffer Create() { }

}

