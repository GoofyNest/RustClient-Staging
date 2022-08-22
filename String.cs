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

	// RVA: 0x18B6E30 Offset: 0x18B5430 VA: 0x1818B6E30
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B71D0 Offset: 0x18B57D0 VA: 0x1818B71D0
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9170 Offset: 0xED7770 VA: 0x180ED9170
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B6B80 Offset: 0x18B5180 VA: 0x1818B6B80
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x18B6EC0 Offset: 0x18B54C0 VA: 0x1818B6EC0
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x18B0940 Offset: 0x18AEF40 VA: 0x1818B0940
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B3E60 Offset: 0x18B2460 VA: 0x1818B3E60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x18B0790 Offset: 0x18AED90 VA: 0x1818B0790
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4280 Offset: 0x18B2880 VA: 0x1818B4280 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B4440 Offset: 0x18B2A40 VA: 0x1818B4440 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x18B44E0 Offset: 0x18B2AE0 VA: 0x1818B44E0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x18B4410 Offset: 0x18B2A10 VA: 0x1818B4410
	public static bool Equals(string a, string b) { }

	// RVA: 0x18B3F70 Offset: 0x18B2570 VA: 0x1818B3F70
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x18B4410 Offset: 0x18B2A10 VA: 0x1818B4410
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x18BB760 Offset: 0x18B9D60 VA: 0x1818BB760
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x18BB430 Offset: 0x18B9A30 VA: 0x1818BB430
	public char get_Chars(int index) { }

	// RVA: 0x18B2BA0 Offset: 0x18B11A0 VA: 0x1818B2BA0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x18BA410 Offset: 0x18B8A10 VA: 0x1818BA410
	public char[] ToCharArray() { }

	// RVA: 0x10109F0 Offset: 0x100EFF0 VA: 0x1810109F0
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x18B6A80 Offset: 0x18B5080 VA: 0x1818B6A80
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5330 Offset: 0x18B3930 VA: 0x1818B5330 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x18B5330 Offset: 0x18B3930 VA: 0x1818B5330
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x18B9430 Offset: 0x18B7A30 VA: 0x1818B9430
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9450 Offset: 0x18B7A50 VA: 0x1818B9450
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B91E0 Offset: 0x18B77E0 VA: 0x1818B91E0
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9410 Offset: 0x18B7A10 VA: 0x1818B9410
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B9470 Offset: 0x18B7A70 VA: 0x1818B9470
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x18B63E0 Offset: 0x18B49E0 VA: 0x1818B63E0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B6690 Offset: 0x18B4C90 VA: 0x1818B6690
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B7DA0 Offset: 0x18B63A0 VA: 0x1818B7DA0
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x18B7F40 Offset: 0x18B6540 VA: 0x1818B7F40
	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	// RVA: 0x18B9AC0 Offset: 0x18B80C0 VA: 0x1818B9AC0
	public string Substring(int startIndex) { }

	// RVA: 0x18B9AD0 Offset: 0x18B80D0 VA: 0x1818B9AD0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x18B69E0 Offset: 0x18B4FE0 VA: 0x1818B69E0
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x18BB100 Offset: 0x18B9700 VA: 0x1818BB100
	public string Trim(char[] trimChars) { }

	// RVA: 0x18BAFD0 Offset: 0x18B95D0 VA: 0x1818BAFD0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x18BA990 Offset: 0x18B8F90 VA: 0x1818BA990
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x18B2E50 Offset: 0x18B1450 VA: 0x1818B2E50
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x18B8100 Offset: 0x18B6700 VA: 0x1818B8100
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x18B47E0 Offset: 0x18B2DE0 VA: 0x1818B47E0
	internal static string FastAllocateString(int length) { }

	// RVA: 0x18B47F0 Offset: 0x18B2DF0 VA: 0x1818B47F0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(char[] value) { }

	// RVA: 0x18BB800 Offset: 0x18B9E00 VA: 0x1818BB800
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x18B36F0 Offset: 0x18B1CF0 VA: 0x1818B36F0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x18B3510 Offset: 0x18B1B10 VA: 0x1818B3510
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x18BB7A0 Offset: 0x18B9DA0 VA: 0x1818BB7A0
	private static int wcslen(char* ptr) { }

	// RVA: 0x18B3990 Offset: 0x18B1F90 VA: 0x1818B3990
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x18B3790 Offset: 0x18B1D90 VA: 0x1818B3790
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x18BB310 Offset: 0x18B9910 VA: 0x1818BB310
	public void .ctor(char c, int count) { }

	// RVA: 0x18B1900 Offset: 0x18AFF00 VA: 0x1818B1900
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x18B1470 Offset: 0x18AFA70 VA: 0x1818B1470
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x18B1B10 Offset: 0x18B0110 VA: 0x1818B1B10
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B1A00 Offset: 0x18B0000 VA: 0x1818B1A00
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B17A0 Offset: 0x18AFDA0 VA: 0x1818B17A0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18B1350 Offset: 0x18AF950 VA: 0x1818B1350
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x18B0E80 Offset: 0x18AF480 VA: 0x1818B0E80
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x18B0D00 Offset: 0x18AF300 VA: 0x1818B0D00 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x18B0C40 Offset: 0x18AF240 VA: 0x1818B0C40 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x18B0BC0 Offset: 0x18AF1C0 VA: 0x1818B0BC0
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x18B0C00 Offset: 0x18AF200 VA: 0x1818B0C00
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18B29F0 Offset: 0x18B0FF0 VA: 0x1818B29F0
	public bool Contains(string value) { }

	// RVA: 0x18B3E50 Offset: 0x18B2450 VA: 0x1818B3E50
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B3B50 Offset: 0x18B2150 VA: 0x1818B3B50
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18B3B20 Offset: 0x18B2120 VA: 0x1818B3B20
	internal bool EndsWith(char value) { }

	// RVA: 0x18B5AA0 Offset: 0x18B40A0 VA: 0x1818B5AA0
	public int IndexOf(char value) { }

	// RVA: 0x18B5AF0 Offset: 0x18B40F0 VA: 0x1818B5AF0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x18B54C0 Offset: 0x18B3AC0 VA: 0x1818B54C0
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x18B54E0 Offset: 0x18B3AE0 VA: 0x1818B54E0
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B5CD0 Offset: 0x18B42D0 VA: 0x1818B5CD0
	public int IndexOf(string value) { }

	// RVA: 0x18B5B10 Offset: 0x18B4110 VA: 0x1818B5B10
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x18B6240 Offset: 0x18B4840 VA: 0x1818B6240
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B5AC0 Offset: 0x18B40C0 VA: 0x1818B5AC0
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x18B5E70 Offset: 0x18B4470 VA: 0x1818B5E70
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B7BC0 Offset: 0x18B61C0 VA: 0x1818B7BC0
	public int LastIndexOf(char value) { }

	// RVA: 0x18B7C10 Offset: 0x18B6210 VA: 0x1818B7C10
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x18B7660 Offset: 0x18B5C60 VA: 0x1818B7660
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x18B7680 Offset: 0x18B5C80 VA: 0x1818B7680
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B7C30 Offset: 0x18B6230 VA: 0x1818B7C30
	public int LastIndexOf(string value) { }

	// RVA: 0x18B7BE0 Offset: 0x18B61E0 VA: 0x1818B7BE0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B77B0 Offset: 0x18B5DB0 VA: 0x1818B77B0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B8370 Offset: 0x18B6970 VA: 0x1818B8370
	public string PadLeft(int totalWidth) { }

	// RVA: 0x18B8390 Offset: 0x18B6990 VA: 0x1818B8390
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x18B83D0 Offset: 0x18B69D0 VA: 0x1818B83D0
	public string PadRight(int totalWidth) { }

	// RVA: 0x18B83B0 Offset: 0x18B69B0 VA: 0x1818B83B0
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x18B9750 Offset: 0x18B7D50 VA: 0x1818B9750
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18B97D0 Offset: 0x18B7DD0 VA: 0x1818B97D0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18BA580 Offset: 0x18B8B80 VA: 0x1818BA580
	public string ToLower() { }

	// RVA: 0x18BA670 Offset: 0x18B8C70 VA: 0x1818BA670
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x18BA490 Offset: 0x18B8A90 VA: 0x1818BA490
	public string ToLowerInvariant() { }

	// RVA: 0x18BA800 Offset: 0x18B8E00 VA: 0x1818BA800
	public string ToUpper() { }

	// RVA: 0x18BA8F0 Offset: 0x18B8EF0 VA: 0x1818BA8F0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x18BA710 Offset: 0x18B8D10 VA: 0x1818BA710
	public string ToUpperInvariant() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 3
	public override string ToString() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 5
	public object Clone() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x18BB300 Offset: 0x18B9900 VA: 0x1818BB300
	public string Trim() { }

	// RVA: 0x18BAD10 Offset: 0x18B9310 VA: 0x1818BAD10
	private string TrimHelper(int trimType) { }

	// RVA: 0x18BAB00 Offset: 0x18B9100 VA: 0x1818BAB00
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x18B3470 Offset: 0x18B1A70 VA: 0x1818B3470
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x18B6270 Offset: 0x18B4870 VA: 0x1818B6270
	public string Insert(int startIndex, string value) { }

	// RVA: 0x18B8F90 Offset: 0x18B7590 VA: 0x1818B8F90
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x18B90E0 Offset: 0x18B76E0 VA: 0x1818B90E0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x18B83F0 Offset: 0x18B69F0 VA: 0x1818B83F0
	public string Remove(int startIndex, int count) { }

	// RVA: 0x18B85B0 Offset: 0x18B6BB0 VA: 0x1818B85B0
	public string Remove(int startIndex) { }

	// RVA: 0x18B4970 Offset: 0x18B2F70 VA: 0x1818B4970
	public static string Format(string format, object arg0) { }

	// RVA: 0x18B4A80 Offset: 0x18B3080 VA: 0x1818B4A80
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x18B4B90 Offset: 0x18B3190 VA: 0x1818B4B90
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B4EF0 Offset: 0x18B34F0 VA: 0x1818B4EF0
	public static string Format(string format, object[] args) { }

	// RVA: 0x18B4CA0 Offset: 0x18B32A0 VA: 0x1818B4CA0
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x18B4DC0 Offset: 0x18B33C0 VA: 0x1818B4DC0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x18B5070 Offset: 0x18B3670 VA: 0x1818B5070
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B51B0 Offset: 0x18B37B0 VA: 0x1818B51B0
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x18B4890 Offset: 0x18B2E90 VA: 0x1818B4890
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x18B2DA0 Offset: 0x18B13A0 VA: 0x1818B2DA0
	public static string Copy(string str) { }

	// RVA: 0x18B1FC0 Offset: 0x18B05C0 VA: 0x1818B1FC0
	public static string Concat(object arg0) { }

	// RVA: 0x18B2420 Offset: 0x18B0A20 VA: 0x1818B2420
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x18B1ED0 Offset: 0x18B04D0 VA: 0x1818B1ED0
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x18B21E0 Offset: 0x18B07E0 VA: 0x1818B21E0
	public static string Concat(object[] args) { }

	// RVA: 0x18B2020 Offset: 0x18B0620 VA: 0x1818B2020
	public static string Concat(string str0, string str1) { }

	// RVA: 0x18B27B0 Offset: 0x18B0DB0 VA: 0x1818B27B0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x18B24D0 Offset: 0x18B0AD0 VA: 0x1818B24D0
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x18B1BF0 Offset: 0x18B01F0 VA: 0x1818B1BF0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x18B1D20 Offset: 0x18B0320 VA: 0x1818B1D20
	public static string Concat(string[] values) { }

	// RVA: 0x150ED50 Offset: 0x150D350 VA: 0x18150ED50 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x18B9D60 Offset: 0x18B8360 VA: 0x1818B9D60 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18B9E40 Offset: 0x18B8440 VA: 0x1818B9E40 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x18BA160 Offset: 0x18B8760 VA: 0x1818BA160 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x18B9DD0 Offset: 0x18B83D0 VA: 0x1818B9DD0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x18BA010 Offset: 0x18B8610 VA: 0x1818BA010 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x18BA2C0 Offset: 0x18B88C0 VA: 0x1818BA2C0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18BA080 Offset: 0x18B8680 VA: 0x1818BA080 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x18BA330 Offset: 0x18B8930 VA: 0x1818BA330 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x18BA0F0 Offset: 0x18B86F0 VA: 0x1818BA0F0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x18BA3A0 Offset: 0x18B89A0 VA: 0x1818BA3A0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x18BA1D0 Offset: 0x18B87D0 VA: 0x1818BA1D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x18B9FA0 Offset: 0x18B85A0 VA: 0x1818B9FA0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x18B9F20 Offset: 0x18B8520 VA: 0x1818B9F20 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x18B9EB0 Offset: 0x18B84B0 VA: 0x1818B9EB0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x18BA240 Offset: 0x18B8840 VA: 0x1818BA240 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18B9CA0 Offset: 0x18B82A0 VA: 0x1818B9CA0 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x18B9D00 Offset: 0x18B8300 VA: 0x1818B9D00 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Length() { }

	// RVA: 0x18B0A40 Offset: 0x18AF040 VA: 0x1818B0A40
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x18B5950 Offset: 0x18B3F50 VA: 0x1818B5950
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B5700 Offset: 0x18B3D00 VA: 0x1818B5700
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B5800 Offset: 0x18B3E00 VA: 0x1818B5800
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x18B5500 Offset: 0x18B3B00 VA: 0x1818B5500
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B5390 Offset: 0x18B3990 VA: 0x1818B5390
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B7C60 Offset: 0x18B6260 VA: 0x1818B7C60
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B76A0 Offset: 0x18B5CA0 VA: 0x1818B76A0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B7460 Offset: 0x18B5A60 VA: 0x1818B7460
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B73A0 Offset: 0x18B59A0 VA: 0x1818B73A0
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18BB5E0 Offset: 0x18B9BE0 VA: 0x1818BB5E0
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x18B87F0 Offset: 0x18B6DF0 VA: 0x1818B87F0
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x18B8940 Offset: 0x18B6F40 VA: 0x1818B8940
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x18B8A40 Offset: 0x18B7040 VA: 0x1818B8A40
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x18B8690 Offset: 0x18B6C90 VA: 0x1818B8690
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x18B81B0 Offset: 0x18B67B0 VA: 0x1818B81B0
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x18B9700 Offset: 0x18B7D00 VA: 0x1818B9700
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x18B6A50 Offset: 0x18B5050 VA: 0x1818B6A50
	internal bool IsAscii() { }

	// RVA: 0x18B0740 Offset: 0x18AED40 VA: 0x1818B0740
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x18BB4F0 Offset: 0x18B9AF0 VA: 0x1818BB4F0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x18BB4E0 Offset: 0x18B9AE0 VA: 0x1818BB4E0
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB360 Offset: 0x18B9960 VA: 0x1818BB360
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x18BB320 Offset: 0x18B9920 VA: 0x1818BB320
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x18BB330 Offset: 0x18B9930 VA: 0x1818BB330
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x18BB340 Offset: 0x18B9940 VA: 0x1818BB340
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x18BB350 Offset: 0x18B9950 VA: 0x1818BB350
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x18BB4A0 Offset: 0x18B9AA0 VA: 0x1818BB4A0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB4B0 Offset: 0x18B9AB0 VA: 0x1818BB4B0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB4C0 Offset: 0x18B9AC0 VA: 0x1818BB4C0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x18BB4D0 Offset: 0x18B9AD0 VA: 0x1818BB4D0
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x18B3370 Offset: 0x18B1970 VA: 0x1818B3370
	private string CreateString(sbyte* value) { }

	// RVA: 0x18B30E0 Offset: 0x18B16E0 VA: 0x1818B30E0
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x18B3360 Offset: 0x18B1960 VA: 0x1818B3360
	private string CreateString(char* value) { }

	// RVA: 0x18B3450 Offset: 0x18B1A50 VA: 0x1818B3450
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x18B3460 Offset: 0x18B1A60 VA: 0x1818B3460
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x18B3020 Offset: 0x18B1620 VA: 0x1818B3020
	private string CreateString(char[] val) { }

	// RVA: 0x18B2F40 Offset: 0x18B1540 VA: 0x1818B2F40
	private string CreateString(char c, int count) { }

	// RVA: 0x18B3100 Offset: 0x18B1700 VA: 0x1818B3100
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

