public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7511
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly EventsCollection <Events>k__BackingField; // 0x18

	public EventsCollection Events { get; }


	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EventsCollection get_Events() { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	public override string ToString() { }

	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

