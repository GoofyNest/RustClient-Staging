internal class Number // TypeDefIndex: 278
{	// Methods

	// RVA: 0x1680700 Offset: 0x167ED00 VA: 0x181680700
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x1680710 Offset: 0x167ED10 VA: 0x181680710
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x167FC20 Offset: 0x167E220 VA: 0x18167FC20
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FD40 Offset: 0x167E340 VA: 0x18167FD40
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FDC0 Offset: 0x167E3C0 VA: 0x18167FDC0
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x1680120 Offset: 0x167E720 VA: 0x181680120
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FF30 Offset: 0x167E530 VA: 0x18167FF30
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x1680280 Offset: 0x167E880 VA: 0x181680280
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x16800A0 Offset: 0x167E6A0 VA: 0x1816800A0
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x16803E0 Offset: 0x167E9E0 VA: 0x1816803E0
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x1680460 Offset: 0x167EA60 VA: 0x181680460
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x1680520 Offset: 0x167EB20 VA: 0x181680520
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x16805A0 Offset: 0x167EBA0 VA: 0x1816805A0
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x1680630 Offset: 0x167EC30 VA: 0x181680630
	private static bool IsWhite(char ch) { }

	// RVA: 0x1680720 Offset: 0x167ED20 VA: 0x181680720
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x1680780 Offset: 0x167ED80 VA: 0x181680780
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x1680800 Offset: 0x167EE00 VA: 0x181680800
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x1680860 Offset: 0x167EE60 VA: 0x181680860
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x1680690 Offset: 0x167EC90 VA: 0x181680690
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x1680650 Offset: 0x167EC50 VA: 0x181680650
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x16808D0 Offset: 0x167EED0 VA: 0x1816808D0
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680A40 Offset: 0x167F040 VA: 0x181680A40
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680CF0 Offset: 0x167F2F0 VA: 0x181680CF0
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1680F40 Offset: 0x167F540 VA: 0x181680F40
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x16811B0 Offset: 0x167F7B0 VA: 0x1816811B0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x1681CA0 Offset: 0x16802A0 VA: 0x181681CA0
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1681FC0 Offset: 0x16805C0 VA: 0x181681FC0
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1682200 Offset: 0x1680800 VA: 0x181682200
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1682460 Offset: 0x1680A60 VA: 0x181682460
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x16825A0 Offset: 0x1680BA0 VA: 0x1816825A0
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x1682600 Offset: 0x1680C00 VA: 0x181682600
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x1682780 Offset: 0x1680D80 VA: 0x181682780
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x1682900 Offset: 0x1680F00 VA: 0x181682900
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x1682B40 Offset: 0x1681140 VA: 0x181682B40
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x1682D10 Offset: 0x1681310 VA: 0x181682D10
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x1682EC0 Offset: 0x16814C0 VA: 0x181682EC0
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x1683100 Offset: 0x1681700 VA: 0x181683100
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x1683420 Offset: 0x1681A20 VA: 0x181683420
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1683350 Offset: 0x1681950 VA: 0x181683350
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

	// RVA: 0x1FC100 Offset: 0x1FB500 VA: 0x1801FC100
	public void .ctor(byte* stackBuffer) { }

	// RVA: 0x1FC0E0 Offset: 0x1FB4E0 VA: 0x1801FC0E0
	public byte* PackForNative() { }

	// RVA: 0x1679FC0 Offset: 0x16785C0 VA: 0x181679FC0
	private static void .cctor() { }

}

