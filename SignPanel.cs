public class SignPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8817
{	// Fields
	public RawImage Image; // 0x18
	public RectTransform ImageContainer; // 0x20
	public RustText DisabledSignsMessage; // 0x28
	private Item _item; // 0x30
	private Texture2D _texture; // 0x38

	// Methods

	// RVA: 0x59A590 Offset: 0x598B90 VA: 0x18059A590
	public void OnItem(Item item) { }

	// RVA: 0x59A500 Offset: 0x598B00 VA: 0x18059A500 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x59A790 Offset: 0x598D90 VA: 0x18059A790
	public static void SizeImageBasedOnTexture(Texture2D tex, RectTransform imageContainer) { }

	// RVA: 0x59A450 Offset: 0x598A50 VA: 0x18059A450
	public void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

