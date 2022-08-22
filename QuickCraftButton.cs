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

	// RVA: 0x69BE00 Offset: 0x69A400 VA: 0x18069BE00
	internal void Setup(ItemBlueprint item) { }

	// RVA: 0x69BD30 Offset: 0x69A330 VA: 0x18069BD30
	private void RefreshFavouriteIcon() { }

	// RVA: 0x69BFE0 Offset: 0x69A5E0 VA: 0x18069BFE0
	private void Update() { }

	// RVA: 0x69BA90 Offset: 0x69A090 VA: 0x18069BA90
	private void QueueItem(int quantity) { }

	// RVA: 0x69B650 Offset: 0x699C50 VA: 0x18069B650 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x69BA10 Offset: 0x69A010 VA: 0x18069BA10
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x69B9B0 Offset: 0x699FB0 VA: 0x18069B9B0 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x69B9E0 Offset: 0x699FE0 VA: 0x18069B9E0 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x69B450 Offset: 0x699A50 VA: 0x18069B450
	public void OnFavouriteHovered() { }

	// RVA: 0x69B5D0 Offset: 0x699BD0 VA: 0x18069B5D0
	public void OnFavouriteUnhovered() { }

	// RVA: 0x69C120 Offset: 0x69A720 VA: 0x18069C120
	public void .ctor() { }

	// RVA: 0x69C0E0 Offset: 0x69A6E0 VA: 0x18069C0E0
	private static void .cctor() { }

}

