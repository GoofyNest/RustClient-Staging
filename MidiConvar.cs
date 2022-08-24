public class MidiConvar : MonoBehaviour // TypeDefIndex: 9313
{	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0xE7430 Offset: 0xE6830 VA: 0x1800E7430
	public static bool debugMode; // 0x1
	private static MidiConvar Instance; // 0x8
	private List<MidiConvar.KnobBinding> knobBindings; // 0x18
	private List<MidiConvar.NoteBinding> noteBindings; // 0x20

	[ClientVar] // RVA: 0xE78E0 Offset: 0xE6CE0 VA: 0x1800E78E0
	public static bool Enabled { get; set; }


	public static bool get_Enabled() { }

	public static void set_Enabled(bool value) { }

	[ClientVar] // RVA: 0xE74E0 Offset: 0xE68E0 VA: 0x1800E74E0
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7540 Offset: 0xE6940 VA: 0x1800E7540
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7650 Offset: 0xE6A50 VA: 0x1800E7650
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7710 Offset: 0xE6B10 VA: 0x1800E7710
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7870 Offset: 0xE6C70 VA: 0x1800E7870
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	private void NoteOffDelegate(MidiChannel channel, int note) { }

	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	private int ChannelToInt(MidiChannel channel) { }

	private static bool CanRunBinds() { }

	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	private bool RemoveBindingForKnob(int knob, int channel) { }

	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	private void SaveBindings() { }

	private void LoadBindings() { }

	private string GetBindingsPath() { }

	private string PrintBindings() { }

	private void ClearAllBindings() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum MidiConvar.NoteType // TypeDefIndex: 9314
{	public int value__; // 0x0
	public const MidiConvar.NoteType NoteOn = 0;
	public const MidiConvar.NoteType NoteOff = 1;

}

private struct MidiConvar.KnobBinding // TypeDefIndex: 9315
{	public int knobNumber; // 0x0
	public string convar; // 0x8
	public float minValue; // 0x10
	public float maxValue; // 0x14
	public int channel; // 0x18
	public bool relative; // 0x1C

}

private struct MidiConvar.NoteBinding // TypeDefIndex: 9316
{	public int noteNumber; // 0x0
	public string[] convar; // 0x8
	public MidiConvar.NoteType noteType; // 0x10
	public int channel; // 0x14
	public bool cycled; // 0x18
	public int cycleIndex; // 0x1C

}

private struct MidiConvar.SavedBindings // TypeDefIndex: 9317
{	public List<MidiConvar.KnobBinding> knobs; // 0x0
	public List<MidiConvar.NoteBinding> notes; // 0x8

}

