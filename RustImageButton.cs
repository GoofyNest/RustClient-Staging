public class RustImageButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7020
{	// Fields
	public Image Background; // 0x30
	public Image Icon; // 0x38
	public UnityEvent OnPressed; // 0x40
	public UnityEvent OnReleased; // 0x48
	public bool IsToggle; // 0x50
	public bool UnpressSiblings; // 0x51
	public bool PreventToggleOff; // 0x52
	public Transform TabPanelTarget; // 0x58
	public Sprite PressedImage; // 0x60
	public Sprite UnpressedImage; // 0x68

	// Properties
	public bool Value { get; set; }
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0xFCB320 Offset: 0xFC9920 VA: 0x180FCB320
	public bool get_Value() { }

	// RVA: 0xFCB7B0 Offset: 0xFC9DB0 VA: 0x180FCB7B0
	public void set_Value(bool value) { }

	// RVA: 0xFCC130 Offset: 0xFCA730 VA: 0x180FCC130
	public void Press() { }

	// RVA: 0xFCC0E0 Offset: 0xFCA6E0 VA: 0x180FCC0E0
	public void Unpress() { }

	// RVA: 0xFCC0B0 Offset: 0xFCA6B0 VA: 0x180FCC0B0 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCC380 Offset: 0xFCA980 VA: 0x180FCC380
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCC270 Offset: 0xFCA870 VA: 0x180FCC270
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCBE00 Offset: 0xFCA400 VA: 0x180FCBE00
	private void DoUnpressSiblings() { }

	// RVA: 0xFCC0E0 Offset: 0xFCA6E0 VA: 0x180FCC0E0 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCC060 Offset: 0xFCA660 VA: 0x180FCC060 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCBC80 Offset: 0xFCA280 VA: 0x180FCBC80 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCC700 Offset: 0xFCAD00 VA: 0x180FCC700 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCC840 Offset: 0xFCAE40 VA: 0x180FCC840 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCC530 Offset: 0xFCAB30 VA: 0x180FCC530 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCC670 Offset: 0xFCAC70 VA: 0x180FCC670 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCC7B0 Offset: 0xFCADB0 VA: 0x180FCC7B0 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCC4A0 Offset: 0xFCAAA0 VA: 0x180FCC4A0 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCC5E0 Offset: 0xFCABE0 VA: 0x180FCC5E0 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCBDC0 Offset: 0xFCA3C0 VA: 0x180FCBDC0 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCBDE0 Offset: 0xFCA3E0 VA: 0x180FCBDE0 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCC440 Offset: 0xFCAA40 VA: 0x180FCC440
	public void .ctor() { }

}

