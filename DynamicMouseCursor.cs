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

	// RVA: 0xAB5C30 Offset: 0xAB4230 VA: 0x180AB5C30
	private void LateUpdate() { }

	// RVA: 0xAB5D90 Offset: 0xAB4390 VA: 0x180AB5D90
	private void UpdateCursor(Texture2D cursor, Vector2 offs) { }

	// RVA: 0xAB5990 Offset: 0xAB3F90 VA: 0x180AB5990
	private GameObject CurrentlyHoveredItem() { }

	// RVA: 0xAB5E40 Offset: 0xAB4440 VA: 0x180AB5E40
	public void .ctor() { }

}

