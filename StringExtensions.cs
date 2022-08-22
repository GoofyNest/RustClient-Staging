public static class StringExtensions // TypeDefIndex: 4846
{	// Fields
	private static readonly Regex regexSplitQuotes; // 0x0
	private static char[] spaceOrQuote; // 0x8
	private static char[] FilenameDelim; // 0x10
	private static readonly char[] _badCharacters; // 0x18

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270720 Offset: 0x226ED20 VA: 0x182270720
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270A80 Offset: 0x226F080 VA: 0x182270A80
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270D80 Offset: 0x226F380 VA: 0x182270D80
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270E00 Offset: 0x226F400 VA: 0x182270E00
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270EF0 Offset: 0x226F4F0 VA: 0x182270EF0
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270C40 Offset: 0x226F240 VA: 0x182270C40
	public static bool ToBool(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271290 Offset: 0x226F890 VA: 0x182271290
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22710D0 Offset: 0x226F6D0 VA: 0x1822710D0
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22706F0 Offset: 0x226ECF0 VA: 0x1822706F0
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22708E0 Offset: 0x226EEE0 VA: 0x1822708E0
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22707D0 Offset: 0x226EDD0 VA: 0x1822707D0
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270670 Offset: 0x226EC70 VA: 0x182270670
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22705F0 Offset: 0x226EBF0 VA: 0x1822705F0
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x2271310 Offset: 0x226F910 VA: 0x182271310
	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{	// Fields
	public static readonly StringExtensions.<>c <>9; // 0x0
	public static Func<char, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x2271540 Offset: 0x226FB40 VA: 0x182271540
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22714C0 Offset: 0x226FAC0 VA: 0x1822714C0
	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BCE30 Offset: 0x21BB430 VA: 0x1821BCE30
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD070 Offset: 0x21BB670 VA: 0x1821BD070
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BCEA0 Offset: 0x21BB4A0 VA: 0x1821BCEA0
	public static Color ToColor(string str) { }

}

