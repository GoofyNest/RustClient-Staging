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

	// RVA: 0x4A5CE0 Offset: 0x4A42E0 VA: 0x1804A5CE0
	public RectTransform get_rectTransform() { }

	// RVA: 0x4A5A50 Offset: 0x4A4050 VA: 0x1804A5A50
	private void OnEnable() { }

	// RVA: 0x4A5A60 Offset: 0x4A4060 VA: 0x1804A5A60 Slot: 4
	public void OnScroll(PointerEventData data) { }

	// RVA: 0x4A5AA0 Offset: 0x4A40A0 VA: 0x1804A5AA0
	public void SetZoom(float z, bool expZoom = True) { }

	// RVA: 0x4A5CB0 Offset: 0x4A42B0 VA: 0x1804A5CB0
	public void .ctor() { }

}

