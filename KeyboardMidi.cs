public static class KeyboardMidi // TypeDefIndex: 12115
{	// Fields
	[ClientVar] // RVA: 0xDC320 Offset: 0xDB720 VA: 0x1800DC320
	public static string midikeymap; // 0x0
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; // 0x8

	// Methods

	[ClientVar] // RVA: 0xDC420 Offset: 0xDB820 VA: 0x1800DC420
	// RVA: 0x4BEC30 Offset: 0x4BD230 VA: 0x1804BEC30
	public static void Reload() { }

	// RVA: 0x4BE620 Offset: 0x4BCC20 VA: 0x1804BE620
	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	// RVA: 0x4BECA0 Offset: 0x4BD2A0 VA: 0x1804BECA0
	private static KeyCode[] StringToKeycodeArray(string val) { }

	// RVA: 0x4BEB40 Offset: 0x4BD140 VA: 0x1804BEB40
	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	// RVA: 0x4BEEC0 Offset: 0x4BD4C0 VA: 0x1804BEEC0
	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 12116
{	// Fields
	public static readonly KeyboardMidi.<>c <>9; // 0x0
	public static Func<string, KeyCode> <>9__4_0; // 0x8
	public static Func<KeyCode, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0x4D2560 Offset: 0x4D0B60 VA: 0x1804D2560
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D2000 Offset: 0x4D0600 VA: 0x1804D2000
	internal KeyCode <StringToKeycodeArray>b__4_0(string x) { }

	// RVA: 0x4D20C0 Offset: 0x4D06C0 VA: 0x1804D20C0
	internal bool <StringToKeycodeArray>b__4_1(KeyCode x) { }

}

