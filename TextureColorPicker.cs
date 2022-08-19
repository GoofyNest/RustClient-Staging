public class TextureColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler // TypeDefIndex: 9242
{	// Fields
	public Texture2D texture; // 0x18
	public TextureColorPicker.onColorSelectedEvent onColorSelected; // 0x20

	// Methods

	// RVA: 0x888120 Offset: 0x886720 VA: 0x180888120 Slot: 6
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x887EB0 Offset: 0x8864B0 VA: 0x180887EB0 Slot: 7
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x888140 Offset: 0x886740 VA: 0x180888140
	public void .ctor() { }

}

public class TextureColorPicker.onColorSelectedEvent : UnityEvent<Color> // TypeDefIndex: 9243
{	// Methods

	// RVA: 0x8916D0 Offset: 0x88FCD0 VA: 0x1808916D0
	public void .ctor() { }

}

