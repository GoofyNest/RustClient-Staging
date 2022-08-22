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

	// RVA: 0xFFD8C0 Offset: 0xFFBEC0 VA: 0x180FFD8C0
	internal void .ctor(long totalSize) { }

	// RVA: 0xFFD650 Offset: 0xFFBC50 VA: 0x180FFD650
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0xFFD920 Offset: 0xFFBF20 VA: 0x180FFD920
	private bool get_Empty() { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	internal int get_Length() { }

	// RVA: 0xFFD7B0 Offset: 0xFFBDB0 VA: 0x180FFD7B0
	internal void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xFFD580 Offset: 0xFFBB80 VA: 0x180FFD580
	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }

}

private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 2923
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0xFFA610 Offset: 0xFF8C10 VA: 0x180FFA610
	internal void .ctor(int bufferSize) { }

}

