public class instruments : ConsoleSystem // TypeDefIndex: 11937
{	// Fields
	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7D10 Offset: 0xA7110 VA: 0x1800A7D10
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <debugNotes>k__BackingField; // 0x2

	// Properties
	[ClientVar] // RVA: 0xA9B20 Offset: 0xA8F20 VA: 0x1800A9B20
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA9C00 Offset: 0xA9000 VA: 0x1800A9C00
	public static bool debugNotes { get; set; }

	// Methods

	// RVA: 0x3735F0 Offset: 0x371BF0 VA: 0x1803735F0
	public static bool get_debugMidi() { }

	// RVA: 0x375B00 Offset: 0x374100 VA: 0x180375B00
	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x373650 Offset: 0x371C50 VA: 0x180373650
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x375B90 Offset: 0x374190 VA: 0x180375B90
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA7F00 Offset: 0xA7300 VA: 0x1800A7F00
	// RVA: 0x3752B0 Offset: 0x3738B0 VA: 0x1803752B0
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7FA0 Offset: 0xA73A0 VA: 0x1800A7FA0
	// RVA: 0x3745D0 Offset: 0x372BD0 VA: 0x1803745D0
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7FE0 Offset: 0xA73E0 VA: 0x1800A7FE0
	// RVA: 0x3732A0 Offset: 0x3718A0 VA: 0x1803732A0
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA80B0 Offset: 0xA74B0 VA: 0x1800A80B0
	// RVA: 0x3736B0 Offset: 0x371CB0 VA: 0x1803736B0
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	// RVA: 0x3727D0 Offset: 0x370DD0 VA: 0x1803727D0
	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	// RVA: 0x373020 Offset: 0x371620 VA: 0x180373020
	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	// RVA: 0x372E70 Offset: 0x371470 VA: 0x180372E70
	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA94E0 Offset: 0xA88E0 VA: 0x1800A94E0
	// RVA: 0x373C30 Offset: 0x372230 VA: 0x180373C30
	public static void playnote(ConsoleSystem.Arg arg) { }

	// RVA: 0x372ED0 Offset: 0x3714D0 VA: 0x180372ED0
	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	// RVA: 0x3729C0 Offset: 0x370FC0 VA: 0x1803729C0
	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA95D0 Offset: 0xA89D0 VA: 0x1800A95D0
	// RVA: 0x375BF0 Offset: 0x3741F0 VA: 0x180375BF0
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
	// RVA: 0x375DF0 Offset: 0x3743F0 VA: 0x180375DF0
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9720 Offset: 0xA8B20 VA: 0x1800A9720
	// RVA: 0x373E90 Offset: 0x372490 VA: 0x180373E90
	public static void playrecording(ConsoleSystem.Arg arg) { }

	// RVA: 0x372610 Offset: 0x370C10 VA: 0x180372610
	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	// RVA: 0x372B20 Offset: 0x371120 VA: 0x180372B20
	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA97B0 Offset: 0xA8BB0 VA: 0x1800A97B0
	// RVA: 0x374B00 Offset: 0x373100 VA: 0x180374B00
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA98A0 Offset: 0xA8CA0 VA: 0x1800A98A0
	// RVA: 0x375100 Offset: 0x373700 VA: 0x180375100
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9930 Offset: 0xA8D30 VA: 0x1800A9930
	// RVA: 0x373A30 Offset: 0x372030 VA: 0x180373A30
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9A80 Offset: 0xA8E80 VA: 0x1800A9A80
	// RVA: 0x373490 Offset: 0x371A90 VA: 0x180373490
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	// RVA: 0x373240 Offset: 0x371840 VA: 0x180373240
	public void .ctor() { }

	// RVA: 0x3731F0 Offset: 0x3717F0 VA: 0x1803731F0
	private static void .cctor() { }

}

