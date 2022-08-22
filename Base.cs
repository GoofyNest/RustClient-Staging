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

	// RVA: 0xDD8430 Offset: 0xDD6A30 VA: 0x180DD8430
	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD8360 Offset: 0xDD6960 VA: 0x180DD8360
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD8530 Offset: 0xDD6B30 VA: 0x180DD8530
	public void remove_OnChanges(Action value) { }

	// RVA: 0xDD81F0 Offset: 0xDD67F0 VA: 0x180DD81F0
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0xA25E0 Offset: 0xA19E0 VA: 0x1800A25E0
	// RVA: 0xDD7D00 Offset: 0xDD6300 VA: 0x180DD7D00 Slot: 5
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDD7960 Offset: 0xDD5F60 VA: 0x180DD7960 Slot: 6
	public virtual void Cancel() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void LaunchQuery();

	// RVA: 0xDD79A0 Offset: 0xDD5FA0 VA: 0x180DD79A0 Slot: 8
	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	// RVA: 0xDD78C0 Offset: 0xDD5EC0 VA: 0x180DD78C0
	public void AddFilter(string key, string value) { }

	// RVA: 0xDD8400 Offset: 0xDD6A00 VA: 0x180DD8400
	internal int get_Count() { }

	// RVA: 0xDD84C0 Offset: 0xDD6AC0 VA: 0x180DD84C0
	internal bool get_IsRefreshing() { }

	// RVA: 0xDD7CA0 Offset: 0xDD62A0 VA: 0x180DD7CA0
	private void Reset() { }

	// RVA: 0xDD7C20 Offset: 0xDD6220 VA: 0x180DD7C20
	private void ReleaseQuery() { }

	// RVA: 0xDD7990 Offset: 0xDD5F90 VA: 0x180DD7990 Slot: 4
	public void Dispose() { }

	// RVA: 0xDD79F0 Offset: 0xDD5FF0 VA: 0x180DD79F0
	internal void InvokeChanges() { }

	// RVA: 0xDD80D0 Offset: 0xDD66D0 VA: 0x180DD80D0
	private void UpdatePending() { }

	// RVA: 0xDD8160 Offset: 0xDD6760 VA: 0x180DD8160
	public void UpdateResponsive() { }

	// RVA: 0xDD7A10 Offset: 0xDD6010 VA: 0x180DD7A10
	private void MovePendingToUnresponsive() { }

	// RVA: 0xDD7AA0 Offset: 0xDD60A0 VA: 0x180DD7AA0
	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7F70 Offset: 0xDD6570 VA: 0x180DD7F70
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDD7E00 Offset: 0xDD6400 VA: 0x180DD7E00
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

	// RVA: 0x1234E0 Offset: 0x1228E0 VA: 0x1801234E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1234F0 Offset: 0x1228F0 VA: 0x1801234F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Base // TypeDefIndex: 6254
{	// Fields
	public string Parent; // 0x10
	public Auth Auth; // 0x18

	// Properties
	public int Version { get; }

	// Methods

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20
	public int get_Version() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

