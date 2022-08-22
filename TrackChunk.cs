public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7511
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly EventsCollection <Events>k__BackingField; // 0x18

	// Properties
	public EventsCollection Events { get; }

	// Methods

	// RVA: 0x13A96D0 Offset: 0x13A7CD0 VA: 0x1813A96D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventsCollection get_Events() { }

	// RVA: 0x13A9150 Offset: 0x13A7750 VA: 0x1813A9150 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	// RVA: 0x13A9640 Offset: 0x13A7C40 VA: 0x1813A9640 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A92F0 Offset: 0x13A78F0 VA: 0x1813A92F0
	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

