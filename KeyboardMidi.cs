public static class KeyboardMidi // TypeDefIndex: 12115
{	[ClientVar] // RVA: 0xDC320 Offset: 0xDB720 VA: 0x1800DC320
	public static string midikeymap; // 0x0
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; // 0x8


	[ClientVar] // RVA: 0xDC420 Offset: 0xDB820 VA: 0x1800DC420
	public static void Reload() { }

	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	private static KeyCode[] StringToKeycodeArray(string val) { }

	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 12116
{	public static readonly KeyboardMidi.<>c <>9; // 0x0
	public static Func<string, KeyCode> <>9__4_0; // 0x8
	public static Func<KeyCode, bool> <>9__4_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal KeyCode <StringToKeycodeArray>b__4_0(string x) { }

	internal bool <StringToKeycodeArray>b__4_1(KeyCode x) { }

}

