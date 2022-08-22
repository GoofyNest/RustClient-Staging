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

	// RVA: 0x18B7450 Offset: 0x18B5A50 VA: 0x1818B7450
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B77F0 Offset: 0x18B5DF0 VA: 0x1818B77F0
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8400 Offset: 0xED6A00 VA: 0x180ED8400
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B71A0 Offset: 0x18B57A0 VA: 0x1818B71A0
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x18B74E0 Offset: 0x18B5AE0 VA: 0x1818B74E0
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x18B0F60 Offset: 0x18AF560 VA: 0x1818B0F60
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4480 Offset: 0x18B2A80 VA: 0x1818B4480
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x18B0DB0 Offset: 0x18AF3B0 VA: 0x1818B0DB0
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B48A0 Offset: 0x18B2EA0 VA: 0x1818B48A0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4A60 Offset: 0x18B3060 VA: 0x1818B4A60 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x18B4B00 Offset: 0x18B3100 VA: 0x1818B4B00
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4A30 Offset: 0x18B3030 VA: 0x1818B4A30
	public static bool Equals(string a, string b) { }

	// RVA: 0x18B4590 Offset: 0x18B2B90 VA: 0x1818B4590
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x18B4A30 Offset: 0x18B3030 VA: 0x1818B4A30
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x18BBD80 Offset: 0x18BA380 VA: 0x1818BBD80
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x18BBA50 Offset: 0x18BA050 VA: 0x1818BBA50
	public char get_Chars(int index) { }

	// RVA: 0x18B31C0 Offset: 0x18B17C0 VA: 0x1818B31C0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x18BAA30 Offset: 0x18B9030 VA: 0x1818BAA30
	public char[] ToCharArray() { }

	// RVA: 0x100FC90 Offset: 0x100E290 VA: 0x18100FC90
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x18B70A0 Offset: 0x18B56A0 VA: 0x1818B70A0
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5950 Offset: 0x18B3F50 VA: 0x1818B5950 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5950 Offset: 0x18B3F50 VA: 0x1818B5950
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x18B9A50 Offset: 0x18B8050 VA: 0x1818B9A50
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9A70 Offset: 0x18B8070 VA: 0x1818B9A70
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9800 Offset: 0x18B7E00 VA: 0x1818B9800
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9A30 Offset: 0x18B8030 VA: 0x1818B9A30
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9A90 Offset: 0x18B8090 VA: 0x1818B9A90
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x18B6A00 Offset: 0x18B5000 VA: 0x1818B6A00
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B6CB0 Offset: 0x18B52B0 VA: 0x1818B6CB0
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B83C0 Offset: 0x18B69C0 VA: 0x1818B83C0
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x18B8560 Offset: 0x18B6B60 VA: 0x1818B8560
	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	// RVA: 0x18BA0E0 Offset: 0x18B86E0 VA: 0x1818BA0E0
	public string Substring(int startIndex) { }

	// RVA: 0x18BA0F0 Offset: 0x18B86F0 VA: 0x1818BA0F0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x18B7000 Offset: 0x18B5600 VA: 0x1818B7000
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x18BB720 Offset: 0x18B9D20 VA: 0x1818BB720
	public string Trim(char[] trimChars) { }

	// RVA: 0x18BB5F0 Offset: 0x18B9BF0 VA: 0x1818BB5F0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x18BAFB0 Offset: 0x18B95B0 VA: 0x1818BAFB0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x18B3470 Offset: 0x18B1A70 VA: 0x1818B3470
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x18B8720 Offset: 0x18B6D20 VA: 0x1818B8720
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x18B4E00 Offset: 0x18B3400 VA: 0x1818B4E00
	internal static string FastAllocateString(int length) { }

	// RVA: 0x18B4E10 Offset: 0x18B3410 VA: 0x1818B4E10
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(char[] value) { }

	// RVA: 0x18BBE20 Offset: 0x18BA420 VA: 0x1818BBE20
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x18B3D10 Offset: 0x18B2310 VA: 0x1818B3D10
	private string CtorCharArray(char[] value) { }

	// RVA: 0x18B3B30 Offset: 0x18B2130 VA: 0x1818B3B30
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x18BBDC0 Offset: 0x18BA3C0 VA: 0x1818BBDC0
	private static int wcslen(char* ptr) { }

	// RVA: 0x18B3FB0 Offset: 0x18B25B0 VA: 0x1818B3FB0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x18B3DB0 Offset: 0x18B23B0 VA: 0x1818B3DB0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x18BB930 Offset: 0x18B9F30 VA: 0x1818BB930
	public void .ctor(char c, int count) { }

	// RVA: 0x18B1F20 Offset: 0x18B0520 VA: 0x1818B1F20
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x18B1A90 Offset: 0x18B0090 VA: 0x1818B1A90
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x18B2130 Offset: 0x18B0730 VA: 0x1818B2130
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B2020 Offset: 0x18B0620 VA: 0x1818B2020
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B1DC0 Offset: 0x18B03C0 VA: 0x1818B1DC0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B1970 Offset: 0x18AFF70 VA: 0x1818B1970
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x18B14A0 Offset: 0x18AFAA0 VA: 0x1818B14A0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x18B1320 Offset: 0x18AF920 VA: 0x1818B1320 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x18B1260 Offset: 0x18AF860 VA: 0x1818B1260 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x18B11E0 Offset: 0x18AF7E0 VA: 0x1818B11E0
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x18B1220 Offset: 0x18AF820 VA: 0x1818B1220
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B3010 Offset: 0x18B1610 VA: 0x1818B3010
	public bool Contains(string value) { }

	// RVA: 0x18B4470 Offset: 0x18B2A70 VA: 0x1818B4470
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B4170 Offset: 0x18B2770 VA: 0x1818B4170
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4140 Offset: 0x18B2740 VA: 0x1818B4140
	internal bool EndsWith(char value) { }

	// RVA: 0x18B60C0 Offset: 0x18B46C0 VA: 0x1818B60C0
	public int IndexOf(char value) { }

	// RVA: 0x18B6110 Offset: 0x18B4710 VA: 0x1818B6110
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x18B5AE0 Offset: 0x18B40E0 VA: 0x1818B5AE0
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x18B5B00 Offset: 0x18B4100 VA: 0x1818B5B00
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B62F0 Offset: 0x18B48F0 VA: 0x1818B62F0
	public int IndexOf(string value) { }

	// RVA: 0x18B6130 Offset: 0x18B4730 VA: 0x1818B6130
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x18B6860 Offset: 0x18B4E60 VA: 0x1818B6860
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B60E0 Offset: 0x18B46E0 VA: 0x1818B60E0
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x18B6490 Offset: 0x18B4A90 VA: 0x1818B6490
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B81E0 Offset: 0x18B67E0 VA: 0x1818B81E0
	public int LastIndexOf(char value) { }

	// RVA: 0x18B8230 Offset: 0x18B6830 VA: 0x1818B8230
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x18B7C80 Offset: 0x18B6280 VA: 0x1818B7C80
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x18B7CA0 Offset: 0x18B62A0 VA: 0x1818B7CA0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B8250 Offset: 0x18B6850 VA: 0x1818B8250
	public int LastIndexOf(string value) { }

	// RVA: 0x18B8200 Offset: 0x18B6800 VA: 0x1818B8200
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B7DD0 Offset: 0x18B63D0 VA: 0x1818B7DD0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B8990 Offset: 0x18B6F90 VA: 0x1818B8990
	public string PadLeft(int totalWidth) { }

	// RVA: 0x18B89B0 Offset: 0x18B6FB0 VA: 0x1818B89B0
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x18B89F0 Offset: 0x18B6FF0 VA: 0x1818B89F0
	public string PadRight(int totalWidth) { }

	// RVA: 0x18B89D0 Offset: 0x18B6FD0 VA: 0x1818B89D0
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x18B9D70 Offset: 0x18B8370 VA: 0x1818B9D70
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9DF0 Offset: 0x18B83F0 VA: 0x1818B9DF0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18BABA0 Offset: 0x18B91A0 VA: 0x1818BABA0
	public string ToLower() { }

	// RVA: 0x18BAC90 Offset: 0x18B9290 VA: 0x1818BAC90
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x18BAAB0 Offset: 0x18B90B0 VA: 0x1818BAAB0
	public string ToLowerInvariant() { }

	// RVA: 0x18BAE20 Offset: 0x18B9420 VA: 0x1818BAE20
	public string ToUpper() { }

	// RVA: 0x18BAF10 Offset: 0x18B9510 VA: 0x1818BAF10
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x18BAD30 Offset: 0x18B9330 VA: 0x1818BAD30
	public string ToUpperInvariant() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 5
	public object Clone() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x18BB920 Offset: 0x18B9F20 VA: 0x1818BB920
	public string Trim() { }

	// RVA: 0x18BB330 Offset: 0x18B9930 VA: 0x1818BB330
	private string TrimHelper(int trimType) { }

	// RVA: 0x18BB120 Offset: 0x18B9720 VA: 0x1818BB120
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x18B3A90 Offset: 0x18B2090 VA: 0x1818B3A90
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x18B6890 Offset: 0x18B4E90 VA: 0x1818B6890
	public string Insert(int startIndex, string value) { }

	// RVA: 0x18B95B0 Offset: 0x18B7BB0 VA: 0x1818B95B0
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x18B9700 Offset: 0x18B7D00 VA: 0x1818B9700
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x18B8A10 Offset: 0x18B7010 VA: 0x1818B8A10
	public string Remove(int startIndex, int count) { }

	// RVA: 0x18B8BD0 Offset: 0x18B71D0 VA: 0x1818B8BD0
	public string Remove(int startIndex) { }

	// RVA: 0x18B4F90 Offset: 0x18B3590 VA: 0x1818B4F90
	public static string Format(string format, object arg0) { }

	// RVA: 0x18B50A0 Offset: 0x18B36A0 VA: 0x1818B50A0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x18B51B0 Offset: 0x18B37B0 VA: 0x1818B51B0
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B5510 Offset: 0x18B3B10 VA: 0x1818B5510
	public static string Format(string format, object[] args) { }

	// RVA: 0x18B52C0 Offset: 0x18B38C0 VA: 0x1818B52C0
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x18B53E0 Offset: 0x18B39E0 VA: 0x1818B53E0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x18B5690 Offset: 0x18B3C90 VA: 0x1818B5690
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B57D0 Offset: 0x18B3DD0 VA: 0x1818B57D0
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x18B4EB0 Offset: 0x18B34B0 VA: 0x1818B4EB0
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x18B33C0 Offset: 0x18B19C0 VA: 0x1818B33C0
	public static string Copy(string str) { }

	// RVA: 0x18B25E0 Offset: 0x18B0BE0 VA: 0x1818B25E0
	public static string Concat(object arg0) { }

	// RVA: 0x18B2A40 Offset: 0x18B1040 VA: 0x1818B2A40
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x18B24F0 Offset: 0x18B0AF0 VA: 0x1818B24F0
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x18B2800 Offset: 0x18B0E00 VA: 0x1818B2800
	public static string Concat(object[] args) { }

	// RVA: 0x18B2640 Offset: 0x18B0C40 VA: 0x1818B2640
	public static string Concat(string str0, string str1) { }

	// RVA: 0x18B2DD0 Offset: 0x18B13D0 VA: 0x1818B2DD0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x18B2AF0 Offset: 0x18B10F0 VA: 0x1818B2AF0
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x18B2210 Offset: 0x18B0810 VA: 0x1818B2210
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x18B2340 Offset: 0x18B0940 VA: 0x1818B2340
	public static string Concat(string[] values) { }

	// RVA: 0x150F9C0 Offset: 0x150DFC0 VA: 0x18150F9C0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x18BA380 Offset: 0x18B8980 VA: 0x1818BA380 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18BA460 Offset: 0x18B8A60 VA: 0x1818BA460 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x18BA780 Offset: 0x18B8D80 VA: 0x1818BA780 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x18BA3F0 Offset: 0x18B89F0 VA: 0x1818BA3F0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x18BA630 Offset: 0x18B8C30 VA: 0x1818BA630 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x18BA8E0 Offset: 0x18B8EE0 VA: 0x1818BA8E0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18BA6A0 Offset: 0x18B8CA0 VA: 0x1818BA6A0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x18BA950 Offset: 0x18B8F50 VA: 0x1818BA950 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x18BA710 Offset: 0x18B8D10 VA: 0x1818BA710 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x18BA9C0 Offset: 0x18B8FC0 VA: 0x1818BA9C0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x18BA7F0 Offset: 0x18B8DF0 VA: 0x1818BA7F0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x18BA5C0 Offset: 0x18B8BC0 VA: 0x1818BA5C0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x18BA540 Offset: 0x18B8B40 VA: 0x1818BA540 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x18BA4D0 Offset: 0x18B8AD0 VA: 0x1818BA4D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x18BA860 Offset: 0x18B8E60 VA: 0x1818BA860 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18BA2C0 Offset: 0x18B88C0 VA: 0x1818BA2C0 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x18BA320 Offset: 0x18B8920 VA: 0x1818BA320 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Length() { }

	// RVA: 0x18B1060 Offset: 0x18AF660 VA: 0x1818B1060
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x18B5F70 Offset: 0x18B4570 VA: 0x1818B5F70
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B5D20 Offset: 0x18B4320 VA: 0x1818B5D20
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B5E20 Offset: 0x18B4420 VA: 0x1818B5E20
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x18B5B20 Offset: 0x18B4120 VA: 0x1818B5B20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B59B0 Offset: 0x18B3FB0 VA: 0x1818B59B0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B8280 Offset: 0x18B6880 VA: 0x1818B8280
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B7CC0 Offset: 0x18B62C0 VA: 0x1818B7CC0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B7A80 Offset: 0x18B6080 VA: 0x1818B7A80
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B79C0 Offset: 0x18B5FC0 VA: 0x1818B79C0
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18BBC00 Offset: 0x18BA200 VA: 0x1818BBC00
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x18B8E10 Offset: 0x18B7410 VA: 0x1818B8E10
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x18B8F60 Offset: 0x18B7560 VA: 0x1818B8F60
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x18B9060 Offset: 0x18B7660 VA: 0x1818B9060
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x18B8CB0 Offset: 0x18B72B0 VA: 0x1818B8CB0
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x18B87D0 Offset: 0x18B6DD0 VA: 0x1818B87D0
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x18B9D20 Offset: 0x18B8320 VA: 0x1818B9D20
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x18B7070 Offset: 0x18B5670 VA: 0x1818B7070
	internal bool IsAscii() { }

	// RVA: 0x18B0D60 Offset: 0x18AF360 VA: 0x1818B0D60
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x18BBB10 Offset: 0x18BA110 VA: 0x1818BBB10
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x18BBB00 Offset: 0x18BA100 VA: 0x1818BBB00
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB980 Offset: 0x18B9F80 VA: 0x1818BB980
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x18BB940 Offset: 0x18B9F40 VA: 0x1818BB940
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x18BB950 Offset: 0x18B9F50 VA: 0x1818BB950
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x18BB960 Offset: 0x18B9F60 VA: 0x1818BB960
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x18BB970 Offset: 0x18B9F70 VA: 0x1818BB970
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x18BBAC0 Offset: 0x18BA0C0 VA: 0x1818BBAC0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBAD0 Offset: 0x18BA0D0 VA: 0x1818BBAD0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBAE0 Offset: 0x18BA0E0 VA: 0x1818BBAE0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x18BBAF0 Offset: 0x18BA0F0 VA: 0x1818BBAF0
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x18B3990 Offset: 0x18B1F90 VA: 0x1818B3990
	private string CreateString(sbyte* value) { }

	// RVA: 0x18B3700 Offset: 0x18B1D00 VA: 0x1818B3700
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x18B3980 Offset: 0x18B1F80 VA: 0x1818B3980
	private string CreateString(char* value) { }

	// RVA: 0x18B3A70 Offset: 0x18B2070 VA: 0x1818B3A70
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x18B3A80 Offset: 0x18B2080 VA: 0x1818B3A80
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x18B3640 Offset: 0x18B1C40 VA: 0x1818B3640
	private string CreateString(char[] val) { }

	// RVA: 0x18B3560 Offset: 0x18B1B60 VA: 0x1818B3560
	private string CreateString(char c, int count) { }

	// RVA: 0x18B3720 Offset: 0x18B1D20 VA: 0x1818B3720
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

