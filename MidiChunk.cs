public abstract class MidiChunk // TypeDefIndex: 7510
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly string <ChunkId>k__BackingField; // 0x10

	public string ChunkId { get; }


	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public string get_ChunkId() { }

	internal void Read(MidiReader reader, ReadingSettings settings) { }

	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

