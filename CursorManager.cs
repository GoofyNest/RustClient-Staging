public class CursorManager : SingletonComponent<CursorManager> // TypeDefIndex: 10849
{	private static int iHoldOpen; // 0x0
	private static int iPreviousOpen; // 0x4
	private static float lastTimeVisible; // 0x8
	private static float lastTimeInvisible; // 0xC


	private void Update() { }

	public void SwitchToGame() { }

	private void SwitchToUI() { }

	public static void HoldOpen(bool cursorVisible = False) { }

	public static bool WasVisible(float deltaTime) { }

	public static bool WasInvisible(float deltaTime) { }

	public void .ctor() { }

	private static void .cctor() { }

}

