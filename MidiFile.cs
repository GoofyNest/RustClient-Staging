public sealed class MidiFile // TypeDefIndex: 7585
{	// Fields
	internal Nullable<ushort> _originalFormat; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeDivision <TimeDivision>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ChunksCollection <Chunks>k__BackingField; // 0x20

	// Properties
	public TimeDivision TimeDivision { get; set; }
	public ChunksCollection Chunks { get; }

	// Methods

	// RVA: 0x13A19D0 Offset: 0x139FFD0 VA: 0x1813A19D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ChunksCollection get_Chunks() { }

	// RVA: 0x13A16C0 Offset: 0x139FCC0 VA: 0x1813A16C0
	public static MidiFile Read(string filePath, ReadingSettings settings) { }

	// RVA: 0x13A0EB0 Offset: 0x139F4B0 VA: 0x1813A0EB0
	public static MidiFile Read(Stream stream, ReadingSettings settings) { }

	// RVA: 0x13A0A90 Offset: 0x139F090 VA: 0x1813A0A90
	private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, Nullable<int> expectedTrackChunksCount) { }

	// RVA: 0x13A0A10 Offset: 0x139F010 VA: 0x1813A0A10
	private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount) { }

	// RVA: 0x13A09A0 Offset: 0x139EFA0 VA: 0x1813A09A0
	private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception) { }

	// RVA: 0x13A17B0 Offset: 0x139FDB0 VA: 0x1813A17B0
	private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes) { }

	// RVA: 0x13A0860 Offset: 0x139EE60 VA: 0x1813A0860
	private static bool IsChunkType(Type type) { }

}

