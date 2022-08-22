internal static class PointerDeviceState // TypeDefIndex: 4685
{	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0xEB7CB0 Offset: 0xEB62B0 VA: 0x180EB7CB0
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0xEB7A60 Offset: 0xEB6060 VA: 0x180EB7A60
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0xEB7BD0 Offset: 0xEB61D0 VA: 0x180EB7BD0
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0xEB7B40 Offset: 0xEB6140 VA: 0x180EB7B40
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0xEB78A0 Offset: 0xEB5EA0 VA: 0x180EB78A0
	public static Vector2 GetPointerPosition(int pointerId) { }

	// RVA: 0xEB7930 Offset: 0xEB5F30 VA: 0x180EB7930
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0xEB79C0 Offset: 0xEB5FC0 VA: 0x180EB79C0
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0xEB7DE0 Offset: 0xEB63E0 VA: 0x180EB7DE0
	private static void .cctor() { }

}

