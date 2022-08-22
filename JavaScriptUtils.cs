internal static class JavaScriptUtils // TypeDefIndex: 5959
{	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x17F53E0 Offset: 0x17F39E0 VA: 0x1817F53E0
	private static void .cctor() { }

	// RVA: 0x17F4960 Offset: 0x17F2F60 VA: 0x1817F4960
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x17F4A40 Offset: 0x17F3040 VA: 0x1817F4A40
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0x17F4DE0 Offset: 0x17F33E0 VA: 0x1817F4DE0
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x17F4AD0 Offset: 0x17F30D0 VA: 0x1817F4AD0
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

}

