public static class Dispatch // TypeDefIndex: 5104
{	// Fields
	public static Action<CallbackType, string, bool> OnDebugCallback; // 0x0
	public static Action<Exception> OnException; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HSteamPipe <ClientPipe>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HSteamPipe <ServerPipe>k__BackingField; // 0x14
	private static bool runningFrame; // 0x18
	private static List<Action<IntPtr>> actionsToCall; // 0x20
	private static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks; // 0x28
	private static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks; // 0x30

	// Properties
	internal static HSteamPipe ClientPipe { get; set; }
	internal static HSteamPipe ServerPipe { get; }

	// Methods

	// RVA: 0x1284850 Offset: 0x1282E50 VA: 0x181284850
	internal static extern void SteamAPI_ManualDispatch_Init() { }

	// RVA: 0x12848C0 Offset: 0x1282EC0 VA: 0x1812848C0
	internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe) { }

	// RVA: 0x12847C0 Offset: 0x1282DC0 VA: 0x1812847C0
	internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, ref Dispatch.CallbackMsg_t msg) { }

	// RVA: 0x1284740 Offset: 0x1282D40 VA: 0x181284740
	internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1284A30 Offset: 0x1283030 VA: 0x181284A30
	internal static HSteamPipe get_ClientPipe() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1284B50 Offset: 0x1283150 VA: 0x181284B50
	internal static void set_ClientPipe(HSteamPipe value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1284A90 Offset: 0x1283090 VA: 0x181284A90
	internal static HSteamPipe get_ServerPipe() { }

	// RVA: 0x1283920 Offset: 0x1281F20 VA: 0x181283920
	internal static void Init() { }

	// RVA: 0x1283510 Offset: 0x1281B10 VA: 0x181283510
	internal static void Frame(HSteamPipe pipe) { }

	// RVA: 0x1283A50 Offset: 0x1282050 VA: 0x181283A50
	private static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer) { }

	// RVA: 0x1283180 Offset: 0x1281780 VA: 0x181283180
	internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize) { }

	// RVA: 0x1284050 Offset: 0x1282650 VA: 0x181284050
	private static void ProcessResult(Dispatch.CallbackMsg_t msg) { }

	[AsyncStateMachineAttribute] // RVA: 0x8B3B0 Offset: 0x8A7B0 VA: 0x18008B3B0
	// RVA: 0x12839D0 Offset: 0x1281FD0 VA: 0x1812839D0
	internal static void LoopClientAsync() { }

	// RVA: -1 Offset: -1
	internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9EB0 Offset: 0xCF84B0 VA: 0x180CF9EB0
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCF9F80 Offset: 0xCF8580 VA: 0x180CF9F80
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCFA050 Offset: 0xCF8650 VA: 0x180CFA050
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCFA120 Offset: 0xCF8720 VA: 0x180CFA120
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCFA1F0 Offset: 0xCF87F0 VA: 0x180CFA1F0
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCFA2C0 Offset: 0xCF88C0 VA: 0x180CFA2C0
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCFA390 Offset: 0xCF8990 VA: 0x180CFA390
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	// RVA: -1 Offset: -1
	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2DE0 Offset: 0xCF13E0 VA: 0x180CF2DE0
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCF2FE0 Offset: 0xCF15E0 VA: 0x180CF2FE0
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCF31E0 Offset: 0xCF17E0 VA: 0x180CF31E0
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCF33E0 Offset: 0xCF19E0 VA: 0x180CF33E0
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCF3600 Offset: 0xCF1C00 VA: 0x180CF3600
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCF3820 Offset: 0xCF1E20 VA: 0x180CF3820
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCF3A20 Offset: 0xCF2020 VA: 0x180CF3A20
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCF3C40 Offset: 0xCF2240 VA: 0x180CF3C40
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCF3E40 Offset: 0xCF2440 VA: 0x180CF3E40
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCF4040 Offset: 0xCF2640 VA: 0x180CF4040
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCF4240 Offset: 0xCF2840 VA: 0x180CF4240
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCF4440 Offset: 0xCF2A40 VA: 0x180CF4440
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCF4640 Offset: 0xCF2C40 VA: 0x180CF4640
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCF4840 Offset: 0xCF2E40 VA: 0x180CF4840
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCF4A40 Offset: 0xCF3040 VA: 0x180CF4A40
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCF4C40 Offset: 0xCF3240 VA: 0x180CF4C40
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCF4E40 Offset: 0xCF3440 VA: 0x180CF4E40
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCF5040 Offset: 0xCF3640 VA: 0x180CF5040
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCF5240 Offset: 0xCF3840 VA: 0x180CF5240
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF5460 Offset: 0xCF3A60 VA: 0x180CF5460
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF5680 Offset: 0xCF3C80 VA: 0x180CF5680
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF5880 Offset: 0xCF3E80 VA: 0x180CF5880
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF5AA0 Offset: 0xCF40A0 VA: 0x180CF5AA0
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF5CC0 Offset: 0xCF42C0 VA: 0x180CF5CC0
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF5EE0 Offset: 0xCF44E0 VA: 0x180CF5EE0
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF6100 Offset: 0xCF4700 VA: 0x180CF6100
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF6300 Offset: 0xCF4900 VA: 0x180CF6300
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF6520 Offset: 0xCF4B20 VA: 0x180CF6520
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF6720 Offset: 0xCF4D20 VA: 0x180CF6720
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF6920 Offset: 0xCF4F20 VA: 0x180CF6920
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF6B20 Offset: 0xCF5120 VA: 0x180CF6B20
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF6D20 Offset: 0xCF5320 VA: 0x180CF6D20
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF6F20 Offset: 0xCF5520 VA: 0x180CF6F20
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF7120 Offset: 0xCF5720 VA: 0x180CF7120
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF73C0 Offset: 0xCF59C0 VA: 0x180CF73C0
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF75C0 Offset: 0xCF5BC0 VA: 0x180CF75C0
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF77C0 Offset: 0xCF5DC0 VA: 0x180CF77C0
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF79C0 Offset: 0xCF5FC0 VA: 0x180CF79C0
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF7BC0 Offset: 0xCF61C0 VA: 0x180CF7BC0
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF7DE0 Offset: 0xCF63E0 VA: 0x180CF7DE0
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF8010 Offset: 0xCF6610 VA: 0x180CF8010
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF8210 Offset: 0xCF6810 VA: 0x180CF8210
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF8430 Offset: 0xCF6A30 VA: 0x180CF8430
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF8630 Offset: 0xCF6C30 VA: 0x180CF8630
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF8830 Offset: 0xCF6E30 VA: 0x180CF8830
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF8A30 Offset: 0xCF7030 VA: 0x180CF8A30
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF8C30 Offset: 0xCF7230 VA: 0x180CF8C30
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF8E30 Offset: 0xCF7430 VA: 0x180CF8E30
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF9030 Offset: 0xCF7630 VA: 0x180CF9030
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF9250 Offset: 0xCF7850 VA: 0x180CF9250
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF9470 Offset: 0xCF7A70 VA: 0x180CF9470
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF9690 Offset: 0xCF7C90 VA: 0x180CF9690
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF9890 Offset: 0xCF7E90 VA: 0x180CF9890
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCF9A90 Offset: 0xCF8090 VA: 0x180CF9A90
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCF9CB0 Offset: 0xCF82B0 VA: 0x180CF9CB0
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF7320 Offset: 0xCF5920 VA: 0x180CF7320
	|-Dispatch.Install<object>
	*/

	// RVA: 0x12841E0 Offset: 0x12827E0 VA: 0x1812841E0
	internal static void ShutdownClient() { }

	// RVA: 0x1284940 Offset: 0x1282F40 VA: 0x181284940
	private static void .cctor() { }

}

internal struct Dispatch.CallbackMsg_t // TypeDefIndex: 5105
{	// Fields
	public HSteamUser m_hSteamUser; // 0x0
	public CallbackType Type; // 0x4
	public IntPtr Data; // 0x8
	public int DataSize; // 0x10

}

private struct Dispatch.ResultCallback // TypeDefIndex: 5106
{	// Fields
	public Action continuation; // 0x0
	public bool server; // 0x8

}

private struct Dispatch.Callback // TypeDefIndex: 5107
{	// Fields
	public Action<IntPtr> action; // 0x0
	public bool server; // 0x8

}

private sealed class Dispatch.<>c // TypeDefIndex: 5108
{	// Fields
	public static readonly Dispatch.<>c <>9; // 0x0
	public static Func<FieldInfo, int> <>9__20_0; // 0x8
	public static Predicate<Dispatch.Callback> <>9__31_3; // 0x10
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> <>9__31_0; // 0x18
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> <>9__31_1; // 0x20
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> <>9__31_2; // 0x28

	// Methods

	// RVA: 0x1291BA0 Offset: 0x12901A0 VA: 0x181291BA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1291A80 Offset: 0x1290080 VA: 0x181291A80
	internal int <CallbackToString>b__20_0(FieldInfo x) { }

	// RVA: 0x1291B80 Offset: 0x1290180 VA: 0x181291B80
	internal bool <ShutdownClient>b__31_3(Dispatch.Callback x) { }

	// RVA: 0x1291AC0 Offset: 0x12900C0 VA: 0x181291AC0
	internal bool <ShutdownClient>b__31_0(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	// RVA: 0x1291B00 Offset: 0x1290100 VA: 0x181291B00
	internal ulong <ShutdownClient>b__31_1(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	// RVA: 0x1291B40 Offset: 0x1290140 VA: 0x181291B40
	internal Dispatch.ResultCallback <ShutdownClient>b__31_2(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

}

private struct Dispatch.<LoopClientAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5109
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1DB1A0 Offset: 0x1DA5A0 VA: 0x1801DB1A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Dispatch.<>c__DisplayClass29_0<T> // TypeDefIndex: 5110
{	// Fields
	public Action<T> p; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Install>b__0(IntPtr x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A510B0 Offset: 0x1A4F6B0 VA: 0x181A510B0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A529F0 Offset: 0x1A50FF0 VA: 0x181A529F0
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A517A0 Offset: 0x1A4FDA0 VA: 0x181A517A0
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1A53140 Offset: 0x1A51740 VA: 0x181A53140
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1A50DE0 Offset: 0x1A4F3E0 VA: 0x181A50DE0
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1A512E0 Offset: 0x1A4F8E0 VA: 0x181A512E0
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A52D40 Offset: 0x1A51340 VA: 0x181A52D40
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A51910 Offset: 0x1A4FF10 VA: 0x181A51910
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A50EA0 Offset: 0x1A4F4A0 VA: 0x181A50EA0
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A52B40 Offset: 0x1A51140 VA: 0x181A52B40
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1A532C0 Offset: 0x1A518C0 VA: 0x181A532C0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A51440 Offset: 0x1A4FA40 VA: 0x181A51440
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A530A0 Offset: 0x1A516A0 VA: 0x181A530A0
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A52BE0 Offset: 0x1A511E0 VA: 0x181A52BE0
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1A52E00 Offset: 0x1A51400 VA: 0x181A52E00
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A521E0 Offset: 0x1A507E0 VA: 0x181A521E0
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1A525D0 Offset: 0x1A50BD0 VA: 0x181A525D0
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1A53410 Offset: 0x1A51A10 VA: 0x181A53410
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A52080 Offset: 0x1A50680 VA: 0x181A52080
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A52510 Offset: 0x1A50B10 VA: 0x181A52510
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A51BC0 Offset: 0x1A501C0 VA: 0x181A51BC0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A51220 Offset: 0x1A4F820 VA: 0x181A51220
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A52930 Offset: 0x1A50F30 VA: 0x181A52930
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1A51850 Offset: 0x1A4FE50 VA: 0x181A51850
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A51160 Offset: 0x1A4F760 VA: 0x181A51160
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1A52AA0 Offset: 0x1A510A0 VA: 0x181A52AA0
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1A51FC0 Offset: 0x1A505C0 VA: 0x181A51FC0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A52EA0 Offset: 0x1A514A0 VA: 0x181A52EA0
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1A51B10 Offset: 0x1A50110 VA: 0x181A51B10
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1A523C0 Offset: 0x1A509C0 VA: 0x181A523C0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1A52720 Offset: 0x1A50D20 VA: 0x181A52720
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1A52460 Offset: 0x1A50A60 VA: 0x181A52460
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A514F0 Offset: 0x1A4FAF0 VA: 0x181A514F0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A51C70 Offset: 0x1A50270 VA: 0x181A51C70
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A52680 Offset: 0x1A50C80 VA: 0x181A52680
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1A51D20 Offset: 0x1A50320 VA: 0x181A51D20
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A52880 Offset: 0x1A50E80 VA: 0x181A52880
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A51DD0 Offset: 0x1A503D0 VA: 0x181A51DD0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A51660 Offset: 0x1A4FC60 VA: 0x181A51660
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A52290 Offset: 0x1A50890 VA: 0x181A52290
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1A50D30 Offset: 0x1A4F330 VA: 0x181A50D30
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A50F50 Offset: 0x1A4F550 VA: 0x181A50F50
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1A53370 Offset: 0x1A51970 VA: 0x181A53370
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51F20 Offset: 0x1A50520 VA: 0x181A51F20
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51010 Offset: 0x1A4F610 VA: 0x181A51010
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1A527D0 Offset: 0x1A50DD0 VA: 0x181A527D0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A519C0 Offset: 0x1A4FFC0 VA: 0x181A519C0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51E70 Offset: 0x1A50470 VA: 0x181A51E70
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1A52F40 Offset: 0x1A51540 VA: 0x181A52F40
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1A53200 Offset: 0x1A51800 VA: 0x181A53200
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1A515A0 Offset: 0x1A4FBA0 VA: 0x181A515A0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1A51A60 Offset: 0x1A50060 VA: 0x181A51A60
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1A53000 Offset: 0x1A51600 VA: 0x181A53000
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1A52C80 Offset: 0x1A51280 VA: 0x181A52C80
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A51390 Offset: 0x1A4F990 VA: 0x181A51390
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A52140 Offset: 0x1A50740 VA: 0x181A52140
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

