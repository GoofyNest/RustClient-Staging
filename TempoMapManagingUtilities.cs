public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2201150 Offset: 0x21FF750 VA: 0x182201150
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22010F0 Offset: 0x21FF6F0 VA: 0x1822010F0
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	// Fields
	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18

	// Methods

	// RVA: 0x2205580 Offset: 0x2203B80 VA: 0x182205580
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF7D0 Offset: 0xDEDDD0 VA: 0x180DEF7D0
	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	// RVA: 0x22053F0 Offset: 0x22039F0 VA: 0x1822053F0
	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

