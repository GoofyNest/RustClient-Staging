public abstract class MidiChunk // TypeDefIndex: 7510
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <ChunkId>k__BackingField; // 0x10

	// Properties
	public string ChunkId { get; }

	// Methods

	// RVA: 0x13A0820 Offset: 0x139EE20 VA: 0x1813A0820
	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ChunkId() { }

	// RVA: 0x13A0630 Offset: 0x139EC30 VA: 0x1813A0630
	internal void Read(MidiReader reader, ReadingSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

