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

	// RVA: 0x970630 Offset: 0x96EC30 VA: 0x180970630
	public static bool get_Enabled() { }

	// RVA: 0x970690 Offset: 0x96EC90 VA: 0x180970690
	public static void set_Enabled(bool value) { }

	[ClientVar] // RVA: 0xE73E0 Offset: 0xE67E0 VA: 0x1800E73E0
	// RVA: 0x96D8F0 Offset: 0x96BEF0 VA: 0x18096D8F0
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7420 Offset: 0xE6820 VA: 0x1800E7420
	// RVA: 0x96D480 Offset: 0x96BA80 VA: 0x18096D480
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7530 Offset: 0xE6930 VA: 0x1800E7530
	// RVA: 0x96D230 Offset: 0x96B830 VA: 0x18096D230
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE75F0 Offset: 0xE69F0 VA: 0x1800E75F0
	// RVA: 0x96CFE0 Offset: 0x96B5E0 VA: 0x18096CFE0
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x96F370 Offset: 0x96D970 VA: 0x18096F370
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x96DFC0 Offset: 0x96C5C0 VA: 0x18096DFC0
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7750 Offset: 0xE6B50 VA: 0x1800E7750
	// RVA: 0x970100 Offset: 0x96E700 VA: 0x180970100
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	// RVA: 0x96F1A0 Offset: 0x96D7A0 VA: 0x18096F1A0
	private void OnEnable() { }

	// RVA: 0x96F010 Offset: 0x96D610 VA: 0x18096F010
	private void OnDisable() { }

	// RVA: 0x970560 Offset: 0x96EB60 VA: 0x180970560
	private void Update() { }

	// RVA: 0x96E180 Offset: 0x96C780 VA: 0x18096E180
	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	// RVA: 0x96E8D0 Offset: 0x96CED0 VA: 0x18096E8D0
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x96EC70 Offset: 0x96D270 VA: 0x18096EC70
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x96DE80 Offset: 0x96C480 VA: 0x18096DE80
	private int ChannelToInt(MidiChannel channel) { }

	// RVA: 0x96DDD0 Offset: 0x96C3D0 VA: 0x18096DDD0
	private static bool CanRunBinds() { }

	// RVA: 0x96CB80 Offset: 0x96B180 VA: 0x18096CB80
	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	// RVA: 0x96CC80 Offset: 0x96B280 VA: 0x18096CC80
	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	// RVA: 0x96CD70 Offset: 0x96B370 VA: 0x18096CD70
	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	// RVA: 0x970200 Offset: 0x96E800 VA: 0x180970200
	private bool RemoveBindingForKnob(int knob, int channel) { }

	// RVA: 0x970310 Offset: 0x96E910 VA: 0x180970310
	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	// RVA: 0x970450 Offset: 0x96EA50 VA: 0x180970450
	private void SaveBindings() { }

	// RVA: 0x96E700 Offset: 0x96CD00 VA: 0x18096E700
	private void LoadBindings() { }

	// RVA: 0x96E110 Offset: 0x96C710 VA: 0x18096E110
	private string GetBindingsPath() { }

	// RVA: 0x96F480 Offset: 0x96DA80 VA: 0x18096F480
	private string PrintBindings() { }

	// RVA: 0x96DF50 Offset: 0x96C550 VA: 0x18096DF50
	private void ClearAllBindings() { }

	// RVA: 0x970590 Offset: 0x96EB90 VA: 0x180970590
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

