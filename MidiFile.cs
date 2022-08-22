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

	// RVA: 0x13A1C90 Offset: 0x13A0290 VA: 0x1813A1C90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ChunksCollection get_Chunks() { }

	// RVA: 0x13A1980 Offset: 0x139FF80 VA: 0x1813A1980
	public static MidiFile Read(string filePath, ReadingSettings settings) { }

	// RVA: 0x13A1170 Offset: 0x139F770 VA: 0x1813A1170
	public static MidiFile Read(Stream stream, ReadingSettings settings) { }

	// RVA: 0x13A0D50 Offset: 0x139F350 VA: 0x1813A0D50
	private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, Nullable<int> expectedTrackChunksCount) { }

	// RVA: 0x13A0CD0 Offset: 0x139F2D0 VA: 0x1813A0CD0
	private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount) { }

	// RVA: 0x13A0C60 Offset: 0x139F260 VA: 0x1813A0C60
	private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception) { }

	// RVA: 0x13A1A70 Offset: 0x13A0070 VA: 0x1813A1A70
	private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes) { }

	// RVA: 0x13A0B20 Offset: 0x139F120 VA: 0x1813A0B20
	private static bool IsChunkType(Type type) { }

}

