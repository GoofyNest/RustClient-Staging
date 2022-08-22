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

	// RVA: 0x18B7710 Offset: 0x18B5D10 VA: 0x1818B7710
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B7AB0 Offset: 0x18B60B0 VA: 0x1818B7AB0
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED86C0 Offset: 0xED6CC0 VA: 0x180ED86C0
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B7460 Offset: 0x18B5A60 VA: 0x1818B7460
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x18B77A0 Offset: 0x18B5DA0 VA: 0x1818B77A0
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x18B1220 Offset: 0x18AF820 VA: 0x1818B1220
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4740 Offset: 0x18B2D40 VA: 0x1818B4740
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x18B1070 Offset: 0x18AF670 VA: 0x1818B1070
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4B60 Offset: 0x18B3160 VA: 0x1818B4B60 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4D20 Offset: 0x18B3320 VA: 0x1818B4D20 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x18B4DC0 Offset: 0x18B33C0 VA: 0x1818B4DC0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4CF0 Offset: 0x18B32F0 VA: 0x1818B4CF0
	public static bool Equals(string a, string b) { }

	// RVA: 0x18B4850 Offset: 0x18B2E50 VA: 0x1818B4850
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x18B4CF0 Offset: 0x18B32F0 VA: 0x1818B4CF0
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x18BC040 Offset: 0x18BA640 VA: 0x1818BC040
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x18BBD10 Offset: 0x18BA310 VA: 0x1818BBD10
	public char get_Chars(int index) { }

	// RVA: 0x18B3480 Offset: 0x18B1A80 VA: 0x1818B3480
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x18BACF0 Offset: 0x18B92F0 VA: 0x1818BACF0
	public char[] ToCharArray() { }

	// RVA: 0x100FF50 Offset: 0x100E550 VA: 0x18100FF50
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x18B7360 Offset: 0x18B5960 VA: 0x1818B7360
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5C10 Offset: 0x18B4210 VA: 0x1818B5C10 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5C10 Offset: 0x18B4210 VA: 0x1818B5C10
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x18B9D10 Offset: 0x18B8310 VA: 0x1818B9D10
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9D30 Offset: 0x18B8330 VA: 0x1818B9D30
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9AC0 Offset: 0x18B80C0 VA: 0x1818B9AC0
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9CF0 Offset: 0x18B82F0 VA: 0x1818B9CF0
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9D50 Offset: 0x18B8350 VA: 0x1818B9D50
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x18B6CC0 Offset: 0x18B52C0 VA: 0x1818B6CC0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B6F70 Offset: 0x18B5570 VA: 0x1818B6F70
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B8680 Offset: 0x18B6C80 VA: 0x1818B8680
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x18B8820 Offset: 0x18B6E20 VA: 0x1818B8820
	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	// RVA: 0x18BA3A0 Offset: 0x18B89A0 VA: 0x1818BA3A0
	public string Substring(int startIndex) { }

	// RVA: 0x18BA3B0 Offset: 0x18B89B0 VA: 0x1818BA3B0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x18B72C0 Offset: 0x18B58C0 VA: 0x1818B72C0
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x18BB9E0 Offset: 0x18B9FE0 VA: 0x1818BB9E0
	public string Trim(char[] trimChars) { }

	// RVA: 0x18BB8B0 Offset: 0x18B9EB0 VA: 0x1818BB8B0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x18BB270 Offset: 0x18B9870 VA: 0x1818BB270
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x18B3730 Offset: 0x18B1D30 VA: 0x1818B3730
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x18B89E0 Offset: 0x18B6FE0 VA: 0x1818B89E0
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x18B50C0 Offset: 0x18B36C0 VA: 0x1818B50C0
	internal static string FastAllocateString(int length) { }

	// RVA: 0x18B50D0 Offset: 0x18B36D0 VA: 0x1818B50D0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(char[] value) { }

	// RVA: 0x18BC0E0 Offset: 0x18BA6E0 VA: 0x1818BC0E0
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x18B3FD0 Offset: 0x18B25D0 VA: 0x1818B3FD0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x18B3DF0 Offset: 0x18B23F0 VA: 0x1818B3DF0
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x18BC080 Offset: 0x18BA680 VA: 0x1818BC080
	private static int wcslen(char* ptr) { }

	// RVA: 0x18B4270 Offset: 0x18B2870 VA: 0x1818B4270
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x18B4070 Offset: 0x18B2670 VA: 0x1818B4070
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x18BBBF0 Offset: 0x18BA1F0 VA: 0x1818BBBF0
	public void .ctor(char c, int count) { }

	// RVA: 0x18B21E0 Offset: 0x18B07E0 VA: 0x1818B21E0
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x18B1D50 Offset: 0x18B0350 VA: 0x1818B1D50
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x18B23F0 Offset: 0x18B09F0 VA: 0x1818B23F0
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B22E0 Offset: 0x18B08E0 VA: 0x1818B22E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B2080 Offset: 0x18B0680 VA: 0x1818B2080
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B1C30 Offset: 0x18B0230 VA: 0x1818B1C30
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x18B1760 Offset: 0x18AFD60 VA: 0x1818B1760
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x18B15E0 Offset: 0x18AFBE0 VA: 0x1818B15E0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x18B1520 Offset: 0x18AFB20 VA: 0x1818B1520 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x18B14A0 Offset: 0x18AFAA0 VA: 0x1818B14A0
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x18B14E0 Offset: 0x18AFAE0 VA: 0x1818B14E0
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B32D0 Offset: 0x18B18D0 VA: 0x1818B32D0
	public bool Contains(string value) { }

	// RVA: 0x18B4730 Offset: 0x18B2D30 VA: 0x1818B4730
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B4430 Offset: 0x18B2A30 VA: 0x1818B4430
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4400 Offset: 0x18B2A00 VA: 0x1818B4400
	internal bool EndsWith(char value) { }

	// RVA: 0x18B6380 Offset: 0x18B4980 VA: 0x1818B6380
	public int IndexOf(char value) { }

	// RVA: 0x18B63D0 Offset: 0x18B49D0 VA: 0x1818B63D0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x18B5DA0 Offset: 0x18B43A0 VA: 0x1818B5DA0
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x18B5DC0 Offset: 0x18B43C0 VA: 0x1818B5DC0
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B65B0 Offset: 0x18B4BB0 VA: 0x1818B65B0
	public int IndexOf(string value) { }

	// RVA: 0x18B63F0 Offset: 0x18B49F0 VA: 0x1818B63F0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x18B6B20 Offset: 0x18B5120 VA: 0x1818B6B20
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B63A0 Offset: 0x18B49A0 VA: 0x1818B63A0
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x18B6750 Offset: 0x18B4D50 VA: 0x1818B6750
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B84A0 Offset: 0x18B6AA0 VA: 0x1818B84A0
	public int LastIndexOf(char value) { }

	// RVA: 0x18B84F0 Offset: 0x18B6AF0 VA: 0x1818B84F0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x18B7F40 Offset: 0x18B6540 VA: 0x1818B7F40
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x18B7F60 Offset: 0x18B6560 VA: 0x1818B7F60
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B8510 Offset: 0x18B6B10 VA: 0x1818B8510
	public int LastIndexOf(string value) { }

	// RVA: 0x18B84C0 Offset: 0x18B6AC0 VA: 0x1818B84C0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B8090 Offset: 0x18B6690 VA: 0x1818B8090
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B8C50 Offset: 0x18B7250 VA: 0x1818B8C50
	public string PadLeft(int totalWidth) { }

	// RVA: 0x18B8C70 Offset: 0x18B7270 VA: 0x1818B8C70
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x18B8CB0 Offset: 0x18B72B0 VA: 0x1818B8CB0
	public string PadRight(int totalWidth) { }

	// RVA: 0x18B8C90 Offset: 0x18B7290 VA: 0x1818B8C90
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x18BA030 Offset: 0x18B8630 VA: 0x1818BA030
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18BA0B0 Offset: 0x18B86B0 VA: 0x1818BA0B0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18BAE60 Offset: 0x18B9460 VA: 0x1818BAE60
	public string ToLower() { }

	// RVA: 0x18BAF50 Offset: 0x18B9550 VA: 0x1818BAF50
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x18BAD70 Offset: 0x18B9370 VA: 0x1818BAD70
	public string ToLowerInvariant() { }

	// RVA: 0x18BB0E0 Offset: 0x18B96E0 VA: 0x1818BB0E0
	public string ToUpper() { }

	// RVA: 0x18BB1D0 Offset: 0x18B97D0 VA: 0x1818BB1D0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x18BAFF0 Offset: 0x18B95F0 VA: 0x1818BAFF0
	public string ToUpperInvariant() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 5
	public object Clone() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x18BBBE0 Offset: 0x18BA1E0 VA: 0x1818BBBE0
	public string Trim() { }

	// RVA: 0x18BB5F0 Offset: 0x18B9BF0 VA: 0x1818BB5F0
	private string TrimHelper(int trimType) { }

	// RVA: 0x18BB3E0 Offset: 0x18B99E0 VA: 0x1818BB3E0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x18B3D50 Offset: 0x18B2350 VA: 0x1818B3D50
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x18B6B50 Offset: 0x18B5150 VA: 0x1818B6B50
	public string Insert(int startIndex, string value) { }

	// RVA: 0x18B9870 Offset: 0x18B7E70 VA: 0x1818B9870
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x18B99C0 Offset: 0x18B7FC0 VA: 0x1818B99C0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x18B8CD0 Offset: 0x18B72D0 VA: 0x1818B8CD0
	public string Remove(int startIndex, int count) { }

	// RVA: 0x18B8E90 Offset: 0x18B7490 VA: 0x1818B8E90
	public string Remove(int startIndex) { }

	// RVA: 0x18B5250 Offset: 0x18B3850 VA: 0x1818B5250
	public static string Format(string format, object arg0) { }

	// RVA: 0x18B5360 Offset: 0x18B3960 VA: 0x1818B5360
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x18B5470 Offset: 0x18B3A70 VA: 0x1818B5470
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B57D0 Offset: 0x18B3DD0 VA: 0x1818B57D0
	public static string Format(string format, object[] args) { }

	// RVA: 0x18B5580 Offset: 0x18B3B80 VA: 0x1818B5580
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x18B56A0 Offset: 0x18B3CA0 VA: 0x1818B56A0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x18B5950 Offset: 0x18B3F50 VA: 0x1818B5950
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B5A90 Offset: 0x18B4090 VA: 0x1818B5A90
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x18B5170 Offset: 0x18B3770 VA: 0x1818B5170
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x18B3680 Offset: 0x18B1C80 VA: 0x1818B3680
	public static string Copy(string str) { }

	// RVA: 0x18B28A0 Offset: 0x18B0EA0 VA: 0x1818B28A0
	public static string Concat(object arg0) { }

	// RVA: 0x18B2D00 Offset: 0x18B1300 VA: 0x1818B2D00
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x18B27B0 Offset: 0x18B0DB0 VA: 0x1818B27B0
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x18B2AC0 Offset: 0x18B10C0 VA: 0x1818B2AC0
	public static string Concat(object[] args) { }

	// RVA: 0x18B2900 Offset: 0x18B0F00 VA: 0x1818B2900
	public static string Concat(string str0, string str1) { }

	// RVA: 0x18B3090 Offset: 0x18B1690 VA: 0x1818B3090
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x18B2DB0 Offset: 0x18B13B0 VA: 0x1818B2DB0
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x18B24D0 Offset: 0x18B0AD0 VA: 0x1818B24D0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x18B2600 Offset: 0x18B0C00 VA: 0x1818B2600
	public static string Concat(string[] values) { }

	// RVA: 0x150FC80 Offset: 0x150E280 VA: 0x18150FC80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x18BA640 Offset: 0x18B8C40 VA: 0x1818BA640 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18BA720 Offset: 0x18B8D20 VA: 0x1818BA720 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x18BAA40 Offset: 0x18B9040 VA: 0x1818BAA40 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x18BA6B0 Offset: 0x18B8CB0 VA: 0x1818BA6B0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x18BA8F0 Offset: 0x18B8EF0 VA: 0x1818BA8F0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x18BABA0 Offset: 0x18B91A0 VA: 0x1818BABA0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18BA960 Offset: 0x18B8F60 VA: 0x1818BA960 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x18BAC10 Offset: 0x18B9210 VA: 0x1818BAC10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x18BA9D0 Offset: 0x18B8FD0 VA: 0x1818BA9D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x18BAC80 Offset: 0x18B9280 VA: 0x1818BAC80 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x18BAAB0 Offset: 0x18B90B0 VA: 0x1818BAAB0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x18BA880 Offset: 0x18B8E80 VA: 0x1818BA880 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x18BA800 Offset: 0x18B8E00 VA: 0x1818BA800 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x18BA790 Offset: 0x18B8D90 VA: 0x1818BA790 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x18BAB20 Offset: 0x18B9120 VA: 0x1818BAB20 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18BA580 Offset: 0x18B8B80 VA: 0x1818BA580 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x18BA5E0 Offset: 0x18B8BE0 VA: 0x1818BA5E0 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Length() { }

	// RVA: 0x18B1320 Offset: 0x18AF920 VA: 0x1818B1320
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x18B6230 Offset: 0x18B4830 VA: 0x1818B6230
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B5FE0 Offset: 0x18B45E0 VA: 0x1818B5FE0
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B60E0 Offset: 0x18B46E0 VA: 0x1818B60E0
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x18B5DE0 Offset: 0x18B43E0 VA: 0x1818B5DE0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B5C70 Offset: 0x18B4270 VA: 0x1818B5C70
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B8540 Offset: 0x18B6B40 VA: 0x1818B8540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B7F80 Offset: 0x18B6580 VA: 0x1818B7F80
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B7D40 Offset: 0x18B6340 VA: 0x1818B7D40
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B7C80 Offset: 0x18B6280 VA: 0x1818B7C80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18BBEC0 Offset: 0x18BA4C0 VA: 0x1818BBEC0
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x18B90D0 Offset: 0x18B76D0 VA: 0x1818B90D0
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x18B9220 Offset: 0x18B7820 VA: 0x1818B9220
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x18B9320 Offset: 0x18B7920 VA: 0x1818B9320
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x18B8F70 Offset: 0x18B7570 VA: 0x1818B8F70
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x18B8A90 Offset: 0x18B7090 VA: 0x1818B8A90
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x18B9FE0 Offset: 0x18B85E0 VA: 0x1818B9FE0
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x18B7330 Offset: 0x18B5930 VA: 0x1818B7330
	internal bool IsAscii() { }

	// RVA: 0x18B1020 Offset: 0x18AF620 VA: 0x1818B1020
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x18BBDD0 Offset: 0x18BA3D0 VA: 0x1818BBDD0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x18BBDC0 Offset: 0x18BA3C0 VA: 0x1818BBDC0
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBC40 Offset: 0x18BA240 VA: 0x1818BBC40
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x18BBC00 Offset: 0x18BA200 VA: 0x1818BBC00
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x18BBC10 Offset: 0x18BA210 VA: 0x1818BBC10
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x18BBC20 Offset: 0x18BA220 VA: 0x1818BBC20
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x18BBC30 Offset: 0x18BA230 VA: 0x1818BBC30
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x18BBD80 Offset: 0x18BA380 VA: 0x1818BBD80
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBD90 Offset: 0x18BA390 VA: 0x1818BBD90
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBDA0 Offset: 0x18BA3A0 VA: 0x1818BBDA0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBDB0 Offset: 0x18BA3B0 VA: 0x1818BBDB0
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x18B3C50 Offset: 0x18B2250 VA: 0x1818B3C50
	private string CreateString(sbyte* value) { }

	// RVA: 0x18B39C0 Offset: 0x18B1FC0 VA: 0x1818B39C0
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x18B3C40 Offset: 0x18B2240 VA: 0x1818B3C40
	private string CreateString(char* value) { }

	// RVA: 0x18B3D30 Offset: 0x18B2330 VA: 0x1818B3D30
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x18B3D40 Offset: 0x18B2340 VA: 0x1818B3D40
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x18B3900 Offset: 0x18B1F00 VA: 0x1818B3900
	private string CreateString(char[] val) { }

	// RVA: 0x18B3820 Offset: 0x18B1E20 VA: 0x1818B3820
	private string CreateString(char c, int count) { }

	// RVA: 0x18B39E0 Offset: 0x18B1FE0 VA: 0x1818B39E0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

