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

	// RVA: 0xFBEE00 Offset: 0xFBD400 VA: 0x180FBEE00
	public Option get_Value() { }

	// RVA: 0xFCE810 Offset: 0xFCCE10 VA: 0x180FCE810 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCEB80 Offset: 0xFCD180 VA: 0x180FCEB80
	public void SetOptions(Option[] options) { }

	// RVA: 0xFCEB00 Offset: 0xFCD100 VA: 0x180FCEB00
	public void SetOption(int i) { }

	// RVA: 0xFCEAA0 Offset: 0xFCD0A0 VA: 0x180FCEAA0
	public void SetOptionDefault() { }

	// RVA: 0xFCE8F0 Offset: 0xFCCEF0 VA: 0x180FCE8F0
	public void OnLeft() { }

	// RVA: 0xFCE990 Offset: 0xFCCF90 VA: 0x180FCE990
	public void OnRight() { }

	// RVA: 0xFCE6F0 Offset: 0xFCCCF0 VA: 0x180FCE6F0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCEC00 Offset: 0xFCD200 VA: 0x180FCEC00
	public void .ctor() { }

}

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7026
{	// Methods

	// RVA: 0xFBDF40 Offset: 0xFBC540 VA: 0x180FBDF40
	public void .ctor() { }

}

