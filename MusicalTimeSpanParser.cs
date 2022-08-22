internal static class MusicalTimeSpanParser // TypeDefIndex: 7488
{	// Fields
	private static readonly Dictionary<string, Tuple<int, int>> Fractions; // 0x0
	private static readonly Dictionary<string, Tuple<int, int>> Tuplets; // 0x8
	private static readonly string FractionGroup; // 0x10
	private static readonly string FractionMnemonicGroup; // 0x18
	private static readonly string TupletGroup; // 0x20
	private static readonly string TupletMnemonicGroup; // 0x28
	private static readonly string DotsGroup; // 0x30
	private static readonly string[] Patterns; // 0x38

	// Methods

	// RVA: 0x21FCFF0 Offset: 0x21FB5F0 VA: 0x1821FCFF0
	internal static ParsingResult TryParse(string input, out MusicalTimeSpan timeSpan) { }

	// RVA: 0x21FCD80 Offset: 0x21FB380 VA: 0x1821FCD80
	private static string GetMnemonicGroup(string groupName, IEnumerable<string> mnemonics) { }

	// RVA: 0x21FD650 Offset: 0x21FBC50 VA: 0x1821FD650
	private static void .cctor() { }

}

