internal static class PointerDeviceState // TypeDefIndex: 4685
{	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0xEB6F40 Offset: 0xEB5540 VA: 0x180EB6F40
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0xEB6CF0 Offset: 0xEB52F0 VA: 0x180EB6CF0
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0xEB6E60 Offset: 0xEB5460 VA: 0x180EB6E60
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0xEB6DD0 Offset: 0xEB53D0 VA: 0x180EB6DD0
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0xEB6B30 Offset: 0xEB5130 VA: 0x180EB6B30
	public static Vector2 GetPointerPosition(int pointerId) { }

	// RVA: 0xEB6BC0 Offset: 0xEB51C0 VA: 0x180EB6BC0
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0xEB6C50 Offset: 0xEB5250 VA: 0x180EB6C50
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0xEB7070 Offset: 0xEB5670 VA: 0x180EB7070
	private static void .cctor() { }

}

