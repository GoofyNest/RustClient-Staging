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
	|-RVA: 0x1AAADE0 Offset: 0x1AA93E0 VA: 0x181AAADE0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAC720 Offset: 0x1AAAD20 VA: 0x181AAC720
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAB4D0 Offset: 0x1AA9AD0 VA: 0x181AAB4D0
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1AACE70 Offset: 0x1AAB470 VA: 0x181AACE70
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAAB10 Offset: 0x1AA9110 VA: 0x181AAAB10
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1AAB010 Offset: 0x1AA9610 VA: 0x181AAB010
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AACA70 Offset: 0x1AAB070 VA: 0x181AACA70
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAB640 Offset: 0x1AA9C40 VA: 0x181AAB640
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAABD0 Offset: 0x1AA91D0 VA: 0x181AAABD0
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC870 Offset: 0x1AAAE70 VA: 0x181AAC870
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1AACFF0 Offset: 0x1AAB5F0 VA: 0x181AACFF0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAB170 Offset: 0x1AA9770 VA: 0x181AAB170
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AACDD0 Offset: 0x1AAB3D0 VA: 0x181AACDD0
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AAC910 Offset: 0x1AAAF10 VA: 0x181AAC910
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1AACB30 Offset: 0x1AAB130 VA: 0x181AACB30
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AABF10 Offset: 0x1AAA510 VA: 0x181AABF10
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1AAC300 Offset: 0x1AAA900 VA: 0x181AAC300
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1AAD140 Offset: 0x1AAB740 VA: 0x181AAD140
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AABDB0 Offset: 0x1AAA3B0 VA: 0x181AABDB0
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAC240 Offset: 0x1AAA840 VA: 0x181AAC240
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB8F0 Offset: 0x1AA9EF0 VA: 0x181AAB8F0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAF50 Offset: 0x1AA9550 VA: 0x181AAAF50
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC660 Offset: 0x1AAAC60 VA: 0x181AAC660
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1AAB580 Offset: 0x1AA9B80 VA: 0x181AAB580
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAE90 Offset: 0x1AA9490 VA: 0x181AAAE90
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1AAC7D0 Offset: 0x1AAADD0 VA: 0x181AAC7D0
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1AABCF0 Offset: 0x1AAA2F0 VA: 0x181AABCF0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AACBD0 Offset: 0x1AAB1D0 VA: 0x181AACBD0
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1AAB840 Offset: 0x1AA9E40 VA: 0x181AAB840
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1AAC0F0 Offset: 0x1AAA6F0 VA: 0x181AAC0F0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1AAC450 Offset: 0x1AAAA50 VA: 0x181AAC450
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1AAC190 Offset: 0x1AAA790 VA: 0x181AAC190
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAB220 Offset: 0x1AA9820 VA: 0x181AAB220
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAB9A0 Offset: 0x1AA9FA0 VA: 0x181AAB9A0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAC3B0 Offset: 0x1AAA9B0 VA: 0x181AAC3B0
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1AABA50 Offset: 0x1AAA050 VA: 0x181AABA50
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC5B0 Offset: 0x1AAABB0 VA: 0x181AAC5B0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AABB00 Offset: 0x1AAA100 VA: 0x181AABB00
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB390 Offset: 0x1AA9990 VA: 0x181AAB390
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AABFC0 Offset: 0x1AAA5C0 VA: 0x181AABFC0
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAAA60 Offset: 0x1AA9060 VA: 0x181AAAA60
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAAC80 Offset: 0x1AA9280 VA: 0x181AAAC80
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1AAD0A0 Offset: 0x1AAB6A0 VA: 0x181AAD0A0
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABC50 Offset: 0x1AAA250 VA: 0x181AABC50
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAAD40 Offset: 0x1AA9340 VA: 0x181AAAD40
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1AAC500 Offset: 0x1AAAB00 VA: 0x181AAC500
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAB6F0 Offset: 0x1AA9CF0 VA: 0x181AAB6F0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABBA0 Offset: 0x1AAA1A0 VA: 0x181AABBA0
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1AACC70 Offset: 0x1AAB270 VA: 0x181AACC70
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1AACF30 Offset: 0x1AAB530 VA: 0x181AACF30
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1AAB2D0 Offset: 0x1AA98D0 VA: 0x181AAB2D0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1AAB790 Offset: 0x1AA9D90 VA: 0x181AAB790
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1AACD30 Offset: 0x1AAB330 VA: 0x181AACD30
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1AAC9B0 Offset: 0x1AAAFB0 VA: 0x181AAC9B0
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AAB0C0 Offset: 0x1AA96C0 VA: 0x181AAB0C0
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AABE70 Offset: 0x1AAA470 VA: 0x181AABE70
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

