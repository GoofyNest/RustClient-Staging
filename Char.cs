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

	// RVA: 0x1562EB0 Offset: 0x15614B0 VA: 0x181562EB0
	private static bool IsLatin1(char ch) { }

	// RVA: 0x1562AD0 Offset: 0x15610D0 VA: 0x181562AD0
	private static bool IsAscii(char ch) { }

	// RVA: 0x1562830 Offset: 0x1560E30 VA: 0x181562830
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x1F2F80 Offset: 0x1F2380 VA: 0x1801F2F80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F2EE0 Offset: 0x1F22E0 VA: 0x1801F2EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F2F70 Offset: 0x1F2370 VA: 0x1801F2F70 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0x1F2E10 Offset: 0x1F2210 VA: 0x1801F2E10 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2E00 Offset: 0x1F2200 VA: 0x1801F2E00 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0x1F3390 Offset: 0x1F2790 VA: 0x1801F3390 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F33F0 Offset: 0x1F27F0 VA: 0x1801F33F0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1564470 Offset: 0x1562A70 VA: 0x181564470
	public static string ToString(char c) { }

	// RVA: 0x1563D00 Offset: 0x1562300 VA: 0x181563D00
	public static char Parse(string s) { }

	// RVA: 0x15647F0 Offset: 0x1562DF0 VA: 0x1815647F0
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x1562CF0 Offset: 0x15612F0 VA: 0x181562CF0
	public static bool IsDigit(char c) { }

	// RVA: 0x1562530 Offset: 0x1560B30 VA: 0x181562530
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x1563130 Offset: 0x1561730 VA: 0x181563130
	public static bool IsLetter(char c) { }

	// RVA: 0x1563A80 Offset: 0x1562080 VA: 0x181563A80
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x1563AB0 Offset: 0x15620B0 VA: 0x181563AB0
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x1563980 Offset: 0x1561F80 VA: 0x181563980
	public static bool IsUpper(char c) { }

	// RVA: 0x1563270 Offset: 0x1561870 VA: 0x181563270
	public static bool IsLower(char c) { }

	// RVA: 0x1562550 Offset: 0x1560B50 VA: 0x181562550
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x1563650 Offset: 0x1561C50 VA: 0x181563650
	public static bool IsPunctuation(char c) { }

	// RVA: 0x1562520 Offset: 0x1560B20 VA: 0x181562520
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x1563050 Offset: 0x1561650 VA: 0x181563050
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1564750 Offset: 0x1562D50 VA: 0x181564750
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x1564650 Offset: 0x1562C50 VA: 0x181564650
	public static char ToUpper(char c) { }

	// RVA: 0x1564550 Offset: 0x1562B50 VA: 0x181564550
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x15642D0 Offset: 0x15628D0 VA: 0x1815642D0
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x1564370 Offset: 0x1562970 VA: 0x181564370
	public static char ToLower(char c) { }

	// RVA: 0x15641D0 Offset: 0x15627D0 VA: 0x1815641D0
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x1F2F90 Offset: 0x1F2390 VA: 0x1801F2F90 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2FA0 Offset: 0x1F23A0 VA: 0x1801F2FA0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x121080 Offset: 0x120480 VA: 0x180121080 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F3170 Offset: 0x1F2570 VA: 0x1801F3170 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F2FB0 Offset: 0x1F23B0 VA: 0x1801F2FB0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F3050 Offset: 0x1F2450 VA: 0x1801F3050 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F3270 Offset: 0x1F2670 VA: 0x1801F3270 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F30B0 Offset: 0x1F24B0 VA: 0x1801F30B0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F32D0 Offset: 0x1F26D0 VA: 0x1801F32D0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F3110 Offset: 0x1F2510 VA: 0x1801F3110 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F3330 Offset: 0x1F2730 VA: 0x1801F3330 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F31D0 Offset: 0x1F25D0 VA: 0x1801F31D0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F3040 Offset: 0x1F2440 VA: 0x1801F3040 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F3020 Offset: 0x1F2420 VA: 0x1801F3020 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F3010 Offset: 0x1F2410 VA: 0x1801F3010 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F31E0 Offset: 0x1F25E0 VA: 0x1801F31E0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1562AE0 Offset: 0x15610E0 VA: 0x181562AE0
	public static bool IsControl(char c) { }

	// RVA: 0x1562BA0 Offset: 0x15611A0 VA: 0x181562BA0
	public static bool IsControl(string s, int index) { }

	// RVA: 0x1562EC0 Offset: 0x15614C0 VA: 0x181562EC0
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x1562540 Offset: 0x1560B40 VA: 0x181562540
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x1563370 Offset: 0x1561970 VA: 0x181563370
	public static bool IsNumber(char c) { }

	// RVA: 0x1563490 Offset: 0x1561A90 VA: 0x181563490
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x1562560 Offset: 0x1560B60 VA: 0x181562560
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1563730 Offset: 0x1561D30 VA: 0x181563730
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x1563750 Offset: 0x1561D50 VA: 0x181563750
	public static bool IsSeparator(char c) { }

	// RVA: 0x1563960 Offset: 0x1561F60 VA: 0x181563960
	public static bool IsSurrogate(char c) { }

	// RVA: 0x1563860 Offset: 0x1561E60 VA: 0x181563860
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x1563B80 Offset: 0x1562180 VA: 0x181563B80
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x15628C0 Offset: 0x1560EC0 VA: 0x1815628C0
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x1562970 Offset: 0x1560F70 VA: 0x181562970
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1562D90 Offset: 0x1561390 VA: 0x181562D90
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1562DB0 Offset: 0x15613B0 VA: 0x181562DB0
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x1563250 Offset: 0x1561850 VA: 0x181563250
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1563830 Offset: 0x1561E30 VA: 0x181563830
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1562650 Offset: 0x1560C50 VA: 0x181562650
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1564820 Offset: 0x1562E20 VA: 0x181564820
	private static void .cctor() { }

}

