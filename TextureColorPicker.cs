public class TextureColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler // TypeDefIndex: 9242
{	// Fields
	public Texture2D texture; // 0x18
	public TextureColorPicker.onColorSelectedEvent onColorSelected; // 0x20

	// Methods

	// RVA: 0x86B570 Offset: 0x869B70 VA: 0x18086B570 Slot: 6
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x86B300 Offset: 0x869900 VA: 0x18086B300 Slot: 7
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x86B590 Offset: 0x869B90 VA: 0x18086B590
	public void .ctor() { }

}

public class TextureColorPicker.onColorSelectedEvent : UnityEvent<Color> // TypeDefIndex: 9243
{	// Methods

	// RVA: 0x874B20 Offset: 0x873120 VA: 0x180874B20
	public void .ctor() { }

}

