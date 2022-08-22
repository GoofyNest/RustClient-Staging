internal static class PointerDeviceState // TypeDefIndex: 4685
{	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0xEB7200 Offset: 0xEB5800 VA: 0x180EB7200
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0xEB6FB0 Offset: 0xEB55B0 VA: 0x180EB6FB0
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0xEB7120 Offset: 0xEB5720 VA: 0x180EB7120
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0xEB7090 Offset: 0xEB5690 VA: 0x180EB7090
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0xEB6DF0 Offset: 0xEB53F0 VA: 0x180EB6DF0
	public static Vector2 GetPointerPosition(int pointerId) { }

	// RVA: 0xEB6E80 Offset: 0xEB5480 VA: 0x180EB6E80
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0xEB6F10 Offset: 0xEB5510 VA: 0x180EB6F10
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0xEB7330 Offset: 0xEB5930 VA: 0x180EB7330
	private static void .cctor() { }

}

