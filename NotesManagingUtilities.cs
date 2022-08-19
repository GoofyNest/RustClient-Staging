public static class NotesManagingUtilities // TypeDefIndex: 7447
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2200930 Offset: 0x21FEF30 VA: 0x182200930
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2200AC0 Offset: 0x21FF0C0 VA: 0x182200AC0
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2200F90 Offset: 0x21FF590 VA: 0x182200F90
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7448
{	// Fields
	public static readonly NotesManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, EventsCollection> <>9__16_0; // 0x8
	public static Func<EventsCollection, int> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x22053C0 Offset: 0x22039C0 VA: 0x1822053C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal EventsCollection <GetNotes>b__16_0(TrackChunk c) { }

	// RVA: 0x22052F0 Offset: 0x22038F0 VA: 0x1822052F0
	internal int <GetNotes>b__16_1(EventsCollection e) { }

}

