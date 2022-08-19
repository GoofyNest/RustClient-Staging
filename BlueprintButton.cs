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

	// RVA: 0x5147F0 Offset: 0x512DF0 VA: 0x1805147F0
	public void Setup(ItemBlueprint bp, UIBlueprints parent) { }

	// RVA: 0x513C20 Offset: 0x512220 VA: 0x180513C20
	public void Awake() { }

	// RVA: 0x513CA0 Offset: 0x5122A0 VA: 0x180513CA0
	public void OnDestroy() { }

	// RVA: 0x5149E0 Offset: 0x512FE0 VA: 0x1805149E0
	private void Update() { }

	// RVA: 0x5149B0 Offset: 0x512FB0 VA: 0x1805149B0
	private void UpdateSelection() { }

	// RVA: 0x513FF0 Offset: 0x5125F0 VA: 0x180513FF0
	private void Refresh() { }

	// RVA: 0x513E50 Offset: 0x512450 VA: 0x180513E50 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x513E60 Offset: 0x512460 VA: 0x180513E60 Slot: 5
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x513F70 Offset: 0x512570 VA: 0x180513F70
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x513F10 Offset: 0x512510 VA: 0x180513F10 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x513F40 Offset: 0x512540 VA: 0x180513F40 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x513D50 Offset: 0x512350 VA: 0x180513D50
	public void OnFavouriteHovered() { }

	// RVA: 0x513DD0 Offset: 0x5123D0 VA: 0x180513DD0
	public void OnFavouriteUnhovered() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

