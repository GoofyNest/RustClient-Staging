public class Properties // TypeDefIndex: 7055
{	// Fields
	private object Parent; // 0x10
	private RectTransform Canvas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action UpdateControlsFromValues; // 0x20
	public List<FieldInfo> Fields; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsDirty>k__BackingField; // 0x30

	// Properties
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC9870 Offset: 0xFC7E70 VA: 0x180FC9870
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC9910 Offset: 0xFC7F10 VA: 0x180FC9910
	public void remove_UpdateControlsFromValues(Action value) { }

	// RVA: 0xFC97C0 Offset: 0xFC7DC0 VA: 0x180FC97C0
	public void .ctor(object Parent, RectTransform Canvas) { }

	// RVA: 0xFC8110 Offset: 0xFC6710 VA: 0x180FC8110
	public void CreateControls() { }

	// RVA: 0xFC7920 Offset: 0xFC5F20 VA: 0x180FC7920
	private void AddControl(RustControl ctrl, LabelAttribute label) { }

	// RVA: 0xFC7F10 Offset: 0xFC6510 VA: 0x180FC7F10
	private bool CreateControl(FieldInfo f) { }

	// RVA: 0xFC8580 Offset: 0xFC6B80 VA: 0x180FC8580
	private bool CreateReadOnlyControl(FieldInfo f) { }

	// RVA: 0xFC88B0 Offset: 0xFC6EB0 VA: 0x180FC88B0
	private bool CreateStringControl(FieldInfo f) { }

	// RVA: 0xFC7C40 Offset: 0xFC6240 VA: 0x180FC7C40
	private bool CreateBooleanControl(FieldInfo f) { }

	// RVA: 0xFC81B0 Offset: 0xFC67B0 VA: 0x180FC81B0
	private bool CreateNumericControl(FieldInfo f) { }

	// RVA: 0xFC97A0 Offset: 0xFC7DA0 VA: 0x180FC97A0
	public void SyncControls() { }

	// RVA: 0xFC8C00 Offset: 0xFC7200 VA: 0x180FC8C00
	public Dictionary<string, object> GetValues() { }

	// RVA: 0xFC9620 Offset: 0xFC7C20 VA: 0x180FC9620
	public void SetValues(Dictionary<string, object> d) { }

	// RVA: 0xFC8FD0 Offset: 0xFC75D0 VA: 0x180FC8FD0
	public void SetValues(Dictionary<string, object> a, Dictionary<string, object> b, float delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	public void set_IsDirty(bool value) { }

	// RVA: 0xFC8FC0 Offset: 0xFC75C0 VA: 0x180FC8FC0
	private void MarkDirty() { }

	// RVA: 0xFC8DA0 Offset: 0xFC73A0 VA: 0x180FC8DA0
	public void Load(JProperty entry) { }

}

private sealed class Properties.<>c__DisplayClass10_0 // TypeDefIndex: 7056
{	// Fields
	public RustInput ctrl; // 0x10
	public FieldInfo f; // 0x18
	public Properties <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9250 Offset: 0xFD7850 VA: 0x180FD9250
	internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD92E0 Offset: 0xFD78E0 VA: 0x180FD92E0
	internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{	// Fields
	public RustButtonGroup ctrl; // 0x10
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9330 Offset: 0xFD7930 VA: 0x180FD9330
	internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{	// Fields
	public static readonly Properties.<>c <>9; // 0x0
	public static Func<OptionAttribute, Option> <>9__11_0; // 0x8

	// Methods

	// RVA: 0xFD9CB0 Offset: 0xFD82B0 VA: 0x180FD9CB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9120 Offset: 0xFD7720 VA: 0x180FD9120
	internal Option <CreateStringControl>b__11_0(OptionAttribute x) { }

}

private sealed class Properties.<>c__DisplayClass12_0 // TypeDefIndex: 7060
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18
	public RustToggle ctrl; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9630 Offset: 0xFD7C30 VA: 0x180FD9630
	internal void <CreateBooleanControl>b__0(bool x) { }

	// RVA: 0xFD96D0 Offset: 0xFD7CD0 VA: 0x180FD96D0
	internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9780 Offset: 0xFD7D80 VA: 0x180FD9780
	internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{	// Fields
	public RustSlider ctrl; // 0x10
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9820 Offset: 0xFD7E20 VA: 0x180FD9820
	internal void <CreateNumericControl>b__1() { }

}

