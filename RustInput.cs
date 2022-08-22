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

	// RVA: 0xFCD330 Offset: 0xFCB930 VA: 0x180FCD330
	public RustText get_Placeholder() { }

	// RVA: 0xFCD310 Offset: 0xFCB910 VA: 0x180FCD310
	public bool get_IsFocused() { }

	// RVA: 0xFCD3C0 Offset: 0xFCB9C0 VA: 0x180FCD3C0
	public string get_Value() { }

	// RVA: 0xFCD3C0 Offset: 0xFCB9C0 VA: 0x180FCD3C0
	public string get_Text() { }

	// RVA: 0xFCD3E0 Offset: 0xFCB9E0 VA: 0x180FCD3E0
	public void set_Text(string value) { }

	// RVA: 0xFCCDD0 Offset: 0xFCB3D0 VA: 0x180FCCDD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCD170 Offset: 0xFCB770 VA: 0x180FCD170 Slot: 28
	public override StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFCCBB0 Offset: 0xFCB1B0 VA: 0x180FCCBB0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCD110 Offset: 0xFCB710 VA: 0x180FCD110
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCCFD0 Offset: 0xFCB5D0 VA: 0x180FCCFD0
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCD030 Offset: 0xFCB630 VA: 0x180FCD030
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCD090 Offset: 0xFCB690 VA: 0x180FCD090
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCD0F0 Offset: 0xFCB6F0 VA: 0x180FCD0F0
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCD0F0 Offset: 0xFCB6F0 VA: 0x180FCD0F0
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7022
{	// Methods

	// RVA: 0xFBE240 Offset: 0xFBC840 VA: 0x180FBE240
	public void .ctor() { }

}

