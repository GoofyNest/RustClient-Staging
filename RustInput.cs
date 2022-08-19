public class RustInput : RustControl // TypeDefIndex: 7021
{	// Fields
	public TMP_InputField InputField; // 0x30
	public Image Background; // 0x38
	public RustInput.ChangedEvent OnValueChanged; // 0x40
	public RustInput.ChangedEvent OnEndEdit; // 0x48
	public RustInput.ChangedEvent OnSubmit; // 0x50

	// Properties
	public RustText Placeholder { get; }
	public bool IsFocused { get; }
	public string Value { get; }
	public string Text { get; set; }
	public override StyleAsset.Group CurrentStyleCollection { get; }

	// Methods

	// RVA: 0xFCD070 Offset: 0xFCB670 VA: 0x180FCD070
	public RustText get_Placeholder() { }

	// RVA: 0xFCD050 Offset: 0xFCB650 VA: 0x180FCD050
	public bool get_IsFocused() { }

	// RVA: 0xFCD100 Offset: 0xFCB700 VA: 0x180FCD100
	public string get_Value() { }

	// RVA: 0xFCD100 Offset: 0xFCB700 VA: 0x180FCD100
	public string get_Text() { }

	// RVA: 0xFCD120 Offset: 0xFCB720 VA: 0x180FCD120
	public void set_Text(string value) { }

	// RVA: 0xFCCB10 Offset: 0xFCB110 VA: 0x180FCCB10 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCCEB0 Offset: 0xFCB4B0 VA: 0x180FCCEB0 Slot: 28
	public override StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFCC8F0 Offset: 0xFCAEF0 VA: 0x180FCC8F0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCCE50 Offset: 0xFCB450 VA: 0x180FCCE50
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCCD10 Offset: 0xFCB310 VA: 0x180FCCD10
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCCD70 Offset: 0xFCB370 VA: 0x180FCCD70
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCCDD0 Offset: 0xFCB3D0 VA: 0x180FCCDD0
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCCE30 Offset: 0xFCB430 VA: 0x180FCCE30
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCCE30 Offset: 0xFCB430 VA: 0x180FCCE30
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7022
{	// Methods

	// RVA: 0xFBDF80 Offset: 0xFBC580 VA: 0x180FBDF80
	public void .ctor() { }

}

