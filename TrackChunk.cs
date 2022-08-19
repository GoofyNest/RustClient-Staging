public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7511
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly EventsCollection <Events>k__BackingField; // 0x18

	// Properties
	public EventsCollection Events { get; }

	// Methods

	// RVA: 0x13AA310 Offset: 0x13A8910 VA: 0x1813AA310
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventsCollection get_Events() { }

	// RVA: 0x13A9D90 Offset: 0x13A8390 VA: 0x1813A9D90 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	// RVA: 0x13AA280 Offset: 0x13A8880 VA: 0x1813AA280 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A9F30 Offset: 0x13A8530 VA: 0x1813A9F30
	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

