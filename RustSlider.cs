public class RustSlider : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 7029
{	// Fields
	public RustInput NumberInput; // 0x30
	public Image SliderCanvas; // 0x38
	public string DecimalFormat; // 0x40
	public float MinValue; // 0x48
	public float MaxValue; // 0x4C
	public bool Integer; // 0x50
	public float ValueInternal; // 0x54
	public RustSlider.ChangedEvent OnChanged; // 0x58
	private float lastCallbackValue; // 0x60

	// Properties
	public float Value { get; set; }
	public float ValueNormalized { get; set; }

	// Methods

	// RVA: 0xFCFA60 Offset: 0xFCE060 VA: 0x180FCFA60 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD00B0 Offset: 0xFCE6B0 VA: 0x180FD00B0
	public float get_Value() { }

	// RVA: 0xFD00E0 Offset: 0xFCE6E0 VA: 0x180FD00E0
	public void set_Value(float value) { }

	// RVA: 0xFD0020 Offset: 0xFCE620 VA: 0x180FD0020
	public float get_ValueNormalized() { }

	// RVA: 0xFD00C0 Offset: 0xFCE6C0 VA: 0x180FD00C0
	public void set_ValueNormalized(float value) { }

	// RVA: 0xFCFD80 Offset: 0xFCE380 VA: 0x180FCFD80
	public void TextChanged(string text) { }

	// RVA: 0xFCFD70 Offset: 0xFCE370 VA: 0x180FCFD70
	public void SliderChanged(float slider) { }

	// RVA: 0xFCF9C0 Offset: 0xFCDFC0 VA: 0x180FCF9C0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCFC10 Offset: 0xFCE210 VA: 0x180FCFC10 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCFCF0 Offset: 0xFCE2F0 VA: 0x180FCFCF0 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCFBF0 Offset: 0xFCE1F0 VA: 0x180FCFBF0 Slot: 34
	public void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0xFCFB80 Offset: 0xFCE180 VA: 0x180FCFB80 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFCFDC0 Offset: 0xFCE3C0 VA: 0x180FCFDC0
	private void UpdateDrag(Vector2 pos, Camera cam) { }

	// RVA: 0xFCFFB0 Offset: 0xFCE5B0 VA: 0x180FCFFB0
	public void .ctor() { }

}

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7030
{	// Methods

	// RVA: 0xFBEDA0 Offset: 0xFBD3A0 VA: 0x180FBEDA0
	public void .ctor() { }

}

