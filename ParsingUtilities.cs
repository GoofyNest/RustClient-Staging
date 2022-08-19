internal static class ParsingUtilities // TypeDefIndex: 7632
{	// Methods

	// RVA: 0x13A4710 Offset: 0x13A2D10 VA: 0x1813A4710
	public static string GetNonnegativeIntegerNumberGroup(string groupName) { }

	// RVA: 0x13A46C0 Offset: 0x13A2CC0 VA: 0x1813A46C0
	public static string GetNonnegativeDoubleNumberGroup(string groupName) { }

	// RVA: 0x13A4760 Offset: 0x13A2D60 VA: 0x1813A4760
	public static Match Match(string input, IEnumerable<string> patterns, bool ignoreCase = True) { }

	// RVA: 0x13A4BE0 Offset: 0x13A31E0 VA: 0x1813A4BE0
	public static bool ParseNonnegativeInt(Match match, string groupName, int defaultValue, out int value) { }

	// RVA: 0x13A4AC0 Offset: 0x13A30C0 VA: 0x1813A4AC0
	public static bool ParseNonnegativeDouble(Match match, string groupName, double defaultValue, out double value) { }

	// RVA: 0x13A4C80 Offset: 0x13A3280 VA: 0x1813A4C80
	public static bool ParseNonnegativeLong(Match match, string groupName, long defaultValue, out long value) { }

	// RVA: 0x13A4A10 Offset: 0x13A3010 VA: 0x1813A4A10
	private static bool ParseInt(Match match, string groupName, int defaultValue, NumberStyles numberStyle, out int value) { }

	// RVA: 0x13A48E0 Offset: 0x13A2EE0 VA: 0x1813A48E0
	private static bool ParseDouble(Match match, string groupName, double defaultValue, NumberStyles numberStyle, out double value) { }

}

private sealed class ParsingUtilities.<>c__DisplayClass8_0 // TypeDefIndex: 7633
{	// Fields
	public string input; // 0x10
	public bool ignoreCase; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA950 Offset: 0x13A8F50 VA: 0x1813AA950
	internal Match <Match>b__0(string p) { }

}

private sealed class ParsingUtilities.<>c // TypeDefIndex: 7634
{	// Fields
	public static readonly ParsingUtilities.<>c <>9; // 0x0
	public static Func<Match, bool> <>9__8_1; // 0x8

	// Methods

	// RVA: 0x13AAA70 Offset: 0x13A9070 VA: 0x1813AAA70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA470 Offset: 0x13A8A70 VA: 0x1813AA470
	internal bool <Match>b__8_1(Match m) { }

}

