public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7042
{	// Fields
	public int CurrentPosition; // 0x30
	public Image Background; // 0x38
	private Timeline Parent; // 0x40
	private bool hasDragged; // 0x48

	// Properties
	public override bool IsPressed { get; }

	// Methods

	// RVA: 0xFD5670 Offset: 0xFD3C70 VA: 0x180FD5670 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD5680 Offset: 0xFD3C80 VA: 0x180FD5680 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD57B0 Offset: 0xFD3DB0 VA: 0x180FD57B0 Slot: 34
	public virtual void SelectMarker() { }

	// RVA: 0xFD5650 Offset: 0xFD3C50 VA: 0x180FD5650 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD5830 Offset: 0xFD3E30 VA: 0x180FD5830 Slot: 26
	public override bool get_IsPressed() { }

	// RVA: 0xFD56A0 Offset: 0xFD3CA0 VA: 0x180FD56A0
	internal void Position(Timeline timeline) { }

	// RVA: 0xFD5580 Offset: 0xFD3B80 VA: 0x180FD5580 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560 Slot: 35
	public virtual void SetTime(int time) { }

	// RVA: 0xFD55C0 Offset: 0xFD3BC0 VA: 0x180FD55C0
	public void Delete() { }

	// RVA: 0xFD57D0 Offset: 0xFD3DD0 VA: 0x180FD57D0
	public void .ctor() { }

}

