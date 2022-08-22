public class SignPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8817
{	// Fields
	public RawImage Image; // 0x18
	public RectTransform ImageContainer; // 0x20
	public RustText DisabledSignsMessage; // 0x28
	private Item _item; // 0x30
	private Texture2D _texture; // 0x38

	// Methods

	// RVA: 0x59A520 Offset: 0x598B20 VA: 0x18059A520
	public void OnItem(Item item) { }

	// RVA: 0x59A490 Offset: 0x598A90 VA: 0x18059A490 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x59A720 Offset: 0x598D20 VA: 0x18059A720
	public static void SizeImageBasedOnTexture(Texture2D tex, RectTransform imageContainer) { }

	// RVA: 0x59A3E0 Offset: 0x5989E0 VA: 0x18059A3E0
	public void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

