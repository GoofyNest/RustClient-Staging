public static class StringExtensions // TypeDefIndex: 4846
{	// Fields
	private static readonly Regex regexSplitQuotes; // 0x0
	private static char[] spaceOrQuote; // 0x8
	private static char[] FilenameDelim; // 0x10
	private static readonly char[] _badCharacters; // 0x18

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22709E0 Offset: 0x226EFE0 VA: 0x1822709E0
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270D40 Offset: 0x226F340 VA: 0x182270D40
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271040 Offset: 0x226F640 VA: 0x182271040
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22710C0 Offset: 0x226F6C0 VA: 0x1822710C0
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22711B0 Offset: 0x226F7B0 VA: 0x1822711B0
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270F00 Offset: 0x226F500 VA: 0x182270F00
	public static bool ToBool(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271550 Offset: 0x226FB50 VA: 0x182271550
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2271390 Offset: 0x226F990 VA: 0x182271390
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22709B0 Offset: 0x226EFB0 VA: 0x1822709B0
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270BA0 Offset: 0x226F1A0 VA: 0x182270BA0
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270A90 Offset: 0x226F090 VA: 0x182270A90
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2270930 Offset: 0x226EF30 VA: 0x182270930
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22708B0 Offset: 0x226EEB0 VA: 0x1822708B0
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x22715D0 Offset: 0x226FBD0 VA: 0x1822715D0
	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{	// Fields
	public static readonly StringExtensions.<>c <>9; // 0x0
	public static Func<char, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x2271800 Offset: 0x226FE00 VA: 0x182271800
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2271780 Offset: 0x226FD80 VA: 0x182271780
	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD0F0 Offset: 0x21BB6F0 VA: 0x1821BD0F0
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD330 Offset: 0x21BB930 VA: 0x1821BD330
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BD160 Offset: 0x21BB760 VA: 0x1821BD160
	public static Color ToColor(string str) { }

}

