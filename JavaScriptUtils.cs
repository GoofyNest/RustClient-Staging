internal static class JavaScriptUtils // TypeDefIndex: 5959
{	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x1807CE0 Offset: 0x18062E0 VA: 0x181807CE0
	private static void .cctor() { }

	// RVA: 0x1807260 Offset: 0x1805860 VA: 0x181807260
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x1807340 Offset: 0x1805940 VA: 0x181807340
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0x18076E0 Offset: 0x1805CE0 VA: 0x1818076E0
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x18073D0 Offset: 0x18059D0 VA: 0x1818073D0
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

}

