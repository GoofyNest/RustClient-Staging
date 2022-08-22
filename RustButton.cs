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

	// RVA: 0xFCB5E0 Offset: 0xFC9BE0 VA: 0x180FCB5E0
	public bool get_Value() { }

	// RVA: 0xFCBA70 Offset: 0xFCA070 VA: 0x180FCBA70
	public void set_Value(bool value) { }

	// RVA: 0xFCB5C0 Offset: 0xFC9BC0 VA: 0x180FCB5C0
	public bool get_AutoSize() { }

	// RVA: 0xFCBA50 Offset: 0xFCA050 VA: 0x180FCBA50
	public void set_AutoSize(bool value) { }

	// RVA: 0xFCB1D0 Offset: 0xFC97D0 VA: 0x180FCB1D0
	public void Press() { }

	// RVA: 0xFCB140 Offset: 0xFC9740 VA: 0x180FCB140
	public void Unpress() { }

	// RVA: 0xFCB110 Offset: 0xFC9710 VA: 0x180FCB110 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCB420 Offset: 0xFC9A20 VA: 0x180FCB420
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCB310 Offset: 0xFC9910 VA: 0x180FCB310
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCADC0 Offset: 0xFC93C0 VA: 0x180FCADC0
	private void DoUnpressSiblings() { }

	// RVA: 0xFCB140 Offset: 0xFC9740 VA: 0x180FCB140 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCB020 Offset: 0xFC9620 VA: 0x180FCB020 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCA8D0 Offset: 0xFC8ED0 VA: 0x180FCA8D0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCB860 Offset: 0xFC9E60 VA: 0x180FCB860 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCB9A0 Offset: 0xFC9FA0 VA: 0x180FCB9A0 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCB690 Offset: 0xFC9C90 VA: 0x180FCB690 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCB7D0 Offset: 0xFC9DD0 VA: 0x180FCB7D0 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCB910 Offset: 0xFC9F10 VA: 0x180FCB910 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCB600 Offset: 0xFC9C00 VA: 0x180FCB600 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCB740 Offset: 0xFC9D40 VA: 0x180FCB740 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCAD80 Offset: 0xFC9380 VA: 0x180FCAD80 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCADA0 Offset: 0xFC93A0 VA: 0x180FCADA0 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCB4E0 Offset: 0xFC9AE0 VA: 0x180FCB4E0
	public void .ctor() { }

}

