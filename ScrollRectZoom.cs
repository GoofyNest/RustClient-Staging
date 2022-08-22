public class ScrollRectZoom : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 11219
{	// Fields
	public ScrollRectEx scrollRect; // 0x18
	public float zoom; // 0x20
	public float max; // 0x24
	public float min; // 0x28
	public bool mouseWheelZoom; // 0x2C
	public float scrollAmount; // 0x30

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4A5C70 Offset: 0x4A4270 VA: 0x1804A5C70
	public RectTransform get_rectTransform() { }

	// RVA: 0x4A59E0 Offset: 0x4A3FE0 VA: 0x1804A59E0
	private void OnEnable() { }

	// RVA: 0x4A59F0 Offset: 0x4A3FF0 VA: 0x1804A59F0 Slot: 4
	public void OnScroll(PointerEventData data) { }

	// RVA: 0x4A5A30 Offset: 0x4A4030 VA: 0x1804A5A30
	public void SetZoom(float z, bool expZoom = True) { }

	// RVA: 0x4A5C40 Offset: 0x4A4240 VA: 0x1804A5C40
	public void .ctor() { }

}

