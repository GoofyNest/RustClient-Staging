public sealed class InvalidChunkSizeException : MidiException // TypeDefIndex: 7573
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <ChunkId>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ExpectedSize>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ActualSize>k__BackingField; // 0x98

	// Methods

	// RVA: 0x13995B0 Offset: 0x1397BB0 VA: 0x1813995B0
	internal void .ctor(string chunkId, long expectedSize, long actualSize) { }

}

