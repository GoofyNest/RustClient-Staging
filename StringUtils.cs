internal static class StringUtils // TypeDefIndex: 5969
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18122A0 Offset: 0x18108A0 VA: 0x1818122A0
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812660 Offset: 0x1810C60 VA: 0x181812660
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812810 Offset: 0x1810E10 VA: 0x181812810
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18123F0 Offset: 0x18109F0 VA: 0x1818123F0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18121E0 Offset: 0x18107E0 VA: 0x1818121E0
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x18120F0 Offset: 0x18106F0 VA: 0x1818120F0
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x1812A20 Offset: 0x1811020 VA: 0x181812A20
	public static Nullable<int> GetLength(string value) { }

	// RVA: 0x1812DD0 Offset: 0x18113D0 VA: 0x181812DD0
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAF00 Offset: 0x15B9500 VA: 0x1815BAF00
	|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	*/

	// RVA: 0x1812B80 Offset: 0x1811180 VA: 0x181812B80
	public static string ToCamelCase(string s) { }

	// RVA: 0x1812A80 Offset: 0x1811080 VA: 0x181812A80
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1812AE0 Offset: 0x18110E0 VA: 0x181812AE0
	public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812B40 Offset: 0x1811140 VA: 0x181812B40
	public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18121A0 Offset: 0x18107A0 VA: 0x1818121A0
	public static bool EndsWith(string source, char value) { }

}

private sealed class StringUtils.<>c__DisplayClass15_0<TSource> // TypeDefIndex: 5970
{	// Fields
	public Func<TSource, string> valueSelector; // 0x0
	public string testValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-StringUtils.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65640 Offset: 0xD63C40 VA: 0x180D65640
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65690 Offset: 0xD63C90 VA: 0x180D65690
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
	*/

}

