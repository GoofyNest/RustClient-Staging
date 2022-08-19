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

	// RVA: 0x21FD1B0 Offset: 0x21FB7B0 VA: 0x1821FD1B0
	internal static ParsingResult TryParse(string input, out MusicalTimeSpan timeSpan) { }

	// RVA: 0x21FCF40 Offset: 0x21FB540 VA: 0x1821FCF40
	private static string GetMnemonicGroup(string groupName, IEnumerable<string> mnemonics) { }

	// RVA: 0x21FD810 Offset: 0x21FBE10 VA: 0x1821FD810
	private static void .cctor() { }

}

