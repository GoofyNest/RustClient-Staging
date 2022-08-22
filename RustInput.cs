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

	// RVA: 0xFCDDD0 Offset: 0xFCC3D0 VA: 0x180FCDDD0
	public RustText get_Placeholder() { }

	// RVA: 0xFCDDB0 Offset: 0xFCC3B0 VA: 0x180FCDDB0
	public bool get_IsFocused() { }

	// RVA: 0xFCDE60 Offset: 0xFCC460 VA: 0x180FCDE60
	public string get_Value() { }

	// RVA: 0xFCDE60 Offset: 0xFCC460 VA: 0x180FCDE60
	public string get_Text() { }

	// RVA: 0xFCDE80 Offset: 0xFCC480 VA: 0x180FCDE80
	public void set_Text(string value) { }

	// RVA: 0xFCD870 Offset: 0xFCBE70 VA: 0x180FCD870 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCDC10 Offset: 0xFCC210 VA: 0x180FCDC10 Slot: 28
	public override StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFCD650 Offset: 0xFCBC50 VA: 0x180FCD650 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCDBB0 Offset: 0xFCC1B0 VA: 0x180FCDBB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCDA70 Offset: 0xFCC070 VA: 0x180FCDA70
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCDAD0 Offset: 0xFCC0D0 VA: 0x180FCDAD0
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCDB30 Offset: 0xFCC130 VA: 0x180FCDB30
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCDB90 Offset: 0xFCC190 VA: 0x180FCDB90
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCDB90 Offset: 0xFCC190 VA: 0x180FCDB90
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7022
{	// Methods

	// RVA: 0xFBECE0 Offset: 0xFBD2E0 VA: 0x180FBECE0
	public void .ctor() { }

}

