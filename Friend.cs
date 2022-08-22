public struct Friend // TypeDefIndex: 5236
{	// Fields
	public SteamId Id; // 0x0

	// Properties
	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public bool IsOnline { get; }
	public Relationship Relationship { get; }
	public FriendState State { get; }
	public string Name { get; }
	public Nullable<Friend.FriendGameInfo> GameInfo { get; }

	// Methods

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(SteamId steamid) { }

	// RVA: 0x1D34B0 Offset: 0x1D28B0 VA: 0x1801D34B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D3570 Offset: 0x1D2970 VA: 0x1801D3570
	public bool get_IsMe() { }

	// RVA: 0x1D3550 Offset: 0x1D2950 VA: 0x1801D3550
	public bool get_IsFriend() { }

	// RVA: 0x1D35F0 Offset: 0x1D29F0 VA: 0x1801D35F0
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x1D35D0 Offset: 0x1D29D0 VA: 0x1801D35D0
	public bool get_IsOnline() { }

	[AsyncStateMachineAttribute] // RVA: 0x976C0 Offset: 0x96AC0 VA: 0x1800976C0
	// RVA: 0x1D33F0 Offset: 0x1D27F0 VA: 0x1801D33F0
	public Task RequestInfoAsync() { }

	// RVA: 0x1D3710 Offset: 0x1D2B10 VA: 0x1801D3710
	public Relationship get_Relationship() { }

	// RVA: 0x1D3720 Offset: 0x1D2B20 VA: 0x1801D3720
	public FriendState get_State() { }

	// RVA: 0x1D3700 Offset: 0x1D2B00 VA: 0x1801D3700
	public string get_Name() { }

	// RVA: 0x1D3530 Offset: 0x1D2930 VA: 0x1801D3530
	public Nullable<Friend.FriendGameInfo> get_GameInfo() { }

}

public struct Friend.FriendGameInfo // TypeDefIndex: 5237
{	// Fields
	internal ulong GameID; // 0x0
	internal uint GameIP; // 0x8
	internal ulong SteamIDLobby; // 0x10
	public int ConnectionPort; // 0x18
	public int QueryPort; // 0x1C

	// Properties
	public IPAddress IpAddress { get; }

	// Methods

	// RVA: 0x1D3390 Offset: 0x1D2790 VA: 0x1801D3390
	public IPAddress get_IpAddress() { }

	// RVA: 0x1285430 Offset: 0x1283A30 VA: 0x181285430
	internal static Friend.FriendGameInfo From(FriendGameInfo_t i) { }

}

private struct Friend.<RequestInfoAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 5238
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Friend <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1DB880 Offset: 0x1DAC80 VA: 0x1801DB880 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

