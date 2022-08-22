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

	// RVA: 0xD658E0 Offset: 0xD63EE0 VA: 0x180D658E0
	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	// RVA: 0xD667F0 Offset: 0xD64DF0 VA: 0x180D667F0
	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	// RVA: 0xD662B0 Offset: 0xD648B0 VA: 0x180D662B0
	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	// RVA: 0xD65EF0 Offset: 0xD644F0 VA: 0x180D65EF0
	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	// RVA: 0xD66B20 Offset: 0xD65120 VA: 0x180D66B20
	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute] // RVA: 0x76F60 Offset: 0x76360 VA: 0x180076F60
	// RVA: 0xD66220 Offset: 0xD64820 VA: 0x180D66220
	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid) { }

	// RVA: 0xD65C30 Offset: 0xD64230 VA: 0x180D65C30 Slot: 4
	public void Dispose() { }

	// RVA: 0xD66CB0 Offset: 0xD652B0 VA: 0x180D66CB0
	private void .ctor(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter) { }

	// RVA: 0xD65E00 Offset: 0xD64400 VA: 0x180D65E00
	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	// RVA: 0xD66180 Offset: 0xD64780 VA: 0x180D66180
	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	// RVA: 0xD65D00 Offset: 0xD64300 VA: 0x180D65D00
	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	// RVA: 0xD666A0 Offset: 0xD64CA0 VA: 0x180D666A0
	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities) { }

	// RVA: 0xD66160 Offset: 0xD64760 VA: 0x180D66160
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD87510 Offset: 0xD85B10 VA: 0x180D87510 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87700 Offset: 0xD85D00 VA: 0x180D87700 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87650 Offset: 0xD85C50 VA: 0x180D87650 Slot: 4
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87650 Offset: 0xD85C50 VA: 0x180D87650 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{	// Fields
	public ActivityFilter filterList; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87840 Offset: 0xD85E40 VA: 0x180D87840
	internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{	// Fields
	public int tickNow; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD878F0 Offset: 0xD85EF0 VA: 0x180D878F0
	internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) { }

}

