internal sealed class NotesBuilder // TypeDefIndex: 7440
{	// Fields
	private readonly NoteDetectionSettings _noteDetectionSettings; // 0x10

	// Methods

	// RVA: 0x22009B0 Offset: 0x21FEFB0 VA: 0x1822009B0
	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EF10 Offset: 0x9E310 VA: 0x18009EF10
	// RVA: 0x2200830 Offset: 0x21FEE30 VA: 0x182200830
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EFE0 Offset: 0x9E3E0 VA: 0x18009EFE0
	// RVA: 0x22008F0 Offset: 0x21FEEF0 VA: 0x1822008F0
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	// RVA: 0x2200790 Offset: 0x21FED90 VA: 0x182200790
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(TimedEvent noteOnTimedEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public TimedEvent get_NoteOnTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TimedEvent get_NoteOffTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_NoteOffTimedEvent(TimedEvent value) { }

	// RVA: 0x17CB400 Offset: 0x17C9A00 VA: 0x1817CB400
	public bool get_IsCompleted() { }

	// RVA: 0x21FF500 Offset: 0x21FDB00 VA: 0x1821FF500
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
	|-RVA: 0x17FA7F0 Offset: 0x17F8DF0 VA: 0x1817FA7F0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>..ctor
	|-NotesBuilder.NoteOnsHolderBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA8F0 Offset: 0x17F8EF0 VA: 0x1817FA8F0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.get_Count
	|-NotesBuilder.NoteOnsHolderBase<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(LinkedListNode<TDescriptor> noteOnNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA710 Offset: 0x17F8D10 VA: 0x1817FA710
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.Add
	|-NotesBuilder.NoteOnsHolderBase<object>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<TDescriptor> GetNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA780 Offset: 0x17F8D80 VA: 0x1817FA780
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.GetNext
	|-NotesBuilder.NoteOnsHolderBase<object>.GetNext
	*/

}

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7443
{	// Methods

	// RVA: 0x21FF580 Offset: 0x21FDB80 VA: 0x1821FF580
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203C60 Offset: 0x2202260 VA: 0x182203C60 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2203500 Offset: 0x2201B00 VA: 0x182203500 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2203D90 Offset: 0x2202390 VA: 0x182203D90
	private void <>m__Finally1() { }

	// RVA: 0x2203DE0 Offset: 0x22023E0 VA: 0x182203DE0
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203C10 Offset: 0x2202210 VA: 0x182203C10 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203B40 Offset: 0x2202140 VA: 0x182203B40 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203B40 Offset: 0x2202140 VA: 0x182203B40 Slot: 5
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204600 Offset: 0x2202C00 VA: 0x182204600 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2203E20 Offset: 0x2202420 VA: 0x182203E20 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2204730 Offset: 0x2202D30 VA: 0x182204730
	private void <>m__Finally1() { }

	// RVA: 0x2204780 Offset: 0x2202D80 VA: 0x182204780
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22045B0 Offset: 0x2202BB0 VA: 0x1822045B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22044E0 Offset: 0x2202AE0 VA: 0x1822044E0 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22044E0 Offset: 0x2202AE0 VA: 0x1822044E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

