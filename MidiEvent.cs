public abstract class MidiEvent // TypeDefIndex: 7517
{	// Fields
	internal long _deltaTime; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MidiEventType <EventType>k__BackingField; // 0x18

	// Properties
	public MidiEventType EventType { get; }
	public long DeltaTime { get; set; }

	// Methods

	// RVA: 0x13960D0 Offset: 0x13946D0 VA: 0x1813960D0
	public void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public MidiEventType get_EventType() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_DeltaTime() { }

	// RVA: 0x13A0700 Offset: 0x139ED00 VA: 0x1813A0700
	public void set_DeltaTime(long value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract MidiEvent CloneEvent();

	// RVA: 0x13A06C0 Offset: 0x139ECC0 VA: 0x1813A06C0
	public MidiEvent Clone() { }

}

