internal static class BigNumber // TypeDefIndex: 3966
{	// Methods

	// RVA: 0x2233F90 Offset: 0x2232590 VA: 0x182233F90
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x2233D40 Offset: 0x2232340 VA: 0x182233D40
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x2233750 Offset: 0x2231D50 VA: 0x182233750
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2232440 Offset: 0x2230A40 VA: 0x182232440
	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	// RVA: 0x2233A70 Offset: 0x2232070 VA: 0x182233A70
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2233170 Offset: 0x2231770 VA: 0x182233170
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2233400 Offset: 0x2231A00 VA: 0x182233400
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x2233BE0 Offset: 0x22321E0 VA: 0x182233BE0
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x22325B0 Offset: 0x2230BB0 VA: 0x1822325B0
	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	// RVA: 0x22328A0 Offset: 0x2230EA0 VA: 0x1822328A0
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x22323D0 Offset: 0x22309D0 VA: 0x1822323D0
	public static BigNumber.BigNumberBuffer Create() { }

}

