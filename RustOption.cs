public class RustOption : RustControl // TypeDefIndex: 7025
{	// Fields
	public RustButton Left; // 0x30
	public RustButton Right; // 0x38
	public RustText Text; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public RustOption.ChangedEvent OnChanged; // 0x58

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFBFB60 Offset: 0xFBE160 VA: 0x180FBFB60
	public Option get_Value() { }

	// RVA: 0xFCF570 Offset: 0xFCDB70 VA: 0x180FCF570 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCF8E0 Offset: 0xFCDEE0 VA: 0x180FCF8E0
	public void SetOptions(Option[] options) { }

	// RVA: 0xFCF860 Offset: 0xFCDE60 VA: 0x180FCF860
	public void SetOption(int i) { }

	// RVA: 0xFCF800 Offset: 0xFCDE00 VA: 0x180FCF800
	public void SetOptionDefault() { }

	// RVA: 0xFCF650 Offset: 0xFCDC50 VA: 0x180FCF650
	public void OnLeft() { }

	// RVA: 0xFCF6F0 Offset: 0xFCDCF0 VA: 0x180FCF6F0
	public void OnRight() { }

	// RVA: 0xFCF450 Offset: 0xFCDA50 VA: 0x180FCF450 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCF960 Offset: 0xFCDF60 VA: 0x180FCF960
	public void .ctor() { }

}

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7026
{	// Methods

	// RVA: 0xFBECA0 Offset: 0xFBD2A0 VA: 0x180FBECA0
	public void .ctor() { }

}

