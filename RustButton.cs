public class RustButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7013
{	// Fields
	public Image Background; // 0x30
	public RustText Text; // 0x38
	public RustText SubText; // 0x40
	public RustIcon Icon; // 0x48
	public Image IconImage; // 0x50
	public UnityEvent OnPressed; // 0x58
	public UnityEvent OnReleased; // 0x60
	public bool IsToggle; // 0x68
	public bool UnpressSiblings; // 0x69
	public bool PreventToggleOff; // 0x6A
	public Transform TabPanelTarget; // 0x70
	public Vector4 TextMargin; // 0x78
	public Vector4 TextMarginNoIcon; // 0x88

	// Properties
	public bool Value { get; set; }
	public bool AutoSize { get; set; }
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

	// RVA: 0xFCB300 Offset: 0xFC9900 VA: 0x180FCB300
	public bool get_AutoSize() { }

	// RVA: 0xFCB790 Offset: 0xFC9D90 VA: 0x180FCB790
	public void set_AutoSize(bool value) { }

	// RVA: 0xFCAF10 Offset: 0xFC9510 VA: 0x180FCAF10
	public void Press() { }

	// RVA: 0xFCAE80 Offset: 0xFC9480 VA: 0x180FCAE80
	public void Unpress() { }

	// RVA: 0xFCAE50 Offset: 0xFC9450 VA: 0x180FCAE50 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCB160 Offset: 0xFC9760 VA: 0x180FCB160
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCB050 Offset: 0xFC9650 VA: 0x180FCB050
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCAB00 Offset: 0xFC9100 VA: 0x180FCAB00
	private void DoUnpressSiblings() { }

	// RVA: 0xFCAE80 Offset: 0xFC9480 VA: 0x180FCAE80 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCAD60 Offset: 0xFC9360 VA: 0x180FCAD60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCA610 Offset: 0xFC8C10 VA: 0x180FCA610 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCB5A0 Offset: 0xFC9BA0 VA: 0x180FCB5A0 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCB6E0 Offset: 0xFC9CE0 VA: 0x180FCB6E0 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCB3D0 Offset: 0xFC99D0 VA: 0x180FCB3D0 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCB510 Offset: 0xFC9B10 VA: 0x180FCB510 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCB650 Offset: 0xFC9C50 VA: 0x180FCB650 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCB340 Offset: 0xFC9940 VA: 0x180FCB340 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCB480 Offset: 0xFC9A80 VA: 0x180FCB480 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCAAC0 Offset: 0xFC90C0 VA: 0x180FCAAC0 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCAAE0 Offset: 0xFC90E0 VA: 0x180FCAAE0 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCB220 Offset: 0xFC9820 VA: 0x180FCB220
	public void .ctor() { }

}

