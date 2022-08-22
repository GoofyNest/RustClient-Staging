internal sealed class NotesBuilder // TypeDefIndex: 7440
{	// Fields
	private readonly NoteDetectionSettings _noteDetectionSettings; // 0x10

	// Methods

	// RVA: 0x22006F0 Offset: 0x21FECF0 VA: 0x1822006F0
	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EF10 Offset: 0x9E310 VA: 0x18009EF10
	// RVA: 0x2200570 Offset: 0x21FEB70 VA: 0x182200570
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EFE0 Offset: 0x9E3E0 VA: 0x18009EFE0
	// RVA: 0x2200630 Offset: 0x21FEC30 VA: 0x182200630
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	// RVA: 0x22004D0 Offset: 0x21FEAD0 VA: 0x1822004D0
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

	// RVA: 0x17CB140 Offset: 0x17C9740 VA: 0x1817CB140
	public bool get_IsCompleted() { }

	// RVA: 0x21FF240 Offset: 0x21FD840 VA: 0x1821FF240
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
	|-RVA: 0x17FA530 Offset: 0x17F8B30 VA: 0x1817FA530
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>..ctor
	|-NotesBuilder.NoteOnsHolderBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA630 Offset: 0x17F8C30 VA: 0x1817FA630
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.get_Count
	|-NotesBuilder.NoteOnsHolderBase<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(LinkedListNode<TDescriptor> noteOnNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA450 Offset: 0x17F8A50 VA: 0x1817FA450
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.Add
	|-NotesBuilder.NoteOnsHolderBase<object>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<TDescriptor> GetNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA4C0 Offset: 0x17F8AC0 VA: 0x1817FA4C0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.GetNext
	|-NotesBuilder.NoteOnsHolderBase<object>.GetNext
	*/

}

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7443
{	// Methods

	// RVA: 0x21FF2C0 Offset: 0x21FD8C0 VA: 0x1821FF2C0
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22039A0 Offset: 0x2201FA0 VA: 0x1822039A0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2203240 Offset: 0x2201840 VA: 0x182203240 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2203AD0 Offset: 0x22020D0 VA: 0x182203AD0
	private void <>m__Finally1() { }

	// RVA: 0x2203B20 Offset: 0x2202120 VA: 0x182203B20
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203950 Offset: 0x2201F50 VA: 0x182203950 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203880 Offset: 0x2201E80 VA: 0x182203880 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203880 Offset: 0x2201E80 VA: 0x182203880 Slot: 5
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204340 Offset: 0x2202940 VA: 0x182204340 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2203B60 Offset: 0x2202160 VA: 0x182203B60 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2204470 Offset: 0x2202A70 VA: 0x182204470
	private void <>m__Finally1() { }

	// RVA: 0x22044C0 Offset: 0x2202AC0 VA: 0x1822044C0
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22042F0 Offset: 0x22028F0 VA: 0x1822042F0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204220 Offset: 0x2202820 VA: 0x182204220 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204220 Offset: 0x2202820 VA: 0x182204220 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

