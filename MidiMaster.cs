public static class MidiMaster // TypeDefIndex: 7647
{	// Properties
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }

	// Methods

	// RVA: 0x2318060 Offset: 0x2316660 VA: 0x182318060
	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	// RVA: 0x23180E0 Offset: 0x23166E0 VA: 0x1823180E0
	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	// RVA: 0x2318040 Offset: 0x2316640 VA: 0x182318040
	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	// RVA: 0x23180B0 Offset: 0x23166B0 VA: 0x1823180B0
	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	// RVA: 0x2318020 Offset: 0x2316620 VA: 0x182318020
	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	// RVA: 0x2318080 Offset: 0x2316680 VA: 0x182318080
	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x2317EA0 Offset: 0x23164A0 VA: 0x182317EA0
	public static float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317E60 Offset: 0x2316460 VA: 0x182317E60
	public static float GetKey(int noteNumber) { }

	// RVA: 0x2317D60 Offset: 0x2316360 VA: 0x182317D60
	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317DA0 Offset: 0x23163A0 VA: 0x182317DA0
	public static bool GetKeyDown(int noteNumber) { }

	// RVA: 0x2317DE0 Offset: 0x23163E0 VA: 0x182317DE0
	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317E20 Offset: 0x2316420 VA: 0x182317E20
	public static bool GetKeyUp(int noteNumber) { }

	// RVA: 0x2317EE0 Offset: 0x23164E0 VA: 0x182317EE0
	public static int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2317F10 Offset: 0x2316510 VA: 0x182317F10
	public static int[] GetKnobNumbers() { }

	// RVA: 0x2317F90 Offset: 0x2316590 VA: 0x182317F90
	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317F40 Offset: 0x2316540 VA: 0x182317F40
	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2317FF0 Offset: 0x23165F0 VA: 0x182317FF0
	public static void ToggleEnabled(bool state) { }

}

