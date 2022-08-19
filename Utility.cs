internal class Utility // TypeDefIndex: 4719
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBEA30 Offset: 0xEBD030 VA: 0x180EBEA30
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBE920 Offset: 0xEBCF20 VA: 0x180EBE920
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBE9C0 Offset: 0xEBCFC0 VA: 0x180EBE9C0
	internal static void RaiseFlushPendingResources() { }

	// RVA: 0xEBEAB0 Offset: 0xEBD0B0 VA: 0x180EBEAB0
	private static void .cctor() { }

}

public class Utility.GPUBuffer<T> // TypeDefIndex: 4720
{	// Fields
	private IntPtr buffer; // 0x0

}

public static class Utility // TypeDefIndex: 5272
{	// Fields
	private static readonly byte[] readBuffer; // 0x13850

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static T ToType<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4840 Offset: 0x5D2E40 VA: 0x1805D4840
	|-Utility.ToType<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0x5D4950 Offset: 0x5D2F50 VA: 0x1805D4950
	|-Utility.ToType<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0x5D4A60 Offset: 0x5D3060 VA: 0x1805D4A60
	|-Utility.ToType<ClientGameServerDeny_t>
	|
	|-RVA: 0x5D4B90 Offset: 0x5D3190 VA: 0x1805D4B90
	|-Utility.ToType<DownloadItemResult_t>
	|
	|-RVA: 0x5D4CE0 Offset: 0x5D32E0 VA: 0x1805D4CE0
	|-Utility.ToType<DurationControl_t>
	|
	|-RVA: 0x5D4E20 Offset: 0x5D3420 VA: 0x1805D4E20
	|-Utility.ToType<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0x5D4F50 Offset: 0x5D3550 VA: 0x1805D4F50
	|-Utility.ToType<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0x5D5090 Offset: 0x5D3690 VA: 0x1805D5090
	|-Utility.ToType<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0x5D51C0 Offset: 0x5D37C0 VA: 0x1805D51C0
	|-Utility.ToType<GameLobbyJoinRequested_t>
	|
	|-RVA: 0x5D52F0 Offset: 0x5D38F0 VA: 0x1805D52F0
	|-Utility.ToType<GameOverlayActivated_t>
	|
	|-RVA: 0x5D5400 Offset: 0x5D3A00 VA: 0x1805D5400
	|-Utility.ToType<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0x5D5530 Offset: 0x5D3B30 VA: 0x1805D5530
	|-Utility.ToType<GameServerChangeRequested_t>
	|
	|-RVA: 0x5D5660 Offset: 0x5D3C60 VA: 0x1805D5660
	|-Utility.ToType<GameWebCallback_t>
	|
	|-RVA: 0x5D5770 Offset: 0x5D3D70 VA: 0x1805D5770
	|-Utility.ToType<GamepadTextInputDismissed_t>
	|
	|-RVA: 0x5D5880 Offset: 0x5D3E80 VA: 0x1805D5880
	|-Utility.ToType<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0x5D5990 Offset: 0x5D3F90 VA: 0x1805D5990
	|-Utility.ToType<IPCountry_t>
	|
	|-RVA: 0x5D5AA0 Offset: 0x5D40A0 VA: 0x1805D5AA0
	|-Utility.ToType<ItemInstalled_t>
	|
	|-RVA: 0x5D5BD0 Offset: 0x5D41D0 VA: 0x1805D5BD0
	|-Utility.ToType<LicensesUpdated_t>
	|
	|-RVA: 0x5D5CE0 Offset: 0x5D42E0 VA: 0x1805D5CE0
	|-Utility.ToType<LobbyChatMsg_t>
	|
	|-RVA: 0x5D5E30 Offset: 0x5D4430 VA: 0x1805D5E30
	|-Utility.ToType<LobbyChatUpdate_t>
	|
	|-RVA: 0x5D5F70 Offset: 0x5D4570 VA: 0x1805D5F70
	|-Utility.ToType<LobbyCreated_t>
	|
	|-RVA: 0x5D60A0 Offset: 0x5D46A0 VA: 0x1805D60A0
	|-Utility.ToType<LobbyDataUpdate_t>
	|
	|-RVA: 0x5D61F0 Offset: 0x5D47F0 VA: 0x1805D61F0
	|-Utility.ToType<LobbyEnter_t>
	|
	|-RVA: 0x5D6340 Offset: 0x5D4940 VA: 0x1805D6340
	|-Utility.ToType<LobbyGameCreated_t>
	|
	|-RVA: 0x5D6490 Offset: 0x5D4A90 VA: 0x1805D6490
	|-Utility.ToType<LobbyInvite_t>
	|
	|-RVA: 0x5D65E0 Offset: 0x5D4BE0 VA: 0x1805D65E0
	|-Utility.ToType<LowBatteryPower_t>
	|
	|-RVA: 0x5D66F0 Offset: 0x5D4CF0 VA: 0x1805D66F0
	|-Utility.ToType<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0x5D6840 Offset: 0x5D4E40 VA: 0x1805D6840
	|-Utility.ToType<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0x5D6950 Offset: 0x5D4F50 VA: 0x1805D6950
	|-Utility.ToType<P2PSessionConnectFail_t>
	|
	|-RVA: 0x5D6A80 Offset: 0x5D5080 VA: 0x1805D6A80
	|-Utility.ToType<P2PSessionRequest_t>
	|
	|-RVA: 0x5D6B90 Offset: 0x5D5190 VA: 0x1805D6B90
	|-Utility.ToType<PersonaStateChange_t>
	|
	|-RVA: 0x5D6CC0 Offset: 0x5D52C0 VA: 0x1805D6CC0
	|-Utility.ToType<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0x5D6DD0 Offset: 0x5D53D0 VA: 0x1805D6DD0
	|-Utility.ToType<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0x5D6F00 Offset: 0x5D5500 VA: 0x1805D6F00
	|-Utility.ToType<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0x5D7140 Offset: 0x5D5740 VA: 0x1805D7140
	|-Utility.ToType<ScreenshotReady_t>
	|
	|-RVA: 0x5D7250 Offset: 0x5D5850 VA: 0x1805D7250
	|-Utility.ToType<ScreenshotRequested_t>
	|
	|-RVA: 0x5D7360 Offset: 0x5D5960 VA: 0x1805D7360
	|-Utility.ToType<SteamAPICallCompleted_t>
	|
	|-RVA: 0x5D7490 Offset: 0x5D5A90 VA: 0x1805D7490
	|-Utility.ToType<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0x5D75A0 Offset: 0x5D5BA0 VA: 0x1805D75A0
	|-Utility.ToType<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0x5D76B0 Offset: 0x5D5CB0 VA: 0x1805D76B0
	|-Utility.ToType<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0x5D7900 Offset: 0x5D5F00 VA: 0x1805D7900
	|-Utility.ToType<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0x5D7AD0 Offset: 0x5D60D0 VA: 0x1805D7AD0
	|-Utility.ToType<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0x5D7BE0 Offset: 0x5D61E0 VA: 0x1805D7BE0
	|-Utility.ToType<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0x5D7D30 Offset: 0x5D6330 VA: 0x1805D7D30
	|-Utility.ToType<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0x5D7E40 Offset: 0x5D6440 VA: 0x1805D7E40
	|-Utility.ToType<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0x5D7F50 Offset: 0x5D6550 VA: 0x1805D7F50
	|-Utility.ToType<SteamServerConnectFailure_t>
	|
	|-RVA: 0x5D8060 Offset: 0x5D6660 VA: 0x1805D8060
	|-Utility.ToType<SteamServersConnected_t>
	|
	|-RVA: 0x5D8170 Offset: 0x5D6770 VA: 0x1805D8170
	|-Utility.ToType<SteamServersDisconnected_t>
	|
	|-RVA: 0x5D8280 Offset: 0x5D6880 VA: 0x1805D8280
	|-Utility.ToType<SteamShutdown_t>
	|
	|-RVA: 0x5D8390 Offset: 0x5D6990 VA: 0x1805D8390
	|-Utility.ToType<UserAchievementIconFetched_t>
	|
	|-RVA: 0x5D84E0 Offset: 0x5D6AE0 VA: 0x1805D84E0
	|-Utility.ToType<UserAchievementStored_t>
	|
	|-RVA: 0x5D8620 Offset: 0x5D6C20 VA: 0x1805D8620
	|-Utility.ToType<UserStatsReceived_t>
	|
	|-RVA: 0x5D8760 Offset: 0x5D6D60 VA: 0x1805D8760
	|-Utility.ToType<UserStatsStored_t>
	|
	|-RVA: 0x5D8890 Offset: 0x5D6E90 VA: 0x1805D8890
	|-Utility.ToType<UserStatsUnloaded_t>
	|
	|-RVA: 0x5D89A0 Offset: 0x5D6FA0 VA: 0x1805D89A0
	|-Utility.ToType<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0x5D8AE0 Offset: 0x5D70E0 VA: 0x1805D8AE0
	|-Utility.ToType<VolumeHasChanged_t>
	|
	|-RVA: 0x5D8C00 Offset: 0x5D7200 VA: 0x1805D8C00
	|-Utility.ToType<gameserveritem_t>
	|
	|-RVA: 0x5D7030 Offset: 0x5D5630 VA: 0x1805D7030
	|-Utility.ToType<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E2120 Offset: 0x19E0720 VA: 0x1819E2120
	internal static object ToType(IntPtr ptr, Type t) { }

	// RVA: 0x19E20F0 Offset: 0x19E06F0 VA: 0x1819E20F0
	internal static uint Swap(uint x) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E1E10 Offset: 0x19E0410 VA: 0x1819E1E10
	public static uint IpToInt32(IPAddress ipAddress) { }

	// RVA: 0x19E1D70 Offset: 0x19E0370 VA: 0x1819E1D70
	public static IPAddress Int32ToIp(uint ipAddress) { }

	// RVA: 0x19E1260 Offset: 0x19DF860 VA: 0x1819E1260
	public static string FormatPrice(string currency, double price) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E1EA0 Offset: 0x19E04A0 VA: 0x1819E1EA0
	public static string ReadNullTerminatedUTF8String(BinaryReader br) { }

	// RVA: 0x19E21A0 Offset: 0x19E07A0 VA: 0x1819E21A0
	private static void .cctor() { }

}

