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

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080
	public bool get_Value() { }

	// RVA: 0xFCC510 Offset: 0xFCAB10 VA: 0x180FCC510
	public void set_Value(bool value) { }

	// RVA: 0xFCC060 Offset: 0xFCA660 VA: 0x180FCC060
	public bool get_AutoSize() { }

	// RVA: 0xFCC4F0 Offset: 0xFCAAF0 VA: 0x180FCC4F0
	public void set_AutoSize(bool value) { }

	// RVA: 0xFCBC70 Offset: 0xFCA270 VA: 0x180FCBC70
	public void Press() { }

	// RVA: 0xFCBBE0 Offset: 0xFCA1E0 VA: 0x180FCBBE0
	public void Unpress() { }

	// RVA: 0xFCBBB0 Offset: 0xFCA1B0 VA: 0x180FCBBB0 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCBEC0 Offset: 0xFCA4C0 VA: 0x180FCBEC0
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCBDB0 Offset: 0xFCA3B0 VA: 0x180FCBDB0
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCB860 Offset: 0xFC9E60 VA: 0x180FCB860
	private void DoUnpressSiblings() { }

	// RVA: 0xFCBBE0 Offset: 0xFCA1E0 VA: 0x180FCBBE0 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCBAC0 Offset: 0xFCA0C0 VA: 0x180FCBAC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCB370 Offset: 0xFC9970 VA: 0x180FCB370 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCC300 Offset: 0xFCA900 VA: 0x180FCC300 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCC440 Offset: 0xFCAA40 VA: 0x180FCC440 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCC130 Offset: 0xFCA730 VA: 0x180FCC130 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCC270 Offset: 0xFCA870 VA: 0x180FCC270 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCC3B0 Offset: 0xFCA9B0 VA: 0x180FCC3B0 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCC0A0 Offset: 0xFCA6A0 VA: 0x180FCC0A0 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCC1E0 Offset: 0xFCA7E0 VA: 0x180FCC1E0 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCB820 Offset: 0xFC9E20 VA: 0x180FCB820 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCB840 Offset: 0xFC9E40 VA: 0x180FCB840 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCBF80 Offset: 0xFCA580 VA: 0x180FCBF80
	public void .ctor() { }

}

