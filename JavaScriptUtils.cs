internal static class JavaScriptUtils // TypeDefIndex: 5959
{	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x1807FA0 Offset: 0x18065A0 VA: 0x181807FA0
	private static void .cctor() { }

	// RVA: 0x1807520 Offset: 0x1805B20 VA: 0x181807520
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x1807600 Offset: 0x1805C00 VA: 0x181807600
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0x18079A0 Offset: 0x1805FA0 VA: 0x1818079A0
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x1807690 Offset: 0x1805C90 VA: 0x181807690
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

}

