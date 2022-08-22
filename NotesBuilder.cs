internal sealed class NotesBuilder // TypeDefIndex: 7440
{	// Fields
	private readonly NoteDetectionSettings _noteDetectionSettings; // 0x10

	// Methods

	// RVA: 0x22011D0 Offset: 0x21FF7D0 VA: 0x1822011D0
	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EF10 Offset: 0x9E310 VA: 0x18009EF10
	// RVA: 0x2201050 Offset: 0x21FF650 VA: 0x182201050
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EFE0 Offset: 0x9E3E0 VA: 0x18009EFE0
	// RVA: 0x2201110 Offset: 0x21FF710 VA: 0x182201110
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	// RVA: 0x2200FB0 Offset: 0x21FF5B0 VA: 0x182200FB0
	private static int GetNoteEventId(NoteEvent noteEvent) { }

}

private class NotesBuilder.NoteDescriptor // TypeDefIndex: 7441
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TimedEvent <NoteOnTimedEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimedEvent <NoteOffTimedEvent>k__BackingField; // 0x18

	// Properties
	public TimedEvent NoteOnTimedEvent { get; }
	public TimedEvent NoteOffTimedEvent { get; set; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(TimedEvent noteOnTimedEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public TimedEvent get_NoteOnTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TimedEvent get_NoteOffTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_NoteOffTimedEvent(TimedEvent value) { }

	// RVA: 0x17C8F50 Offset: 0x17C7550 VA: 0x1817C8F50
	public bool get_IsCompleted() { }

	// RVA: 0x21FFD20 Offset: 0x21FE320 VA: 0x1821FFD20
	public Note GetNote() { }

}

private abstract class NotesBuilder.NoteOnsHolderBase<TDescriptor> // TypeDefIndex: 7442
{	// Fields
	private readonly NoteStartDetectionPolicy _noteStartDetectionPolicy; // 0x0
	private readonly Stack<LinkedListNode<TDescriptor>> _nodesStack; // 0x0
	private readonly Queue<LinkedListNode<TDescriptor>> _nodesQueue; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E600 Offset: 0x164CC00 VA: 0x18164E600
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>..ctor
	|-NotesBuilder.NoteOnsHolderBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E700 Offset: 0x164CD00 VA: 0x18164E700
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.get_Count
	|-NotesBuilder.NoteOnsHolderBase<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(LinkedListNode<TDescriptor> noteOnNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E520 Offset: 0x164CB20 VA: 0x18164E520
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.Add
	|-NotesBuilder.NoteOnsHolderBase<object>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<TDescriptor> GetNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E590 Offset: 0x164CB90 VA: 0x18164E590
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.GetNext
	|-NotesBuilder.NoteOnsHolderBase<object>.GetNext
	*/

}

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7443
{	// Methods

	// RVA: 0x21FFDA0 Offset: 0x21FE3A0 VA: 0x1821FFDA0
	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__7 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7444
{	// Fields
	private int <>1__state; // 0x10
	private Note <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IEnumerable<TimedEvent> timedEvents; // 0x28
	public IEnumerable<TimedEvent> <>3__timedEvents; // 0x30
	private bool collectTimedEvents; // 0x38
	public bool <>3__collectTimedEvents; // 0x39
	private List<TimedEvent> collectedTimedEvents; // 0x40
	public List<TimedEvent> <>3__collectedTimedEvents; // 0x48
	public NotesBuilder <>4__this; // 0x50
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2; // 0x58
	private Dictionary<int, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3; // 0x60
	private IEnumerator<TimedEvent> <>7__wrap3; // 0x68
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__5; // 0x70
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap5; // 0x78

	// Properties
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204480 Offset: 0x2202A80 VA: 0x182204480 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2203D20 Offset: 0x2202320 VA: 0x182203D20 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x22045B0 Offset: 0x2202BB0 VA: 0x1822045B0
	private void <>m__Finally1() { }

	// RVA: 0x2204600 Offset: 0x2202C00 VA: 0x182204600
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204430 Offset: 0x2202A30 VA: 0x182204430 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204360 Offset: 0x2202960 VA: 0x182204360 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204360 Offset: 0x2202960 VA: 0x182204360 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__8 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7445
{	// Fields
	private int <>1__state; // 0x10
	private Note <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public NotesBuilder <>4__this; // 0x28
	private IEnumerable<Tuple<TimedEvent, int>> timedEvents; // 0x30
	public IEnumerable<Tuple<TimedEvent, int>> <>3__timedEvents; // 0x38
	private bool collectTimedEvents; // 0x40
	public bool <>3__collectTimedEvents; // 0x41
	private List<Tuple<TimedEvent, int>> collectedTimedEvents; // 0x48
	public List<Tuple<TimedEvent, int>> <>3__collectedTimedEvents; // 0x50
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2; // 0x58
	private Dictionary<Tuple<int, int>, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3; // 0x60
	private bool <respectEventsCollectionIndex>5__4; // 0x68
	private IEnumerator<Tuple<TimedEvent, int>> <>7__wrap4; // 0x70
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__6; // 0x78
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap6; // 0x80

	// Properties
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204E20 Offset: 0x2203420 VA: 0x182204E20 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2204640 Offset: 0x2202C40 VA: 0x182204640 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2204F50 Offset: 0x2203550 VA: 0x182204F50
	private void <>m__Finally1() { }

	// RVA: 0x2204FA0 Offset: 0x22035A0 VA: 0x182204FA0
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204DD0 Offset: 0x22033D0 VA: 0x182204DD0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204D00 Offset: 0x2203300 VA: 0x182204D00 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204D00 Offset: 0x2203300 VA: 0x182204D00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

