public class RustButtonGroup : RustControl // TypeDefIndex: 7014
{	// Fields
	public Option[] Options; // 0x30
	public string ButtonStyle; // 0x38
	private int CurrentOption; // 0x40
	public RustButtonGroup.ChangedEvent OnChanged; // 0x48

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFCA5C0 Offset: 0xFC8BC0 VA: 0x180FCA5C0
	public Option get_Value() { }

	// RVA: 0xFC9FD0 Offset: 0xFC85D0 VA: 0x180FC9FD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCA440 Offset: 0xFC8A40 VA: 0x180FCA440
	public void SetOption(int i) { }

	// RVA: 0xFCA3A0 Offset: 0xFC89A0 VA: 0x180FCA3A0
	public void SetOption(string value) { }

	// RVA: 0xFCA280 Offset: 0xFC8880 VA: 0x180FCA280
	private void ButtonPressed(int i) { }

	// RVA: 0xFCA330 Offset: 0xFC8930 VA: 0x180FCA330
	public void SetOptionDefault() { }

	// RVA: 0xFC9FF0 Offset: 0xFC85F0 VA: 0x180FC9FF0
	public void BuildContents() { }

	// RVA: 0xFCA550 Offset: 0xFC8B50 VA: 0x180FCA550
	public void .ctor() { }

}

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7015
{	// Methods

	// RVA: 0xFBE080 Offset: 0xFBC680 VA: 0x180FBE080
	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7016
{	// Fields
	public int buttonNumber; // 0x10
	public RustButtonGroup <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD86F0 Offset: 0xFD6CF0 VA: 0x180FD86F0
	internal void <BuildContents>b__0() { }

}

