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

	// RVA: 0xDD76C0 Offset: 0xDD5CC0 VA: 0x180DD76C0
	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD75F0 Offset: 0xDD5BF0 VA: 0x180DD75F0
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD77C0 Offset: 0xDD5DC0 VA: 0x180DD77C0
	public void remove_OnChanges(Action value) { }

	// RVA: 0xDD7480 Offset: 0xDD5A80 VA: 0x180DD7480
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0xA25E0 Offset: 0xA19E0 VA: 0x1800A25E0
	// RVA: 0xDD6F90 Offset: 0xDD5590 VA: 0x180DD6F90 Slot: 5
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDD6BF0 Offset: 0xDD51F0 VA: 0x180DD6BF0 Slot: 6
	public virtual void Cancel() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void LaunchQuery();

	// RVA: 0xDD6C30 Offset: 0xDD5230 VA: 0x180DD6C30 Slot: 8
	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	// RVA: 0xDD6B50 Offset: 0xDD5150 VA: 0x180DD6B50
	public void AddFilter(string key, string value) { }

	// RVA: 0xDD7690 Offset: 0xDD5C90 VA: 0x180DD7690
	internal int get_Count() { }

	// RVA: 0xDD7750 Offset: 0xDD5D50 VA: 0x180DD7750
	internal bool get_IsRefreshing() { }

	// RVA: 0xDD6F30 Offset: 0xDD5530 VA: 0x180DD6F30
	private void Reset() { }

	// RVA: 0xDD6EB0 Offset: 0xDD54B0 VA: 0x180DD6EB0
	private void ReleaseQuery() { }

	// RVA: 0xDD6C20 Offset: 0xDD5220 VA: 0x180DD6C20 Slot: 4
	public void Dispose() { }

	// RVA: 0xDD6C80 Offset: 0xDD5280 VA: 0x180DD6C80
	internal void InvokeChanges() { }

	// RVA: 0xDD7360 Offset: 0xDD5960 VA: 0x180DD7360
	private void UpdatePending() { }

	// RVA: 0xDD73F0 Offset: 0xDD59F0 VA: 0x180DD73F0
	public void UpdateResponsive() { }

	// RVA: 0xDD6CA0 Offset: 0xDD52A0 VA: 0x180DD6CA0
	private void MovePendingToUnresponsive() { }

	// RVA: 0xDD6D30 Offset: 0xDD5330 VA: 0x180DD6D30
	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7200 Offset: 0xDD5800 VA: 0x180DD7200
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7090 Offset: 0xDD5690 VA: 0x180DD7090
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

