public class TimedEvent : ITimedObject // TypeDefIndex: 7458
{	// Fields
	internal long _time; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly MidiEvent <Event>k__BackingField; // 0x18

	// Properties
	public MidiEvent Event { get; }
	public long Time { get; }

	// Methods

	// RVA: 0x2203290 Offset: 0x2201890 VA: 0x182203290
	public void .ctor(MidiEvent midiEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public MidiEvent get_Event() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public long get_Time() { }

	// RVA: 0x2203230 Offset: 0x2201830 VA: 0x182203230 Slot: 3
	public override string ToString() { }

}
