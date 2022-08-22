public class EventArgs // TypeDefIndex: 215
{	// Fields
	public static readonly EventArgs Empty; // 0x13B0F

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10DC850 Offset: 0x10DAE50 VA: 0x1810DC850
	private static void .cctor() { }

}

public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 216
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
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
	|-RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50
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
	|-RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10
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

	// RVA: 0x18C85B0 Offset: 0x18C6BB0 VA: 0x1818C85B0 Slot: 17
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C5D80 Offset: 0x18C4380 VA: 0x1818C5D80
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C8630 Offset: 0x18C6C30 VA: 0x1818C8630
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18C84F0 Offset: 0x18C6AF0 VA: 0x1818C84F0
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

}

private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 566
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object _this, Delegate dele) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
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

	// RVA: 0x1492210 Offset: 0x1490810 VA: 0x181492210
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x1492230 Offset: 0x1490830 VA: 0x181492230
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x1492130 Offset: 0x1490730 VA: 0x181492130
	public bool Reset() { }

	// RVA: 0x14921A0 Offset: 0x14907A0 VA: 0x1814921A0
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
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
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

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(List<string> payloadNames, List<object> payloadValues) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public ICollection<string> get_Keys() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	public ICollection<object> get_Values() { }

	// RVA: 0xD75EB0 Offset: 0xD744B0 VA: 0x180D75EB0 Slot: 4
	public object get_Item(string key) { }

	// RVA: 0xD760A0 Offset: 0xD746A0 VA: 0x180D760A0 Slot: 5
	public void set_Item(string key, object value) { }

	// RVA: 0xD75860 Offset: 0xD73E60 VA: 0x180D75860 Slot: 9
	public void Add(string key, object value) { }

	// RVA: 0xD75810 Offset: 0xD73E10 VA: 0x180D75810 Slot: 14
	public void Add(KeyValuePair<string, object> payloadEntry) { }

	// RVA: 0xD758B0 Offset: 0xD73EB0 VA: 0x180D758B0 Slot: 15
	public void Clear() { }

	// RVA: 0xD75A90 Offset: 0xD74090 VA: 0x180D75A90 Slot: 16
	public bool Contains(KeyValuePair<string, object> entry) { }

	// RVA: 0xD75900 Offset: 0xD73F00 VA: 0x180D75900 Slot: 8
	public bool ContainsKey(string key) { }

	// RVA: 0xD75E70 Offset: 0xD74470 VA: 0x180D75E70 Slot: 12
	public int get_Count() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public bool get_IsReadOnly() { }

	[IteratorStateMachineAttribute] // RVA: 0xF0A50 Offset: 0xEFE50 VA: 0x1800F0A50
	// RVA: 0xD75B30 Offset: 0xD74130 VA: 0x180D75B30 Slot: 19
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	// RVA: 0xD75C40 Offset: 0xD74240 VA: 0x180D75C40 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD75AE0 Offset: 0xD740E0 VA: 0x180D75AE0 Slot: 17
	public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count) { }

	// RVA: 0xD75BA0 Offset: 0xD741A0 VA: 0x180D75BA0 Slot: 10
	public bool Remove(string key) { }

	// RVA: 0xD75BF0 Offset: 0xD741F0 VA: 0x180D75BF0 Slot: 18
	public bool Remove(KeyValuePair<string, object> entry) { }

	// RVA: 0xD75C80 Offset: 0xD74280 VA: 0x180D75C80 Slot: 11
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

	// RVA: 0xD87DE0 Offset: 0xD863E0 VA: 0x180D87DE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0 Slot: 4
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87F20 Offset: 0xD86520 VA: 0x180D87F20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87F70 Offset: 0xD86570 VA: 0x180D87F70 Slot: 7
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

	// RVA: 0x1AD420 Offset: 0x1AC820 VA: 0x1801AD420
	public void set_Level(EventLevel value) { }

	// RVA: 0x1AD480 Offset: 0x1AC880 VA: 0x1801AD480
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0x1AD410 Offset: 0x1AC810 VA: 0x1801AD410
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

	// RVA: 0xD85510 Offset: 0xD83B10 VA: 0x180D85510
	private void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD84FE0 Offset: 0xD835E0 VA: 0x180D84FE0
	private void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD855A0 Offset: 0xD83BA0 VA: 0x180D855A0
	internal void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data) { }

	[NonEventAttribute] // RVA: 0x70090 Offset: 0x6F490 VA: 0x180070090
	[ReliabilityContractAttribute] // RVA: 0x70090 Offset: 0x6F490 VA: 0x180070090
	// RVA: 0xD82790 Offset: 0xD80D90 VA: 0x180D82790
	private void WriteCleanup(GCHandle* pPins, int cPins) { }

	// RVA: 0xD7F960 Offset: 0xD7DF60 VA: 0x180D7F960
	private void InitializeProviderMetadata() { }

	// RVA: 0xD79BD0 Offset: 0xD781D0 VA: 0x180D79BD0
	private static int AddValueToMetaData(List<byte> metaData, string value) { }

	// RVA: 0xD7F860 Offset: 0xD7DE60 VA: 0x180D7F860
	private static int HexDigit(char c) { }

	// RVA: 0xD82180 Offset: 0xD80780 VA: 0x180D82180
	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0xD86970 Offset: 0xD84F70 VA: 0x180D86970
	public Guid get_Guid() { }

	// RVA: 0xABF5D0 Offset: 0xABDBD0 VA: 0x180ABF5D0
	public bool IsEnabled() { }

	// RVA: 0xD804F0 Offset: 0xD7EAF0 VA: 0x180D804F0
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0xD804F0 Offset: 0xD7EAF0 VA: 0x180D804F0
	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel) { }

	// RVA: 0xD7EEE0 Offset: 0xD7D4E0 VA: 0x180D7EEE0
	public static Guid GetGuid(Type eventSourceType) { }

	// RVA: 0xD7F510 Offset: 0xD7DB10 VA: 0x180D7F510
	public static string GetName(Type eventSourceType) { }

	// RVA: 0xD816C0 Offset: 0xD7FCC0 VA: 0x180D816C0
	public static void SetCurrentThreadActivityId(Guid activityId) { }

	// RVA: 0xD86880 Offset: 0xD84E80 VA: 0x180D86880
	public static Guid get_CurrentThreadActivityId() { }

	// RVA: 0xD86980 Offset: 0xD84F80 VA: 0x180D86980
	internal static Guid get_InternalCurrentThreadActivityId() { }

	// RVA: 0xD868B0 Offset: 0xD84EB0 VA: 0x180D868B0
	internal static Guid get_FallbackActivityId() { }

	// RVA: 0xD81F80 Offset: 0xD80580 VA: 0x180D81F80 Slot: 3
	public override string ToString() { }

	// RVA: 0xD86480 Offset: 0xD84A80 VA: 0x180D86480
	protected void .ctor() { }

	// RVA: 0xD86590 Offset: 0xD84B90 VA: 0x180D86590
	protected void .ctor(EventSourceSettings settings) { }

	// RVA: 0xD86700 Offset: 0xD84D00 VA: 0x180D86700
	protected void .ctor(EventSourceSettings settings, string[] traits) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void OnEventCommand(EventCommandEventArgs command) { }

	// RVA: 0xD84BF0 Offset: 0xD831F0 VA: 0x180D84BF0
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0xD84B00 Offset: 0xD83100 VA: 0x180D84B00
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0xD84A50 Offset: 0xD83050 VA: 0x180D84A50
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0xD84DB0 Offset: 0xD833B0 VA: 0x180D84DB0
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0xD84E90 Offset: 0xD83490 VA: 0x180D84E90
	protected void WriteEvent(int eventId, string arg1, string arg2) { }

	// RVA: 0xD848C0 Offset: 0xD82EC0 VA: 0x180D848C0
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	// RVA: 0xD84CA0 Offset: 0xD832A0 VA: 0x180D84CA0
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xD82840 Offset: 0xD80E40 VA: 0x180D82840
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xD83BE0 Offset: 0xD821E0 VA: 0x180D83BE0
	protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD848A0 Offset: 0xD82EA0 VA: 0x180D848A0
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0xD7CDC0 Offset: 0xD7B3C0 VA: 0x180D7CDC0 Slot: 4
	public void Dispose() { }

	// RVA: 0xD7CE30 Offset: 0xD7B430 VA: 0x180D7CE30 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD7DFC0 Offset: 0xD7C5C0 VA: 0x180D7DFC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD85CB0 Offset: 0xD842B0 VA: 0x180D85CB0
	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m) { }

	// RVA: 0xD82870 Offset: 0xD80E70 VA: 0x180D82870
	private void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD7FE20 Offset: 0xD7E420 VA: 0x180D7FE20
	private void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits) { }

	// RVA: 0xD7F570 Offset: 0xD7DB70 VA: 0x180D7F570
	private static string GetName(Type eventSourceType, EventManifestOptions flags) { }

	// RVA: 0xD7E060 Offset: 0xD7C660 VA: 0x180D7E060
	private static Guid GenerateGuidFromName(string name) { }

	// RVA: 0xD7C2C0 Offset: 0xD7A8C0 VA: 0x180D7C2C0
	private object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data) { }

	// RVA: 0xD7E980 Offset: 0xD7CF80 VA: 0x180D7E980
	private EventDispatcher GetDispatcher(EventListener listener) { }

	// RVA: 0xD82DE0 Offset: 0xD813E0 VA: 0x180D82DE0
	private void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD81440 Offset: 0xD7FA40 VA: 0x180D81440
	private object[] SerializeEventArgs(int eventId, object[] args) { }

	// RVA: 0xD80520 Offset: 0xD7EB20 VA: 0x180D80520
	private void LogEventArgsMismatches(ParameterInfo[] infos, object[] args) { }

	// RVA: 0xD7F760 Offset: 0xD7DD60 VA: 0x180D7F760
	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters) { }

	// RVA: 0xD85F70 Offset: 0xD84570 VA: 0x180D85F70
	private void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD85E00 Offset: 0xD84400 VA: 0x180D85E00
	private void WriteToAllListeners(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD7CBB0 Offset: 0xD7B1B0 VA: 0x180D7CBB0
	private void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs) { }

	// RVA: 0xD82970 Offset: 0xD80F70 VA: 0x180D82970
	private void WriteEventString(EventLevel level, long keywords, string msgString) { }

	// RVA: 0xD85A90 Offset: 0xD84090 VA: 0x180D85A90
	private void WriteStringToAllListeners(string eventName, string msg) { }

	// RVA: 0xD7E9C0 Offset: 0xD7CFC0 VA: 0x180D7E9C0
	private SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID) { }

	// RVA: 0xD803C0 Offset: 0xD7E9C0 VA: 0x180D803C0
	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword) { }

	// RVA: 0xD804C0 Offset: 0xD7EAC0 VA: 0x180D804C0
	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel) { }

	// RVA: 0xD818D0 Offset: 0xD7FED0 VA: 0x180D818D0
	private void ThrowEventSourceException(string eventName, Exception innerEx) { }

	// RVA: 0xD826D0 Offset: 0xD80CD0 VA: 0x180D826D0
	private void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName) { }

	// RVA: 0xD7F6D0 Offset: 0xD7DCD0 VA: 0x180D7F6D0
	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName) { }

	// RVA: 0xD80FD0 Offset: 0xD7F5D0 VA: 0x180D80FD0
	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments) { }

	// RVA: 0xD7CF60 Offset: 0xD7B560 VA: 0x180D7CF60
	internal void DoCommand(EventCommandEventArgs commandArgs) { }

	// RVA: 0xD822C0 Offset: 0xD808C0 VA: 0x180D822C0
	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling) { }

	// RVA: 0xD80760 Offset: 0xD7ED60 VA: 0x180D80760
	internal static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit) { }

	// RVA: 0xD82600 Offset: 0xD80C00 VA: 0x180D82600
	internal void UpdateKwdTriggers(bool enable) { }

	// RVA: 0xD7DAC0 Offset: 0xD7C0C0 VA: 0x180D7DAC0
	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value) { }

	// RVA: 0xD79E80 Offset: 0xD78480 VA: 0x180D79E80
	private bool AnyEventEnabled() { }

	// RVA: 0xD86A80 Offset: 0xD85080 VA: 0x180D86A80
	private bool get_IsDisposed() { }

	// RVA: 0xD7DBC0 Offset: 0xD7C1C0 VA: 0x180D7DBC0
	private void EnsureDescriptorsInitialized() { }

	// RVA: 0xD811E0 Offset: 0xD7F7E0 VA: 0x180D811E0
	private bool SendManifest(byte[] rawManifest) { }

	// RVA: 0xD7E1B0 Offset: 0xD7C7B0 VA: 0x180D7E1B0
	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = 0) { }

	// RVA: 0xD79F50 Offset: 0xD78550 VA: 0x180D79F50
	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType) { }

	// RVA: 0xD7ECC0 Offset: 0xD7D2C0 VA: 0x180D7ECC0
	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly) { }

	// RVA: 0xD7A0E0 Offset: 0xD786E0 VA: 0x180D7A0E0
	private static byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = 0) { }

	// RVA: 0xD80960 Offset: 0xD7EF60 VA: 0x180D80960
	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args) { }

	// RVA: 0xD795C0 Offset: 0xD77BC0 VA: 0x180D795C0
	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind) { }

	// RVA: 0xD79080 Offset: 0xD77680 VA: 0x180D79080
	private static void AddEventDescriptor(ref EventSource.EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID) { }

	// RVA: 0xD820C0 Offset: 0xD806C0 VA: 0x180D820C0
	private static void TrimEventDescriptors(ref EventSource.EventMetadata[] eventData) { }

	// RVA: 0xD793F0 Offset: 0xD779F0 VA: 0x180D793F0
	internal void AddListener(EventListener listener) { }

	// RVA: 0xD7B9C0 Offset: 0xD79FC0 VA: 0x180D7B9C0
	private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventSource.EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options) { }

	// RVA: 0xD7F260 Offset: 0xD7D860 VA: 0x180D7F260
	private static int GetHelperCallFirstArg(MethodInfo method) { }

	// RVA: 0xD80EE0 Offset: 0xD7F4E0 VA: 0x180D80EE0
	internal void ReportOutOfBandMessage(string msg, bool flush) { }

	// RVA: 0xD82700 Offset: 0xD80D00 VA: 0x180D82700
	private EventSourceSettings ValidateSettings(EventSourceSettings settings) { }

	// RVA: 0xD86AE0 Offset: 0xD850E0 VA: 0x180D86AE0
	private bool get_ThrowOnEventWriteErrors() { }

	// RVA: 0xD86AD0 Offset: 0xD850D0 VA: 0x180D86AD0
	private bool get_SelfDescribingEvents() { }

	// RVA: 0xD80B00 Offset: 0xD7F100 VA: 0x180D80B00
	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions) { }

	// RVA: 0xD863D0 Offset: 0xD849D0 VA: 0x180D863D0
	private static void .cctor() { }

}

private struct EventSource.Sha1ForNonSecretPurposes // TypeDefIndex: 1582
{	// Fields
	private long length; // 0x0
	private uint[] w; // 0x8
	private int pos; // 0x10

	// Methods

	// RVA: 0x1AD660 Offset: 0x1ACA60 VA: 0x1801AD660
	public void Start() { }

	// RVA: 0x1AD570 Offset: 0x1AC970 VA: 0x1801AD570
	public void Append(byte input) { }

	// RVA: 0x1AD580 Offset: 0x1AC980 VA: 0x1801AD580
	public void Append(byte[] input) { }

	// RVA: 0x1AD650 Offset: 0x1ACA50 VA: 0x1801AD650
	public void Finish(byte[] output) { }

	// RVA: 0x1AD640 Offset: 0x1ACA40 VA: 0x1801AD640
	private void Drain() { }

	// RVA: 0x10E63D0 Offset: 0x10E49D0 VA: 0x1810E63D0
	private static uint Rol1(uint input) { }

	// RVA: 0x10E63F0 Offset: 0x10E49F0 VA: 0x1810E63F0
	private static uint Rol5(uint input) { }

	// RVA: 0x10E63E0 Offset: 0x10E49E0 VA: 0x1810E63E0
	private static uint Rol30(uint input) { }

}

private class EventSource.OverideEventProvider : EventProvider // TypeDefIndex: 1583
{	// Fields
	private EventSource m_eventSource; // 0x60

	// Methods

	// RVA: 0x10E5530 Offset: 0x10E3B30 VA: 0x1810E5530
	public void .ctor(EventSource eventSource) { }

	// RVA: 0x10E54D0 Offset: 0x10E3AD0 VA: 0x1810E54D0 Slot: 6
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

	// RVA: 0x120E40 Offset: 0x120240 VA: 0x180120E40
	public void .ctor(int traceloggingId, byte level, byte opcode, long keywords) { }

	// RVA: 0x120E70 Offset: 0x120270 VA: 0x180120E70
	public void .ctor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0
	public int get_EventId() { }

	// RVA: 0x120EE0 Offset: 0x1202E0 VA: 0x180120EE0
	public byte get_Version() { }

	// RVA: 0x120E90 Offset: 0x120290 VA: 0x180120E90
	public byte get_Channel() { }

	// RVA: 0x120EB0 Offset: 0x1202B0 VA: 0x180120EB0
	public byte get_Level() { }

	// RVA: 0x120EC0 Offset: 0x1202C0 VA: 0x180120EC0
	public byte get_Opcode() { }

	// RVA: 0x120ED0 Offset: 0x1202D0 VA: 0x180120ED0
	public int get_Task() { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public long get_Keywords() { }

	// RVA: 0x120D30 Offset: 0x120130 VA: 0x180120D30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x120E10 Offset: 0x120210 VA: 0x180120E10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x120CD0 Offset: 0x1200D0 VA: 0x180120CD0
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

	// RVA: 0xD77F70 Offset: 0xD76570 VA: 0x180D77F70
	internal void Register(Guid providerGuid) { }

	// RVA: 0xD780B0 Offset: 0xD766B0 VA: 0x180D780B0
	internal int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize) { }

	// RVA: 0xD76260 Offset: 0xD74860 VA: 0x180D76260 Slot: 4
	public void Dispose() { }

	// RVA: 0xD76130 Offset: 0xD74730 VA: 0x180D76130 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD760F0 Offset: 0xD746F0 VA: 0x180D760F0
	private void Deregister() { }

	[EventProvider.MonoPInvokeCallbackAttribute] // RVA: 0x70EC0 Offset: 0x702C0 VA: 0x180070EC0
	// RVA: 0xD77390 Offset: 0xD75990 VA: 0x180D77390
	private static void EtwEnableCallBack(in Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0xD76E30 Offset: 0xD75430 VA: 0x180D76E30
	private void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	protected EventLevel get_Level() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	protected EventKeywords get_MatchAnyKeyword() { }

	// RVA: 0xD774E0 Offset: 0xD75AE0 VA: 0x180D774E0
	private static int FindNull(byte[] buffer, int idx) { }

	// RVA: 0xD779E0 Offset: 0xD75FE0 VA: 0x180D779E0
	private List<Tuple<EventProvider.SessionInfo, bool>> GetSessions() { }

	// RVA: 0xD776E0 Offset: 0xD75CE0 VA: 0x180D776E0
	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList) { }

	// RVA: 0xD77870 Offset: 0xD75E70 VA: 0x180D77870
	private void GetSessionInfo(Action<int, long> action) { }

	// RVA: 0xD77EA0 Offset: 0xD764A0 VA: 0x180D77EA0
	private static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId) { }

	// RVA: 0xD77530 Offset: 0xD75B30 VA: 0x180D77530
	private bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data, out int dataStart) { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool IsEnabled() { }

	// RVA: 0xD77F30 Offset: 0xD76530 VA: 0x180D77F30
	public bool IsEnabled(byte level, long keywords) { }

	// RVA: 0xD77640 Offset: 0xD75C40 VA: 0x180D77640
	public static EventProvider.WriteEventErrorCode GetLastWriteEventError() { }

	// RVA: 0xD781B0 Offset: 0xD767B0 VA: 0x180D781B0
	private static void SetLastError(int error) { }

	// RVA: 0xD762D0 Offset: 0xD748D0 VA: 0x180D762D0
	private static object EncodeObject(ref object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize) { }

	// RVA: 0xD783E0 Offset: 0xD769E0 VA: 0x180D783E0
	internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, object[] eventPayload) { }

	// RVA: 0xD78320 Offset: 0xD76920 VA: 0x180D78320
	protected internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD78260 Offset: 0xD76860 VA: 0x180D78260
	internal bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD774B0 Offset: 0xD75AB0 VA: 0x180D774B0
	private uint EventUnregister() { }

	// RVA: 0xD78FC0 Offset: 0xD775C0 VA: 0x180D78FC0
	private static int bitcount(uint n) { }

	// RVA: 0xD79060 Offset: 0xD77660 VA: 0x180D79060
	private static int bitindex(uint n) { }

	// RVA: 0xD78F50 Offset: 0xD77550 VA: 0x180D78F50
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

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor(Type t) { }

}

private sealed class EventProvider.<>c__DisplayClass44_0 // TypeDefIndex: 1604
{	// Fields
	public List<EventProvider.SessionInfo> liveSessionList; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD88490 Offset: 0xD86A90 VA: 0x180D88490
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

	// RVA: 0xD75590 Offset: 0xD73B90 VA: 0x180D75590 Slot: 4
	protected internal virtual void OnEventSourceCreated(EventSource eventSource) { }

	// RVA: 0xD75630 Offset: 0xD73C30 VA: 0x180D75630 Slot: 5
	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData) { }

	// RVA: 0xD74EC0 Offset: 0xD734C0 VA: 0x180D74EC0
	internal static void AddEventSource(EventSource newEventSource) { }

	// RVA: 0xD75350 Offset: 0xD73950 VA: 0x180D75350
	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	// RVA: 0xD75710 Offset: 0xD73D10 VA: 0x180D75710
	internal static object get_EventListenersLock() { }

	// RVA: 0xD75690 Offset: 0xD73C90 VA: 0x180D75690
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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	internal void set_Command(EventCommand value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IDictionary<string, string> get_Arguments() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Arguments(IDictionary<string, string> value) { }

	// RVA: 0xD74AA0 Offset: 0xD730A0 VA: 0x180D74AA0
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
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_EventSource(EventSource value) { }

	// RVA: 0x10DC970 Offset: 0x10DAF70 VA: 0x1810DC970
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

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_EventName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	internal void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10DCD50 Offset: 0x10DB350 VA: 0x1810DCD50
	internal void set_RelatedActivityId(Guid value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_Payload(ReadOnlyCollection<object> value) { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	internal void set_PayloadNames(ReadOnlyCollection<string> value) { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Message(string value) { }

	// RVA: 0x10DCCE0 Offset: 0x10DB2E0 VA: 0x1810DCCE0
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Guid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Guid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_LocalizationResources() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0xD74A50 Offset: 0xD73050 VA: 0x180D74A50
	public void .ctor(int eventId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_EventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public EventLevel get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	public void set_Level(EventLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventKeywords get_Keywords() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public EventOpcode get_Opcode() { }

	// RVA: 0xD74A90 Offset: 0xD73090 VA: 0x180D74A90
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0xC66170 Offset: 0xC64770 VA: 0x180C66170
	internal bool get_IsOpcodeSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public EventTask get_Task() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	public void set_Task(EventTask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public byte get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public EventTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
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

	// RVA: 0xD74E50 Offset: 0xD73450 VA: 0x180D74E50
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

	// RVA: 0x10DCB90 Offset: 0x10DB190 VA: 0x1810DCB90
	public void .ctor() { }

	// RVA: 0x10DCAF0 Offset: 0x10DB0F0 VA: 0x1810DCAF0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10DCA70 Offset: 0x10DB070 VA: 0x1810DCA70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10DC9D0 Offset: 0x10DAFD0 VA: 0x1810DC9D0
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

	// RVA: 0x15C45A0 Offset: 0x15C2BA0 VA: 0x1815C45A0
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x15C4640 Offset: 0x15C2C40 VA: 0x1815C4640
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public int get_Count() { }

	// RVA: 0x15C46F0 Offset: 0x15C2CF0 VA: 0x1815C46F0 Slot: 19
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x15C3030 Offset: 0x15C1630 VA: 0x1815C3030
	public int Add(EventDescriptor value) { }

	// RVA: 0x15C3130 Offset: 0x15C1730 VA: 0x1815C3130
	public void Clear() { }

	// RVA: 0x15C3190 Offset: 0x15C1790 VA: 0x1815C3190
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x15C3C20 Offset: 0x15C2220 VA: 0x1815C3C20 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15C31F0 Offset: 0x15C17F0 VA: 0x1815C31F0
	private void EnsureEventsOwned() { }

	// RVA: 0x15C32A0 Offset: 0x15C18A0 VA: 0x1815C32A0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15C3470 Offset: 0x15C1A70 VA: 0x1815C3470
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x15C34D0 Offset: 0x15C1AD0 VA: 0x1815C34D0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x15C3B60 Offset: 0x15C2160 VA: 0x1815C3B60
	public void Remove(EventDescriptor value) { }

	// RVA: 0x15C3A80 Offset: 0x15C2080 VA: 0x1815C3A80
	public void RemoveAt(int index) { }

	// RVA: 0x15C33C0 Offset: 0x15C19C0 VA: 0x1815C33C0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15C3670 Offset: 0x15C1C70 VA: 0x1815C3670
	protected void InternalSort(string[] names) { }

	// RVA: 0x15C35F0 Offset: 0x15C1BF0 VA: 0x1815C35F0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15C3C70 Offset: 0x15C2270 VA: 0x1815C3C70 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15C4300 Offset: 0x15C2900 VA: 0x1815C4300 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15C4320 Offset: 0x15C2920 VA: 0x1815C4320 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15C3D20 Offset: 0x15C2320 VA: 0x1815C3D20 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15C3130 Offset: 0x15C1730 VA: 0x1815C3130 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15C3E90 Offset: 0x15C2490 VA: 0x1815C3E90 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15C3F60 Offset: 0x15C2560 VA: 0x1815C3F60 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15C4030 Offset: 0x15C2630 VA: 0x1815C4030 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15C41D0 Offset: 0x15C27D0 VA: 0x1815C41D0 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15C41C0 Offset: 0x15C27C0 VA: 0x1815C41C0 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15C44E0 Offset: 0x15C2AE0 VA: 0x1815C44E0
	private static void .cctor() { }

}

public sealed class EventHandlerList : IDisposable // TypeDefIndex: 2704
{	// Fields
	private EventHandlerList.ListEntry head; // 0x10
	private Component parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x10B6570 Offset: 0x10B4B70 VA: 0x1810B6570
	internal void .ctor(Component parent) { }

	// RVA: 0x15C4900 Offset: 0x15C2F00 VA: 0x1815C4900
	public Delegate get_Item(object key) { }

	// RVA: 0x15C4790 Offset: 0x15C2D90 VA: 0x1815C4790
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0xE37A10 Offset: 0xE36010 VA: 0x180E37A10 Slot: 4
	public void Dispose() { }

	// RVA: 0x15C4880 Offset: 0x15C2E80 VA: 0x1815C4880
	private EventHandlerList.ListEntry Find(object key) { }

	// RVA: 0x15C48A0 Offset: 0x15C2EA0 VA: 0x1815C48A0
	public void RemoveHandler(object key, Delegate value) { }

}

private sealed class EventHandlerList.ListEntry // TypeDefIndex: 2705
{	// Fields
	internal EventHandlerList.ListEntry next; // 0x10
	internal object key; // 0x18
	internal Delegate handler; // 0x20

	// Methods

	// RVA: 0x15C8750 Offset: 0x15C6D50 VA: 0x1815C8750
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

	// RVA: 0x1A57C40 Offset: 0x1A56240 VA: 0x181A57C40
	public EventType get_rawType() { }

	// RVA: 0x1A57B70 Offset: 0x1A56170 VA: 0x181A57B70
	public Vector2 get_mousePosition() { }

	// RVA: 0x1A57F50 Offset: 0x1A56550 VA: 0x181A57F50
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x1A578F0 Offset: 0x1A55EF0 VA: 0x181A578F0
	public Vector2 get_delta() { }

	// RVA: 0x1A57BC0 Offset: 0x1A561C0 VA: 0x181A57BC0
	public PointerType get_pointerType() { }

	// RVA: 0x1A576E0 Offset: 0x1A55CE0 VA: 0x181A576E0
	public int get_button() { }

	// RVA: 0x1A57AE0 Offset: 0x1A560E0 VA: 0x181A57AE0
	public EventModifiers get_modifiers() { }

	// RVA: 0x1A57EC0 Offset: 0x1A564C0 VA: 0x181A57EC0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1A57C00 Offset: 0x1A56200 VA: 0x181A57C00
	public float get_pressure() { }

	// RVA: 0x1A57760 Offset: 0x1A55D60 VA: 0x181A57760
	public int get_clickCount() { }

	// RVA: 0x1A57720 Offset: 0x1A55D20 VA: 0x181A57720
	public char get_character() { }

	// RVA: 0x1A57D00 Offset: 0x1A56300 VA: 0x181A57D00
	public void set_character(char value) { }

	// RVA: 0x1A57AA0 Offset: 0x1A560A0 VA: 0x181A57AA0
	public KeyCode get_keyCode() { }

	// RVA: 0x1A57E80 Offset: 0x1A56480 VA: 0x181A57E80
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x1A57940 Offset: 0x1A55F40 VA: 0x181A57940
	public int get_displayIndex() { }

	// RVA: 0x1A57E40 Offset: 0x1A56440 VA: 0x181A57E40
	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] // RVA: 0xC5DD0 Offset: 0xC51D0 VA: 0x1800C5DD0
	// RVA: 0x1A57CC0 Offset: 0x1A562C0 VA: 0x181A57CC0
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0xC5EB0 Offset: 0xC52B0 VA: 0x1800C5EB0
	// RVA: 0x1A57F90 Offset: 0x1A56590 VA: 0x181A57F90
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] // RVA: 0xC6040 Offset: 0xC5440 VA: 0x1800C6040
	// RVA: 0x1A577A0 Offset: 0x1A55DA0 VA: 0x181A577A0
	public string get_commandName() { }

	[FreeFunctionAttribute] // RVA: 0xC6100 Offset: 0xC5500 VA: 0x1800C6100
	// RVA: 0x1A57D50 Offset: 0x1A56350 VA: 0x181A57D50
	public void set_commandName(string value) { }

	[NativeMethodAttribute] // RVA: 0xC61B0 Offset: 0xC55B0 VA: 0x1800C61B0
	// RVA: 0x1A555C0 Offset: 0x1A53BC0 VA: 0x181A555C0
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0xC6270 Offset: 0xC5670 VA: 0x1800C6270
	// RVA: 0x1A553C0 Offset: 0x1A539C0 VA: 0x181A553C0
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0xC6300 Offset: 0xC5700 VA: 0x1800C6300
	// RVA: 0x1A55400 Offset: 0x1A53A00 VA: 0x181A55400
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xC6340 Offset: 0xC5740 VA: 0x1800C6340
	// RVA: 0x1A55380 Offset: 0x1A53980 VA: 0x181A55380
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunctionAttribute] // RVA: 0xC63D0 Offset: 0xC57D0 VA: 0x1800C63D0
	// RVA: 0x1A55340 Offset: 0x1A53940 VA: 0x181A55340
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] // RVA: 0xC6440 Offset: 0xC5840 VA: 0x1800C6440
	[VisibleToOtherModulesAttribute] // RVA: 0xC6440 Offset: 0xC5840 VA: 0x1800C6440
	// RVA: 0x1A54E20 Offset: 0x1A53420 VA: 0x181A54E20
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1A56890 Offset: 0x1A54E90 VA: 0x181A56890
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1A55580 Offset: 0x1A53B80 VA: 0x181A55580
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A55440 Offset: 0x1A53A40 VA: 0x181A55440
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1A57610 Offset: 0x1A55C10 VA: 0x181A57610
	public void .ctor() { }

	// RVA: 0x1A57650 Offset: 0x1A55C50 VA: 0x181A57650
	public void .ctor(int displayIndex) { }

	// RVA: 0x1A57560 Offset: 0x1A55B60 VA: 0x181A57560
	public void .ctor(Event other) { }

	// RVA: 0x1A55130 Offset: 0x1A53730 VA: 0x181A55130 Slot: 1
	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC66A0 Offset: 0xC5AA0 VA: 0x1800C66A0
	// RVA: 0x1A54E70 Offset: 0x1A53470 VA: 0x181A54E70
	internal void CopyFrom(Event e) { }

	// RVA: 0x1A57C80 Offset: 0x1A56280 VA: 0x181A57C80
	public bool get_shift() { }

	// RVA: 0x1A57820 Offset: 0x1A55E20 VA: 0x181A57820
	public bool get_control() { }

	// RVA: 0x1A576A0 Offset: 0x1A55CA0 VA: 0x181A576A0
	public bool get_alt() { }

	// RVA: 0x1A577E0 Offset: 0x1A55DE0 VA: 0x181A577E0
	public bool get_command() { }

	// RVA: 0x1A57860 Offset: 0x1A55E60 VA: 0x181A57860
	public static Event get_current() { }

	// RVA: 0x1A57DA0 Offset: 0x1A563A0 VA: 0x181A57DA0
	public static void set_current(Event value) { }

	// RVA: 0x1A579F0 Offset: 0x1A55FF0 VA: 0x181A579F0
	public bool get_isKey() { }

	// RVA: 0x1A57A40 Offset: 0x1A56040 VA: 0x181A57A40
	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC69B0 Offset: 0xC5DB0 VA: 0x1800C69B0
	// RVA: 0x1A57980 Offset: 0x1A55F80 VA: 0x181A57980
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x1A55600 Offset: 0x1A53C00 VA: 0x181A55600
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x1A55210 Offset: 0x1A53810 VA: 0x181A55210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A54EE0 Offset: 0x1A534E0 VA: 0x181A54EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A568D0 Offset: 0x1A54ED0 VA: 0x181A568D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A573B0 Offset: 0x1A559B0 VA: 0x181A573B0
	public void Use() { }

	// RVA: 0x1A57B20 Offset: 0x1A56120 VA: 0x181A57B20
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x1A57F00 Offset: 0x1A56500 VA: 0x181A57F00
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x1A578A0 Offset: 0x1A55EA0 VA: 0x181A578A0
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
	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F9DD0 Offset: 0x1F91D0 VA: 0x1801F9DD0
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x229CB0 Offset: 0x2290B0 VA: 0x180229CB0
	public bool WantsEvent(EventType type) { }

}

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 4582
{	// Fields
	private readonly EventDispatcher m_Dispatcher; // 0x0

	// Methods

	// RVA: 0x139D20 Offset: 0x139120 VA: 0x180139D20
	public void .ctor(EventDispatcher d) { }

	// RVA: 0x139C40 Offset: 0x139040 VA: 0x180139C40 Slot: 4
	public void Dispose() { }

	// RVA: 0x139C50 Offset: 0x139050 VA: 0x180139C50 Slot: 5
	public bool Equals(EventDispatcherGate other) { }

	// RVA: 0x139C60 Offset: 0x139060 VA: 0x180139C60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139CF0 Offset: 0x1390F0 VA: 0x180139CF0 Slot: 2
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

	// RVA: 0xEAF620 Offset: 0xEADC20 VA: 0x180EAF620
	internal void .ctor() { }

	// RVA: 0xEAF910 Offset: 0xEADF10 VA: 0x180EAF910
	private bool get_dispatchImmediately() { }

	// RVA: 0xEAECC0 Offset: 0xEAD2C0 VA: 0x180EAECC0
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0xEAECB0 Offset: 0xEAD2B0 VA: 0x180EAECB0
	internal void CloseGate() { }

	// RVA: 0xEAEE90 Offset: 0xEAD490 VA: 0x180EAEE90
	internal void OpenGate() { }

	// RVA: 0xEAEF10 Offset: 0xEAD510 VA: 0x180EAEF10
	private void ProcessEventQueue() { }

	// RVA: 0xEAF1D0 Offset: 0xEAD7D0 VA: 0x180EAF1D0
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xEAEA40 Offset: 0xEAD040 VA: 0x180EAEA40
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0xEAF5B0 Offset: 0xEADBB0 VA: 0x180EAF5B0
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

	// RVA: 0xEACB90 Offset: 0xEAB190 VA: 0x180EACB90
	protected static long RegisterEventType() { }

	// RVA: 0xEACD90 Offset: 0xEAB390 VA: 0x180EACD90 Slot: 5
	public virtual long get_eventTypeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFD0 Offset: 0x4995D0 VA: 0x18049AFD0
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE74D40 Offset: 0xE73340 VA: 0x180E74D40
	private void set_triggerEventId(ulong value) { }

	// RVA: 0xE74D40 Offset: 0xE73340 VA: 0x180E74D40
	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	internal void set_propagation(EventBase.EventPropagation value) { }

	// RVA: 0xEACE10 Offset: 0xEAB410 VA: 0x180EACE10
	internal PropagationPaths get_path() { }

	// RVA: 0xEAD240 Offset: 0xEAB840 VA: 0x180EAD240
	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] // RVA: 0x95D30 Offset: 0x95130 VA: 0x180095D30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void PreDispatch() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 7
	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] // RVA: 0x95E70 Offset: 0x95270 VA: 0x180095E70
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void PostDispatch() { }

	// RVA: 0xEACB50 Offset: 0xEAB150 VA: 0x180EACB50 Slot: 9
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0xEACD50 Offset: 0xEAB350 VA: 0x180EACD50
	public bool get_bubbles() { }

	// RVA: 0xEACF50 Offset: 0xEAB550 VA: 0x180EACF50
	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0xEACF40 Offset: 0xEAB540 VA: 0x180EACF40
	public IEventHandler get_target() { }

	// RVA: 0xEAD400 Offset: 0xEABA00 VA: 0x180EAD400
	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal List<IEventHandler> get_skipElements() { }

	// RVA: 0xEACBF0 Offset: 0xEAB1F0 VA: 0x180EACBF0
	internal bool Skip(IEventHandler h) { }

	// RVA: 0xEACDE0 Offset: 0xEAB3E0 VA: 0x180EACDE0
	public bool get_isPropagationStopped() { }

	// RVA: 0xEAD210 Offset: 0xEAB810 VA: 0x180EAD210
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0xEACC60 Offset: 0xEAB260 VA: 0x180EACC60
	public void StopPropagation() { }

	// RVA: 0xEACDD0 Offset: 0xEAB3D0 VA: 0x180EACDD0
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0xEAD1F0 Offset: 0xEAB7F0 VA: 0x180EAD1F0
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0xEACC50 Offset: 0xEAB250 VA: 0x180EACC50
	public void StopImmediatePropagation() { }

	// RVA: 0xEACDC0 Offset: 0xEAB3C0 VA: 0x180EACDC0
	public bool get_isDefaultPrevented() { }

	// RVA: 0xEAD1D0 Offset: 0xEAB7D0 VA: 0x180EAD1D0
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0xEACB80 Offset: 0xEAB180 VA: 0x180EACB80
	public void PreventDefault() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD280D0 Offset: 0xD266D0 VA: 0x180D280D0
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0xEACD60 Offset: 0xEAB360 VA: 0x180EACD60 Slot: 10
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0xEACF60 Offset: 0xEAB560 VA: 0x180EACF60 Slot: 11
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0xEACD70 Offset: 0xEAB370 VA: 0x180EACD70
	public bool get_dispatch() { }

	// RVA: 0xEAD090 Offset: 0xEAB690 VA: 0x180EAD090
	internal void set_dispatch(bool value) { }

	// RVA: 0xEACAD0 Offset: 0xEAB0D0 VA: 0x180EACAD0
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0xEACD80 Offset: 0xEAB380 VA: 0x180EACD80
	private bool get_dispatched() { }

	// RVA: 0xEAD0B0 Offset: 0xEAB6B0 VA: 0x180EAD0B0
	private void set_dispatched(bool value) { }

	// RVA: 0xEACF10 Offset: 0xEAB510 VA: 0x180EACF10
	internal bool get_processed() { }

	// RVA: 0xEAD3A0 Offset: 0xEAB9A0 VA: 0x180EAD3A0
	private void set_processed(bool value) { }

	// RVA: 0xEACF30 Offset: 0xEAB530 VA: 0x180EACF30
	internal bool get_stopDispatch() { }

	// RVA: 0xEAD3E0 Offset: 0xEAB9E0 VA: 0x180EAD3E0
	internal void set_stopDispatch(bool value) { }

	// RVA: 0xEACF20 Offset: 0xEAB520 VA: 0x180EACF20
	internal bool get_propagateToIMGUI() { }

	// RVA: 0xEAD3C0 Offset: 0xEAB9C0 VA: 0x180EAD3C0
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0xEACDA0 Offset: 0xEAB3A0 VA: 0x180EACDA0
	private bool get_imguiEventIsValid() { }

	// RVA: 0xEAD0D0 Offset: 0xEAB6D0 VA: 0x180EAD0D0
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0xEACDB0 Offset: 0xEAB3B0 VA: 0x180EACDB0
	public Event get_imguiEvent() { }

	// RVA: 0xEAD0F0 Offset: 0xEAB6F0 VA: 0x180EAD0F0
	protected void set_imguiEvent(Event value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEACDF0 Offset: 0xEAB3F0 VA: 0x180EACDF0
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEAD230 Offset: 0xEAB830 VA: 0x180EAD230
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0xEAC890 Offset: 0xEAAE90 VA: 0x180EAC890 Slot: 12
	protected virtual void Init() { }

	// RVA: 0xEAC8A0 Offset: 0xEAAEA0 VA: 0x180EAC8A0
	private void LocalInit() { }

	// RVA: 0xEACCC0 Offset: 0xEAB2C0 VA: 0x180EACCC0
	protected void .ctor() { }

	// RVA: 0xEACF00 Offset: 0xEAB500 VA: 0x180EACF00
	protected bool get_pooled() { }

	// RVA: 0xEAD380 Offset: 0xEAB980 VA: 0x180EAD380
	protected void set_pooled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void Acquire();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose();

	// RVA: 0xEACC70 Offset: 0xEAB270 VA: 0x180EACC70
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

	// RVA: 0xEAD440 Offset: 0xEABA40 VA: 0x180EAD440
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0xEAD5A0 Offset: 0xEABBA0 VA: 0x180EAD5A0
	public void Release(EventCallbackList element) { }

	// RVA: 0xEAD630 Offset: 0xEABC30 VA: 0x180EAD630
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
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0xEAD840 Offset: 0xEABE40 VA: 0x180EAD840
	public void .ctor() { }

	// RVA: 0xEAD8B0 Offset: 0xEABEB0 VA: 0x180EAD8B0
	public void .ctor(EventCallbackList source) { }

	// RVA: 0xEAD6A0 Offset: 0xEABCA0 VA: 0x180EAD6A0
	public void AddRange(EventCallbackList list) { }

	// RVA: 0xEAD940 Offset: 0xEABF40 VA: 0x180EAD940
	public int get_Count() { }

	// RVA: 0xEAD980 Offset: 0xEABF80 VA: 0x180EAD980
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0xEAD7F0 Offset: 0xEABDF0 VA: 0x180EAD7F0
	public void Clear() { }

}

internal class EventCallbackRegistry // TypeDefIndex: 4648
{	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0xEAD9E0 Offset: 0xEABFE0 VA: 0x180EAD9E0
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0xEADD50 Offset: 0xEAC350 VA: 0x180EADD50
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0xEADBE0 Offset: 0xEAC1E0 VA: 0x180EADBE0
	public void InvokeCallbacks(EventBase evt) { }

	// RVA: 0xEADBC0 Offset: 0xEAC1C0 VA: 0x180EADBC0
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEADBA0 Offset: 0xEAC1A0 VA: 0x180EADBA0
	public bool HasBubbleHandlers() { }

	// RVA: 0xEADE30 Offset: 0xEAC430 VA: 0x180EADE30
	private static void .cctor() { }

}

internal static class EventDispatchUtilities // TypeDefIndex: 4658
{	// Methods

	// RVA: 0xEADFF0 Offset: 0xEAC5F0 VA: 0x180EADFF0
	public static void PropagateEvent(EventBase evt) { }

	// RVA: 0xEAE750 Offset: 0xEACD50 VA: 0x180EAE750
	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0xEADEE0 Offset: 0xEAC4E0 VA: 0x180EADEE0
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

	// RVA: 0x10C5000 Offset: 0x10C3600 VA: 0x1810C5000
	public static EventSystem get_current() { }

	// RVA: 0x10C50C0 Offset: 0x10C36C0 VA: 0x1810C50C0
	public static void set_current(EventSystem value) { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_sendNavigationEvents() { }

	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public int get_pixelDragThreshold() { }

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_isFocused() { }

	// RVA: 0x10C4EF0 Offset: 0x10C34F0 VA: 0x1810C4EF0
	protected void .ctor() { }

	// RVA: 0x10C48C0 Offset: 0x10C2EC0 VA: 0x1810C48C0
	public void UpdateModules() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00
	public bool get_alreadySelecting() { }

	// RVA: 0x10C4400 Offset: 0x10C2A00 VA: 0x1810C4400
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x10C4F70 Offset: 0x10C3570 VA: 0x1810C4F70
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x10C4600 Offset: 0x10C2C00 VA: 0x1810C4600
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x10C3F50 Offset: 0x10C2550 VA: 0x1810C3F50
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x10C3D70 Offset: 0x10C2370 VA: 0x1810C3D70
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x10C3B60 Offset: 0x10C2160 VA: 0x1810C3B60
	public bool IsPointerOverGameObject() { }

	// RVA: 0x10C3AB0 Offset: 0x10C20B0 VA: 0x1810C3AB0
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C3CF0 Offset: 0x10C22F0 VA: 0x1810C3CF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10C3C00 Offset: 0x10C2200 VA: 0x1810C3C00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10C46A0 Offset: 0x10C2CA0 VA: 0x1810C46A0
	private void TickModules() { }

	// RVA: 0x810590 Offset: 0x80EB90 VA: 0x180810590 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x10C49F0 Offset: 0x10C2FF0 VA: 0x1810C49F0 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x10C3980 Offset: 0x10C1F80 VA: 0x1810C3980
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x10C47B0 Offset: 0x10C2DB0 VA: 0x1810C47B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C4E40 Offset: 0x10C3440 VA: 0x1810C4E40
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

	// RVA: 0x10C5460 Offset: 0x10C3A60 VA: 0x1810C5460
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x10C5460 Offset: 0x10C3A60 VA: 0x1810C5460
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x10C51C0 Offset: 0x10C37C0 VA: 0x1810C51C0
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x10C53F0 Offset: 0x10C39F0 VA: 0x1810C53F0 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x10C5400 Offset: 0x10C3A00 VA: 0x1810C5400 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x10C5380 Offset: 0x10C3980 VA: 0x1810C5380 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x10C5390 Offset: 0x10C3990 VA: 0x1810C5390 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x10C53E0 Offset: 0x10C39E0 VA: 0x1810C53E0 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x10C5410 Offset: 0x10C3A10 VA: 0x1810C5410 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x10C53D0 Offset: 0x10C39D0 VA: 0x1810C53D0 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10C5430 Offset: 0x10C3A30 VA: 0x1810C5430 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x10C5370 Offset: 0x10C3970 VA: 0x1810C5370 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x10C5420 Offset: 0x10C3A20 VA: 0x1810C5420 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x10C53C0 Offset: 0x10C39C0 VA: 0x1810C53C0 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x10C5450 Offset: 0x10C3A50 VA: 0x1810C5450 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x10C53B0 Offset: 0x10C39B0 VA: 0x1810C53B0 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x10C5350 Offset: 0x10C3950 VA: 0x1810C5350 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x10C53A0 Offset: 0x10C39A0 VA: 0x1810C53A0 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x10C5440 Offset: 0x10C3A40 VA: 0x1810C5440 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10C5360 Offset: 0x10C3960 VA: 0x1810C5360 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }

}

public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 5073
{	// Methods

	// RVA: 0x10CF920 Offset: 0x10CDF20 VA: 0x1810CF920
	public void .ctor() { }

}

public class EventTrigger.Entry // TypeDefIndex: 5074
{	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x10C38F0 Offset: 0x10C1EF0 VA: 0x1810C38F0
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
	|-RVA: 0x1571D20 Offset: 0x1570320 VA: 0x181571D20
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

	// RVA: 0x13978A0 Offset: 0x1395EA0 VA: 0x1813978A0
	internal void .ctor() { }

	// RVA: 0x1397950 Offset: 0x1395F50 VA: 0x181397950
	public MidiEvent get_Item(int index) { }

	// RVA: 0x1397910 Offset: 0x1395F10 VA: 0x181397910 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1397500 Offset: 0x1395B00 VA: 0x181397500 Slot: 6
	public void Add(MidiEvent midiEvent) { }

	// RVA: 0x1397760 Offset: 0x1395D60 VA: 0x181397760 Slot: 10
	public bool Remove(MidiEvent midiEvent) { }

	// RVA: 0x13975C0 Offset: 0x1395BC0 VA: 0x1813975C0 Slot: 7
	public void Clear() { }

	// RVA: 0x13976E0 Offset: 0x1395CE0 VA: 0x1813976E0 Slot: 11
	public IEnumerator<MidiEvent> GetEnumerator() { }

	// RVA: 0x1397820 Offset: 0x1395E20 VA: 0x181397820 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1397610 Offset: 0x1395C10 VA: 0x181397610 Slot: 8
	public bool Contains(MidiEvent item) { }

	// RVA: 0x1397670 Offset: 0x1395C70 VA: 0x181397670 Slot: 9
	public void CopyTo(MidiEvent[] array, int arrayIndex) { }

}

public sealed class EventTypesCollection // TypeDefIndex: 7530
{	// Fields
	private readonly Dictionary<byte, Type> _types; // 0x10

	// Methods

	// RVA: 0x1397490 Offset: 0x1395A90 VA: 0x181397490
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

	// RVA: 0x13971C0 Offset: 0x13957C0 VA: 0x1813971C0
	internal static IEventReader GetReader(byte statusByte, bool smfOnly) { }

	// RVA: 0x1397360 Offset: 0x1395960 VA: 0x181397360
	private static void .cctor() { }

}

public class EventSchedule : BaseMonoBehaviour // TypeDefIndex: 9817
{	// Fields
	[TooltipAttribute] // RVA: 0x99C40 Offset: 0x99040 VA: 0x180099C40
	public float minimumHoursBetween; // 0x18
	[TooltipAttribute] // RVA: 0x99E30 Offset: 0x99230 VA: 0x180099E30
	public float maxmumHoursBetween; // 0x1C

	// Methods

	// RVA: 0x8CC840 Offset: 0x8CAE40 VA: 0x1808CC840
	public void .ctor() { }

}

