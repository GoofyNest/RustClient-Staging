public class Menu : RustControl // TypeDefIndex: 7008
{	// Fields
	public bool AllowFiltering; // 0x30
	public int MaxResults; // 0x34
	public Image Border; // 0x38
	public Image Background; // 0x40
	public Option[] Options; // 0x48
	public RectTransform OptionCanvas; // 0x50
	public RustInput FilterField; // 0x58
	public Option SelectedOption; // 0x60
	public Menu.ChangedEvent OnSelected; // 0x80
	public Blocker Blocker; // 0x88

	// Methods

	// RVA: 0xFC4420 Offset: 0xFC2A20 VA: 0x180FC4420 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC44C0 Offset: 0xFC2AC0 VA: 0x180FC44C0
	public void Build() { }

	// RVA: 0xFC4B70 Offset: 0xFC3170 VA: 0x180FC4B70
	private void OnOptionSelected(Option option) { }

	// RVA: 0xFC49B0 Offset: 0xFC2FB0 VA: 0x180FC49B0
	private IEnumerable<Option> GetOptions() { }

	// RVA: 0xFC4C70 Offset: 0xFC3270 VA: 0x180FC4C70
	internal void Popup(RectTransform source) { }

	// RVA: 0xFC5900 Offset: 0xFC3F00 VA: 0x180FC5900
	private void RestrainToScreen() { }

	// RVA: 0xFC4310 Offset: 0xFC2910 VA: 0x180FC4310 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC5C50 Offset: 0xFC4250 VA: 0x180FC5C50
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC5C40 Offset: 0xFC4240 VA: 0x180FC5C40
	private void <Awake>b__11_0(string x) { }

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7009
{	// Methods

	// RVA: 0xFBDFC0 Offset: 0xFBC5C0 VA: 0x180FBDFC0
	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7010
{	// Fields
	public Option option; // 0x10
	public Menu <>4__this; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD87B0 Offset: 0xFD6DB0 VA: 0x180FD87B0
	internal void <Build>b__0() { }

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7011
{	// Fields
	public string searchString; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8B70 Offset: 0xFD7170 VA: 0x180FD8B70
	internal bool <GetOptions>b__1(Option x) { }

}

private sealed class Menu.<>c // TypeDefIndex: 7012
{	// Fields
	public static readonly Menu.<>c <>9; // 0x0
	public static Func<Option, Option> <>9__14_0; // 0x8

	// Methods

	// RVA: 0xFD9070 Offset: 0xFD7670 VA: 0x180FD9070
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8450 Offset: 0xFD6A50 VA: 0x180FD8450
	internal Option <GetOptions>b__14_0(Option x) { }

}

