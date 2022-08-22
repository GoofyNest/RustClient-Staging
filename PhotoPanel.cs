public class PhotoPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8816
{	// Fields
	public RawImage Image; // 0x18
	public InputField Message; // 0x20
	private Item _item; // 0x28
	private Texture2D _texture; // 0x30

	// Methods

	// RVA: 0x90A410 Offset: 0x908A10 VA: 0x18090A410
	public void OnItem(Item item) { }

	// RVA: 0x90A390 Offset: 0x908990 VA: 0x18090A390 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x90A4E0 Offset: 0x908AE0 VA: 0x18090A4E0
	public void OnMessageChanged() { }

	// RVA: 0x90A2E0 Offset: 0x9088E0 VA: 0x18090A2E0
	public void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

