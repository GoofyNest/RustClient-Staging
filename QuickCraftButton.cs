public class QuickCraftButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 11047
{	// Fields
	public Image icon; // 0x18
	public Image favourite; // 0x20
	public Tooltip tooltip; // 0x28
	public Text CraftCount; // 0x30
	public Image FavouriteIcon; // 0x38
	private ItemBlueprint bp; // 0x40
	private int skinId; // 0x48
	private int oldCount; // 0x4C
	private bool favourited; // 0x50
	private static int lastClickedItemID; // 0x0

	// Methods

	// RVA: 0x69BE70 Offset: 0x69A470 VA: 0x18069BE70
	internal void Setup(ItemBlueprint item) { }

	// RVA: 0x69BDA0 Offset: 0x69A3A0 VA: 0x18069BDA0
	private void RefreshFavouriteIcon() { }

	// RVA: 0x69C050 Offset: 0x69A650 VA: 0x18069C050
	private void Update() { }

	// RVA: 0x69BB00 Offset: 0x69A100 VA: 0x18069BB00
	private void QueueItem(int quantity) { }

	// RVA: 0x69B6C0 Offset: 0x699CC0 VA: 0x18069B6C0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x69BA80 Offset: 0x69A080 VA: 0x18069BA80
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x69BA20 Offset: 0x69A020 VA: 0x18069BA20 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x69BA50 Offset: 0x69A050 VA: 0x18069BA50 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x69B4C0 Offset: 0x699AC0 VA: 0x18069B4C0
	public void OnFavouriteHovered() { }

	// RVA: 0x69B640 Offset: 0x699C40 VA: 0x18069B640
	public void OnFavouriteUnhovered() { }

	// RVA: 0x69C190 Offset: 0x69A790 VA: 0x18069C190
	public void .ctor() { }

	// RVA: 0x69C150 Offset: 0x69A750 VA: 0x18069C150
	private static void .cctor() { }

}

