public static class Dispatch // TypeDefIndex: 5104
{	// Fields
	public static Action<CallbackType, string, bool> OnDebugCallback; // 0x0
	public static Action<Exception> OnException; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static HSteamPipe <ClientPipe>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static HSteamPipe <ServerPipe>k__BackingField; // 0x14
	private static bool runningFrame; // 0x18
	private static List<Action<IntPtr>> actionsToCall; // 0x20
	private static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks; // 0x28
	private static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks; // 0x30

	// Properties
	internal static HSteamPipe ClientPipe { get; set; }
	internal static HSteamPipe ServerPipe { get; }

	// Methods

	// RVA: 0x1284590 Offset: 0x1282B90 VA: 0x181284590
	internal static extern void SteamAPI_ManualDispatch_Init() { }

	// RVA: 0x1284600 Offset: 0x1282C00 VA: 0x181284600
	internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe) { }

	// RVA: 0x1284500 Offset: 0x1282B00 VA: 0x181284500
	internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, ref Dispatch.CallbackMsg_t msg) { }

	// RVA: 0x1284480 Offset: 0x1282A80 VA: 0x181284480
	internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1284770 Offset: 0x1282D70 VA: 0x181284770
	internal static HSteamPipe get_ClientPipe() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1284890 Offset: 0x1282E90 VA: 0x181284890
	internal static void set_ClientPipe(HSteamPipe value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x12847D0 Offset: 0x1282DD0 VA: 0x1812847D0
	internal static HSteamPipe get_ServerPipe() { }

	// RVA: 0x1283660 Offset: 0x1281C60 VA: 0x181283660
	internal static void Init() { }

	// RVA: 0x1283250 Offset: 0x1281850 VA: 0x181283250
	internal static void Frame(HSteamPipe pipe) { }

	// RVA: 0x1283790 Offset: 0x1281D90 VA: 0x181283790
	private static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer) { }

	// RVA: 0x1282EC0 Offset: 0x12814C0 VA: 0x181282EC0
	internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize) { }

	// RVA: 0x1283D90 Offset: 0x1282390 VA: 0x181283D90
	private static void ProcessResult(Dispatch.CallbackMsg_t msg) { }

	[AsyncStateMachineAttribute] // RVA: 0x8B340 Offset: 0x8A740 VA: 0x18008B340
	// RVA: 0x1283710 Offset: 0x1281D10 VA: 0x181283710
	internal static void LoopClientAsync() { }

	// RVA: -1 Offset: -1
	internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9BF0 Offset: 0xCF81F0 VA: 0x180CF9BF0
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCF9CC0 Offset: 0xCF82C0 VA: 0x180CF9CC0
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCF9D90 Offset: 0xCF8390 VA: 0x180CF9D90
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCF9E60 Offset: 0xCF8460 VA: 0x180CF9E60
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCF9F30 Offset: 0xCF8530 VA: 0x180CF9F30
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCFA000 Offset: 0xCF8600 VA: 0x180CFA000
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCFA0D0 Offset: 0xCF86D0 VA: 0x180CFA0D0
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	// RVA: -1 Offset: -1
	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2B20 Offset: 0xCF1120 VA: 0x180CF2B20
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCF2D20 Offset: 0xCF1320 VA: 0x180CF2D20
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCF2F20 Offset: 0xCF1520 VA: 0x180CF2F20
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCF3120 Offset: 0xCF1720 VA: 0x180CF3120
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCF3340 Offset: 0xCF1940 VA: 0x180CF3340
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCF3560 Offset: 0xCF1B60 VA: 0x180CF3560
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCF3760 Offset: 0xCF1D60 VA: 0x180CF3760
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCF3980 Offset: 0xCF1F80 VA: 0x180CF3980
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCF3B80 Offset: 0xCF2180 VA: 0x180CF3B80
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCF3D80 Offset: 0xCF2380 VA: 0x180CF3D80
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCF3F80 Offset: 0xCF2580 VA: 0x180CF3F80
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCF4180 Offset: 0xCF2780 VA: 0x180CF4180
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCF4380 Offset: 0xCF2980 VA: 0x180CF4380
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCF4580 Offset: 0xCF2B80 VA: 0x180CF4580
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCF4780 Offset: 0xCF2D80 VA: 0x180CF4780
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCF4980 Offset: 0xCF2F80 VA: 0x180CF4980
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCF4B80 Offset: 0xCF3180 VA: 0x180CF4B80
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCF4D80 Offset: 0xCF3380 VA: 0x180CF4D80
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCF4F80 Offset: 0xCF3580 VA: 0x180CF4F80
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF51A0 Offset: 0xCF37A0 VA: 0x180CF51A0
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF53C0 Offset: 0xCF39C0 VA: 0x180CF53C0
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF55C0 Offset: 0xCF3BC0 VA: 0x180CF55C0
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF57E0 Offset: 0xCF3DE0 VA: 0x180CF57E0
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF5A00 Offset: 0xCF4000 VA: 0x180CF5A00
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF5C20 Offset: 0xCF4220 VA: 0x180CF5C20
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF5E40 Offset: 0xCF4440 VA: 0x180CF5E40
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF6040 Offset: 0xCF4640 VA: 0x180CF6040
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF6260 Offset: 0xCF4860 VA: 0x180CF6260
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF6460 Offset: 0xCF4A60 VA: 0x180CF6460
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF6660 Offset: 0xCF4C60 VA: 0x180CF6660
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF6860 Offset: 0xCF4E60 VA: 0x180CF6860
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF6A60 Offset: 0xCF5060 VA: 0x180CF6A60
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF6C60 Offset: 0xCF5260 VA: 0x180CF6C60
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF6E60 Offset: 0xCF5460 VA: 0x180CF6E60
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF7100 Offset: 0xCF5700 VA: 0x180CF7100
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF7300 Offset: 0xCF5900 VA: 0x180CF7300
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF7500 Offset: 0xCF5B00 VA: 0x180CF7500
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF7700 Offset: 0xCF5D00 VA: 0x180CF7700
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF7900 Offset: 0xCF5F00 VA: 0x180CF7900
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF7B20 Offset: 0xCF6120 VA: 0x180CF7B20
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF7D50 Offset: 0xCF6350 VA: 0x180CF7D50
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF7F50 Offset: 0xCF6550 VA: 0x180CF7F50
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF8170 Offset: 0xCF6770 VA: 0x180CF8170
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF8370 Offset: 0xCF6970 VA: 0x180CF8370
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF8570 Offset: 0xCF6B70 VA: 0x180CF8570
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF8770 Offset: 0xCF6D70 VA: 0x180CF8770
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF8970 Offset: 0xCF6F70 VA: 0x180CF8970
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF8B70 Offset: 0xCF7170 VA: 0x180CF8B70
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF8D70 Offset: 0xCF7370 VA: 0x180CF8D70
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF8F90 Offset: 0xCF7590 VA: 0x180CF8F90
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF91B0 Offset: 0xCF77B0 VA: 0x180CF91B0
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF93D0 Offset: 0xCF79D0 VA: 0x180CF93D0
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF95D0 Offset: 0xCF7BD0 VA: 0x180CF95D0
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCF97D0 Offset: 0xCF7DD0 VA: 0x180CF97D0
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCF99F0 Offset: 0xCF7FF0 VA: 0x180CF99F0
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF7060 Offset: 0xCF5660 VA: 0x180CF7060
	|-Dispatch.Install<object>
	*/

	// RVA: 0x1283F20 Offset: 0x1282520 VA: 0x181283F20
	internal static void ShutdownClient() { }

	// RVA: 0x1284680 Offset: 0x1282C80 VA: 0x181284680
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

	// RVA: 0x12918E0 Offset: 0x128FEE0 VA: 0x1812918E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x12917C0 Offset: 0x128FDC0 VA: 0x1812917C0
	internal int <CallbackToString>b__20_0(FieldInfo x) { }

	// RVA: 0x12918C0 Offset: 0x128FEC0 VA: 0x1812918C0
	internal bool <ShutdownClient>b__31_3(Dispatch.Callback x) { }

	// RVA: 0x1291800 Offset: 0x128FE00 VA: 0x181291800
	internal bool <ShutdownClient>b__31_0(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	// RVA: 0x1291840 Offset: 0x128FE40 VA: 0x181291840
	internal ulong <ShutdownClient>b__31_1(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	// RVA: 0x1291880 Offset: 0x128FE80 VA: 0x181291880
	internal Dispatch.ResultCallback <ShutdownClient>b__31_2(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

}

private struct Dispatch.<LoopClientAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5109
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1DB220 Offset: 0x1DA620 VA: 0x1801DB220 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
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
	|-RVA: 0x1A50E30 Offset: 0x1A4F430 VA: 0x181A50E30
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A52770 Offset: 0x1A50D70 VA: 0x181A52770
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A51520 Offset: 0x1A4FB20 VA: 0x181A51520
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1A52EC0 Offset: 0x1A514C0 VA: 0x181A52EC0
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1A50B60 Offset: 0x1A4F160 VA: 0x181A50B60
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1A51060 Offset: 0x1A4F660 VA: 0x181A51060
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A52AC0 Offset: 0x1A510C0 VA: 0x181A52AC0
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A51690 Offset: 0x1A4FC90 VA: 0x181A51690
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A50C20 Offset: 0x1A4F220 VA: 0x181A50C20
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A528C0 Offset: 0x1A50EC0 VA: 0x181A528C0
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1A53040 Offset: 0x1A51640 VA: 0x181A53040
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A511C0 Offset: 0x1A4F7C0 VA: 0x181A511C0
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A52E20 Offset: 0x1A51420 VA: 0x181A52E20
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A52960 Offset: 0x1A50F60 VA: 0x181A52960
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1A52B80 Offset: 0x1A51180 VA: 0x181A52B80
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A51F60 Offset: 0x1A50560 VA: 0x181A51F60
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1A52350 Offset: 0x1A50950 VA: 0x181A52350
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1A53190 Offset: 0x1A51790 VA: 0x181A53190
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A51E00 Offset: 0x1A50400 VA: 0x181A51E00
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A52290 Offset: 0x1A50890 VA: 0x181A52290
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A51940 Offset: 0x1A4FF40 VA: 0x181A51940
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A50FA0 Offset: 0x1A4F5A0 VA: 0x181A50FA0
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A526B0 Offset: 0x1A50CB0 VA: 0x181A526B0
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1A515D0 Offset: 0x1A4FBD0 VA: 0x181A515D0
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A50EE0 Offset: 0x1A4F4E0 VA: 0x181A50EE0
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1A52820 Offset: 0x1A50E20 VA: 0x181A52820
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1A51D40 Offset: 0x1A50340 VA: 0x181A51D40
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A52C20 Offset: 0x1A51220 VA: 0x181A52C20
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1A51890 Offset: 0x1A4FE90 VA: 0x181A51890
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1A52140 Offset: 0x1A50740 VA: 0x181A52140
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1A524A0 Offset: 0x1A50AA0 VA: 0x181A524A0
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1A521E0 Offset: 0x1A507E0 VA: 0x181A521E0
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A51270 Offset: 0x1A4F870 VA: 0x181A51270
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A519F0 Offset: 0x1A4FFF0 VA: 0x181A519F0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A52400 Offset: 0x1A50A00 VA: 0x181A52400
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1A51AA0 Offset: 0x1A500A0 VA: 0x181A51AA0
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A52600 Offset: 0x1A50C00 VA: 0x181A52600
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A51B50 Offset: 0x1A50150 VA: 0x181A51B50
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A513E0 Offset: 0x1A4F9E0 VA: 0x181A513E0
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A52010 Offset: 0x1A50610 VA: 0x181A52010
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1A50AB0 Offset: 0x1A4F0B0 VA: 0x181A50AB0
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A50CD0 Offset: 0x1A4F2D0 VA: 0x181A50CD0
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1A530F0 Offset: 0x1A516F0 VA: 0x181A530F0
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51CA0 Offset: 0x1A502A0 VA: 0x181A51CA0
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A50D90 Offset: 0x1A4F390 VA: 0x181A50D90
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1A52550 Offset: 0x1A50B50 VA: 0x181A52550
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51740 Offset: 0x1A4FD40 VA: 0x181A51740
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A51BF0 Offset: 0x1A501F0 VA: 0x181A51BF0
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1A52CC0 Offset: 0x1A512C0 VA: 0x181A52CC0
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1A52F80 Offset: 0x1A51580 VA: 0x181A52F80
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1A51320 Offset: 0x1A4F920 VA: 0x181A51320
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1A517E0 Offset: 0x1A4FDE0 VA: 0x181A517E0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1A52D80 Offset: 0x1A51380 VA: 0x181A52D80
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1A52A00 Offset: 0x1A51000 VA: 0x181A52A00
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A51110 Offset: 0x1A4F710 VA: 0x181A51110
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A51EC0 Offset: 0x1A504C0 VA: 0x181A51EC0
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

