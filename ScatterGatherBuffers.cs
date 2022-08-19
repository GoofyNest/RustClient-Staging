internal class ScatterGatherBuffers // TypeDefIndex: 2922
{	// Fields
	private ScatterGatherBuffers.MemoryChunk headChunk; // 0x10
	private ScatterGatherBuffers.MemoryChunk currentChunk; // 0x18
	private int nextChunkLength; // 0x20
	private int totalLength; // 0x24
	private int chunkCount; // 0x28

	// Properties
	private bool Empty { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0xFFCB60 Offset: 0xFFB160 VA: 0x180FFCB60
	internal void .ctor(long totalSize) { }

	// RVA: 0xFFC8F0 Offset: 0xFFAEF0 VA: 0x180FFC8F0
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0xFFCBC0 Offset: 0xFFB1C0 VA: 0x180FFCBC0
	private bool get_Empty() { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	internal int get_Length() { }

	// RVA: 0xFFCA50 Offset: 0xFFB050 VA: 0x180FFCA50
	internal void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xFFC820 Offset: 0xFFAE20 VA: 0x180FFC820
	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }

}

private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 2923
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0xFF98B0 Offset: 0xFF7EB0 VA: 0x180FF98B0
	internal void .ctor(int bufferSize) { }

}

