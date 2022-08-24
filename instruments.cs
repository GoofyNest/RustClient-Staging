public class instruments : ConsoleSystem // TypeDefIndex: 11941
{	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7790 Offset: 0xA6B90 VA: 0x1800A7790
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static bool <debugNotes>k__BackingField; // 0x2

	[ClientVar] // RVA: 0xA98E0 Offset: 0xA8CE0 VA: 0x1800A98E0
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA99A0 Offset: 0xA8DA0 VA: 0x1800A99A0
	public static bool debugNotes { get; set; }


	public static bool get_debugMidi() { }

	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA7D10 Offset: 0xA7110 VA: 0x1800A7D10
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7D80 Offset: 0xA7180 VA: 0x1800A7D80
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7E10 Offset: 0xA7210 VA: 0x1800A7E10
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7F50 Offset: 0xA7350 VA: 0x1800A7F50
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA7FC0 Offset: 0xA73C0 VA: 0x1800A7FC0
	public static void playnote(ConsoleSystem.Arg arg) { }

	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA8050 Offset: 0xA7450 VA: 0x1800A8050
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA80F0 Offset: 0xA74F0 VA: 0x1800A80F0
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA8160 Offset: 0xA7560 VA: 0x1800A8160
	public static void playrecording(ConsoleSystem.Arg arg) { }

	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA8200 Offset: 0xA7600 VA: 0x1800A8200
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA95F0 Offset: 0xA89F0 VA: 0x1800A95F0
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA96C0 Offset: 0xA8AC0 VA: 0x1800A96C0
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA97B0 Offset: 0xA8BB0 VA: 0x1800A97B0
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

