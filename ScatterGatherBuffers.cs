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

	// RVA: 0xFFCE20 Offset: 0xFFB420 VA: 0x180FFCE20
	internal void .ctor(long totalSize) { }

	// RVA: 0xFFCBB0 Offset: 0xFFB1B0 VA: 0x180FFCBB0
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0xFFCE80 Offset: 0xFFB480 VA: 0x180FFCE80
	private bool get_Empty() { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	internal int get_Length() { }

	// RVA: 0xFFCD10 Offset: 0xFFB310 VA: 0x180FFCD10
	internal void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xFFCAE0 Offset: 0xFFB0E0 VA: 0x180FFCAE0
	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }

}

private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 2923
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0xFF9B70 Offset: 0xFF8170 VA: 0x180FF9B70
	internal void .ctor(int bufferSize) { }

}

