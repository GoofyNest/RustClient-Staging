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

	// RVA: 0xFCEFC0 Offset: 0xFCD5C0 VA: 0x180FCEFC0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCF610 Offset: 0xFCDC10 VA: 0x180FCF610
	public float get_Value() { }

	// RVA: 0xFCF640 Offset: 0xFCDC40 VA: 0x180FCF640
	public void set_Value(float value) { }

	// RVA: 0xFCF580 Offset: 0xFCDB80 VA: 0x180FCF580
	public float get_ValueNormalized() { }

	// RVA: 0xFCF620 Offset: 0xFCDC20 VA: 0x180FCF620
	public void set_ValueNormalized(float value) { }

	// RVA: 0xFCF2E0 Offset: 0xFCD8E0 VA: 0x180FCF2E0
	public void TextChanged(string text) { }

	// RVA: 0xFCF2D0 Offset: 0xFCD8D0 VA: 0x180FCF2D0
	public void SliderChanged(float slider) { }

	// RVA: 0xFCEF20 Offset: 0xFCD520 VA: 0x180FCEF20 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCF170 Offset: 0xFCD770 VA: 0x180FCF170 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCF250 Offset: 0xFCD850 VA: 0x180FCF250 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCF150 Offset: 0xFCD750 VA: 0x180FCF150 Slot: 34
	public void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0xFCF0E0 Offset: 0xFCD6E0 VA: 0x180FCF0E0 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFCF320 Offset: 0xFCD920 VA: 0x180FCF320
	private void UpdateDrag(Vector2 pos, Camera cam) { }

	// RVA: 0xFCF510 Offset: 0xFCDB10 VA: 0x180FCF510
	public void .ctor() { }

}

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7030
{	// Methods

	// RVA: 0xFBE300 Offset: 0xFBC900 VA: 0x180FBE300
	public void .ctor() { }

}

