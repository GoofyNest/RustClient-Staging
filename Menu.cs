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

	// RVA: 0xFC5180 Offset: 0xFC3780 VA: 0x180FC5180 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC5220 Offset: 0xFC3820 VA: 0x180FC5220
	public void Build() { }

	// RVA: 0xFC58D0 Offset: 0xFC3ED0 VA: 0x180FC58D0
	private void OnOptionSelected(Option option) { }

	// RVA: 0xFC5710 Offset: 0xFC3D10 VA: 0x180FC5710
	private IEnumerable<Option> GetOptions() { }

	// RVA: 0xFC59D0 Offset: 0xFC3FD0 VA: 0x180FC59D0
	internal void Popup(RectTransform source) { }

	// RVA: 0xFC6660 Offset: 0xFC4C60 VA: 0x180FC6660
	private void RestrainToScreen() { }

	// RVA: 0xFC5070 Offset: 0xFC3670 VA: 0x180FC5070 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC69B0 Offset: 0xFC4FB0 VA: 0x180FC69B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC69A0 Offset: 0xFC4FA0 VA: 0x180FC69A0
	private void <Awake>b__11_0(string x) { }

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7009
{	// Methods

	// RVA: 0xFBED20 Offset: 0xFBD320 VA: 0x180FBED20
	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7010
{	// Fields
	public Option option; // 0x10
	public Menu <>4__this; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9510 Offset: 0xFD7B10 VA: 0x180FD9510
	internal void <Build>b__0() { }

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7011
{	// Fields
	public string searchString; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD98D0 Offset: 0xFD7ED0 VA: 0x180FD98D0
	internal bool <GetOptions>b__1(Option x) { }

}

private sealed class Menu.<>c // TypeDefIndex: 7012
{	// Fields
	public static readonly Menu.<>c <>9; // 0x0
	public static Func<Option, Option> <>9__14_0; // 0x8

	// Methods

	// RVA: 0xFD9DD0 Offset: 0xFD83D0 VA: 0x180FD9DD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD91B0 Offset: 0xFD77B0 VA: 0x180FD91B0
	internal Option <GetOptions>b__14_0(Option x) { }

}

