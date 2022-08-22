public class MidiConvar : MonoBehaviour // TypeDefIndex: 9313
{	// Fields
	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0xE7330 Offset: 0xE6730 VA: 0x1800E7330
	public static bool debugMode; // 0x1
	private static MidiConvar Instance; // 0x8
	private List<MidiConvar.KnobBinding> knobBindings; // 0x18
	private List<MidiConvar.NoteBinding> noteBindings; // 0x20

	// Properties
	[ClientVar] // RVA: 0xE77C0 Offset: 0xE6BC0 VA: 0x1800E77C0
	public static bool Enabled { get; set; }

	// Methods

	// RVA: 0x970130 Offset: 0x96E730 VA: 0x180970130
	public static bool get_Enabled() { }

	// RVA: 0x970190 Offset: 0x96E790 VA: 0x180970190
	public static void set_Enabled(bool value) { }

	[ClientVar] // RVA: 0xE73E0 Offset: 0xE67E0 VA: 0x1800E73E0
	// RVA: 0x96D3F0 Offset: 0x96B9F0 VA: 0x18096D3F0
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7420 Offset: 0xE6820 VA: 0x1800E7420
	// RVA: 0x96CF80 Offset: 0x96B580 VA: 0x18096CF80
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7530 Offset: 0xE6930 VA: 0x1800E7530
	// RVA: 0x96CD30 Offset: 0x96B330 VA: 0x18096CD30
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE75F0 Offset: 0xE69F0 VA: 0x1800E75F0
	// RVA: 0x96CAE0 Offset: 0x96B0E0 VA: 0x18096CAE0
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x96EE70 Offset: 0x96D470 VA: 0x18096EE70
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x96DAC0 Offset: 0x96C0C0 VA: 0x18096DAC0
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7750 Offset: 0xE6B50 VA: 0x1800E7750
	// RVA: 0x96FC00 Offset: 0x96E200 VA: 0x18096FC00
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	// RVA: 0x96ECA0 Offset: 0x96D2A0 VA: 0x18096ECA0
	private void OnEnable() { }

	// RVA: 0x96EB10 Offset: 0x96D110 VA: 0x18096EB10
	private void OnDisable() { }

	// RVA: 0x970060 Offset: 0x96E660 VA: 0x180970060
	private void Update() { }

	// RVA: 0x96DC80 Offset: 0x96C280 VA: 0x18096DC80
	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	// RVA: 0x96E3D0 Offset: 0x96C9D0 VA: 0x18096E3D0
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x96E770 Offset: 0x96CD70 VA: 0x18096E770
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x96D980 Offset: 0x96BF80 VA: 0x18096D980
	private int ChannelToInt(MidiChannel channel) { }

	// RVA: 0x96D8D0 Offset: 0x96BED0 VA: 0x18096D8D0
	private static bool CanRunBinds() { }

	// RVA: 0x96C680 Offset: 0x96AC80 VA: 0x18096C680
	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	// RVA: 0x96C780 Offset: 0x96AD80 VA: 0x18096C780
	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	// RVA: 0x96C870 Offset: 0x96AE70 VA: 0x18096C870
	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	// RVA: 0x96FD00 Offset: 0x96E300 VA: 0x18096FD00
	private bool RemoveBindingForKnob(int knob, int channel) { }

	// RVA: 0x96FE10 Offset: 0x96E410 VA: 0x18096FE10
	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	// RVA: 0x96FF50 Offset: 0x96E550 VA: 0x18096FF50
	private void SaveBindings() { }

	// RVA: 0x96E200 Offset: 0x96C800 VA: 0x18096E200
	private void LoadBindings() { }

	// RVA: 0x96DC10 Offset: 0x96C210 VA: 0x18096DC10
	private string GetBindingsPath() { }

	// RVA: 0x96EF80 Offset: 0x96D580 VA: 0x18096EF80
	private string PrintBindings() { }

	// RVA: 0x96DA50 Offset: 0x96C050 VA: 0x18096DA50
	private void ClearAllBindings() { }

	// RVA: 0x970090 Offset: 0x96E690 VA: 0x180970090
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public enum MidiConvar.NoteType // TypeDefIndex: 9314
{	// Fields
	public int value__; // 0x0
	public const MidiConvar.NoteType NoteOn = 0;
	public const MidiConvar.NoteType NoteOff = 1;

}

private struct MidiConvar.KnobBinding // TypeDefIndex: 9315
{	// Fields
	public int knobNumber; // 0x0
	public string convar; // 0x8
	public float minValue; // 0x10
	public float maxValue; // 0x14
	public int channel; // 0x18
	public bool relative; // 0x1C

}

private struct MidiConvar.NoteBinding // TypeDefIndex: 9316
{	// Fields
	public int noteNumber; // 0x0
	public string[] convar; // 0x8
	public MidiConvar.NoteType noteType; // 0x10
	public int channel; // 0x14
	public bool cycled; // 0x18
	public int cycleIndex; // 0x1C

}

private struct MidiConvar.SavedBindings // TypeDefIndex: 9317
{	// Fields
	public List<MidiConvar.KnobBinding> knobs; // 0x0
	public List<MidiConvar.NoteBinding> notes; // 0x8

}

