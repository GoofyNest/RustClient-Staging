internal static class ParsingUtilities // TypeDefIndex: 7632
{	// Methods

	// RVA: 0x13A3AD0 Offset: 0x13A20D0 VA: 0x1813A3AD0
	public static string GetNonnegativeIntegerNumberGroup(string groupName) { }

	// RVA: 0x13A3A80 Offset: 0x13A2080 VA: 0x1813A3A80
	public static string GetNonnegativeDoubleNumberGroup(string groupName) { }

	// RVA: 0x13A3B20 Offset: 0x13A2120 VA: 0x1813A3B20
	public static Match Match(string input, IEnumerable<string> patterns, bool ignoreCase = True) { }

	// RVA: 0x13A3FA0 Offset: 0x13A25A0 VA: 0x1813A3FA0
	public static bool ParseNonnegativeInt(Match match, string groupName, int defaultValue, out int value) { }

	// RVA: 0x13A3E80 Offset: 0x13A2480 VA: 0x1813A3E80
	public static bool ParseNonnegativeDouble(Match match, string groupName, double defaultValue, out double value) { }

	// RVA: 0x13A4040 Offset: 0x13A2640 VA: 0x1813A4040
	public static bool ParseNonnegativeLong(Match match, string groupName, long defaultValue, out long value) { }

	// RVA: 0x13A3DD0 Offset: 0x13A23D0 VA: 0x1813A3DD0
	private static bool ParseInt(Match match, string groupName, int defaultValue, NumberStyles numberStyle, out int value) { }

	// RVA: 0x13A3CA0 Offset: 0x13A22A0 VA: 0x1813A3CA0
	private static bool ParseDouble(Match match, string groupName, double defaultValue, NumberStyles numberStyle, out double value) { }

}

private sealed class ParsingUtilities.<>c__DisplayClass8_0 // TypeDefIndex: 7633
{	// Fields
	public string input; // 0x10
	public bool ignoreCase; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13A9D10 Offset: 0x13A8310 VA: 0x1813A9D10
	internal Match <Match>b__0(string p) { }

}

private sealed class ParsingUtilities.<>c // TypeDefIndex: 7634
{	// Fields
	public static readonly ParsingUtilities.<>c <>9; // 0x0
	public static Func<Match, bool> <>9__8_1; // 0x8

	// Methods

	// RVA: 0x13A9E30 Offset: 0x13A8430 VA: 0x1813A9E30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13A9830 Offset: 0x13A7E30 VA: 0x1813A9830
	internal bool <Match>b__8_1(Match m) { }

}

