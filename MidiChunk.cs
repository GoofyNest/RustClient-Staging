public abstract class MidiChunk // TypeDefIndex: 7510
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <ChunkId>k__BackingField; // 0x10

	// Properties
	public string ChunkId { get; }

	// Methods

	// RVA: 0x13A0560 Offset: 0x139EB60 VA: 0x1813A0560
	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ChunkId() { }

	// RVA: 0x13A0370 Offset: 0x139E970 VA: 0x1813A0370
	internal void Read(MidiReader reader, ReadingSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

