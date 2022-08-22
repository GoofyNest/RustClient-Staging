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

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080
	public bool get_Value() { }

	// RVA: 0xFCC510 Offset: 0xFCAB10 VA: 0x180FCC510
	public void set_Value(bool value) { }

	// RVA: 0xFCCE90 Offset: 0xFCB490 VA: 0x180FCCE90
	public void Press() { }

	// RVA: 0xFCCE40 Offset: 0xFCB440 VA: 0x180FCCE40
	public void Unpress() { }

	// RVA: 0xFCCE10 Offset: 0xFCB410 VA: 0x180FCCE10 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCD0E0 Offset: 0xFCB6E0 VA: 0x180FCD0E0
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCCFD0 Offset: 0xFCB5D0 VA: 0x180FCCFD0
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCCB60 Offset: 0xFCB160 VA: 0x180FCCB60
	private void DoUnpressSiblings() { }

	// RVA: 0xFCCE40 Offset: 0xFCB440 VA: 0x180FCCE40 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCCDC0 Offset: 0xFCB3C0 VA: 0x180FCCDC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCC9E0 Offset: 0xFCAFE0 VA: 0x180FCC9E0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCD460 Offset: 0xFCBA60 VA: 0x180FCD460 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCD5A0 Offset: 0xFCBBA0 VA: 0x180FCD5A0 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCD290 Offset: 0xFCB890 VA: 0x180FCD290 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCD3D0 Offset: 0xFCB9D0 VA: 0x180FCD3D0 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCD510 Offset: 0xFCBB10 VA: 0x180FCD510 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCD200 Offset: 0xFCB800 VA: 0x180FCD200 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCD340 Offset: 0xFCB940 VA: 0x180FCD340 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCCB20 Offset: 0xFCB120 VA: 0x180FCCB20 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCCB40 Offset: 0xFCB140 VA: 0x180FCCB40 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCD1A0 Offset: 0xFCB7A0 VA: 0x180FCD1A0
	public void .ctor() { }

}

