public class PhotoPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8816
{	// Fields
	public RawImage Image; // 0x18
	public InputField Message; // 0x20
	private Item _item; // 0x28
	private Texture2D _texture; // 0x30

	// Methods

	// RVA: 0x909F00 Offset: 0x908500 VA: 0x180909F00
	public void OnItem(Item item) { }

	// RVA: 0x909E80 Offset: 0x908480 VA: 0x180909E80 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x909FD0 Offset: 0x9085D0 VA: 0x180909FD0
	public void OnMessageChanged() { }

	// RVA: 0x909DD0 Offset: 0x9083D0 VA: 0x180909DD0
	public void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

