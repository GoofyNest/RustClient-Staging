public class RustButtonGroup : RustControl // TypeDefIndex: 7014
{	// Fields
	public Option[] Options; // 0x30
	public string ButtonStyle; // 0x38
	private int CurrentOption; // 0x40
	public RustButtonGroup.ChangedEvent OnChanged; // 0x48

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFCA880 Offset: 0xFC8E80 VA: 0x180FCA880
	public Option get_Value() { }

	// RVA: 0xFCA290 Offset: 0xFC8890 VA: 0x180FCA290 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCA700 Offset: 0xFC8D00 VA: 0x180FCA700
	public void SetOption(int i) { }

	// RVA: 0xFCA660 Offset: 0xFC8C60 VA: 0x180FCA660
	public void SetOption(string value) { }

	// RVA: 0xFCA540 Offset: 0xFC8B40 VA: 0x180FCA540
	private void ButtonPressed(int i) { }

	// RVA: 0xFCA5F0 Offset: 0xFC8BF0 VA: 0x180FCA5F0
	public void SetOptionDefault() { }

	// RVA: 0xFCA2B0 Offset: 0xFC88B0 VA: 0x180FCA2B0
	public void BuildContents() { }

	// RVA: 0xFCA810 Offset: 0xFC8E10 VA: 0x180FCA810
	public void .ctor() { }

}

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7015
{	// Methods

	// RVA: 0xFBE340 Offset: 0xFBC940 VA: 0x180FBE340
	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7016
{	// Fields
	public int buttonNumber; // 0x10
	public RustButtonGroup <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD89B0 Offset: 0xFD6FB0 VA: 0x180FD89B0
	internal void <BuildContents>b__0() { }

}

