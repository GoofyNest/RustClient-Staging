public class CursorManager : SingletonComponent<CursorManager> // TypeDefIndex: 10845
{	// Fields
	private static int iHoldOpen; // 0x0
	private static int iPreviousOpen; // 0x4
	private static float lastTimeVisible; // 0x8
	private static float lastTimeInvisible; // 0xC

	// Methods

	// RVA: 0x6C65A0 Offset: 0x6C4BA0 VA: 0x1806C65A0
	private void Update() { }

	// RVA: 0x6C6440 Offset: 0x6C4A40 VA: 0x1806C6440
	public void SwitchToGame() { }

	// RVA: 0x6C64F0 Offset: 0x6C4AF0 VA: 0x1806C64F0
	private void SwitchToUI() { }

	// RVA: 0x6C63D0 Offset: 0x6C49D0 VA: 0x1806C63D0
	public static void HoldOpen(bool cursorVisible = False) { }

	// RVA: 0x6C6880 Offset: 0x6C4E80 VA: 0x1806C6880
	public static bool WasVisible(float deltaTime) { }

	// RVA: 0x6C6800 Offset: 0x6C4E00 VA: 0x1806C6800
	public static bool WasInvisible(float deltaTime) { }

	// RVA: 0x6C6900 Offset: 0x6C4F00 VA: 0x1806C6900
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

