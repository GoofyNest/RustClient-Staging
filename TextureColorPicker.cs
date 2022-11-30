public class TextureColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler // TypeDefIndex: 10977
{
	public Texture2D texture;
	public TextureColorPicker.onColorSelectedEvent onColorSelected;


	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public void .ctor() { }

}

public class TextureColorPicker.onColorSelectedEvent : UnityEvent<Color> // TypeDefIndex: 10978
{

	public void .ctor() { }

}

