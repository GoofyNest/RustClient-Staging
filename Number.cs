internal class Number // TypeDefIndex: 278
{	// Methods

	// RVA: 0x1680440 Offset: 0x167EA40 VA: 0x181680440
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x1680450 Offset: 0x167EA50 VA: 0x181680450
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x167F960 Offset: 0x167DF60 VA: 0x18167F960
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FA80 Offset: 0x167E080 VA: 0x18167FA80
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FB00 Offset: 0x167E100 VA: 0x18167FB00
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FE60 Offset: 0x167E460 VA: 0x18167FE60
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FC70 Offset: 0x167E270 VA: 0x18167FC70
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FFC0 Offset: 0x167E5C0 VA: 0x18167FFC0
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x167FDE0 Offset: 0x167E3E0 VA: 0x18167FDE0
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x1680120 Offset: 0x167E720 VA: 0x181680120
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x16801A0 Offset: 0x167E7A0 VA: 0x1816801A0
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x1680260 Offset: 0x167E860 VA: 0x181680260
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x16802E0 Offset: 0x167E8E0 VA: 0x1816802E0
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x1680370 Offset: 0x167E970 VA: 0x181680370
	private static bool IsWhite(char ch) { }

	// RVA: 0x1680460 Offset: 0x167EA60 VA: 0x181680460
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x16804C0 Offset: 0x167EAC0 VA: 0x1816804C0
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x1680540 Offset: 0x167EB40 VA: 0x181680540
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x16805A0 Offset: 0x167EBA0 VA: 0x1816805A0
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x16803D0 Offset: 0x167E9D0 VA: 0x1816803D0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x1680390 Offset: 0x167E990 VA: 0x181680390
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x1680610 Offset: 0x167EC10 VA: 0x181680610
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680780 Offset: 0x167ED80 VA: 0x181680780
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680A30 Offset: 0x167F030 VA: 0x181680A30
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1680C80 Offset: 0x167F280 VA: 0x181680C80
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1680EF0 Offset: 0x167F4F0 VA: 0x181680EF0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x16819E0 Offset: 0x167FFE0 VA: 0x1816819E0
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1681D00 Offset: 0x1680300 VA: 0x181681D00
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x1681F40 Offset: 0x1680540 VA: 0x181681F40
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x16821A0 Offset: 0x16807A0 VA: 0x1816821A0
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x16822E0 Offset: 0x16808E0 VA: 0x1816822E0
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x1682340 Offset: 0x1680940 VA: 0x181682340
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x16824C0 Offset: 0x1680AC0 VA: 0x1816824C0
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x1682640 Offset: 0x1680C40 VA: 0x181682640
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x1682880 Offset: 0x1680E80 VA: 0x181682880
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x1682A50 Offset: 0x1681050 VA: 0x181682A50
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x1682C00 Offset: 0x1681200 VA: 0x181682C00
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x1682E40 Offset: 0x1681440 VA: 0x181682E40
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x1683160 Offset: 0x1681760 VA: 0x181683160
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1683090 Offset: 0x1681690 VA: 0x181683090
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

	// RVA: 0x1679D00 Offset: 0x1678300 VA: 0x181679D00
	private static void .cctor() { }

}

