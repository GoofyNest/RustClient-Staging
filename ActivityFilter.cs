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

	// RVA: 0xD66390 Offset: 0xD64990 VA: 0x180D66390
	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	// RVA: 0xD672A0 Offset: 0xD658A0 VA: 0x180D672A0
	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	// RVA: 0xD66D60 Offset: 0xD65360 VA: 0x180D66D60
	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	// RVA: 0xD669A0 Offset: 0xD64FA0 VA: 0x180D669A0
	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	// RVA: 0xD675D0 Offset: 0xD65BD0 VA: 0x180D675D0
	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute] // RVA: 0x76F60 Offset: 0x76360 VA: 0x180076F60
	// RVA: 0xD66CD0 Offset: 0xD652D0 VA: 0x180D66CD0
	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid) { }

	// RVA: 0xD666E0 Offset: 0xD64CE0 VA: 0x180D666E0 Slot: 4
	public void Dispose() { }

	// RVA: 0xD67760 Offset: 0xD65D60 VA: 0x180D67760
	private void .ctor(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter) { }

	// RVA: 0xD668B0 Offset: 0xD64EB0 VA: 0x180D668B0
	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	// RVA: 0xD66C30 Offset: 0xD65230 VA: 0x180D66C30
	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	// RVA: 0xD667B0 Offset: 0xD64DB0 VA: 0x180D667B0
	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	// RVA: 0xD67150 Offset: 0xD65750 VA: 0x180D67150
	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities) { }

	// RVA: 0xD66C10 Offset: 0xD65210 VA: 0x180D66C10
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD87FC0 Offset: 0xD865C0 VA: 0x180D87FC0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD881B0 Offset: 0xD867B0 VA: 0x180D881B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88100 Offset: 0xD86700 VA: 0x180D88100 Slot: 4
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88100 Offset: 0xD86700 VA: 0x180D88100 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{	// Fields
	public ActivityFilter filterList; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD882F0 Offset: 0xD868F0 VA: 0x180D882F0
	internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{	// Fields
	public int tickNow; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD883A0 Offset: 0xD869A0 VA: 0x180D883A0
	internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) { }

}

