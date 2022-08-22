public class EventArgs // TypeDefIndex: 215
{	// Fields
	public static readonly EventArgs Empty; // 0x2B111C0

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10DBDE0 Offset: 0x10DA3E0 VA: 0x1810DBDE0
	private static void .cctor() { }

}

public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 216
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 217
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-EventHandler<LoadCompletedEventArgs>..ctor
	|-EventHandler<LoadProgressEventArgs>..ctor
	|-EventHandler<StateChangedEventArgs>..ctor
	|-EventHandler<RowUpdatingEventArgs>..ctor
	|-EventHandler<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880
	|-EventHandler<ErrorEventArgs>.Invoke
	|-EventHandler<EventCommandEventArgs>.Invoke
	|-EventHandler<EventSourceCreatedEventArgs>.Invoke
	|-EventHandler<EventWrittenEventArgs>.Invoke
	|-EventHandler<SocketAsyncEventArgs>.Invoke
	|-EventHandler<object>.Invoke
	|-EventHandler<SafeSerializationEventArgs>.Invoke
	|-EventHandler<UnobservedTaskExceptionEventArgs>.Invoke
	|-EventHandler<XObjectChangeEventArgs>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, TEventArgs e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840
	|-EventHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-EventHandler<object>.EndInvoke
	*/

}

public enum EventAttributes // TypeDefIndex: 524
{	// Fields
	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes ReservedMask = 1024;
	public const EventAttributes RTSpecialName = 1024;

}

public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 565
{	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public virtual Type EventHandlerType { get; }
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x18C8E90 Offset: 0x18C7490 VA: 0x1818C8E90 Slot: 17
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C6660 Offset: 0x18C4C60 VA: 0x1818C6660
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C8F10 Offset: 0x18C7510 VA: 0x1818C8F10
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18C8DD0 Offset: 0x18C73D0 VA: 0x1818C8DD0
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

}

private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 566
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object _this, Delegate dele) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object _this, Delegate dele, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum EventResetMode // TypeDefIndex: 778
{	// Fields
	public int value__; // 0x0
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;

}

public class EventWaitHandle : WaitHandle // TypeDefIndex: 779
{	// Methods

	// RVA: 0x1493140 Offset: 0x1491740 VA: 0x181493140
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x1493160 Offset: 0x1491760 VA: 0x181493160
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x1493060 Offset: 0x1491660 VA: 0x181493060
	public bool Reset() { }

	// RVA: 0x14930D0 Offset: 0x14916D0 VA: 0x1814930D0
	public bool Set() { }

}

public enum EventFieldTags // TypeDefIndex: 1516
{	// Fields
	public int value__; // 0x0
	public const EventFieldTags None = 0;

}

public class EventFieldAttribute : Attribute // TypeDefIndex: 1517
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventFieldTags <Tags>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventFieldFormat <Format>k__BackingField; // 0x20

	// Properties
	public EventFieldTags Tags { get; }
	internal string Name { get; }
	public EventFieldFormat Format { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public EventFieldFormat get_Format() { }

}

public enum EventFieldFormat // TypeDefIndex: 1518
{	// Fields
	public int value__; // 0x0
	public const EventFieldFormat Default = 0;
	public const EventFieldFormat String = 2;
	public const EventFieldFormat Boolean = 3;
	public const EventFieldFormat Hexadecimal = 4;
	public const EventFieldFormat Xml = 11;
	public const EventFieldFormat Json = 12;
	public const EventFieldFormat HResult = 15;

}

internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 1520
{
// Namespace: System.Diagnostics.Tracing
[DefaultMemberAttribute] // RVA: 0x70CB0 Offset: 0x700B0 VA: 0x180070CB0
internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 1520
	// Fields
	private List<string> m_names; // 0x10
	private List<object> m_values; // 0x18

	// Properties
	public ICollection<string> Keys { get; }
	public ICollection<object> Values { get; }
	public object Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(List<string> payloadNames, List<object> payloadValues) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public ICollection<string> get_Keys() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	public ICollection<object> get_Values() { }

	// RVA: 0xD75400 Offset: 0xD73A00 VA: 0x180D75400 Slot: 4
	public object get_Item(string key) { }

	// RVA: 0xD755F0 Offset: 0xD73BF0 VA: 0x180D755F0 Slot: 5
	public void set_Item(string key, object value) { }

	// RVA: 0xD74DB0 Offset: 0xD733B0 VA: 0x180D74DB0 Slot: 9
	public void Add(string key, object value) { }

	// RVA: 0xD74D60 Offset: 0xD73360 VA: 0x180D74D60 Slot: 14
	public void Add(KeyValuePair<string, object> payloadEntry) { }

	// RVA: 0xD74E00 Offset: 0xD73400 VA: 0x180D74E00 Slot: 15
	public void Clear() { }

	// RVA: 0xD74FE0 Offset: 0xD735E0 VA: 0x180D74FE0 Slot: 16
	public bool Contains(KeyValuePair<string, object> entry) { }

	// RVA: 0xD74E50 Offset: 0xD73450 VA: 0x180D74E50 Slot: 8
	public bool ContainsKey(string key) { }

	// RVA: 0xD753C0 Offset: 0xD739C0 VA: 0x180D753C0 Slot: 12
	public int get_Count() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public bool get_IsReadOnly() { }

	[IteratorStateMachineAttribute] // RVA: 0xF0A50 Offset: 0xEFE50 VA: 0x1800F0A50
	// RVA: 0xD75080 Offset: 0xD73680 VA: 0x180D75080 Slot: 19
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	// RVA: 0xD75190 Offset: 0xD73790 VA: 0x180D75190 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD75030 Offset: 0xD73630 VA: 0x180D75030 Slot: 17
	public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count) { }

	// RVA: 0xD750F0 Offset: 0xD736F0 VA: 0x180D750F0 Slot: 10
	public bool Remove(string key) { }

	// RVA: 0xD75140 Offset: 0xD73740 VA: 0x180D75140 Slot: 18
	public bool Remove(KeyValuePair<string, object> entry) { }

	// RVA: 0xD751D0 Offset: 0xD737D0 VA: 0x180D751D0 Slot: 11
	public bool TryGetValue(string key, out object value) { }

}

private sealed class EventPayload.<GetEnumerator>d__17 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 1521
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, object> <>2__current; // 0x18
	public EventPayload <>4__this; // 0x28
	private int <i>5__1; // 0x30

	// Properties
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD87330 Offset: 0xD85930 VA: 0x180D87330 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0 Slot: 4
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87470 Offset: 0xD85A70 VA: 0x180D87470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD874C0 Offset: 0xD85AC0 VA: 0x180D874C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct EventSourceOptions // TypeDefIndex: 1522
{	// Fields
	internal EventKeywords keywords; // 0x0
	internal EventTags tags; // 0x8
	internal EventActivityOptions activityOptions; // 0xC
	internal byte level; // 0x10
	internal byte opcode; // 0x11
	internal byte valuesSet; // 0x12

	// Properties
	public EventLevel Level { set; }
	public EventOpcode Opcode { set; }
	public EventKeywords Keywords { set; }

	// Methods

	// RVA: 0x19F590 Offset: 0x19E990 VA: 0x18019F590
	public void set_Level(EventLevel value) { }

	// RVA: 0x19F5F0 Offset: 0x19E9F0 VA: 0x18019F5F0
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0x19F580 Offset: 0x19E980 VA: 0x18019F580
	public void set_Keywords(EventKeywords value) { }

}

public class EventSource : IDisposable // TypeDefIndex: 1580
{	// Fields
	private byte[] providerMetadata; // 0x10
	private string m_name; // 0x18
	internal int m_id; // 0x20
	private Guid m_guid; // 0x24
	internal EventSource.EventMetadata[] m_eventData; // 0x38
	private byte[] m_rawManifest; // 0x40
	private EventHandler<EventCommandEventArgs> m_eventCommandExecuted; // 0x48
	private EventSourceSettings m_config; // 0x50
	private bool m_eventSourceEnabled; // 0x54
	internal EventLevel m_level; // 0x58
	internal EventKeywords m_matchAnyKeyword; // 0x60
	internal EventDispatcher m_Dispatchers; // 0x68
	private EventSource.OverideEventProvider m_provider; // 0x70
	private bool m_completelyInited; // 0x78
	private Exception m_constructionException; // 0x80
	private byte m_outOfBandMessageCount; // 0x88
	private EventCommandEventArgs m_deferredCommands; // 0x90
	private string[] m_traits; // 0x98
	internal static uint s_currentPid; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static byte m_EventSourceExceptionRecurenceCount; // 0x80000000
	private SessionMask m_curLiveSessions; // 0xA0
	private EtwSession[] m_etwSessionIdMap; // 0xA8
	private List<EtwSession> m_legacySessions; // 0xB0
	internal long m_keywordTriggers; // 0xB8
	internal SessionMask m_activityFilteringForETWEnabled; // 0xC0
	internal static Action<Guid> s_activityDying; // 0x8
	private ActivityTracker m_activityTracker; // 0xC8
	private static readonly byte[] namespaceBytes; // 0x10
	private static readonly Guid AspNetEventSourceGuid; // 0x18

	// Properties
	public string Name { get; }
	public Guid Guid { get; }
	public static Guid CurrentThreadActivityId { get; }
	internal static Guid InternalCurrentThreadActivityId { get; }
	internal static Guid FallbackActivityId { get; }
	private bool IsDisposed { get; }
	private bool ThrowOnEventWriteErrors { get; }
	private bool SelfDescribingEvents { get; }

	// Methods

	// RVA: 0xD84A60 Offset: 0xD83060 VA: 0x180D84A60
	private void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD84530 Offset: 0xD82B30 VA: 0x180D84530
	private void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD84AF0 Offset: 0xD830F0 VA: 0x180D84AF0
	internal void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data) { }

	[NonEventAttribute] // RVA: 0x70090 Offset: 0x6F490 VA: 0x180070090
	[ReliabilityContractAttribute] // RVA: 0x70090 Offset: 0x6F490 VA: 0x180070090
	// RVA: 0xD81CE0 Offset: 0xD802E0 VA: 0x180D81CE0
	private void WriteCleanup(GCHandle* pPins, int cPins) { }

	// RVA: 0xD7EEB0 Offset: 0xD7D4B0 VA: 0x180D7EEB0
	private void InitializeProviderMetadata() { }

	// RVA: 0xD79120 Offset: 0xD77720 VA: 0x180D79120
	private static int AddValueToMetaData(List<byte> metaData, string value) { }

	// RVA: 0xD7EDB0 Offset: 0xD7D3B0 VA: 0x180D7EDB0
	private static int HexDigit(char c) { }

	// RVA: 0xD816D0 Offset: 0xD7FCD0 VA: 0x180D816D0
	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0xD85EC0 Offset: 0xD844C0 VA: 0x180D85EC0
	public Guid get_Guid() { }

	// RVA: 0xABF100 Offset: 0xABD700 VA: 0x180ABF100
	public bool IsEnabled() { }

	// RVA: 0xD7FA40 Offset: 0xD7E040 VA: 0x180D7FA40
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0xD7FA40 Offset: 0xD7E040 VA: 0x180D7FA40
	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel) { }

	// RVA: 0xD7E430 Offset: 0xD7CA30 VA: 0x180D7E430
	public static Guid GetGuid(Type eventSourceType) { }

	// RVA: 0xD7EA60 Offset: 0xD7D060 VA: 0x180D7EA60
	public static string GetName(Type eventSourceType) { }

	// RVA: 0xD80C10 Offset: 0xD7F210 VA: 0x180D80C10
	public static void SetCurrentThreadActivityId(Guid activityId) { }

	// RVA: 0xD85DD0 Offset: 0xD843D0 VA: 0x180D85DD0
	public static Guid get_CurrentThreadActivityId() { }

	// RVA: 0xD85ED0 Offset: 0xD844D0 VA: 0x180D85ED0
	internal static Guid get_InternalCurrentThreadActivityId() { }

	// RVA: 0xD85E00 Offset: 0xD84400 VA: 0x180D85E00
	internal static Guid get_FallbackActivityId() { }

	// RVA: 0xD814D0 Offset: 0xD7FAD0 VA: 0x180D814D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD859D0 Offset: 0xD83FD0 VA: 0x180D859D0
	protected void .ctor() { }

	// RVA: 0xD85AE0 Offset: 0xD840E0 VA: 0x180D85AE0
	protected void .ctor(EventSourceSettings settings) { }

	// RVA: 0xD85C50 Offset: 0xD84250 VA: 0x180D85C50
	protected void .ctor(EventSourceSettings settings, string[] traits) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void OnEventCommand(EventCommandEventArgs command) { }

	// RVA: 0xD84140 Offset: 0xD82740 VA: 0x180D84140
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0xD84050 Offset: 0xD82650 VA: 0x180D84050
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0xD83FA0 Offset: 0xD825A0 VA: 0x180D83FA0
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0xD84300 Offset: 0xD82900 VA: 0x180D84300
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0xD843E0 Offset: 0xD829E0 VA: 0x180D843E0
	protected void WriteEvent(int eventId, string arg1, string arg2) { }

	// RVA: 0xD83E10 Offset: 0xD82410 VA: 0x180D83E10
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	// RVA: 0xD841F0 Offset: 0xD827F0 VA: 0x180D841F0
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xD81D90 Offset: 0xD80390 VA: 0x180D81D90
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xD83130 Offset: 0xD81730 VA: 0x180D83130
	protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD83DF0 Offset: 0xD823F0 VA: 0x180D83DF0
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0xD7C310 Offset: 0xD7A910 VA: 0x180D7C310 Slot: 4
	public void Dispose() { }

	// RVA: 0xD7C380 Offset: 0xD7A980 VA: 0x180D7C380 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD7D510 Offset: 0xD7BB10 VA: 0x180D7D510 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD85200 Offset: 0xD83800 VA: 0x180D85200
	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m) { }

	// RVA: 0xD81DC0 Offset: 0xD803C0 VA: 0x180D81DC0
	private void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD7F370 Offset: 0xD7D970 VA: 0x180D7F370
	private void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits) { }

	// RVA: 0xD7EAC0 Offset: 0xD7D0C0 VA: 0x180D7EAC0
	private static string GetName(Type eventSourceType, EventManifestOptions flags) { }

	// RVA: 0xD7D5B0 Offset: 0xD7BBB0 VA: 0x180D7D5B0
	private static Guid GenerateGuidFromName(string name) { }

	// RVA: 0xD7B810 Offset: 0xD79E10 VA: 0x180D7B810
	private object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data) { }

	// RVA: 0xD7DED0 Offset: 0xD7C4D0 VA: 0x180D7DED0
	private EventDispatcher GetDispatcher(EventListener listener) { }

	// RVA: 0xD82330 Offset: 0xD80930 VA: 0x180D82330
	private void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD80990 Offset: 0xD7EF90 VA: 0x180D80990
	private object[] SerializeEventArgs(int eventId, object[] args) { }

	// RVA: 0xD7FA70 Offset: 0xD7E070 VA: 0x180D7FA70
	private void LogEventArgsMismatches(ParameterInfo[] infos, object[] args) { }

	// RVA: 0xD7ECB0 Offset: 0xD7D2B0 VA: 0x180D7ECB0
	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters) { }

	// RVA: 0xD854C0 Offset: 0xD83AC0 VA: 0x180D854C0
	private void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD85350 Offset: 0xD83950 VA: 0x180D85350
	private void WriteToAllListeners(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD7C100 Offset: 0xD7A700 VA: 0x180D7C100
	private void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs) { }

	// RVA: 0xD81EC0 Offset: 0xD804C0 VA: 0x180D81EC0
	private void WriteEventString(EventLevel level, long keywords, string msgString) { }

	// RVA: 0xD84FE0 Offset: 0xD835E0 VA: 0x180D84FE0
	private void WriteStringToAllListeners(string eventName, string msg) { }

	// RVA: 0xD7DF10 Offset: 0xD7C510 VA: 0x180D7DF10
	private SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID) { }

	// RVA: 0xD7F910 Offset: 0xD7DF10 VA: 0x180D7F910
	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword) { }

	// RVA: 0xD7FA10 Offset: 0xD7E010 VA: 0x180D7FA10
	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel) { }

	// RVA: 0xD80E20 Offset: 0xD7F420 VA: 0x180D80E20
	private void ThrowEventSourceException(string eventName, Exception innerEx) { }

	// RVA: 0xD81C20 Offset: 0xD80220 VA: 0x180D81C20
	private void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName) { }

	// RVA: 0xD7EC20 Offset: 0xD7D220 VA: 0x180D7EC20
	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName) { }

	// RVA: 0xD80520 Offset: 0xD7EB20 VA: 0x180D80520
	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments) { }

	// RVA: 0xD7C4B0 Offset: 0xD7AAB0 VA: 0x180D7C4B0
	internal void DoCommand(EventCommandEventArgs commandArgs) { }

	// RVA: 0xD81810 Offset: 0xD7FE10 VA: 0x180D81810
	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling) { }

	// RVA: 0xD7FCB0 Offset: 0xD7E2B0 VA: 0x180D7FCB0
	internal static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit) { }

	// RVA: 0xD81B50 Offset: 0xD80150 VA: 0x180D81B50
	internal void UpdateKwdTriggers(bool enable) { }

	// RVA: 0xD7D010 Offset: 0xD7B610 VA: 0x180D7D010
	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value) { }

	// RVA: 0xD793D0 Offset: 0xD779D0 VA: 0x180D793D0
	private bool AnyEventEnabled() { }

	// RVA: 0xD85FD0 Offset: 0xD845D0 VA: 0x180D85FD0
	private bool get_IsDisposed() { }

	// RVA: 0xD7D110 Offset: 0xD7B710 VA: 0x180D7D110
	private void EnsureDescriptorsInitialized() { }

	// RVA: 0xD80730 Offset: 0xD7ED30 VA: 0x180D80730
	private bool SendManifest(byte[] rawManifest) { }

	// RVA: 0xD7D700 Offset: 0xD7BD00 VA: 0x180D7D700
	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = 0) { }

	// RVA: 0xD794A0 Offset: 0xD77AA0 VA: 0x180D794A0
	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType) { }

	// RVA: 0xD7E210 Offset: 0xD7C810 VA: 0x180D7E210
	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly) { }

	// RVA: 0xD79630 Offset: 0xD77C30 VA: 0x180D79630
	private static byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = 0) { }

	// RVA: 0xD7FEB0 Offset: 0xD7E4B0 VA: 0x180D7FEB0
	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args) { }

	// RVA: 0xD78B10 Offset: 0xD77110 VA: 0x180D78B10
	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind) { }

	// RVA: 0xD785D0 Offset: 0xD76BD0 VA: 0x180D785D0
	private static void AddEventDescriptor(ref EventSource.EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID) { }

	// RVA: 0xD81610 Offset: 0xD7FC10 VA: 0x180D81610
	private static void TrimEventDescriptors(ref EventSource.EventMetadata[] eventData) { }

	// RVA: 0xD78940 Offset: 0xD76F40 VA: 0x180D78940
	internal void AddListener(EventListener listener) { }

	// RVA: 0xD7AF10 Offset: 0xD79510 VA: 0x180D7AF10
	private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventSource.EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options) { }

	// RVA: 0xD7E7B0 Offset: 0xD7CDB0 VA: 0x180D7E7B0
	private static int GetHelperCallFirstArg(MethodInfo method) { }

	// RVA: 0xD80430 Offset: 0xD7EA30 VA: 0x180D80430
	internal void ReportOutOfBandMessage(string msg, bool flush) { }

	// RVA: 0xD81C50 Offset: 0xD80250 VA: 0x180D81C50
	private EventSourceSettings ValidateSettings(EventSourceSettings settings) { }

	// RVA: 0xD86030 Offset: 0xD84630 VA: 0x180D86030
	private bool get_ThrowOnEventWriteErrors() { }

	// RVA: 0xD86020 Offset: 0xD84620 VA: 0x180D86020
	private bool get_SelfDescribingEvents() { }

	// RVA: 0xD80050 Offset: 0xD7E650 VA: 0x180D80050
	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions) { }

	// RVA: 0xD85920 Offset: 0xD83F20 VA: 0x180D85920
	private static void .cctor() { }

}

private struct EventSource.Sha1ForNonSecretPurposes // TypeDefIndex: 1582
{	// Fields
	private long length; // 0x0
	private uint[] w; // 0x8
	private int pos; // 0x10

	// Methods

	// RVA: 0x19F7D0 Offset: 0x19EBD0 VA: 0x18019F7D0
	public void Start() { }

	// RVA: 0x19F6E0 Offset: 0x19EAE0 VA: 0x18019F6E0
	public void Append(byte input) { }

	// RVA: 0x19F6F0 Offset: 0x19EAF0 VA: 0x18019F6F0
	public void Append(byte[] input) { }

	// RVA: 0x19F7C0 Offset: 0x19EBC0 VA: 0x18019F7C0
	public void Finish(byte[] output) { }

	// RVA: 0x19F7B0 Offset: 0x19EBB0 VA: 0x18019F7B0
	private void Drain() { }

	// RVA: 0x10E5960 Offset: 0x10E3F60 VA: 0x1810E5960
	private static uint Rol1(uint input) { }

	// RVA: 0x10E5980 Offset: 0x10E3F80 VA: 0x1810E5980
	private static uint Rol5(uint input) { }

	// RVA: 0x10E5970 Offset: 0x10E3F70 VA: 0x1810E5970
	private static uint Rol30(uint input) { }

}

private class EventSource.OverideEventProvider : EventProvider // TypeDefIndex: 1583
{	// Fields
	private EventSource m_eventSource; // 0x60

	// Methods

	// RVA: 0x10E4AC0 Offset: 0x10E30C0 VA: 0x1810E4AC0
	public void .ctor(EventSource eventSource) { }

	// RVA: 0x10E4A60 Offset: 0x10E3060 VA: 0x1810E4A60 Slot: 6
	protected override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId) { }

}

internal struct EventSource.EventMetadata // TypeDefIndex: 1584
{	// Fields
	public EventDescriptor Descriptor; // 0x0
	public EventTags Tags; // 0x10
	public bool EnabledForAnyListener; // 0x14
	public bool EnabledForETW; // 0x15
	public bool HasRelatedActivityID; // 0x16
	public byte TriggersActivityTracking; // 0x17
	public string Name; // 0x18
	public string Message; // 0x20
	public ParameterInfo[] Parameters; // 0x28
	public TraceLoggingEventTypes TraceLoggingEventTypes; // 0x30
	public EventActivityOptions ActivityOptions; // 0x38

}

public enum EventTags // TypeDefIndex: 1585
{	// Fields
	public int value__; // 0x0
	public const EventTags None = 0;

}

public enum EventActivityOptions // TypeDefIndex: 1596
{	// Fields
	public int value__; // 0x0
	public const EventActivityOptions None = 0;
	public const EventActivityOptions Disable = 2;
	public const EventActivityOptions Recursive = 4;
	public const EventActivityOptions Detachable = 8;

}

internal struct EventDescriptor // TypeDefIndex: 1597
{	// Fields
	private int m_traceloggingId; // 0x0
	private ushort m_id; // 0x0
	private byte m_version; // 0x2
	private byte m_channel; // 0x3
	private byte m_level; // 0x4
	private byte m_opcode; // 0x5
	private ushort m_task; // 0x6
	private long m_keywords; // 0x8

	// Properties
	public int EventId { get; }
	public byte Version { get; }
	public byte Channel { get; }
	public byte Level { get; }
	public byte Opcode { get; }
	public int Task { get; }
	public long Keywords { get; }

	// Methods

	// RVA: 0x121020 Offset: 0x120420 VA: 0x180121020
	public void .ctor(int traceloggingId, byte level, byte opcode, long keywords) { }

	// RVA: 0x121050 Offset: 0x120450 VA: 0x180121050
	public void .ctor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { }

	// RVA: 0x121080 Offset: 0x120480 VA: 0x180121080
	public int get_EventId() { }

	// RVA: 0x1210C0 Offset: 0x1204C0 VA: 0x1801210C0
	public byte get_Version() { }

	// RVA: 0x121070 Offset: 0x120470 VA: 0x180121070
	public byte get_Channel() { }

	// RVA: 0x121090 Offset: 0x120490 VA: 0x180121090
	public byte get_Level() { }

	// RVA: 0x1210A0 Offset: 0x1204A0 VA: 0x1801210A0
	public byte get_Opcode() { }

	// RVA: 0x1210B0 Offset: 0x1204B0 VA: 0x1801210B0
	public int get_Task() { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public long get_Keywords() { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x120FF0 Offset: 0x1203F0 VA: 0x180120FF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x120EB0 Offset: 0x1202B0 VA: 0x180120EB0
	public bool Equals(EventDescriptor other) { }

}

internal class EventProvider : IDisposable // TypeDefIndex: 1599
{	// Fields
	private static bool m_setInformationMissing; // 0x0
	private UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback; // 0x10
	private GCHandle m_thisGCHandle; // 0x18
	private long m_regHandle; // 0x20
	private byte m_level; // 0x28
	private long m_anyKeywordMask; // 0x30
	private long m_allKeywordMask; // 0x38
	private List<EventProvider.SessionInfo> m_liveSessions; // 0x40
	private bool m_enabled; // 0x48
	private Guid m_providerId; // 0x4C
	internal bool m_disposed; // 0x5C
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static EventProvider.WriteEventErrorCode s_returnCode; // 0x80000000
	private static int[] nibblebits; // 0x8

	// Properties
	protected EventLevel Level { get; }
	protected EventKeywords MatchAnyKeyword { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0xD774C0 Offset: 0xD75AC0 VA: 0x180D774C0
	internal void Register(Guid providerGuid) { }

	// RVA: 0xD77600 Offset: 0xD75C00 VA: 0x180D77600
	internal int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize) { }

	// RVA: 0xD757B0 Offset: 0xD73DB0 VA: 0x180D757B0 Slot: 4
	public void Dispose() { }

	// RVA: 0xD75680 Offset: 0xD73C80 VA: 0x180D75680 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD75640 Offset: 0xD73C40 VA: 0x180D75640
	private void Deregister() { }

	[EventProvider.MonoPInvokeCallbackAttribute] // RVA: 0x70EC0 Offset: 0x702C0 VA: 0x180070EC0
	// RVA: 0xD768E0 Offset: 0xD74EE0 VA: 0x180D768E0
	private static void EtwEnableCallBack(in Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0xD76380 Offset: 0xD74980 VA: 0x180D76380
	private void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	protected EventLevel get_Level() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	protected EventKeywords get_MatchAnyKeyword() { }

	// RVA: 0xD76A30 Offset: 0xD75030 VA: 0x180D76A30
	private static int FindNull(byte[] buffer, int idx) { }

	// RVA: 0xD76F30 Offset: 0xD75530 VA: 0x180D76F30
	private List<Tuple<EventProvider.SessionInfo, bool>> GetSessions() { }

	// RVA: 0xD76C30 Offset: 0xD75230 VA: 0x180D76C30
	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList) { }

	// RVA: 0xD76DC0 Offset: 0xD753C0 VA: 0x180D76DC0
	private void GetSessionInfo(Action<int, long> action) { }

	// RVA: 0xD773F0 Offset: 0xD759F0 VA: 0x180D773F0
	private static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId) { }

	// RVA: 0xD76A80 Offset: 0xD75080 VA: 0x180D76A80
	private bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data, out int dataStart) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool IsEnabled() { }

	// RVA: 0xD77480 Offset: 0xD75A80 VA: 0x180D77480
	public bool IsEnabled(byte level, long keywords) { }

	// RVA: 0xD76B90 Offset: 0xD75190 VA: 0x180D76B90
	public static EventProvider.WriteEventErrorCode GetLastWriteEventError() { }

	// RVA: 0xD77700 Offset: 0xD75D00 VA: 0x180D77700
	private static void SetLastError(int error) { }

	// RVA: 0xD75820 Offset: 0xD73E20 VA: 0x180D75820
	private static object EncodeObject(ref object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize) { }

	// RVA: 0xD77930 Offset: 0xD75F30 VA: 0x180D77930
	internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, object[] eventPayload) { }

	// RVA: 0xD77870 Offset: 0xD75E70 VA: 0x180D77870
	protected internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD777B0 Offset: 0xD75DB0 VA: 0x180D777B0
	internal bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD76A00 Offset: 0xD75000 VA: 0x180D76A00
	private uint EventUnregister() { }

	// RVA: 0xD78510 Offset: 0xD76B10 VA: 0x180D78510
	private static int bitcount(uint n) { }

	// RVA: 0xD785B0 Offset: 0xD76BB0 VA: 0x180D785B0
	private static int bitindex(uint n) { }

	// RVA: 0xD784A0 Offset: 0xD76AA0 VA: 0x180D784A0
	private static void .cctor() { }

}

public struct EventProvider.EventData // TypeDefIndex: 1600
{	// Fields
	internal ulong Ptr; // 0x0
	internal uint Size; // 0x8
	internal uint Reserved; // 0xC

}

public struct EventProvider.SessionInfo // TypeDefIndex: 1601
{	// Fields
	internal int sessionIdBit; // 0x0
	internal int etwSessionId; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	internal void .ctor(int sessionIdBit_, int etwSessionId_) { }

}

public enum EventProvider.WriteEventErrorCode // TypeDefIndex: 1602
{	// Fields
	public int value__; // 0x0
	public const EventProvider.WriteEventErrorCode NoError = 0;
	public const EventProvider.WriteEventErrorCode NoFreeBuffers = 1;
	public const EventProvider.WriteEventErrorCode EventTooBig = 2;
	public const EventProvider.WriteEventErrorCode NullInput = 3;
	public const EventProvider.WriteEventErrorCode TooManyArgs = 4;
	public const EventProvider.WriteEventErrorCode Other = 5;

}

private sealed class EventProvider.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 1603
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor(Type t) { }

}

private sealed class EventProvider.<>c__DisplayClass44_0 // TypeDefIndex: 1604
{	// Fields
	public List<EventProvider.SessionInfo> liveSessionList; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD879E0 Offset: 0xD85FE0 VA: 0x180D879E0
	internal void <GetSessions>b__0(int etwSessionId, long matchAllKeywords) { }

}

public enum EventSourceSettings // TypeDefIndex: 1605
{	// Fields
	public int value__; // 0x0
	public const EventSourceSettings Default = 0;
	public const EventSourceSettings ThrowOnEventWriteErrors = 1;
	public const EventSourceSettings EtwManifestEventFormat = 4;
	public const EventSourceSettings EtwSelfDescribingEventFormat = 8;

}

public class EventListener // TypeDefIndex: 1606
{	// Fields
	private static readonly object s_EventSourceCreatedLock; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<EventWrittenEventArgs> EventWritten; // 0x18
	internal EventListener m_Next; // 0x20
	internal ActivityFilter m_activityFilter; // 0x28
	internal static EventListener s_Listeners; // 0x8
	internal static List<WeakReference> s_EventSources; // 0x10
	private static bool s_CreatingListener; // 0x18
	private static bool s_EventSourceShutdownRegistered; // 0x19

	// Properties
	internal static object EventListenersLock { get; }

	// Methods

	// RVA: 0xD74AE0 Offset: 0xD730E0 VA: 0x180D74AE0 Slot: 4
	protected internal virtual void OnEventSourceCreated(EventSource eventSource) { }

	// RVA: 0xD74B80 Offset: 0xD73180 VA: 0x180D74B80 Slot: 5
	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData) { }

	// RVA: 0xD74410 Offset: 0xD72A10 VA: 0x180D74410
	internal static void AddEventSource(EventSource newEventSource) { }

	// RVA: 0xD748A0 Offset: 0xD72EA0 VA: 0x180D748A0
	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	// RVA: 0xD74C60 Offset: 0xD73260 VA: 0x180D74C60
	internal static object get_EventListenersLock() { }

	// RVA: 0xD74BE0 Offset: 0xD731E0 VA: 0x180D74BE0
	private static void .cctor() { }

}

public class EventCommandEventArgs : EventArgs // TypeDefIndex: 1607
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventCommand <Command>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IDictionary<string, string> <Arguments>k__BackingField; // 0x18
	internal EventSource eventSource; // 0x20
	internal EventDispatcher dispatcher; // 0x28
	internal EventListener listener; // 0x30
	internal int perEventSourceSessionId; // 0x38
	internal int etwSessionId; // 0x3C
	internal bool enable; // 0x40
	internal EventLevel level; // 0x44
	internal EventKeywords matchAnyKeyword; // 0x48
	internal EventCommandEventArgs nextCommand; // 0x50

	// Properties
	public EventCommand Command { get; set; }
	public IDictionary<string, string> Arguments { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public EventCommand get_Command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	internal void set_Command(EventCommand value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IDictionary<string, string> get_Arguments() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Arguments(IDictionary<string, string> value) { }

	// RVA: 0xD73FF0 Offset: 0xD725F0 VA: 0x180D73FF0
	internal void .ctor(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword) { }

}

public class EventSourceCreatedEventArgs : EventArgs // TypeDefIndex: 1608
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventSource <EventSource>k__BackingField; // 0x10

	// Properties
	internal EventSource EventSource { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_EventSource(EventSource value) { }

	// RVA: 0x10DBF00 Offset: 0x10DA500 VA: 0x1810DBF00
	public void .ctor() { }

}

public class EventWrittenEventArgs : EventArgs // TypeDefIndex: 1609
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <EventId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Guid <RelatedActivityId>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ReadOnlyCollection<object> <Payload>k__BackingField; // 0x28
	private string m_message; // 0x30
	private string m_eventName; // 0x38
	private EventSource m_eventSource; // 0x40
	private ReadOnlyCollection<string> m_payloadNames; // 0x48

	// Properties
	internal string EventName { set; }
	internal int EventId { set; }
	internal Guid RelatedActivityId { set; }
	internal ReadOnlyCollection<object> Payload { set; }
	internal ReadOnlyCollection<string> PayloadNames { set; }
	internal string Message { set; }

	// Methods

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_EventName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	internal void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10DC2E0 Offset: 0x10DA8E0 VA: 0x1810DC2E0
	internal void set_RelatedActivityId(Guid value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_Payload(ReadOnlyCollection<object> value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_PayloadNames(ReadOnlyCollection<string> value) { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Message(string value) { }

	// RVA: 0x10DC270 Offset: 0x10DA870 VA: 0x1810DC270
	internal void .ctor(EventSource eventSource) { }

}

public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1610
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Guid>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <LocalizationResources>k__BackingField; // 0x20

	// Properties
	public string Name { get; set; }
	public string Guid { get; set; }
	public string LocalizationResources { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Guid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Guid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_LocalizationResources() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public sealed class EventAttribute : Attribute // TypeDefIndex: 1611
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <EventId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventTask <Task>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Version>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Message>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventTags <Tags>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventActivityOptions <ActivityOptions>k__BackingField; // 0x34
	private EventOpcode m_opcode; // 0x38
	private bool m_opcodeSet; // 0x3C

	// Properties
	public int EventId { get; set; }
	public EventLevel Level { get; set; }
	public EventKeywords Keywords { get; }
	public EventOpcode Opcode { get; set; }
	internal bool IsOpcodeSet { get; }
	public EventTask Task { get; set; }
	public byte Version { get; }
	public string Message { get; set; }
	public EventTags Tags { get; }
	public EventActivityOptions ActivityOptions { get; set; }

	// Methods

	// RVA: 0xD73FA0 Offset: 0xD725A0 VA: 0x180D73FA0
	public void .ctor(int eventId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_EventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public EventLevel get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	public void set_Level(EventLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventKeywords get_Keywords() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public EventOpcode get_Opcode() { }

	// RVA: 0xD73FE0 Offset: 0xD725E0 VA: 0x180D73FE0
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0xC65CA0 Offset: 0xC642A0 VA: 0x180C65CA0
	internal bool get_IsOpcodeSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public EventTask get_Task() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	public void set_Task(EventTask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747A0 Offset: 0x772DA0 VA: 0x1807747A0
	public byte get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public EventTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_ActivityOptions(EventActivityOptions value) { }

}

public enum EventCommand // TypeDefIndex: 1613
{	// Fields
	public int value__; // 0x0
	public const EventCommand Update = 0;
	public const EventCommand SendManifest = -1;
	public const EventCommand Enable = -2;
	public const EventCommand Disable = -3;

}

internal class EventDispatcher // TypeDefIndex: 1622
{	// Fields
	internal readonly EventListener m_Listener; // 0x10
	internal bool[] m_EventEnabled; // 0x18
	internal bool m_activityFilteringEnabled; // 0x20
	internal EventDispatcher m_Next; // 0x28

	// Methods

	// RVA: 0xD743A0 Offset: 0xD729A0 VA: 0x180D743A0
	internal void .ctor(EventDispatcher next, bool[] eventEnabled, EventListener listener) { }

}

public enum EventManifestOptions // TypeDefIndex: 1623
{	// Fields
	public int value__; // 0x0
	public const EventManifestOptions None = 0;
	public const EventManifestOptions Strict = 1;
	public const EventManifestOptions AllCultures = 2;
	public const EventManifestOptions OnlyIfNeededForRegistration = 4;
	public const EventManifestOptions AllowEventSourceOverride = 8;

}

public class EventSourceException : Exception // TypeDefIndex: 1629
{	// Methods

	// RVA: 0x10DC120 Offset: 0x10DA720 VA: 0x1810DC120
	public void .ctor() { }

	// RVA: 0x10DC080 Offset: 0x10DA680 VA: 0x1810DC080
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10DC000 Offset: 0x10DA600 VA: 0x1810DC000
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10DBF60 Offset: 0x10DA560 VA: 0x1810DBF60
	internal void .ctor(Exception innerException) { }

}

public enum EventLevel // TypeDefIndex: 1630
{	// Fields
	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;

}

public enum EventTask // TypeDefIndex: 1631
{	// Fields
	public int value__; // 0x0
	public const EventTask None = 0;

}

public enum EventOpcode // TypeDefIndex: 1632
{	// Fields
	public int value__; // 0x0
	public const EventOpcode Info = 0;
	public const EventOpcode Start = 1;
	public const EventOpcode Stop = 2;
	public const EventOpcode DataCollectionStart = 3;
	public const EventOpcode DataCollectionStop = 4;
	public const EventOpcode Extension = 5;
	public const EventOpcode Reply = 6;
	public const EventOpcode Resume = 7;
	public const EventOpcode Suspend = 8;
	public const EventOpcode Send = 9;
	public const EventOpcode Receive = 240;

}

public enum EventChannel // TypeDefIndex: 1633
{	// Fields
	public byte value__; // 0x0
	public const EventChannel None = 0;
	public const EventChannel Admin = 16;
	public const EventChannel Operational = 17;
	public const EventChannel Analytic = 18;
	public const EventChannel Debug = 19;

}

public enum EventKeywords // TypeDefIndex: 1634
{	// Fields
	public long value__; // 0x0
	public const EventKeywords None = 0;
	public const EventKeywords All = -1;
	public const EventKeywords MicrosoftTelemetry = 562949953421312;
	public const EventKeywords WdiContext = 562949953421312;
	public const EventKeywords WdiDiagnostic = 1125899906842624;
	public const EventKeywords Sqm = 2251799813685248;
	public const EventKeywords AuditFailure = 4503599627370496;
	public const EventKeywords AuditSuccess = 9007199254740992;
	public const EventKeywords CorrelationHint = 4503599627370496;
	public const EventKeywords EventLogClassic = 36028797018963968;

}

public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 2703
{
// Namespace: System.ComponentModel
[DefaultMemberAttribute] // RVA: 0xA9760 Offset: 0xA8B60 VA: 0x1800A9760
[ComVisibleAttribute] // RVA: 0xA9760 Offset: 0xA8B60 VA: 0x1800A9760
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 2703
	// Fields
	private EventDescriptor[] events; // 0x10
	private string[] namedSort; // 0x18
	private IComparer comparer; // 0x20
	private bool eventsOwned; // 0x28
	private bool needSort; // 0x29
	private int eventCount; // 0x2C
	private bool readOnly; // 0x30
	public static readonly EventDescriptorCollection Empty; // 0x0

	// Properties
	public int Count { get; }
	public virtual EventDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x15C54D0 Offset: 0x15C3AD0 VA: 0x1815C54D0
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x15C5570 Offset: 0x15C3B70 VA: 0x1815C5570
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_Count() { }

	// RVA: 0x15C5620 Offset: 0x15C3C20 VA: 0x1815C5620 Slot: 19
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x15C3F60 Offset: 0x15C2560 VA: 0x1815C3F60
	public int Add(EventDescriptor value) { }

	// RVA: 0x15C4060 Offset: 0x15C2660 VA: 0x1815C4060
	public void Clear() { }

	// RVA: 0x15C40C0 Offset: 0x15C26C0 VA: 0x1815C40C0
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x15C4B50 Offset: 0x15C3150 VA: 0x1815C4B50 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15C4120 Offset: 0x15C2720 VA: 0x1815C4120
	private void EnsureEventsOwned() { }

	// RVA: 0x15C41D0 Offset: 0x15C27D0 VA: 0x1815C41D0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15C43A0 Offset: 0x15C29A0 VA: 0x1815C43A0
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x15C4400 Offset: 0x15C2A00 VA: 0x1815C4400
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x15C4A90 Offset: 0x15C3090 VA: 0x1815C4A90
	public void Remove(EventDescriptor value) { }

	// RVA: 0x15C49B0 Offset: 0x15C2FB0 VA: 0x1815C49B0
	public void RemoveAt(int index) { }

	// RVA: 0x15C42F0 Offset: 0x15C28F0 VA: 0x1815C42F0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15C45A0 Offset: 0x15C2BA0 VA: 0x1815C45A0
	protected void InternalSort(string[] names) { }

	// RVA: 0x15C4520 Offset: 0x15C2B20 VA: 0x1815C4520
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15C4BA0 Offset: 0x15C31A0 VA: 0x1815C4BA0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15C5230 Offset: 0x15C3830 VA: 0x1815C5230 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15C5250 Offset: 0x15C3850 VA: 0x1815C5250 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15C4C50 Offset: 0x15C3250 VA: 0x1815C4C50 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15C4060 Offset: 0x15C2660 VA: 0x1815C4060 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15C4DC0 Offset: 0x15C33C0 VA: 0x1815C4DC0 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15C4E90 Offset: 0x15C3490 VA: 0x1815C4E90 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15C4F60 Offset: 0x15C3560 VA: 0x1815C4F60 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15C5100 Offset: 0x15C3700 VA: 0x1815C5100 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15C50F0 Offset: 0x15C36F0 VA: 0x1815C50F0 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15C5410 Offset: 0x15C3A10 VA: 0x1815C5410
	private static void .cctor() { }

}

public sealed class EventHandlerList : IDisposable // TypeDefIndex: 2704
{	// Fields
	private EventHandlerList.ListEntry head; // 0x10
	private Component parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x10B5B00 Offset: 0x10B4100 VA: 0x1810B5B00
	internal void .ctor(Component parent) { }

	// RVA: 0x15C5830 Offset: 0x15C3E30 VA: 0x1815C5830
	public Delegate get_Item(object key) { }

	// RVA: 0x15C56C0 Offset: 0x15C3CC0 VA: 0x1815C56C0
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0xE36F60 Offset: 0xE35560 VA: 0x180E36F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x15C57B0 Offset: 0x15C3DB0 VA: 0x1815C57B0
	private EventHandlerList.ListEntry Find(object key) { }

	// RVA: 0x15C57D0 Offset: 0x15C3DD0 VA: 0x1815C57D0
	public void RemoveHandler(object key, Delegate value) { }

}

private sealed class EventHandlerList.ListEntry // TypeDefIndex: 2705
{	// Fields
	internal EventHandlerList.ListEntry next; // 0x10
	internal object key; // 0x18
	internal Delegate handler; // 0x20

	// Methods

	// RVA: 0x15C9680 Offset: 0x15C7C80 VA: 0x1815C9680
	public void .ctor(object key, Delegate handler, EventHandlerList.ListEntry next) { }

}

public sealed class Event // TypeDefIndex: 4025
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xC5C50 Offset: 0xC5050 VA: 0x1800C5C50
[StaticAccessorAttribute] // RVA: 0xC5C50 Offset: 0xC5050 VA: 0x1800C5C50
public sealed class Event // TypeDefIndex: 4025
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0xC6B40 Offset: 0xC5F40 VA: 0x1800C6B40
	public EventType rawType { get; }
	[NativePropertyAttribute] // RVA: 0xC6C00 Offset: 0xC6000 VA: 0x1800C6C00
	public Vector2 mousePosition { get; set; }
	[NativePropertyAttribute] // RVA: 0xC6D40 Offset: 0xC6140 VA: 0x1800C6D40
	public Vector2 delta { get; }
	[NativePropertyAttribute] // RVA: 0xC6DB0 Offset: 0xC61B0 VA: 0x1800C6DB0
	public PointerType pointerType { get; }
	[NativePropertyAttribute] // RVA: 0xC6E60 Offset: 0xC6260 VA: 0x1800C6E60
	public int button { get; }
	[NativePropertyAttribute] // RVA: 0xC6EF0 Offset: 0xC62F0 VA: 0x1800C6EF0
	public EventModifiers modifiers { get; set; }
	[NativePropertyAttribute] // RVA: 0xC6F90 Offset: 0xC6390 VA: 0x1800C6F90
	public float pressure { get; }
	[NativePropertyAttribute] // RVA: 0xC70B0 Offset: 0xC64B0 VA: 0x1800C70B0
	public int clickCount { get; }
	[NativePropertyAttribute] // RVA: 0xC7450 Offset: 0xC6850 VA: 0x1800C7450
	public char character { get; set; }
	[NativePropertyAttribute] // RVA: 0xC8830 Offset: 0xC7C30 VA: 0x1800C8830
	public KeyCode keyCode { get; set; }
	[NativePropertyAttribute] // RVA: 0xC8950 Offset: 0xC7D50 VA: 0x1800C8950
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x1A6B710 Offset: 0x1A69D10 VA: 0x181A6B710
	public EventType get_rawType() { }

	// RVA: 0x1A6B640 Offset: 0x1A69C40 VA: 0x181A6B640
	public Vector2 get_mousePosition() { }

	// RVA: 0x1A6BA20 Offset: 0x1A6A020 VA: 0x181A6BA20
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x1A6B3C0 Offset: 0x1A699C0 VA: 0x181A6B3C0
	public Vector2 get_delta() { }

	// RVA: 0x1A6B690 Offset: 0x1A69C90 VA: 0x181A6B690
	public PointerType get_pointerType() { }

	// RVA: 0x1A6B1B0 Offset: 0x1A697B0 VA: 0x181A6B1B0
	public int get_button() { }

	// RVA: 0x1A6B5B0 Offset: 0x1A69BB0 VA: 0x181A6B5B0
	public EventModifiers get_modifiers() { }

	// RVA: 0x1A6B990 Offset: 0x1A69F90 VA: 0x181A6B990
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1A6B6D0 Offset: 0x1A69CD0 VA: 0x181A6B6D0
	public float get_pressure() { }

	// RVA: 0x1A6B230 Offset: 0x1A69830 VA: 0x181A6B230
	public int get_clickCount() { }

	// RVA: 0x1A6B1F0 Offset: 0x1A697F0 VA: 0x181A6B1F0
	public char get_character() { }

	// RVA: 0x1A6B7D0 Offset: 0x1A69DD0 VA: 0x181A6B7D0
	public void set_character(char value) { }

	// RVA: 0x1A6B570 Offset: 0x1A69B70 VA: 0x181A6B570
	public KeyCode get_keyCode() { }

	// RVA: 0x1A6B950 Offset: 0x1A69F50 VA: 0x181A6B950
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x1A6B410 Offset: 0x1A69A10 VA: 0x181A6B410
	public int get_displayIndex() { }

	// RVA: 0x1A6B910 Offset: 0x1A69F10 VA: 0x181A6B910
	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] // RVA: 0xC5DD0 Offset: 0xC51D0 VA: 0x1800C5DD0
	// RVA: 0x1A6B790 Offset: 0x1A69D90 VA: 0x181A6B790
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0xC5EB0 Offset: 0xC52B0 VA: 0x1800C5EB0
	// RVA: 0x1A6BA60 Offset: 0x1A6A060 VA: 0x181A6BA60
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] // RVA: 0xC6040 Offset: 0xC5440 VA: 0x1800C6040
	// RVA: 0x1A6B270 Offset: 0x1A69870 VA: 0x181A6B270
	public string get_commandName() { }

	[FreeFunctionAttribute] // RVA: 0xC6100 Offset: 0xC5500 VA: 0x1800C6100
	// RVA: 0x1A6B820 Offset: 0x1A69E20 VA: 0x181A6B820
	public void set_commandName(string value) { }

	[NativeMethodAttribute] // RVA: 0xC61B0 Offset: 0xC55B0 VA: 0x1800C61B0
	// RVA: 0x1A69090 Offset: 0x1A67690 VA: 0x181A69090
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0xC6270 Offset: 0xC5670 VA: 0x1800C6270
	// RVA: 0x1A68E90 Offset: 0x1A67490 VA: 0x181A68E90
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0xC6300 Offset: 0xC5700 VA: 0x1800C6300
	// RVA: 0x1A68ED0 Offset: 0x1A674D0 VA: 0x181A68ED0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xC6340 Offset: 0xC5740 VA: 0x1800C6340
	// RVA: 0x1A68E50 Offset: 0x1A67450 VA: 0x181A68E50
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunctionAttribute] // RVA: 0xC63D0 Offset: 0xC57D0 VA: 0x1800C63D0
	// RVA: 0x1A68E10 Offset: 0x1A67410 VA: 0x181A68E10
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] // RVA: 0xC6440 Offset: 0xC5840 VA: 0x1800C6440
	[VisibleToOtherModulesAttribute] // RVA: 0xC6440 Offset: 0xC5840 VA: 0x1800C6440
	// RVA: 0x1A688F0 Offset: 0x1A66EF0 VA: 0x181A688F0
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1A6A360 Offset: 0x1A68960 VA: 0x181A6A360
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1A69050 Offset: 0x1A67650 VA: 0x181A69050
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A68F10 Offset: 0x1A67510 VA: 0x181A68F10
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1A6B0E0 Offset: 0x1A696E0 VA: 0x181A6B0E0
	public void .ctor() { }

	// RVA: 0x1A6B120 Offset: 0x1A69720 VA: 0x181A6B120
	public void .ctor(int displayIndex) { }

	// RVA: 0x1A6B030 Offset: 0x1A69630 VA: 0x181A6B030
	public void .ctor(Event other) { }

	// RVA: 0x1A68C00 Offset: 0x1A67200 VA: 0x181A68C00 Slot: 1
	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC66A0 Offset: 0xC5AA0 VA: 0x1800C66A0
	// RVA: 0x1A68940 Offset: 0x1A66F40 VA: 0x181A68940
	internal void CopyFrom(Event e) { }

	// RVA: 0x1A6B750 Offset: 0x1A69D50 VA: 0x181A6B750
	public bool get_shift() { }

	// RVA: 0x1A6B2F0 Offset: 0x1A698F0 VA: 0x181A6B2F0
	public bool get_control() { }

	// RVA: 0x1A6B170 Offset: 0x1A69770 VA: 0x181A6B170
	public bool get_alt() { }

	// RVA: 0x1A6B2B0 Offset: 0x1A698B0 VA: 0x181A6B2B0
	public bool get_command() { }

	// RVA: 0x1A6B330 Offset: 0x1A69930 VA: 0x181A6B330
	public static Event get_current() { }

	// RVA: 0x1A6B870 Offset: 0x1A69E70 VA: 0x181A6B870
	public static void set_current(Event value) { }

	// RVA: 0x1A6B4C0 Offset: 0x1A69AC0 VA: 0x181A6B4C0
	public bool get_isKey() { }

	// RVA: 0x1A6B510 Offset: 0x1A69B10 VA: 0x181A6B510
	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC69B0 Offset: 0xC5DB0 VA: 0x1800C69B0
	// RVA: 0x1A6B450 Offset: 0x1A69A50 VA: 0x181A6B450
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x1A690D0 Offset: 0x1A676D0 VA: 0x181A690D0
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x1A68CE0 Offset: 0x1A672E0 VA: 0x181A68CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A689B0 Offset: 0x1A66FB0 VA: 0x181A689B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A6A3A0 Offset: 0x1A689A0 VA: 0x181A6A3A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6AE80 Offset: 0x1A69480 VA: 0x181A6AE80
	public void Use() { }

	// RVA: 0x1A6B5F0 Offset: 0x1A69BF0 VA: 0x181A6B5F0
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x1A6B9D0 Offset: 0x1A69FD0 VA: 0x181A6B9D0
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x1A6B370 Offset: 0x1A69970 VA: 0x181A6B370
	private void get_delta_Injected(out Vector2 ret) { }

}

public enum EventType // TypeDefIndex: 4026
{	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	[ObsoleteAttribute] // RVA: 0xC8A30 Offset: 0xC7E30 VA: 0x1800C8A30
	[EditorBrowsableAttribute] // RVA: 0xC8A30 Offset: 0xC7E30 VA: 0x1800C8A30
	public const EventType mouseDown = 0;
	[EditorBrowsableAttribute] // RVA: 0xC8B80 Offset: 0xC7F80 VA: 0x1800C8B80
	[ObsoleteAttribute] // RVA: 0xC8B80 Offset: 0xC7F80 VA: 0x1800C8B80
	public const EventType mouseUp = 1;
	[ObsoleteAttribute] // RVA: 0xC8D10 Offset: 0xC8110 VA: 0x1800C8D10
	[EditorBrowsableAttribute] // RVA: 0xC8D10 Offset: 0xC8110 VA: 0x1800C8D10
	public const EventType mouseMove = 2;
	[ObsoleteAttribute] // RVA: 0xC8F20 Offset: 0xC8320 VA: 0x1800C8F20
	[EditorBrowsableAttribute] // RVA: 0xC8F20 Offset: 0xC8320 VA: 0x1800C8F20
	public const EventType mouseDrag = 3;
	[ObsoleteAttribute] // RVA: 0xC90A0 Offset: 0xC84A0 VA: 0x1800C90A0
	[EditorBrowsableAttribute] // RVA: 0xC90A0 Offset: 0xC84A0 VA: 0x1800C90A0
	public const EventType keyDown = 4;
	[EditorBrowsableAttribute] // RVA: 0xC9190 Offset: 0xC8590 VA: 0x1800C9190
	[ObsoleteAttribute] // RVA: 0xC9190 Offset: 0xC8590 VA: 0x1800C9190
	public const EventType keyUp = 5;
	[EditorBrowsableAttribute] // RVA: 0xC9590 Offset: 0xC8990 VA: 0x1800C9590
	[ObsoleteAttribute] // RVA: 0xC9590 Offset: 0xC8990 VA: 0x1800C9590
	public const EventType scrollWheel = 6;
	[ObsoleteAttribute] // RVA: 0xC97B0 Offset: 0xC8BB0 VA: 0x1800C97B0
	[EditorBrowsableAttribute] // RVA: 0xC97B0 Offset: 0xC8BB0 VA: 0x1800C97B0
	public const EventType repaint = 7;
	[EditorBrowsableAttribute] // RVA: 0xC98A0 Offset: 0xC8CA0 VA: 0x1800C98A0
	[ObsoleteAttribute] // RVA: 0xC98A0 Offset: 0xC8CA0 VA: 0x1800C98A0
	public const EventType layout = 8;
	[EditorBrowsableAttribute] // RVA: 0xC99C0 Offset: 0xC8DC0 VA: 0x1800C99C0
	[ObsoleteAttribute] // RVA: 0xC99C0 Offset: 0xC8DC0 VA: 0x1800C99C0
	public const EventType dragUpdated = 9;
	[ObsoleteAttribute] // RVA: 0xC9B10 Offset: 0xC8F10 VA: 0x1800C9B10
	[EditorBrowsableAttribute] // RVA: 0xC9B10 Offset: 0xC8F10 VA: 0x1800C9B10
	public const EventType dragPerform = 10;
	[ObsoleteAttribute] // RVA: 0xC9CE0 Offset: 0xC90E0 VA: 0x1800C9CE0
	[EditorBrowsableAttribute] // RVA: 0xC9CE0 Offset: 0xC90E0 VA: 0x1800C9CE0
	public const EventType ignore = 11;
	[EditorBrowsableAttribute] // RVA: 0xC9E40 Offset: 0xC9240 VA: 0x1800C9E40
	[ObsoleteAttribute] // RVA: 0xC9E40 Offset: 0xC9240 VA: 0x1800C9E40
	public const EventType used = 12;

}

public enum EventModifiers // TypeDefIndex: 4027
{	// Fields
	public int value__; // 0x0
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;

}

internal struct EventInterests // TypeDefIndex: 4029
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1

	// Properties
	public bool wantsMouseMove { get; }
	public bool wantsMouseEnterLeaveWindow { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1FA1A0 Offset: 0x1F95A0 VA: 0x1801FA1A0
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x22ACD0 Offset: 0x22A0D0 VA: 0x18022ACD0
	public bool WantsEvent(EventType type) { }

}

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 4582
{	// Fields
	private readonly EventDispatcher m_Dispatcher; // 0x0

	// Methods

	// RVA: 0x139F00 Offset: 0x139300 VA: 0x180139F00
	public void .ctor(EventDispatcher d) { }

	// RVA: 0x139E20 Offset: 0x139220 VA: 0x180139E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x139E30 Offset: 0x139230 VA: 0x180139E30 Slot: 5
	public bool Equals(EventDispatcherGate other) { }

	// RVA: 0x139E40 Offset: 0x139240 VA: 0x180139E40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139ED0 Offset: 0x1392D0 VA: 0x180139ED0 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EventDispatcher // TypeDefIndex: 4583
{	// Fields
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x10
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private Queue<EventDispatcher.EventRecord> m_Queue; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x20
	private uint m_GateCount; // 0x28
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; // 0x30
	private bool m_Immediate; // 0x38

	// Properties
	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0xEAEB70 Offset: 0xEAD170 VA: 0x180EAEB70
	internal void .ctor() { }

	// RVA: 0xEAEE60 Offset: 0xEAD460 VA: 0x180EAEE60
	private bool get_dispatchImmediately() { }

	// RVA: 0xEAE210 Offset: 0xEAC810 VA: 0x180EAE210
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0xEAE200 Offset: 0xEAC800 VA: 0x180EAE200
	internal void CloseGate() { }

	// RVA: 0xEAE3E0 Offset: 0xEAC9E0 VA: 0x180EAE3E0
	internal void OpenGate() { }

	// RVA: 0xEAE460 Offset: 0xEACA60 VA: 0x180EAE460
	private void ProcessEventQueue() { }

	// RVA: 0xEAE720 Offset: 0xEACD20 VA: 0x180EAE720
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xEADF90 Offset: 0xEAC590 VA: 0x180EADF90
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0xEAEB00 Offset: 0xEAD100 VA: 0x180EAEB00
	private static void .cctor() { }

}

private struct EventDispatcher.EventRecord // TypeDefIndex: 4584
{	// Fields
	public EventBase m_Event; // 0x0
	public IPanel m_Panel; // 0x8

}

private struct EventDispatcher.DispatchContext // TypeDefIndex: 4585
{	// Fields
	public uint m_GateCount; // 0x0
	public Queue<EventDispatcher.EventRecord> m_Queue; // 0x8

}

public abstract class EventBase : IDisposable // TypeDefIndex: 4640
{	// Fields
	private static long s_LastTypeId; // 0x0
	private static ulong s_NextEventId; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private long <timestamp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ulong <eventId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ulong <triggerEventId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private EventBase.EventPropagation <propagation>k__BackingField; // 0x28
	private PropagationPaths m_Path; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private IEventHandler <leafTarget>k__BackingField; // 0x40
	private IEventHandler m_Target; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly List<IEventHandler> <skipElements>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private PropagationPhase <propagationPhase>k__BackingField; // 0x58
	private IEventHandler m_CurrentTarget; // 0x60
	private Event m_ImguiEvent; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Vector2 <originalMousePosition>k__BackingField; // 0x70

	// Properties
	public virtual long eventTypeId { get; }
	private long timestamp { set; }
	internal ulong eventId { get; set; }
	private ulong triggerEventId { set; }
	internal EventBase.EventPropagation propagation { get; set; }
	internal PropagationPaths path { get; set; }
	private EventBase.LifeCycleStatus lifeCycleStatus { get; set; }
	public bool bubbles { get; }
	public bool tricklesDown { get; }
	internal IEventHandler leafTarget { get; set; }
	public IEventHandler target { get; set; }
	internal List<IEventHandler> skipElements { get; }
	public bool isPropagationStopped { get; set; }
	public bool isImmediatePropagationStopped { get; set; }
	public bool isDefaultPrevented { get; set; }
	public PropagationPhase propagationPhase { get; set; }
	public virtual IEventHandler currentTarget { get; set; }
	public bool dispatch { get; set; }
	private bool dispatched { get; set; }
	internal bool processed { get; set; }
	internal bool stopDispatch { get; set; }
	internal bool propagateToIMGUI { get; set; }
	private bool imguiEventIsValid { get; set; }
	public Event imguiEvent { get; set; }
	public Vector2 originalMousePosition { get; set; }
	protected bool pooled { get; set; }

	// Methods

	// RVA: 0xEAC0E0 Offset: 0xEAA6E0 VA: 0x180EAC0E0
	protected static long RegisterEventType() { }

	// RVA: 0xEAC2E0 Offset: 0xEAA8E0 VA: 0x180EAC2E0 Slot: 5
	public virtual long get_eventTypeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFD0 Offset: 0x4995D0 VA: 0x18049AFD0
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE74290 Offset: 0xE72890 VA: 0x180E74290
	private void set_triggerEventId(ulong value) { }

	// RVA: 0xE74290 Offset: 0xE72890 VA: 0x180E74290
	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	internal void set_propagation(EventBase.EventPropagation value) { }

	// RVA: 0xEAC360 Offset: 0xEAA960 VA: 0x180EAC360
	internal PropagationPaths get_path() { }

	// RVA: 0xEAC790 Offset: 0xEAAD90 VA: 0x180EAC790
	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] // RVA: 0x95D30 Offset: 0x95130 VA: 0x180095D30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void PreDispatch() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 7
	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] // RVA: 0x95E70 Offset: 0x95270 VA: 0x180095E70
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void PostDispatch() { }

	// RVA: 0xEAC0A0 Offset: 0xEAA6A0 VA: 0x180EAC0A0 Slot: 9
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0xEAC2A0 Offset: 0xEAA8A0 VA: 0x180EAC2A0
	public bool get_bubbles() { }

	// RVA: 0xEAC4A0 Offset: 0xEAAAA0 VA: 0x180EAC4A0
	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0xEAC490 Offset: 0xEAAA90 VA: 0x180EAC490
	public IEventHandler get_target() { }

	// RVA: 0xEAC950 Offset: 0xEAAF50 VA: 0x180EAC950
	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal List<IEventHandler> get_skipElements() { }

	// RVA: 0xEAC140 Offset: 0xEAA740 VA: 0x180EAC140
	internal bool Skip(IEventHandler h) { }

	// RVA: 0xEAC330 Offset: 0xEAA930 VA: 0x180EAC330
	public bool get_isPropagationStopped() { }

	// RVA: 0xEAC760 Offset: 0xEAAD60 VA: 0x180EAC760
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0xEAC1B0 Offset: 0xEAA7B0 VA: 0x180EAC1B0
	public void StopPropagation() { }

	// RVA: 0xEAC320 Offset: 0xEAA920 VA: 0x180EAC320
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0xEAC740 Offset: 0xEAAD40 VA: 0x180EAC740
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0xEAC1A0 Offset: 0xEAA7A0 VA: 0x180EAC1A0
	public void StopImmediatePropagation() { }

	// RVA: 0xEAC310 Offset: 0xEAA910 VA: 0x180EAC310
	public bool get_isDefaultPrevented() { }

	// RVA: 0xEAC720 Offset: 0xEAAD20 VA: 0x180EAC720
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0xEAC0D0 Offset: 0xEAA6D0 VA: 0x180EAC0D0
	public void PreventDefault() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27C30 Offset: 0xD26230 VA: 0x180D27C30
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0xEAC2B0 Offset: 0xEAA8B0 VA: 0x180EAC2B0 Slot: 10
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0xEAC4B0 Offset: 0xEAAAB0 VA: 0x180EAC4B0 Slot: 11
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0xEAC2C0 Offset: 0xEAA8C0 VA: 0x180EAC2C0
	public bool get_dispatch() { }

	// RVA: 0xEAC5E0 Offset: 0xEAABE0 VA: 0x180EAC5E0
	internal void set_dispatch(bool value) { }

	// RVA: 0xEAC020 Offset: 0xEAA620 VA: 0x180EAC020
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0xEAC2D0 Offset: 0xEAA8D0 VA: 0x180EAC2D0
	private bool get_dispatched() { }

	// RVA: 0xEAC600 Offset: 0xEAAC00 VA: 0x180EAC600
	private void set_dispatched(bool value) { }

	// RVA: 0xEAC460 Offset: 0xEAAA60 VA: 0x180EAC460
	internal bool get_processed() { }

	// RVA: 0xEAC8F0 Offset: 0xEAAEF0 VA: 0x180EAC8F0
	private void set_processed(bool value) { }

	// RVA: 0xEAC480 Offset: 0xEAAA80 VA: 0x180EAC480
	internal bool get_stopDispatch() { }

	// RVA: 0xEAC930 Offset: 0xEAAF30 VA: 0x180EAC930
	internal void set_stopDispatch(bool value) { }

	// RVA: 0xEAC470 Offset: 0xEAAA70 VA: 0x180EAC470
	internal bool get_propagateToIMGUI() { }

	// RVA: 0xEAC910 Offset: 0xEAAF10 VA: 0x180EAC910
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0xEAC2F0 Offset: 0xEAA8F0 VA: 0x180EAC2F0
	private bool get_imguiEventIsValid() { }

	// RVA: 0xEAC620 Offset: 0xEAAC20 VA: 0x180EAC620
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0xEAC300 Offset: 0xEAA900 VA: 0x180EAC300
	public Event get_imguiEvent() { }

	// RVA: 0xEAC640 Offset: 0xEAAC40 VA: 0x180EAC640
	protected void set_imguiEvent(Event value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEAC340 Offset: 0xEAA940 VA: 0x180EAC340
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEAC780 Offset: 0xEAAD80 VA: 0x180EAC780
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0xEABDE0 Offset: 0xEAA3E0 VA: 0x180EABDE0 Slot: 12
	protected virtual void Init() { }

	// RVA: 0xEABDF0 Offset: 0xEAA3F0 VA: 0x180EABDF0
	private void LocalInit() { }

	// RVA: 0xEAC210 Offset: 0xEAA810 VA: 0x180EAC210
	protected void .ctor() { }

	// RVA: 0xEAC450 Offset: 0xEAAA50 VA: 0x180EAC450
	protected bool get_pooled() { }

	// RVA: 0xEAC8D0 Offset: 0xEAAED0 VA: 0x180EAC8D0
	protected void set_pooled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void Acquire();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose();

	// RVA: 0xEAC1C0 Offset: 0xEAA7C0 VA: 0x180EAC1C0
	private static void .cctor() { }

}

internal enum EventBase.EventPropagation // TypeDefIndex: 4641
{	// Fields
	public int value__; // 0x0
	public const EventBase.EventPropagation None = 0;
	public const EventBase.EventPropagation Bubbles = 1;
	public const EventBase.EventPropagation TricklesDown = 2;
	public const EventBase.EventPropagation Cancellable = 4;

}

private enum EventBase.LifeCycleStatus // TypeDefIndex: 4642
{	// Fields
	public int value__; // 0x0
	public const EventBase.LifeCycleStatus None = 0;
	public const EventBase.LifeCycleStatus PropagationStopped = 1;
	public const EventBase.LifeCycleStatus ImmediatePropagationStopped = 2;
	public const EventBase.LifeCycleStatus DefaultPrevented = 4;
	public const EventBase.LifeCycleStatus Dispatching = 8;
	public const EventBase.LifeCycleStatus Pooled = 16;
	public const EventBase.LifeCycleStatus IMGUIEventIsValid = 32;
	public const EventBase.LifeCycleStatus StopDispatch = 64;
	public const EventBase.LifeCycleStatus PropagateToIMGUI = 128;
	public const EventBase.LifeCycleStatus Dispatched = 512;
	public const EventBase.LifeCycleStatus Processed = 1024;

}

internal abstract class EventCallbackFunctorBase // TypeDefIndex: 4644
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private CallbackPhase <phase>k__BackingField; // 0x10

	// Properties
	public CallbackPhase phase { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public CallbackPhase get_phase() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(EventBase evt);

}

internal class EventCallbackListPool // TypeDefIndex: 4646
{	// Fields
	private readonly Stack<EventCallbackList> m_Stack; // 0x10

	// Methods

	// RVA: 0xEAC990 Offset: 0xEAAF90 VA: 0x180EAC990
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0xEACAF0 Offset: 0xEAB0F0 VA: 0x180EACAF0
	public void Release(EventCallbackList element) { }

	// RVA: 0xEACB80 Offset: 0xEAB180 VA: 0x180EACB80
	public void .ctor() { }

}

internal class EventCallbackList // TypeDefIndex: 4647
{	// Fields
	private List<EventCallbackFunctorBase> m_List; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Properties
	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0xEACD90 Offset: 0xEAB390 VA: 0x180EACD90
	public void .ctor() { }

	// RVA: 0xEACE00 Offset: 0xEAB400 VA: 0x180EACE00
	public void .ctor(EventCallbackList source) { }

	// RVA: 0xEACBF0 Offset: 0xEAB1F0 VA: 0x180EACBF0
	public void AddRange(EventCallbackList list) { }

	// RVA: 0xEACE90 Offset: 0xEAB490 VA: 0x180EACE90
	public int get_Count() { }

	// RVA: 0xEACED0 Offset: 0xEAB4D0 VA: 0x180EACED0
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0xEACD40 Offset: 0xEAB340 VA: 0x180EACD40
	public void Clear() { }

}

internal class EventCallbackRegistry // TypeDefIndex: 4648
{	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0xEACF30 Offset: 0xEAB530 VA: 0x180EACF30
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0xEAD2A0 Offset: 0xEAB8A0 VA: 0x180EAD2A0
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0xEAD130 Offset: 0xEAB730 VA: 0x180EAD130
	public void InvokeCallbacks(EventBase evt) { }

	// RVA: 0xEAD110 Offset: 0xEAB710 VA: 0x180EAD110
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEAD0F0 Offset: 0xEAB6F0 VA: 0x180EAD0F0
	public bool HasBubbleHandlers() { }

	// RVA: 0xEAD380 Offset: 0xEAB980 VA: 0x180EAD380
	private static void .cctor() { }

}

internal static class EventDispatchUtilities // TypeDefIndex: 4658
{	// Methods

	// RVA: 0xEAD540 Offset: 0xEABB40 VA: 0x180EAD540
	public static void PropagateEvent(EventBase evt) { }

	// RVA: 0xEADCA0 Offset: 0xEAC2A0 VA: 0x180EADCA0
	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0xEAD430 Offset: 0xEABA30 VA: 0x180EAD430
	public static void ExecuteDefaultAction(EventBase evt, IPanel panel) { }

}

internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 4703
{	// Methods

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void .ctor(EventBase evt) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0 Slot: 4
	public void Dispose() { }

}

internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 4704
{	// Methods

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void .ctor(EventBase evt) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0 Slot: 4
	public void Dispose() { }

}

internal class EventDebugger // TypeDefIndex: 4705
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

public enum EventHandle // TypeDefIndex: 5052
{	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;

}

public class EventSystem : UIBehaviour // TypeDefIndex: 5071
{	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x18
	private BaseInputModule m_CurrentInputModule; // 0x20
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField] // RVA: 0x85E30 Offset: 0x85230 VA: 0x180085E30
	[FormerlySerializedAsAttribute] // RVA: 0x85E30 Offset: 0x85230 VA: 0x180085E30
	private GameObject m_FirstSelected; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_sendNavigationEvents; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_DragThreshold; // 0x34
	private GameObject m_CurrentSelected; // 0x38
	private bool m_HasFocus; // 0x40
	private bool m_SelectionGuard; // 0x41
	private BaseEventData m_DummyData; // 0x48
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[ObsoleteAttribute] // RVA: 0x86090 Offset: 0x85490 VA: 0x180086090
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }

	// Methods

	// RVA: 0x10C4590 Offset: 0x10C2B90 VA: 0x1810C4590
	public static EventSystem get_current() { }

	// RVA: 0x10C4650 Offset: 0x10C2C50 VA: 0x1810C4650
	public static void set_current(EventSystem value) { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_sendNavigationEvents() { }

	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_pixelDragThreshold() { }

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_isFocused() { }

	// RVA: 0x10C4480 Offset: 0x10C2A80 VA: 0x1810C4480
	protected void .ctor() { }

	// RVA: 0x10C3E50 Offset: 0x10C2450 VA: 0x1810C3E50
	public void UpdateModules() { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150
	public bool get_alreadySelecting() { }

	// RVA: 0x10C3990 Offset: 0x10C1F90 VA: 0x1810C3990
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x10C4500 Offset: 0x10C2B00 VA: 0x1810C4500
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x10C3B90 Offset: 0x10C2190 VA: 0x1810C3B90
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x10C34E0 Offset: 0x10C1AE0 VA: 0x1810C34E0
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x10C3300 Offset: 0x10C1900 VA: 0x1810C3300
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x10C30F0 Offset: 0x10C16F0 VA: 0x1810C30F0
	public bool IsPointerOverGameObject() { }

	// RVA: 0x10C3040 Offset: 0x10C1640 VA: 0x1810C3040
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C3280 Offset: 0x10C1880 VA: 0x1810C3280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10C3190 Offset: 0x10C1790 VA: 0x1810C3190 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10C3C30 Offset: 0x10C2230 VA: 0x1810C3C30
	private void TickModules() { }

	// RVA: 0x810000 Offset: 0x80E600 VA: 0x180810000 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x10C3F80 Offset: 0x10C2580 VA: 0x1810C3F80 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x10C2F10 Offset: 0x10C1510 VA: 0x1810C2F10
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x10C3D40 Offset: 0x10C2340 VA: 0x1810C3D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C43D0 Offset: 0x10C29D0 VA: 0x1810C43D0
	private static void .cctor() { }

}

public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5072
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x862E0 Offset: 0x856E0 VA: 0x1800862E0
	[SerializeField] // RVA: 0x862E0 Offset: 0x856E0 VA: 0x1800862E0
	private List<EventTrigger.Entry> m_Delegates; // 0x18

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x86490 Offset: 0x85890 VA: 0x180086490
	[ObsoleteAttribute] // RVA: 0x86490 Offset: 0x85890 VA: 0x180086490
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x10C49F0 Offset: 0x10C2FF0 VA: 0x1810C49F0
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x10C49F0 Offset: 0x10C2FF0 VA: 0x1810C49F0
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x10C4750 Offset: 0x10C2D50 VA: 0x1810C4750
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x10C4980 Offset: 0x10C2F80 VA: 0x1810C4980 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x10C4990 Offset: 0x10C2F90 VA: 0x1810C4990 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x10C4910 Offset: 0x10C2F10 VA: 0x1810C4910 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x10C4920 Offset: 0x10C2F20 VA: 0x1810C4920 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x10C4970 Offset: 0x10C2F70 VA: 0x1810C4970 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x10C49A0 Offset: 0x10C2FA0 VA: 0x1810C49A0 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x10C4960 Offset: 0x10C2F60 VA: 0x1810C4960 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10C49C0 Offset: 0x10C2FC0 VA: 0x1810C49C0 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x10C4900 Offset: 0x10C2F00 VA: 0x1810C4900 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x10C49B0 Offset: 0x10C2FB0 VA: 0x1810C49B0 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x10C4950 Offset: 0x10C2F50 VA: 0x1810C4950 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x10C49E0 Offset: 0x10C2FE0 VA: 0x1810C49E0 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x10C4940 Offset: 0x10C2F40 VA: 0x1810C4940 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x10C48E0 Offset: 0x10C2EE0 VA: 0x1810C48E0 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x10C4930 Offset: 0x10C2F30 VA: 0x1810C4930 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x10C49D0 Offset: 0x10C2FD0 VA: 0x1810C49D0 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10C48F0 Offset: 0x10C2EF0 VA: 0x1810C48F0 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }

}

public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 5073
{	// Methods

	// RVA: 0x10CEEB0 Offset: 0x10CD4B0 VA: 0x1810CEEB0
	public void .ctor() { }

}

public class EventTrigger.Entry // TypeDefIndex: 5074
{	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x10C2E80 Offset: 0x10C1480 VA: 0x1810C2E80
	public void .ctor() { }

}

public enum EventTriggerType // TypeDefIndex: 5075
{	// Fields
	public int value__; // 0x0
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;

}

internal static class EventHandlerExtensions // TypeDefIndex: 7141
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void Raise<T>(EventHandler<T> eventHandler, object sender, T eventArgs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572C50 Offset: 0x1571250 VA: 0x181572C50
	|-EventHandlerExtensions.Raise<LoadCompletedEventArgs>
	|-EventHandlerExtensions.Raise<LoadProgressEventArgs>
	|-EventHandlerExtensions.Raise<StateChangedEventArgs>
	|-EventHandlerExtensions.Raise<object>
	*/

}

public sealed class EventsCollection : ICollection<MidiEvent>, IEnumerable<MidiEvent>, IEnumerable // TypeDefIndex: 7514
{	// Fields
	internal readonly List<MidiEvent> _events; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public MidiEvent Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x13987A0 Offset: 0x1396DA0 VA: 0x1813987A0
	internal void .ctor() { }

	// RVA: 0x1398850 Offset: 0x1396E50 VA: 0x181398850
	public MidiEvent get_Item(int index) { }

	// RVA: 0x1398810 Offset: 0x1396E10 VA: 0x181398810 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1398400 Offset: 0x1396A00 VA: 0x181398400 Slot: 6
	public void Add(MidiEvent midiEvent) { }

	// RVA: 0x1398660 Offset: 0x1396C60 VA: 0x181398660 Slot: 10
	public bool Remove(MidiEvent midiEvent) { }

	// RVA: 0x13984C0 Offset: 0x1396AC0 VA: 0x1813984C0 Slot: 7
	public void Clear() { }

	// RVA: 0x13985E0 Offset: 0x1396BE0 VA: 0x1813985E0 Slot: 11
	public IEnumerator<MidiEvent> GetEnumerator() { }

	// RVA: 0x1398720 Offset: 0x1396D20 VA: 0x181398720 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1398510 Offset: 0x1396B10 VA: 0x181398510 Slot: 8
	public bool Contains(MidiEvent item) { }

	// RVA: 0x1398570 Offset: 0x1396B70 VA: 0x181398570 Slot: 9
	public void CopyTo(MidiEvent[] array, int arrayIndex) { }

}

public sealed class EventTypesCollection // TypeDefIndex: 7530
{	// Fields
	private readonly Dictionary<byte, Type> _types; // 0x10

	// Methods

	// RVA: 0x1398390 Offset: 0x1396990 VA: 0x181398390
	public bool TryGetType(byte statusByte, out Type type) { }

}

internal static class EventReaderFactory // TypeDefIndex: 7553
{	// Fields
	private static readonly IEventReader MetaEventReader; // 0x0
	private static readonly IEventReader ChannelEventReader; // 0x8
	private static readonly IEventReader SysExEventReader; // 0x10
	private static readonly IEventReader SystemRealTimeEventReader; // 0x18
	private static readonly IEventReader SystemCommonEventReader; // 0x20

	// Methods

	// RVA: 0x13980C0 Offset: 0x13966C0 VA: 0x1813980C0
	internal static IEventReader GetReader(byte statusByte, bool smfOnly) { }

	// RVA: 0x1398260 Offset: 0x1396860 VA: 0x181398260
	private static void .cctor() { }

}

public class EventSchedule : BaseMonoBehaviour // TypeDefIndex: 9817
{	// Fields
	[TooltipAttribute] // RVA: 0x99C40 Offset: 0x99040 VA: 0x180099C40
	public float minimumHoursBetween; // 0x18
	[TooltipAttribute] // RVA: 0x99E30 Offset: 0x99230 VA: 0x180099E30
	public float maxmumHoursBetween; // 0x1C

	// Methods

	// RVA: 0x8CC330 Offset: 0x8CA930 VA: 0x1808CC330
	public void .ctor() { }

}

