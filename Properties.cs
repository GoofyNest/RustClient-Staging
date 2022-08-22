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
	// RVA: 0xFC8DD0 Offset: 0xFC73D0 VA: 0x180FC8DD0
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC8E70 Offset: 0xFC7470 VA: 0x180FC8E70
	public void remove_UpdateControlsFromValues(Action value) { }

	// RVA: 0xFC8D20 Offset: 0xFC7320 VA: 0x180FC8D20
	public void .ctor(object Parent, RectTransform Canvas) { }

	// RVA: 0xFC7670 Offset: 0xFC5C70 VA: 0x180FC7670
	public void CreateControls() { }

	// RVA: 0xFC6E80 Offset: 0xFC5480 VA: 0x180FC6E80
	private void AddControl(RustControl ctrl, LabelAttribute label) { }

	// RVA: 0xFC7470 Offset: 0xFC5A70 VA: 0x180FC7470
	private bool CreateControl(FieldInfo f) { }

	// RVA: 0xFC7AE0 Offset: 0xFC60E0 VA: 0x180FC7AE0
	private bool CreateReadOnlyControl(FieldInfo f) { }

	// RVA: 0xFC7E10 Offset: 0xFC6410 VA: 0x180FC7E10
	private bool CreateStringControl(FieldInfo f) { }

	// RVA: 0xFC71A0 Offset: 0xFC57A0 VA: 0x180FC71A0
	private bool CreateBooleanControl(FieldInfo f) { }

	// RVA: 0xFC7710 Offset: 0xFC5D10 VA: 0x180FC7710
	private bool CreateNumericControl(FieldInfo f) { }

	// RVA: 0xFC8D00 Offset: 0xFC7300 VA: 0x180FC8D00
	public void SyncControls() { }

	// RVA: 0xFC8160 Offset: 0xFC6760 VA: 0x180FC8160
	public Dictionary<string, object> GetValues() { }

	// RVA: 0xFC8B80 Offset: 0xFC7180 VA: 0x180FC8B80
	public void SetValues(Dictionary<string, object> d) { }

	// RVA: 0xFC8530 Offset: 0xFC6B30 VA: 0x180FC8530
	public void SetValues(Dictionary<string, object> a, Dictionary<string, object> b, float delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	public void set_IsDirty(bool value) { }

	// RVA: 0xFC8520 Offset: 0xFC6B20 VA: 0x180FC8520
	private void MarkDirty() { }

	// RVA: 0xFC8300 Offset: 0xFC6900 VA: 0x180FC8300
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

	// RVA: 0xFD87B0 Offset: 0xFD6DB0 VA: 0x180FD87B0
	internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8840 Offset: 0xFD6E40 VA: 0x180FD8840
	internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{	// Fields
	public RustButtonGroup ctrl; // 0x10
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8890 Offset: 0xFD6E90 VA: 0x180FD8890
	internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{	// Fields
	public static readonly Properties.<>c <>9; // 0x0
	public static Func<OptionAttribute, Option> <>9__11_0; // 0x8

	// Methods

	// RVA: 0xFD9210 Offset: 0xFD7810 VA: 0x180FD9210
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8680 Offset: 0xFD6C80 VA: 0x180FD8680
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

	// RVA: 0xFD8B90 Offset: 0xFD7190 VA: 0x180FD8B90
	internal void <CreateBooleanControl>b__0(bool x) { }

	// RVA: 0xFD8C30 Offset: 0xFD7230 VA: 0x180FD8C30
	internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8CE0 Offset: 0xFD72E0 VA: 0x180FD8CE0
	internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{	// Fields
	public RustSlider ctrl; // 0x10
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8D80 Offset: 0xFD7380 VA: 0x180FD8D80
	internal void <CreateNumericControl>b__1() { }

}

