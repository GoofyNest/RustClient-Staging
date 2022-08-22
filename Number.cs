internal class Number // TypeDefIndex: 278
{	// Methods

	// RVA: 0x167E2F0 Offset: 0x167C8F0 VA: 0x18167E2F0
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x167E300 Offset: 0x167C900 VA: 0x18167E300
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x167D810 Offset: 0x167BE10 VA: 0x18167D810
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x167D930 Offset: 0x167BF30 VA: 0x18167D930
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x167D9B0 Offset: 0x167BFB0 VA: 0x18167D9B0
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x167DD10 Offset: 0x167C310 VA: 0x18167DD10
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x167DB20 Offset: 0x167C120 VA: 0x18167DB20
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x167DE70 Offset: 0x167C470 VA: 0x18167DE70
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x167DC90 Offset: 0x167C290 VA: 0x18167DC90
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x167DFD0 Offset: 0x167C5D0 VA: 0x18167DFD0
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x167E050 Offset: 0x167C650 VA: 0x18167E050
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x167E110 Offset: 0x167C710 VA: 0x18167E110
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x167E190 Offset: 0x167C790 VA: 0x18167E190
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x167E220 Offset: 0x167C820 VA: 0x18167E220
	private static bool IsWhite(char ch) { }

	// RVA: 0x167E310 Offset: 0x167C910 VA: 0x18167E310
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x167E370 Offset: 0x167C970 VA: 0x18167E370
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x167E3F0 Offset: 0x167C9F0 VA: 0x18167E3F0
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x167E450 Offset: 0x167CA50 VA: 0x18167E450
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x167E280 Offset: 0x167C880 VA: 0x18167E280
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x167E240 Offset: 0x167C840 VA: 0x18167E240
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x167E4C0 Offset: 0x167CAC0 VA: 0x18167E4C0
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167E630 Offset: 0x167CC30 VA: 0x18167E630
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167E8E0 Offset: 0x167CEE0 VA: 0x18167E8E0
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x167EB30 Offset: 0x167D130 VA: 0x18167EB30
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167EDA0 Offset: 0x167D3A0 VA: 0x18167EDA0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x167F890 Offset: 0x167DE90 VA: 0x18167F890
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167FBB0 Offset: 0x167E1B0 VA: 0x18167FBB0
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167FDF0 Offset: 0x167E3F0 VA: 0x18167FDF0
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680050 Offset: 0x167E650 VA: 0x181680050
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x1680190 Offset: 0x167E790 VA: 0x181680190
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x16801F0 Offset: 0x167E7F0 VA: 0x1816801F0
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x1680370 Offset: 0x167E970 VA: 0x181680370
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x16804F0 Offset: 0x167EAF0 VA: 0x1816804F0
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x1680730 Offset: 0x167ED30 VA: 0x181680730
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x1680900 Offset: 0x167EF00 VA: 0x181680900
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x1680AB0 Offset: 0x167F0B0 VA: 0x181680AB0
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x1680CF0 Offset: 0x167F2F0 VA: 0x181680CF0
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x1681010 Offset: 0x167F610 VA: 0x181681010
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1680F40 Offset: 0x167F540 VA: 0x181680F40
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

}

internal struct Number.NumberBuffer // TypeDefIndex: 279
{	// Fields
	public static readonly int NumberBufferBytes; // 0x0
	private byte* baseAddress; // 0x0
	public char* digits; // 0x8
	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18

	// Methods

	// RVA: 0x1FBD30 Offset: 0x1FB130 VA: 0x1801FBD30
	public void .ctor(byte* stackBuffer) { }

	// RVA: 0x1FBD10 Offset: 0x1FB110 VA: 0x1801FBD10
	public byte* PackForNative() { }

	// RVA: 0x1677BB0 Offset: 0x16761B0 VA: 0x181677BB0
	private static void .cctor() { }

}

