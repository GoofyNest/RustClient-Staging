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

	// RVA: 0xAB5EF0 Offset: 0xAB44F0 VA: 0x180AB5EF0
	private void LateUpdate() { }

	// RVA: 0xAB6050 Offset: 0xAB4650 VA: 0x180AB6050
	private void UpdateCursor(Texture2D cursor, Vector2 offs) { }

	// RVA: 0xAB5C50 Offset: 0xAB4250 VA: 0x180AB5C50
	private GameObject CurrentlyHoveredItem() { }

	// RVA: 0xAB6100 Offset: 0xAB4700 VA: 0x180AB6100
	public void .ctor() { }

}

