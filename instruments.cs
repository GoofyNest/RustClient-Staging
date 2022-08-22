public class instruments : ConsoleSystem // TypeDefIndex: 11937
{	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7D10 Offset: 0xA7110 VA: 0x1800A7D10
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <debugNotes>k__BackingField; // 0x2

	[ClientVar] // RVA: 0xA9B20 Offset: 0xA8F20 VA: 0x1800A9B20
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA9C00 Offset: 0xA9000 VA: 0x1800A9C00
	public static bool debugNotes { get; set; }


	public static bool get_debugMidi() { }

	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA7F00 Offset: 0xA7300 VA: 0x1800A7F00
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7FA0 Offset: 0xA73A0 VA: 0x1800A7FA0
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7FE0 Offset: 0xA73E0 VA: 0x1800A7FE0
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA80B0 Offset: 0xA74B0 VA: 0x1800A80B0
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA94E0 Offset: 0xA88E0 VA: 0x1800A94E0
	public static void playnote(ConsoleSystem.Arg arg) { }

	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA95D0 Offset: 0xA89D0 VA: 0x1800A95D0
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9720 Offset: 0xA8B20 VA: 0x1800A9720
	public static void playrecording(ConsoleSystem.Arg arg) { }

	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA97B0 Offset: 0xA8BB0 VA: 0x1800A97B0
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA98A0 Offset: 0xA8CA0 VA: 0x1800A98A0
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9930 Offset: 0xA8D30 VA: 0x1800A9930
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9A80 Offset: 0xA8E80 VA: 0x1800A9A80
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

