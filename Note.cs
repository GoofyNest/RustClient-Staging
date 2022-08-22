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

	// RVA: 0x22008D0 Offset: 0x21FEED0 VA: 0x1822008D0
	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x22009A0 Offset: 0x21FEFA0 VA: 0x1822009A0
	public NoteName get_NoteName() { }

	// RVA: 0x2200AF0 Offset: 0x21FF0F0 VA: 0x182200AF0
	public int get_Octave() { }

	// RVA: 0x2200000 Offset: 0x21FE600 VA: 0x182200000
	public static Note Get(SevenBitNumber noteNumber) { }

	// RVA: 0x2200D80 Offset: 0x21FF380 VA: 0x182200D80
	public static bool op_Equality(Note note1, Note note2) { }

	// RVA: 0x21FFEC0 Offset: 0x21FE4C0 VA: 0x1821FFEC0 Slot: 4
	public int CompareTo(Note other) { }

	// RVA: 0x22002E0 Offset: 0x21FE8E0 VA: 0x1822002E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FFEF0 Offset: 0x21FE4F0 VA: 0x1821FFEF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FFFE0 Offset: 0x21FE5E0 VA: 0x1821FFFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22004C0 Offset: 0x21FEAC0 VA: 0x1822004C0
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

	// RVA: 0x2200520 Offset: 0x21FEB20 VA: 0x182200520
	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	// RVA: 0xB292C0 Offset: 0xB278C0 VA: 0x180B292C0 Slot: 5
	public long get_Time() { }

	// RVA: 0x2200900 Offset: 0x21FEF00 VA: 0x182200900 Slot: 4
	public long get_Length() { }

	// RVA: 0x2200A10 Offset: 0x21FF010 VA: 0x182200A10
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x2200D10 Offset: 0x21FF310 VA: 0x182200D10
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x2200F30 Offset: 0x21FF530 VA: 0x182200F30
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x2200EB0 Offset: 0x21FF4B0 VA: 0x182200EB0
	public void set_OffVelocity(SevenBitNumber value) { }

	// RVA: 0x2200E10 Offset: 0x21FF410 VA: 0x182200E10
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x2200930 Offset: 0x21FEF30 VA: 0x182200930
	public NoteName get_NoteName() { }

	// RVA: 0x2200A80 Offset: 0x21FF080 VA: 0x182200A80
	public int get_Octave() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal TimedEvent get_TimedNoteOffEvent() { }

	// RVA: 0x2200B50 Offset: 0x21FF150 VA: 0x182200B50
	internal Note get_UnderlyingNote() { }

	// RVA: 0x2200110 Offset: 0x21FE710 VA: 0x182200110 Slot: 3
	public override string ToString() { }

	// RVA: 0x2200460 Offset: 0x21FEA60 VA: 0x182200460
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

