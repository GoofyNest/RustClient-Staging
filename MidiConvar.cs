public class MidiConvar : MonoBehaviour // TypeDefIndex: 9313
{	// Fields
	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0xE72B0 Offset: 0xE66B0 VA: 0x1800E72B0
	public static bool debugMode; // 0x1
	private static MidiConvar Instance; // 0x8
	private List<MidiConvar.KnobBinding> knobBindings; // 0x18
	private List<MidiConvar.NoteBinding> noteBindings; // 0x20

	// Properties
	[ClientVar] // RVA: 0xE76F0 Offset: 0xE6AF0 VA: 0x1800E76F0
	public static bool Enabled { get; set; }

	// Methods

	// RVA: 0x970020 Offset: 0x96E620 VA: 0x180970020
	public static bool get_Enabled() { }

	// RVA: 0x970080 Offset: 0x96E680 VA: 0x180970080
	public static void set_Enabled(bool value) { }

	[ClientVar] // RVA: 0xE72F0 Offset: 0xE66F0 VA: 0x1800E72F0
	// RVA: 0x96D2E0 Offset: 0x96B8E0 VA: 0x18096D2E0
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7380 Offset: 0xE6780 VA: 0x1800E7380
	// RVA: 0x96CE70 Offset: 0x96B470 VA: 0x18096CE70
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7490 Offset: 0xE6890 VA: 0x1800E7490
	// RVA: 0x96CC20 Offset: 0x96B220 VA: 0x18096CC20
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7550 Offset: 0xE6950 VA: 0x1800E7550
	// RVA: 0x96C9D0 Offset: 0x96AFD0 VA: 0x18096C9D0
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x96ED60 Offset: 0x96D360 VA: 0x18096ED60
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x96D9B0 Offset: 0x96BFB0 VA: 0x18096D9B0
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE76B0 Offset: 0xE6AB0 VA: 0x1800E76B0
	// RVA: 0x96FAF0 Offset: 0x96E0F0 VA: 0x18096FAF0
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	// RVA: 0x96EB90 Offset: 0x96D190 VA: 0x18096EB90
	private void OnEnable() { }

	// RVA: 0x96EA00 Offset: 0x96D000 VA: 0x18096EA00
	private void OnDisable() { }

	// RVA: 0x96FF50 Offset: 0x96E550 VA: 0x18096FF50
	private void Update() { }

	// RVA: 0x96DB70 Offset: 0x96C170 VA: 0x18096DB70
	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	// RVA: 0x96E2C0 Offset: 0x96C8C0 VA: 0x18096E2C0
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x96E660 Offset: 0x96CC60 VA: 0x18096E660
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x96D870 Offset: 0x96BE70 VA: 0x18096D870
	private int ChannelToInt(MidiChannel channel) { }

	// RVA: 0x96D7C0 Offset: 0x96BDC0 VA: 0x18096D7C0
	private static bool CanRunBinds() { }

	// RVA: 0x96C570 Offset: 0x96AB70 VA: 0x18096C570
	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	// RVA: 0x96C670 Offset: 0x96AC70 VA: 0x18096C670
	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	// RVA: 0x96C760 Offset: 0x96AD60 VA: 0x18096C760
	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	// RVA: 0x96FBF0 Offset: 0x96E1F0 VA: 0x18096FBF0
	private bool RemoveBindingForKnob(int knob, int channel) { }

	// RVA: 0x96FD00 Offset: 0x96E300 VA: 0x18096FD00
	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	// RVA: 0x96FE40 Offset: 0x96E440 VA: 0x18096FE40
	private void SaveBindings() { }

	// RVA: 0x96E0F0 Offset: 0x96C6F0 VA: 0x18096E0F0
	private void LoadBindings() { }

	// RVA: 0x96DB00 Offset: 0x96C100 VA: 0x18096DB00
	private string GetBindingsPath() { }

	// RVA: 0x96EE70 Offset: 0x96D470 VA: 0x18096EE70
	private string PrintBindings() { }

	// RVA: 0x96D940 Offset: 0x96BF40 VA: 0x18096D940
	private void ClearAllBindings() { }

	// RVA: 0x96FF80 Offset: 0x96E580 VA: 0x18096FF80
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

