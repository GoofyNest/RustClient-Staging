public class Cursor // TypeDefIndex: 3454
{	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x1827F30 Offset: 0x1826530 VA: 0x181827F30
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x1827FB0 Offset: 0x18265B0 VA: 0x181827FB0
	public static bool get_visible() { }

	// RVA: 0x1828020 Offset: 0x1826620 VA: 0x181828020
	public static void set_visible(bool value) { }

	// RVA: 0x1827F80 Offset: 0x1826580 VA: 0x181827F80
	public static CursorLockMode get_lockState() { }

	// RVA: 0x1827FE0 Offset: 0x18265E0 VA: 0x181827FE0
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x1827ED0 Offset: 0x18264D0 VA: 0x181827ED0
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

