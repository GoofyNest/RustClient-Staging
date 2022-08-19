internal sealed class ActivityFilter : IDisposable // TypeDefIndex: 1614
{	// Fields
	private ConcurrentDictionary<Guid, int> m_activeActivities; // 0x10
	private ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities; // 0x18
	private Guid m_providerGuid; // 0x20
	private int m_eventId; // 0x30
	private int m_samplingFreq; // 0x34
	private int m_curSampleCount; // 0x38
	private int m_perEventSourceSessionId; // 0x3C
	private ActivityFilter m_next; // 0x40
	private Action<Guid> m_myActivityDelegate; // 0x48

	// Methods

	// RVA: 0xD65620 Offset: 0xD63C20 VA: 0x180D65620
	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	// RVA: 0xD66530 Offset: 0xD64B30 VA: 0x180D66530
	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	// RVA: 0xD65FF0 Offset: 0xD645F0 VA: 0x180D65FF0
	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	// RVA: 0xD65C30 Offset: 0xD64230 VA: 0x180D65C30
	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	// RVA: 0xD66860 Offset: 0xD64E60 VA: 0x180D66860
	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute] // RVA: 0x76F70 Offset: 0x76370 VA: 0x180076F70
	// RVA: 0xD65F60 Offset: 0xD64560 VA: 0x180D65F60
	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid) { }

	// RVA: 0xD65970 Offset: 0xD63F70 VA: 0x180D65970 Slot: 4
	public void Dispose() { }

	// RVA: 0xD669F0 Offset: 0xD64FF0 VA: 0x180D669F0
	private void .ctor(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter) { }

	// RVA: 0xD65B40 Offset: 0xD64140 VA: 0x180D65B40
	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	// RVA: 0xD65EC0 Offset: 0xD644C0 VA: 0x180D65EC0
	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	// RVA: 0xD65A40 Offset: 0xD64040 VA: 0x180D65A40
	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	// RVA: 0xD663E0 Offset: 0xD649E0 VA: 0x180D663E0
	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities) { }

	// RVA: 0xD65EA0 Offset: 0xD644A0 VA: 0x180D65EA0
	private static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList) { }

}

private sealed class ActivityFilter.<GetFilterAsTuple>d__7 : IEnumerable<Tuple<int, int>>, IEnumerable, IEnumerator<Tuple<int, int>>, IDisposable, IEnumerator // TypeDefIndex: 1615
{	// Fields
	private int <>1__state; // 0x10
	private Tuple<int, int> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ActivityFilter <>4__this; // 0x28
	private Guid sourceGuid; // 0x30
	public Guid <>3__sourceGuid; // 0x40
	private ActivityFilter <af>5__1; // 0x50

	// Properties
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD87250 Offset: 0xD85850 VA: 0x180D87250 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87440 Offset: 0xD85A40 VA: 0x180D87440 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87390 Offset: 0xD85990 VA: 0x180D87390 Slot: 4
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87390 Offset: 0xD85990 VA: 0x180D87390 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{	// Fields
	public ActivityFilter filterList; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87580 Offset: 0xD85B80 VA: 0x180D87580
	internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{	// Fields
	public int tickNow; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87630 Offset: 0xD85C30 VA: 0x180D87630
	internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) { }

}

