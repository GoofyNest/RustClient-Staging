public sealed class Note : IComparable<Note> // TypeDefIndex: 7433
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 7417

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 7418

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 // TypeDefIndex: 7419

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 // TypeDefIndex: 7420

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 7421

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 // TypeDefIndex: 7422

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 // TypeDefIndex: 7423

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 // TypeDefIndex: 7424

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 7425

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 // TypeDefIndex: 7426

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 7427

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 // TypeDefIndex: 7428

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 // TypeDefIndex: 7429

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 7430

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 // TypeDefIndex: 7431

// Namespace: 
internal class <Module> // TypeDefIndex: 7432

// Namespace: Melanchall.DryWetMidi.MusicTheory
public sealed class Note : IComparable<Note> // TypeDefIndex: 7433
	// Fields
	private static readonly ConcurrentDictionary<SevenBitNumber, Note> Cache; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly SevenBitNumber <NoteNumber>k__BackingField; // 0x10

	// Properties
	public SevenBitNumber NoteNumber { get; }
	public NoteName NoteName { get; }
	public int Octave { get; }

	// Methods

	// RVA: 0x22000B0 Offset: 0x21FE6B0 VA: 0x1822000B0
	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x2200180 Offset: 0x21FE780 VA: 0x182200180
	public NoteName get_NoteName() { }

	// RVA: 0x22002D0 Offset: 0x21FE8D0 VA: 0x1822002D0
	public int get_Octave() { }

	// RVA: 0x21FF7E0 Offset: 0x21FDDE0 VA: 0x1821FF7E0
	public static Note Get(SevenBitNumber noteNumber) { }

	// RVA: 0x2200560 Offset: 0x21FEB60 VA: 0x182200560
	public static bool op_Equality(Note note1, Note note2) { }

	// RVA: 0x21FF6A0 Offset: 0x21FDCA0 VA: 0x1821FF6A0 Slot: 4
	public int CompareTo(Note other) { }

	// RVA: 0x21FFAC0 Offset: 0x21FE0C0 VA: 0x1821FFAC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FF6D0 Offset: 0x21FDCD0 VA: 0x1821FF6D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FF7C0 Offset: 0x21FDDC0 VA: 0x1821FF7C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FFCA0 Offset: 0x21FE2A0 VA: 0x1821FFCA0
	private static void .cctor() { }

}

public class Note : ILengthedObject, ITimedObject // TypeDefIndex: 7438
{	// Fields
	public static readonly SevenBitNumber DefaultVelocity; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TimedEvent <TimedNoteOnEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TimedEvent <TimedNoteOffEvent>k__BackingField; // 0x18

	// Properties
	public long Time { get; }
	public long Length { get; }
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber Velocity { get; set; }
	public SevenBitNumber OffVelocity { set; }
	public FourBitNumber Channel { set; }
	public NoteName NoteName { get; }
	public int Octave { get; }
	internal TimedEvent TimedNoteOnEvent { get; }
	internal TimedEvent TimedNoteOffEvent { get; }
	internal Note UnderlyingNote { get; }

	// Methods

	// RVA: 0x21FFD00 Offset: 0x21FE300 VA: 0x1821FFD00
	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	// RVA: 0xB28DF0 Offset: 0xB273F0 VA: 0x180B28DF0 Slot: 5
	public long get_Time() { }

	// RVA: 0x22000E0 Offset: 0x21FE6E0 VA: 0x1822000E0 Slot: 4
	public long get_Length() { }

	// RVA: 0x22001F0 Offset: 0x21FE7F0 VA: 0x1822001F0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x22004F0 Offset: 0x21FEAF0 VA: 0x1822004F0
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x2200710 Offset: 0x21FED10 VA: 0x182200710
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x2200690 Offset: 0x21FEC90 VA: 0x182200690
	public void set_OffVelocity(SevenBitNumber value) { }

	// RVA: 0x22005F0 Offset: 0x21FEBF0 VA: 0x1822005F0
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x2200110 Offset: 0x21FE710 VA: 0x182200110
	public NoteName get_NoteName() { }

	// RVA: 0x2200260 Offset: 0x21FE860 VA: 0x182200260
	public int get_Octave() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal TimedEvent get_TimedNoteOffEvent() { }

	// RVA: 0x2200330 Offset: 0x21FE930 VA: 0x182200330
	internal Note get_UnderlyingNote() { }

	// RVA: 0x21FF8F0 Offset: 0x21FDEF0 VA: 0x1821FF8F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FFC40 Offset: 0x21FE240 VA: 0x1821FFC40
	private static void .cctor() { }

}

public class Note : ConsoleSystem // TypeDefIndex: 11949
{	// Methods

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x367090 Offset: 0x365690 VA: 0x180367090
	public static void craft_add(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x3672A0 Offset: 0x3658A0 VA: 0x1803672A0
	public static void craft_start(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x367170 Offset: 0x365770 VA: 0x180367170
	public static void craft_done(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x367230 Offset: 0x365830 VA: 0x180367230
	public static void craft_fasttracked(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x367360 Offset: 0x365960 VA: 0x180367360
	public static void inv(ConsoleSystem.Arg args) { }

	// RVA: 0x367030 Offset: 0x365630 VA: 0x180367030
	public void .ctor() { }

}

