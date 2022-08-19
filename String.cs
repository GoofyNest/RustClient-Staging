public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 301
{	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x18B7490 Offset: 0x18B5A90 VA: 0x1818B7490
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B7830 Offset: 0x18B5E30 VA: 0x1818B7830
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8400 Offset: 0xED6A00 VA: 0x180ED8400
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B71E0 Offset: 0x18B57E0 VA: 0x1818B71E0
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x18B7520 Offset: 0x18B5B20 VA: 0x1818B7520
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x18B0FA0 Offset: 0x18AF5A0 VA: 0x1818B0FA0
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x18B44C0 Offset: 0x18B2AC0 VA: 0x1818B44C0
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x18B0DF0 Offset: 0x18AF3F0 VA: 0x1818B0DF0
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x18B48E0 Offset: 0x18B2EE0 VA: 0x1818B48E0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x18B4AA0 Offset: 0x18B30A0 VA: 0x1818B4AA0 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x18B4B40 Offset: 0x18B3140 VA: 0x1818B4B40
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4A70 Offset: 0x18B3070 VA: 0x1818B4A70
	public static bool Equals(string a, string b) { }

	// RVA: 0x18B45D0 Offset: 0x18B2BD0 VA: 0x1818B45D0
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x18B4A70 Offset: 0x18B3070 VA: 0x1818B4A70
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x18BBDC0 Offset: 0x18BA3C0 VA: 0x1818BBDC0
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x18BBA90 Offset: 0x18BA090 VA: 0x1818BBA90
	public char get_Chars(int index) { }

	// RVA: 0x18B3200 Offset: 0x18B1800 VA: 0x1818B3200
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x18BAA70 Offset: 0x18B9070 VA: 0x1818BAA70
	public char[] ToCharArray() { }

	// RVA: 0x100FC90 Offset: 0x100E290 VA: 0x18100FC90
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x18B70E0 Offset: 0x18B56E0 VA: 0x1818B70E0
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x18B5990 Offset: 0x18B3F90 VA: 0x1818B5990 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x18B5990 Offset: 0x18B3F90 VA: 0x1818B5990
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x18B9A90 Offset: 0x18B8090 VA: 0x1818B9A90
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B9AB0 Offset: 0x18B80B0 VA: 0x1818B9AB0
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B9840 Offset: 0x18B7E40 VA: 0x1818B9840
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B9A70 Offset: 0x18B8070 VA: 0x1818B9A70
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B9AD0 Offset: 0x18B80D0 VA: 0x1818B9AD0
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x18B6A40 Offset: 0x18B5040 VA: 0x1818B6A40
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B6CF0 Offset: 0x18B52F0 VA: 0x1818B6CF0
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B8400 Offset: 0x18B6A00 VA: 0x1818B8400
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x18B85A0 Offset: 0x18B6BA0 VA: 0x1818B85A0
	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	// RVA: 0x18BA120 Offset: 0x18B8720 VA: 0x1818BA120
	public string Substring(int startIndex) { }

	// RVA: 0x18BA130 Offset: 0x18B8730 VA: 0x1818BA130
	public string Substring(int startIndex, int length) { }

	// RVA: 0x18B7040 Offset: 0x18B5640 VA: 0x1818B7040
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x18BB760 Offset: 0x18B9D60 VA: 0x1818BB760
	public string Trim(char[] trimChars) { }

	// RVA: 0x18BB630 Offset: 0x18B9C30 VA: 0x1818BB630
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x18BAFF0 Offset: 0x18B95F0 VA: 0x1818BAFF0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x18B34B0 Offset: 0x18B1AB0 VA: 0x1818B34B0
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x18B8760 Offset: 0x18B6D60 VA: 0x1818B8760
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x18B4E40 Offset: 0x18B3440 VA: 0x1818B4E40
	internal static string FastAllocateString(int length) { }

	// RVA: 0x18B4E50 Offset: 0x18B3450 VA: 0x1818B4E50
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(char[] value) { }

	// RVA: 0x18BBE60 Offset: 0x18BA460 VA: 0x1818BBE60
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x18B3D50 Offset: 0x18B2350 VA: 0x1818B3D50
	private string CtorCharArray(char[] value) { }

	// RVA: 0x18B3B70 Offset: 0x18B2170 VA: 0x1818B3B70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x18BBE00 Offset: 0x18BA400 VA: 0x1818BBE00
	private static int wcslen(char* ptr) { }

	// RVA: 0x18B3FF0 Offset: 0x18B25F0 VA: 0x1818B3FF0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x18B3DF0 Offset: 0x18B23F0 VA: 0x1818B3DF0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	public void .ctor(char c, int count) { }

	// RVA: 0x18B1F60 Offset: 0x18B0560 VA: 0x1818B1F60
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x18B1AD0 Offset: 0x18B00D0 VA: 0x1818B1AD0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x18B2170 Offset: 0x18B0770 VA: 0x1818B2170
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B2060 Offset: 0x18B0660 VA: 0x1818B2060
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B1E00 Offset: 0x18B0400 VA: 0x1818B1E00
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B19B0 Offset: 0x18AFFB0 VA: 0x1818B19B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x18B14E0 Offset: 0x18AFAE0 VA: 0x1818B14E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x18B1360 Offset: 0x18AF960 VA: 0x1818B1360 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x18B12A0 Offset: 0x18AF8A0 VA: 0x1818B12A0 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x18B1220 Offset: 0x18AF820 VA: 0x1818B1220
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x18B1260 Offset: 0x18AF860 VA: 0x1818B1260
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B3050 Offset: 0x18B1650 VA: 0x1818B3050
	public bool Contains(string value) { }

	// RVA: 0x18B44B0 Offset: 0x18B2AB0 VA: 0x1818B44B0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B41B0 Offset: 0x18B27B0 VA: 0x1818B41B0
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4180 Offset: 0x18B2780 VA: 0x1818B4180
	internal bool EndsWith(char value) { }

	// RVA: 0x18B6100 Offset: 0x18B4700 VA: 0x1818B6100
	public int IndexOf(char value) { }

	// RVA: 0x18B6150 Offset: 0x18B4750 VA: 0x1818B6150
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x18B5B20 Offset: 0x18B4120 VA: 0x1818B5B20
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x18B5B40 Offset: 0x18B4140 VA: 0x1818B5B40
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B6330 Offset: 0x18B4930 VA: 0x1818B6330
	public int IndexOf(string value) { }

	// RVA: 0x18B6170 Offset: 0x18B4770 VA: 0x1818B6170
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x18B68A0 Offset: 0x18B4EA0 VA: 0x1818B68A0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B6120 Offset: 0x18B4720 VA: 0x1818B6120
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x18B64D0 Offset: 0x18B4AD0 VA: 0x1818B64D0
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B8220 Offset: 0x18B6820 VA: 0x1818B8220
	public int LastIndexOf(char value) { }

	// RVA: 0x18B8270 Offset: 0x18B6870 VA: 0x1818B8270
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x18B7CC0 Offset: 0x18B62C0 VA: 0x1818B7CC0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x18B7CE0 Offset: 0x18B62E0 VA: 0x1818B7CE0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B8290 Offset: 0x18B6890 VA: 0x1818B8290
	public int LastIndexOf(string value) { }

	// RVA: 0x18B8240 Offset: 0x18B6840 VA: 0x1818B8240
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B7E10 Offset: 0x18B6410 VA: 0x1818B7E10
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B89D0 Offset: 0x18B6FD0 VA: 0x1818B89D0
	public string PadLeft(int totalWidth) { }

	// RVA: 0x18B89F0 Offset: 0x18B6FF0 VA: 0x1818B89F0
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x18B8A30 Offset: 0x18B7030 VA: 0x1818B8A30
	public string PadRight(int totalWidth) { }

	// RVA: 0x18B8A10 Offset: 0x18B7010 VA: 0x1818B8A10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x18B9DB0 Offset: 0x18B83B0 VA: 0x1818B9DB0
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18B9E30 Offset: 0x18B8430 VA: 0x1818B9E30
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18BABE0 Offset: 0x18B91E0 VA: 0x1818BABE0
	public string ToLower() { }

	// RVA: 0x18BACD0 Offset: 0x18B92D0 VA: 0x1818BACD0
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x18BAAF0 Offset: 0x18B90F0 VA: 0x1818BAAF0
	public string ToLowerInvariant() { }

	// RVA: 0x18BAE60 Offset: 0x18B9460 VA: 0x1818BAE60
	public string ToUpper() { }

	// RVA: 0x18BAF50 Offset: 0x18B9550 VA: 0x1818BAF50
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x18BAD70 Offset: 0x18B9370 VA: 0x1818BAD70
	public string ToUpperInvariant() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 5
	public object Clone() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x18BB960 Offset: 0x18B9F60 VA: 0x1818BB960
	public string Trim() { }

	// RVA: 0x18BB370 Offset: 0x18B9970 VA: 0x1818BB370
	private string TrimHelper(int trimType) { }

	// RVA: 0x18BB160 Offset: 0x18B9760 VA: 0x1818BB160
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x18B3AD0 Offset: 0x18B20D0 VA: 0x1818B3AD0
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x18B68D0 Offset: 0x18B4ED0 VA: 0x1818B68D0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x18B95F0 Offset: 0x18B7BF0 VA: 0x1818B95F0
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x18B9740 Offset: 0x18B7D40 VA: 0x1818B9740
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x18B8A50 Offset: 0x18B7050 VA: 0x1818B8A50
	public string Remove(int startIndex, int count) { }

	// RVA: 0x18B8C10 Offset: 0x18B7210 VA: 0x1818B8C10
	public string Remove(int startIndex) { }

	// RVA: 0x18B4FD0 Offset: 0x18B35D0 VA: 0x1818B4FD0
	public static string Format(string format, object arg0) { }

	// RVA: 0x18B50E0 Offset: 0x18B36E0 VA: 0x1818B50E0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x18B51F0 Offset: 0x18B37F0 VA: 0x1818B51F0
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B5550 Offset: 0x18B3B50 VA: 0x1818B5550
	public static string Format(string format, object[] args) { }

	// RVA: 0x18B5300 Offset: 0x18B3900 VA: 0x1818B5300
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x18B5420 Offset: 0x18B3A20 VA: 0x1818B5420
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x18B56D0 Offset: 0x18B3CD0 VA: 0x1818B56D0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B5810 Offset: 0x18B3E10 VA: 0x1818B5810
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x18B4EF0 Offset: 0x18B34F0 VA: 0x1818B4EF0
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x18B3400 Offset: 0x18B1A00 VA: 0x1818B3400
	public static string Copy(string str) { }

	// RVA: 0x18B2620 Offset: 0x18B0C20 VA: 0x1818B2620
	public static string Concat(object arg0) { }

	// RVA: 0x18B2A80 Offset: 0x18B1080 VA: 0x1818B2A80
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x18B2530 Offset: 0x18B0B30 VA: 0x1818B2530
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x18B2840 Offset: 0x18B0E40 VA: 0x1818B2840
	public static string Concat(object[] args) { }

	// RVA: 0x18B2680 Offset: 0x18B0C80 VA: 0x1818B2680
	public static string Concat(string str0, string str1) { }

	// RVA: 0x18B2E10 Offset: 0x18B1410 VA: 0x1818B2E10
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x18B2B30 Offset: 0x18B1130 VA: 0x1818B2B30
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x18B2250 Offset: 0x18B0850 VA: 0x1818B2250
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x18B2380 Offset: 0x18B0980 VA: 0x1818B2380
	public static string Concat(string[] values) { }

	// RVA: 0x150F9C0 Offset: 0x150DFC0 VA: 0x18150F9C0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x18BA3C0 Offset: 0x18B89C0 VA: 0x1818BA3C0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18BA4A0 Offset: 0x18B8AA0 VA: 0x1818BA4A0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x18BA7C0 Offset: 0x18B8DC0 VA: 0x1818BA7C0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x18BA430 Offset: 0x18B8A30 VA: 0x1818BA430 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x18BA670 Offset: 0x18B8C70 VA: 0x1818BA670 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x18BA920 Offset: 0x18B8F20 VA: 0x1818BA920 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18BA6E0 Offset: 0x18B8CE0 VA: 0x1818BA6E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x18BA990 Offset: 0x18B8F90 VA: 0x1818BA990 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x18BA750 Offset: 0x18B8D50 VA: 0x1818BA750 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x18BAA00 Offset: 0x18B9000 VA: 0x1818BAA00 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x18BA830 Offset: 0x18B8E30 VA: 0x1818BA830 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x18BA600 Offset: 0x18B8C00 VA: 0x1818BA600 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x18BA580 Offset: 0x18B8B80 VA: 0x1818BA580 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x18BA510 Offset: 0x18B8B10 VA: 0x1818BA510 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x18BA8A0 Offset: 0x18B8EA0 VA: 0x1818BA8A0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18BA300 Offset: 0x18B8900 VA: 0x1818BA300 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x18BA360 Offset: 0x18B8960 VA: 0x1818BA360 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Length() { }

	// RVA: 0x18B10A0 Offset: 0x18AF6A0 VA: 0x1818B10A0
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x18B5FB0 Offset: 0x18B45B0 VA: 0x1818B5FB0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B5D60 Offset: 0x18B4360 VA: 0x1818B5D60
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B5E60 Offset: 0x18B4460 VA: 0x1818B5E60
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x18B5B60 Offset: 0x18B4160 VA: 0x1818B5B60
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B59F0 Offset: 0x18B3FF0 VA: 0x1818B59F0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B82C0 Offset: 0x18B68C0 VA: 0x1818B82C0
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B7D00 Offset: 0x18B6300 VA: 0x1818B7D00
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B7AC0 Offset: 0x18B60C0 VA: 0x1818B7AC0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B7A00 Offset: 0x18B6000 VA: 0x1818B7A00
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18BBC40 Offset: 0x18BA240 VA: 0x1818BBC40
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x18B8E50 Offset: 0x18B7450 VA: 0x1818B8E50
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x18B8FA0 Offset: 0x18B75A0 VA: 0x1818B8FA0
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x18B90A0 Offset: 0x18B76A0 VA: 0x1818B90A0
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x18B8CF0 Offset: 0x18B72F0 VA: 0x1818B8CF0
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x18B8810 Offset: 0x18B6E10 VA: 0x1818B8810
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x18B9D60 Offset: 0x18B8360 VA: 0x1818B9D60
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x18B70B0 Offset: 0x18B56B0 VA: 0x1818B70B0
	internal bool IsAscii() { }

	// RVA: 0x18B0DA0 Offset: 0x18AF3A0 VA: 0x1818B0DA0
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x18BBB50 Offset: 0x18BA150 VA: 0x1818BBB50
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x18BBB40 Offset: 0x18BA140 VA: 0x1818BBB40
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB9C0 Offset: 0x18B9FC0 VA: 0x1818BB9C0
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x18BB980 Offset: 0x18B9F80 VA: 0x1818BB980
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x18BB990 Offset: 0x18B9F90 VA: 0x1818BB990
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x18BB9A0 Offset: 0x18B9FA0 VA: 0x1818BB9A0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x18BB9B0 Offset: 0x18B9FB0 VA: 0x1818BB9B0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x18BBB00 Offset: 0x18BA100 VA: 0x1818BBB00
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBB10 Offset: 0x18BA110 VA: 0x1818BBB10
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBB20 Offset: 0x18BA120 VA: 0x1818BBB20
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBB30 Offset: 0x18BA130 VA: 0x1818BBB30
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x18B39D0 Offset: 0x18B1FD0 VA: 0x1818B39D0
	private string CreateString(sbyte* value) { }

	// RVA: 0x18B3740 Offset: 0x18B1D40 VA: 0x1818B3740
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x18B39C0 Offset: 0x18B1FC0 VA: 0x1818B39C0
	private string CreateString(char* value) { }

	// RVA: 0x18B3AB0 Offset: 0x18B20B0 VA: 0x1818B3AB0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x18B3AC0 Offset: 0x18B20C0 VA: 0x1818B3AC0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x18B3680 Offset: 0x18B1C80 VA: 0x1818B3680
	private string CreateString(char[] val) { }

	// RVA: 0x18B35A0 Offset: 0x18B1BA0 VA: 0x1818B35A0
	private string CreateString(char c, int count) { }

	// RVA: 0x18B3760 Offset: 0x18B1D60 VA: 0x1818B3760
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

