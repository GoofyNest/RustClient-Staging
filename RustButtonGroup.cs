public class RustButtonGroup : RustControl // TypeDefIndex: 7014
{	// Fields
	public Option[] Options; // 0x30
	public string ButtonStyle; // 0x38
	private int CurrentOption; // 0x40
	public RustButtonGroup.ChangedEvent OnChanged; // 0x48

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFCB320 Offset: 0xFC9920 VA: 0x180FCB320
	public Option get_Value() { }

	// RVA: 0xFCAD30 Offset: 0xFC9330 VA: 0x180FCAD30 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCB1A0 Offset: 0xFC97A0 VA: 0x180FCB1A0
	public void SetOption(int i) { }

	// RVA: 0xFCB100 Offset: 0xFC9700 VA: 0x180FCB100
	public void SetOption(string value) { }

	// RVA: 0xFCAFE0 Offset: 0xFC95E0 VA: 0x180FCAFE0
	private void ButtonPressed(int i) { }

	// RVA: 0xFCB090 Offset: 0xFC9690 VA: 0x180FCB090
	public void SetOptionDefault() { }

	// RVA: 0xFCAD50 Offset: 0xFC9350 VA: 0x180FCAD50
	public void BuildContents() { }

	// RVA: 0xFCB2B0 Offset: 0xFC98B0 VA: 0x180FCB2B0
	public void .ctor() { }

}

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7015
{	// Methods

	// RVA: 0xFBEDE0 Offset: 0xFBD3E0 VA: 0x180FBEDE0
	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7016
{	// Fields
	public int buttonNumber; // 0x10
	public RustButtonGroup <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9450 Offset: 0xFD7A50 VA: 0x180FD9450
	internal void <BuildContents>b__0() { }

}

