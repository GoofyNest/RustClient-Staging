public static class Numlock // TypeDefIndex: 12028
{	// Fields
	private const byte VK_NUMLOCK = 144;
	private const uint KEYEVENTF_EXTENDEDKEY = 1;
	private const int KEYEVENTF_KEYUP = 2;
	private const int KEYEVENTF_KEYDOWN = 0;

	// Properties
	public static bool IsOn { get; }

	// Methods

	// RVA: 0x4C2300 Offset: 0x4C0900 VA: 0x1804C2300
	private static extern short GetKeyState(int keyCode) { }

	// RVA: 0x4C24B0 Offset: 0x4C0AB0 VA: 0x1804C24B0
	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo) { }

	// RVA: 0x4C2430 Offset: 0x4C0A30 VA: 0x1804C2430
	public static bool get_IsOn() { }

	// RVA: 0x4C2380 Offset: 0x4C0980 VA: 0x1804C2380
	public static void TurnOn() { }

}

