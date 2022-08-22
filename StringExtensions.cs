public static class StringExtensions // TypeDefIndex: 4846
{	// Fields
	private static readonly Regex regexSplitQuotes; // 0x0
	private static char[] spaceOrQuote; // 0x8
	private static char[] FilenameDelim; // 0x10
	private static readonly char[] _badCharacters; // 0x18

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271200 Offset: 0x226F800 VA: 0x182271200
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271560 Offset: 0x226FB60 VA: 0x182271560
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271860 Offset: 0x226FE60 VA: 0x182271860
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22718E0 Offset: 0x226FEE0 VA: 0x1822718E0
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22719D0 Offset: 0x226FFD0 VA: 0x1822719D0
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271720 Offset: 0x226FD20 VA: 0x182271720
	public static bool ToBool(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271D70 Offset: 0x2270370 VA: 0x182271D70
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271BB0 Offset: 0x22701B0 VA: 0x182271BB0
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22711D0 Offset: 0x226F7D0 VA: 0x1822711D0
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22713C0 Offset: 0x226F9C0 VA: 0x1822713C0
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22712B0 Offset: 0x226F8B0 VA: 0x1822712B0
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271150 Offset: 0x226F750 VA: 0x182271150
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22710D0 Offset: 0x226F6D0 VA: 0x1822710D0
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x2271DF0 Offset: 0x22703F0 VA: 0x182271DF0
	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{	// Fields
	public static readonly StringExtensions.<>c <>9; // 0x0
	public static Func<char, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x2272020 Offset: 0x2270620 VA: 0x182272020
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2271FA0 Offset: 0x22705A0 VA: 0x182271FA0
	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD910 Offset: 0x21BBF10 VA: 0x1821BD910
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BDB50 Offset: 0x21BC150 VA: 0x1821BDB50
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD980 Offset: 0x21BBF80 VA: 0x1821BD980
	public static Color ToColor(string str) { }

}

