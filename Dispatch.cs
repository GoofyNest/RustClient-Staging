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
	|-RVA: 0xCFA490 Offset: 0xCF8A90 VA: 0x180CFA490
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCFA560 Offset: 0xCF8B60 VA: 0x180CFA560
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCFA630 Offset: 0xCF8C30 VA: 0x180CFA630
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCFA700 Offset: 0xCF8D00 VA: 0x180CFA700
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCFA7D0 Offset: 0xCF8DD0 VA: 0x180CFA7D0
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCFA8A0 Offset: 0xCF8EA0 VA: 0x180CFA8A0
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCFA970 Offset: 0xCF8F70 VA: 0x180CFA970
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF33C0 Offset: 0xCF19C0 VA: 0x180CF33C0
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCF35C0 Offset: 0xCF1BC0 VA: 0x180CF35C0
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCF37C0 Offset: 0xCF1DC0 VA: 0x180CF37C0
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCF39C0 Offset: 0xCF1FC0 VA: 0x180CF39C0
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCF3BE0 Offset: 0xCF21E0 VA: 0x180CF3BE0
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCF3E00 Offset: 0xCF2400 VA: 0x180CF3E00
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCF4000 Offset: 0xCF2600 VA: 0x180CF4000
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCF4220 Offset: 0xCF2820 VA: 0x180CF4220
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCF4420 Offset: 0xCF2A20 VA: 0x180CF4420
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCF4620 Offset: 0xCF2C20 VA: 0x180CF4620
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCF4820 Offset: 0xCF2E20 VA: 0x180CF4820
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCF4A20 Offset: 0xCF3020 VA: 0x180CF4A20
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCF4C20 Offset: 0xCF3220 VA: 0x180CF4C20
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCF4E20 Offset: 0xCF3420 VA: 0x180CF4E20
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCF5020 Offset: 0xCF3620 VA: 0x180CF5020
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCF5220 Offset: 0xCF3820 VA: 0x180CF5220
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCF5420 Offset: 0xCF3A20 VA: 0x180CF5420
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCF5620 Offset: 0xCF3C20 VA: 0x180CF5620
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCF5820 Offset: 0xCF3E20 VA: 0x180CF5820
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF5A40 Offset: 0xCF4040 VA: 0x180CF5A40
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF5C60 Offset: 0xCF4260 VA: 0x180CF5C60
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF5E60 Offset: 0xCF4460 VA: 0x180CF5E60
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF6080 Offset: 0xCF4680 VA: 0x180CF6080
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF62A0 Offset: 0xCF48A0 VA: 0x180CF62A0
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF64C0 Offset: 0xCF4AC0 VA: 0x180CF64C0
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF66E0 Offset: 0xCF4CE0 VA: 0x180CF66E0
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF68E0 Offset: 0xCF4EE0 VA: 0x180CF68E0
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF6B00 Offset: 0xCF5100 VA: 0x180CF6B00
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF6D00 Offset: 0xCF5300 VA: 0x180CF6D00
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF6F00 Offset: 0xCF5500 VA: 0x180CF6F00
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF7100 Offset: 0xCF5700 VA: 0x180CF7100
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF7300 Offset: 0xCF5900 VA: 0x180CF7300
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF7500 Offset: 0xCF5B00 VA: 0x180CF7500
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF7700 Offset: 0xCF5D00 VA: 0x180CF7700
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF79A0 Offset: 0xCF5FA0 VA: 0x180CF79A0
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF7BA0 Offset: 0xCF61A0 VA: 0x180CF7BA0
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF7DA0 Offset: 0xCF63A0 VA: 0x180CF7DA0
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF7FA0 Offset: 0xCF65A0 VA: 0x180CF7FA0
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF81A0 Offset: 0xCF67A0 VA: 0x180CF81A0
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF83C0 Offset: 0xCF69C0 VA: 0x180CF83C0
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF85F0 Offset: 0xCF6BF0 VA: 0x180CF85F0
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF87F0 Offset: 0xCF6DF0 VA: 0x180CF87F0
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF8A10 Offset: 0xCF7010 VA: 0x180CF8A10
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF8C10 Offset: 0xCF7210 VA: 0x180CF8C10
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF8E10 Offset: 0xCF7410 VA: 0x180CF8E10
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF9010 Offset: 0xCF7610 VA: 0x180CF9010
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF9210 Offset: 0xCF7810 VA: 0x180CF9210
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF9410 Offset: 0xCF7A10 VA: 0x180CF9410
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF9610 Offset: 0xCF7C10 VA: 0x180CF9610
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF9830 Offset: 0xCF7E30 VA: 0x180CF9830
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF9A50 Offset: 0xCF8050 VA: 0x180CF9A50
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF9C70 Offset: 0xCF8270 VA: 0x180CF9C70
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF9E70 Offset: 0xCF8470 VA: 0x180CF9E70
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCFA070 Offset: 0xCF8670 VA: 0x180CFA070
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCFA290 Offset: 0xCF8890 VA: 0x180CFA290
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF7900 Offset: 0xCF5F00 VA: 0x180CF7900
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
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
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
	|-RVA: 0x1AAACE0 Offset: 0x1AA92E0 VA: 0x181AAACE0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAC620 Offset: 0x1AAAC20 VA: 0x181AAC620
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAB3D0 Offset: 0x1AA99D0 VA: 0x181AAB3D0
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1AACD70 Offset: 0x1AAB370 VA: 0x181AACD70
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAAA10 Offset: 0x1AA9010 VA: 0x181AAAA10
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1AAAF10 Offset: 0x1AA9510 VA: 0x181AAAF10
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC970 Offset: 0x1AAAF70 VA: 0x181AAC970
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAB540 Offset: 0x1AA9B40 VA: 0x181AAB540
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAAAD0 Offset: 0x1AA90D0 VA: 0x181AAAAD0
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC770 Offset: 0x1AAAD70 VA: 0x181AAC770
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1AACEF0 Offset: 0x1AAB4F0 VA: 0x181AACEF0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAB070 Offset: 0x1AA9670 VA: 0x181AAB070
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AACCD0 Offset: 0x1AAB2D0 VA: 0x181AACCD0
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AAC810 Offset: 0x1AAAE10 VA: 0x181AAC810
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1AACA30 Offset: 0x1AAB030 VA: 0x181AACA30
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AABE10 Offset: 0x1AAA410 VA: 0x181AABE10
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1AAC200 Offset: 0x1AAA800 VA: 0x181AAC200
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1AAD040 Offset: 0x1AAB640 VA: 0x181AAD040
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AABCB0 Offset: 0x1AAA2B0 VA: 0x181AABCB0
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAC140 Offset: 0x1AAA740 VA: 0x181AAC140
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB7F0 Offset: 0x1AA9DF0 VA: 0x181AAB7F0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAE50 Offset: 0x1AA9450 VA: 0x181AAAE50
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC560 Offset: 0x1AAAB60 VA: 0x181AAC560
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1AAB480 Offset: 0x1AA9A80 VA: 0x181AAB480
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAD90 Offset: 0x1AA9390 VA: 0x181AAAD90
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1AAC6D0 Offset: 0x1AAACD0 VA: 0x181AAC6D0
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1AABBF0 Offset: 0x1AAA1F0 VA: 0x181AABBF0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AACAD0 Offset: 0x1AAB0D0 VA: 0x181AACAD0
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1AAB740 Offset: 0x1AA9D40 VA: 0x181AAB740
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1AABFF0 Offset: 0x1AAA5F0 VA: 0x181AABFF0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1AAC350 Offset: 0x1AAA950 VA: 0x181AAC350
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1AAC090 Offset: 0x1AAA690 VA: 0x181AAC090
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAB120 Offset: 0x1AA9720 VA: 0x181AAB120
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAB8A0 Offset: 0x1AA9EA0 VA: 0x181AAB8A0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAC2B0 Offset: 0x1AAA8B0 VA: 0x181AAC2B0
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1AAB950 Offset: 0x1AA9F50 VA: 0x181AAB950
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC4B0 Offset: 0x1AAAAB0 VA: 0x181AAC4B0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AABA00 Offset: 0x1AAA000 VA: 0x181AABA00
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB290 Offset: 0x1AA9890 VA: 0x181AAB290
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AABEC0 Offset: 0x1AAA4C0 VA: 0x181AABEC0
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAA960 Offset: 0x1AA8F60 VA: 0x181AAA960
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAAB80 Offset: 0x1AA9180 VA: 0x181AAAB80
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1AACFA0 Offset: 0x1AAB5A0 VA: 0x181AACFA0
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABB50 Offset: 0x1AAA150 VA: 0x181AABB50
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAAC40 Offset: 0x1AA9240 VA: 0x181AAAC40
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1AAC400 Offset: 0x1AAAA00 VA: 0x181AAC400
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAB5F0 Offset: 0x1AA9BF0 VA: 0x181AAB5F0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABAA0 Offset: 0x1AAA0A0 VA: 0x181AABAA0
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1AACB70 Offset: 0x1AAB170 VA: 0x181AACB70
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1AACE30 Offset: 0x1AAB430 VA: 0x181AACE30
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1AAB1D0 Offset: 0x1AA97D0 VA: 0x181AAB1D0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1AAB690 Offset: 0x1AA9C90 VA: 0x181AAB690
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1AACC30 Offset: 0x1AAB230 VA: 0x181AACC30
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1AAC8B0 Offset: 0x1AAAEB0 VA: 0x181AAC8B0
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AAAFC0 Offset: 0x1AA95C0 VA: 0x181AAAFC0
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AABD70 Offset: 0x1AAA370 VA: 0x181AABD70
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

