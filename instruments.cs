public class instruments : ConsoleSystem // TypeDefIndex: 11941
{	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7F60 Offset: 0xA7360 VA: 0x1800A7F60
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static bool <debugNotes>k__BackingField; // 0x2

	[ClientVar] // RVA: 0xA9D10 Offset: 0xA9110 VA: 0x1800A9D10
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA9E10 Offset: 0xA9210 VA: 0x1800A9E10
	public static bool debugNotes { get; set; }


	public static bool get_debugMidi() { }

	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA8080 Offset: 0xA7480 VA: 0x1800A8080
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA8120 Offset: 0xA7520 VA: 0x1800A8120
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA94D0 Offset: 0xA88D0 VA: 0x1800A94D0
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA95F0 Offset: 0xA89F0 VA: 0x1800A95F0
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA96E0 Offset: 0xA8AE0 VA: 0x1800A96E0
	public static void playnote(ConsoleSystem.Arg arg) { }

	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA97C0 Offset: 0xA8BC0 VA: 0x1800A97C0
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9850 Offset: 0xA8C50 VA: 0x1800A9850
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9890 Offset: 0xA8C90 VA: 0x1800A9890
	public static void playrecording(ConsoleSystem.Arg arg) { }

	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA99A0 Offset: 0xA8DA0 VA: 0x1800A99A0
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9AB0 Offset: 0xA8EB0 VA: 0x1800A9AB0
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9B60 Offset: 0xA8F60 VA: 0x1800A9B60
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9C40 Offset: 0xA9040 VA: 0x1800A9C40
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

