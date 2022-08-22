public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2201970 Offset: 0x21FFF70 VA: 0x182201970
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2201910 Offset: 0x21FFF10 VA: 0x182201910
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	// Fields
	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18

	// Methods

	// RVA: 0x2205DA0 Offset: 0x22043A0 VA: 0x182205DA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0280 Offset: 0xDEE880 VA: 0x180DF0280
	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0
	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	// RVA: 0x2205C10 Offset: 0x2204210 VA: 0x182205C10
	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

