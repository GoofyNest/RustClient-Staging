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

	// RVA: 0x1561F80 Offset: 0x1560580 VA: 0x181561F80
	private static bool IsLatin1(char ch) { }

	// RVA: 0x1561BA0 Offset: 0x15601A0 VA: 0x181561BA0
	private static bool IsAscii(char ch) { }

	// RVA: 0x1561900 Offset: 0x155FF00 VA: 0x181561900
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x1F33A0 Offset: 0x1F27A0 VA: 0x1801F33A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F3300 Offset: 0x1F2700 VA: 0x1801F3300 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F3390 Offset: 0x1F2790 VA: 0x1801F3390 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0x1F3230 Offset: 0x1F2630 VA: 0x1801F3230 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F3220 Offset: 0x1F2620 VA: 0x1801F3220 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0x1F37B0 Offset: 0x1F2BB0 VA: 0x1801F37B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F3810 Offset: 0x1F2C10 VA: 0x1801F3810 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1563540 Offset: 0x1561B40 VA: 0x181563540
	public static string ToString(char c) { }

	// RVA: 0x1562DD0 Offset: 0x15613D0 VA: 0x181562DD0
	public static char Parse(string s) { }

	// RVA: 0x15638C0 Offset: 0x1561EC0 VA: 0x1815638C0
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x1561DC0 Offset: 0x15603C0 VA: 0x181561DC0
	public static bool IsDigit(char c) { }

	// RVA: 0x1561600 Offset: 0x155FC00 VA: 0x181561600
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x1562200 Offset: 0x1560800 VA: 0x181562200
	public static bool IsLetter(char c) { }

	// RVA: 0x1562B50 Offset: 0x1561150 VA: 0x181562B50
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x1562B80 Offset: 0x1561180 VA: 0x181562B80
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x1562A50 Offset: 0x1561050 VA: 0x181562A50
	public static bool IsUpper(char c) { }

	// RVA: 0x1562340 Offset: 0x1560940 VA: 0x181562340
	public static bool IsLower(char c) { }

	// RVA: 0x1561620 Offset: 0x155FC20 VA: 0x181561620
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x1562720 Offset: 0x1560D20 VA: 0x181562720
	public static bool IsPunctuation(char c) { }

	// RVA: 0x15615F0 Offset: 0x155FBF0 VA: 0x1815615F0
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x1562120 Offset: 0x1560720 VA: 0x181562120
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1563820 Offset: 0x1561E20 VA: 0x181563820
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x1563720 Offset: 0x1561D20 VA: 0x181563720
	public static char ToUpper(char c) { }

	// RVA: 0x1563620 Offset: 0x1561C20 VA: 0x181563620
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x15633A0 Offset: 0x15619A0 VA: 0x1815633A0
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x1563440 Offset: 0x1561A40 VA: 0x181563440
	public static char ToLower(char c) { }

	// RVA: 0x15632A0 Offset: 0x15618A0 VA: 0x1815632A0
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x1F33B0 Offset: 0x1F27B0 VA: 0x1801F33B0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F33C0 Offset: 0x1F27C0 VA: 0x1801F33C0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F3590 Offset: 0x1F2990 VA: 0x1801F3590 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F33D0 Offset: 0x1F27D0 VA: 0x1801F33D0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F3470 Offset: 0x1F2870 VA: 0x1801F3470 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F3690 Offset: 0x1F2A90 VA: 0x1801F3690 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F34D0 Offset: 0x1F28D0 VA: 0x1801F34D0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F36F0 Offset: 0x1F2AF0 VA: 0x1801F36F0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F3530 Offset: 0x1F2930 VA: 0x1801F3530 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F3750 Offset: 0x1F2B50 VA: 0x1801F3750 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F35F0 Offset: 0x1F29F0 VA: 0x1801F35F0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F3460 Offset: 0x1F2860 VA: 0x1801F3460 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F3440 Offset: 0x1F2840 VA: 0x1801F3440 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F3430 Offset: 0x1F2830 VA: 0x1801F3430 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F3600 Offset: 0x1F2A00 VA: 0x1801F3600 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1561BB0 Offset: 0x15601B0 VA: 0x181561BB0
	public static bool IsControl(char c) { }

	// RVA: 0x1561C70 Offset: 0x1560270 VA: 0x181561C70
	public static bool IsControl(string s, int index) { }

	// RVA: 0x1561F90 Offset: 0x1560590 VA: 0x181561F90
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x1561610 Offset: 0x155FC10 VA: 0x181561610
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x1562440 Offset: 0x1560A40 VA: 0x181562440
	public static bool IsNumber(char c) { }

	// RVA: 0x1562560 Offset: 0x1560B60 VA: 0x181562560
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x1561630 Offset: 0x155FC30 VA: 0x181561630
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1562800 Offset: 0x1560E00 VA: 0x181562800
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x1562820 Offset: 0x1560E20 VA: 0x181562820
	public static bool IsSeparator(char c) { }

	// RVA: 0x1562A30 Offset: 0x1561030 VA: 0x181562A30
	public static bool IsSurrogate(char c) { }

	// RVA: 0x1562930 Offset: 0x1560F30 VA: 0x181562930
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x1562C50 Offset: 0x1561250 VA: 0x181562C50
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x1561990 Offset: 0x155FF90 VA: 0x181561990
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x1561A40 Offset: 0x1560040 VA: 0x181561A40
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1561E60 Offset: 0x1560460 VA: 0x181561E60
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1561E80 Offset: 0x1560480 VA: 0x181561E80
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x1562320 Offset: 0x1560920 VA: 0x181562320
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1562900 Offset: 0x1560F00 VA: 0x181562900
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1561720 Offset: 0x155FD20 VA: 0x181561720
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x15638F0 Offset: 0x1561EF0 VA: 0x1815638F0
	private static void .cctor() { }

}

