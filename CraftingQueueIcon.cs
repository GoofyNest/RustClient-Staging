public class CraftingQueueIcon : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10992
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
	public Image icon; // 0x20
	public Image iconCancel; // 0x28
	public GameObject timeLeft; // 0x30
	public GameObject craftingCount; // 0x38
	public int taskid; // 0x40
	public float endTime; // 0x44
	public ItemDefinition item; // 0x48
	public int amount; // 0x50
	private ScrollRect scrollRect; // 0x58
	private bool pointerOverButton; // 0x60

	// Properties
	public string timeLeftString { get; }

	// Methods

	// RVA: 0x6C0DF0 Offset: 0x6BF3F0 VA: 0x1806C0DF0
	private void Awake() { }

	// RVA: 0x6C1710 Offset: 0x6BFD10 VA: 0x1806C1710
	private void Update() { }

	// RVA: 0x6C17A0 Offset: 0x6BFDA0 VA: 0x1806C17A0
	public string get_timeLeftString() { }

	// RVA: 0x6C1670 Offset: 0x6BFC70 VA: 0x1806C1670
	internal void OnTaskStart(float endTime) { }

	// RVA: 0x6C16B0 Offset: 0x6BFCB0 VA: 0x1806C16B0
	internal void ResetEndTime() { }

	// RVA: 0x6C1060 Offset: 0x6BF660 VA: 0x1806C1060
	internal void Finished(bool success, int amountleft) { }

	// RVA: 0x6C1180 Offset: 0x6BF780 VA: 0x1806C1180
	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect) { }

	// RVA: 0x6C0E40 Offset: 0x6BF440 VA: 0x1806C0E40
	private void Cancel() { }

	// RVA: 0x6C0F50 Offset: 0x6BF550 VA: 0x1806C0F50
	private void FastTrack() { }

	// RVA: 0x6C12F0 Offset: 0x6BF8F0 VA: 0x1806C12F0
	public void MoveIconToFront() { }

	// RVA: 0x6C13D0 Offset: 0x6BF9D0 VA: 0x1806C13D0 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6C1400 Offset: 0x6BFA00 VA: 0x1806C1400 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6C1430 Offset: 0x6BFA30 VA: 0x1806C1430 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x6C1370 Offset: 0x6BF970 VA: 0x1806C1370 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x6C1340 Offset: 0x6BF940 VA: 0x1806C1340 Slot: 6
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x6C13A0 Offset: 0x6BF9A0 VA: 0x1806C13A0 Slot: 7
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

