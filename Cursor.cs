public class Cursor // TypeDefIndex: 3454
{	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x1815370 Offset: 0x1813970 VA: 0x181815370
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x18153F0 Offset: 0x18139F0 VA: 0x1818153F0
	public static bool get_visible() { }

	// RVA: 0x1815460 Offset: 0x1813A60 VA: 0x181815460
	public static void set_visible(bool value) { }

	// RVA: 0x18153C0 Offset: 0x18139C0 VA: 0x1818153C0
	public static CursorLockMode get_lockState() { }

	// RVA: 0x1815420 Offset: 0x1813A20 VA: 0x181815420
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x1815310 Offset: 0x1813910 VA: 0x181815310
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

