public class Properties // TypeDefIndex: 7055
{	// Fields
	private object Parent; // 0x10
	private RectTransform Canvas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action UpdateControlsFromValues; // 0x20
	public List<FieldInfo> Fields; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsDirty>k__BackingField; // 0x30

	// Properties
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8B10 Offset: 0xFC7110 VA: 0x180FC8B10
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8BB0 Offset: 0xFC71B0 VA: 0x180FC8BB0
	public void remove_UpdateControlsFromValues(Action value) { }

	// RVA: 0xFC8A60 Offset: 0xFC7060 VA: 0x180FC8A60
	public void .ctor(object Parent, RectTransform Canvas) { }

	// RVA: 0xFC73B0 Offset: 0xFC59B0 VA: 0x180FC73B0
	public void CreateControls() { }

	// RVA: 0xFC6BC0 Offset: 0xFC51C0 VA: 0x180FC6BC0
	private void AddControl(RustControl ctrl, LabelAttribute label) { }

	// RVA: 0xFC71B0 Offset: 0xFC57B0 VA: 0x180FC71B0
	private bool CreateControl(FieldInfo f) { }

	// RVA: 0xFC7820 Offset: 0xFC5E20 VA: 0x180FC7820
	private bool CreateReadOnlyControl(FieldInfo f) { }

	// RVA: 0xFC7B50 Offset: 0xFC6150 VA: 0x180FC7B50
	private bool CreateStringControl(FieldInfo f) { }

	// RVA: 0xFC6EE0 Offset: 0xFC54E0 VA: 0x180FC6EE0
	private bool CreateBooleanControl(FieldInfo f) { }

	// RVA: 0xFC7450 Offset: 0xFC5A50 VA: 0x180FC7450
	private bool CreateNumericControl(FieldInfo f) { }

	// RVA: 0xFC8A40 Offset: 0xFC7040 VA: 0x180FC8A40
	public void SyncControls() { }

	// RVA: 0xFC7EA0 Offset: 0xFC64A0 VA: 0x180FC7EA0
	public Dictionary<string, object> GetValues() { }

	// RVA: 0xFC88C0 Offset: 0xFC6EC0 VA: 0x180FC88C0
	public void SetValues(Dictionary<string, object> d) { }

	// RVA: 0xFC8270 Offset: 0xFC6870 VA: 0x180FC8270
	public void SetValues(Dictionary<string, object> a, Dictionary<string, object> b, float delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	public void set_IsDirty(bool value) { }

	// RVA: 0xFC8260 Offset: 0xFC6860 VA: 0x180FC8260
	private void MarkDirty() { }

	// RVA: 0xFC8040 Offset: 0xFC6640 VA: 0x180FC8040
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

	// RVA: 0xFD84F0 Offset: 0xFD6AF0 VA: 0x180FD84F0
	internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8580 Offset: 0xFD6B80 VA: 0x180FD8580
	internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{	// Fields
	public RustButtonGroup ctrl; // 0x10
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD85D0 Offset: 0xFD6BD0 VA: 0x180FD85D0
	internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{	// Fields
	public static readonly Properties.<>c <>9; // 0x0
	public static Func<OptionAttribute, Option> <>9__11_0; // 0x8

	// Methods

	// RVA: 0xFD8F50 Offset: 0xFD7550 VA: 0x180FD8F50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD83C0 Offset: 0xFD69C0 VA: 0x180FD83C0
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

	// RVA: 0xFD88D0 Offset: 0xFD6ED0 VA: 0x180FD88D0
	internal void <CreateBooleanControl>b__0(bool x) { }

	// RVA: 0xFD8970 Offset: 0xFD6F70 VA: 0x180FD8970
	internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8A20 Offset: 0xFD7020 VA: 0x180FD8A20
	internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{	// Fields
	public RustSlider ctrl; // 0x10
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8AC0 Offset: 0xFD70C0 VA: 0x180FD8AC0
	internal void <CreateNumericControl>b__1() { }

}

