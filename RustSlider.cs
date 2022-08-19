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

	// RVA: 0xFCED00 Offset: 0xFCD300 VA: 0x180FCED00 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCF350 Offset: 0xFCD950 VA: 0x180FCF350
	public float get_Value() { }

	// RVA: 0xFCF380 Offset: 0xFCD980 VA: 0x180FCF380
	public void set_Value(float value) { }

	// RVA: 0xFCF2C0 Offset: 0xFCD8C0 VA: 0x180FCF2C0
	public float get_ValueNormalized() { }

	// RVA: 0xFCF360 Offset: 0xFCD960 VA: 0x180FCF360
	public void set_ValueNormalized(float value) { }

	// RVA: 0xFCF020 Offset: 0xFCD620 VA: 0x180FCF020
	public void TextChanged(string text) { }

	// RVA: 0xFCF010 Offset: 0xFCD610 VA: 0x180FCF010
	public void SliderChanged(float slider) { }

	// RVA: 0xFCEC60 Offset: 0xFCD260 VA: 0x180FCEC60 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCEEB0 Offset: 0xFCD4B0 VA: 0x180FCEEB0 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFCEF90 Offset: 0xFCD590 VA: 0x180FCEF90 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFCEE90 Offset: 0xFCD490 VA: 0x180FCEE90 Slot: 34
	public void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0xFCEE20 Offset: 0xFCD420 VA: 0x180FCEE20 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFCF060 Offset: 0xFCD660 VA: 0x180FCF060
	private void UpdateDrag(Vector2 pos, Camera cam) { }

	// RVA: 0xFCF250 Offset: 0xFCD850 VA: 0x180FCF250
	public void .ctor() { }

}

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7030
{	// Methods

	// RVA: 0xFBE040 Offset: 0xFBC640 VA: 0x180FBE040
	public void .ctor() { }

}

