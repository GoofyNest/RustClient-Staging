public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7042
{	// Fields
	public int CurrentPosition; // 0x30
	public Image Background; // 0x38
	private Timeline Parent; // 0x40
	private bool hasDragged; // 0x48

	// Properties
	public override bool IsPressed { get; }

	// Methods

	// RVA: 0xFD53B0 Offset: 0xFD39B0 VA: 0x180FD53B0 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD53C0 Offset: 0xFD39C0 VA: 0x180FD53C0 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD54F0 Offset: 0xFD3AF0 VA: 0x180FD54F0 Slot: 34
	public virtual void SelectMarker() { }

	// RVA: 0xFD5390 Offset: 0xFD3990 VA: 0x180FD5390 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD5570 Offset: 0xFD3B70 VA: 0x180FD5570 Slot: 26
	public override bool get_IsPressed() { }

	// RVA: 0xFD53E0 Offset: 0xFD39E0 VA: 0x180FD53E0
	internal void Position(Timeline timeline) { }

	// RVA: 0xFD52C0 Offset: 0xFD38C0 VA: 0x180FD52C0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0 Slot: 35
	public virtual void SetTime(int time) { }

	// RVA: 0xFD5300 Offset: 0xFD3900 VA: 0x180FD5300
	public void Delete() { }

	// RVA: 0xFD5510 Offset: 0xFD3B10 VA: 0x180FD5510
	public void .ctor() { }

}

