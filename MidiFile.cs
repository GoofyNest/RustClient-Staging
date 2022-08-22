public sealed class MidiFile // TypeDefIndex: 7585
{	// Fields
	internal Nullable<ushort> _originalFormat; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeDivision <TimeDivision>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ChunksCollection <Chunks>k__BackingField; // 0x20

	// Properties
	public TimeDivision TimeDivision { get; set; }
	public ChunksCollection Chunks { get; }

	// Methods

	// RVA: 0x13A0D90 Offset: 0x139F390 VA: 0x1813A0D90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ChunksCollection get_Chunks() { }

	// RVA: 0x13A0A80 Offset: 0x139F080 VA: 0x1813A0A80
	public static MidiFile Read(string filePath, ReadingSettings settings) { }

	// RVA: 0x13A0270 Offset: 0x139E870 VA: 0x1813A0270
	public static MidiFile Read(Stream stream, ReadingSettings settings) { }

	// RVA: 0x139FE50 Offset: 0x139E450 VA: 0x18139FE50
	private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, Nullable<int> expectedTrackChunksCount) { }

	// RVA: 0x139FDD0 Offset: 0x139E3D0 VA: 0x18139FDD0
	private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount) { }

	// RVA: 0x139FD60 Offset: 0x139E360 VA: 0x18139FD60
	private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception) { }

	// RVA: 0x13A0B70 Offset: 0x139F170 VA: 0x1813A0B70
	private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes) { }

	// RVA: 0x139FC20 Offset: 0x139E220 VA: 0x18139FC20
	private static bool IsChunkType(Type type) { }

}

