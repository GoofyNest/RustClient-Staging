public class CursorManager : SingletonComponent<CursorManager> // TypeDefIndex: 10845
{	// Fields
	private static int iHoldOpen; // 0x0
	private static int iPreviousOpen; // 0x4
	private static float lastTimeVisible; // 0x8
	private static float lastTimeInvisible; // 0xC

	// Methods

	// RVA: 0x6C6640 Offset: 0x6C4C40 VA: 0x1806C6640
	private void Update() { }

	// RVA: 0x6C64E0 Offset: 0x6C4AE0 VA: 0x1806C64E0
	public void SwitchToGame() { }

	// RVA: 0x6C6590 Offset: 0x6C4B90 VA: 0x1806C6590
	private void SwitchToUI() { }

	// RVA: 0x6C6470 Offset: 0x6C4A70 VA: 0x1806C6470
	public static void HoldOpen(bool cursorVisible = False) { }

	// RVA: 0x6C6920 Offset: 0x6C4F20 VA: 0x1806C6920
	public static bool WasVisible(float deltaTime) { }

	// RVA: 0x6C68A0 Offset: 0x6C4EA0 VA: 0x1806C68A0
	public static bool WasInvisible(float deltaTime) { }

	// RVA: 0x6C69A0 Offset: 0x6C4FA0 VA: 0x1806C69A0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

