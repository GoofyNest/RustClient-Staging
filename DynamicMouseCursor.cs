public class DynamicMouseCursor : MonoBehaviour // TypeDefIndex: 10921
{	// Fields
	public Texture2D RegularCursor; // 0x18
	public Vector2 RegularCursorPos; // 0x20
	public Texture2D HoverCursor; // 0x28
	public Vector2 HoverCursorPos; // 0x30
	private Texture2D current; // 0x38
	private PointerEventData pointer; // 0x40
	private List<RaycastResult> results; // 0x48

	// Methods

	// RVA: 0xAB63C0 Offset: 0xAB49C0 VA: 0x180AB63C0
	private void LateUpdate() { }

	// RVA: 0xAB6520 Offset: 0xAB4B20 VA: 0x180AB6520
	private void UpdateCursor(Texture2D cursor, Vector2 offs) { }

	// RVA: 0xAB6120 Offset: 0xAB4720 VA: 0x180AB6120
	private GameObject CurrentlyHoveredItem() { }

	// RVA: 0xAB65D0 Offset: 0xAB4BD0 VA: 0x180AB65D0
	public void .ctor() { }

}

