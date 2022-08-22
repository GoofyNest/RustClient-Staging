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

	// RVA: 0xFC46E0 Offset: 0xFC2CE0 VA: 0x180FC46E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC4780 Offset: 0xFC2D80 VA: 0x180FC4780
	public void Build() { }

	// RVA: 0xFC4E30 Offset: 0xFC3430 VA: 0x180FC4E30
	private void OnOptionSelected(Option option) { }

	// RVA: 0xFC4C70 Offset: 0xFC3270 VA: 0x180FC4C70
	private IEnumerable<Option> GetOptions() { }

	// RVA: 0xFC4F30 Offset: 0xFC3530 VA: 0x180FC4F30
	internal void Popup(RectTransform source) { }

	// RVA: 0xFC5BC0 Offset: 0xFC41C0 VA: 0x180FC5BC0
	private void RestrainToScreen() { }

	// RVA: 0xFC45D0 Offset: 0xFC2BD0 VA: 0x180FC45D0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC5F10 Offset: 0xFC4510 VA: 0x180FC5F10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC5F00 Offset: 0xFC4500 VA: 0x180FC5F00
	private void <Awake>b__11_0(string x) { }

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7009
{	// Methods

	// RVA: 0xFBE280 Offset: 0xFBC880 VA: 0x180FBE280
	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7010
{	// Fields
	public Option option; // 0x10
	public Menu <>4__this; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8A70 Offset: 0xFD7070 VA: 0x180FD8A70
	internal void <Build>b__0() { }

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7011
{	// Fields
	public string searchString; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8E30 Offset: 0xFD7430 VA: 0x180FD8E30
	internal bool <GetOptions>b__1(Option x) { }

}

private sealed class Menu.<>c // TypeDefIndex: 7012
{	// Fields
	public static readonly Menu.<>c <>9; // 0x0
	public static Func<Option, Option> <>9__14_0; // 0x8

	// Methods

	// RVA: 0xFD9330 Offset: 0xFD7930 VA: 0x180FD9330
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8710 Offset: 0xFD6D10 VA: 0x180FD8710
	internal Option <GetOptions>b__14_0(Option x) { }

}

