public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 183
{	// Fields
	internal char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x1562BF0 Offset: 0x15611F0 VA: 0x181562BF0
	private static bool IsLatin1(char ch) { }

	// RVA: 0x1562810 Offset: 0x1560E10 VA: 0x181562810
	private static bool IsAscii(char ch) { }

	// RVA: 0x1562570 Offset: 0x1560B70 VA: 0x181562570
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x1F3000 Offset: 0x1F2400 VA: 0x1801F3000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F2F60 Offset: 0x1F2360 VA: 0x1801F2F60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F2FF0 Offset: 0x1F23F0 VA: 0x1801F2FF0 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0x1F2E90 Offset: 0x1F2290 VA: 0x1801F2E90 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2E80 Offset: 0x1F2280 VA: 0x1801F2E80 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0x1F3410 Offset: 0x1F2810 VA: 0x1801F3410 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F3470 Offset: 0x1F2870 VA: 0x1801F3470 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x15641B0 Offset: 0x15627B0 VA: 0x1815641B0
	public static string ToString(char c) { }

	// RVA: 0x1563A40 Offset: 0x1562040 VA: 0x181563A40
	public static char Parse(string s) { }

	// RVA: 0x1564530 Offset: 0x1562B30 VA: 0x181564530
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x1562A30 Offset: 0x1561030 VA: 0x181562A30
	public static bool IsDigit(char c) { }

	// RVA: 0x1562270 Offset: 0x1560870 VA: 0x181562270
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x1562E70 Offset: 0x1561470 VA: 0x181562E70
	public static bool IsLetter(char c) { }

	// RVA: 0x15637C0 Offset: 0x1561DC0 VA: 0x1815637C0
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x15637F0 Offset: 0x1561DF0 VA: 0x1815637F0
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x15636C0 Offset: 0x1561CC0 VA: 0x1815636C0
	public static bool IsUpper(char c) { }

	// RVA: 0x1562FB0 Offset: 0x15615B0 VA: 0x181562FB0
	public static bool IsLower(char c) { }

	// RVA: 0x1562290 Offset: 0x1560890 VA: 0x181562290
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x1563390 Offset: 0x1561990 VA: 0x181563390
	public static bool IsPunctuation(char c) { }

	// RVA: 0x1562260 Offset: 0x1560860 VA: 0x181562260
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x1562D90 Offset: 0x1561390 VA: 0x181562D90
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1564490 Offset: 0x1562A90 VA: 0x181564490
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x1564390 Offset: 0x1562990 VA: 0x181564390
	public static char ToUpper(char c) { }

	// RVA: 0x1564290 Offset: 0x1562890 VA: 0x181564290
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x1564010 Offset: 0x1562610 VA: 0x181564010
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x15640B0 Offset: 0x15626B0 VA: 0x1815640B0
	public static char ToLower(char c) { }

	// RVA: 0x1563F10 Offset: 0x1562510 VA: 0x181563F10
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x1F3010 Offset: 0x1F2410 VA: 0x1801F3010 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F3020 Offset: 0x1F2420 VA: 0x1801F3020 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x121100 Offset: 0x120500 VA: 0x180121100 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F31F0 Offset: 0x1F25F0 VA: 0x1801F31F0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F3030 Offset: 0x1F2430 VA: 0x1801F3030 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F30D0 Offset: 0x1F24D0 VA: 0x1801F30D0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F32F0 Offset: 0x1F26F0 VA: 0x1801F32F0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F3130 Offset: 0x1F2530 VA: 0x1801F3130 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F3350 Offset: 0x1F2750 VA: 0x1801F3350 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F3190 Offset: 0x1F2590 VA: 0x1801F3190 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F33B0 Offset: 0x1F27B0 VA: 0x1801F33B0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F3250 Offset: 0x1F2650 VA: 0x1801F3250 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F30C0 Offset: 0x1F24C0 VA: 0x1801F30C0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F30A0 Offset: 0x1F24A0 VA: 0x1801F30A0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F3090 Offset: 0x1F2490 VA: 0x1801F3090 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F3260 Offset: 0x1F2660 VA: 0x1801F3260 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1562820 Offset: 0x1560E20 VA: 0x181562820
	public static bool IsControl(char c) { }

	// RVA: 0x15628E0 Offset: 0x1560EE0 VA: 0x1815628E0
	public static bool IsControl(string s, int index) { }

	// RVA: 0x1562C00 Offset: 0x1561200 VA: 0x181562C00
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x1562280 Offset: 0x1560880 VA: 0x181562280
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x15630B0 Offset: 0x15616B0 VA: 0x1815630B0
	public static bool IsNumber(char c) { }

	// RVA: 0x15631D0 Offset: 0x15617D0 VA: 0x1815631D0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x15622A0 Offset: 0x15608A0 VA: 0x1815622A0
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1563470 Offset: 0x1561A70 VA: 0x181563470
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x1563490 Offset: 0x1561A90 VA: 0x181563490
	public static bool IsSeparator(char c) { }

	// RVA: 0x15636A0 Offset: 0x1561CA0 VA: 0x1815636A0
	public static bool IsSurrogate(char c) { }

	// RVA: 0x15635A0 Offset: 0x1561BA0 VA: 0x1815635A0
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x15638C0 Offset: 0x1561EC0 VA: 0x1815638C0
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x1562600 Offset: 0x1560C00 VA: 0x181562600
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x15626B0 Offset: 0x1560CB0 VA: 0x1815626B0
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1562AD0 Offset: 0x15610D0 VA: 0x181562AD0
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1562AF0 Offset: 0x15610F0 VA: 0x181562AF0
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x1562F90 Offset: 0x1561590 VA: 0x181562F90
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1563570 Offset: 0x1561B70 VA: 0x181563570
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1562390 Offset: 0x1560990 VA: 0x181562390
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1564560 Offset: 0x1562B60 VA: 0x181564560
	private static void .cctor() { }

}

