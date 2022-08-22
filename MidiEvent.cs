public abstract class MidiEvent // TypeDefIndex: 7517
{	// Fields
	internal long _deltaTime; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MidiEventType <EventType>k__BackingField; // 0x18

	// Properties
	public MidiEventType EventType { get; }
	public long DeltaTime { get; set; }

	// Methods

	// RVA: 0x1395490 Offset: 0x1393A90 VA: 0x181395490
	public void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public MidiEventType get_EventType() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_DeltaTime() { }

	// RVA: 0x139FAC0 Offset: 0x139E0C0 VA: 0x18139FAC0
	public void set_DeltaTime(long value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract MidiEvent CloneEvent();

	// RVA: 0x139FA80 Offset: 0x139E080 VA: 0x18139FA80
	public MidiEvent Clone() { }

}

