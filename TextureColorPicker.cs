public class TextureColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler // TypeDefIndex: 9242
{	// Fields
	public Texture2D texture; // 0x18
	public TextureColorPicker.onColorSelectedEvent onColorSelected; // 0x20

	// Methods

	// RVA: 0x888230 Offset: 0x886830 VA: 0x180888230 Slot: 6
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x887FC0 Offset: 0x8865C0 VA: 0x180887FC0 Slot: 7
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x888250 Offset: 0x886850 VA: 0x180888250
	public void .ctor() { }

}

public class TextureColorPicker.onColorSelectedEvent : UnityEvent<Color> // TypeDefIndex: 9243
{	// Methods

	// RVA: 0x8917E0 Offset: 0x88FDE0 VA: 0x1808917E0
	public void .ctor() { }

}

