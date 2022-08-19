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

	// RVA: 0x6C0D50 Offset: 0x6BF350 VA: 0x1806C0D50
	private void Awake() { }

	// RVA: 0x6C1670 Offset: 0x6BFC70 VA: 0x1806C1670
	private void Update() { }

	// RVA: 0x6C1700 Offset: 0x6BFD00 VA: 0x1806C1700
	public string get_timeLeftString() { }

	// RVA: 0x6C15D0 Offset: 0x6BFBD0 VA: 0x1806C15D0
	internal void OnTaskStart(float endTime) { }

	// RVA: 0x6C1610 Offset: 0x6BFC10 VA: 0x1806C1610
	internal void ResetEndTime() { }

	// RVA: 0x6C0FC0 Offset: 0x6BF5C0 VA: 0x1806C0FC0
	internal void Finished(bool success, int amountleft) { }

	// RVA: 0x6C10E0 Offset: 0x6BF6E0 VA: 0x1806C10E0
	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect) { }

	// RVA: 0x6C0DA0 Offset: 0x6BF3A0 VA: 0x1806C0DA0
	private void Cancel() { }

	// RVA: 0x6C0EB0 Offset: 0x6BF4B0 VA: 0x1806C0EB0
	private void FastTrack() { }

	// RVA: 0x6C1250 Offset: 0x6BF850 VA: 0x1806C1250
	public void MoveIconToFront() { }

	// RVA: 0x6C1330 Offset: 0x6BF930 VA: 0x1806C1330 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6C1360 Offset: 0x6BF960 VA: 0x1806C1360 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6C1390 Offset: 0x6BF990 VA: 0x1806C1390 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x6C12D0 Offset: 0x6BF8D0 VA: 0x1806C12D0 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x6C12A0 Offset: 0x6BF8A0 VA: 0x1806C12A0 Slot: 6
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x6C1300 Offset: 0x6BF900 VA: 0x1806C1300 Slot: 7
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

