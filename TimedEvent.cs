public class TimedEvent : ITimedObject // TypeDefIndex: 7458
{	// Fields
	internal long _time; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MidiEvent <Event>k__BackingField; // 0x18

	// Properties
	public MidiEvent Event { get; }
	public long Time { get; }

	// Methods

	// RVA: 0x22030D0 Offset: 0x22016D0 VA: 0x1822030D0
	public void .ctor(MidiEvent midiEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public MidiEvent get_Event() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public long get_Time() { }

	// RVA: 0x2203070 Offset: 0x2201670 VA: 0x182203070 Slot: 3
	public override string ToString() { }

}

