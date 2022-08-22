public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200E90 Offset: 0x21FF490 VA: 0x182200E90
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200E30 Offset: 0x21FF430 VA: 0x182200E30
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	// Fields
	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18

	// Methods

	// RVA: 0x22052C0 Offset: 0x22038C0 VA: 0x1822052C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF510 Offset: 0xDEDB10 VA: 0x180DEF510
	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	// RVA: 0x2205130 Offset: 0x2203730 VA: 0x182205130
	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

