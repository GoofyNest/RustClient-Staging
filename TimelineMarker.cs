public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7042
{	// Fields
	public int CurrentPosition; // 0x30
	public Image Background; // 0x38
	private Timeline Parent; // 0x40
	private bool hasDragged; // 0x48

	// Properties
	public override bool IsPressed { get; }

	// Methods

	// RVA: 0xFD6110 Offset: 0xFD4710 VA: 0x180FD6110 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD6120 Offset: 0xFD4720 VA: 0x180FD6120 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD6250 Offset: 0xFD4850 VA: 0x180FD6250 Slot: 34
	public virtual void SelectMarker() { }

	// RVA: 0xFD60F0 Offset: 0xFD46F0 VA: 0x180FD60F0 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD62D0 Offset: 0xFD48D0 VA: 0x180FD62D0 Slot: 26
	public override bool get_IsPressed() { }

	// RVA: 0xFD6140 Offset: 0xFD4740 VA: 0x180FD6140
	internal void Position(Timeline timeline) { }

	// RVA: 0xFD6020 Offset: 0xFD4620 VA: 0x180FD6020 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50 Slot: 35
	public virtual void SetTime(int time) { }

	// RVA: 0xFD6060 Offset: 0xFD4660 VA: 0x180FD6060
	public void Delete() { }

	// RVA: 0xFD6270 Offset: 0xFD4870 VA: 0x180FD6270
	public void .ctor() { }

}

