public class PhotoPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8816
{	// Fields
	public RawImage Image; // 0x18
	public InputField Message; // 0x20
	private Item _item; // 0x28
	private Texture2D _texture; // 0x30

	// Methods

	// RVA: 0x909DF0 Offset: 0x9083F0 VA: 0x180909DF0
	public void OnItem(Item item) { }

	// RVA: 0x909D70 Offset: 0x908370 VA: 0x180909D70 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x909EC0 Offset: 0x9084C0 VA: 0x180909EC0
	public void OnMessageChanged() { }

	// RVA: 0x909CC0 Offset: 0x9082C0 VA: 0x180909CC0
	public void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

