public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10983
{	// Fields
	public Image image; // 0x18
	public Image imageFavourite; // 0x20
	public Button button; // 0x28
	public CanvasGroup group; // 0x30
	public GameObject newNotification; // 0x38
	public GameObject lockedOverlay; // 0x40
	public Tooltip Tip; // 0x48
	public Image FavouriteIcon; // 0x50
	internal bool needsRefresh; // 0x58
	internal ItemBlueprint blueprint; // 0x60
	private UIBlueprints parentBlueprints; // 0x68
	private bool favourited; // 0x70
	private bool hovered; // 0x71

	// Methods

	// RVA: 0x514780 Offset: 0x512D80 VA: 0x180514780
	public void Setup(ItemBlueprint bp, UIBlueprints parent) { }

	// RVA: 0x513BB0 Offset: 0x5121B0 VA: 0x180513BB0
	public void Awake() { }

	// RVA: 0x513C30 Offset: 0x512230 VA: 0x180513C30
	public void OnDestroy() { }

	// RVA: 0x514970 Offset: 0x512F70 VA: 0x180514970
	private void Update() { }

	// RVA: 0x514940 Offset: 0x512F40 VA: 0x180514940
	private void UpdateSelection() { }

	// RVA: 0x513F80 Offset: 0x512580 VA: 0x180513F80
	private void Refresh() { }

	// RVA: 0x513DE0 Offset: 0x5123E0 VA: 0x180513DE0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x513DF0 Offset: 0x5123F0 VA: 0x180513DF0 Slot: 5
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x513F00 Offset: 0x512500 VA: 0x180513F00
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x513EA0 Offset: 0x5124A0 VA: 0x180513EA0 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x513ED0 Offset: 0x5124D0 VA: 0x180513ED0 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x513CE0 Offset: 0x5122E0 VA: 0x180513CE0
	public void OnFavouriteHovered() { }

	// RVA: 0x513D60 Offset: 0x512360 VA: 0x180513D60
	public void OnFavouriteUnhovered() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

