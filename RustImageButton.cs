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

	// RVA: 0xFCB5E0 Offset: 0xFC9BE0 VA: 0x180FCB5E0
	public bool get_Value() { }

	// RVA: 0xFCBA70 Offset: 0xFCA070 VA: 0x180FCBA70
	public void set_Value(bool value) { }

	// RVA: 0xFCC3F0 Offset: 0xFCA9F0 VA: 0x180FCC3F0
	public void Press() { }

	// RVA: 0xFCC3A0 Offset: 0xFCA9A0 VA: 0x180FCC3A0
	public void Unpress() { }

	// RVA: 0xFCC370 Offset: 0xFCA970 VA: 0x180FCC370 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCC640 Offset: 0xFCAC40 VA: 0x180FCC640
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFCC530 Offset: 0xFCAB30 VA: 0x180FCC530
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFCC0C0 Offset: 0xFCA6C0 VA: 0x180FCC0C0
	private void DoUnpressSiblings() { }

	// RVA: 0xFCC3A0 Offset: 0xFCA9A0 VA: 0x180FCC3A0 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCC320 Offset: 0xFCA920 VA: 0x180FCC320 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFCBF40 Offset: 0xFCA540 VA: 0x180FCBF40 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCC9C0 Offset: 0xFCAFC0 VA: 0x180FCC9C0 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFCCB00 Offset: 0xFCB100 VA: 0x180FCCB00 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFCC7F0 Offset: 0xFCADF0 VA: 0x180FCC7F0 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFCC930 Offset: 0xFCAF30 VA: 0x180FCC930 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFCCA70 Offset: 0xFCB070 VA: 0x180FCCA70 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFCC760 Offset: 0xFCAD60 VA: 0x180FCC760 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFCC8A0 Offset: 0xFCAEA0 VA: 0x180FCC8A0 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFCC080 Offset: 0xFCA680 VA: 0x180FCC080 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFCC0A0 Offset: 0xFCA6A0 VA: 0x180FCC0A0 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFCC700 Offset: 0xFCAD00 VA: 0x180FCC700
	public void .ctor() { }

}

