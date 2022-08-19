public static class StringExtensions // TypeDefIndex: 4846
{	// Fields
	private static readonly Regex regexSplitQuotes; // 0x0
	private static char[] spaceOrQuote; // 0x8
	private static char[] FilenameDelim; // 0x10
	private static readonly char[] _badCharacters; // 0x18

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22708E0 Offset: 0x226EEE0 VA: 0x1822708E0
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270C40 Offset: 0x226F240 VA: 0x182270C40
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270F40 Offset: 0x226F540 VA: 0x182270F40
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270FC0 Offset: 0x226F5C0 VA: 0x182270FC0
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22710B0 Offset: 0x226F6B0 VA: 0x1822710B0
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270E00 Offset: 0x226F400 VA: 0x182270E00
	public static bool ToBool(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2271450 Offset: 0x226FA50 VA: 0x182271450
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2271290 Offset: 0x226F890 VA: 0x182271290
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22708B0 Offset: 0x226EEB0 VA: 0x1822708B0
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270AA0 Offset: 0x226F0A0 VA: 0x182270AA0
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270990 Offset: 0x226EF90 VA: 0x182270990
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2270830 Offset: 0x226EE30 VA: 0x182270830
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22707B0 Offset: 0x226EDB0 VA: 0x1822707B0
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x22714D0 Offset: 0x226FAD0 VA: 0x1822714D0
	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{	// Fields
	public static readonly StringExtensions.<>c <>9; // 0x0
	public static Func<char, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x2271700 Offset: 0x226FD00 VA: 0x182271700
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2271680 Offset: 0x226FC80 VA: 0x182271680
	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BCFF0 Offset: 0x21BB5F0 VA: 0x1821BCFF0
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BD230 Offset: 0x21BB830 VA: 0x1821BD230
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BD060 Offset: 0x21BB660 VA: 0x1821BD060
	public static Color ToColor(string str) { }

}

