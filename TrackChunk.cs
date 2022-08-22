public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7511
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly EventsCollection <Events>k__BackingField; // 0x18

	// Properties
	public EventsCollection Events { get; }

	// Methods

	// RVA: 0x13AA5D0 Offset: 0x13A8BD0 VA: 0x1813AA5D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventsCollection get_Events() { }

	// RVA: 0x13AA050 Offset: 0x13A8650 VA: 0x1813AA050 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	// RVA: 0x13AA540 Offset: 0x13A8B40 VA: 0x1813AA540 Slot: 3
	public override string ToString() { }

	// RVA: 0x13AA1F0 Offset: 0x13A87F0 VA: 0x1813AA1F0
	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

