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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly SevenBitNumber <NoteNumber>k__BackingField; // 0x10

	// Properties
	public SevenBitNumber NoteNumber { get; }
	public NoteName NoteName { get; }
	public int Octave { get; }

	// Methods

	// RVA: 0x21FFFB0 Offset: 0x21FE5B0 VA: 0x1821FFFB0
	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x2200080 Offset: 0x21FE680 VA: 0x182200080
	public NoteName get_NoteName() { }

	// RVA: 0x22001D0 Offset: 0x21FE7D0 VA: 0x1822001D0
	public int get_Octave() { }

	// RVA: 0x21FF6E0 Offset: 0x21FDCE0 VA: 0x1821FF6E0
	public static Note Get(SevenBitNumber noteNumber) { }

	// RVA: 0x2200460 Offset: 0x21FEA60 VA: 0x182200460
	public static bool op_Equality(Note note1, Note note2) { }

	// RVA: 0x21FF5A0 Offset: 0x21FDBA0 VA: 0x1821FF5A0 Slot: 4
	public int CompareTo(Note other) { }

	// RVA: 0x21FF9C0 Offset: 0x21FDFC0 VA: 0x1821FF9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FF5D0 Offset: 0x21FDBD0 VA: 0x1821FF5D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FF6C0 Offset: 0x21FDCC0 VA: 0x1821FF6C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FFBA0 Offset: 0x21FE1A0 VA: 0x1821FFBA0
	private static void .cctor() { }

}

public class Note : ILengthedObject, ITimedObject // TypeDefIndex: 7438
{	// Fields
	public static readonly SevenBitNumber DefaultVelocity; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly TimedEvent <TimedNoteOnEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x21FFC00 Offset: 0x21FE200 VA: 0x1821FFC00
	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30 Slot: 5
	public long get_Time() { }

	// RVA: 0x21FFFE0 Offset: 0x21FE5E0 VA: 0x1821FFFE0 Slot: 4
	public long get_Length() { }

	// RVA: 0x22000F0 Offset: 0x21FE6F0 VA: 0x1822000F0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x22003F0 Offset: 0x21FE9F0 VA: 0x1822003F0
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x2200610 Offset: 0x21FEC10 VA: 0x182200610
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x2200590 Offset: 0x21FEB90 VA: 0x182200590
	public void set_OffVelocity(SevenBitNumber value) { }

	// RVA: 0x22004F0 Offset: 0x21FEAF0 VA: 0x1822004F0
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x2200010 Offset: 0x21FE610 VA: 0x182200010
	public NoteName get_NoteName() { }

	// RVA: 0x2200160 Offset: 0x21FE760 VA: 0x182200160
	public int get_Octave() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal TimedEvent get_TimedNoteOffEvent() { }

	// RVA: 0x2200230 Offset: 0x21FE830 VA: 0x182200230
	internal Note get_UnderlyingNote() { }

	// RVA: 0x21FF7F0 Offset: 0x21FDDF0 VA: 0x1821FF7F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FFB40 Offset: 0x21FE140 VA: 0x1821FFB40
	private static void .cctor() { }

}

public class Note : ConsoleSystem // TypeDefIndex: 11949
{	// Methods

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x367090 Offset: 0x365690 VA: 0x180367090
	public static void craft_add(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x3672A0 Offset: 0x3658A0 VA: 0x1803672A0
	public static void craft_start(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x367170 Offset: 0x365770 VA: 0x180367170
	public static void craft_done(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x367230 Offset: 0x365830 VA: 0x180367230
	public static void craft_fasttracked(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x367360 Offset: 0x365960 VA: 0x180367360
	public static void inv(ConsoleSystem.Arg args) { }

	// RVA: 0x367030 Offset: 0x365630 VA: 0x180367030
	public void .ctor() { }

}

