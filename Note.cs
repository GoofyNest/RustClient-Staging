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

	// RVA: 0x21FFDF0 Offset: 0x21FE3F0 VA: 0x1821FFDF0
	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x21FFEC0 Offset: 0x21FE4C0 VA: 0x1821FFEC0
	public NoteName get_NoteName() { }

	// RVA: 0x2200010 Offset: 0x21FE610 VA: 0x182200010
	public int get_Octave() { }

	// RVA: 0x21FF520 Offset: 0x21FDB20 VA: 0x1821FF520
	public static Note Get(SevenBitNumber noteNumber) { }

	// RVA: 0x22002A0 Offset: 0x21FE8A0 VA: 0x1822002A0
	public static bool op_Equality(Note note1, Note note2) { }

	// RVA: 0x21FF3E0 Offset: 0x21FD9E0 VA: 0x1821FF3E0 Slot: 4
	public int CompareTo(Note other) { }

	// RVA: 0x21FF800 Offset: 0x21FDE00 VA: 0x1821FF800 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FF410 Offset: 0x21FDA10 VA: 0x1821FF410 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FF500 Offset: 0x21FDB00 VA: 0x1821FF500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FF9E0 Offset: 0x21FDFE0 VA: 0x1821FF9E0
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

	// RVA: 0x21FFA40 Offset: 0x21FE040 VA: 0x1821FFA40
	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30 Slot: 5
	public long get_Time() { }

	// RVA: 0x21FFE20 Offset: 0x21FE420 VA: 0x1821FFE20 Slot: 4
	public long get_Length() { }

	// RVA: 0x21FFF30 Offset: 0x21FE530 VA: 0x1821FFF30
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x2200230 Offset: 0x21FE830 VA: 0x182200230
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x2200450 Offset: 0x21FEA50 VA: 0x182200450
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x22003D0 Offset: 0x21FE9D0 VA: 0x1822003D0
	public void set_OffVelocity(SevenBitNumber value) { }

	// RVA: 0x2200330 Offset: 0x21FE930 VA: 0x182200330
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x21FFE50 Offset: 0x21FE450 VA: 0x1821FFE50
	public NoteName get_NoteName() { }

	// RVA: 0x21FFFA0 Offset: 0x21FE5A0 VA: 0x1821FFFA0
	public int get_Octave() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal TimedEvent get_TimedNoteOffEvent() { }

	// RVA: 0x2200070 Offset: 0x21FE670 VA: 0x182200070
	internal Note get_UnderlyingNote() { }

	// RVA: 0x21FF630 Offset: 0x21FDC30 VA: 0x1821FF630 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FF980 Offset: 0x21FDF80 VA: 0x1821FF980
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

