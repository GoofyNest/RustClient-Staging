public static class Numlock // TypeDefIndex: 12028
{	// Fields
	private const byte VK_NUMLOCK = 144;
	private const uint KEYEVENTF_EXTENDEDKEY = 1;
	private const int KEYEVENTF_KEYUP = 2;
	private const int KEYEVENTF_KEYDOWN = 0;

	// Properties
	public static bool IsOn { get; }

	// Methods

	// RVA: 0x4C2370 Offset: 0x4C0970 VA: 0x1804C2370
	private static extern short GetKeyState(int keyCode) { }

	// RVA: 0x4C2520 Offset: 0x4C0B20 VA: 0x1804C2520
	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo) { }

	// RVA: 0x4C24A0 Offset: 0x4C0AA0 VA: 0x1804C24A0
	public static bool get_IsOn() { }

	// RVA: 0x4C23F0 Offset: 0x4C09F0 VA: 0x1804C23F0
	public static void TurnOn() { }

}

