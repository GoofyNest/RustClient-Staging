public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2201050 Offset: 0x21FF650 VA: 0x182201050
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2200FF0 Offset: 0x21FF5F0 VA: 0x182200FF0
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	// Fields
	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18

	// Methods

	// RVA: 0x2205480 Offset: 0x2203A80 VA: 0x182205480
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF510 Offset: 0xDEDB10 VA: 0x180DEF510
	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	// RVA: 0x22052F0 Offset: 0x22038F0 VA: 0x1822052F0
	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

