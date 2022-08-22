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

	// RVA: 0x6C0E60 Offset: 0x6BF460 VA: 0x1806C0E60
	private void Awake() { }

	// RVA: 0x6C1780 Offset: 0x6BFD80 VA: 0x1806C1780
	private void Update() { }

	// RVA: 0x6C1810 Offset: 0x6BFE10 VA: 0x1806C1810
	public string get_timeLeftString() { }

	// RVA: 0x6C16E0 Offset: 0x6BFCE0 VA: 0x1806C16E0
	internal void OnTaskStart(float endTime) { }

	// RVA: 0x6C1720 Offset: 0x6BFD20 VA: 0x1806C1720
	internal void ResetEndTime() { }

	// RVA: 0x6C10D0 Offset: 0x6BF6D0 VA: 0x1806C10D0
	internal void Finished(bool success, int amountleft) { }

	// RVA: 0x6C11F0 Offset: 0x6BF7F0 VA: 0x1806C11F0
	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect) { }

	// RVA: 0x6C0EB0 Offset: 0x6BF4B0 VA: 0x1806C0EB0
	private void Cancel() { }

	// RVA: 0x6C0FC0 Offset: 0x6BF5C0 VA: 0x1806C0FC0
	private void FastTrack() { }

	// RVA: 0x6C1360 Offset: 0x6BF960 VA: 0x1806C1360
	public void MoveIconToFront() { }

	// RVA: 0x6C1440 Offset: 0x6BFA40 VA: 0x1806C1440 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6C1470 Offset: 0x6BFA70 VA: 0x1806C1470 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6C14A0 Offset: 0x6BFAA0 VA: 0x1806C14A0 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x6C13E0 Offset: 0x6BF9E0 VA: 0x1806C13E0 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x6C13B0 Offset: 0x6BF9B0 VA: 0x1806C13B0 Slot: 6
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x6C1410 Offset: 0x6BFA10 VA: 0x1806C1410 Slot: 7
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

