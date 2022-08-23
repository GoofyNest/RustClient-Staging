internal static class StringUtils // TypeDefIndex: 5969
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	public static StringWriter CreateStringWriter(int capacity) { }

	public static Nullable<int> GetLength(string value) { }

	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA0D0 Offset: 0x15B86D0 VA: 0x1815BA0D0
	|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	*/

	public static string ToCamelCase(string s) { }

	public static bool IsHighSurrogate(char c) { }

	public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool EndsWith(string source, char value) { }

}

private sealed class StringUtils.<>c__DisplayClass15_0<TSource> // TypeDefIndex: 5970
{	public Func<TSource, string> valueSelector; // 0x0
	public string testValue; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-StringUtils.<>c__DisplayClass15_0<object>..ctor
	*/

	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD660F0 Offset: 0xD646F0 VA: 0x180D660F0
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
	*/

	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66140 Offset: 0xD64740 VA: 0x180D66140
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
	*/

}

