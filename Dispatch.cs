public static class Dispatch // TypeDefIndex: 5104
{	public static Action<CallbackType, string, bool> OnDebugCallback; // 0x0
	public static Action<Exception> OnException; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HSteamPipe <ClientPipe>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HSteamPipe <ServerPipe>k__BackingField; // 0x14
	private static bool runningFrame; // 0x18
	private static List<Action<IntPtr>> actionsToCall; // 0x20
	private static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks; // 0x28
	private static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks; // 0x30

	internal static HSteamPipe ClientPipe { get; set; }
	internal static HSteamPipe ServerPipe { get; }


	internal static extern void SteamAPI_ManualDispatch_Init() { }

	internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe) { }

	internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, ref Dispatch.CallbackMsg_t msg) { }

	internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static HSteamPipe get_ClientPipe() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void set_ClientPipe(HSteamPipe value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static HSteamPipe get_ServerPipe() { }

	internal static void Init() { }

	internal static void Frame(HSteamPipe pipe) { }

	private static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer) { }

	internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize) { }

	private static void ProcessResult(Dispatch.CallbackMsg_t msg) { }

	[AsyncStateMachineAttribute] // RVA: 0x8B3B0 Offset: 0x8A7B0 VA: 0x18008B3B0
	internal static void LoopClientAsync() { }

	internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA450 Offset: 0xCF8A50 VA: 0x180CFA450
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCFA520 Offset: 0xCF8B20 VA: 0x180CFA520
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCFA5F0 Offset: 0xCF8BF0 VA: 0x180CFA5F0
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCFA6C0 Offset: 0xCF8CC0 VA: 0x180CFA6C0
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCFA790 Offset: 0xCF8D90 VA: 0x180CFA790
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCFA860 Offset: 0xCF8E60 VA: 0x180CFA860
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCFA930 Offset: 0xCF8F30 VA: 0x180CFA930
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3380 Offset: 0xCF1980 VA: 0x180CF3380
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCF3580 Offset: 0xCF1B80 VA: 0x180CF3580
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCF3780 Offset: 0xCF1D80 VA: 0x180CF3780
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCF3980 Offset: 0xCF1F80 VA: 0x180CF3980
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCF3BA0 Offset: 0xCF21A0 VA: 0x180CF3BA0
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCF3DC0 Offset: 0xCF23C0 VA: 0x180CF3DC0
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCF3FC0 Offset: 0xCF25C0 VA: 0x180CF3FC0
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCF41E0 Offset: 0xCF27E0 VA: 0x180CF41E0
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCF43E0 Offset: 0xCF29E0 VA: 0x180CF43E0
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCF45E0 Offset: 0xCF2BE0 VA: 0x180CF45E0
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCF47E0 Offset: 0xCF2DE0 VA: 0x180CF47E0
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCF49E0 Offset: 0xCF2FE0 VA: 0x180CF49E0
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCF4BE0 Offset: 0xCF31E0 VA: 0x180CF4BE0
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCF4DE0 Offset: 0xCF33E0 VA: 0x180CF4DE0
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCF4FE0 Offset: 0xCF35E0 VA: 0x180CF4FE0
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCF51E0 Offset: 0xCF37E0 VA: 0x180CF51E0
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCF53E0 Offset: 0xCF39E0 VA: 0x180CF53E0
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCF55E0 Offset: 0xCF3BE0 VA: 0x180CF55E0
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCF57E0 Offset: 0xCF3DE0 VA: 0x180CF57E0
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF5A00 Offset: 0xCF4000 VA: 0x180CF5A00
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF5C20 Offset: 0xCF4220 VA: 0x180CF5C20
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF5E20 Offset: 0xCF4420 VA: 0x180CF5E20
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF6040 Offset: 0xCF4640 VA: 0x180CF6040
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF6260 Offset: 0xCF4860 VA: 0x180CF6260
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF6480 Offset: 0xCF4A80 VA: 0x180CF6480
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF66A0 Offset: 0xCF4CA0 VA: 0x180CF66A0
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF68A0 Offset: 0xCF4EA0 VA: 0x180CF68A0
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF6AC0 Offset: 0xCF50C0 VA: 0x180CF6AC0
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF6CC0 Offset: 0xCF52C0 VA: 0x180CF6CC0
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF6EC0 Offset: 0xCF54C0 VA: 0x180CF6EC0
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF70C0 Offset: 0xCF56C0 VA: 0x180CF70C0
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF72C0 Offset: 0xCF58C0 VA: 0x180CF72C0
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF74C0 Offset: 0xCF5AC0 VA: 0x180CF74C0
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF76C0 Offset: 0xCF5CC0 VA: 0x180CF76C0
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF7960 Offset: 0xCF5F60 VA: 0x180CF7960
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF7B60 Offset: 0xCF6160 VA: 0x180CF7B60
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF7D60 Offset: 0xCF6360 VA: 0x180CF7D60
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF7F60 Offset: 0xCF6560 VA: 0x180CF7F60
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF8160 Offset: 0xCF6760 VA: 0x180CF8160
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF8380 Offset: 0xCF6980 VA: 0x180CF8380
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF85B0 Offset: 0xCF6BB0 VA: 0x180CF85B0
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF87B0 Offset: 0xCF6DB0 VA: 0x180CF87B0
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF89D0 Offset: 0xCF6FD0 VA: 0x180CF89D0
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF8BD0 Offset: 0xCF71D0 VA: 0x180CF8BD0
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF8DD0 Offset: 0xCF73D0 VA: 0x180CF8DD0
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF8FD0 Offset: 0xCF75D0 VA: 0x180CF8FD0
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF91D0 Offset: 0xCF77D0 VA: 0x180CF91D0
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF93D0 Offset: 0xCF79D0 VA: 0x180CF93D0
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF95D0 Offset: 0xCF7BD0 VA: 0x180CF95D0
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF97F0 Offset: 0xCF7DF0 VA: 0x180CF97F0
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF9A10 Offset: 0xCF8010 VA: 0x180CF9A10
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF9C30 Offset: 0xCF8230 VA: 0x180CF9C30
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF9E30 Offset: 0xCF8430 VA: 0x180CF9E30
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCFA030 Offset: 0xCF8630 VA: 0x180CFA030
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCFA250 Offset: 0xCF8850 VA: 0x180CFA250
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF78C0 Offset: 0xCF5EC0 VA: 0x180CF78C0
	|-Dispatch.Install<object>
	*/

	internal static void ShutdownClient() { }

	private static void .cctor() { }

}

internal struct Dispatch.CallbackMsg_t // TypeDefIndex: 5105
{	public HSteamUser m_hSteamUser; // 0x0
	public CallbackType Type; // 0x4
	public IntPtr Data; // 0x8
	public int DataSize; // 0x10

}

private struct Dispatch.ResultCallback // TypeDefIndex: 5106
{	public Action continuation; // 0x0
	public bool server; // 0x8

}

private struct Dispatch.Callback // TypeDefIndex: 5107
{	public Action<IntPtr> action; // 0x0
	public bool server; // 0x8

}

private sealed class Dispatch.<>c // TypeDefIndex: 5108
{	public static readonly Dispatch.<>c <>9; // 0x0
	public static Func<FieldInfo, int> <>9__20_0; // 0x8
	public static Predicate<Dispatch.Callback> <>9__31_3; // 0x10
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> <>9__31_0; // 0x18
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> <>9__31_1; // 0x20
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> <>9__31_2; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CallbackToString>b__20_0(FieldInfo x) { }

	internal bool <ShutdownClient>b__31_3(Dispatch.Callback x) { }

	internal bool <ShutdownClient>b__31_0(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	internal ulong <ShutdownClient>b__31_1(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	internal Dispatch.ResultCallback <ShutdownClient>b__31_2(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

}

private struct Dispatch.<LoopClientAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5109
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Dispatch.<>c__DisplayClass29_0<T> // TypeDefIndex: 5110
{	public Action<T> p; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
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

	internal void <Install>b__0(IntPtr x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAADA0 Offset: 0x1AA93A0 VA: 0x181AAADA0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAC6E0 Offset: 0x1AAACE0 VA: 0x181AAC6E0
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAB490 Offset: 0x1AA9A90 VA: 0x181AAB490
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1AACE30 Offset: 0x1AAB430 VA: 0x181AACE30
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAAAD0 Offset: 0x1AA90D0 VA: 0x181AAAAD0
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1AAAFD0 Offset: 0x1AA95D0 VA: 0x181AAAFD0
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AACA30 Offset: 0x1AAB030 VA: 0x181AACA30
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAB600 Offset: 0x1AA9C00 VA: 0x181AAB600
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAAB90 Offset: 0x1AA9190 VA: 0x181AAAB90
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC830 Offset: 0x1AAAE30 VA: 0x181AAC830
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1AACFB0 Offset: 0x1AAB5B0 VA: 0x181AACFB0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAB130 Offset: 0x1AA9730 VA: 0x181AAB130
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AACD90 Offset: 0x1AAB390 VA: 0x181AACD90
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AAC8D0 Offset: 0x1AAAED0 VA: 0x181AAC8D0
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1AACAF0 Offset: 0x1AAB0F0 VA: 0x181AACAF0
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AABED0 Offset: 0x1AAA4D0 VA: 0x181AABED0
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1AAC2C0 Offset: 0x1AAA8C0 VA: 0x181AAC2C0
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1AAD100 Offset: 0x1AAB700 VA: 0x181AAD100
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AABD70 Offset: 0x1AAA370 VA: 0x181AABD70
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAC200 Offset: 0x1AAA800 VA: 0x181AAC200
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB8B0 Offset: 0x1AA9EB0 VA: 0x181AAB8B0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAF10 Offset: 0x1AA9510 VA: 0x181AAAF10
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC620 Offset: 0x1AAAC20 VA: 0x181AAC620
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1AAB540 Offset: 0x1AA9B40 VA: 0x181AAB540
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAE50 Offset: 0x1AA9450 VA: 0x181AAAE50
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1AAC790 Offset: 0x1AAAD90 VA: 0x181AAC790
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1AABCB0 Offset: 0x1AAA2B0 VA: 0x181AABCB0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AACB90 Offset: 0x1AAB190 VA: 0x181AACB90
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1AAB800 Offset: 0x1AA9E00 VA: 0x181AAB800
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1AAC0B0 Offset: 0x1AAA6B0 VA: 0x181AAC0B0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1AAC410 Offset: 0x1AAAA10 VA: 0x181AAC410
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1AAC150 Offset: 0x1AAA750 VA: 0x181AAC150
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAB1E0 Offset: 0x1AA97E0 VA: 0x181AAB1E0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAB960 Offset: 0x1AA9F60 VA: 0x181AAB960
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAC370 Offset: 0x1AAA970 VA: 0x181AAC370
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1AABA10 Offset: 0x1AAA010 VA: 0x181AABA10
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC570 Offset: 0x1AAAB70 VA: 0x181AAC570
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AABAC0 Offset: 0x1AAA0C0 VA: 0x181AABAC0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB350 Offset: 0x1AA9950 VA: 0x181AAB350
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AABF80 Offset: 0x1AAA580 VA: 0x181AABF80
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAAA20 Offset: 0x1AA9020 VA: 0x181AAAA20
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAAC40 Offset: 0x1AA9240 VA: 0x181AAAC40
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1AAD060 Offset: 0x1AAB660 VA: 0x181AAD060
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABC10 Offset: 0x1AAA210 VA: 0x181AABC10
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAAD00 Offset: 0x1AA9300 VA: 0x181AAAD00
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1AAC4C0 Offset: 0x1AAAAC0 VA: 0x181AAC4C0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAB6B0 Offset: 0x1AA9CB0 VA: 0x181AAB6B0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABB60 Offset: 0x1AAA160 VA: 0x181AABB60
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1AACC30 Offset: 0x1AAB230 VA: 0x181AACC30
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1AACEF0 Offset: 0x1AAB4F0 VA: 0x181AACEF0
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1AAB290 Offset: 0x1AA9890 VA: 0x181AAB290
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1AAB750 Offset: 0x1AA9D50 VA: 0x181AAB750
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1AACCF0 Offset: 0x1AAB2F0 VA: 0x181AACCF0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1AAC970 Offset: 0x1AAAF70 VA: 0x181AAC970
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AAB080 Offset: 0x1AA9680 VA: 0x181AAB080
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AABE30 Offset: 0x1AAA430 VA: 0x181AABE30
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

