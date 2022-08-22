internal static class StringUtils // TypeDefIndex: 5969
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1811FE0 Offset: 0x18105E0 VA: 0x181811FE0
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18123A0 Offset: 0x18109A0 VA: 0x1818123A0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812550 Offset: 0x1810B50 VA: 0x181812550
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812130 Offset: 0x1810730 VA: 0x181812130
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1811F20 Offset: 0x1810520 VA: 0x181811F20
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x1811E30 Offset: 0x1810430 VA: 0x181811E30
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x1812760 Offset: 0x1810D60 VA: 0x181812760
	public static Nullable<int> GetLength(string value) { }

	// RVA: 0x1812B10 Offset: 0x1811110 VA: 0x181812B10
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC40 Offset: 0x15B9240 VA: 0x1815BAC40
	|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	*/

	// RVA: 0x18128C0 Offset: 0x1810EC0 VA: 0x1818128C0
	public static string ToCamelCase(string s) { }

	// RVA: 0x18127C0 Offset: 0x1810DC0 VA: 0x1818127C0
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1812820 Offset: 0x1810E20 VA: 0x181812820
	public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1812880 Offset: 0x1810E80 VA: 0x181812880
	public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1811EE0 Offset: 0x18104E0 VA: 0x181811EE0
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
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-StringUtils.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65380 Offset: 0xD63980 VA: 0x180D65380
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD653D0 Offset: 0xD639D0 VA: 0x180D653D0
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
	*/

}

