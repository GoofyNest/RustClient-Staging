public static class KeyboardMidi // TypeDefIndex: 12115
{	// Fields
	[ClientVar] // RVA: 0xDC320 Offset: 0xDB720 VA: 0x1800DC320
	public static string midikeymap; // 0x0
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; // 0x8

	// Methods

	[ClientVar] // RVA: 0xDC420 Offset: 0xDB820 VA: 0x1800DC420
	// RVA: 0x4BEBC0 Offset: 0x4BD1C0 VA: 0x1804BEBC0
	public static void Reload() { }

	// RVA: 0x4BE5B0 Offset: 0x4BCBB0 VA: 0x1804BE5B0
	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	// RVA: 0x4BEC30 Offset: 0x4BD230 VA: 0x1804BEC30
	private static KeyCode[] StringToKeycodeArray(string val) { }

	// RVA: 0x4BEAD0 Offset: 0x4BD0D0 VA: 0x1804BEAD0
	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	// RVA: 0x4BEE50 Offset: 0x4BD450 VA: 0x1804BEE50
	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 12116
{	// Fields
	public static readonly KeyboardMidi.<>c <>9; // 0x0
	public static Func<string, KeyCode> <>9__4_0; // 0x8
	public static Func<KeyCode, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0x4D24F0 Offset: 0x4D0AF0 VA: 0x1804D24F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1F90 Offset: 0x4D0590 VA: 0x1804D1F90
	internal KeyCode <StringToKeycodeArray>b__4_0(string x) { }

	// RVA: 0x4D2050 Offset: 0x4D0650 VA: 0x1804D2050
	internal bool <StringToKeycodeArray>b__4_1(KeyCode x) { }

}

