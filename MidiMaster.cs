public static class MidiMaster // TypeDefIndex: 7647
{	// Properties
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }

	// Methods

	// RVA: 0x2317840 Offset: 0x2315E40 VA: 0x182317840
	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	// RVA: 0x23178C0 Offset: 0x2315EC0 VA: 0x1823178C0
	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	// RVA: 0x2317820 Offset: 0x2315E20 VA: 0x182317820
	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	// RVA: 0x2317890 Offset: 0x2315E90 VA: 0x182317890
	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	// RVA: 0x2317800 Offset: 0x2315E00 VA: 0x182317800
	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	// RVA: 0x2317860 Offset: 0x2315E60 VA: 0x182317860
	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x2317680 Offset: 0x2315C80 VA: 0x182317680
	public static float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317640 Offset: 0x2315C40 VA: 0x182317640
	public static float GetKey(int noteNumber) { }

	// RVA: 0x2317540 Offset: 0x2315B40 VA: 0x182317540
	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317580 Offset: 0x2315B80 VA: 0x182317580
	public static bool GetKeyDown(int noteNumber) { }

	// RVA: 0x23175C0 Offset: 0x2315BC0 VA: 0x1823175C0
	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317600 Offset: 0x2315C00 VA: 0x182317600
	public static bool GetKeyUp(int noteNumber) { }

	// RVA: 0x23176C0 Offset: 0x2315CC0 VA: 0x1823176C0
	public static int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x23176F0 Offset: 0x2315CF0 VA: 0x1823176F0
	public static int[] GetKnobNumbers() { }

	// RVA: 0x2317770 Offset: 0x2315D70 VA: 0x182317770
	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317720 Offset: 0x2315D20 VA: 0x182317720
	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	// RVA: 0x23177D0 Offset: 0x2315DD0 VA: 0x1823177D0
	public static void ToggleEnabled(bool state) { }

}

