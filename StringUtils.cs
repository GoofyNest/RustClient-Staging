internal static class StringUtils // TypeDefIndex: 5969
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FF6E0 Offset: 0x17FDCE0 VA: 0x1817FF6E0
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FFAA0 Offset: 0x17FE0A0 VA: 0x1817FFAA0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FFC50 Offset: 0x17FE250 VA: 0x1817FFC50
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FF830 Offset: 0x17FDE30 VA: 0x1817FF830
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FF620 Offset: 0x17FDC20 VA: 0x1817FF620
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x17FF530 Offset: 0x17FDB30 VA: 0x1817FF530
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x17FFE60 Offset: 0x17FE460 VA: 0x1817FFE60
	public static Nullable<int> GetLength(string value) { }

	// RVA: 0x1800210 Offset: 0x17FE810 VA: 0x181800210
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9FD0 Offset: 0x15B85D0 VA: 0x1815B9FD0
	|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	*/

	// RVA: 0x17FFFC0 Offset: 0x17FE5C0 VA: 0x1817FFFC0
	public static string ToCamelCase(string s) { }

	// RVA: 0x17FFEC0 Offset: 0x17FE4C0 VA: 0x1817FFEC0
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x17FFF20 Offset: 0x17FE520 VA: 0x1817FFF20
	public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FFF80 Offset: 0x17FE580 VA: 0x1817FFF80
	public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FF5E0 Offset: 0x17FDBE0 VA: 0x1817FF5E0
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-StringUtils.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65FF0 Offset: 0xD645F0 VA: 0x180D65FF0
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66040 Offset: 0xD64640 VA: 0x180D66040
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
	*/

}

