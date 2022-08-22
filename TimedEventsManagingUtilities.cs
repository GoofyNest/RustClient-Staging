public static class TimedEventsManagingUtilities // TypeDefIndex: 7459
{	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xA2B40 Offset: 0xA1F40 VA: 0x1800A2B40
	[ExtensionAttribute] // RVA: 0xA2B40 Offset: 0xA1F40 VA: 0x1800A2B40
	// RVA: 0x22033F0 Offset: 0x22019F0 VA: 0x1822033F0
	internal static IEnumerable<Tuple<TimedEvent, int>> GetTimedEventsLazy(EventsCollection[] eventsCollections, int eventsCount, bool cloneEvent = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2D00 Offset: 0xA2100 VA: 0x1800A2D00
	[ExtensionAttribute] // RVA: 0xA2D00 Offset: 0xA2100 VA: 0x1800A2D00
	// RVA: 0x2203480 Offset: 0x2201A80 VA: 0x182203480
	internal static IEnumerable<TimedEvent> GetTimedEventsLazy(IEnumerable<MidiEvent> events, bool cloneEvent = True) { }

}

private sealed class TimedEventsManagingUtilities.<>c // TypeDefIndex: 7460
{	// Fields
	public static readonly TimedEventsManagingUtilities.<>c <>9; // 0x0
	public static Func<EventsCollection, int> <>9__26_0; // 0x8

	// Methods

	// RVA: 0x2205520 Offset: 0x2203B20 VA: 0x182205520
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2205410 Offset: 0x2203A10 VA: 0x182205410
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204EA0 Offset: 0x22034A0 VA: 0x182204EA0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x22047D0 Offset: 0x2202DD0 VA: 0x1822047D0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x2204F50 Offset: 0x2203550 VA: 0x182204F50
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204E50 Offset: 0x2203450 VA: 0x182204E50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204DA0 Offset: 0x22033A0 VA: 0x182204DA0 Slot: 4
	private IEnumerator<Tuple<TimedEvent, int>> System.Collections.Generic.IEnumerable<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204DA0 Offset: 0x22033A0 VA: 0x182204DA0 Slot: 5
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22052F0 Offset: 0x22038F0 VA: 0x1822052F0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2204FA0 Offset: 0x22035A0 VA: 0x182204FA0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x22053A0 Offset: 0x22039A0 VA: 0x1822053A0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22052A0 Offset: 0x22038A0 VA: 0x1822052A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22051F0 Offset: 0x22037F0 VA: 0x1822051F0 Slot: 4
	private IEnumerator<TimedEvent> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.TimedEvent>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22051F0 Offset: 0x22037F0 VA: 0x1822051F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

