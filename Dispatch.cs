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
	|-RVA: 0xCFA350 Offset: 0xCF8950 VA: 0x180CFA350
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCFA420 Offset: 0xCF8A20 VA: 0x180CFA420
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCFA4F0 Offset: 0xCF8AF0 VA: 0x180CFA4F0
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCFA5C0 Offset: 0xCF8BC0 VA: 0x180CFA5C0
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCFA690 Offset: 0xCF8C90 VA: 0x180CFA690
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCFA760 Offset: 0xCF8D60 VA: 0x180CFA760
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCFA830 Offset: 0xCF8E30 VA: 0x180CFA830
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3280 Offset: 0xCF1880 VA: 0x180CF3280
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCF3480 Offset: 0xCF1A80 VA: 0x180CF3480
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCF3680 Offset: 0xCF1C80 VA: 0x180CF3680
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCF3880 Offset: 0xCF1E80 VA: 0x180CF3880
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCF3AA0 Offset: 0xCF20A0 VA: 0x180CF3AA0
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCF3CC0 Offset: 0xCF22C0 VA: 0x180CF3CC0
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCF3EC0 Offset: 0xCF24C0 VA: 0x180CF3EC0
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCF40E0 Offset: 0xCF26E0 VA: 0x180CF40E0
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCF42E0 Offset: 0xCF28E0 VA: 0x180CF42E0
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCF44E0 Offset: 0xCF2AE0 VA: 0x180CF44E0
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCF46E0 Offset: 0xCF2CE0 VA: 0x180CF46E0
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCF48E0 Offset: 0xCF2EE0 VA: 0x180CF48E0
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCF4AE0 Offset: 0xCF30E0 VA: 0x180CF4AE0
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCF4CE0 Offset: 0xCF32E0 VA: 0x180CF4CE0
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCF4EE0 Offset: 0xCF34E0 VA: 0x180CF4EE0
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCF50E0 Offset: 0xCF36E0 VA: 0x180CF50E0
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCF52E0 Offset: 0xCF38E0 VA: 0x180CF52E0
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCF54E0 Offset: 0xCF3AE0 VA: 0x180CF54E0
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCF56E0 Offset: 0xCF3CE0 VA: 0x180CF56E0
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF5900 Offset: 0xCF3F00 VA: 0x180CF5900
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF5B20 Offset: 0xCF4120 VA: 0x180CF5B20
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF5D20 Offset: 0xCF4320 VA: 0x180CF5D20
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF5F40 Offset: 0xCF4540 VA: 0x180CF5F40
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF6160 Offset: 0xCF4760 VA: 0x180CF6160
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF6380 Offset: 0xCF4980 VA: 0x180CF6380
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF65A0 Offset: 0xCF4BA0 VA: 0x180CF65A0
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF67A0 Offset: 0xCF4DA0 VA: 0x180CF67A0
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF69C0 Offset: 0xCF4FC0 VA: 0x180CF69C0
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF6BC0 Offset: 0xCF51C0 VA: 0x180CF6BC0
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF6DC0 Offset: 0xCF53C0 VA: 0x180CF6DC0
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF6FC0 Offset: 0xCF55C0 VA: 0x180CF6FC0
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF71C0 Offset: 0xCF57C0 VA: 0x180CF71C0
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF73C0 Offset: 0xCF59C0 VA: 0x180CF73C0
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF75C0 Offset: 0xCF5BC0 VA: 0x180CF75C0
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF7860 Offset: 0xCF5E60 VA: 0x180CF7860
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF7A60 Offset: 0xCF6060 VA: 0x180CF7A60
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF7C60 Offset: 0xCF6260 VA: 0x180CF7C60
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF7E60 Offset: 0xCF6460 VA: 0x180CF7E60
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF8060 Offset: 0xCF6660 VA: 0x180CF8060
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF8280 Offset: 0xCF6880 VA: 0x180CF8280
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF84B0 Offset: 0xCF6AB0 VA: 0x180CF84B0
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF86B0 Offset: 0xCF6CB0 VA: 0x180CF86B0
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF88D0 Offset: 0xCF6ED0 VA: 0x180CF88D0
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF8AD0 Offset: 0xCF70D0 VA: 0x180CF8AD0
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF8CD0 Offset: 0xCF72D0 VA: 0x180CF8CD0
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF8ED0 Offset: 0xCF74D0 VA: 0x180CF8ED0
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF90D0 Offset: 0xCF76D0 VA: 0x180CF90D0
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF92D0 Offset: 0xCF78D0 VA: 0x180CF92D0
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF94D0 Offset: 0xCF7AD0 VA: 0x180CF94D0
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF96F0 Offset: 0xCF7CF0 VA: 0x180CF96F0
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF9910 Offset: 0xCF7F10 VA: 0x180CF9910
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF9B30 Offset: 0xCF8130 VA: 0x180CF9B30
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF9D30 Offset: 0xCF8330 VA: 0x180CF9D30
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCF9F30 Offset: 0xCF8530 VA: 0x180CF9F30
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCFA150 Offset: 0xCF8750 VA: 0x180CFA150
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF77C0 Offset: 0xCF5DC0 VA: 0x180CF77C0
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x1AAACA0 Offset: 0x1AA92A0 VA: 0x181AAACA0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAC5E0 Offset: 0x1AAABE0 VA: 0x181AAC5E0
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AAB390 Offset: 0x1AA9990 VA: 0x181AAB390
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1AACD30 Offset: 0x1AAB330 VA: 0x181AACD30
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAA9D0 Offset: 0x1AA8FD0 VA: 0x181AAA9D0
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1AAAED0 Offset: 0x1AA94D0 VA: 0x181AAAED0
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC930 Offset: 0x1AAAF30 VA: 0x181AAC930
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAB500 Offset: 0x1AA9B00 VA: 0x181AAB500
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAAA90 Offset: 0x1AA9090 VA: 0x181AAAA90
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC730 Offset: 0x1AAAD30 VA: 0x181AAC730
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1AACEB0 Offset: 0x1AAB4B0 VA: 0x181AACEB0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAB030 Offset: 0x1AA9630 VA: 0x181AAB030
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AACC90 Offset: 0x1AAB290 VA: 0x181AACC90
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AAC7D0 Offset: 0x1AAADD0 VA: 0x181AAC7D0
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1AAC9F0 Offset: 0x1AAAFF0 VA: 0x181AAC9F0
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AABDD0 Offset: 0x1AAA3D0 VA: 0x181AABDD0
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1AAC1C0 Offset: 0x1AAA7C0 VA: 0x181AAC1C0
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1AAD000 Offset: 0x1AAB600 VA: 0x181AAD000
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1AABC70 Offset: 0x1AAA270 VA: 0x181AABC70
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1AAC100 Offset: 0x1AAA700 VA: 0x181AAC100
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB7B0 Offset: 0x1AA9DB0 VA: 0x181AAB7B0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAE10 Offset: 0x1AA9410 VA: 0x181AAAE10
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAC520 Offset: 0x1AAAB20 VA: 0x181AAC520
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1AAB440 Offset: 0x1AA9A40 VA: 0x181AAB440
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1AAAD50 Offset: 0x1AA9350 VA: 0x181AAAD50
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1AAC690 Offset: 0x1AAAC90 VA: 0x181AAC690
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1AABBB0 Offset: 0x1AAA1B0 VA: 0x181AABBB0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AACA90 Offset: 0x1AAB090 VA: 0x181AACA90
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1AAB700 Offset: 0x1AA9D00 VA: 0x181AAB700
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1AABFB0 Offset: 0x1AAA5B0 VA: 0x181AABFB0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1AAC310 Offset: 0x1AAA910 VA: 0x181AAC310
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1AAC050 Offset: 0x1AAA650 VA: 0x181AAC050
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAB0E0 Offset: 0x1AA96E0 VA: 0x181AAB0E0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAB860 Offset: 0x1AA9E60 VA: 0x181AAB860
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1AAC270 Offset: 0x1AAA870 VA: 0x181AAC270
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1AAB910 Offset: 0x1AA9F10 VA: 0x181AAB910
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1AAC470 Offset: 0x1AAAA70 VA: 0x181AAC470
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB9C0 Offset: 0x1AA9FC0 VA: 0x181AAB9C0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1AAB250 Offset: 0x1AA9850 VA: 0x181AAB250
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1AABE80 Offset: 0x1AAA480 VA: 0x181AABE80
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1AAA920 Offset: 0x1AA8F20 VA: 0x181AAA920
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AAAB40 Offset: 0x1AA9140 VA: 0x181AAAB40
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1AACF60 Offset: 0x1AAB560 VA: 0x181AACF60
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABB10 Offset: 0x1AAA110 VA: 0x181AABB10
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAAC00 Offset: 0x1AA9200 VA: 0x181AAAC00
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1AAC3C0 Offset: 0x1AAA9C0 VA: 0x181AAC3C0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1AAB5B0 Offset: 0x1AA9BB0 VA: 0x181AAB5B0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1AABA60 Offset: 0x1AAA060 VA: 0x181AABA60
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1AACB30 Offset: 0x1AAB130 VA: 0x181AACB30
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1AACDF0 Offset: 0x1AAB3F0 VA: 0x181AACDF0
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1AAB190 Offset: 0x1AA9790 VA: 0x181AAB190
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1AAB650 Offset: 0x1AA9C50 VA: 0x181AAB650
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1AACBF0 Offset: 0x1AAB1F0 VA: 0x181AACBF0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1AAC870 Offset: 0x1AAAE70 VA: 0x181AAC870
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1AAAF80 Offset: 0x1AA9580 VA: 0x181AAAF80
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1AABD30 Offset: 0x1AAA330 VA: 0x181AABD30
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

