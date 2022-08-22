internal static class ParsingUtilities // TypeDefIndex: 7632
{	// Methods

	// RVA: 0x13A49D0 Offset: 0x13A2FD0 VA: 0x1813A49D0
	public static string GetNonnegativeIntegerNumberGroup(string groupName) { }

	// RVA: 0x13A4980 Offset: 0x13A2F80 VA: 0x1813A4980
	public static string GetNonnegativeDoubleNumberGroup(string groupName) { }

	// RVA: 0x13A4A20 Offset: 0x13A3020 VA: 0x1813A4A20
	public static Match Match(string input, IEnumerable<string> patterns, bool ignoreCase = True) { }

	// RVA: 0x13A4EA0 Offset: 0x13A34A0 VA: 0x1813A4EA0
	public static bool ParseNonnegativeInt(Match match, string groupName, int defaultValue, out int value) { }

	// RVA: 0x13A4D80 Offset: 0x13A3380 VA: 0x1813A4D80
	public static bool ParseNonnegativeDouble(Match match, string groupName, double defaultValue, out double value) { }

	// RVA: 0x13A4F40 Offset: 0x13A3540 VA: 0x1813A4F40
	public static bool ParseNonnegativeLong(Match match, string groupName, long defaultValue, out long value) { }

	// RVA: 0x13A4CD0 Offset: 0x13A32D0 VA: 0x1813A4CD0
	private static bool ParseInt(Match match, string groupName, int defaultValue, NumberStyles numberStyle, out int value) { }

	// RVA: 0x13A4BA0 Offset: 0x13A31A0 VA: 0x1813A4BA0
	private static bool ParseDouble(Match match, string groupName, double defaultValue, NumberStyles numberStyle, out double value) { }

}

private sealed class ParsingUtilities.<>c__DisplayClass8_0 // TypeDefIndex: 7633
{	// Fields
	public string input; // 0x10
	public bool ignoreCase; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AAC10 Offset: 0x13A9210 VA: 0x1813AAC10
	internal Match <Match>b__0(string p) { }

}

private sealed class ParsingUtilities.<>c // TypeDefIndex: 7634
{	// Fields
	public static readonly ParsingUtilities.<>c <>9; // 0x0
	public static Func<Match, bool> <>9__8_1; // 0x8

	// Methods

	// RVA: 0x13AAD30 Offset: 0x13A9330 VA: 0x1813AAD30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA730 Offset: 0x13A8D30 VA: 0x1813AA730
	internal bool <Match>b__8_1(Match m) { }

}

