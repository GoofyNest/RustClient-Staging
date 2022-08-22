public abstract class Base : IDisposable // TypeDefIndex: 5283
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AppId <AppId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnChanges; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<ServerInfo> OnResponsiveServer; // 0x20
	public List<ServerInfo> Responsive; // 0x28
	public List<ServerInfo> Unresponsive; // 0x30
	internal HServerListRequest request; // 0x38
	internal List<MatchMakingKeyValuePair> filters; // 0x40
	internal List<int> watchList; // 0x48
	internal int LastCount; // 0x50

	// Properties
	internal static ISteamMatchmakingServers Internal { get; }
	public AppId AppId { get; set; }
	internal int Count { get; }
	internal bool IsRefreshing { get; }

	// Methods

	// RVA: 0xDD7980 Offset: 0xDD5F80 VA: 0x180DD7980
	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD78B0 Offset: 0xDD5EB0 VA: 0x180DD78B0
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7A80 Offset: 0xDD6080 VA: 0x180DD7A80
	public void remove_OnChanges(Action value) { }

	// RVA: 0xDD7740 Offset: 0xDD5D40 VA: 0x180DD7740
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0xA25E0 Offset: 0xA19E0 VA: 0x1800A25E0
	// RVA: 0xDD7250 Offset: 0xDD5850 VA: 0x180DD7250 Slot: 5
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDD6EB0 Offset: 0xDD54B0 VA: 0x180DD6EB0 Slot: 6
	public virtual void Cancel() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void LaunchQuery();

	// RVA: 0xDD6EF0 Offset: 0xDD54F0 VA: 0x180DD6EF0 Slot: 8
	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	// RVA: 0xDD6E10 Offset: 0xDD5410 VA: 0x180DD6E10
	public void AddFilter(string key, string value) { }

	// RVA: 0xDD7950 Offset: 0xDD5F50 VA: 0x180DD7950
	internal int get_Count() { }

	// RVA: 0xDD7A10 Offset: 0xDD6010 VA: 0x180DD7A10
	internal bool get_IsRefreshing() { }

	// RVA: 0xDD71F0 Offset: 0xDD57F0 VA: 0x180DD71F0
	private void Reset() { }

	// RVA: 0xDD7170 Offset: 0xDD5770 VA: 0x180DD7170
	private void ReleaseQuery() { }

	// RVA: 0xDD6EE0 Offset: 0xDD54E0 VA: 0x180DD6EE0 Slot: 4
	public void Dispose() { }

	// RVA: 0xDD6F40 Offset: 0xDD5540 VA: 0x180DD6F40
	internal void InvokeChanges() { }

	// RVA: 0xDD7620 Offset: 0xDD5C20 VA: 0x180DD7620
	private void UpdatePending() { }

	// RVA: 0xDD76B0 Offset: 0xDD5CB0 VA: 0x180DD76B0
	public void UpdateResponsive() { }

	// RVA: 0xDD6F60 Offset: 0xDD5560 VA: 0x180DD6F60
	private void MovePendingToUnresponsive() { }

	// RVA: 0xDD6FF0 Offset: 0xDD55F0 VA: 0x180DD6FF0
	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD74C0 Offset: 0xDD5AC0 VA: 0x180DD74C0
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7350 Offset: 0xDD5950 VA: 0x180DD7350
	private bool <MovePendingToUnresponsive>b__34_0(int x) { }

}

private struct Base.<RunQueryAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 5284
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public Base <>4__this; // 0x20
	public float timeoutSeconds; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private HServerListRequest <thisRequest>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1236C0 Offset: 0x122AC0 VA: 0x1801236C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1236D0 Offset: 0x122AD0 VA: 0x1801236D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Base // TypeDefIndex: 6254
{	// Fields
	public string Parent; // 0x10
	public Auth Auth; // 0x18

	// Properties
	public int Version { get; }

	// Methods

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90
	public int get_Version() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

