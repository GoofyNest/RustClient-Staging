public static class MidiMaster // TypeDefIndex: 7647
{	// Properties
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }

	// Methods

	// RVA: 0x2317580 Offset: 0x2315B80 VA: 0x182317580
	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	// RVA: 0x2317600 Offset: 0x2315C00 VA: 0x182317600
	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	// RVA: 0x2317560 Offset: 0x2315B60 VA: 0x182317560
	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	// RVA: 0x23175D0 Offset: 0x2315BD0 VA: 0x1823175D0
	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	// RVA: 0x2317540 Offset: 0x2315B40 VA: 0x182317540
	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	// RVA: 0x23175A0 Offset: 0x2315BA0 VA: 0x1823175A0
	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x23173C0 Offset: 0x23159C0 VA: 0x1823173C0
	public static float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317380 Offset: 0x2315980 VA: 0x182317380
	public static float GetKey(int noteNumber) { }

	// RVA: 0x2317280 Offset: 0x2315880 VA: 0x182317280
	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x23172C0 Offset: 0x23158C0 VA: 0x1823172C0
	public static bool GetKeyDown(int noteNumber) { }

	// RVA: 0x2317300 Offset: 0x2315900 VA: 0x182317300
	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317340 Offset: 0x2315940 VA: 0x182317340
	public static bool GetKeyUp(int noteNumber) { }

	// RVA: 0x2317400 Offset: 0x2315A00 VA: 0x182317400
	public static int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2317430 Offset: 0x2315A30 VA: 0x182317430
	public static int[] GetKnobNumbers() { }

	// RVA: 0x23174B0 Offset: 0x2315AB0 VA: 0x1823174B0
	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317460 Offset: 0x2315A60 VA: 0x182317460
	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317510 Offset: 0x2315B10 VA: 0x182317510
	public static void ToggleEnabled(bool state) { }

}

