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

	// RVA: 0x69BD60 Offset: 0x69A360 VA: 0x18069BD60
	internal void Setup(ItemBlueprint item) { }

	// RVA: 0x69BC90 Offset: 0x69A290 VA: 0x18069BC90
	private void RefreshFavouriteIcon() { }

	// RVA: 0x69BF40 Offset: 0x69A540 VA: 0x18069BF40
	private void Update() { }

	// RVA: 0x69B9F0 Offset: 0x699FF0 VA: 0x18069B9F0
	private void QueueItem(int quantity) { }

	// RVA: 0x69B5B0 Offset: 0x699BB0 VA: 0x18069B5B0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x69B970 Offset: 0x699F70 VA: 0x18069B970
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x69B910 Offset: 0x699F10 VA: 0x18069B910 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x69B940 Offset: 0x699F40 VA: 0x18069B940 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x69B3B0 Offset: 0x6999B0 VA: 0x18069B3B0
	public void OnFavouriteHovered() { }

	// RVA: 0x69B530 Offset: 0x699B30 VA: 0x18069B530
	public void OnFavouriteUnhovered() { }

	// RVA: 0x69C080 Offset: 0x69A680 VA: 0x18069C080
	public void .ctor() { }

	// RVA: 0x69C040 Offset: 0x69A640 VA: 0x18069C040
	private static void .cctor() { }

}

