public static class NotesManagingUtilities // TypeDefIndex: 7447
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200A30 Offset: 0x21FF030 VA: 0x182200A30
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200BC0 Offset: 0x21FF1C0 VA: 0x182200BC0
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2201090 Offset: 0x21FF690 VA: 0x182201090
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7448
{	// Fields
	public static readonly NotesManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, EventsCollection> <>9__16_0; // 0x8
	public static Func<EventsCollection, int> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x22054C0 Offset: 0x2203AC0 VA: 0x1822054C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal EventsCollection <GetNotes>b__16_0(TrackChunk c) { }

	// RVA: 0x22053F0 Offset: 0x22039F0 VA: 0x1822053F0
	internal int <GetNotes>b__16_1(EventsCollection e) { }

}

