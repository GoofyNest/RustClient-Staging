public static class TimedEventsManagingUtilities // TypeDefIndex: 7459
{	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xA2B40 Offset: 0xA1F40 VA: 0x1800A2B40
	[ExtensionAttribute] // RVA: 0xA2B40 Offset: 0xA1F40 VA: 0x1800A2B40
	// RVA: 0x2203130 Offset: 0x2201730 VA: 0x182203130
	internal static IEnumerable<Tuple<TimedEvent, int>> GetTimedEventsLazy(EventsCollection[] eventsCollections, int eventsCount, bool cloneEvent = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2D00 Offset: 0xA2100 VA: 0x1800A2D00
	[ExtensionAttribute] // RVA: 0xA2D00 Offset: 0xA2100 VA: 0x1800A2D00
	// RVA: 0x22031C0 Offset: 0x22017C0 VA: 0x1822031C0
	internal static IEnumerable<TimedEvent> GetTimedEventsLazy(IEnumerable<MidiEvent> events, bool cloneEvent = True) { }

}

private sealed class TimedEventsManagingUtilities.<>c // TypeDefIndex: 7460
{	// Fields
	public static readonly TimedEventsManagingUtilities.<>c <>9; // 0x0
	public static Func<EventsCollection, int> <>9__26_0; // 0x8

	// Methods

	// RVA: 0x2205260 Offset: 0x2203860 VA: 0x182205260
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2205150 Offset: 0x2203750 VA: 0x182205150
	internal int <GetTimedEventsLazy>b__26_0(EventsCollection c) { }

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__26 : IEnumerable<Tuple<TimedEvent, int>>, IEnumerable, IEnumerator<Tuple<TimedEvent, int>>, IDisposable, IEnumerator // TypeDefIndex: 7461
{	// Fields
	private int <>1__state; // 0x10
	private Tuple<TimedEvent, int> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private EventsCollection[] eventsCollections; // 0x28
	public EventsCollection[] <>3__eventsCollections; // 0x30
	private bool cloneEvent; // 0x38
	public bool <>3__cloneEvent; // 0x39
	private int eventsCount; // 0x3C
	public int <>3__eventsCount; // 0x40
	private int <eventsCollectionsCount>5__2; // 0x44
	private int[] <eventsCollectionIndices>5__3; // 0x48
	private int[] <eventsCollectionMaxIndices>5__4; // 0x50
	private long[] <eventsCollectionTimes>5__5; // 0x58
	private IEnumerator<TimedEvent> <>7__wrap5; // 0x60
	private int <i>5__7; // 0x68
	private int <eventsCollectionIndex>5__8; // 0x6C
	private long <minTime>5__9; // 0x70

	// Properties
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204BE0 Offset: 0x22031E0 VA: 0x182204BE0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2204510 Offset: 0x2202B10 VA: 0x182204510 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2204C90 Offset: 0x2203290 VA: 0x182204C90
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204B90 Offset: 0x2203190 VA: 0x182204B90 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204AE0 Offset: 0x22030E0 VA: 0x182204AE0 Slot: 4
	private IEnumerator<Tuple<TimedEvent, int>> System.Collections.Generic.IEnumerable<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204AE0 Offset: 0x22030E0 VA: 0x182204AE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__27 : IEnumerable<TimedEvent>, IEnumerable, IEnumerator<TimedEvent>, IDisposable, IEnumerator // TypeDefIndex: 7462
{	// Fields
	private int <>1__state; // 0x10
	private TimedEvent <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IEnumerable<MidiEvent> events; // 0x28
	public IEnumerable<MidiEvent> <>3__events; // 0x30
	private bool cloneEvent; // 0x38
	public bool <>3__cloneEvent; // 0x39
	private long <time>5__2; // 0x40
	private IEnumerator<MidiEvent> <>7__wrap2; // 0x48

	// Properties
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2205030 Offset: 0x2203630 VA: 0x182205030 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2204CE0 Offset: 0x22032E0 VA: 0x182204CE0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x22050E0 Offset: 0x22036E0 VA: 0x1822050E0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204FE0 Offset: 0x22035E0 VA: 0x182204FE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204F30 Offset: 0x2203530 VA: 0x182204F30 Slot: 4
	private IEnumerator<TimedEvent> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.TimedEvent>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204F30 Offset: 0x2203530 VA: 0x182204F30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

