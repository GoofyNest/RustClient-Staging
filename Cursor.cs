public class Cursor // TypeDefIndex: 3454
{	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x1827C70 Offset: 0x1826270 VA: 0x181827C70
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x1827CF0 Offset: 0x18262F0 VA: 0x181827CF0
	public static bool get_visible() { }

	// RVA: 0x1827D60 Offset: 0x1826360 VA: 0x181827D60
	public static void set_visible(bool value) { }

	// RVA: 0x1827CC0 Offset: 0x18262C0 VA: 0x181827CC0
	public static CursorLockMode get_lockState() { }

	// RVA: 0x1827D20 Offset: 0x1826320 VA: 0x181827D20
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x1827C10 Offset: 0x1826210 VA: 0x181827C10
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

