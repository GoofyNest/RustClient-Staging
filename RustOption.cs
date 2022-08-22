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

	// RVA: 0xFBF0C0 Offset: 0xFBD6C0 VA: 0x180FBF0C0
	public Option get_Value() { }

	// RVA: 0xFCEAD0 Offset: 0xFCD0D0 VA: 0x180FCEAD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCEE40 Offset: 0xFCD440 VA: 0x180FCEE40
	public void SetOptions(Option[] options) { }

	// RVA: 0xFCEDC0 Offset: 0xFCD3C0 VA: 0x180FCEDC0
	public void SetOption(int i) { }

	// RVA: 0xFCED60 Offset: 0xFCD360 VA: 0x180FCED60
	public void SetOptionDefault() { }

	// RVA: 0xFCEBB0 Offset: 0xFCD1B0 VA: 0x180FCEBB0
	public void OnLeft() { }

	// RVA: 0xFCEC50 Offset: 0xFCD250 VA: 0x180FCEC50
	public void OnRight() { }

	// RVA: 0xFCE9B0 Offset: 0xFCCFB0 VA: 0x180FCE9B0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCEEC0 Offset: 0xFCD4C0 VA: 0x180FCEEC0
	public void .ctor() { }

}

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7026
{	// Methods

	// RVA: 0xFBE200 Offset: 0xFBC800 VA: 0x180FBE200
	public void .ctor() { }

}

