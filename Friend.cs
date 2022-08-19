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

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public void .ctor(SteamId steamid) { }

	// RVA: 0x1D2EC0 Offset: 0x1D22C0 VA: 0x1801D2EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D2F80 Offset: 0x1D2380 VA: 0x1801D2F80
	public bool get_IsMe() { }

	// RVA: 0x1D2F60 Offset: 0x1D2360 VA: 0x1801D2F60
	public bool get_IsFriend() { }

	// RVA: 0x1D3000 Offset: 0x1D2400 VA: 0x1801D3000
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x1D2FE0 Offset: 0x1D23E0 VA: 0x1801D2FE0
	public bool get_IsOnline() { }

	[AsyncStateMachineAttribute] // RVA: 0x97630 Offset: 0x96A30 VA: 0x180097630
	// RVA: 0x1D2E00 Offset: 0x1D2200 VA: 0x1801D2E00
	public Task RequestInfoAsync() { }

	// RVA: 0x1D3120 Offset: 0x1D2520 VA: 0x1801D3120
	public Relationship get_Relationship() { }

	// RVA: 0x1D3130 Offset: 0x1D2530 VA: 0x1801D3130
	public FriendState get_State() { }

	// RVA: 0x1D3110 Offset: 0x1D2510 VA: 0x1801D3110
	public string get_Name() { }

	// RVA: 0x1D2F40 Offset: 0x1D2340 VA: 0x1801D2F40
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

	// RVA: 0x1D2DA0 Offset: 0x1D21A0 VA: 0x1801D2DA0
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

	// RVA: 0x1DB290 Offset: 0x1DA690 VA: 0x1801DB290 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

