public class CursorManager : SingletonComponent<CursorManager> // TypeDefIndex: 10845
{	// Fields
	private static int iHoldOpen; // 0x0
	private static int iPreviousOpen; // 0x4
	private static float lastTimeVisible; // 0x8
	private static float lastTimeInvisible; // 0xC

	// Methods

	// RVA: 0x6C66B0 Offset: 0x6C4CB0 VA: 0x1806C66B0
	private void Update() { }

	// RVA: 0x6C6550 Offset: 0x6C4B50 VA: 0x1806C6550
	public void SwitchToGame() { }

	// RVA: 0x6C6600 Offset: 0x6C4C00 VA: 0x1806C6600
	private void SwitchToUI() { }

	// RVA: 0x6C64E0 Offset: 0x6C4AE0 VA: 0x1806C64E0
	public static void HoldOpen(bool cursorVisible = False) { }

	// RVA: 0x6C6990 Offset: 0x6C4F90 VA: 0x1806C6990
	public static bool WasVisible(float deltaTime) { }

	// RVA: 0x6C6910 Offset: 0x6C4F10 VA: 0x1806C6910
	public static bool WasInvisible(float deltaTime) { }

	// RVA: 0x6C6A10 Offset: 0x6C5010 VA: 0x1806C6A10
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

