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

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	public void .ctor(SteamId steamid) { }

	// RVA: 0x1D2E40 Offset: 0x1D2240 VA: 0x1801D2E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D2F00 Offset: 0x1D2300 VA: 0x1801D2F00
	public bool get_IsMe() { }

	// RVA: 0x1D2EE0 Offset: 0x1D22E0 VA: 0x1801D2EE0
	public bool get_IsFriend() { }

	// RVA: 0x1D2F80 Offset: 0x1D2380 VA: 0x1801D2F80
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x1D2F60 Offset: 0x1D2360 VA: 0x1801D2F60
	public bool get_IsOnline() { }

	[AsyncStateMachineAttribute] // RVA: 0x976C0 Offset: 0x96AC0 VA: 0x1800976C0
	// RVA: 0x1D2D80 Offset: 0x1D2180 VA: 0x1801D2D80
	public Task RequestInfoAsync() { }

	// RVA: 0x1D30A0 Offset: 0x1D24A0 VA: 0x1801D30A0
	public Relationship get_Relationship() { }

	// RVA: 0x1D30B0 Offset: 0x1D24B0 VA: 0x1801D30B0
	public FriendState get_State() { }

	// RVA: 0x1D3090 Offset: 0x1D2490 VA: 0x1801D3090
	public string get_Name() { }

	// RVA: 0x1D2EC0 Offset: 0x1D22C0 VA: 0x1801D2EC0
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

	// RVA: 0x1D2D20 Offset: 0x1D2120 VA: 0x1801D2D20
	public IPAddress get_IpAddress() { }

	// RVA: 0x1284AD0 Offset: 0x12830D0 VA: 0x181284AD0
	internal static Friend.FriendGameInfo From(FriendGameInfo_t i) { }

}

private struct Friend.<RequestInfoAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 5238
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Friend <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1DB210 Offset: 0x1DA610 VA: 0x1801DB210 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

