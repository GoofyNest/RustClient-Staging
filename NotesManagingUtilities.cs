public static class NotesManagingUtilities // TypeDefIndex: 7447
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200770 Offset: 0x21FED70 VA: 0x182200770
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200900 Offset: 0x21FEF00 VA: 0x182200900
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2200DD0 Offset: 0x21FF3D0 VA: 0x182200DD0
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7448
{	// Fields
	public static readonly NotesManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, EventsCollection> <>9__16_0; // 0x8
	public static Func<EventsCollection, int> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x2205200 Offset: 0x2203800 VA: 0x182205200
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal EventsCollection <GetNotes>b__16_0(TrackChunk c) { }

	// RVA: 0x2205130 Offset: 0x2203730 VA: 0x182205130
	internal int <GetNotes>b__16_1(EventsCollection e) { }

}

