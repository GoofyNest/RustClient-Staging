public static class MidiMaster // TypeDefIndex: 7647
{	// Properties
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }

	// Methods

	// RVA: 0x2317740 Offset: 0x2315D40 VA: 0x182317740
	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	// RVA: 0x23177C0 Offset: 0x2315DC0 VA: 0x1823177C0
	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	// RVA: 0x2317720 Offset: 0x2315D20 VA: 0x182317720
	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	// RVA: 0x2317790 Offset: 0x2315D90 VA: 0x182317790
	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	// RVA: 0x2317700 Offset: 0x2315D00 VA: 0x182317700
	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	// RVA: 0x2317760 Offset: 0x2315D60 VA: 0x182317760
	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x2317580 Offset: 0x2315B80 VA: 0x182317580
	public static float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317540 Offset: 0x2315B40 VA: 0x182317540
	public static float GetKey(int noteNumber) { }

	// RVA: 0x2317440 Offset: 0x2315A40 VA: 0x182317440
	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317480 Offset: 0x2315A80 VA: 0x182317480
	public static bool GetKeyDown(int noteNumber) { }

	// RVA: 0x23174C0 Offset: 0x2315AC0 VA: 0x1823174C0
	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317500 Offset: 0x2315B00 VA: 0x182317500
	public static bool GetKeyUp(int noteNumber) { }

	// RVA: 0x23175C0 Offset: 0x2315BC0 VA: 0x1823175C0
	public static int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x23175F0 Offset: 0x2315BF0 VA: 0x1823175F0
	public static int[] GetKnobNumbers() { }

	// RVA: 0x2317670 Offset: 0x2315C70 VA: 0x182317670
	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317620 Offset: 0x2315C20 VA: 0x182317620
	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	// RVA: 0x23176D0 Offset: 0x2315CD0 VA: 0x1823176D0
	public static void ToggleEnabled(bool state) { }

}

