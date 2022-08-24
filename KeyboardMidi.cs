public static class KeyboardMidi // TypeDefIndex: 12119
{	[ClientVar] // RVA: 0xDC5E0 Offset: 0xDB9E0 VA: 0x1800DC5E0
	public static string midikeymap; // 0x0
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; // 0x8


	[ClientVar] // RVA: 0xDD9B0 Offset: 0xDCDB0 VA: 0x1800DD9B0
	public static void Reload() { }

	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	private static KeyCode[] StringToKeycodeArray(string val) { }

	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 12120
{	public static readonly KeyboardMidi.<>c <>9; // 0x0
	public static Func<string, KeyCode> <>9__4_0; // 0x8
	public static Func<KeyCode, bool> <>9__4_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal KeyCode <StringToKeycodeArray>b__4_0(string x) { }

	internal bool <StringToKeycodeArray>b__4_1(KeyCode x) { }

}

